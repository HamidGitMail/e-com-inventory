namespace HCS_Inventory_Api.Repositories;

using Dapper;
using MySql.Data.MySqlClient;
using HCS_Inventory_Api.Models;

public class UserRepository : IUserRepository
{
    private readonly MySqlConnection _connection;

    public UserRepository(MySqlConnection connection)
    {
        _connection = connection;
    }

    public async Task<User?> GetByLoginNameAsync(string loginName)
    {
        const string sql = @"
            SELECT * FROM Users 
            WHERE LoginName = @LoginName";

        return await _connection.QueryFirstOrDefaultAsync<User>(sql, new { LoginName = loginName });
    }

    public async Task<bool> CreateUserAsync(User user)
    {
        const string sql = @"
            INSERT INTO Users (
                LoginName, LoginPassword, ShopName, ShopEmail, ShopPhone, 
                CreatedOn, LastUpdated, IsDistributor
            ) VALUES (
                @LoginName, @LoginPassword, @ShopName, @ShopEmail, @ShopPhone,
                @CreatedOn, @LastUpdated, @IsDistributor
            )";

        var result = await _connection.ExecuteAsync(sql, user);
        return result > 0;
    }

    public async Task<bool> UserExistsAsync(string loginName)
    {
        const string sql = "SELECT COUNT(1) FROM Users WHERE LoginName = @LoginName";
        var count = await _connection.ExecuteScalarAsync<int>(sql, new { LoginName = loginName });
        return count > 0;
    }
}