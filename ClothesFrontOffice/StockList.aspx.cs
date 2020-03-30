using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//This was public partial class StockList : System.Web.UI.Page but I have changed it to match the instructions
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //Create an instance of the County collection
        WidgteClasses.clsStockCollection Stocks = new WidgteClasses.clsStockCollection();
        //set the data source to the list of countries in the collection
        lstStocks.Datasource = Stocks.StockList;
        //set the name of the primary key
        lstStocks.DataValueField = "Price";
        //set the data field to display
        lstStocks.DataTextField = "Description";
        //bind the data to the list
        lstStocks.DataBind();
    }

    //Event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Price"] = -1;
        //redirect to the data entry page
        Response.Redirect("SomeStock.aspx");
    }


}