using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Uper.Data;
using Uper.DTO;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.Repo
{
    public class RatingRepo:GenericRepo<Rating>,IRating
    {
        private readonly AppDbContext _context;
        public RatingRepo(AppDbContext context):base(context)
        {
            _context = context; 
        }

        public List<RatingDto> GetTopDrivers()
        {


            var rat = _context.Ratings.Include(x => x.Ride);
            var grp = rat.GroupBy(x => x.Ride.DriverId).Select(x => new RatingDto
            {
                Driverid = x.Key,
                AvgRate=x.Average(x=>x.Score)
            

            }).OrderByDescending(x=>x.AvgRate).Take(5).ToList();
            return grp;

        }


            //var r = _context.Ratings.Include(x => x.Ride).ToList();
            //var ratingdriver = r.GroupBy(x => x.Ride.DriverId).Select(x => new RatingDto
            //{
            //    Driverid = x.Key,
            //    AvgRate = x.Average(y => y.Score)
            //}).OrderByDescending(x=>x.AvgRate).Take(5).ToList();

            //return ratingdriver;
        }
    }

