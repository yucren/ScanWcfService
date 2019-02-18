namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class K3Model : DbContext
    {
        public K3Model()
            : base("name=K3Model")
        {
        }
        public virtual DbSet<vwICBill_11> vwICBill_11 { get; set; }
        public virtual DbSet<vwICBill_2> vwICBill_2 { get; set; }
        public virtual DbSet<vwICBill_8> vwICBill_8 { get; set; }

        public virtual DbSet<ICStockBill> ICStockBill { get; }
        public virtual DbSet<ICStockBillEntry> ICStockBillEntry { get; }
        public virtual DbSet<t_Department> t_Department { get; }
        public virtual DbSet<t_Item> t_Item { get;}
        public virtual DbSet<vw_ICCustomerInfo> vw_ICCustomerInfo { get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FUse)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FSCBillNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FRSCBillNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FOperDate)
                .IsFixedLength();

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FVIPScore)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FHolisticDiscountRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FPOSName)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FHeadSelfB0145)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FHeadSelfB0146)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FHeadSelfB0147)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FHeadSelfB0148)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FHeadSelfB0149)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FInvoiceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FCod)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FReceiveMan)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FConsigneeAdd)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBill>()
                .Property(e => e.FReceiverMobile)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSCBillNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FQtyActual)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxQtyActual)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPlanPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxPlanPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FConsignPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FConsignAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FProcessCost)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FMaterialCost)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FTaxAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FMapNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPlanAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FProcessPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FTaxRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAmtRef)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPriceRef)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxPriceRef)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FQtyInvoice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FQtyInvoiceBase)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FUnitCost)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecCoefficient)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAllHookQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAllHookAmount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCurrentHookQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCurrentHookAmount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FStdAllHookAmount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FStdCurrentHookAmount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FMaterialCostPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FDiscountRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FDiscountAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FOutCommitQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FOutSecCommitQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FDBCommitQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FDBSecCommitQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxQtyInvoice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSplitSecQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSaleCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSaleSecCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSaleAuxCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FVWInStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxVWInStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecVWInStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0447)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0938)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0842)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0841)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfA0549)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfA0548)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0843)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfA0156)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0450)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.fsrmid)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FEntrySelfB0159)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecInvoiceQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecQtyActual)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSecQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCostPercentage)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FWebReturnQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FWebReturnAuxQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FItemStatementBillNO)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCommitAmt)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FRealAmount)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FRealPrice)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FDefaultBaseQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FDefaultQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FRealStockBaseQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FRealStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FReturnNoticeBillNO)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FProductFileQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FServiceRequestNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FSplitState)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FQtySplit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxQtySplit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAddQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FAuxAddQty)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPurchasePrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPurchaseAmount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FCheckAmount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FProcessTaxPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FProcessTaxCost)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FShopName)
                .IsUnicode(false);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPostFee)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FReviewBillsQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICStockBillEntry>()
                .Property(e => e.FPTLQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FBrNO)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FPhone)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FFax)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Department>()
                .Property(e => e.FModifyTime)
                .IsFixedLength();

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FFullNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FFullName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Item>()
                .Property(e => e.FModifyTime)
                .IsFixedLength();

            modelBuilder.Entity<t_Item>()
                .HasMany(e => e.t_Item1)
                .WithRequired(e => e.t_Item2)
                .HasForeignKey(e => e.FParentID);

            modelBuilder.Entity<vw_ICCustomerInfo>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vw_ICCustomerInfo>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<vw_ICCustomerInfo>()
                .Property(e => e.FBillNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_ICCustomerInfo>()
                .Property(e => e.FFullNumber)
                .IsUnicode(false);
            modelBuilder.Entity<vwICBill_11>()
              .Property(e => e.FCheckFlag)
              .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FCancellation)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.Fuse)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FSCStockID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FItemID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.Fmodel)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FUnitID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FAuxQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.Fauxqty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.Fauxprice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.Famount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FSManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FFManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FPurposeID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FUnitGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FAuxPlanPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FPlanAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FCUUnitID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FcuQtyMust)
                .HasPrecision(38, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FCUQty)
                .HasPrecision(38, 10);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FDCSPID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FIsVMI)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FEntrySupply)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_11>()
                .Property(e => e.FClosing)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FCheckFlag)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FCancellation)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FDCStockID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FItemID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.Fmodel)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FUnitID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FAuxQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.Fauxqty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.Fauxprice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.Famount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FFManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FSManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FUnitGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FAuxPlanPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FPlanAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FCUUnitID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FcuQtyMust)
                .HasPrecision(38, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FCUQty)
                .HasPrecision(38, 10);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FDCSPID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FBackFlushed)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_2>()
                .Property(e => e.FChkPassItem)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FCheckFlag)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FCancellation)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FSaleStyle)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FSupplyID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FDCStockID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FItemID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.Fmodel)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FUnitID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.Fauxqty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.Fauxprice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.Famount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FFManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FSManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FVoucherFlag)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FHookFlag)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FOrgBillInterID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FUnitGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FAuxPlanPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FPlanAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FCUUnitID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FcuQty)
                .HasPrecision(38, 10);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FDCSPID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FMapNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FConsignPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FConsignAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FRelateBrID)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FIsVMI)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FEntrySupply)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FClosing)
                .IsUnicode(false);

            modelBuilder.Entity<vwICBill_8>()
                .Property(e => e.FChkPassItem)
                .IsUnicode(false);

        }
    }
}
