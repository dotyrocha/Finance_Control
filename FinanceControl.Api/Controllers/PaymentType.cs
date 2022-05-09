using FinanceControl.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinanceControl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController : ControllerBase
    {
        private readonly PaymentTypeService _paymentTypeService;
        public PaymentTypeController()
        {
            _paymentTypeService = new PaymentTypeService();
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Payment", "Service" };
        }



        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

    }
}  