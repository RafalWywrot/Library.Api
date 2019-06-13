namespace Library.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Renttable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Name = c.Int(nullable: false),
                        Surname = c.Int(nullable: false),
                        From = c.DateTime(nullable: true),
                        To = c.DateTime(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book", t => t.BookId, cascadeDelete: false)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rent", "BookId", "dbo.Book");
            DropIndex("dbo.Rent", new[] { "BookId" });
            DropTable("dbo.Rent");
        }
    }
}
