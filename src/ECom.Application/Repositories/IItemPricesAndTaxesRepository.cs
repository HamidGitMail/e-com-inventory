using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IItemPricesAndTaxesRepository
    {
        Task<ItemPricesAndTaxes> GetByIdAsync(object id);
        Task<IEnumerable<ItemPricesAndTaxes>> ListAsync();
        Task AddAsync(ItemPricesAndTaxes entity);
        Task UpdateAsync(ItemPricesAndTaxes entity);
        Task DeleteAsync(object id);
    }
}