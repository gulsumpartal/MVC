namespace Filters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        KullaniciAdi = c.String(nullable: false, maxLength: 25),
                        ActionName = c.String(nullable: false, maxLength: 100),
                        ControllerName = c.String(nullable: false, maxLength: 100),
                        Bilgi = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 20),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiteUsers");
            DropTable("dbo.Logs");
        }
    }
}
