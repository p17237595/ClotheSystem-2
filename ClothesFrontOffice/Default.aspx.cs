using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted. Doulbe or int32 -----------
        Int32 Price;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Price = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["Price"] = Price;
            //redirect to the delete page
            Response.Redirect("DeleteStock.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted. Doulbe or int32 -----------
        Int32 Price;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Price = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["Price"] = Price;
            //redirect to the edit page
            Response.Redirect("SomeStock.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}