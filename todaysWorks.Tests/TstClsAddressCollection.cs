using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace todaysWorks.Tests
{
    [TestClass]
    public class TstClsAddressCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsAddress> TestList = new List<ClsAddress>();
            //add an item to the list
            //create the item of test data
            ClsAddress TestItem = new ClsAddress();
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 1;
            TestItem.CountyNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "123a";
            TestItem.PostCode = "LE1 1WE";
            TestItem.Street = "some street";
            TestItem.Town = "some town";
            //add the item to te test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.AddressList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllAddresses.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //Create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //create some test data to assign to the property
            ClsAddress TestAddress = new ClsAddress();
            //set the propertied of the test object
            TestAddress.Active = true;
            TestAddress.AddressNo = 1;
            TestAddress.CountyNo = 1;
            TestAddress.DateAdded = DateTime.Now.Date;
            TestAddress.HouseNo = "123a";
            TestAddress.PostCode = "LE1 1WE";
            TestAddress.Street = "some street";
            TestAddress.Town = "some town";
            //assign the data to the property
            AllAddresses.ThisAddress = TestAddress;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestAddress);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsAddress> TestList = new List<ClsAddress>();
            //add an item to the list
            //create the item of test data
            ClsAddress TestItem = new ClsAddress();
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 1;
            TestItem.CountyNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "123a";
            TestItem.PostCode = "LE1 1WE";
            TestItem.Street = "some street";
            TestItem.Town = "some town";
            //add the item to te test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.Count, TestList.Count);
        }

        /* [TestMethod]
         public void TwoRecordsPresent()
         {
             //create an instance of the class we want to create
             ClsAddressCollection AllAddresses = new ClsAddressCollection();
             //test to see that the two values are the same
             Assert.AreEqual(AllAddresses.Count, 2);
         }*/

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //create the item of test data
            ClsAddress TestItem = new ClsAddress();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 1;
            TestItem.CountyNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "123a";
            TestItem.PostCode = "LE1 1WE";
            TestItem.Town = "some town";
            //set ThisAddress to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.AddressNo = PrimaryKey;
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            //create the item of test data
            ClsAddress TestItem = new ClsAddress();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.AddressNo = 1;
            TestItem.CountyNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "123a";
            TestItem.PostCode = "LE1 1WE";
            TestItem.Town = "some town";
            TestItem.Street = "some street";
            //set ThisAddress to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.AddressNo = PrimaryKey;
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class contsaing unfiltered results
            ClsAddressCollection AllAddresses = new ClsAddressCollection();
            // create an instance of the filterd class
            ClsAddressCollection FilteredAddresses = new ClsAddressCollection();
            //apply a blank string(should return all records)
            FilteredAddresses.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.Count, FilteredAddresses.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            // create an instance of the filterd data
            ClsAddressCollection FilteredAddresses = new ClsAddressCollection();
            //apply a blank string(should return all records)
            FilteredAddresses.ReportByPostCode("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredAddresses.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            // create an instance of the filterd data
            ClsAddressCollection FilteredAddresses = new ClsAddressCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a blank string(should return all records)
            FilteredAddresses.ReportByPostCode("yyy yyy");
            //test to see that the two values are the same
            if (FilteredAddresses.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredAddresses.AddressList[0].AddressNo != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredAddresses.AddressList[1].AddressNo != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that ther are no records
            Assert.IsTrue(OK);
        }
    }
}