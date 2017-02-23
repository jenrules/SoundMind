namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmergencyTextNumberToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EmergencyTextNumber", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EmergencyTextNumber");
        }
    }
}
