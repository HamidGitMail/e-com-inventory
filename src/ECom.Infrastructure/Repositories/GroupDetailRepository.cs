using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class GroupDetailRepository : GenericRepository<GroupDetail>, IGroupDetailRepository
    {
        public GroupDetailRepository(ApplicationDbContext context) : base(context) { }
    }
}