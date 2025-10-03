using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class CutomLabelsRepository : GenericRepository<CutomLabels>, ICutomLabelsRepository
    {
        public CutomLabelsRepository(ApplicationDbContext context) : base(context) { }
    }
}