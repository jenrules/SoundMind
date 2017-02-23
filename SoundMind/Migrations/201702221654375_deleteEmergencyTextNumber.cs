namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteEmergencyTextNumber : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "EmergencyTextNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "EmergencyTextNumber", c => c.Int(nullable: false));
        }
    }
}
