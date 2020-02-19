using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesServices.cs;

namespace WebApplication1
{
    public partial class Basket : System.Web.UI.Page
    {
        OrderDetailsServices service = new OrderDetailsServices();

        private short nameCheckAndReturnQuantity(int id)
        {
            var lista = (Dictionary<int, Tuple<string, decimal, short, decimal>>)Session["basket"];

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    if (item.Key == id)
                    {
                        return item.Value.Item3;
                    }
                }
            }
            return 0;
        }

        private DataTable dt = new DataTable();
        private void loadGridView()
        {           
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                                                    new DataColumn("Price per unit", typeof(decimal)),
                                                    new DataColumn("Quantity", typeof(int)),
                                                    new DataColumn("Total product price", typeof(decimal))
                                                  });

            int id = Convert.ToInt32(Session["id"]);
            string name = (string)Session["name"];
            
            //if (null == Request.QueryString["name"].ToString())
            //    return;
            //else
            //    name = Request.QueryString["name"].ToString();

            //decimal price = Convert.ToDecimal(Request.QueryString["price"]);
            //int quantity = Convert.ToInt32(Request.QueryString["quantity"]);

            decimal price = Convert.ToDecimal(Session["price"]);
            short quantity = Convert.ToInt16(Session["quantity"]);

            short q = nameCheckAndReturnQuantity(id);
            if (q != 0)
            {
                quantity += q;
            }
                      
            decimal totalProductCost = price * quantity;

            if (Session["basket"] == null)
            {
                Dictionary<int, Tuple<string, decimal, short, decimal>> orders = 
                    new Dictionary<int, Tuple<string, decimal, short, decimal>>();

                if (gvProductsToBuy.Visible == true)
                {
                    orders.Add(id, Tuple.Create(name, price, quantity, totalProductCost));
                    Session["basket"] = orders;
                }
            }
            else
            {
                var list = (Dictionary<int, Tuple<string, decimal, short, decimal>>)Session["basket"];
                if (q == 0)
                {
                    list.Add(id, Tuple.Create(name, price, quantity, totalProductCost));
                }
                else
                {
                    list[id] = Tuple.Create(name, price, quantity, totalProductCost);
                }
                Session["basket"] = list;
            }

            decimal sum = 0;
           
            foreach (var item in (Dictionary<int, Tuple<string, decimal, short, decimal>>)Session["basket"])
            { 
                dt.Rows.Add(item.Value.Item1, item.Value.Item2, item.Value.Item3, item.Value.Item4);
                sum += item.Value.Item4;                      
            }

            gvProductsToBuy.DataSource = dt;
            gvProductsToBuy.DataBind();

            lbTotalCost.Text = "Ukupna cena vasih proizvoda je: " + sum + " rsd";
           
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
            }

            lbSuccessBuy.Visible = false;
    }

        protected void gvProductsToBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btAddToBase_Click(object sender, EventArgs e)
        {
            string customerId = "QUEEN";
            int employeeId = 7;

            if (0 != Convert.ToInt16(Session["quantity"]))
            {

                int result = service.InsertNewOrder(customerId, employeeId);

                if (result > 0)
                {
                    int orderId = service.GetOrderId(customerId, employeeId);

                    if (orderId > 0)
                    {
                        var collection = (Dictionary<int, Tuple<string, decimal, short, decimal>>)Session["basket"];
                        foreach (var item in collection)
                        {
                            int success = service.InsertNewOrderDetails(orderId, item.Key, item.Value.Item2,
                                                                        item.Value.Item3, 0.5m);
                        }

                        lbSuccessBuy.Visible = true;
                        lbInfo.Visible = false;
                        lbTotalCost.Visible = false;
                        gvProductsToBuy.Visible = false;
                        btAddToBase.Visible = false;

                    }
                }

                Session.Remove("basket");
            }
        }

        protected void btBackToProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products/Products.aspx");
        }

    }
}