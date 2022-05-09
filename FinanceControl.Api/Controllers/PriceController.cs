using FinanceControl.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinanceControl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly PriceService _priceService;
        public PriceController()
        {
            _priceService = new PriceService();
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

    }
}  