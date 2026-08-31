using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace What_sInMyCity.Data
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["WhatsInMyCityConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);

        }
    }
    
}