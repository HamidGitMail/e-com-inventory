namespace HCS_Inventory_Api.Services;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using HCS_Inventory_Api.Models;
using HCS_Inventory_Api.Models.DTOs;
using HCS_Inventory_Api.Repositories;
using BCrypt.Net;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IConfiguration _configuration;

    public AuthService(IUserRepository userRepository, IConfiguration configuration)
    {
        _userRepository = userRepository;
        _configuration = configuration;
    }

    public async Task<AuthResponseDto?> LoginAsync(LoginDto loginDto)
    {
        var user = await _userRepository.GetByLoginNameAsync(loginDto.LoginName);
        
        if (user == null || !BCrypt.Verify(loginDto.Password, user.LoginPassword))
        {
            return null;
        }

        return GenerateToken(user);
    }

    public async Task<AuthResponseDto?> RegisterAsync(RegisterDto registerDto)
    {
        if (await _userRepository.UserExistsAsync(registerDto.LoginName))
        {
            return null;
        }

        var user = new User
        {
            LoginName = registerDto.LoginName,
            LoginPassword = BCrypt.HashPassword(registerDto.Password),
            ShopName = registerDto.ShopName,
            ShopEmail = registerDto.ShopEmail,
            ShopPhone = registerDto.ShopPhone,
            CreatedOn = DateTime.UtcNow,
            LastUpdated = DateTime.UtcNow,
            IsDistributor = false
        };

        var created = await _userRepository.CreateUserAsync(user);
        
        if (!created)
        {
            return null;
        }

        return GenerateToken(user);
    }

    private AuthResponseDto GenerateToken(User user)
    {
        var jwtSettings = _configuration.GetSection("Jwt");
        var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]!);
        var expiryInMinutes = int.Parse(jwtSettings["ExpiryInMinutes"]!);
        var expiresAt = DateTime.UtcNow.AddMinutes(expiryInMinutes);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.LoginName),
                new Claim(ClaimTypes.Email, user.ShopEmail ?? ""),
                new Claim("IsDistributor", user.IsDistributor.ToString())
            }),
            Expires = expiresAt,
            Issuer = jwtSettings["Issuer"],
            Audience = jwtSettings["Audience"],
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        return new AuthResponseDto
        {
            Token = tokenString,
            LoginName = user.LoginName,
            ExpiresAt = expiresAt
        };
    }
}