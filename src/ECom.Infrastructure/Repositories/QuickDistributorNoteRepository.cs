using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class QuickDistributorNoteRepository : GenericRepository<QuickDistributorNote>, IQuickDistributorNoteRepository
    {
        public QuickDistributorNoteRepository(ApplicationDbContext context) : base(context) { }
    }
}