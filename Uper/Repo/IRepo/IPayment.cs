using Uper.DTO;
using Uper.Model;

namespace Uper.Repo.IRepo
{
    public interface IPayment:IGenericRepo<Payment>
    {
      public Task<StaticsDTO> StaticsPayment();

    }
}
