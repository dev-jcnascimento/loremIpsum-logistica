using LoremIpsumLogistica.Api.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

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
        public async Task<TEntity> Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<TEntity> GetById(TId id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public List<TEntity> GetAll(string query)
        {
            return _context.Set<TEntity>().FromSqlRaw(query).ToList();
        }
        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;

        }
        public async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public bool Exists(Func<TEntity, bool> where)
        {
            return _context.Set<TEntity>().Any(where);

        }
    }
}
