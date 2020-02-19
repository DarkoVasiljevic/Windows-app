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
    public class Repository<T> where T : new()
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public T GetInstance()
        {
            T instance = new T();
            return instance;
        }

        public T GetObject(params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        public int AddSingle(T single)
        {
            int result = 0;
            string sql = @"insert into Categories 
                          values ( @categoryId, @categoryName, @description, @image );";

            SqlCommand cmd = new SqlCommand(sql, con);

            //cmd.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.Int)).Value = single.CategoryId;
            //cmd.Parameters.Add(new SqlParameter("@categoryName", SqlDbType.NVarChar, 15)).Value = single.CategoryName;
            //cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NText)).Value = single.Description;
            //cmd.Parameters.Add(new SqlParameter("@image", SqlDbType.VarBinary)).Value = single.Image;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int DeleteSingle(T single)
        {
            int result = 0;
            string sql = @"delete 
                            from Categories 
                            where categoryId = @categoryId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            //cmd.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.Int)).Value = single.CategoryId;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public List<T> GetAll()
        {
            List<T> category = new List<T>();

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
                    byte[] image = (byte[])(rdr[3]);

                    //MemoryStream ms = new MemoryStream(image);
                    //pictureBox1.Image = new Bitmap(ms);

                    T p = new T();
                    category.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }

            return category;
        }

        public T GetById(int id)
        {
            T p = new T();

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
                    byte[] image = (byte[])(rdr[3]);

                    p = new T();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
                rdr.Close();
            }

            return p;
        }

        public int UpdateSingleCa(T single)
        {
            int result = 0;
            string sql = @"update Categories
                            set ( categoryName = @categoryName, description = @description, image = @image )
                            where categoryId = @categoryId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            //cmd.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.Int)).Value = single.CategoryId;
            //cmd.Parameters.Add(new SqlParameter("@categoryName", SqlDbType.NVarChar, 15)).Value = single.CategoryName;
            //cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NText)).Value = single.Description;
            //cmd.Parameters.Add(new SqlParameter("@image", SqlDbType.VarBinary)).Value = single.Image;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }

            return result;
        }
    }
}

