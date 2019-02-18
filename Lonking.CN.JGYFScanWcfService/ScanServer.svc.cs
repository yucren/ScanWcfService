using Lonking.CN.JGYFScanWcfService.Modal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;
using Lonking.CN.JGYFScanWcfService.Modal.K3Modal;

namespace Lonking.CN.JGYFScanWcfService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“ScanServer”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 ScanServer.svc 或 ScanServer.svc.cs，然后开始调试。
    public class ScanServer : IScanServer
    {
        ScanModel db = new ScanModel();
        K3Model kdb = new K3Model();
        public void DoWork()
        {
            

        }

        public string GetCount()
        {
            using (ScanModel db = new ScanModel())
            {
                return db.ScanInEntries.Count().ToString();
            }
        }

        public IQueryable<vwICBill_8> GetSaleBillInfo(string billNo)
        {
         
         var salebill =   from sbill in kdb.vwICBill_8 where sbill.FbillNo == billNo select sbill;
          return salebill;

        }

        public string ScanIn(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            ScanInHead scanIn =    JsonConvert.DeserializeObject<ScanInHead>(json);
            db.ScanInHeads.Add(scanIn);
            db.SaveChanges();
            return "true";
        }

        public string ScanIn(ScanInHead scanInHead)
        {
            var scans = from scan in db.ScanInHeads
                        where scan.Scantime >= DateTime.Today
                        select scan.DocNo.Replace("ScanOut", "");
            var startDocNo = "";
            if (scans.Count()==0)
            {
                startDocNo = DateTime.Today.ToString("yyyyMMdd") +"0001";
            }
            else
            {
                
                startDocNo = (long.Parse(scans.Max()) +1).ToString() ;
                
            }            
            
            scanInHead.DocNo = "ScanOut" + startDocNo;          

                        db.ScanInHeads.Add(scanInHead);
                        db.SaveChanges();

            return "true";
        }

        public string ScanOut(Stream stream)
        {
            throw new NotImplementedException();
        }

        public string ScanOut(ScanOutHead scanOutHead)
        {
            throw new NotImplementedException();
        }
    }
}
