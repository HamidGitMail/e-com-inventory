using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context) { }

        // Interface expects int id signatures in some places; provide them
        public async Task<Address> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await base.DeleteAsync(id);
        }
    }
}