namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        TEntity Create(TEntity item);
        TEntity GetById(TId id);
        List<TEntity> GetAll(string query);
        TEntity Update(TEntity item);
        void Delete(TId id);
        bool Exists(TId id);
    }
}
