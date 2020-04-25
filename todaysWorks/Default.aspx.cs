using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace todaysWorks
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayAddresses();
            }
        }

        void DisplayAddresses()
        {
            todaysWorks.ClsAddressCollection Addresses = new todaysWorks.ClsAddressCollection();
            //set the data source to the list of counties in the collection
            lstAddresses.DataSource = Addresses.AddressList;
            //set the name of the primary key
            lstAddresses.DataValueField = "AddressNo";
            //set the data field to display
            lstAddresses.DataTextField = "PostCode";
            //bind the data the list
            lstAddresses.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // var to store the primary key value of the record to be deleleted
            Int32 AddressNo;
            //if a record has been seleceted froom the list
            if (AddressList.SelectedIndex != -1)
            {
                //get the primary key
                AddressNo = Convert.ToInt32(AddressList.SelectedValue);
                //store the data in the session object
                Session["AddressNo"] = AddressNo;
                //redirectto the delete Page
                Response.Redirect("DeleteAddress.aspx");
            } else //if no record has been selected
            {
                //display error
                lblerror.Text = "Please select a record to delete form the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 AddressNo;
            //if a record has been selected fromthe list
            if(AddressList.SelectedIndex != -1)
            {
                //get the primary key value of the reocrf to edit
                AddressNo = Convert.ToInt32(AddressList.SelectedValue);
                //store the data in the session object
                Session["AddressNo"] = AddressNo;
                //redirect to the edit page
                Response.Redirect("AnAddress.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                //lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 AddressNo;
            //if a record has been selected fromthe list
            if (AddressList.SelectedIndex != -1)
            {
                //get the primary key value of the reocrf to edit
                AddressNo = Convert.ToInt32(AddressList.SelectedValue);
                //store -1 into the session object to indicate this is a new record
                Session["AddressNo"] = -1;
                //redirectto the data entry  Page
                Response.Redirect("Anddress.aspx");
            }
        }
    }
}