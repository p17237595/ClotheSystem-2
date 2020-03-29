using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

//I think the correct namespace to use os this one.
namespace WidgteClasses
{

    //I made this earlier but now on page 14 lab 23 creating the collection class it shows something totally different so do I just delete this again? Super confusing.
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        //constructor. I made this earlier but now on page 14 lab 23 creating the collection class it shows something totally different so do I just delete this again? Super confusing.
        public clsStockCollection()
        {
            //create the items of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Male";
            TestItem.Size = "Medium";
            TestItem.Description = "A lovely t-shirt";
            TestItem.Price = 17.28;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            // add the item to the test list
            mStockList.Add(TestItem);
            //reinitiatise the object for some new data
            TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Female";
            TestItem.Size = "Large";
            TestItem.Description = "A lovely coat";
            TestItem.Price = 100.99;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //add the item to the test list
            mStockList.Add(TestItem);
        }
        List<clsStock> mStockList = new List<clsStock>();

        //Constructor for the class. This is page 14 lab 23 stuff. Above it is already created but the instructions show this code instead. Don't know which one I actually need.
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //Object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Stock
                clsStock SomeStock = new clsStock();
                //read in the fields from the current record
                SomeStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.Size = Convert.ToString(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.DateArrived = Convert.ToDateTime(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data mamber
                mStockList.Add(SomeStock);
                //Point at the next record
                Index++;
            }
        }

        //property
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        //property
        public int Count
        {
            get
            {
                //return the count of the list 
                return mStockList.Count;
            }
            set
            {
                //later
            }
        }


        //I think this is rubbish
        /*
        //property
        public clsStock ThisStock;
        */



    }


}