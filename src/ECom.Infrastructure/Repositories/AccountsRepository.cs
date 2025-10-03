using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    // Concrete repository for Accounts. Implements the interface signatures that expect string ids.
    public class AccountsRepository : GenericRepository<Accounts>, IAccountsRepository
    {
        public AccountsRepository(ApplicationDbContext context) : base(context) { }

        // Provide the strongly-typed GetByIdAsync expected by some interfaces:
        public async Task<Accounts> GetByIdAsync(string id)
        {
            // reuse generic FindAsync via base.GetByIdAsync
            return await base.GetByIdAsync(id);
        }

        public async Task DeleteAsync(string id)
        {
            await base.DeleteAsync(id);
        }
    }
}