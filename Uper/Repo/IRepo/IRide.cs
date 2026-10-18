using Uper.DTO;
using Uper.Model;

namespace Uper.Repo.IRepo
{
    public interface IRide:IGenericRepo<Ride>

    {
        public Task< List<Ride>> Pagination_Sort(int pagesize,int pagenum);
        public List<Ride> Filter_Sort(string status, int maxfare, int minfare, string sortedby);

     
        public Task<List<Ride>> Search(string PackuoOff);
        public Task<List<Report2Dto>> Report();

    }
}
