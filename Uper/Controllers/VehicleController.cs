using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uper.DTO;
using Uper.Model;
using Uper.UnitOfWork;

namespace Uper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VehicleController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        [HttpPost("AddVehicle")]
        public async Task<IActionResult> Add(VehcileDto vehcileDto)
        {
            var map=_mapper.Map<Vehicle>(vehcileDto);
            await _unitOfWork.vehicle.Add(map);
            await  _unitOfWork.Save();
            return Created();

        }

      
       























        //[HttpPost]
        //public async Task<IActionResult> Create(VehcileDto V1)
        //{
        //    var map = _mapper.Map<Vehicle>(V1);
        //    await _unitOfWork.vehicle.Add(map);
        //    await _unitOfWork.Save();

        //    return Created();

        //}
        //[HttpPut("{id}")]
        //public  async Task< IActionResult >Update(VehcileDto vehcileDto,int id)
        //{
        //    var ex=await _unitOfWork.vehicle.GetById(id);
        //    var map=_mapper.Map(vehcileDto,ex);
        //    _unitOfWork.vehicle.Update(ex);
        //  await _unitOfWork.Save();
        //    return Ok(map);

        //}
    }
}
