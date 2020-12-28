using System;
using System.Collections.Generic;
using Common.Core.Interfaces;
using System.Data.Entity;
using Common.Core.Model;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Delete(long id)
        {
            var entityToDelete = _dbSet.Find(id);
            _dbSet.Remove(entityToDelete);
            _context.SaveChanges();
        }

        public TEntity GetById(long id)
        {
            return _dbSet.Find(id);
        }

        public Task<TEntity> GetByIdAsync(long id)
        {
            return _dbSet.FindAsync(id);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> List()
        {
            return _dbSet.ToList();
        }

        public Task<List<TEntity>> ListAsync()
        {
            return _dbSet.ToListAsync();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
