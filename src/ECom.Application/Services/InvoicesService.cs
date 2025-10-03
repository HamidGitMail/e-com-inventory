using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class InvoicesService : GenericService<Invoices>, IInvoicesService
    {
        public InvoicesService(InvoicesRepository repository) : base(repository) { }
    }
}