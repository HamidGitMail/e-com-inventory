using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class BillsService : GenericService<Bills>, IBillsService
    {
        public BillsService(BillsRepository repository) : base(repository) { }
    }
}