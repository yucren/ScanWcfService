using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientUintTest.ServiceReference1;

namespace ClientUintTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ScanServerClient client = new ScanServerClient();
            
            Console.WriteLine(client.GetCount());
            Console.WriteLine("HELLOWORLD");
        }
    }
}
