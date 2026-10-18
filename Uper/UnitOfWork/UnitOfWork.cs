using Uper.Data;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        public IUser user { get; }

        public IGenericRepo<Vehicle> vehicle { get; }

        public IRide ride { get; }
        public IPayment payment { get; }

        public IRating rating { get; }

        public IAuth auth { get; }

        public async Task Save()
        {
          await  context.SaveChangesAsync();
        }
        public UnitOfWork(AppDbContext _context, IUser _user, IGenericRepo<Vehicle> _vehicle, IRide _ride, IPayment _payment, IRating _rating,IAuth _auth)
        {
             context = _context;
            user = _user;
            vehicle = _vehicle;
            ride = _ride;
            payment = _payment;
            rating = _rating;
            auth = _auth;
        }
    }
}
