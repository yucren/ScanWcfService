using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientUintTest.ServiceReference1;
using System.Threading;
using System.Threading.Tasks;

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
        [TestMethod]
        public void TestScanOut()
        {
            ScanServerClient client = new ScanServerClient();
            ScanInHead scanInHead = new ScanInHead()
            {               
                Note = "one",
                Operator = "yuchengren",               
                Scantime = DateTime.Now
            };
            ScanInEntry[] scanInEntrys = new ScanInEntry[]
            {
                new ScanInEntry()
                {
                     ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"
                },
                 new ScanInEntry()
                {
                     ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"
                },
                  new ScanInEntry()
                {
                     ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"
                },
                  new ScanInEntry()
                {
                     ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"
                },
                  new ScanInEntry()
                {
                     ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"
                },
                  new ScanInEntry()
                {
                     ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"
                }

            };


            scanInHead.ScanEntrys = scanInEntrys;
            scanInHead.ScanCount = scanInEntrys.Length;
            Parallel.For(0, 1000, (i) =>
            {
                client.ScanInWCE(scanInHead);

            });
           
           


        }
    }
}
