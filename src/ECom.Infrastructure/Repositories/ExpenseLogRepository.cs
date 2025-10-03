using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class ExpenseLogRepository : GenericRepository<ExpenseLog>, IExpenseLogRepository
    {
        public ExpenseLogRepository(ApplicationDbContext context) : base(context) { }
    }
}