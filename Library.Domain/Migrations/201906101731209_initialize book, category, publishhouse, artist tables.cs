namespace Library.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializebookcategorypublishhouseartisttables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PageCount = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PublishHouseId = c.Int(nullable: false),
                        ArtistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artist", t => t.ArtistId, cascadeDelete: false)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: false)
                .ForeignKey("dbo.PublishHouse", t => t.PublishHouseId, cascadeDelete: false)
                .Index(t => t.CategoryId)
                .Index(t => t.PublishHouseId)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PublishHouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "PublishHouseId", "dbo.PublishHouse");
            DropForeignKey("dbo.Book", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Book", "ArtistId", "dbo.Artist");
            DropIndex("dbo.Book", new[] { "ArtistId" });
            DropIndex("dbo.Book", new[] { "PublishHouseId" });
            DropIndex("dbo.Book", new[] { "CategoryId" });
            DropTable("dbo.PublishHouse");
            DropTable("dbo.Category");
            DropTable("dbo.Book");
            DropTable("dbo.Artist");
        }
    }
}
