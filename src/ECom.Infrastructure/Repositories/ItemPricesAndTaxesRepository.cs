using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class ItemPricesAndTaxesRepository : GenericRepository<ItemPricesAndTaxes>, IItemPricesAndTaxesRepository
    {
        public ItemPricesAndTaxesRepository(ApplicationDbContext context) : base(context) { }
    }
}