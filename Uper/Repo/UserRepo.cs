using Microsoft.EntityFrameworkCore;
using Uper.Data;
using Uper.DTO;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.Repo
{
    public class UserRepo:GenericRepo<User>,IUser
    {
        private readonly AppDbContext _context;
        public UserRepo(AppDbContext context):base(context)
        {
             _context = context;
        }

        public async Task< List<User>> GetAllDrivers()
        {
            return  _context.Users.Where(u=>u.Role=="Driver").ToList();

        }

        public async Task<List<User>> PaginationDrivers(int pagenum, int pageSize)
        {
           return await _context.Users.Where(x=>x.Role=="Driver").Skip((pagenum-1)*pageSize).Take(pageSize).OrderBy(x=>x.Phone).ToListAsync();
        }

       
        public async Task<List<User>> PaginationRiders(int pagenum, int pageSize)
        {
            return await _context.Users.Where(x => x.Role == "Rider").Skip((pagenum - 1) * pageSize).Take(pageSize).OrderBy(x => x.Phone).ToListAsync();
        }

        public async Task<List<User>> Search(string name)
        {
            return _context.Users.Where(x=>x.FullName.Contains(name)).ToList();

        }

       
    }
}
