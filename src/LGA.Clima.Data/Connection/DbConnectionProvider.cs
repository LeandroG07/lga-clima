
using System.Data;
using System.Data.SqlClient;

namespace LGA.Clima.Data.Connection
{
    public class DbConnectionProvider
    {
        private readonly DataContext _context;

        public IDbConnection? Connection { get; }

        public DbConnectionProvider(DataContext context)
        {
            _context = context;
        }

        public IDbConnection GetConnection()
        {
            var connection = new SqlConnection(_context.ConnectionString);
            connection.Open();
            return connection;
        }



    }
}
