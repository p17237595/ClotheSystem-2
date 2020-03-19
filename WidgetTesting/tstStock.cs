using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgteClasses;

namespace Widgte_Testing
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

        [TestMethod]
        public void DateAddedPropertyOK()
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

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            clsStock.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Address, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnAddress.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnAddress.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnAddress.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Town, TestData);
        }

    }
}
