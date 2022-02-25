using LoremIpsumLogistica.Api.Domain.Entities.Base;

namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic
{
    public class BaseRepository<TEntity, TId>
        where TEntity : EntityBase
        where TId : struct
    {
        protected readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }
       public TEntity Create(TEntity item)
        {
            return _context.Set<TEntity>().Add(item);
            throw new NotImplementedException();

        }
        public TEntity GetById(TId id)
        {
            throw new NotImplementedException();
        }
        public List<TEntity> GetAll(string query)
        {
            throw new NotImplementedException();

        }
        public TEntity Update(TEntity item)
        {
            var entity = _context.Set<TEntity>().Update(item);
            throw new NotImplementedException();

        }
        public void Delete(TId id)
        {
            throw new NotImplementedException();

        }
        public bool Exists(TId id)
        {
            return _context.Set<TEntity>().Exists(id);
            throw new NotImplementedException();

        }
    }
}
