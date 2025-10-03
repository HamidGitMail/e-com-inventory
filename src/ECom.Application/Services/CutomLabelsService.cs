using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class CutomLabelsService : GenericService<CutomLabels>, ICutomLabelsService
    {
        public CutomLabelsService(CutomLabelsRepository repository) : base(repository) { }
    }
}