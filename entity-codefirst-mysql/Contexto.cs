using System.Data.Entity;

namespace entity_codefirst_mysql
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto") { }

        public DbSet<Contato> Contato { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Conventions.Remove();
        //}
    }
}