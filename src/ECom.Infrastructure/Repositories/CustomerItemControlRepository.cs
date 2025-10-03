using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class CustomerItemControlRepository : GenericRepository<CustomerItemControl>, ICustomerItemControlRepository
    {
        public CustomerItemControlRepository(ApplicationDbContext context) : base(context) { }
    }
}