using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    interface IScanHead<T>
    {
        int ID { get; set; }
        [Required]
        string DocNo { get; set; }
        [Required]
        DateTime Scantime { get; set; }
        [Required]
        decimal ScanCount { get; set; }
        [Required]
        string Operator { get; set; }
        [Required]
        string Note { get; set; }
        [Required]
        HashSet<T> ScanEntrys { get; set; }



    }
}
