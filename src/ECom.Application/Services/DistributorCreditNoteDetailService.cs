using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class DistributorCreditNoteDetailService : GenericService<DistributorCreditNoteDetail>, IDistributorCreditNoteDetailService
    {
        public DistributorCreditNoteDetailService(DistributorCreditNoteDetailRepository repository) : base(repository) { }
    }
}