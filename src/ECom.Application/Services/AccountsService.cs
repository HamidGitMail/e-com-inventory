using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class AccountsService : GenericService<Accounts>, IAccountsService
    {
        public AccountsService(AccountsRepository repository) : base(repository) { }
    }
}