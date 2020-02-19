using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class OrderDetailsRepository : InterfaceDal<OrderDetails, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        private SqlConnection con = new SqlConnection(conString);

        public int InsertNewOrder(string customerId, int employeeId)
        {
            int result = 0;
            string sql = @"insert into Orders (CustomerID, EmployeeID)
		                    values(@customerID, @employeeID);";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@customerID", SqlDbType.NChar, 5)).Value = customerId;
            cmd.Parameters.Add(new SqlParameter("@employeeID", SqlDbType.Int)).Value = employeeId;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int GetOrderId(string customerId, int employeeId)
        {
            int result = 0;

            string sql = @"select max(OrderID)
                            from Orders
                            where CustomerID = @customerID and EmployeeID = @employeeID;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@customerID", SqlDbType.NChar, 5)).Value = customerId;
            cmd.Parameters.Add(new SqlParameter("@employeeID", SqlDbType.Int)).Value = employeeId;

            try
            {
                con.Open();

                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int InsertNewOrderDetails(int orderId, int productId, decimal price, short quantity, decimal discount)
        {
            int result = 0;
            string sql = @"insert into [Northwind].[dbo].[Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
		                    values(@orderID, @productID, @unitPrice, @quantity, @discount);";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int)).Value = orderId;
            cmd.Parameters.Add(new SqlParameter("@productID", SqlDbType.Int)).Value = productId;
            cmd.Parameters.Add(new SqlParameter("@unitPrice", SqlDbType.Decimal)).Value = price;
            cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.SmallInt)).Value = quantity;
            cmd.Parameters.Add(new SqlParameter("@discount", SqlDbType.Decimal)).Value = discount;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int AddSingle(OrderDetails single)
        {
            int result = 0;
            string sql = @"insert into OrderDetails
                            values (@ordersId, @productsId, @unitPrice, @quantity, @discount);";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int)).Value = single.OrdersId;
            cmd.Parameters.Add(new SqlParameter("@productsId", SqlDbType.Int)).Value = single.ProductsId;
            cmd.Parameters.Add(new SqlParameter("@unitPrice", SqlDbType.Decimal)).Value = single.UnitPrice;
            cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.SmallInt)).Value = single.Quantity;
            cmd.Parameters.Add(new SqlParameter("@discount", SqlDbType.Decimal)).Value = single.Discount;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int DeleteSingle(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetails GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(OrderDetails single)
        {
            throw new NotImplementedException();
        }
    }
}
