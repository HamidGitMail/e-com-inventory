using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class ItemPricesAndTaxesService : GenericService<ItemPricesAndTaxes>, IItemPricesAndTaxesService
    {
        public ItemPricesAndTaxesService(ItemPricesAndTaxesRepository repository) : base(repository) { }
    }
}