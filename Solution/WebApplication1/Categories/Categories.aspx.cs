using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;
using BussinesServices;
using System.Text;

namespace WebApplication1
{
    public partial class categories : System.Web.UI.Page
    {
        CategoryServices categoryService = new CategoryServices();
        List<Categories> listOfCategories;

        private void loadDropDownList()
        {
            ddlCategories.DataSource = categoryService.GetAllCategory();
            ddlCategories.DataTextField = "CategoryName";
            ddlCategories.DataValueField = "CategoryId";
            ddlCategories.DataBind();

            ddlCategories.Items.Insert(0, new ListItem("View category details", "-"));
        }
        private void loadGridView()
        {
            listOfCategories = categoryService.GetAllCategory();
            gvShowAll.DataSource = listOfCategories;
            gvShowAll.DataBind();
        }    

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] == null || Session["passwd"] == null)
            //{
            //    Response.Redirect("LogIN.aspx");
            //}

            if (!IsPostBack)
            {
                loadDropDownList();

                loadGridView();
                gvShowAll.Visible = false;
            }
            tbCategoryId.Enabled = false;
            tbCategoryName.Enabled = false;
            tbCtegoryDesc.Enabled = false;
        }

        protected void btShowALL_Click1(object sender, EventArgs e)
        {

            if (gvShowAll.Visible == true)
            {
                gvShowAll.Visible = false;
                btShowALL.Text = "Show";
            }
            else
            {
                gvShowAll.Visible = true;
                btShowALL.Text = "Hide";
            }
        }

        protected void gwShowAll_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategories.SelectedValue == "-")
            {
                tbCategoryId.Text = "";
                tbCategoryName.Text = "";
                tbCtegoryDesc.Text = "";
            }
            else
            {

                int id = Convert.ToInt32(ddlCategories.SelectedValue);

                Categories cat = categoryService.GetByIdCategory(id);

                tbCategoryId.Text = cat.CategoryId.ToString();
                tbCategoryName.Text = cat.CategoryName.ToString();
                tbCtegoryDesc.Text = cat.Description.ToString();
            }
        }

        protected void tbCategoryId_TextChanged(object sender, EventArgs e)
        {          
        }

        protected void tbCategoryName_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tbCtegoryDesc_TextChanged(object sender, EventArgs e)
        {
        }

        protected void cbDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void rbInsert_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}