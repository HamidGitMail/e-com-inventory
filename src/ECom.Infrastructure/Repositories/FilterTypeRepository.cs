using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class FilterTypeRepository : GenericRepository<FilterType>, IFilterTypeRepository
    {
        public FilterTypeRepository(ApplicationDbContext context) : base(context) { }
    }
}