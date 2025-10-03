using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class BillDetailsService : GenericService<BillDetails>, IBillDetailsService
    {
        public BillDetailsService(BillDetailsRepository repository) : base(repository) { }
    }
}