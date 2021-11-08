namespace BTL_QLKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKH = c.String(),
                        SDT = c.String(maxLength: 10),
                        GioiTinh = c.String(),
                        NgaySinh = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHang");
        }
    }
}
