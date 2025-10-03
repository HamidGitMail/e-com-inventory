using ECom.Application.Repositories;
using ECom.Data;

namespace ECom.Infrastructure.Repositories
{
    // Compatibility adapter: singular named repository
    public class UserRepository : UsersRepository, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }
    }
}