namespace BTL_QLKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TaiKhoanNV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaiKhoanNV",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128, unicode: false),
                        HoTenNV = c.String(),
                        TenTK = c.String(),
                        MatKhau = c.String(),
                        SDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaiKhoanNV");
        }
    }
}
