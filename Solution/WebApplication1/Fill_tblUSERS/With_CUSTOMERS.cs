using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace WebApplication1.Fill_tblUSERS
{
    public class With_CUSTOMERS
    {
        private string cnnString = ConfigurationManager.
                                   ConnectionStrings["NorthwindConnectionString"].
                                   ConnectionString;

        public void CreateUserForEachCustomer()
        {
            SqlConnection con = new SqlConnection(cnnString);

            SqlCommand cmd = new SqlCommand(@"SELECT [CustomerID],[ContactName] 
                                            FROM [Northwind].[dbo].[Customers]", con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string customerId = reader["CustomerID"].ToString();
                string contactName = reader["ContactName"].ToString();

                string firstName = contactName.Split(' ')[0].ToLower();
                string lastName = contactName.Split(' ')[1].ToLower();

                int userId = InsertUserForCustomer(firstName, lastName);

                SetUserIdForCustomer(customerId, userId);
            }
        }

        public int InsertUserForCustomer(string firstName, string lastname)
        {
            SqlConnection sqlConnection = new SqlConnection(cnnString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = @"INSERT INTO tblUsers ([UserName], [Password], [Email], [Role] ) 
                                    VALUES(@UserName, @Password, @Email, @role); 
                                    SELECT CAST(scope_identity() AS int)";

            SqlParameter userNameParam = new SqlParameter();
            userNameParam.ParameterName = "@UserName";
            userNameParam.SqlDbType = SqlDbType.NVarChar;
            userNameParam.Value = firstName.Substring(0, 1).ToLower() + lastname.ToLower();

            SqlParameter passwordParam = new SqlParameter();
            passwordParam.ParameterName = "@Password";
            passwordParam.SqlDbType = SqlDbType.NVarChar;
            string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(firstName.ToLower(), "SHA1");
            passwordParam.Value = encryptedPassword;

            SqlParameter emailParam = new SqlParameter();
            emailParam.SqlDbType = SqlDbType.NVarChar;
            emailParam.ParameterName = "@Email";
            emailParam.Value = string.Format("{0}.{1}@northwind.com", firstName.ToLower(), lastname.ToLower());

            SqlParameter roleParam = new SqlParameter();
            roleParam.SqlDbType = SqlDbType.NVarChar;
            roleParam.ParameterName = "@role";
            roleParam.Value = "Customer";

            sqlCommand.Parameters.Add(userNameParam);
            sqlCommand.Parameters.Add(passwordParam);
            sqlCommand.Parameters.Add(emailParam);
            sqlCommand.Parameters.Add(roleParam);

            sqlConnection.Open();
            int userId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();

            return userId;

        }

        public void SetUserIdForCustomer(string customerId, int userId)
        {
            SqlConnection sqlConnection = new SqlConnection(cnnString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = @" UPDATE [dbo].[Customers]
                                        SET [UserId] = @userId 
                                        WHERE CustomerId = @customerId";

            SqlParameter userIdParam = new SqlParameter();
            userIdParam.SqlDbType = SqlDbType.Int;
            userIdParam.ParameterName = "@userId";
            userIdParam.Value = userId;

            SqlParameter customerIdParam = new SqlParameter();
            customerIdParam.SqlDbType = SqlDbType.NVarChar;
            customerIdParam.ParameterName = "@customerId";
            customerIdParam.Value = customerId;

            sqlCommand.Parameters.Add(userIdParam);
            sqlCommand.Parameters.Add(customerIdParam);

            sqlConnection.Open();
            sqlCommand.ExecuteScalar();
            sqlConnection.Close();

        }
    }
}