using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persist
{
    public class Queries
    {
        private Persist.Connection connection;

        public Queries(Persist.Connection connection)
        {
            this.connection = connection;
        }

        public string GetData()
        {
            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string query = "select * from test"; // Cambiar 'test' por la tabla de l que se quiera sacar información.

            if (connection.getConnection() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = connection.getConnection();
                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    result += mySqlDataReader.GetString("nombre") + "\n"; // Cambiar 'nombre' por la columna deseada.
                }
                mySqlDataReader.Close();
            }
            else
            {
                result = "Error al conectar.";
            }

            return result;
        }
    }
}
