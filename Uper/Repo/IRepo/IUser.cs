using Uper.DTO;
using Uper.Model;

namespace Uper.Repo.IRepo
{
    public interface IUser:IGenericRepo<User>
    {
        public Task< List<User>> GetAllDrivers();
        public Task < List<User>> Search(string name);
        public Task<List<User>> PaginationDrivers(int pagenum, int pageSize);
        public Task<List<User>> PaginationRiders(int pagenum, int pageSize);
    }
}
