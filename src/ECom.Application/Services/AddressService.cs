using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class AddressService : GenericService<Address>, IAddressService
    {
        public AddressService(AddressRepository repository) : base(repository) { }
    }
}