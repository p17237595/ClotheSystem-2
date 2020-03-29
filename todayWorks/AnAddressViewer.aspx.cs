using System;
using System.Web;
using System.Web.UI;
namespace todayWorks
{
    public partial class AnAddressViewer : System.Web.UI.Page
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
    }
}
