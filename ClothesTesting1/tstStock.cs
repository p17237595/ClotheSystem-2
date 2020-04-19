using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgteClasses;

namespace ClothesTesting1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(SomeStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            SomeStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.Active, TestData);
        }
        public void GenderOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "Male";
            //assign the data to the property
            SomeStock.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.DateArrived, TestData);
        }

        [TestMethod]
        public void SizeOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "M";
            //assign the data to the property
            SomeStock.Size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.Size, TestData);
        }
        public void DescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "A colourful t-shirt";
            //assign the data to the property
            SomeStock.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.Description, TestData);
        }
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            SomeStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.Price, TestData);
        }
        public void InStockOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            SomeStock.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.InStock, TestData);
        }
        public void DateArrivedOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            SomeStock.DateArrived = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeStock.DateArrived, TestData);
        }
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //Boolean variable to sotre the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Price = 1;
            //invoke the method
            Found = SomeStock.Find(Price);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        public void TestPriceFound()
        {
            //Create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 Price = 21;
            //Invoke the method
            Found = SomeStock.Find(Price);
            //check the price
            if (SomeStock.Price != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key. The instructions say to use int32 but I will use Double --------------------- I changed it back again.
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Gender = "Male";
            TestItem.Size = "Small";
            TestItem.Description = "Socks";
            TestItem.Price = 2.99;
            TestItem.InStock = true;
            TestItem.DateArrived = DateTime.Now.Date;
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //Add the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //Test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByGenderMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByGender("");
            //Test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }
        [TestMethod]
        public  void ReportByGenderNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a Gender that doesn't exist
            FilteredStock.ReportByGender("xxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByGenderTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a gender that doesn't exist
            FilteredStock.ReportByGender("yyyyyyyyyyyyyyyyyyyyyyy");
            //check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check that the first record ID is m
                if (FilteredStock.StockList[0].Size != "m")
                {
                    OK = false;
                }
                //check that the first record is l
                if (FilteredStock.StockList[1].Size != "l")
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}