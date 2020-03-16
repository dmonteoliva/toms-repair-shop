using System.Data;
using System.Data.SqlClient;
using TomsRepairShop.Domain.Interfaces.Data;

namespace TomsRepairShop.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        protected IDbConnection _connection;
        private IDbTransaction _transaction;

        public void BeginTransaction()
        {
            if (_transaction == null)
                _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            if (_transaction != null)
            {
                try
                {
                    _transaction.Commit();
                }
                catch
                {
                    _transaction.Rollback();
                }
                finally
                {
                    _transaction = null;
                }
            }
        }

        public dynamic OpenConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(AppSettings.ConnectionString);
                _connection.Open();
            }

            return _connection;
        }

        public void Rollback()
        {
            if (_transaction != null)
            {
                try
                {
                    _transaction.Rollback();
                }
                finally
                {
                    _transaction = null;
                }
            }
        }

        public void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }

        public void Dispose()
        {
            if ((_connection != null) && (_connection.State != ConnectionState.Closed))
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}