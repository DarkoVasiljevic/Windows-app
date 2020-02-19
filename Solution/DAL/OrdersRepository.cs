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
    class OrdersRepository : InterfaceDal<Orders, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        private SqlConnection con = new SqlConnection(conString);

        public int AddSingle(Orders single)
        {
            int result = 0;
            string sql = @"insert into Orders 
                            values ( @customerId, @employeeId);";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@customerId", SqlDbType.NChar, 5)).Value = single.CustomerId;
            cmd.Parameters.Add(new SqlParameter("@employeeId", SqlDbType.Int)).Value = single.EmployeeId;

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

        public List<Orders> GetAll()
        {
            throw new NotImplementedException();
        }

        public Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Orders GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(Orders single)
        {
            throw new NotImplementedException();
        }
    }
}
