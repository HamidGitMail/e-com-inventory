using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class FiltersRepository : GenericRepository<Filters>, IFiltersRepository
    {
        public FiltersRepository(ApplicationDbContext context) : base(context) { }
    }
}