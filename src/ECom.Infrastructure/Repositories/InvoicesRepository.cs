using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class InvoicesRepository : GenericRepository<Invoices>, IInvoicesRepository
    {
        public InvoicesRepository(ApplicationDbContext context) : base(context) { }
    }
}