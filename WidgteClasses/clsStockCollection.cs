﻿using System;
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
        //Private data member thisStock
        clsStock mThisStock = new clsStock();

        //constructor. I made this earlier but now on page 14 lab 23 creating the collection class it shows something totally different so do I just delete this again? Super confusing.
        /*
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
        */
        List<clsStock> mStockList = new List<clsStock>();

        //Constructor for the class. This is page 14 lab 23 stuff. Above it is already created but the instructions show this code instead. Don't know which one I actually need. Lab 24 Page 32 just tells me to change it once again?
        /*
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
        */

        //Constructor lab 24 page 32 tells me to make:
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
                
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


        //property
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }


        //This is another part where the instructions just change it totally after already making it.
        /*
        //The instructions say this needs to be int rather than Doulble but i need it for my price.
        public Double Add()
        {
            //Adds a new record to the database based on the values of mThisStock
            //Set the primary key value of the new record
            mThisStock.Price = 20.99;
            //return the primary key of the new record
            //This variable is a double but apparently it needs to be int ------------------
            return mThisStock.Price;
        }
        */

        public int Add()
        {
            //adds a new record to the database based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@Active", mThisStock.Active);
            DB.AddParameter("@Gender", mThisStock.Gender);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@InStock", mThisStock.InStock);
            DB.AddParameter("@DateArrived", mThisStock.DateArrived);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Delete()
        {
            //Deletes the record pointed to by thisStock
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Price", mThisStock.Price);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Active", mThisStock.Active);
            DB.AddParameter("@Gender", mThisStock.Gender);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@InStock", mThisStock.InStock);
            DB.AddParameter("@DateArrived", mThisStock.DateArrived);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByGender(string Gender)
        {
            //Filters the records based on a full or partial gender
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the Gender parameter to the database
            DB.AddParameter("@Gender", Gender);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByGender");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount;
            //Get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mStockList = new List<clsStock>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock SomeStock = new clsStock();
                //read in the fields from the current record
                SomeStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                SomeStock.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                SomeStock.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                SomeStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                SomeStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                SomeStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                SomeStock.DateArrived = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateArrived"]);
            }
        }



    }


}