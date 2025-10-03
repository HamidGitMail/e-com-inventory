using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class DistributorItemControlRepository : GenericRepository<DistributorItemControl>, IDistributorItemControlRepository
    {
        public DistributorItemControlRepository(ApplicationDbContext context) : base(context) { }
    }
}