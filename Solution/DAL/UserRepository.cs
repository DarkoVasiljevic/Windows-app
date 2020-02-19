using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Model;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DAL
{
    public class UserRepository
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public Users GetUserByName(string name)
        {
            Users u = new Users();

            string sql = @"select *
                           from tblUsers
                           where UserName = @name";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar)).Value = name;

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int userId = Convert.ToInt32(rdr[0]);
                    string userName = rdr[1] == DBNull.Value ? null : Convert.ToString(rdr[1]).Trim();
                    string passwd = rdr[2] == DBNull.Value ? null : Convert.ToString(rdr[2]);
                    string email = rdr[3] == DBNull.Value ? null : Convert.ToString(rdr[3]);
                    string role = rdr[4] == DBNull.Value ? null : Convert.ToString(rdr[4]);
                    int retryAtempts = rdr[5] == DBNull.Value ? 0 : Convert.ToInt32(rdr[5]);
                    byte isLocked = rdr[6] == DBNull.Value ? default(byte) : Convert.ToByte(rdr[6]);
                    DateTime date = rdr[7] == DBNull.Value ? default(DateTime) : Convert.ToDateTime(rdr[7]);

                    u = new Users(userId, userName, passwd, email, role, 
                                    retryAtempts, isLocked, date);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGetUserByName failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
                rdr.Close();
            }

            return u;
        }

        public int UpdateUser(Users user)
        {
            int result = 0;
            string sql = @" update tblUsers
                            set UserName = @userName, Password = @password, Email = @email,
                                Role = @role, RetryAttempts = @retryAttempts, 
                                IsLocked = @isLocked, lockedDateTime = @lockedDateTime
                            where Id = @userId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int)).Value = user.UserId;
            cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.NVarChar)).Value = user.UserName;
            cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar)).Value = user.UserPasswd;
            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar)).Value = user.Email;
            cmd.Parameters.Add(new SqlParameter("@role", SqlDbType.NVarChar)).Value = user.Role;
            cmd.Parameters.Add(new SqlParameter("@retryAttempts", SqlDbType.Int)).Value = user.RetryAtempts;
            cmd.Parameters.Add(new SqlParameter("@isLocked", SqlDbType.Bit)).Value = user.IsLocked;
            cmd.Parameters.Add(new SqlParameter("@lockedDateTime", SqlDbType.DateTime)).Value = user.LockedDate;

            try
            {
                con.Open();

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nUpdate User failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }
    }
}
