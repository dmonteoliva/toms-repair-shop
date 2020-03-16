using System.Data;
using System.Data.SqlClient;

namespace TomsRepairShop.Data.Read
{
    public abstract class BaseReadRepository
    {
        protected IDbConnection GetConnection()
        {
            var connection = new SqlConnection(AppSettings.ConnectionString);

            connection.Open();

            return connection;
        }
    }
}