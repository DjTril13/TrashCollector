namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomethingChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}
