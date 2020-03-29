using NUnit.Framework;
using System;
namespace todayWorks.Tests
{
    [TestClass]
    public class tstAddressCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAddresses);
        }

    }
