using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Model;
using BussinesServices.cs;
using BussinesServices;
using System.Web.Security;

namespace WebApplication1.Registration
{
    public partial class Register : Page
    {
        CustomerServices customerService = new CustomerServices();
        EmployeeServices employeeService = new EmployeeServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            lbInfo.Visible = false;
            lbInfoCustomer.Visible = false;
        }  

        protected void tbUserName_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tbPasswd_TextChanged(object sender, EventArgs e)
        {
        }

        protected void btRegEmployee_Click(object sender, EventArgs e)
        {
            rfReg.Enabled = false;

            string fName = tbFirstName.Text.ToString();
            string lName = tbLastName.Text.ToString();

            Random random = new Random();
            string title = "Sailer " +
                            new string(Enumerable.Repeat("abcdefghijklmnoprsyqwxz0123456789", 3).
                                        Select(s => s[random.Next(s.Length)]).ToArray());

            int employeeId = 0;
            int userId = 0;
            int success = 0;

            Employees employee = employeeService.IsEmployeeExist(fName.Trim(), lName.Trim());
            if (employee.FirstName == fName && employee.LastName == lName)
            {
                lbInfo.Visible = true;
                lbInfo.Text = "Vec ste registrovani: " + fName + " " + lName + " !";

                // Funkcija - Omoguciti resetovanje registracije

                tbCustomer.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
            }
            else
            {
                employeeId = employeeService.insertEmployeeByName(fName, lName, title);

                string passwd = FormsAuthentication.
                                HashPasswordForStoringInConfigFile(fName.ToLower(), "SHA1");
                userId = employeeService.insertEmployeeToUser(fName, lName, passwd);

                success = employeeService.updateUserId(userId, employeeId);

                lbInfo.Visible = true;

                if (success != 0)
                    lbInfo.Text = "Uspesno ste registrovani: " + fName + " " + lName + " !";
                else
                    lbInfo.Text = "Doslo je do greske !" + userId.ToString();

                tbCustomer.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
            }

        }

        protected void btRegCustomer_Click(object sender, EventArgs e)
        {
            rvPasswd.Enabled = false;
            rvUserName.Enabled = false;

            int result = 0;
            int userId = 0;
            int success = 0;

            string contactName = tbCustomer.Text.ToString();

            Random random = new Random();
            string companyName = "Test Autentifikacije " + 
                                  new string(Enumerable.Repeat("abcdefghijklmnoprsyqwxz0123456789", 2).
                                        Select(s => s[random.Next(s.Length)]).ToArray());

            string customerId = new string(Enumerable.Repeat("ABCDEFGHIJKLOMNPRSTZQWX0123456789", 5).
                                        Select(s => s[random.Next(s.Length)]).ToArray());

            string name = customerService.GetCustomerName(contactName.Trim());
            if (name == contactName)
            {
                lbInfoCustomer.Visible = true;
                lbInfoCustomer.Text = "Vec ste registrovani: " + name + " !";

                // Funkcija - Omoguciti resetovanje registracije

                tbCustomer.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
            }
            else
            {
                result = customerService.insertCustomerByContactName(
                                                customerId, companyName, contactName);

                string firstName = contactName.Split(' ')[0].ToLower();
                string lastName = contactName.Split(' ')[1].ToLower();
                string passwd = FormsAuthentication.
                                HashPasswordForStoringInConfigFile(firstName.ToLower(), "SHA1");

                userId = customerService.insertCustomerToUser(firstName, lastName, passwd);

                success = customerService.updateUserId(userId, customerId);

                lbInfoCustomer.Visible = true;

                if (success != 0)
                    lbInfoCustomer.Text = "Uspesno ste registrovani: " + contactName + " !";
                else
                    lbInfoCustomer.Text = "Doslo je do greske !";

                tbCustomer.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
            }
        }

        protected void tbCustomer_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tbLastName_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tbFirstName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}