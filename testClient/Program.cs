
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testClient.ServiceReference1;

namespace testClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ScanServerClient client = new ScanServerClient();

            ScanOutHead scanOutHead = new ScanOutHead
            {
                CustomerCode = "111",
                Note = "",
                Operator = "yuchengren",
                ScanCount = 6,
                Scantime = DateTime.Now,
                CustomerName = "龙工",

            };
            ScanOutEntry scanOutEntry = new ScanOutEntry
            {
                ItemCode = "60101000012",
                ItemName = "柴油机总成",
                ItemModel = "CDM856E.01Ⅲ.03~组合件",
                Sn = "10008611"


            };
            scanOutHead.ScanEntrys = new ScanOutEntry[] { scanOutEntry };




            //ScanInHead scanInHead = new ScanInHead()
            //{
            //    Note = "one",
            //    Operator = "yuchengren",
            //    Scantime = DateTime.Now
            //};
            //ScanInEntry[] scanInEntrys = new ScanInEntry[]
            //{
            //    new ScanInEntry()
            //    {
            //         ItemCode = "60101000012",
            //    ItemName = "柴油机总成",
            //    ItemModel = "CDM856E.01Ⅲ.03~组合件",
            //    Sn = "10008611"
            //    },
            //     new ScanInEntry()
            //    {
            //         ItemCode = "60101000012",
            //    ItemName = "柴油机总成",
            //    ItemModel = "CDM856E.01Ⅲ.03~组合件",
            //    Sn = "10008610"
            //    },
            //      new ScanInEntry()
            //    {
            //         ItemCode = "60101000012",
            //    ItemName = "柴油机总成",
            //    ItemModel = "CDM856E.01Ⅲ.03~组合件",
            //    Sn = "10008609"
            //    },
            //      new ScanInEntry()
            //    {
            //         ItemCode = "60101000012",
            //    ItemName = "柴油机总成",
            //    ItemModel = "CDM856E.01Ⅲ.03~组合件",
            //    Sn = "10008612"
            //    },
            //      new ScanInEntry()
            //    {
            //         ItemCode = "60101000012",
            //    ItemName = "柴油机总成",
            //    ItemModel = "CDM856E.01Ⅲ.03~组合件",
            //    Sn = "10008613"
            //    },
            //      new ScanInEntry()
            //    {
            //         ItemCode = "60101000012",
            //    ItemName = "柴油机总成",
            //    ItemModel = "CDM856E.01Ⅲ.03~组合件",
            //    Sn = "10008614"
            //    }

            //};


            //scanInHead.ScanEntrys = scanInEntrys;
            //scanInHead.ScanCount = scanInEntrys.Length;
            Parallel.For(0, 1, (i) =>
            {
              //  Console.WriteLine(client.ScanInWCE(scanInHead));
               Console.WriteLine(client.ScanOutWCE(scanOutHead));

            });

        }
    }
}
