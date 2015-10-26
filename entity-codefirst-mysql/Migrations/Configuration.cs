using System.Data.Entity.Migrations;
using MySql.Data.Entity;

namespace entity_codefirst_mysql.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;            
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Contato.AddOrUpdate(
              p => p.Nome,
              new Contato { Nome = "Andrew Peters", Email = "andrewpeters@damasio34.com" },
              new Contato { Nome = "Brice Lambson", Email = "bricelambson@damasio34.com" },
              new Contato { Nome = "Rowan Miller", Email = "rowanmiller@damasio34.com" }
            );
            
        }
    }
}
