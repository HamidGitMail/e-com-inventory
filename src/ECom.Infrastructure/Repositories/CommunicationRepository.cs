using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class CommunicationRepository : GenericRepository<Communication>, ICommunicationRepository
    {
        public CommunicationRepository(ApplicationDbContext context) : base(context) { }
    }
}