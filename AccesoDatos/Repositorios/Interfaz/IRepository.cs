using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorios
{
    public interface IRepository<T> where T: IEntity
    {
        IEnumerable<T> List();
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int id);
    }
}
