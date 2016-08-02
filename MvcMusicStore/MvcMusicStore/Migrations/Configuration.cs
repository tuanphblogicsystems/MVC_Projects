namespace MvcMusicStore.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMusicStore.Models.MusicStoreDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcMusicStore.Models.MusicStoreDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Artists.AddOrUpdate(c=>c.Name, new Artist { Name = "Al Di Meola" });
            context.Genres.AddOrUpdate(new Genre { Name = "Jazz" });
            context.Albums.AddOrUpdate(new Album { Artist = new Artist { Name = "Rush" }, Genre = new Genre { Name = "Rock" }, Price = 9.99m, Title = "Caravan" });
            base.Seed(context);

        }
    }
}
