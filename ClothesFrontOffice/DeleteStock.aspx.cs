using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WidgteClasses;

public partial class DeleteStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the price to be deleted from the session object Double or int32 ------------------------
        Price = Convert.ToInt32(Session["Price"]);
    }
}
//Not certain this is in the right place.
public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 Price;

    //event handler for the load event
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new insance of the Stock
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(Price);
        //delete the record
        StockBook.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}