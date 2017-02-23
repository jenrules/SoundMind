namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaxControllerAndView : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Relaxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Technique = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Relaxes");
        }
    }
}
