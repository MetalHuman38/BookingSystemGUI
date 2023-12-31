using System.Data.SqlClient;

namespace BookingSystem.Repositories
{
    public class RepositoryBaseClass
    {

        private readonly string _connectionString;
        public RepositoryBaseClass()
        {
            _connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=BookingSystem; Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
