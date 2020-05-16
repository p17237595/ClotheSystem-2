using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;

//I think the correct namespace to use os this one.
namespace WidgteClasses
{

    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //Private data member thisStock
        clsStock mThisStock = new clsStock();

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
                //add the record to the private data member
                mStockList.Add(SomeStock);
                //point at the next record
                Index++;
            }
        }



    }


}