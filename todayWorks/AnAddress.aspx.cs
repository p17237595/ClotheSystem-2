using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using todayWorks;

namespace todayWorks
{

    public partial class AnAddress : System.Web.UI.Page
    {
        protected void Page_load(object sendeer, EventArgs e)
        {
            //create a new instance of clsAddress
            clsAddress AnAddress = new clsAddress();
            //get the data from the session object
            AnAddress = (clsAddress)Session["AnAddress"];
            //display the house number for this entry
            Response.Write(AnAddress.HouseNo);
        }
        public void btnOK_Clicked(object sender, EventArgs args)
        {
            clsAddress AnAddress = new clsAddress();
            //capture the house no
            string HouseNo = txtHouseNo.Text;
            //capture the street
            string Street = street.Text;
            //capture the town
            string Town = town.Text;
            //capture the post code
            string PostCode = postalcode.Text;
            //capture the county
            string CountyNo = country.Text;
            //capture date added
            string DateAdded = Convert.ToDateTime(dateAdded.Text)
            //Store the address in th session object
            //variable to store any error message
            string Error = "";
            Error = AnAddress.Valid(HouseNo, Street, Town, PostCode, DateAdded);
            if (Error == "")
            {
                //capture the house no
                AnAddress.HouseNo = txtHouseNo.Text;
                //capture the street
                AnAddress.Street = street.Text;
                //capture the town
                AnAddress.Town = town.Text;
                //capture the post code
                AnAddress.PostCode = postalcode.Text;
                //capture the county
                AnAddress.CountyNo = country.Text;
                //capture date added
                AnAddress.DateAdded = Convert.ToDateTime(DateAdded);
                //Store the address in th session object
                Session["AnAddress"] = AnAddress;
                //redirect to viewer page
                Response.Redirect("AnAddressViewer.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }
    }
}
