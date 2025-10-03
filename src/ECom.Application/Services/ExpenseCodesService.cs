using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class ExpenseCodesService : GenericService<ExpenseCodes>, IExpenseCodesService
    {
        public ExpenseCodesService(ExpenseCodesRepository repository) : base(repository) { }
    }
}