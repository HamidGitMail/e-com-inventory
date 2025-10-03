using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class QuickCustomerNoteRepository : GenericRepository<QuickCustomerNote>, IQuickCustomerNoteRepository
    {
        public QuickCustomerNoteRepository(ApplicationDbContext context) : base(context) { }
    }
}