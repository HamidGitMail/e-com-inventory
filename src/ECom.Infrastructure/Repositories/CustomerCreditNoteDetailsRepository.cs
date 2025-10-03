using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class CustomerCreditNoteDetailsRepository : GenericRepository<CustomerCreditNoteDetails>, ICustomerCreditNoteDetailsRepository
    {
        public CustomerCreditNoteDetailsRepository(ApplicationDbContext context) : base(context) { }
    }
}