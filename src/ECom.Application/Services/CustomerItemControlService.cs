using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class CustomerItemControlService : GenericService<CustomerItemControl>, ICustomerItemControlService
    {
        public CustomerItemControlService(CustomerItemControlRepository repository) : base(repository) { }
    }
}