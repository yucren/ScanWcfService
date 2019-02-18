using Lonking.CN.JGYFScanWcfService.Modal;
using Lonking.CN.JGYFScanWcfService.Modal.K3Modal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lonking.CN.JGYFScanWcfService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IScanServer”。
    [ServiceContract]
    public interface IScanServer
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        string GetCount();
        [OperationContract]
        
        string ScanIn(Stream stream);
        [OperationContract]
        string ScanOut(Stream stream);
        [OperationContract(Name ="ScanInWCE")]
        string ScanIn(ScanInHead scanInHead);
        [OperationContract(Name = "ScanOutWCE")]
        string ScanOut(ScanOutHead scanOutHead);
        [OperationContract]
       IQueryable<vwICBill_8> GetSaleBillInfo(string billNo);


    }
}
