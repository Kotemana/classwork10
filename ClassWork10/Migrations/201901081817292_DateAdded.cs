namespace ClassWork10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "DateMade", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "DateMade");
        }
    }
}
