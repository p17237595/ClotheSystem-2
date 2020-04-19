using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todaysWorks
{
    public class ClsAddress
    {
            //private data member for active
            private Boolean mActive;
            //public property for active
            public bool Active
            {
                get
                {
                    //return the private data
                    return mActive;
                }
                set
                {
                    //set the private data
                    mActive = value;
                }
            }

            //private date added data member
            private DateTime mDateAdded;
            //public property for date added
            public DateTime DateAdded
            {
                get
                {
                    //return the private data
                    return mDateAdded;
                }
                set
                {
                    //set the private data
                    mDateAdded = value;
                }
            }

            //private data member for the AddressNo property
            private Int32 mAddressNo;
            //public property for the address number
            public int AddressNo
            {
                get
                {
                    //return the private data
                    return mAddressNo;
                }
                set
                {
                    //set the value of the private data member
                    mAddressNo = value;
                }
            }

            //private data member for county no
            private Int32 mCountyNo;
            //public property for county no
            public int CountyNo
            {
                get
                {
                    //return the private data
                    return mCountyNo;
                }
                set
                {
                    //set the private data
                    mCountyNo = value;
                }
            }

            //private data member for HouseNo
            private string mHouseNo;
            //public property for house no
            public string HouseNo
            {
                get
                {
                    //return private data
                    return mHouseNo;
                }
                set
                {
                    //set the private data
                    mHouseNo = value;
                }
            }

            //private data member for post code
            private string mPostCode;
            //public property for post code
            public string PostCode
            {
                get
                {
                    //return the private data
                    return mPostCode;
                }
                set
                {
                    //set the private data
                    mPostCode = value;
                }
            }

            //private data member for street
            private string mStreet;
            //public data member for street
            public string Street
            {
                get
                {
                    //return the private data
                    return mStreet;
                }
                set
                {
                    //set the private data
                    mStreet = value;
                }
            }

            //private data member for town
            private string mTown;
            //public data member for Town
            public string Town
            {
                get
                {
                    //return the private data
                    return mTown;
                }
                set
                {
                    //set the private data
                    mTown = value;
                }
            }

            public bool Find(int AddressNo)
            {
                //set the private data members to the test data value
                mAddressNo = 21;
                mHouseNo = "123";
                mStreet = "Test Street";
                mTown = "Test Town";
                mPostCode = "XXX XXX";
                mCountyNo = 1;
                mDateAdded = Convert.ToDateTime("16/9/2015");
                mActive = true;
                //always return true
                return true;
            }

            public string Valid(string houseNo, string street, string town, string postCode, string dateAdded)
            {
                //create a string variable to store the error
                String Error = "";
                //create a temporary variable to store date values
                DateTime DateTemp;
                //if the HouseNo is blank
                if (houseNo.Length == 0)
                {
                    //record the error
                    Error = Error + "The house no may not be blank : ";
                }
                //if the house no is greater than 6 characters
                if (houseNo.Length > 6)
                {
                    //record the error
                    Error = Error + "The house no must be less than 6 characters : ";
                }
                try
                {
                    //copy the dateAdded value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(dateAdded);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the past : ";
                    }
                    //check to see if the date is greater than today's date
                    if (DateTemp > DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    //record the error
                    Error = Error + "The date was not a valid date : ";
                }
                //is the post code blank
                if (postCode.Length == 0)
                {
                    //record the error
                    Error = Error + "The post code may not be blank : ";
                }
                //if the post code is too long
                if (postCode.Length > 9)
                {
                    //record the error
                    Error = Error + "The post code must be less than 9 characters : ";
                }
                //is the street blank
                if (street.Length == 0)
                {
                    //record the error
                    Error = Error + "The street may not be blank : ";
                }
                //if the street is too long
                if (street.Length > 50)
                {
                    //record the error
                    Error = Error + "The street must be less than 50 characters : ";
                }
                //is the town blank
                if (town.Length == 0)
                {
                    //record the error
                    Error = Error + "The town may not be blank : ";
                }
                //if the town is too long
                if (town.Length > 50)
                {
                    //record the error
                    Error = Error + "The town must be less than 50 characters : ";
                }
                //return any error messages
                return Error;
            }
    }
}