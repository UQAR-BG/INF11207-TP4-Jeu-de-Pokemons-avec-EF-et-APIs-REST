using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using Microsoft.EntityFrameworkCore;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST
{
    public class JeuDePokemonsDbContext : DbContext
    {
        public DbSet<EfficaciteAttaque> Efficacites { get; set; }
        public DbSet<Correspondance> Correspondances { get; set; }
        public DbSet<Attaque> Attaques { get; set; }
        public DbSet<Evolution> Evolutions { get; set; }

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

            modelBuilder.Entity<Correspondance>(e => {
                e.HasKey(c => c.CorrespondanceId);
                e.Property(c => c.CorrespondancesSerialisee).IsRequired();
                e.HasData(Correspondance.ChargerCorrespondancesDepuisFichier());
            });

            modelBuilder.Entity<Attaque>(e => {
                e.HasKey(a => a.AttaqueId);
                e.Property(a => a.Name).IsRequired();
                e.Property(a => a.Damage).IsRequired();
                e.Property(a => a.Type).IsRequired();
                e.HasData(Loader.ChargerDepuisFichier<Attaque>("Resources/Data/Attacks.json"));
            });

            modelBuilder.Entity<Evolution>(e => {
                e.HasKey(ev => ev.EvolutionId);
                e.Property(ev => ev.Level).IsRequired();
                e.Property(ev => ev.To).IsRequired();
                e.HasData(Loader.ChargerDepuisFichier<Evolution>("Resources/Data/Evolutions.json"));
            });
        }
    }
}
