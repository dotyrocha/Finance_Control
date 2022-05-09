using FinanceControl.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinanceControl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly CreditCardService _creditCardService;
        public CreditCardController()
        {
            _creditCardService = new CreditCardService();
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Credit", "Card" };
        }



        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

    }
}  