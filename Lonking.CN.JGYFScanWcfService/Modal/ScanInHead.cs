using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    public class ScanInHead : IScanHead<ScanInEntry>
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
        [Required]
        public string Note { get; set; }
        [Required]
        
        public virtual HashSet<ScanInEntry> ScanEntrys { get; set; }
    }
}