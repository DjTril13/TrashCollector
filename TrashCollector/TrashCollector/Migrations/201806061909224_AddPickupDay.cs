namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPickupDay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PickupDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                        Fee = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "PickupDayId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "PickupDayId");
            AddForeignKey("dbo.Customers", "PickupDayId", "dbo.PickupDays", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "PickupDayId", "dbo.PickupDays");
            DropIndex("dbo.Customers", new[] { "PickupDayId" });
            DropColumn("dbo.Customers", "PickupDayId");
            DropTable("dbo.PickupDays");
        }
    }
}
