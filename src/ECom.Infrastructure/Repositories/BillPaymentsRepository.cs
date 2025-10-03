using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class BillPaymentsRepository : GenericRepository<BillPayments>, IBillPaymentsRepository
    {
        public BillPaymentsRepository(ApplicationDbContext context) : base(context) { }
    }
}