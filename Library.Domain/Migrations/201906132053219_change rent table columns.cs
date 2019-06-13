namespace Library.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changerenttablecolumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rent", "Available", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Rent", "Name", c => c.String());
            AlterColumn("dbo.Rent", "Surname", c => c.String());
            DropColumn("dbo.Rent", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rent", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Rent", "Surname", c => c.Int(nullable: false));
            AlterColumn("dbo.Rent", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.Rent", "Available");
        }
    }
}
