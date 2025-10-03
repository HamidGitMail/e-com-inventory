using ECom.Application.Services.Interfaces;
using ECom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentDetailsController : GenericController<PaymentDetails>
    {
        public PaymentDetailsController(IPaymentDetailsService service) : base(service) { }
    }
}