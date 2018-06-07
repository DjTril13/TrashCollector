namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPickupWeekdays : DbMigration
    {
        public override void Up()

        {
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (1, Monday, 10)");
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (2, Tuesday, 10)");
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (3, Wednesday, 10)");
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (4, Thursday, 10)");
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (5, Friday, 10)");
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (6, Saturday, 10)");
            Sql("INSERT INTO PickupDays (Id, Day, Fee) VALUES (7, Sunday, 10)");
        }

        public override void Down()
        {
        }
    }
}
