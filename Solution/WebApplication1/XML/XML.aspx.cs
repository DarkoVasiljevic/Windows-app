using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1.XML
{
    public partial class XML : Page
    {
        private static string conString = @"Data Source=EB-K0039\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        private DataSet readTable()
        {
            string sql = @"select *
                            from tblUsers;";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        private void writeXml(DataSet ds)
        {
            ds.WriteXml(Server.MapPath("WriteXml.xml"), XmlWriteMode.IgnoreSchema);
            ds.ReadXml(Server.MapPath("WriteXml.xml"));
            tbReadXML.Text = ds.GetXml();

            //Ucitavanje preko load Xmldocument
            //XmlDocument doc = new XmlDocument();
            //doc.Load(Server.MapPath("WriteXml.xml"));
            //tbReadXML.Text = doc.InnerXml;
        }

        private void writeSchema(DataSet ds)
        {
            ds.WriteXmlSchema(Server.MapPath("WriteSchema.xsd"));
            ds.ReadXmlSchema(Server.MapPath("WriteSchema.xsd"));
            tbReadSchema.Text = ds.GetXmlSchema();

            //Ucitavanje preko load Xmldocument
            //XmlDocument doc = new XmlDocument();
            //doc.Load(Server.MapPath("WriteSchema.xsd"));
            //tbReadSchema.Text = doc.SchemaInfo.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btReadXML_Click(object sender, EventArgs e)
        {
            writeXml(readTable());
        }

        protected void btReadSchema_Click(object sender, EventArgs e)
        {
            writeSchema(readTable());
        }

        protected void tbReadXML_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tbReadSchema_TextChanged(object sender, EventArgs e)
        {
        }

    }
}