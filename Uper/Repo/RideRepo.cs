using Microsoft.EntityFrameworkCore;
using Uper.Data;
using Uper.DTO;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.Repo
{
    public class RideRepo:GenericRepo<Ride>,IRide
    {
        private readonly AppDbContext _context;
        public RideRepo(AppDbContext context):base(context)
        {
             _context = context;
        }

      

        public List<Ride> Filter_Sort(string status, int maxfare, int minfare, string sortedby)
        {
            var r = _context.Rides.ToList();
            if (status != null)
            {
                r = r.Where(x => x.Status == status).ToList();

            }
             if (maxfare != null)
            {
                r = r.Where(x => x.Fare <= maxfare).ToList();

            }
             if (minfare != null)
            {
                r = r.Where(x => x.Fare >= minfare).ToList();

            }

            
            if (sortedby == "Fare")
            {
                r = r.OrderByDescending(x => x.Fare).ToList();
            }
            return r;
        }

        public  async Task<List<Ride>> Pagination_Sort(int pagesize, int pagenum)
        {
            return await _context.Rides.Skip((pagenum - 1) *pagesize) .Take(pagesize).OrderBy(x => x.Fare).ToListAsync();
        }

        public async Task<List<Report2Dto>> Report()
        {
            return await _context.Rides.Select(x => new Report2Dto
            {
                Fare = x.Fare,
                DriverName=x.Driver.FullName,
                RiderName=x.Rider.FullName,
                Score=x.Rating.Score,
                PaymentMethoud=x.Payment.PaymentMethod
                
            }).ToListAsync();


        }













        //public async Task<ReportRideDto> Report()
        //{
        //    var r =  _context.Rides;
        //    var report =  new ReportRideDto
        //    {
        //        TotalFare =  r.Sum(x => x.Fare),
        //        TotalRide = r.Count(),
        //        CancelledRide = r.Count(x => x.Status == "Cancelled"),
        //        CompleteRide = r.Count(x => x.Status == "Complete")
        //    };
        //    return report;

        //}

        public async Task<List<Ride>> Search(string PackuoOff)
        {
           return await _context.Rides.Where(x=>x.PickupLocation == PackuoOff).ToListAsync();
        }

       
    }
}
