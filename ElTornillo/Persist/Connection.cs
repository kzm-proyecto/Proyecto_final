
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persist
{
    public class Connection
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "pruebas"; // Cambiar a base de datos real
        private string user = "root";
        private string password = "contraseña";// Cambiar a contraseña real
        private string connectionString;

        public Connection()
        {
            connectionString = $"Server={server};" +
                $"Database={database};" +
                $"User Id={user};" +
                $"Password={password};" +
                $"SslMode=None;";
        }

        public MySqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            return connection;
        }
    }
}
