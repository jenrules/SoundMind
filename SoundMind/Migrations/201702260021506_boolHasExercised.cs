namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class boolHasExercised : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyMoodTrackers", "hasExercised", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DailyMoodTrackers", "hasExercised");
        }
    }
}
