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
    public class CategoriesRepository : InterfaceDal<Categories, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public int AddSingle(Categories single)
        {
            int result = 0;
            string sql = @"insert into Categories (categoryName, description)
                            values (@categoryName, @description);";//, @image );";

            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.Add(new SqlParameter("@categoryName", SqlDbType.NVarChar, 15)).Value = single.CategoryName;
            cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NText)).Value = single.Description;
            //cmd.Parameters.Add(new SqlParameter("@image", SqlDbType.VarBinary)).Value = single.Image;
         
            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAddSingle failed\n" + ex.Message);
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
                            from Categories 
                            where categoryId = @categoryId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.Int)).Value = id;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nDeleteSingle failed \nbecause of the constraint to Products\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public List<Categories> GetAll()
        {
            List<Categories> category = new List<Categories>();
            Categories p = new Categories();

            string sql = @"select *
                            from Categories";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int categoryId = Convert.ToInt32(rdr[0]);
                    string categoryName = Convert.ToString(rdr[1]);
                    string description = Convert.ToString(rdr[2]);
                    //byte[] image = (byte[])rdr[3];
                 
                    p = new Categories(categoryId, categoryName, description);

                    category.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGetingALL failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
                rdr.Close();
            }

            return category;
        }

        public Categories GetById(int id)
        {
            Categories p = new Categories();

            string sql = @"select *
                            from Categories
                            where categoryId = @categoryId";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.Int)).Value = id;

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int categoryId = Convert.ToInt32(rdr[0]);
                    string categoryName = Convert.ToString(rdr[1]);
                    string description = Convert.ToString(rdr[2]);
                    //byte[] image = (byte[])rdr[3];

                    p = new Categories(categoryId, categoryName, description);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGetById failed\n" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                
                rdr.Close();
            }

            return p;
        }

        public Categories GetByName(string name)
        {
            Categories p = new Categories();

            string sql = @"select *
                            from Categories
                            where categoryName = @categoryName";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@categoryName", SqlDbType.NVarChar, 15)).Value = name;

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int categoryId = Convert.ToInt32(rdr[0]);
                    string categoryName = Convert.ToString(rdr[1]).Trim();
                    string description = Convert.ToString(rdr[2]);
                    //byte[] image = (byte[])rdr[3];

                    p = new Categories(categoryId, categoryName, description);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGetById failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
                rdr.Close();
            }

            return p;
        }

        public byte[] GetPicture(string name)
        {
            byte[] result = null;

            string sql = @"select image
                            from Categories
                            where categoryName = @categoryName";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@categoryName", SqlDbType.NVarChar, 15)).Value = name;

            try
            {
                con.Open();

                result = (byte[])cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGet picture failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int UpdateSingle(Categories single)
        {
            int result = 0;
            string sql = @"update Categories
                            set categoryName = @categoryName, description = @description
                            where categoryId = @categoryId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.Int)).Value = single.CategoryId;
            cmd.Parameters.Add(new SqlParameter("@categoryName", SqlDbType.NVarChar, 15)).Value = single.CategoryName;
            cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NText)).Value = single.Description;
            //cmd.Parameters.Add(new SqlParameter("@image", SqlDbType.VarBinary)).Value = single.Image;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nUpdate failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }
    }
}
