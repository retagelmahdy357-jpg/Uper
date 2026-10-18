using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uper.UnitOfWork;

namespace Uper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RatingController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;


        }
        [HttpGet]
        public IActionResult Get()
        {
          var r=  _unitOfWork.rating.GetTopDrivers();
            return  Ok(r);
        }
    }
}
