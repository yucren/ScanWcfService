using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    public class ScanInv
    {
        public int ID { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string ItemModel { get; set; }
       
        public string Sn { get; set; }
        [Required]
        public DateTime Scantime { get; set; }
    }
}