using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillsController : GenericController<Bills>
    {
        public BillsController(IBillsService service) : base(service) { }
    }
}