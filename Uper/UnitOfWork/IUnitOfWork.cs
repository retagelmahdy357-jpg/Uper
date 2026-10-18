using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IUser user {get;}
        public IGenericRepo<Vehicle> vehicle {get;}
        public IRide ride {get;}
        public IPayment payment {get;}
        public IRating rating {get;}
        public IAuth auth {get;}
        public Task Save();
    }
}
