namespace SoundMind.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoundMind.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SoundMind.Models.ApplicationDbContext";
        }

        protected override void Seed(SoundMind.Models.ApplicationDbContext context)
        {
           
        }
    }
}
