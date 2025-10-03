using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    // Repository implementation for ExpenseCodes (GenericRepository-based)
    public class ExpenseCodesRepository : GenericRepository<ExpenseCodes>, IExpenseCodesRepository
    {
        public ExpenseCodesRepository(ApplicationDbContext context) : base(context) { }
    }
}