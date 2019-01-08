namespace ClassWork10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        TelNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Model = c.String(),
                        Color = c.String(),
                        Dealer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dealer", t => t.Dealer_Id)
                .Index(t => t.Dealer_Id);
            
            CreateTable(
                "dbo.Dealer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Car", "Dealer_Id", "dbo.Dealer");
            DropForeignKey("dbo.Dealer", "Address_Id", "dbo.Address");
            DropIndex("dbo.Dealer", new[] { "Address_Id" });
            DropIndex("dbo.Car", new[] { "Dealer_Id" });
            DropTable("dbo.Dealer");
            DropTable("dbo.Car");
            DropTable("dbo.Address");
        }
    }
}
