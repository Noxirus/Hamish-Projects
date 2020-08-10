using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamishLab4
{
    class OrderDetailsDB
    {
        //creating a list of objects for order details
        public static List <OrderDetails> GetOrderDetails(int orderID)
        {
            //variables and lists
            List <OrderDetails> ordDet = new List<OrderDetails>();
            OrderDetails singleOrdDet = null;
            //connection to SQL and submitting required query
            using (SqlConnection connection = NorthwindDB.GetConnection())
            {
                string query = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                                "FROM [Order Details] " +
                                "WHERE OrderID = @OrderID";
            
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        //add all items from order details database to object list
                        while (reader.Read())
                        {
                            singleOrdDet = new OrderDetails();
                            singleOrdDet.OrderID = (int)reader["OrderID"];
                            singleOrdDet.ProductID = (int)reader["ProductID"];
                            singleOrdDet.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                            singleOrdDet.Quantity = Convert.ToInt32(reader["Quantity"]);
                            singleOrdDet.Discount = Convert.ToDecimal(reader["Discount"]);
                            ordDet.Add(singleOrdDet);
                        }
                    }
                }
            }
            return ordDet; //returns full list of order details objects
        }// Get Customer method completed
    }
}
