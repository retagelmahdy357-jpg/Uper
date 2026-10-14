using Uper.DTO;
using Uper.Model;

namespace Uper.Repo.IRepo
{
    public interface IAuth
    {
        public Task<string> Login(AppUserDTO DTO);
       // public Task Rigester(AppUser User);


    }
}
