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
    public class SuppliersRepository : InterfaceDal<Suppliers, int, string>
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public int AddSingle(Suppliers single)
        {
            int result = 0;
            string sql = @"insert into Suppliers 
                            values ( @supplierId, @companyName, @contactName, @contactTitle, @adress
                                     @city, @region, @postCode, @country, @phone, @fax, @homepage);";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@supplierId", SqlDbType.Int)).Value = single.SupplierId;
            cmd.Parameters.Add(new SqlParameter("@companyName", SqlDbType.NVarChar, 40)).Value = single.CompanyName;
            cmd.Parameters.Add(new SqlParameter("@contactName", SqlDbType.NVarChar, 30)).Value = single.ContactName;
            cmd.Parameters.Add(new SqlParameter("@contactTitle", SqlDbType.NVarChar, 30)).Value = single.ContactTitle;
            cmd.Parameters.Add(new SqlParameter("@adress", SqlDbType.NVarChar, 60)).Value = single.Adress;
            cmd.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar, 15)).Value = single.City;
            cmd.Parameters.Add(new SqlParameter("@region", SqlDbType.NVarChar, 15)).Value = single.Region;
            cmd.Parameters.Add(new SqlParameter("@postCode", SqlDbType.NVarChar, 10)).Value = single.PostalCode;
            cmd.Parameters.Add(new SqlParameter("@country", SqlDbType.NVarChar, 15)).Value = single.Country;
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 24)).Value = single.Phone;
            cmd.Parameters.Add(new SqlParameter("@fax", SqlDbType.NVarChar, 24)).Value = single.Fax;
            cmd.Parameters.Add(new SqlParameter("@homepage", SqlDbType.NText)).Value = single.Homepage;

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

        public int DeleteSingle(int id)
        {
            int result = 0;
            string sql = @"delete 
                            from Suppliers 
                            where supplierId = @supplierId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@supplierId", SqlDbType.Int)).Value = id;

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

        public List<Suppliers> GetAll()
        {
            List<Suppliers> supplier = new List<Suppliers>();

            string sql = @"select *
                            from Suppliers";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int supplierId = Convert.ToInt32(rdr[0]);
                    string companyName = Convert.ToString(rdr[1]);
                    string contactName = Convert.ToString(rdr[2]);
                    string contactTitle = Convert.ToString(rdr[3]);
                    string adress = Convert.ToString(rdr[4]);
                    string city = Convert.ToString(rdr[5]);
                    string region = Convert.ToString(rdr[6]);
                    string postCode = Convert.ToString(rdr[7]);
                    string country = Convert.ToString(rdr[8]);
                    string phone = Convert.ToString(rdr[9]);
                    string fax = Convert.ToString(rdr[10]);
                    string homepage = Convert.ToString(rdr[1]);

                    Suppliers p = new Suppliers(supplierId, companyName, contactName, contactTitle,
                                                adress, city, region, postCode, country, phone, fax, homepage);
                    supplier.Add(p);
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

            return supplier;
        }

        public Suppliers GetById(int id)
        {
            Suppliers p = new Suppliers();

            string sql = @"select *
                            from Suppliers
                            where supplierId = @supplierId";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@supplierId", SqlDbType.Int)).Value = id;

            SqlDataReader rdr = null;

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int supplierId = Convert.ToInt32(rdr[0]);
                    string companyName = Convert.ToString(rdr[1]);
                    string contactName = Convert.ToString(rdr[2]);
                    string contactTitle = Convert.ToString(rdr[3]);
                    string adress = Convert.ToString(rdr[4]);
                    string city = Convert.ToString(rdr[5]);
                    string region = Convert.ToString(rdr[6]);
                    string postCode = Convert.ToString(rdr[7]);
                    string country = Convert.ToString(rdr[8]);
                    string phone = Convert.ToString(rdr[9]);
                    string fax = Convert.ToString(rdr[10]);
                    string homepage = Convert.ToString(rdr[1]);

                    p = new Suppliers(supplierId, companyName, contactName, contactTitle,
                                      adress, city, region, postCode, country, phone, fax, homepage);
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

        public Suppliers GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(Suppliers single)
        {
            int result = 0;
            string sql = @"update Suppliers
                            set ( supplierId = @supplierId, companyName = @companyName, contactName = @contactName,
                                  contactTitle = @contactTitle, adress = @adress, city = @city, region = @region, 
                                  postCode = @postCode, country = @country, phone = @phone, fax = @fax, homepage = @homepage)
                            where supplierId = @supplierId;";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@supplierId", SqlDbType.Int)).Value = single.SupplierId;
            cmd.Parameters.Add(new SqlParameter("@companyName", SqlDbType.NVarChar, 40)).Value = single.CompanyName;
            cmd.Parameters.Add(new SqlParameter("@contactName", SqlDbType.NVarChar, 30)).Value = single.ContactName;
            cmd.Parameters.Add(new SqlParameter("@contactTitle", SqlDbType.NVarChar, 30)).Value = single.ContactTitle;
            cmd.Parameters.Add(new SqlParameter("@adress", SqlDbType.NVarChar, 60)).Value = single.Adress;
            cmd.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar, 15)).Value = single.City;
            cmd.Parameters.Add(new SqlParameter("@region", SqlDbType.NVarChar, 15)).Value = single.Region;
            cmd.Parameters.Add(new SqlParameter("@postCode", SqlDbType.NVarChar, 10)).Value = single.PostalCode;
            cmd.Parameters.Add(new SqlParameter("@country", SqlDbType.NVarChar, 15)).Value = single.Country;
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 24)).Value = single.Phone;
            cmd.Parameters.Add(new SqlParameter("@fax", SqlDbType.NVarChar, 24)).Value = single.Fax;
            cmd.Parameters.Add(new SqlParameter("@homepage", SqlDbType.NText)).Value = single.Homepage;

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
