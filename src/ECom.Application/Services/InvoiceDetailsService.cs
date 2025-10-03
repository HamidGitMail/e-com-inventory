using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    // Concrete service for InvoiceDetails that reuses GenericService
    public class InvoiceDetailsService : GenericService<InvoiceDetails>, IInvoiceDetailsService
    {
        public InvoiceDetailsService(InvoiceDetailsRepository repository) : base(repository) { }
    }
}