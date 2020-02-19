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
    public class CustomersRepository : InterfaceDal<Customers, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public int AddSingle(Customers single)
        {
            throw new NotImplementedException();
        }

        public int DeleteSingle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            List<Customers> customer = new List<Customers>();
            Customers p = new Customers();

            string sql = @"select *
                            from Customers";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //int tblUserID = Convert.ToInt32((rdr[0]);
                    string customerId = Convert.ToString(rdr[1]);
                    string companyName = Convert.ToString(rdr[2]);
                    string contactName = Convert.ToString(rdr[3]);
                    string contactTitle = Convert.ToString(rdr[4]);
                    string adress = Convert.ToString(rdr[5]);
                    string city = Convert.ToString(rdr[6]);
                    string region = Convert.ToString(rdr[7]);
                    string postCode = Convert.ToString(rdr[8]);
                    string country = Convert.ToString(rdr[9]);
                    string phone = Convert.ToString(rdr[10]);
                    string fax = Convert.ToString(rdr[11]);

                    p = new Customers(customerId, companyName, contactName, contactTitle, adress, city,
                                       region, postCode, country, phone, fax);

                    customer.Add(p);
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

            return customer;
        }

        public Customers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customers GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(Customers single)
        {
            throw new NotImplementedException();
        }

        public string GetCustomerName(string name)
        {
            string sql = @"select ContactName
                            from Customers
                            where ContactName = @name";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40)).Value = name;

            string result = null;
            try
            {
                con.Open();

                result = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGetingCustomer failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int insertCustomerByContactName(string customerId, string companyName, string contactName)
        {
            int result = 0;
            string sql = @"insert into Customers (customerId, companyName, contactName)
                            values (@customerId, @companyName, @contactName);";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@customerId", SqlDbType.NChar, 5)).Value = customerId;
            cmd.Parameters.Add(new SqlParameter("@companyName", SqlDbType.NVarChar, 40)).Value = companyName;
            cmd.Parameters.Add(new SqlParameter("@contactName", SqlDbType.NVarChar, 30)).Value = contactName;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAdd Customer failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public int insertCustomerToUser(string firstName, string lastName, string passwd)
        {
            int userId = 0;
           
            string sql = @"INSERT INTO tblUsers (UserName, Password, Email, Role, RetryAttempts, IsLocked) 
                           VALUES(@UserName, @Password, @Email, @Role, 0, 0);
                           SELECT CAST(scope_identity() AS int)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar)).
                                    Value = firstName.Substring(0, 1).ToLower() + lastName.ToLower();

            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar)).Value = passwd;

            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).
                                Value = string.Format("{0}.{1}@northwind.com", firstName.ToLower(), 
                                                                                lastName.ToLower());

            cmd.Parameters.Add(new SqlParameter("@Role", SqlDbType.NVarChar)).Value = "Customer";

            try
            {
                con.Open();

                userId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAdd Customer to User failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return userId;
        }

        public int updateUserId(int userId, string customerId)
        {
            int result = 0;

            string sql = @" UPDATE Customers
                            SET UserId = @userId 
                            WHERE CustomerId = @customerId";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int)).Value = userId;
            cmd.Parameters.Add(new SqlParameter("@customerId", SqlDbType.NVarChar)).Value = customerId;

            try
            {
                con.Open();

                result = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAdd Customer to User failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

     }
}
