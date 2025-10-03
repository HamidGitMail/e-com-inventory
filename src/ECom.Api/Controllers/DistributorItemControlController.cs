using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistributorItemControlController : GenericController<DistributorItemControl>
    {
        public DistributorItemControlController(IDistributorItemControlService service) : base(service) { }
    }
}