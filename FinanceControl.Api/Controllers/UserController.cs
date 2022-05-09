using FinanceControl.Domain.Models;
using FinanceControl.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceControl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            var result = this._userService.GetAll();
            return result;
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            this._userService.Create(user);
        }
    }
}
