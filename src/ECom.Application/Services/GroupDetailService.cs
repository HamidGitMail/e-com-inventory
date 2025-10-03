using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class GroupDetailService : GenericService<GroupDetail>, IGroupDetailService
    {
        public GroupDetailService(GroupDetailRepository repository) : base(repository) { }
    }
}