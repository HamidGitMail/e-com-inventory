using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class DistributorCreditNoteDetailRepository : GenericRepository<DistributorCreditNoteDetail>, IDistributorCreditNoteDetailRepository
    {
        public DistributorCreditNoteDetailRepository(ApplicationDbContext context) : base(context) { }
    }
}