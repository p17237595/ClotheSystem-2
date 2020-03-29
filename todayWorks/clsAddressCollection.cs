using System;
using System.Collections.Generic;
using todayWorks;

namespace todayWorks
{
    public class clsAddressCollection
    {
        //constructor
        public clsAddressCollection()
        {
            clsAddress TestItem = new clsAddress();
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 1;
            TestItem.CountyNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "123a";
            TestItem.PostCode = "LE1 1ME";
            TestItem.Street = "some street";
            TestItem.Town = 'some town';
            // add the item to the test list
            mAddressList.Add(TestItem);
            //reinitiatise the object for some new data
            TestItem = new clsAddress();
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 2;
            TestItem.CountyNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "99";
            TestItem.PostCode = "LE1 7YY";
            TestItem.Street = "another street";
            TestItem.Town = 'another town';
            //add the item to the test list
            mAddressList.Add(TestItem);
        }
        List<clsAddress> mAddressList = new List<clsAddress>();

        //property
        public List<clsAddress> AddressList
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
        public clsAddress ThisAddress;




    }
}
