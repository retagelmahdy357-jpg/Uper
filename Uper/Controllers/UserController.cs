using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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



        [HttpPost("GetAllUser")]
        public async Task<IActionResult> GettAll(UserCreateDto userCreateDto)
        {
            var r = await _unitOfWork.user.GetAll();
            var map = _mapper.Map<List<UserCreateDto>>(r);
            return Ok(map);
        }


        [HttpGet("PaginationDriver{pagenum}/{pagesize})")]

        public async Task<IActionResult> Pagination(int pagenum, int pageSize)
        {
            var u=await _unitOfWork.user.PaginationDrivers(pagenum, pageSize);
            return Ok(u);
        }

        [HttpPut("Update{id}")]

        public async Task<IActionResult> Update(int id,UserCreateDto createDto)
        {
            var u=await _unitOfWork.user.GetById(id);
            var map = _mapper.Map(createDto, u);
             _unitOfWork.user.Update(u);
            return Ok(map);

        }



        [HttpGet("PaginationRiders{pagenum}/{pagesize})")]

        public async Task<IActionResult> PaginationRiders(int pagenum, int pageSize)
        {
            var u = await _unitOfWork.user.PaginationRiders(pagenum, pageSize);
            return Ok(u);
        }

       

        //[HttpPost]
        //public async Task<IActionResult> Create(UserCreateDto U1)
        //{
        //    var map = _mapper.Map<User>(U1);
        //    await _unitOfWork.user.Add(map);
        //    await _unitOfWork.Save();

        //    return Created();

        //}
        ////  [Authorize(Roles ="Driver")]
        //[HttpGet("AllDrivers")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var u = await _unitOfWork.user.GetAllDrivers();
        //    var map = _mapper.Map<List<UserReadDto>>(u);
        //    return Ok(map);
        //}
        //[HttpGet("{name}Search")]
        //public async Task<IActionResult> Search(string name)
        //{
        //    var u = await _unitOfWork.user.Search(name);
        //    var map = _mapper.Map<List<UserReadDto>>(u);
        //    return Ok(map);
        //}


        //[HttpDelete("{id}")]
        //public async Task< ActionResult> Delete(int id)
        //{
        //    var d=await _unitOfWork.vehicle.GetById(id);
        //     _unitOfWork.vehicle.Delete(d);
        //    await _unitOfWork.Save();
        //    return NoContent();

        //}
    }
}
