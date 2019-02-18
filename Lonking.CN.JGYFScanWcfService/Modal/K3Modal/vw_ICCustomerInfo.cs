namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ICCustomerInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FID { get; set; }

        [StringLength(255)]
        public string FNumber { get; set; }

        [StringLength(80)]
        public string FName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string FBillNo { get; set; }

       
        [Column(Order = 2)]
        
        public int FDetail { get; set; }

        
        [Column(Order = 3)]
  
        public int FClassTypeID { get; set; }

       
        [Column(Order = 4)]
      
        public int FParentID { get; set; }

        public int? FLevels { get; set; }

        public int? FLogic { get; set; }

       
        [Column(Order = 5)]
       
        public int FDeleted { get; set; }

        [Column(Order = 6)]
       
        public int FDiscontinued { get; set; }

        [StringLength(255)]
        public string FFullNumber { get; set; }

        
        [Column(Order = 7)]
        
        public int Femployee { get; set; }

        
        [Column(Order = 8)]
        
        public int Fdepartment { get; set; }
    }
}
