using Microsoft.EntityFrameworkCore;
using Uper.Data;
using Uper.Repo.IRepo;

namespace Uper.Repo
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public GenericRepo(AppDbContext context)
        {
             _context=context;
        }
        public async Task Add(TEntity entity)
        {
          await  _context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
           _context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
