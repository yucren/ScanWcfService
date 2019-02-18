namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FItemID { get; set; }

        [Required]
        [StringLength(10)]
        public string FBrNO { get; set; }

        public int? FManager { get; set; }

        [StringLength(30)]
        public string FPhone { get; set; }

        [StringLength(30)]
        public string FFax { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [StringLength(255)]
        public string FNumber { get; set; }

        [StringLength(255)]
        public string FName { get; set; }

        public int? FParentID { get; set; }

        public int FDProperty { get; set; }

        public int? FDStock { get; set; }

        public short FDeleted { get; set; }

        [StringLength(80)]
        public string FShortNumber { get; set; }

        public int FAcctID { get; set; }

        public int FCostAccountType { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] FModifyTime { get; set; }

        public int FCalID { get; set; }

        public int? FPlanArea { get; set; }

        public int FOtherARAcctID { get; set; }

        public int FOtherAPAcctID { get; set; }

        public int FPreARAcctID { get; set; }

        public int FPreAPAcctID { get; set; }

        public bool FIsCreditMgr { get; set; }

        public bool FIsVDept { get; set; }
    }
}
