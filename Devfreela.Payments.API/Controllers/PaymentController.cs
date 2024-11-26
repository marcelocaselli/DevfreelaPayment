using Devfreela.Payments.API.Models;
using Devfreela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devfreela.Payments.API.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _service;
        public PaymentController(IPaymentService service)
        {
            _service = service;
            
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(PaymentInfoInputModel model)
        {
            var result = await _service.Proccess(model);

            if (!result)
            {
                return BadRequest();
            }

            return NoContent();
        }

    }
}
