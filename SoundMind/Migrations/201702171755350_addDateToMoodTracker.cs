namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateToMoodTracker : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyMoodTrackers", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DailyMoodTrackers", "Date");
        }
    }
}
