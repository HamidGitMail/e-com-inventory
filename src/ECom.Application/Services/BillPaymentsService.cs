using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class BillPaymentsService : GenericService<BillPayments>, IBillPaymentsService
    {
        public BillPaymentsService(BillPaymentsRepository repository) : base(repository) { }
    }
}