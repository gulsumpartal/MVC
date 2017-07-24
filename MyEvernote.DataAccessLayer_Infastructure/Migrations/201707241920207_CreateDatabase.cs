namespace MyEvernote.DataAccessLayer_Infastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 150),
                        CeratedOn = c.DateTime(nullable: false),
                        CrearedUsername = c.String(nullable: false, maxLength: 30),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        Text = c.String(nullable: false, maxLength: 2000),
                        IsDraft = c.Boolean(nullable: false),
                        LikeCount = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CeratedOn = c.DateTime(nullable: false),
                        CrearedUsername = c.String(nullable: false, maxLength: 30),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(nullable: false, maxLength: 30),
                        EvernoteUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.EvernoteUser_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.EvernoteUser_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 300),
                        CeratedOn = c.DateTime(nullable: false),
                        CrearedUsername = c.String(nullable: false, maxLength: 30),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(nullable: false, maxLength: 30),
                        EvernoteUser_Id = c.Int(),
                        Note_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.EvernoteUser_Id)
                .ForeignKey("dbo.Notes", t => t.Note_Id)
                .Index(t => t.EvernoteUser_Id)
                .Index(t => t.Note_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Surname = c.String(nullable: false, maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false, maxLength: 70),
                        Password = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        ActivateGuid = c.Guid(nullable: false),
                        CeratedOn = c.DateTime(nullable: false),
                        CrearedUsername = c.String(nullable: false, maxLength: 30),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvernoteUser_Id = c.Int(),
                        Note_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.EvernoteUser_Id)
                .ForeignKey("dbo.Notes", t => t.Note_Id)
                .Index(t => t.EvernoteUser_Id)
                .Index(t => t.Note_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.Notes", "EvernoteUser_Id", "dbo.Users");
            DropForeignKey("dbo.Likes", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.Likes", "EvernoteUser_Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "EvernoteUser_Id", "dbo.Users");
            DropForeignKey("dbo.Notes", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Likes", new[] { "Note_Id" });
            DropIndex("dbo.Likes", new[] { "EvernoteUser_Id" });
            DropIndex("dbo.Comments", new[] { "Note_Id" });
            DropIndex("dbo.Comments", new[] { "EvernoteUser_Id" });
            DropIndex("dbo.Notes", new[] { "EvernoteUser_Id" });
            DropIndex("dbo.Notes", new[] { "CategoryId" });
            DropTable("dbo.Likes");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Notes");
            DropTable("dbo.Categories");
        }
    }
}
