namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class medAlarmControllerAndView : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedAlarms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedAlarms");
        }
    }
}
