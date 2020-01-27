using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamishLab4
{
    public static class OrdersDB
    {
        // retrieve a single order data
        public static Orders GetOrder(int orderID)
        {
            //creating the object to store the orders information
            Orders ord = null;
            //opening a connection to SQL and inputting a query to access the specific orderIDs information
            using (SqlConnection connection = NorthwindDB.GetConnection())
            {
                string query = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                "FROM Orders " +
                                "WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    connection.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        //store values into the order object
                        if(reader.Read())
                        {
                            ord = new Orders();
                            ord.OrderID = (int)reader["OrderID"];
                            ord.CustomerID = reader["CustomerID"].ToString();
                            //taking in account potential null values for dates
                            if(reader["OrderDate"] == DBNull.Value)
                            {
                                ord.OrderDate = null;
                            }
                            else
                            {
                                ord.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                            }
                            if(reader["RequiredDate"] == DBNull.Value)
                            {
                                ord.RequiredDate = null;
                            }
                            else
                            {
                                ord.RequiredDate = Convert.ToDateTime(reader["RequiredDate"]);
                            }
                            if(reader["ShippedDate"] == DBNull.Value)
                            {
                                ord.ShippedDate = null;
                            }
                            else 
                            { 
                            ord.ShippedDate = Convert.ToDateTime(reader["ShippedDate"]);
                            }
                        }
                    }
                }
            }
            return ord;
        }// Get Order method completed
        //accessing SQL and changing the shipped date
        public static bool UpdateOrder(int orderID, DateTime? newOrd)
        {
            int count; // how many rows updated
            using (SqlConnection connection = NorthwindDB.GetConnection())
            {
                string updateStatement =
                    "UPDATE Orders SET " +
                    " ShippedDate = @newShippedDate " +
                    "WHERE orderID = @orderID";

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    if (newOrd != null)
                    {
                        cmd.Parameters.AddWithValue("@newShippedDate", newOrd);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@newShippedDate", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // returns how many rows updated
                }
            }
            return (count > 0);
        }
        // gets all order IDs for the combo box
        public static List<int> GetOrderIDs()
        {
            List<int> orderIDs = new List<int>(); // empty list of IDs
            int id; // for reading
            using (SqlConnection connection = NorthwindDB.GetConnection())
            {
                string query = "SELECT OrderID FROM Orders";
                // any exception not handled here is automatically thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        id = (int)reader["OrderID"];
                        orderIDs.Add(id);
                    }
                } // command object recycled
            } // connection object recycled
            return orderIDs;
        }
    } //end of class space
}//End of namespace
