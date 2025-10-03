using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class QuickCustomerNoteService : GenericService<QuickCustomerNote>, IQuickCustomerNoteService
    {
        public QuickCustomerNoteService(QuickCustomerNoteRepository repository) : base(repository) { }
    }
}