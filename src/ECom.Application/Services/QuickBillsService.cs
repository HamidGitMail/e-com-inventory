using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class QuickBillsService : GenericService<QuickBills>, IQuickBillsService
    {
        public QuickBillsService(QuickBillsRepository repository) : base(repository) { }
    }
}