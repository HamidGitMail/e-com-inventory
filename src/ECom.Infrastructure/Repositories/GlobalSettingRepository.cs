using ECom.Application.Repositories;
using ECom.Data;
using ECom.Domain.Models;

namespace ECom.Infrastructure.Repositories
{
    public class GlobalSettingRepository : GenericRepository<GlobalSetting>, IGlobalSettingRepository
    {
        public GlobalSettingRepository(ApplicationDbContext context) : base(context) { }
    }
}