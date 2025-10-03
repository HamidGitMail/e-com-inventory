using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class CustomerCreditNoteDetailsService : GenericService<CustomerCreditNoteDetails>, ICustomerCreditNoteDetailsService
    {
        public CustomerCreditNoteDetailsService(CustomerCreditNoteDetailsRepository repository) : base(repository) { }
    }
}