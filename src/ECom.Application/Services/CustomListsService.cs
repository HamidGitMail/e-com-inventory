using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class CustomListsService : GenericService<CustomLists>, ICustomListsService
    {
        public CustomListsService(CustomListsRepository repository) : base(repository) { }
    }
}