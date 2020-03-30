using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;




namespace ClassLibrary
{
    public partial class SomeStock : System.Web.UI.Page
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
            //Variable to store any error message
            string Error = "";
            //Validate the data
            Error = SomeStock.Valid(Gender, Size, Description, Price, InStock, DataArrived);
            if (Error == "")
            {


                //Store the stock in the session object
                Session["SomeStock"] = SomeStock;
                //redirect to the viewer page
                Response.Redirect("StockViewer.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }
    }
    //t
}