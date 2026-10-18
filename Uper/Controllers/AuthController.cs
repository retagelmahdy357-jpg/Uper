using System.Net;
using System.Security.AccessControl;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uper.DTO;
using Uper.Model;
using Uper.Repo.IRepo;
using Uper.UnitOfWork;

namespace Uper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
      
        private readonly IUnitOfWork _unitOfWork;

        public AuthController( IUnitOfWork unitOfWork)
        {
          
            _unitOfWork=unitOfWork;
        }











       // [HttpPost("Login")]
        //public async Task<IActionResult> Login(AppUserDTO userDTO)
        //{
        //    var usr=await _unitOfWork.auth.Login(userDTO);
        //    if (usr == null)
        //    {
        //        return BadRequest("Email Or Password NotValid");
        //    }
        //    return Ok(usr);
        //}

        //[HttpPost("Rigester")]
        //public async Task<IActionResult> Rigester(RigesterDTO userDTO)
        //{
        //    if(userDTO == null || !ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    var newusr = new AppUser
        //    {
        //        FullName = userDTO.FullName,
        //        email = userDTO.email,
        //        password = userDTO.password,
        //        Role = userDTO.Role

        //    };
        //    var r=await _unitOfWork.auth.Rigester(newusr);
        //    if (r==true)
        //    {
        //        await _unitOfWork.Save();
        //        return Created();
        //    }
        //    return BadRequest("AllreadyExsist");
            
        //}



    }
}
