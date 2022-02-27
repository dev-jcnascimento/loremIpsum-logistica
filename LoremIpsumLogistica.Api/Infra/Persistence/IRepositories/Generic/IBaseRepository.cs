namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> GetById(TId id);
        Task<List<TEntity>> GetAll();
        Task<TEntity> Update(TEntity entity);
        Task Delete(TEntity entity);
        bool Exists(Func<TEntity, bool> where);
    }
}
