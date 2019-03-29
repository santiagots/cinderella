using System;
using System.Collections.Generic;
using Common.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class VentaRepository : IRepository<Venta, long>
    {
        private readonly CrudContext _context;
        private readonly DbSet< _context;

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Venta GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Venta entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Venta entity)
        {
            throw new NotImplementedException();
        }
    }
}
