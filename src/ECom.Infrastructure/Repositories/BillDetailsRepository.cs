using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class BillDetailsRepository : GenericRepository<BillDetails>, IBillDetailsRepository
    {
        public BillDetailsRepository(ApplicationDbContext context) : base(context) { }
    }
}