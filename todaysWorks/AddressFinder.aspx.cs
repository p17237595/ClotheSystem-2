using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace todaysWorks
{
    public partial class AddressFinder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create an instance of the address class
            ClsAddress AnAddress = new ClsAddress();
            //variable to store the primary key
            Int32 AddressNo;
            //variable to store the result of the fing operation
            Boolean Found = false;
            //get the primary key entered by the user
            AddressNo = Convert.ToInt32(txtAddressNo.Text);
            //find the record
            Found = AnAddress.Find(AddressNo);
            //if founnd
            if(Found == true)
            {
                //display the values of the properties in the form
                txtHouseNo.Text = AnAddress.HouseNo;
                txtStreet.Text = AnAddress.Street;
                txtTown.Text = AnAddress.Town;
                txtPostCode.Text = AnAddress.PostCode;
                txtCounty.Text = AnAddress.CountyNo.ToString();
                txtDateAdded.Text = AnAddress.DateAdded.ToString();
            }
        }
    }
}