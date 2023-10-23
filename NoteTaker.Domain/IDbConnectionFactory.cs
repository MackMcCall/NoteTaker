using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker.Domain
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }

    public class SqlServerConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;
        
        public SqlServerConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}