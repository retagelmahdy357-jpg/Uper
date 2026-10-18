using Uper.DTO;
using Uper.Model;

namespace Uper.Repo.IRepo
{
    public interface IAuth
    {
        public Task<string>Login(AppUserDTO userDTO);
        public Task<bool> Rigester(AppUser user);


    }
}
