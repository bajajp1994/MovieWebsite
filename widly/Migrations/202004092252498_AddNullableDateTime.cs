namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rentals", "DateRented", c => c.DateTime());
        }
    }
}
