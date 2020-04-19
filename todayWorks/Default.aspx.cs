using System;
using System.Web;
using System.Web.UI;

namespace todayWorks
{

    public partial class Default : System.Web.UI.Page
    {
        public  void Page_Load (object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayAddresses();
            }
        }

        void DisplayAddresses()
        {
            todayWorks.clsAddressCollection Addresses = new todayWorks.clsAddressCollection();
            //set the data source to the list of counties in the collection
            lstAddresses.DataSource = Addresses.AddressList;
            //set the name of the primary key
            lstAddresses.DataValueField = "AddressNo";
            //set the data field to display
            lstAddresses.DataTextField = "PostCode";
            //bind the data the list
            lstAddresses.DataBind();
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
        }
    }
}
