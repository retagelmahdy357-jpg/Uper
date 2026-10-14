using System.Net;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uper.DTO;
using Uper.Repo.IRepo;

namespace Uper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth _authService;

        public AuthController(IAuth authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AppUserDTO model)
        {
            //if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _authService.Login(model);

            if (result == null)
            {

                return Unauthorized();
                
            }
            return Ok(result);
        }
    }
}
