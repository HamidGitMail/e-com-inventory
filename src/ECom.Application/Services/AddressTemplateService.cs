using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class AddressTemplateService : GenericService<AddressTemplate>, IAddressTemplateService
    {
        public AddressTemplateService(AddressTemplateRepository repository) : base(repository) { }
    }
}