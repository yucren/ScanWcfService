using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    public class ScanInEntry : IScanEntry
    {
        [Required]
        [MaxLength(15, ErrorMessage = "料号不予过长")]
        public string ItemCode { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "品名不予超过50个字符")]
        public string ItemName { get; set; }
        [Required]
        public string ItemModel { get; set; }
        [Required]
        public string Sn { get; set; }
        public int ID { get; set; }
        public int ScanInHeadID { get; set; }
        public virtual ScanInHead ScanInHead { get; set; }
    }
}


