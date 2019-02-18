namespace Lonking.CN.JGYFScanWcfService.Modal.K3Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Item()
        {
            t_Item1 = new HashSet<t_Item>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FItemID { get; set; }

        public int FItemClassID { get; set; }

        public int FExternID { get; set; }

        [Required]
        [StringLength(80)]
        public string FNumber { get; set; }

        public int FParentID { get; set; }

        public short FLevel { get; set; }

        public bool FDetail { get; set; }

        [Required]
        [StringLength(255)]
        public string FName { get; set; }

        public bool? FUnUsed { get; set; }

        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Required]
        [StringLength(80)]
        public string FFullNumber { get; set; }

        public bool FDiff { get; set; }

        public short FDeleted { get; set; }

        [StringLength(80)]
        public string FShortNumber { get; set; }

        [StringLength(255)]
        public string FFullName { get; set; }

        public Guid UUID { get; set; }

        public int FGRCommonID { get; set; }

        public int FSystemType { get; set; }

        public int FUseSign { get; set; }

        public int? FChkUserID { get; set; }

        public short FAccessory { get; set; }

        public int FGrControl { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] FModifyTime { get; set; }

        public short FHavePicture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Item> t_Item1 { get; set; }

        public virtual t_Item t_Item2 { get; set; }
    }
}
