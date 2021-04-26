using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST
{
    public class JeuDePokemonsDbContext : DbContext
    {
        public DbSet<EfficaciteAttaque> Efficacites { get; set; }
        public DbSet<Correspondance> Correspondances { get; set; }
        public DbSet<Attaque> Attaques { get; set; }
        public DbSet<Evolution> Evolutions { get; set; }
        public DbSet<Statistiques> Statistiques { get; set; }
        public DbSet<JaugeXp> XpGauges { get; set; }
        public DbSet<JaugeVie> HealthGauges { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<DepotPokemons> Depots { get; set; }
        public DbSet<Dresseur> Dresseurs { get; set; }

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

            modelBuilder.Entity<Statistiques>(e => {
                e.HasKey(s => s.StatistiquesId);
                e.Property(s => s.MontantAccumule).IsRequired();
                e.Property(s => s.MontantDepense).IsRequired();
                e.Property(s => s.PokemonsAchetes).IsRequired();
                e.Property(s => s.PokemonsDebloques).IsRequired();
                e.Property(s => s.CombatsTotal).IsRequired();
                e.Property(s => s.CombatsGagnes).IsRequired();
                e.Property(s => s.CombatsPerdus).IsRequired();
                e.HasData(new Statistiques(5000, 1)
                {
                    StatistiquesId = 1
                });
            });

            modelBuilder.Entity<JaugeXp>(e => {
                e.HasKey(j => j.GaugeId);
                e.Property(j => j.MaxValue).IsRequired();
                e.Property(j => j.Value).IsRequired();
                e.HasData(new List<JaugeXp>() {
                    new JaugeXp(100) { GaugeId = 1 },
                    new JaugeXp(100) { GaugeId = 2 },
                });
            });

            modelBuilder.Entity<JaugeVie>(e => {
                e.HasKey(j => j.GaugeId);
                e.Property(j => j.MaxValue).IsRequired();
                e.Property(j => j.Value).IsRequired();
                e.HasData(new JaugeVie(50)
                {
                    GaugeId = 1
                });
            });

            List<Pokemon> pokemonsDeBase = Pokemon.ChargerPokemonDeBase();
            Pokemon pokemon = (Pokemon)pokemonsDeBase[0].Clone();
            pokemon.Id = 152;
            pokemon.Achete = true;
            pokemon.DepotId = 1;
            pokemon.HpGaugeId = 1;
            pokemon.XpGaugeId = 1;
            pokemonsDeBase.Add(pokemon);

            Dresseur adversaire;
            Loader.Charger(out adversaire, "Resources/Data/Adversaire.json");

            modelBuilder.Entity<Pokemon>(e =>
            {
                e.HasKey(p => p.Id);
                e.Property(p => p.DepotId);
                e.Property(p => p.Name).IsRequired();
                e.Property(p => p.Level).IsRequired();
                e.Property(p => p.XpGaugeId).IsRequired();
                e.Property(p => p.TypesSerialises).IsRequired();
                e.Property(p => p.EvolutionId).IsRequired();
                e.Property(p => p.Description).IsRequired();
                e.Property(p => p.ATK).IsRequired();
                e.Property(p => p.DEF).IsRequired();
                e.Property(p => p.Price).IsRequired();
                e.Property(p => p.Health).IsRequired();
                e.Property(p => p.HpGaugeId).IsRequired();
                e.Property(p => p.Image).IsRequired();
                e.Property(p => p.AttacksIdsSerialises).IsRequired();
                e.Property(p => p.Achete).IsRequired();
                e.Property(p => p.Equipe).IsRequired();
                e.Property(p => p.Emplacement).IsRequired();
                e.HasData(pokemonsDeBase);
            });

            modelBuilder.Entity<DepotPokemons>(e =>
            {
                e.HasKey(d => d.DepotId);
                e.Property(d => d.DresseurId);
                e.Property(d => d.IndexPokemonsEquipesSerialises);
                e.HasData(new DepotPokemons()
                {
                    DepotId = 1,
                    DresseurId = 1,
                    IndexPokemonsEquipesSerialises = adversaire.Depot.IndexPokemonsEquipesSerialises
                });
            });

            modelBuilder.Entity<Dresseur>(e =>
            {
                e.HasKey(d => d.DresseurId);
                e.Property(d => d.Name).IsRequired();
                e.Property(d => d.FirstName).IsRequired();
                e.Property(d => d.Age).IsRequired();
                e.Property(d => d.Money).IsRequired();
                e.Property(d => d.Level).IsRequired();
                e.Property(d => d.XpGaugeId).IsRequired();
                e.Property(d => d.StatistiquesId);
                e.Property(d => d.DepotId);
                e.HasData(adversaire);
            });
        }
    }
}
