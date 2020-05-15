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
    public partial class ConfirmDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

            var conns = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
            conns.Open();
            var username = Session["New"];
            string checkuser = "delete from user where username ='" + username + "'";
            //SqlCommand com = new SqlCommand(checkuser,conn);
            var com2 = new MySqlCommand(checkuser, conns);
            com2.ExecuteNonQuery();
            conns.Close();
            Session["New"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}