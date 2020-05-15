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
            if (!Page.IsPostBack)
            {
                var id = Session["IDU"];
                string checkuser = "select username,password,email from user where id ='" + id + "'";
                var conns = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                conns.Open();
                var com2 = new MySqlCommand(checkuser, conns);
                MySqlDataReader reader = com2.ExecuteReader();
                reader.Read();
                TextBoxUser.Text = reader["username"].ToString();
                TextBoxPass.Text = reader["password"].ToString();
                TextBoxEmail.Text = reader["email"].ToString();
                conns.Close();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                var id = Session["IDU"];
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from user where username ='" + TextBoxUser.Text + "' and id <> '" + id + "' ";
                //SqlCommand com = new SqlCommand(checkuser,conn);
                var com2 = new MySqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com2.ExecuteScalar().ToString());
                conn.Close();
                if (temp == 1)
                {
                    Response.Write("User alredy exists");
                    return;
                }
                conn.Open();
                string updateuser = "UPDATE user SET username = @username, password = @password, email = @email where id = @id";
                var com = new MySqlCommand(updateuser, conn);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@username", TextBoxUser.Text);
                com.Parameters.AddWithValue("@password", TextBoxPass.Text);
                com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                com.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Manager.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manager.aspx");
        }
    }
}