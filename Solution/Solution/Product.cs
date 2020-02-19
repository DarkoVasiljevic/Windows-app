using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
using BussinesServices;

namespace Solution
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private ProductServices service = new ProductServices();

        private void btBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void refreshCombos()
        {
            comboRead(cmbAllProducts);
            
        }

        private void comboRead(ComboBox cmb)
        {
            try
            {
                List<Products> products = service.GetAllProduct();

                cmb.DataSource = products;
                cmb.DisplayMember = "ProductName";
                cmb.ValueMember = "ProductId";
                cmb.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("GetALLProduct failed\n" + ex.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            comboRead(cmbAllProducts);
        }

       

        private void lbProducts_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void clearProduct( string name, int? suppId, int? catId, string quantity, decimal? price,
                            short? order, short? reorder, short? stock )
        {
            tbCategoryId.Clear();
            tbOrder.Clear();
            tbPrice.Clear();
            tbProductName.Clear();
            tbQuantity.Clear();
            tbReorder.Clear();
            tbStock.Clear();
            tbSupplierId.Clear();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string name = tbProductName.Text;
            int? suppId = Convert.ToInt32(tbSupplierId.Text);
            int? catId = Convert.ToInt32(tbCategoryId.Text);
            string quantity = tbQuantity.Text;
            decimal? price = Convert.ToDecimal(tbPrice.Text);
            short? order = Convert.ToInt16(tbOrder.Text);
            short? reorder = Convert.ToInt16(tbReorder.Text);
            short? stock = Convert.ToInt16(tbStock.Text);
            //bool disco = Convert.ToBoolean(tbDiscounted.Text);

            try
            {
                int result = service.AddProduct(name, suppId, catId, quantity, price,
                                                stock, order, reorder, true);
                MessageBox.Show("Product added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not added\n" + ex.Message);
            }

            refreshCombos();

            clearProduct(name, suppId, catId, quantity, price,
                         stock, order, reorder);
        }
    }
}
