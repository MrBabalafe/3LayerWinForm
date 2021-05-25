using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    public static class OrderDB {

        //Retrieves CustomerID, OrderDate, RequiredDate, ShippedDate for specified Order ID
        public static Order GetOrder(int id) {
            Order order = new Order();

            //Establish Connection
            using(SqlConnection connection = NorthwindDB.GetConnection()) {

                string query = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                               "FROM Orders " +
                               "WHERE OrderID = @OrderID";

                //Create Command
                using(SqlCommand cmd = new SqlCommand(query, connection)) {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@OrderID", id);

                    //Execute and process data
                    using(SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)) {

                        if (dr.Read()) {
                            order.OrderID = (int)dr["OrderID"];
                            order.CustomerID = dr["CustomerID"].ToString();

                            //For every date, if the value is NULL in the database, store it as defaul value (0001-01-01)
                            //Otherwise just store the date normally
                            if (dr["OrderDate"] == DBNull.Value) {
                                order.OrderDate = default;
                            } else {
                                order.OrderDate = (DateTime)dr["OrderDate"];
                            }

                            if (dr["RequiredDate"] == DBNull.Value) {
                                order.RequiredDate = default;
                            } else {
                                order.RequiredDate = (DateTime)dr["RequiredDate"];
                            }

                            if (dr["ShippedDate"] == DBNull.Value) {
                                order.ShippedDate = default;
                            } else {
                                order.ShippedDate = (DateTime)dr["ShippedDate"];
                            }

                        }
                    }
                }
            }

            return order;
        }

        //Update Shipped Date for specified order in the Database. isNull paramater is used to tell if ShippedDate should be null or not.
        public static void UpdateOrder(Order newOrder, bool isNull) {

            //Establish connection
            using(SqlConnection connection = NorthwindDB.GetConnection()) {

                string query = "UPDATE Orders " +
                               "SET ShippedDate = @ShippedDate " +
                               "WHERE OrderID = @OrderID";

                //Create command
                using (SqlCommand cmd = new SqlCommand(query, connection)) {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@OrderID", newOrder.OrderID);
                    if(isNull) {
                        cmd.Parameters.AddWithValue("@ShippedDate", DBNull.Value);
                    } else {
                        cmd.Parameters.AddWithValue("@ShippedDate", newOrder.ShippedDate);
                    }

                    //Execute
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
