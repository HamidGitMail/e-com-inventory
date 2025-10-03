using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class GlobalSettingService : GenericService<GlobalSetting>, IGlobalSettingService
    {
        public GlobalSettingService(GlobalSettingRepository repository) : base(repository) { }
    }
}