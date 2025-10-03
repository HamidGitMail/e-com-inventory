using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class QuickBillsRepository : GenericRepository<QuickBills>, IQuickBillsRepository
    {
        public QuickBillsRepository(ApplicationDbContext context) : base(context) { }
    }
}