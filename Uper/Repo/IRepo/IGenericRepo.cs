namespace Uper.Repo.IRepo
{
    public interface IGenericRepo<TEntity>where TEntity : class

    {
        public Task Add(TEntity entity);
        public void Delete(TEntity entity);
        public Task<TEntity> GetById(int id);
        public Task<List<TEntity>> GetAll();
        public void Update(TEntity entity);
    }
}
