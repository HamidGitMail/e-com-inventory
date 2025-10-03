using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    // Repository implementation for CustomLists
    public class CustomListsRepository : GenericRepository<CustomLists>, ICustomListsRepository
    {
        public CustomListsRepository(ApplicationDbContext context) : base(context) { }
    }
}