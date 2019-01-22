using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lonking.CN.JGYFScanWcfService.Modal
{
    interface IScanEntry
    {
       
        int ID { get; set; } 
        [Required]
        
        string ItemCode { get; set; }
        [Required]
        string ItemName { get; set; }
        [Required]
        string ItemModel { get; set; }
        [Required]
        string Sn { get; set; }   
        

        


    }
}
