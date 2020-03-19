using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WidgteClasses;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock SomeStock = new clsStock();
        //get the data from the session object
        SomeStock = (clsStock)Session["SomeStock"];
        //display the address for this entry
        Response.Write(SomeStock.Gender);
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStock
        clsStock SomeStock = new clsStock();
        //Capture the gender
        SomeStock.Gender = GenderText.Text;
        //Capture the size
        SomeStock.Size = SizeText.Text;
        //Capture the description
        SomeStock.Description = DescriptionText.Text;
        //Capture the Price
        SomeStock.Price = PriceText.Text;
        //Capture the stock
        SomeStock.InStock = InStockCheck.Text;
        //Capture the date arrived
        SomeStock.DateArrived = Convert.ToDateTime(DateArrivedText.Text);
        //Store the stock in the session object
        Session["SomeStock"] = SomeStock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}