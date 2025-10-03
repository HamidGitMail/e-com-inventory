using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class StoreReconcilationRepository : GenericRepository<StoreReconcilation>, IStoreReconcilationRepository
    {
        public StoreReconcilationRepository(ApplicationDbContext context) : base(context) { }
    }
}