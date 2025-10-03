using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class PaymentDetailsService : GenericService<PaymentDetails>, IPaymentDetailsService
    {
        public PaymentDetailsService(PaymentDetailsRepository repository) : base(repository) { }
    }
}