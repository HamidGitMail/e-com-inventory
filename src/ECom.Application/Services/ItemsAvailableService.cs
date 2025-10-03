using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class ItemsAvailableService : GenericService<ItemsAvailable>, IItemsAvailableService
    {
        public ItemsAvailableService(ItemsAvailableRepository repository) : base(repository) { }
    }
}