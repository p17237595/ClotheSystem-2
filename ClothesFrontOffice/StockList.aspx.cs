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
        1stStocks.Datasource = Stocks.StockList;
        //set the name of the primary key
        1stStocks.DataValueField = "Price";
        //set the data field to display
        1stStocks.DataTextField = "Description";
        //bind the data to the list
        1stStocks.DataBind();
    }
}