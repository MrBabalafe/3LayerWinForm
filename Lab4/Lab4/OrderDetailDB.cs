using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    public static class OrderDetailDB {

        //Retrieves OrderID, ProductID, UnitPrice, Quantity, Discount for specified Order ID in [Order Details] table
        //Returns data as a list of OrderDetails
        public static List<OrderDetail> GetOrderDetails(int id) {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            OrderDetail orderDetail;

            //Establish connection
            using(SqlConnection connection = NorthwindDB.GetConnection()) {

                string query = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                               "FROM [Order Details] " +
                               "WHERE OrderID = @OrderID";

                //Create command
                using (SqlCommand cmd = new SqlCommand(query, connection)) {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@OrderID", id);

                    //Execute and process data
                    using(SqlDataReader dr = cmd.ExecuteReader()) {

                        while(dr.Read()) {
                            orderDetail = new OrderDetail();
                            orderDetail.OrderID = (int)dr["OrderID"];
                            orderDetail.ProductID = (int)dr["ProductID"];
                            orderDetail.UnitPrice = (decimal)dr["UnitPrice"];
                            orderDetail.Quantity = (short)dr["Quantity"];
                            orderDetail.Discount = (float)dr["Discount"];
                            orderDetails.Add(orderDetail);
                        }
                        
                    }
                }
            }

            return orderDetails;
        }
    }
}
