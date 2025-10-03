using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class InvoiceDetailsRepository : GenericRepository<InvoiceDetails>, IInvoiceDetailsRepository
    {
        public InvoiceDetailsRepository(ApplicationDbContext context) : base(context) { }
    }
}