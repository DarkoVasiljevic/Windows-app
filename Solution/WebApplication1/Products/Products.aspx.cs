using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;
using BussinesServices;
using System.Data;

namespace WebApplication1
{
    public partial class Products : System.Web.UI.Page
    {
        ProductServices service = new ProductServices();
        List<Model.Products> listOfProducts;

        private void loadGridView()
        {
            listOfProducts = service.GetAllProduct();

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Name", typeof(string)),
                                                    new DataColumn("Price", typeof(decimal)) });

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                dt.Rows.Add(listOfProducts[i].ProductName, listOfProducts[i].UnitPrice);
            }

            gvProducts.DataSource = dt;

            gvProducts.DataBind();
        }

        private void loadDropDownList()
        {
            ddlChooseProduct.DataSource = service.GetAllProduct();
            ddlChooseProduct.DataTextField = "ProductName";
            ddlChooseProduct.DataValueField = "ProductId";

            ddlChooseProduct.DataBind();

            ddlChooseProduct.Items.Insert(0, new ListItem("Chose product to buy", "-"));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] == null || Session["passwd"] == null)
            //{
            //    Response.Redirect("LogIN.aspx");
            //}

            if (!IsPostBack)
            {
                loadGridView();
                gvProducts.Visible = false;

                loadDropDownList();

                tbInform.Visible = false;
                lbInfo.Visible = false;
            }

            tbPrice.Enabled = false;
            tbInform.Enabled = false;

            btConfirmBuy.Visible = false;          
        }

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btShowAll_Click(object sender, EventArgs e)
        {
            if (gvProducts.Visible == true)
            {
                gvProducts.Visible = false;
                btShowAll.Text = "Show all products";
            }
            else
            {
                gvProducts.Visible = true;
                btShowAll.Text = "Hide products";
            }
        }

        protected void ddlChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlChooseProduct.SelectedValue == "-")
            {
                tbPrice.Text = "";
                tbQuantity.Text = "";
            }
            else
            {
                int id = Convert.ToInt32(ddlChooseProduct.SelectedValue);

                Model.Products prod = service.GetByIdProduct(id);

                tbPrice.Text = String.Format("{0:0.00}", prod.UnitPrice);
            }
        }

        protected void tbPrice_TextChanged(object sender, EventArgs e)
        {
        }

        protected void btConfirm_Click(object sender, EventArgs e)
        {
            tbInform.Visible = true;
            btConfirmBuy.Visible = true;
            btConfirm.Visible = false;
            lbInfo.Visible = true;

            tbInform.Text = @"Name: " + ddlChooseProduct.SelectedItem.Text + "\n"
                            + "Price: " + tbPrice.Text + " rsd" + "\n"
                            + "Quantity: " + tbQuantity.Text + "\n"
                            + "Total cost: " + Convert.ToDecimal(tbPrice.Text)* Convert.ToDecimal(tbQuantity.Text) + " rsd";
        }

        protected void btConfirmBuy_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Basket?name=" + ddlChooseProduct.SelectedItem.Text +
            //                  "&price=" + tbPrice.Text +
            //                  "&quantity=" + tbQuantity.Text);

            Session["id"] = ddlChooseProduct.SelectedValue;
            Session["name"] = ddlChooseProduct.SelectedItem.Text;
            Session["price"] = tbPrice.Text;
            Session["quantity"] = tbQuantity.Text;

            Response.Redirect("~/Basket/Basket.aspx");

            tbPrice.Text = "";
            tbQuantity.Text = "";
            tbInform.Text = "";

            tbInform.Visible = false;
            lbInfo.Visible = false;
        }

        protected void tbInform_TextChanged(object sender, EventArgs e)
        {
        }
    }
}