using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FiltersController : GenericController<Filters>
    {
        public FiltersController(IFiltersService service) : base(service) { }
    }
}