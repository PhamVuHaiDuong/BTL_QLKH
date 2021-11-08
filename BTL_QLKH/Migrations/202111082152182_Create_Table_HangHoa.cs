namespace BTL_QLKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoa",
                c => new
                    {
                        MaHH = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenHH = c.String(maxLength: 50),
                        DonGia = c.Int(nullable: false),
                        DV = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaHH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoa");
        }
    }
}
