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

    }
}