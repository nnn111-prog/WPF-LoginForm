using MySql.Data.MySqlClient;

namespace WPF_LoginForm.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString = @"Server=localhost;user id=root;password=root;Database=equipment;port=8080;";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);

        }
    }
}