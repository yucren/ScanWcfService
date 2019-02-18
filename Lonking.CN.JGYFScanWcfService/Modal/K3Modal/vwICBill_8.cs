namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwICBill_8
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

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string FbillNo { get; set; }

        [StringLength(80)]
        public string FSaleStyle { get; set; }

        [StringLength(80)]
        public string FSupplyID { get; set; }

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

        [StringLength(200)]
        public string FBatchNo { get; set; }

        public decimal? Fauxqty { get; set; }

        public decimal? Fauxprice { get; set; }

        public decimal? Famount { get; set; }

        [StringLength(255)]
        public string FFManagerID { get; set; }

        [StringLength(255)]
        public string FSManagerID { get; set; }

        [StringLength(50)]
        public string FBillerID { get; set; }

        [StringLength(50)]
        public string Fcheckerid { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string FVoucherFlag { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [StringLength(111)]
        public string FVchInterID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string FHookFlag { get; set; }

        [StringLength(2)]
        public string FOrgBillInterID { get; set; }

        [StringLength(80)]
        public string FUnitGroupID { get; set; }

        public decimal? FQty { get; set; }

        public decimal? FAuxPlanPrice { get; set; }

        public decimal? FPlanAmount { get; set; }

        [StringLength(80)]
        public string FCUUnitID { get; set; }

        public decimal? FcuQty { get; set; }

        [StringLength(80)]
        public string FDCSPID { get; set; }

        public int? FKFPeriod { get; set; }

        public DateTime? FKFDate { get; set; }

        [StringLength(255)]
        public string FZPInterID { get; set; }

        [StringLength(256)]
        public string FMapName { get; set; }

        [StringLength(80)]
        public string FMapNumber { get; set; }

        public decimal? FConsignPrice { get; set; }

        public decimal? FConsignAmount { get; set; }

        [StringLength(80)]
        public string FRelateBrID { get; set; }

        [StringLength(80)]
        public string FIsVMI { get; set; }

        [StringLength(80)]
        public string FEntrySupply { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string FClosing { get; set; }

        [StringLength(80)]
        public string FChkPassItem { get; set; }
    }
}
