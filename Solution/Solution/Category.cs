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
using BussinesServices;
using System.IO;

namespace Solution
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private CategoryServices service = new CategoryServices();

        private void refreshCombos()
        {
            comboRead(cmbUpdateOldName);
            comboRead(cmbShowName);
            comboRead(cmbDeleteName);
        }

        private void comboRead(ComboBox cmb)
        {
            try
            {
                List<Categories> categories = service.GetAllCategory();

                cmb.DataSource = categories;
                cmb.DisplayMember = "CategoryName";
                cmb.ValueMember = "CategoryId";
                cmb.SelectedIndex = -1;
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetALLCategory failed\n" + ex.Message);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            comboRead(cmbShowName);
            comboRead(cmbDeleteName);
            comboRead(cmbUpdateOldName);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();
            try
            {
                List<Categories> category = service.GetAllCategory();

                foreach (var item in category)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(item.CategoryId.ToString());
                    sb.Append(", ");
                    sb.Append(item.CategoryName.ToString());
                    sb.Append(", ");
                    sb.Append(item.Description.ToString());

                    rtbShow.AppendText(sb + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category showing error\n" + ex.Message);
                rtbShow.Clear();
            }

        }

        private void btBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();
        }

        private void btShowOne_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();

            string name = cmbShowName.Text.Trim();

            Categories o = (Categories)cmbDeleteName.SelectedItem;

            try
            {
                Categories category = service.GetByNameCategory(name);

                StringBuilder sb = new StringBuilder();
                sb.Append(category.CategoryId.ToString());
                sb.Append(", ");
                sb.Append(category.CategoryName.ToString());
                sb.Append(", ");
                sb.Append(category.Description.ToString());

                rtbShow.AppendText(sb + "\n");

                //byte[] image = service.GetPictyreByName(category.CategoryName);
                //if (image == null)
                //{
                //    pbImage.Image = null;
                //}
                //else
                //{
                //    MemoryStream ms = new MemoryStream();
                //    pbImage.Image = Image.FromStream(ms);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category showing error\n" + ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            string name = cmbDeleteName.Text.Trim();

            try
            {
                Categories catName = service.GetByNameCategory(name);
                int id = catName.CategoryId;

                int result = service.DeleteCategory(id);
                MessageBox.Show("Category deleted");
            }
            catch (Exception ex)
            {      
                MessageBox.Show("Category not deleted\n" + ex.Message);
            }

            refreshCombos();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string name = tbInsertName.Text;
            string desc = tbInsertDesc.Text;

            try
            {
                int result = service.AddCategory(name, desc);
                MessageBox.Show("Category added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category not added\n" + ex.Message);
            }

            refreshCombos();

            tbInsertName.Clear();
            tbInsertDesc.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string oldName = cmbUpdateOldName.Text.Trim();

            string newName = tbUpdateName.Text.ToString();
            string newDesc = tbUpdateDesc.Text.ToString();

            try
            {
                Categories catName = service.GetByNameCategory(oldName);
                int id = catName.CategoryId;

                int result = service.UpdateCategory(id, newName, newDesc);
                MessageBox.Show("Category updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category not updated\n" + ex.Message);
            }

            refreshCombos();

            tbUpdateName.Clear();
            tbUpdateDesc.Clear();
        }

        private void cmbShowName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Categories category = service.GetByNameCategory(cmbShowName.Text);
                tbShowId.Text = category.CategoryId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void cmbDeleteName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Categories category = service.GetByNameCategory(cmbDeleteName.Text);
                tbDeleteOne.Text = category.CategoryId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbShowId_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbDeleteOne_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbUpdateOldName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
