using System.Data.Entity;
using BTL_QLKH.Models;

namespace BTL_QLKH.Models
{
    public partial class QLKHDbcontext : DbContext
    {
        public QLKHDbcontext() : base("name=QLKHDbcontext")
        {
        }

        public virtual DbSet<TaiKhoanNV> TaiKhoanNVs{ get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoanNV>()
            .Property(e => e.MaNV)
            .IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
            .Property(e => e.MaHH)
            .IsUnicode(false);
            modelBuilder.Entity<KhachHang>()
            .Property(e => e.MaKH)
            .IsUnicode(false);
        }
    }
}