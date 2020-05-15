using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
//using ClassLibrary;
using System.Web.UI.WebControls;
using WidgteClasses;

//namespace ClassLibrary
//{
    public partial class SomeStock : System.Web.UI.Page
    {

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
        //txtGender.DataSource = StockBook.StockList;


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
            SomeStock.Price =Convert.ToDouble( txtPrice.Text);
            //Capture the stock
            SomeStock.InStock = chkInStock.Checked;
            //Capture the date arrived
            SomeStock.DateArrived = Convert.ToDateTime(txtDateArrived.Text);
            //Variable to store any error message
            string Error = "";
            //Validate the data
            //Error = SomeStock.Valid(Gender, Size, Description, Price, InStock, DataArrived);//this code needs serious review
            if (Error == "")
            {
                //capture Active
                SomeStock.Active = chkActive.Checked;
            //Capture gender
            //SomeStock.Gender = Gender; variable not declared
            //capture size
            //SomeStock.Size = Size; variable not declared
            //Capture description
            //SomeStock.Description = Description; variable not declared
            //capture price
            SomeStock.Price = Price;
                //Capture inStock
                SomeStock.InStock = chkInStock.Checked;
            //Capture DateArrived
            //SomeStock.DateArrived = Convert.ToDateTime(DateArrived); variable not declared
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
            
        }
    }
    
//}