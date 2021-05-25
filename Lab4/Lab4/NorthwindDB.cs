using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    public static class NorthwindDB {

        //Return connection to Northwind Database
        public static SqlConnection GetConnection() {

            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);

        }

    }
}
