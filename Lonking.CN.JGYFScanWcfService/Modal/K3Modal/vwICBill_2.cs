namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwICBill_2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        public int? FEntryID { get; set; }

        public DateTime? Fdate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string FCheckFlag { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string FCancellation { get; set; }

        [StringLength(80)]
        public string FDeptID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string FBillNo { get; set; }

        [StringLength(80)]
        public string FDCStockID { get; set; }

        [StringLength(80)]
        public string FShortNumber { get; set; }

        [StringLength(80)]
        public string FNumber { get; set; }

        [StringLength(80)]
        public string FItemID { get; set; }

        [StringLength(255)]
        public string Fmodel { get; set; }

        [StringLength(80)]
        public string FUnitID { get; set; }

        public int? FSourceTranType { get; set; }

        [StringLength(255)]
        public string FSourceBillNo { get; set; }

        public decimal? FAuxQtyMust { get; set; }

        public decimal? Fauxqty { get; set; }

        public decimal? Fauxprice { get; set; }

        public decimal? Famount { get; set; }

        [StringLength(200)]
        public string FBatchNo { get; set; }

        [StringLength(255)]
        public string FFManagerID { get; set; }

        [StringLength(255)]
        public string FSManagerID { get; set; }

        [StringLength(50)]
        public string FBillerID { get; set; }

        [StringLength(50)]
        public string Fcheckerid { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [StringLength(111)]
        public string FVchInterID { get; set; }

        [StringLength(80)]
        public string FUnitGroupID { get; set; }

        public decimal? FQtyMust { get; set; }

        public decimal? FQty { get; set; }

        public decimal? FAuxPlanPrice { get; set; }

        public decimal? FPlanAmount { get; set; }

        [StringLength(80)]
        public string FCUUnitID { get; set; }

        public decimal? FcuQtyMust { get; set; }

        public decimal? FCUQty { get; set; }

        [StringLength(80)]
        public string FDCSPID { get; set; }

        public int? FKFPeriod { get; set; }

        public DateTime? FKFDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string FBackFlushed { get; set; }

        [StringLength(80)]
        public string FChkPassItem { get; set; }
    }
}
