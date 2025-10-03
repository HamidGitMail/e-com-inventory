using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class DistributorCreditNoteService : GenericService<DistributorCreditNote>, IDistributorCreditNoteService
    {
        public DistributorCreditNoteService(DistributorCreditNoteRepository repository) : base(repository) { }
    }
}