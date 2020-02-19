using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;
using BussinesServices.cs;
using BussinesServices;

namespace Solution
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private CustomerServices service = new CustomerServices();

        private void btBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();
            try
            {
                List<Customers> customer = service.GetAllCustomers();

                foreach (var item in customer)
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append(item.CustomerId.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.CompanyName.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.ContactTitle.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.Adress.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.City.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.Region.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.PostCode.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.Country.ToString());
                    sb.Append("  |  ");
                    sb.Append(item.Phone.ToString());

                    rtbShow.AppendText(sb + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer showing error\n" + ex.Message);
                rtbShow.Clear();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();
        }
    }
}
