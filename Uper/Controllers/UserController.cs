using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uper.Data;
using Uper.DTO;
using Uper.Model;
using Uper.UnitOfWork;

namespace Uper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;


        }

        [HttpPost]
        public async Task<IActionResult> Create( UserCreateDto U1)
        {
            var map = _mapper.Map<User>(U1);
           await _unitOfWork.user.Add(map);

            return Created();

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var u=await _unitOfWork.user.GetAll();
            return Ok(u);
        }

    }
}
