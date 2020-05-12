﻿using System;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {


                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                var conns = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                conns.Open();

                string checkuser = "select count(*) from user where username ='" + TextBoxUsername.Text + "'";
                //SqlCommand com = new SqlCommand(checkuser,conn);
                var com2 = new MySqlCommand(checkuser, conns);
                int temp = Convert.ToInt32(com2.ExecuteScalar().ToString());
                conns.Close();
                if (temp >= 1)
                {
                    Response.Write("User alredy exists");
                    return;
                }

                

            try
            {
                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
                conn.Open();

                string insertUser = "INSERT INTO user (id,username, password, email, role) VALUES (NULL, @username, @pass, @email, 2)";
                //SqlCommand com = new SqlCommand(insertUser, conn);
                var com = new MySqlCommand(insertUser, conn);
                com.Parameters.AddWithValue("@username", TextBoxUsername.Text);
                com.Parameters.AddWithValue("@pass", TextBoxPass.Text);
                com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Manager.aspx");
                Response.Write("Registration is successful");


                conn.Close();

            }
            catch(Exception ex) {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}