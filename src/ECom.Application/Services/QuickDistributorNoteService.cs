using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class QuickDistributorNoteService : GenericService<QuickDistributorNote>, IQuickDistributorNoteService
    {
        public QuickDistributorNoteService(QuickDistributorNoteRepository repository) : base(repository) { }
    }
}