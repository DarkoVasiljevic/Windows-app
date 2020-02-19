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
    public class EmployeesRepository : InterfaceDal<Employees, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public int AddSingle(Employees single)
        {
            throw new NotImplementedException();
        }

        public int DeleteSingle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employees GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employees GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(Employees single)
        {
            throw new NotImplementedException();
        }

        public Employees IsEmployeeExist(string fName, string lName)
        {
            Employees e = new Employees();

            string sql = @"select FirstName, LastName
                            from Employees
                            where FirstName = @fName and LastName = @lName";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@fName", System.Data.SqlDbType.NVarChar)).Value = fName;
            cmd.Parameters.Add(new SqlParameter("@lName", System.Data.SqlDbType.NVarChar)).Value = lName;

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string firstName = Convert.ToString(rdr[0]);
                    string lastName = Convert.ToString(rdr[1]);

                    e = new Employees(firstName.Trim(), lastName.Trim());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nGeting Employee failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return e;
        }

        public int insertEmployeeByName(string fName, string lName, string title)
        {
            int employeeId = 0;
            string sql = @"insert into Employees (firstName, lastName, title)
                            values (@firstName, @lastName, @title);
                            SELECT CAST(scope_identity() AS int)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar)).Value = fName;
            cmd.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar)).Value = lName;
            cmd.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar)).Value = title;

            try
            {
                con.Open();

                employeeId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAdd Employee failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return employeeId;
        }

        public int insertEmployeeToUser(string firstName, string lastName, string passwd)
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

            cmd.Parameters.Add(new SqlParameter("@Role", SqlDbType.NVarChar)).Value = "Employee";

            try
            {
                con.Open();

                userId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAdd Employee to User failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return userId;
        }

        public int updateUserId(int userId, int employeeId)
        {
            int result = 0;

            string sql = @" UPDATE Employees
                            SET UserID = @userId 
                            WHERE EmployeeId = @employeeId";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int)).Value = userId;
            cmd.Parameters.Add(new SqlParameter("@employeeId", SqlDbType.Int)).Value = employeeId;

            try
            {
                con.Open();

                result = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("From DAL: \nAdd Employee to User failed\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }
    }
}

