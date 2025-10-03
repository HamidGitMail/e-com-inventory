using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class PaymentsService : GenericService<Payments>, IPaymentsService
    {
        public PaymentsService(PaymentsRepository repository) : base(repository) { }
    }
}