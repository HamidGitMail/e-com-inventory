using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class ExpenseLogService : GenericService<ExpenseLog>, IExpenseLogService
    {
        public ExpenseLogService(ExpenseLogRepository repository) : base(repository) { }
    }
}