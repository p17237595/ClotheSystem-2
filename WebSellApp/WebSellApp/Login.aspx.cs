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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var conns = new MySqlConnection(ConfigurationManager.ConnectionStrings["silvioConnectionString"].ConnectionString);
            conns.Open();

            string checkuser = "select count(*) from user where username ='" + TextBoxUsername.Text + "'";
            //SqlCommand com = new SqlCommand(checkuser,conn);
            var com2 = new MySqlCommand(checkuser, conns);
            int temp = Convert.ToInt32(com2.ExecuteScalar().ToString());
            conns.Close();
            if (temp == 1)
            {
                conns.Open();
                string checkpass = "select count(*) from user where username ='" + TextBoxUsername.Text + "' and password = '" + TextBoxPass.Text + "'";
                //SqlCommand com = new SqlCommand(checkuser,conn);
                com2 = new MySqlCommand(checkpass, conns);
                temp = Convert.ToInt32(com2.ExecuteScalar().ToString());
                conns.Close();
                if (temp == 1)
                {
                    Session["New"] = TextBoxUsername.Text;
                    Response.Redirect("Manager.aspx");
                } else
                {
                    Response.Write("Password incorrect");
                }
            } else
            {
                Response.Write("User incorrect");
            }
        }
    }
}