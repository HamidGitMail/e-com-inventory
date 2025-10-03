using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class CustomerCreditNoteService : GenericService<CustomerCreditNote>, ICustomerCreditNoteService
    {
        public CustomerCreditNoteService(CustomerCreditNoteRepository repository) : base(repository) { }
    }
}