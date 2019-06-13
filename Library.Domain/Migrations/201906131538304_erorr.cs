namespace Library.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class erorr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rent", "From", c => c.DateTime());
            AlterColumn("dbo.Rent", "To", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rent", "To", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rent", "From", c => c.DateTime(nullable: false));
        }
    }
}
