using ECom.Application.Services.Interfaces;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class VersionService : GenericService<Version>, IVersionService
    {
        public VersionService(VersionRepository repository) : base(repository) { }
    }
}