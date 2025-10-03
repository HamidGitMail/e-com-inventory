using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class PaymentDetailsRepository : GenericRepository<PaymentDetails>, IPaymentDetailsRepository
    {
        public PaymentDetailsRepository(ApplicationDbContext context) : base(context) { }
    }
}