namespace WrapperTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RouterApiWrapper;
    using System.Diagnostics;

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

        // Check if Simulator Process is running. not a Testmethod
        public static bool CheckSimulatorProcessRunning()
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process process in processlist)
            {
                if (String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    continue;
                }

                if (!(process.ProcessName == "BmdVideoHub"))
                {
                    continue;
                }

                Console.WriteLine("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);
                return true;
            }
            return false;
        }
    }
}