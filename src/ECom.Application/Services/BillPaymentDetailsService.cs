using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class BillPaymentDetailsService : GenericService<BillPaymentDetails>, IBillPaymentDetailsService
    {
        public BillPaymentDetailsService(BillPaymentDetailsRepository repository) : base(repository) { }
    }
}