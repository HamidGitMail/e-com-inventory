using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class FiltersService : GenericService<Filters>, IFiltersService
    {
        public FiltersService(FiltersRepository repository) : base(repository) { }
    }
}