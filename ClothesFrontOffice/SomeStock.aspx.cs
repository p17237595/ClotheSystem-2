﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;
using WidgteClasses;

namespace ClassLibrary
{
    public partial class SomeStock : System.Web.UI.Page
    {
        //Another part of code that I have created but the instructions just tell me something totally different later on.
        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsStock
            clsStock SomeStock = new clsStock();
            //get the data from the session object
            SomeStock = (clsStock)Session["SomeStock"];
            //display the address for this entry
            Response.Write(SomeStock.Price);
        }
        */
        Int32 Price;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be processed ------------------
            Price = Convert.ToInt32(Session["Price"]);
            if (IsPostBack == false)
            {
                //if this is not a new record
                if (Price != -1)
                {
                    //display the current data for the record
                    DisplayStock();
                }
            }
        }
        void DisplayStock()
        {
            //create an instance of the stock book
            clsStockCollection StockBook = new clsStockCollection();
            //find the record to update
            StockBook.ThisStock.Find(Price);
            //display the data for this record
            txtGender.Text = StockBook.ThisStock.Gender.ToString();
            txtSize.Text = StockBook.ThisStock.Size.ToString();
            txtDescription.Text = StockBook.ThisStock.Description.ToString();
            txtPrice.Text = StockBook.ThisStock.Price.ToString();
            chkInStock.Checked = StockBook.ThisStock.InStock;
            txtDateArrived.Text = StockBook.ThisStock.DateArrived.ToString();
            chkActive.Checked = StockBook.ThisStock.Active;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //Create a new instance of clsStock
            clsStock SomeStock = new clsStock();
            //Capture the gender
            SomeStock.Gender = txtGender.Text;
            //Capture the size
            SomeStock.Size = txtSize.Text;
            //Capture the description
            SomeStock.Description = txtDescription.Text;
            //Capture the Price
            SomeStock.Price = txtPrice.Text;
            //Capture the stock
            SomeStock.InStock = chkInStock.Text;
            //Capture the date arrived
            SomeStock.DateArrived = Convert.ToDateTime(txtDateArrived.Text);
            //Variable to store any error message
            string Error = "";
            //Validate the data
            Error = SomeStock.Valid(Gender, Size, Description, Price, InStock, DataArrived);
            if (Error == "")
            {
                //capture Active
                SomeStock.Active = chkActive.Checked;
                //Capture gender
                SomeStock.Gender = Gender;
                //capture size
                SomeStock.Size = Size;
                //Capture description
                SomeStock.Description = Description;
                //capture price
                SomeStock.Price = Price;
                //Capture inStock
                SomeStock.InStock = chkInStock.Checked;
                //Capture DateArrived
                SomeStock.DateArrived = Convert.ToDateTime(DateArrived);
                //Create a new instance of the stock collection
                clsStockCollection StockList = new clsStockCollection();

                //if this is a new record i.e. Price = -1 then add the data
                if (Price == -1)
                {
                    //set the ThisStock property
                    StockList.ThisStock = SomeStock;
                    //add the new record
                    StockList.Add();
                }
                //Otherwise it must update
                else
                {
                    //find the record to update
                    StockList.ThisStock.Find(Price);
                    //set the ThisStock property
                    StockList.ThisStock = SomeStock;
                    //update the record
                    StockList.Update();
                }
                //redirect back to the listpage
                Response.Redirect("StockList.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
            //Some more code that is changed totally
            /*
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
            */
        }
    }
    
}