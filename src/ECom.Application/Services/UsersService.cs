using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class UsersService : GenericService<Users>, IUsersService
    {
        public UsersService(UsersRepository repository) : base(repository) { }
    }
}