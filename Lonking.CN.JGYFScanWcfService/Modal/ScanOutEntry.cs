using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    public class ScanOutEntry : IScanEntry
    {
        public int ID { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string ItemModel { get; set; }
        [Required]
        public string Sn { get; set; }
        public virtual ScanOutHead ScanOutHead { get; set; }
         
    }
}