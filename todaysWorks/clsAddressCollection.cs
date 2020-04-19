using System;
using System.Collections.Generic;

namespace todaysWorks
{
    public class ClsAddressCollection
    {
        //constructor
        /*public ClsAddressCollection()
        {
            ClsAddress TestItem = new ClsAddress();
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 1;
            TestItem.CountyNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "123a";
            TestItem.PostCode = "LE1 1ME";
            TestItem.Street = "street1";
            TestItem.Town = "town1";
            // add the item to the test list
            mAddressList.Add(TestItem);
            //reinitiatise the object for some new data
            TestItem = new ClsAddress();
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 2;
            TestItem.CountyNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "99";
            TestItem.PostCode = "LE1 7YY";
            TestItem.Street = "street2";
            TestItem.Town = "town2";
            //add the item to the test list
            mAddressList.Add(TestItem);
        }*/

            //constructor for the class
        public ClsAddressCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_SelectAll");
            //populated the aray list with the data datatable
            PopulateArray(DB);
        }

      //List<ClsAddress> mAddressList = new List<ClsAddress>();

      ClsAddress mThisAddress = new ClsAddress();

        //property
        public List<ClsAddress> AddressList
        {
            get
            {
                //return the private data
                return mAddressList;
            }
            set
            {
                //set the private data
                mAddressList = value;
            }
        }

        //property
        public int Count
        {
            get
            {
                //return the count of the list 
                return mAddressList.Count;
            }
            set
            {
                //later
            }
        }

        //property
       // public ClsAddress mThisAddress;

        private List<ClsAddress> mAddressList;

        public ClsAddress ThisAddress
        {
            get
            {
                //return the count of the list 
                return mThisAddress;
            }
            set
            {
                //set the private data
                mThisAddress = value;
            }
        }
        //METHOD
        public int Add()
        {
            /*//add a new record to the database based on the values of mThisAddress
            //set the primary key value of the new record
            mThisAddress.AddressNo = 123;
            //Return the primary key of the new record
            return mThisAddress.AddressNo;*/

            //Adds a new record to the database on the values of thisAddress
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HouseNo", mThisAddress.HouseNo);
            DB.AddParameter("@Street", mThisAddress.Street);
            DB.AddParameter("@Town", mThisAddress.Town);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            DB.AddParameter("@CountyNo", mThisAddress.CountyNo);
            DB.AddParameter("@DateAdded", mThisAddress.DateAdded);
            DB.AddParameter("@Active", mThisAddress.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tlbAddress_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AddressNo", mThisAddress.AddressNo);

            //execute the query returning the primary key value
            DB.Execute("sproc_tlbAddress_Delete");
        }

        public int Update()
        {
            /*//add a new record to the database based on the values of mThisAddress
            //set the primary key value of the new record
            mThisAddress.AddressNo = 123;
            //Return the primary key of the new record
            return mThisAddress.AddressNo;*/

            //Adds a new record to the database on the values of thisAddress
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HouseNo", mThisAddress.HouseNo);
            DB.AddParameter("@Street", mThisAddress.Street);
            DB.AddParameter("@Town", mThisAddress.Town);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            DB.AddParameter("@CountyNo", mThisAddress.CountyNo);
            DB.AddParameter("@DateAdded", mThisAddress.DateAdded);
            DB.AddParameter("@Active", mThisAddress.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tlbAddress_Update");
        }

        public void ReportByPostCode(string PostCode)
        {
            //FILTER THE RECORDS basd on a fail or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByPostCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mAddressList = new List<ClsAddress>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                ClsAddress AnAddress = new ClsAddress();
                //read in the fields from the current record
                AnAddress.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnAddress.AddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressNo"]);
                AnAddress.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                AnAddress.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAddded"]);
                AnAddress.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnAddress.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnAddress.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AnAddress.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                //add the record to the private data member
                mAddressList.Add(AnAddress);
                //point to the next record 
                Index++;
            }
        }
    }
}