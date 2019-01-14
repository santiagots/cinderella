using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class UnidadDeTrabajo: IUnidadDeTrabajo
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        private VentaRepository _ventaRepository;

        public UnidadDeTrabajo(string connectionString, bool transaction)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            if (transaction)
            {
                _transaction = _connection.BeginTransaction();
            }
        }

        public VentaRepository VentaRepository
        {
            get { return _ventaRepository ?? (_ventaRepository = new VentaRepository(_connection, _transaction)); }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepositories();
            }
        }

        private void resetRepositories()
        {
            _ventaRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnidadDeTrabajo()
        {
            dispose(false);
        }
    }
}
