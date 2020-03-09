[TestMethod]
public void instanceOK()
{
    //create an instance of the class we want to create
    clsCustomer AnCustomer = new clsCustomer();
    //test to see that it exists
    Assert.IsNotNull(AnCustomer);
}