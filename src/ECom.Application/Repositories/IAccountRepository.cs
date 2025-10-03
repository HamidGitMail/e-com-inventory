namespace ECom.Application.Repositories
{
    // Compatibility interface: some files reference singular IAccountRepository
    // Implement as a thin alias so both IAccountsRepository and IAccountRepository can be used.
    public interface IAccountRepository : IAccountsRepository
    {
    }
}