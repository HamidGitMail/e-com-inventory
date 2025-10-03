using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class BillPaymentDetailsRepository : GenericRepository<BillPaymentDetails>, IBillPaymentDetailsRepository
    {
        public BillPaymentDetailsRepository(ApplicationDbContext context) : base(context) { }
    }
}