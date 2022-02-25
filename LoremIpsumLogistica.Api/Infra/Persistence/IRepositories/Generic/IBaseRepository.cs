namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> GetById(TId id);
        List<TEntity> GetAll(string query);
        Task<TEntity> Update(TEntity entity);
        Task Delete(TEntity entity);
        bool Exists(Func<TEntity, bool> where);
    }
}
