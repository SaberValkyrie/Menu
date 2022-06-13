using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Menu
{
    internal class ConnectionDB
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "Data source = localhost;Initial Catalog =product;User=sa;password = sa";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;

        }
    }
}
