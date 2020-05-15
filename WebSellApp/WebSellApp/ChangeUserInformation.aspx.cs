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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                if (!Page.IsPostBack && !IsCallback)
                {
                    try
                    {
                        var userName = Session["New"];
                        string checkuser = "select id,password,email, CustomerName, CustomerAddress, CustomerCardName, CustomerCardNo, CustomerCardExpire from user inner join customer on customer.user = user.id where username ='" + userName + "'";
                        var conns = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);

                        conns.Open();
                        var com2 = new MySqlCommand(checkuser, conns);
                        MySqlDataReader reader = com2.ExecuteReader();
                        reader.Read();
                        TextBoxPass.Text = reader["password"].ToString();
                        TextBoxEmail.Text = reader["email"].ToString();
                        Session["IDC"] = reader["id"].ToString();
                        TextBoxCName.Text = reader["CustomerName"].ToString();
                        TextBoxCAddress.Text = reader["CustomerAddress"].ToString();
                        TextBoxCCName.Text = reader["CustomerCardName"].ToString();
                        TextBoxCCNo.Text = reader["CustomerCardNo"].ToString();
                        TextBoxCCExpire.Text = reader["CustomerCardExpire"].ToString();
                        conns.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error:" + ex.ToString());
                    }
                }
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["IDC"] = null;
            Response.Redirect("UserHome.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                conn.Open();
                string updatecustomer = "UPDATE customer SET  CustomerName = @cname, CustomerAddress = @caddress, CustomerCardName = @ccname, CustomerCardNo = @ccno, CustomerCardExpire = @cce where user = @userid";
                var com = new MySqlCommand(updatecustomer, conn);
                com.Parameters.AddWithValue("@cname", TextBoxCName.Text);
                com.Parameters.AddWithValue("@caddress", TextBoxCAddress.Text);
                com.Parameters.AddWithValue("@ccname", TextBoxCCName.Text);
                com.Parameters.AddWithValue("@ccno", TextBoxCCNo.Text);
                com.Parameters.AddWithValue("@cce", TextBoxCCExpire.Text);
                com.Parameters.AddWithValue("@userid", Session["IDC"]);
                com.ExecuteNonQuery();
                var username = Session["New"];
                string updateuser = "UPDATE user SET  password = @password, email = @email where username = @username";
                var com2 = new MySqlCommand(updateuser, conn);
                com2.Parameters.AddWithValue("@username", username);
                com2.Parameters.AddWithValue("@password", TextBoxPass.Text);
                com2.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                com2.ExecuteNonQuery();
                conn.Close();      
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
            Session["IDC"] = null;
            Response.Redirect("UserHome.aspx");
        }
    }
}