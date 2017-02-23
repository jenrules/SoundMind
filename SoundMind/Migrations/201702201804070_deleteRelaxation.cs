namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteRelaxation : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Relaxations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Relaxations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Technique = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
