using ECom.Data;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Infrastructure.Repositories
{
    public class AccountsRepository : GenericRepository<Accounts>, ECom.Application.Repositories.IAccountsRepository
    {
        public AccountsRepository(ApplicationDbContext context) : base(context) { }
    }
}