using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class CustomerCreditNoteRepository : GenericRepository<CustomerCreditNote>, ICustomerCreditNoteRepository
    {
        public CustomerCreditNoteRepository(ApplicationDbContext context) : base(context) { }
    }
}