namespace WrapperTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RouterApiWrapper;
    
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewRouter()
        {
            RouterApiWrapperClass routerApiWrapper = new RouterApiWrapperClass();
            int result = routerApiWrapper.AddRouter("127.0.0.1");

            Assert.AreEqual(0, result);

        }
    }
}