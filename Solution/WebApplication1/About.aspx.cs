using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;
using BussinesServices;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] == null || Session["passwd"] == null)
            //{
            //    Response.Redirect("LogIN.aspx");
            //}

            Response.Write("<br />");
            Response.Write("<br />");

            if (HttpContext.Current.User.IsInRole("Employee"))
            {
                Response.Write(HttpContext.Current.User.Identity.Name.ToString());
            }

            //test EVENT

            //kada kontrola vec ima neki event samo mu dodamo nas
            btTestEvent.Click += (o, i) => { testEvent(); };
            tbEvent.Load += (o, i) => { tbEvent.Text = "WE call EVENT on LOAD!"; };

            //kada kontrola nema event
            //prvo dodamo event i onda mu kazemo sta da radi kad se on pozove

        }

        private void testEvent()
        {
            lbEvent.Text = "AFTER WE call EVENT!";
        }

        protected void btTestEvent_Click(object sender, EventArgs e)
        {      
        }
    }
}