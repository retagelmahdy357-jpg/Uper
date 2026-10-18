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
    public class PaymentController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

            //[HttpGet("Staticts")]
            //public async Task<IActionResult> Statics()
            //{
            //    var r =await _unitOfWork.ride.GetAll();
            //var stat = new
            //{
            //    TotalCash = r.Count(X => X.Payment.PaymentMethod == "Cach"),
               

            //    TotalCompleted = r.Count(x => x.Status == "Completed"),
          

            //};
            //}
        //}
        //    [HttpPost]
        //    public async Task<IActionResult> Create(PaymentDTO P1)
        //    {
        //        var map = _mapper.Map<Payment>(P1);
        //        await _unitOfWork.payment.Add(map);
        //        await _unitOfWork.Save();

        //        return Created();

        //    }

        //    [HttpGet("Statics")]
        //public async Task<IActionResult> Statices()
        //    {
        //        var p = await _unitOfWork.payment.StaticsPayment();
        //        return Ok(p);
        //    }

    }
    }
