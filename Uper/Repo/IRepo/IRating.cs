using Uper.DTO;
using Uper.Model;

namespace Uper.Repo.IRepo
{
    public interface IRating:IGenericRepo<Rating>
    {
        public List<RatingDto> GetTopDrivers();
        
    }
}
