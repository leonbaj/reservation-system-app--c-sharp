﻿namespace ReservationSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddisActivecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "isActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "isActive");
        }
    }
}
