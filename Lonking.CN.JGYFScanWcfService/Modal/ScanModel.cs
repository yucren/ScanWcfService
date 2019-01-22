namespace Lonking.CN.JGYFScanWcfService.Modal
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ScanModel : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“ScanModel”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“Lonking.CN.JGYFScanWcfService.Modal.ScanModel”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“ScanModel”
        //连接字符串。
        public ScanModel()
            : base("name=ScanModel")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScanInEntry>().HasRequired(p => p.ScanInHead).WithMany(t => t.ScanEntrys).HasForeignKey(p => p.ScanInHeadID).WillCascadeOnDelete(true);
           
        }
        
        static ScanModel()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ScanModel>());
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        public virtual DbSet<ScanInHead> ScanInHeads { get; set; }
        public virtual DbSet<ScanInEntry> ScanInEntries { get; set; }
        public virtual DbSet<ScanOutHead> ScanOutHeads { get; set; }
        public virtual DbSet<ScanOutEntry> ScanOutEntries { get; set; }
        public virtual DbSet<ScanInv> ScanInvs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}