using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class StoreReconcilationService : GenericService<StoreReconcilation>, IStoreReconcilationService
    {
        public StoreReconcilationService(StoreReconcilationRepository repository) : base(repository) { }
    }
}