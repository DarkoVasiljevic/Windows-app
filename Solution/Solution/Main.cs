using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private static string selectItem;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectItem = cmbox.Items[cmbox.SelectedIndex].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (selectItem == "Categories")
            {
                this.Hide();
                Category formCategory = new Category();
                formCategory.Show();
            }
            else if (selectItem == "Suppliers")
            {
                this.Hide();
                Supplier formSupplier = new Supplier();
                formSupplier.Show();
            }
            else if (selectItem == "Products")
            {
                this.Hide();
                Product formProduct = new Product();
                formProduct.Show();
            }
            else if (selectItem == "Orders")
            {
                this.Hide();
                Orders  formOrder = new Orders();
                formOrder.Show();
            }
            else if (selectItem == "OrderDetails")
            {
                this.Hide();
                OrderDetails formOrderDetails = new OrderDetails();
                formOrderDetails.Show();
            }
            else if (selectItem == "Customers")
            {
                this.Hide();
                Customer formCustomer = new Customer();
                formCustomer.Show();
            }
        }
    }
}
