using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> List();
        TEntity GetById(long id);
        Task<TEntity> GetByIdAsync(long id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(long id);
    }
}
