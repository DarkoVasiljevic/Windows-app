
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
    public class ProductsRepository : InterfaceDal<Products, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        private SqlConnection con = new SqlConnection(conString);

        public int AddSingle(Products single)
        {
            int result = 0;
            string sql = @"insert into Products 
                            values ( @name, @suppId, @catId, 
                                     @quantity, @price, @stock, 
                                     @order, @reorder, @discounted );";

            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40)).Value = single.ProductName;
            cmd.Parameters.Add(new SqlParameter("@suppId", SqlDbType.Int)).Value = single.SuplierId;
            cmd.Parameters.Add(new SqlParameter("@catId", SqlDbType.Int)).Value = single.CategoryId;
            cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.NVarChar, 20)).Value = single.QuantityPerUnit;
            cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Money)).Value = single.UnitPrice;
            cmd.Parameters.Add(new SqlParameter("@stock", SqlDbType.SmallInt)).Value = single.UnitsInStock;
            cmd.Parameters.Add(new SqlParameter("@order", SqlDbType.SmallInt)).Value = single.UnitsOnOrder;
            cmd.Parameters.Add(new SqlParameter("@reorder", SqlDbType.SmallInt)).Value = single.ReorderLevel;
            cmd.Parameters.Add(new SqlParameter("@discounted", SqlDbType.Bit)).Value = single.ReorderLevel;

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
            int result = 0;
            string sql = @"delete 
                            from Products 
                            where productId = @prodId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@prodId", SqlDbType.Int)).Value = id;

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

        public List<Products> GetAll()
        {
            List<Products> product = new List<Products>();

            string sql = @"select *
                            from Products";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int productId = Convert.ToInt32(rdr[0]);
                    string name = Convert.ToString(rdr[1]);
                    int suppId = Convert.ToInt32(rdr[2]);
                    int catId = Convert.ToInt32(rdr[3]);
                    string quantity = Convert.ToString(rdr[4]);
                    decimal price = Convert.ToDecimal(rdr[5]);
                    short stock = Convert.ToInt16(rdr[6]);
                    short order = Convert.ToInt16(rdr[7]);
                    short reorder = Convert.ToInt16(rdr[8]);
                    bool discounted = Convert.ToBoolean(rdr[9]);

                    Products p = new Products(productId, name, suppId, catId, quantity,
                                                price, stock, order, reorder, discounted);
                    product.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                rdr.Close();
            }

            return product;
        }

        public Products GetById(int id)
        {
            Products p = new Products();

            string sql = @"select *
                            from Products
                            where productId = @prodId";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@prodId", SqlDbType.Int)).Value = id;

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int productId = Convert.ToInt32(rdr[0]);
                    string name = Convert.ToString(rdr[1]);
                    int suppId = Convert.ToInt32(rdr[2]);
                    int catId = Convert.ToInt32(rdr[3]);
                    string quantity = Convert.ToString(rdr[4]);
                    decimal price = Convert.ToDecimal(rdr[5]);
                    short stock = Convert.ToInt16(rdr[6]);
                    short order = Convert.ToInt16(rdr[7]);
                    short reorder = Convert.ToInt16(rdr[8]);
                    bool discounted = Convert.ToBoolean(rdr[9]);

                    p = new Products(productId, name, suppId, catId, quantity,
                                        price, stock, order, reorder, discounted);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                rdr.Close();
            }

            return p;
        }

        public Products GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(Products single)
        {
            int result = 0;
            string sql = @"update
                            set productName = @name, suplierId = @suppId, categoryId = @catId, 
                                quantityPerUnit = @quantity, unitPrice = @price, unitsInStock = @stock, 
                                unitsOnOrder = @order, reorderLevel = @reorder, discounted = @discounted
                            where productId = @prodId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@prodId", SqlDbType.Int)).Value = single.ProductId;
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40)).Value = single.ProductName;
            cmd.Parameters.Add(new SqlParameter("@suppId", SqlDbType.Int)).Value = single.SuplierId;
            cmd.Parameters.Add(new SqlParameter("@catId", SqlDbType.Int)).Value = single.CategoryId;
            cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.NVarChar, 20)).Value = single.QuantityPerUnit;
            cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Money)).Value = single.UnitPrice;
            cmd.Parameters.Add(new SqlParameter("@stock", SqlDbType.SmallInt)).Value = single.UnitsInStock;
            cmd.Parameters.Add(new SqlParameter("@order", SqlDbType.SmallInt)).Value = single.UnitsOnOrder;
            cmd.Parameters.Add(new SqlParameter("@reorder", SqlDbType.SmallInt)).Value = single.ReorderLevel;
            cmd.Parameters.Add(new SqlParameter("@discounted", SqlDbType.Bit)).Value = single.ReorderLevel;

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
    }
}
