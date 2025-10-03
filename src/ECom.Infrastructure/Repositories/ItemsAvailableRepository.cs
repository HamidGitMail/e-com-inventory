using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class ItemsAvailableRepository : GenericRepository<ItemsAvailable>, IItemsAvailableRepository
    {
        public ItemsAvailableRepository(ApplicationDbContext context) : base(context) { }
    }
}