using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class BillsRepository : GenericRepository<Bills>, IBillsRepository
    {
        public BillsRepository(ApplicationDbContext context) : base(context) { }

        // Bills has a composite key (BillNumber + Account_ID) in your schema. Provide explicit methods.
        public async Task<Bills> GetByIdAsync(string billNumber, string accountId)
        {
            // Use FindAsync with composite key values in the correct order
            return await _dbSet.FindAsync(billNumber, accountId);
        }

        public async Task DeleteAsync(string billNumber, string accountId)
        {
            var entity = await GetByIdAsync(billNumber, accountId);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}