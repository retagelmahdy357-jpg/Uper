using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Uper.DTO;
using Uper.Model;
using Uper.UnitOfWork;

namespace Uper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RideController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;


        }

        [HttpGet]
        public  IActionResult GFilterSort(string status, int maxfare, int minfare, string sortedby)
        {
            var r= _unitOfWork.ride.Filter_Sort(status, maxfare, minfare, sortedby);
            return Ok(r);
        }
        [HttpGet("Report")]
        public async Task<IActionResult> Report()
        {
          var r=await _unitOfWork.ride.Report();
            return Ok(r);
        
        }

       















        //[HttpPost]
        //public async Task<IActionResult> Create(RideDto R1)
        //{
        //    var map = _mapper.Map<Ride>(R1);
        //    await _unitOfWork.ride.Add(map);
        //    await _unitOfWork.Save();

        //    return Created();

        //}

        //[HttpGet("{id}GetById")]
        //public async Task<IActionResult>GetById(int id)
        //{
        //    var r=await _unitOfWork.ride.GetById(id);
        //    var map=_mapper.Map<RideDto>(r);
        //    return Ok(r);
        //}
        //[HttpDelete("{id}delete")]
        //public async Task<IActionResult>Delete(int id)
        //{
        //    var r = await _unitOfWork.ride.GetById(id);
        //    _unitOfWork.ride.Delete(r);
        //    await _unitOfWork.Save();
        //    return NoContent();

        //}

        //[HttpPatch("{id}Accept")]
        //public async Task< IActionResult> Patchaccept(int id)
        //{
        //    var r = await _unitOfWork.ride.GetById(id);
        //    if (r.Status == "Accept")
        //    {
        //        return BadRequest("Allredy Accepted");
        //    }
        //    r.Status = "Accept";
        //    await _unitOfWork.Save();
        //    return Ok(r);

        //}

        //[HttpPatch("{id}Complete")]
        //public async Task<IActionResult> PatchCompletet(int id)
        //{
        //    var r = await _unitOfWork.ride.GetById(id);
        //    if (r.Status == "Complete")
        //    {
        //        return BadRequest("Allredy Completed");
        //    }
        //    else
        //    {
        //        r.Status = "Complete";
        //        await _unitOfWork.Save();
        //        return Ok(r);
        //    }

        //}

        //[HttpGet("pagination/{pagenum}/{pagesize}")]
        //public async Task<IActionResult>Pagination(int pagenum,int pagesize)
        //{
        //    var p=await _unitOfWork.ride.Pagination_Sort(pagesize,pagenum);
        //    var map=_mapper.Map<List<RideDto>>(p);
        //    return Ok(map);
        //}

        //[HttpGet("{pickup}Pickup")]
        //public async Task<IActionResult> SerchPuckup(string pickup)
        //{
        //    var r =await _unitOfWork.ride.Search(pickup);
        //    var map =_mapper.Map<List<RideDto>>(r);
        //    return Ok(map);
        //}
        //[HttpGet("Report")]
        //public async Task<IActionResult> Report()
        //{
        //    var r=await _unitOfWork.ride.Report();
        //    return Ok(r);
        //}
    }
}
