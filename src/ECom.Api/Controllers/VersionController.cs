using ECom.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionController : GenericController<Version>
    {
        public VersionController(IVersionService service) : base(service) { }
    }
}