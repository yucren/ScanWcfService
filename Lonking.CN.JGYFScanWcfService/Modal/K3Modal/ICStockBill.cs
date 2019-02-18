namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ICStockBill")]
    public partial class ICStockBill
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        public short? FTranType { get; set; }

        public DateTime? FDate { get; set; }

        [Required]
        [StringLength(255)]
        public string FBillNo { get; set; }

        [StringLength(255)]
        public string FUse { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FDCStockID { get; set; }

        public int? FSCStockID { get; set; }

        public int? FDeptID { get; set; }

        public int? FEmpID { get; set; }

        public int? FSupplyID { get; set; }

        public int? FPosterID { get; set; }

        public int? FCheckerID { get; set; }

        public int? FFManagerID { get; set; }

        public int? FSManagerID { get; set; }

        public int? FBillerID { get; set; }

        public int? FReturnBillInterID { get; set; }

        [StringLength(30)]
        public string FSCBillNo { get; set; }

        public int? FHookInterID { get; set; }

        public int? FVchInterID { get; set; }

        public short FPosted { get; set; }

        public short? FCheckSelect { get; set; }

        public int? FCurrencyID { get; set; }

        public int? FSaleStyle { get; set; }

        public int? FAcctID { get; set; }

        public short FROB { get; set; }

        [StringLength(30)]
        public string FRSCBillNo { get; set; }

        public short FStatus { get; set; }

        public bool FUpStockWhenSave { get; set; }

        public bool FCancellation { get; set; }

        public int FOrgBillInterID { get; set; }

        public int? FBillTypeID { get; set; }

        public int? FPOStyle { get; set; }

        public int? FMultiCheckLevel1 { get; set; }

        public int? FMultiCheckLevel2 { get; set; }

        public int? FMultiCheckLevel3 { get; set; }

        public int? FMultiCheckLevel4 { get; set; }

        public int? FMultiCheckLevel5 { get; set; }

        public int? FMultiCheckLevel6 { get; set; }

        public DateTime? FMultiCheckDate1 { get; set; }

        public DateTime? FMultiCheckDate2 { get; set; }

        public DateTime? FMultiCheckDate3 { get; set; }

        public DateTime? FMultiCheckDate4 { get; set; }

        public DateTime? FMultiCheckDate5 { get; set; }

        public DateTime? FMultiCheckDate6 { get; set; }

        public int? FCurCheckLevel { get; set; }

        public int? FTaskID { get; set; }

        public int? FResourceID { get; set; }

        public bool FBackFlushed { get; set; }

        public int FWBInterID { get; set; }

        public int FTranStatus { get; set; }

        public int? FZPBillInterID { get; set; }

        public int? FRelateBrID { get; set; }

        public int FPurposeID { get; set; }

        public Guid FUUID { get; set; }

        public int FRelateInvoiceID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FOperDate { get; set; }

        public int? FImport { get; set; }

        public int? FSystemType { get; set; }

        public int FMarketingStyle { get; set; }

        public int FPayBillID { get; set; }

        public DateTime? FCheckDate { get; set; }

        [StringLength(1000)]
        public string FExplanation { get; set; }

        [Required]
        [StringLength(255)]
        public string FFetchAdd { get; set; }

        public DateTime? FFetchDate { get; set; }

        public int FManagerID { get; set; }

        public int FRefType { get; set; }

        public int FSelTranType { get; set; }

        public int FChildren { get; set; }

        public short FHookStatus { get; set; }

        public int FActPriceVchTplID { get; set; }

        public int FPlanPriceVchTplID { get; set; }

        public int FProcID { get; set; }

        public int FActualVchTplID { get; set; }

        public int FPlanVchTplID { get; set; }

        public int? FBrID { get; set; }

        public int FVIPCardID { get; set; }

        public decimal FVIPScore { get; set; }

        public decimal FHolisticDiscountRate { get; set; }

        [Required]
        [StringLength(255)]
        public string FPOSName { get; set; }

        public int FWorkShiftId { get; set; }

        public int FCussentAcctID { get; set; }

        public bool FZanGuCount { get; set; }

        [StringLength(255)]
        public string FPOOrdBillNo { get; set; }

        public int FLSSrcInterID { get; set; }

        public int? FHeadSelfB0432 { get; set; }

        public int? FHeadSelfA0137 { get; set; }

        public int? FHeadSelfA0227 { get; set; }

        public int? FHeadSelfB0144 { get; set; }

        [StringLength(255)]
        public string FHeadSelfB0145 { get; set; }

        public int? FHeadSelfD0132 { get; set; }

        public int? FHeadSelfD0133 { get; set; }

        public int? FHeadSelfA0228 { get; set; }

        [StringLength(255)]
        public string FHeadSelfB0146 { get; set; }

        [StringLength(255)]
        public string FHeadSelfB0147 { get; set; }

        [StringLength(255)]
        public string FHeadSelfB0148 { get; set; }

        [StringLength(255)]
        public string FHeadSelfB0149 { get; set; }

        public DateTime? FSettleDate { get; set; }

        public int? FManageType { get; set; }

        public int? FOrderAffirm { get; set; }

        public byte FAutoCreType { get; set; }

        [StringLength(255)]
        public string FConsignee { get; set; }

        public int FDrpRelateTranType { get; set; }

        public short FPrintCount { get; set; }

        public int? FPOMode { get; set; }

        public int FInventoryType { get; set; }

        public int FObjectItem { get; set; }

        public short FConfirmStatus { get; set; }

        [Required]
        [StringLength(255)]
        public string FConfirmMem { get; set; }

        public DateTime? FConfirmDate { get; set; }

        public int FConfirmer { get; set; }

        public int FAutoCreatePeriod { get; set; }

        [Required]
        [StringLength(25)]
        public string FYearPeriod { get; set; }

        public int? FPayCondition { get; set; }

        public int? FsourceType { get; set; }

        [StringLength(255)]
        public string FReceiver { get; set; }

        [Required]
        [StringLength(10)]
        public string FInvoiceStatus { get; set; }

        public int FSendStatus { get; set; }

        public int FEnterpriseID { get; set; }

        public int? FBillReviewer { get; set; }

        public DateTime? FBillReviewDate { get; set; }

        [StringLength(255)]
        public string FCod { get; set; }

        [StringLength(255)]
        public string FReceiveMan { get; set; }

        [StringLength(255)]
        public string FConsigneeAdd { get; set; }

        public int FISUpLoad { get; set; }

        [StringLength(30)]
        public string FReceiverMobile { get; set; }

        public virtual HashSet<ICStockBillEntry> ICStockBillEntries { get; set; }
    }
}
