using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LogOUT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] != null || Session["passwd"] != null)
            //{
            //    Session.RemoveAll();
            //}

            Response.Redirect("~/LogIN/LogIN.aspx");
            FormsAuthentication.SignOut();

        }
    }
}