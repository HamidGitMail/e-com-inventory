using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class CommunicationService : GenericService<Communication>, ICommunicationService
    {
        public CommunicationService(CommunicationRepository repository) : base(repository) { }
    }
}