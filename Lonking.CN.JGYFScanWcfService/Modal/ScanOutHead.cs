using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    public class ScanOutHead : IScanHead<ScanOutEntry>
    {
        public int ID { get; set; }
        [Required]
        public string DocNo { get; set; }
        [Required]
        public DateTime Scantime { get; set; }
        [Required]
        public decimal ScanCount { get; set; }
        [Required]
        public string Operator { get; set; }
           
        public string Note { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerCode { get; set; }
        [Required]
        public HashSet<ScanOutEntry> ScanEntrys { get; set; }
    }
}