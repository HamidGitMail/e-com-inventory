using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class GroupsService : GenericService<Groups>, IGroupsService
    {
        public GroupsService(GroupsRepository repository) : base(repository) { }
    }
}