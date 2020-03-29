using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgteClasses;

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
        /*
        [TestMethod]
        public void CountStockOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //Assign data to the property
            AllStock.Count = SomeCount;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }
        */
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


    }
}
