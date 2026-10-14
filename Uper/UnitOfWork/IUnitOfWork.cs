using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGenericRepo<User> user {get;}
        public IGenericRepo<Vehicle> vehicle {get;}
        public IGenericRepo<Ride> ride {get;}
        public IGenericRepo<Payment> payment {get;}
        public IGenericRepo<Rating> rating {get;}
        public Task Save();
    }
}
