using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class DistributorItemControlService : GenericService<DistributorItemControl>, IDistributorItemControlService
    {
        public DistributorItemControlService(DistributorItemControlRepository repository) : base(repository) { }
    }
}