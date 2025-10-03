using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class AddressTemplateRepository : GenericRepository<AddressTemplate>, IAddressTemplateRepository
    {
        public AddressTemplateRepository(ApplicationDbContext context) : base(context) { }

        // Provide strongly-typed signatures expected by the interface
        public async Task<AddressTemplate> GetByIdAsync(string addressName)
        {
            return await base.GetByIdAsync(addressName);
        }

        public async Task DeleteAsync(string addressName)
        {
            await base.DeleteAsync(addressName);
        }
    }
}