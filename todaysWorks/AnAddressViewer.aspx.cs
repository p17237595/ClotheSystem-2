using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace todaysWorks
{
    public partial class AnAddressViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsAddress
            ClsAddress AnAddress = new ClsAddress();
            //get the data from the session object
            AnAddress = (ClsAddress)Session["AnAddress"];
            //display the house number for this entry
            Response.Write(AnAddress.HouseNo);
        }
    }
}