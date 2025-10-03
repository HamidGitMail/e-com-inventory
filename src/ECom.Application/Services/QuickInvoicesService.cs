using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class QuickInvoicesService : GenericService<QuickInvoices>, IQuickInvoicesService
    {
        public QuickInvoicesService(QuickInvoicesRepository repository) : base(repository) { }
    }
}