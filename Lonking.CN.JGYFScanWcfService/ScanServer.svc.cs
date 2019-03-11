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
        private static object  lockNo =new object();
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
            try
            {
                lock (lockNo)
                {
                    var scans = from scan in db.ScanInHeads
                                where scan.Scantime >= DateTime.Today
                                select scan.DocNo.Replace("IN", "");
                    var startDocNo = "";
                    if (scans.Count() == 0)
                    {
                        startDocNo = DateTime.Today.ToString("yyyyMMdd") + "0001";
                    }
                    else
                    {
                        startDocNo = (long.Parse(scans.Max()) + 1).ToString();
                    }

                    scanInHead.DocNo = "IN" + startDocNo;                                       
                    db.ScanInHeads.Add(scanInHead);
                    foreach (var scanEntry in scanInHead.ScanEntrys)
                    {
                        if (db.ScanInvs.Where(p=>p.Sn == scanEntry.Sn).Count() ==0)
                        {
                            db.ScanInvs.Add(new ScanInv { ItemCode = scanEntry.ItemCode, ItemName = scanEntry.ItemName, ItemModel = scanEntry.ItemModel, Sn = scanEntry.Sn,IsInStock =true });
                            
                        }
                        else
                        {
                            throw new Exception(scanEntry.Sn + "号已存在，请检查");
                        }
                       
                    }
                    db.SaveChanges();
                   
                }
            }
            catch (Exception ex)
            {

                return "发生错误:" + ex.Message;
            }

           
            
            return "true";
        }

        public string ScanOut(Stream stream)
        {
            throw new NotImplementedException();
        }

        public string ScanOut(ScanOutHead scanOutHead)
        {
            try
            {
                lock (lockNo)
                {
                    var scans = from scan in db.ScanOutHeads
                                where scan.Scantime >= DateTime.Today
                                select scan.DocNo.Replace("OUT", "");
                    var startDocNo = "";
                    if (scans.Count() == 0)
                    {
                        startDocNo = DateTime.Today.ToString("yyyyMMdd") + "0001";
                    }
                    else
                    {
                        startDocNo = (long.Parse(scans.Max()) + 1).ToString();
                    }

                    scanOutHead.DocNo = "OUT" + startDocNo;
                    db.ScanOutHeads.Add(scanOutHead);
                    foreach (var scanEntry in scanOutHead.ScanEntrys)
                    {
                        if (db.ScanInvs.Where(p => p.Sn == scanEntry.Sn).Count() == 0)
                        {
                            throw new Exception(scanEntry.Sn + "号不存在，请检查");

                        }
                        else
                        {
                            db.ScanInvs.Where(p => p.Sn == scanEntry.Sn).First().IsInStock = false;
                        }

                    }
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                return "发生错误:" + ex.Message;
            }



            return "true";

        }
    }
}
