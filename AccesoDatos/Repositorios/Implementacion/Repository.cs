using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorios
{
    public class Repository
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get; private set; }

        public Repository(IDbConnection connection, IDbTransaction transaction)
        {
            Connection = connection;
            Transaction = transaction;
        }
    }
}
