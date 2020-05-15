using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgteClasses;
using System.Collections.Generic;

namespace ClothesTesting1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Male";
            TestItem.Size = "M";
            TestItem.Description = "A lovely jacket";
            TestItem.Price = 18.80;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);



            /*
            //test to see that it exists
            Assert.IsNotNull(AllStock);
            */
        }
       
        [TestMethod]
        public void ThisStockOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.Active = true;
            TestStock.Gender = "Male";
            TestStock.Size = "32S";
            TestStock.Description = "Nice pair of jeans";
            TestStock.Price = 15.89;
            TestStock.InStock = true;
            TestStock.DateArrived = DateTime.Now.Date;
            //Assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);


        }

        //This one is exactly the same as the first test called InstanceOK. Why is there a duplicate?
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Male";
            TestItem.Size = "M";
            TestItem.Description = "A lovely jacket";
            TestItem.Price = 18.80;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Male";
            TestItem.Size = "Medium";
            TestItem.Description = "Nice shoes";
            TestItem.Price = 120.99;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Price = PrimaryKey;
            //Find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key Doulbe or int32 ----------
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Male";
            TestItem.Size = "Medium";
            TestItem.Description = "Nice shoes";
            TestItem.Price = 120.99;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Price = PrimaryKey;
            //modify the test data
            TestItem.Active = true;
            TestItem.Gender = "Female";
            TestItem.Size = "Small";
            TestItem.Description = "Nice coat";
            TestItem.Price = 25.99;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }
    }
}
