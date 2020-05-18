using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSellApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                Label_welcome.Text += Session["New"].ToString();
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }

        protected void B_logout_Click1(object sender, EventArgs e)
        {
            Session["New"] = null;
            Response.Write("Good Bye");
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeUserInformation.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfirmDelete.aspx");
        }
    }
}