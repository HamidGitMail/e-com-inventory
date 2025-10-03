using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class AddressRepository : GenericRepository<Address>, ECom.Application.Repositories.IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context) { }
    }
}
