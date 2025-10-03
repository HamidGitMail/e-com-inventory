using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class QuickInvoicesRepository : GenericRepository<QuickInvoices>, IQuickInvoicesRepository
    {
        public QuickInvoicesRepository(ApplicationDbContext context) : base(context) { }
    }
}