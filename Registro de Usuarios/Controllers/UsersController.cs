using AuthLayer;
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
        private ISessionManager _sessionManager;
        public UsersController(IUserManager userManager, ISessionManager sessionManager)
        {
            // this = _ (evita ambiguedades)
            _userManager = userManager;
            _sessionManager = sessionManager;
        }
        [HttpGet]
        public IActionResult GetUsers([FromHeader] string userName, [FromHeader] string password)
        {
            if (_sessionManager.ValidateCredentials(userName, password) != null)
            {
                //var userList = _userManager.GetUsers();
                return Ok(_userManager.GetUsers());
            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpPost]
        public IActionResult PostUser([FromHeader] string userName, [FromHeader] string password, [FromBody] User user)
        {
            if (_sessionManager.ValidateCredentials(userName, password) != null)
            {
                return Ok(_userManager.PostUser(user));
            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            /* OTRA MANERA DE ESCRIBIR
            if(user.Ci <= 0 || user.Name == null || user.Name.Trim() == "")
            {

            }*/
            //Se identifico una manera mas detallada e interesante
            if (user.Ci <= 0 || String.IsNullOrEmpty(user.Name))
            {

            }

            User updated = _userManager.PutUser(user);
            if(updated != null)
            {
                return Ok(updated);
            }
            else
            {
                return BadRequest("No se encuentra el usuario");
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser()
        {
            return Ok();
        }
    }
}
