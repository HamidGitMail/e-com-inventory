using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class PaymentsRepository : GenericRepository<Payments>, IPaymentsRepository
    {
        public PaymentsRepository(ApplicationDbContext context) : base(context) { }
    }
}