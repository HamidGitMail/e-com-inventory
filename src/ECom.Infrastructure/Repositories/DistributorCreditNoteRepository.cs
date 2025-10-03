using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class DistributorCreditNoteRepository : GenericRepository<DistributorCreditNote>, IDistributorCreditNoteRepository
    {
        public DistributorCreditNoteRepository(ApplicationDbContext context) : base(context) { }
    }
}