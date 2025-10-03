using ECom.Application.Repositories;
using ECom.Data;

namespace ECom.Infrastructure.Repositories
{
    // Compatibility adapter to satisfy references to AccountRepository (singular).
    // It simply inherits the correct AccountsRepository implementation.
    public class AccountRepository : AccountsRepository, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context) : base(context) { }
    }
}