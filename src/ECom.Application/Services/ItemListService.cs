using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class ItemListService : GenericService<ItemList>, IItemListService
    {
        public ItemListService(ItemListRepository repository) : base(repository) { }
    }
}