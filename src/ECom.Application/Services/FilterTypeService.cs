using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class FilterTypeService : GenericService<FilterType>, IFilterTypeService
    {
        public FilterTypeService(FilterTypeRepository repository) : base(repository) { }
    }
}