using Uper.Data;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        public IGenericRepo<User> user { get; }

        public IGenericRepo<Vehicle> vehicle { get; }

        public IGenericRepo<Ride> ride { get; }

        public IGenericRepo<Payment> payment { get; }

        public IGenericRepo<Rating> rating { get; }

        public async Task Save()
        {
          await  context.SaveChangesAsync();
        }
        public UnitOfWork(AppDbContext _context, IGenericRepo<User> _user, IGenericRepo<Vehicle> _vehicle, IGenericRepo<Ride> _ride, IGenericRepo<Payment> _payment, IGenericRepo<Rating> _rating)
        {
             context = _context;
            user = _user;
            vehicle = _vehicle;
            ride = _ride;
            payment = _payment;
            rating = _rating;
        }
    }
}
