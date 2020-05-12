using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace WebSellApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null || Session["New"] != "Admin" )
            {
                Session["New"] = null;
                Response.Write("A normal user cant see this page");
                Response.Redirect("Login.aspx");
            }
            if (Session["IDU"] == null )
            {
                Response.Write("Error in User ID");
                Response.Redirect("Manager.aspx");
            }
        }

        protected void DeleteUser_Click(object sender, EventArgs e)
        {
            try { 
                var conns = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                conns.Open();
                var id = Session["IDU"];
                string checkuser = "delete from user where id ='" + id + "'";
                //SqlCommand com = new SqlCommand(checkuser,conn);
                var com2 = new MySqlCommand(checkuser, conns);
                com2.ExecuteNonQuery();
                conns.Close();
                Response.Redirect("Manager.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}