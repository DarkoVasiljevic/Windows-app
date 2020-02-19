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
    public class With_EMPLOYEES
    {
        private string cnnString = ConfigurationManager.
                                   ConnectionStrings["NorthwindConnectionString"].
                                   ConnectionString;

        public void CreateUserForEachEmployee()
        {
            SqlConnection con = new SqlConnection(cnnString);

            SqlCommand cmd = new SqlCommand(@"SELECT [EmployeeID],[FirstName], [LastName] 
                                            FROM [Northwind].[dbo].[Employees]", con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int employeeId = (int)reader["EmployeeID"];
                string firstName = reader["FirstName"].ToString();
                string LastName = reader["LastName"].ToString();

                int userId = InsertUserForEmployee(firstName, LastName);
                SetUserIdForEmployee(employeeId, userId);
            }
        }

        public int InsertUserForEmployee(string firstName, string lastname)
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
            roleParam.Value = "Employee";

            sqlCommand.Parameters.Add(userNameParam);
            sqlCommand.Parameters.Add(passwordParam);
            sqlCommand.Parameters.Add(emailParam);
            sqlCommand.Parameters.Add(roleParam);

            sqlConnection.Open();
            int userId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();

            return userId;

        }

        public void SetUserIdForEmployee(int employeeId, int userId)
        {
            SqlConnection sqlConnection = new SqlConnection(cnnString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = @" UPDATE [dbo].[Employees]
                                        SET [UserId] = @userId 
                                        WHERE EmployeeID = @employeeId";

            SqlParameter userIdParam = new SqlParameter();
            userIdParam.SqlDbType = SqlDbType.Int;
            userIdParam.ParameterName = "@userId";
            userIdParam.Value = userId;

            SqlParameter employeeIdParam = new SqlParameter();
            employeeIdParam.SqlDbType = SqlDbType.Int;
            employeeIdParam.ParameterName = "@employeeId";
            employeeIdParam.Value = employeeId;

            sqlCommand.Parameters.Add(userIdParam);
            sqlCommand.Parameters.Add(employeeIdParam);

            sqlConnection.Open();
            sqlCommand.ExecuteScalar();
            sqlConnection.Close();

        }
    }
}