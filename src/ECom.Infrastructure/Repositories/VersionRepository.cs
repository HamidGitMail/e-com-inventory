using ECom.Application.Repositories;
using ECom.Data;

namespace ECom.Infrastructure.Repositories
{
    public class VersionRepository : GenericRepository<Version>, IVersionRepository
    {
        public VersionRepository(ApplicationDbContext context) : base(context) { }
    }
}