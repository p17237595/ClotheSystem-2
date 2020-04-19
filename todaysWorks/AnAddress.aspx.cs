using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace todaysWorks
{
    public partial class AnAddress : System.Web.UI.Page
    {
        Int32 AddressNo;
        protected void Page_Load(object sender, EventArgs e)
        { //if this is the first time the page is displayed
            AddressNo = Convert.ToInt32(Session["AddressNo"]);
            if (IsPostBack == false)
            {
                //display the current data for the record
                DisplayAddresses();
            }
        }

        void DisplayAddresses()
        {
            ClsAddressCollection AddressesBook = new ClsAddressCollection();
            //find the record to update
            AddressesBook.ThisAddress.Find(AddressNo);
            //display the data for this record
            txtAddressNo.Text = AddressesBook.ThisAddress.AddressNo.ToString();
            txtHouseNo.Text = AddressesBook.ThisAddress.HouseNo;
            txtStreet.Text = AddressesBook.ThisAddress.Street;
            txtTown.Text = AddressesBook.ThisAddress.Town;
            txtPostCode.Text = AddressesBook.ThisAddress.PostCode;
            txtDateAdded.Text = AddressesBook.ThisAddress.DateAdded.ToString();
            chkActive.Checked = AddressesBook.ThisAddress.Active;
            txtCounty.Text = AddressesBook.ThisAddress.CountyNo.ToString();
        }
        public void btnOK_Clicked(object sender, EventArgs args)
        {
            ClsAddress AnAddress = new ClsAddress();
            //capture the house no
            string HouseNo = txtHouseNo.Text;
            //capture the street
            string Street = txtStreet.Text;
            //capture the town
            string Town = txtTown.Text;
            //capture the post code
            string PostCode = txtPostalCode.Text;
            //capture the county
            string CountyNo = txtCounty.Text;
            //capture date added
            string DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //Store the address in th session object
            //variable to store any error message
            string Error = "";
            Error = AnAddress.Valid(HouseNo, Street, Town, PostCode, DateAdded);
            if (Error == "")
            {
                //capture the address no
                AnAddress.AddressNo = AddressNo;
                //capture the house no
                AnAddress.HouseNo = HouseNo;
                //capture the street
                AnAddress.Street = Street;
                //capture the town
                AnAddress.Town = Town;
                //capture the post code
                AnAddress.PostCode = PostCode;
                //capture the county
                AnAddress.CountyNo = Convert.ToInt32(CountyNo);
                //capture date added
                AnAddress.DateAdded = Convert.ToDateTime(DateAdded);
                //capture active
                AnAddress.Active = chkActive.Checked;
                //Store the address in th session object
                //create new instance of the address collection
                ClsAddressCollection AddressList = new ClsAddressCollection();
               
                if(AddressNo == -1)
                {
                    //set the ThisAddress property
                    AddressList.ThisAddress = AnAddress;
                    //add the new record
                    AddressList.Add();
                }
                //otherwise
                else
                {
                    //find the record to update
                    AddressList.ThisAddress.Find(AddressNo);
                    //set the ThisAddress property
                    AddressList.ThisAddress = AnAddress;
                    //update the record
                    AddressList.Update();
                }               
                //redirect back to the listpage
                Response.Redirect("AnAddressList.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }
    }
}
