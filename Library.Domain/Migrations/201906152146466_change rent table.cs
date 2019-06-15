namespace Library.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changerenttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rent", "Contact", c => c.String());
            DropColumn("dbo.Rent", "Available");
            DropColumn("dbo.Rent", "To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rent", "To", c => c.DateTime());
            AddColumn("dbo.Rent", "Available", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rent", "Contact");
        }
    }
}
