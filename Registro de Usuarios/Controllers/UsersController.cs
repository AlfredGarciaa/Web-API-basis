using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_de_Usuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUsers(User user)
        {
            return Ok(_userManager.PostUser(user));
        }
        [HttpPut]
        public IActionResult PutUsers()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteUsers()
        {
            return Ok();
        }
    }
}
