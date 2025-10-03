namespace ECom.Application.Services
{
    public class AuthService : IAuthService
    {
        public Task<bool> ValidateCredentialsAsync(string username, string password)
        {
            // stubbed validation: replace with real logic
            return Task.FromResult(true);
        }
    }
}