using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class ItemListRepository : GenericRepository<ItemList>, IItemListRepository
    {
        public ItemListRepository(ApplicationDbContext context) : base(context) { }
    }
}