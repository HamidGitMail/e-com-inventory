namespace ECom.Application.Services
{
    // Simple authentication service interface used by some files. Provide a minimal contract.
    public interface IAuthService
    {
        Task<bool> ValidateCredentialsAsync(string username, string password);
    }
}