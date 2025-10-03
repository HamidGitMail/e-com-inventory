using Microsoft.AspNetCore.Mvc;
using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;

namespace ECom.Api.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : GenericController<Accounts>
    {
        public AccountsController(IAccountsService service) : base(service) { }
    }
}