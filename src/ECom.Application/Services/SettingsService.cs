using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class SettingsService : GenericService<Settings>, ISettingsService
    {
        public SettingsService(SettingsRepository repository) : base(repository) { }
    }
}