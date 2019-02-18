namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ICStockBillEntry")]
    public partial class ICStockBillEntry
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FEntryID { get; set; }

        public int? FItemID { get; set; }

        public decimal FQtyMust { get; set; }

        public decimal FQty { get; set; }

        public decimal FPrice { get; set; }

        [Required]
        [StringLength(200)]
        public string FBatchNo { get; set; }

        public decimal FAmount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FSCBillInterID { get; set; }

        [StringLength(30)]
        public string FSCBillNo { get; set; }

        public int FUnitID { get; set; }

        public decimal FAuxPrice { get; set; }

        public decimal FAuxQty { get; set; }

        public decimal FAuxQtyMust { get; set; }

        public decimal FQtyActual { get; set; }

        public decimal FAuxQtyActual { get; set; }

        public decimal FPlanPrice { get; set; }

        public decimal FAuxPlanPrice { get; set; }

        public int FSourceEntryID { get; set; }

        public decimal FCommitQty { get; set; }

        public decimal FAuxCommitQty { get; set; }

        public DateTime? FKFDate { get; set; }

        public int FKFPeriod { get; set; }

        public int? FDCSPID { get; set; }

        public int? FSCSPID { get; set; }

        public decimal FConsignPrice { get; set; }

        public decimal FConsignAmount { get; set; }

        public decimal FProcessCost { get; set; }

        public decimal FMaterialCost { get; set; }

        public decimal FTaxAmount { get; set; }

        [Required]
        [StringLength(80)]
        public string FMapNumber { get; set; }

        [StringLength(256)]
        public string FMapName { get; set; }

        public int FOrgBillEntryID { get; set; }

        public int? FOperID { get; set; }

        public decimal FPlanAmount { get; set; }

        public decimal FProcessPrice { get; set; }

        public decimal FTaxRate { get; set; }

        public int? FSnListID { get; set; }

        public decimal FAmtRef { get; set; }

        public int FAuxPropID { get; set; }

        public decimal FCost { get; set; }

        public decimal FPriceRef { get; set; }

        public decimal FAuxPriceRef { get; set; }

        public DateTime? FFetchDate { get; set; }

        public decimal FQtyInvoice { get; set; }

        public decimal FQtyInvoiceBase { get; set; }

        public decimal FUnitCost { get; set; }

        public decimal FSecCoefficient { get; set; }

        public decimal FSecQty { get; set; }

        public decimal FSecCommitQty { get; set; }

        public int FSourceTranType { get; set; }

        public int FSourceInterId { get; set; }

        [Required]
        [StringLength(255)]
        public string FSourceBillNo { get; set; }

        public int FContractInterID { get; set; }

        public int FContractEntryID { get; set; }

        [Required]
        [StringLength(255)]
        public string FContractBillNo { get; set; }

        [Required]
        [StringLength(255)]
        public string FICMOBillNo { get; set; }

        public int FICMOInterID { get; set; }

        public int FPPBomEntryID { get; set; }

        public int FOrderInterID { get; set; }

        public int FOrderEntryID { get; set; }

        [Required]
        [StringLength(255)]
        public string FOrderBillNo { get; set; }

        public decimal FAllHookQTY { get; set; }

        public decimal FAllHookAmount { get; set; }

        public decimal FCurrentHookQTY { get; set; }

        public decimal FCurrentHookAmount { get; set; }

        public decimal FStdAllHookAmount { get; set; }

        public decimal FStdCurrentHookAmount { get; set; }

        public int FSCStockID { get; set; }

        public int FDCStockID { get; set; }

        public DateTime? FPeriodDate { get; set; }

        public int FCostObjGroupID { get; set; }

        public int FCostOBJID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FDetailID { get; set; }

        public decimal FMaterialCostPrice { get; set; }

        public int FReProduceType { get; set; }

        public int FBomInterID { get; set; }

        public decimal FDiscountRate { get; set; }

        public decimal FDiscountAmount { get; set; }

        public int FSepcialSaleId { get; set; }

        public decimal FOutCommitQty { get; set; }

        public decimal FOutSecCommitQty { get; set; }

        public decimal FDBCommitQty { get; set; }

        public decimal FDBSecCommitQty { get; set; }

        public decimal FAuxQtyInvoice { get; set; }

        public int FOperSN { get; set; }

        public short FCheckStatus { get; set; }

        public decimal? FSplitSecQty { get; set; }

        public int FInStockID { get; set; }

        public decimal FSaleCommitQty { get; set; }

        public decimal FSaleSecCommitQty { get; set; }

        public decimal FSaleAuxCommitQty { get; set; }

        public int FSelectedProcID { get; set; }

        public decimal FVWInStockQty { get; set; }

        public decimal FAuxVWInStockQty { get; set; }

        public decimal FSecVWInStockQty { get; set; }

        public int? FEntrySelfB0446 { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0447 { get; set; }

        public int? FEntrySelfA9739 { get; set; }

        public int? FEntrySelfB0937 { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0938 { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0842 { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0841 { get; set; }

        [StringLength(255)]
        public string FEntrySelfA0549 { get; set; }

        [StringLength(255)]
        public string FEntrySelfA0548 { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0843 { get; set; }

        [StringLength(255)]
        public string FEntrySelfA0156 { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0450 { get; set; }

        [StringLength(255)]
        public string fsrmid { get; set; }

        [StringLength(255)]
        public string FEntrySelfB0159 { get; set; }

        public decimal FSecInvoiceQty { get; set; }

        public int FCostCenterID { get; set; }

        public int FPlanMode { get; set; }

        [Required]
        [StringLength(50)]
        public string FMTONo { get; set; }

        public decimal FSecQtyActual { get; set; }

        public decimal FSecQtyMust { get; set; }

        [StringLength(255)]
        public string FClientOrderNo { get; set; }

        public int? FClientEntryID { get; set; }

        public byte FRowClosed { get; set; }

        public decimal? FCostPercentage { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSize { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSuite { get; set; }

        [Required]
        [StringLength(4000)]
        public string FPositionNo { get; set; }

        public byte? FAcctCheck { get; set; }

        public byte? FClosing { get; set; }

        public int? FDeliveryNoticeEntryID { get; set; }

        public int? FDeliveryNoticeFID { get; set; }

        public int FIsVMI { get; set; }

        public int FEntrySupply { get; set; }

        public int FChkPassItem { get; set; }

        public int FSEOutInterID { get; set; }

        public int FSEOutEntryID { get; set; }

        [Required]
        [StringLength(255)]
        public string FSEOutBillNo { get; set; }

        [Required]
        [StringLength(255)]
        public string FConfirmMemEntry { get; set; }

        public decimal FWebReturnQty { get; set; }

        public decimal FWebReturnAuxQty { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemStatementBillNO { get; set; }

        public int FItemStatementEntryID { get; set; }

        public int FItemStatementInterID { get; set; }

        public decimal? FCommitAmt { get; set; }

        public int? FFatherProductID { get; set; }

        public decimal FRealAmount { get; set; }

        public decimal FRealPrice { get; set; }

        public decimal FDefaultBaseQty { get; set; }

        public decimal FDefaultQty { get; set; }

        public decimal FRealStockBaseQty { get; set; }

        public decimal FRealStockQty { get; set; }

        public int FDiscardID { get; set; }

        [StringLength(255)]
        public string FOLOrderBillNo { get; set; }

        public int FLockFlag { get; set; }

        [Required]
        [StringLength(255)]
        public string FReturnNoticeBillNO { get; set; }

        public int FReturnNoticeEntryID { get; set; }

        public int FReturnNoticeInterID { get; set; }

        public decimal FProductFileQty { get; set; }

        [StringLength(255)]
        public string FServiceRequestNo { get; set; }

        [Required]
        [StringLength(10)]
        public string FSplitState { get; set; }

        public decimal FQtySplit { get; set; }

        public decimal FAuxQtySplit { get; set; }

        public decimal FAddQty { get; set; }

        public decimal FAuxAddQty { get; set; }

        public decimal? FPurchasePrice { get; set; }

        public decimal? FPurchaseAmount { get; set; }

        public decimal? FCheckAmount { get; set; }

        public int FOutSourceInterID { get; set; }

        public int FOutSourceEntryID { get; set; }

        public int FOutSourceTranType { get; set; }

        public decimal? FProcessTaxPrice { get; set; }

        public decimal? FProcessTaxCost { get; set; }

        [StringLength(255)]
        public string FShopName { get; set; }

        public decimal? FPostFee { get; set; }

        public decimal? FReviewBillsQty { get; set; }

        public decimal FPTLQty { get; set; }
        public virtual ICStockBill ICStockBill { get; set; }
    }
}
