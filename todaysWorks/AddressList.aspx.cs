using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace todaysWorks
{
    public partial class AddressList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Store -1 into the session object to indicate this is a new record
            Session["AddressNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnAddress.aspx");
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //create an instance of the address collection
            ClsAddressCollection Addresses = new ClsAddressCollection();
            Addresses.ReportByPostCode(txtFilter.Text);
            lstAddressList.DataSource = Addresses.AddressList;
            //set the name of the primary key
            lstAddressList.DataValueField = "AddressNo";
            //set the name of the field to display
            lstAddressList.DataTextField = "PostCode";
            //bind the data to the list
            lstAddressList.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //create an instance of the address collection
            ClsAddressCollection Addresses = new ClsAddressCollection();
            Addresses.ReportByPostCode("");
            //clear any existing filter to tidy up the interface
            txtFilter.Text = "";
            lstAddressList.DataSource = Addresses.AddressList;
            //set the name of the primary key
            lstAddressList.DataValueField = "AddressNo";
            //set the name of the field to display
            lstAddressList.DataTextField = "PostCode";
            //bind the data to the list
            lstAddressList.DataBind();
        }

       
    }
}