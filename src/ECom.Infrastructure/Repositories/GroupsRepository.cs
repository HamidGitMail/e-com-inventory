using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class GroupsRepository : GenericRepository<Groups>, IGroupsRepository
    {
        public GroupsRepository(ApplicationDbContext context) : base(context) { }
    }
}