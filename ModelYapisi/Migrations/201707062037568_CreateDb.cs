namespace ModelYapisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressDetail = c.String(),
                        KisiId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kisiler", t => t.KisiId_Id)
                .Index(t => t.KisiId_Id);
            
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 25),
                        Soyad = c.String(nullable: false, maxLength: 25),
                        Yas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adresler", "KisiId_Id", "dbo.Kisiler");
            DropIndex("dbo.Adresler", new[] { "KisiId_Id" });
            DropTable("dbo.Kisiler");
            DropTable("dbo.Adresler");
        }
    }
}
