using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
