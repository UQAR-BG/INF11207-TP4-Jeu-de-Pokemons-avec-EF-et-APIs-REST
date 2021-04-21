using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using Microsoft.EntityFrameworkCore;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST
{
    public class JeuDePokemonsDbContext : DbContext
    {
        public DbSet<EfficaciteAttaque> Efficacites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;
                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False;Database=JeuDePokemonsDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EfficaciteAttaque>(e => {
                e.HasKey(ea => ea.EfficaciteId);
                e.Property(ea => ea.Attack).IsRequired();
                e.Property(ea => ea.Defend).IsRequired();
                e.Property(ea => ea.Effectiveness).IsRequired();
                e.HasData(EfficaciteAttaque.ChargerEfficacitesDepuisFichier());
            });
        }
    }
}
