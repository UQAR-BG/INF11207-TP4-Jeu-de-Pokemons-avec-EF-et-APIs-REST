using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class AjoutAdversairedansBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Depots",
                columns: new[] { "DepotId", "DresseurId", "IndexPokemonsEquipesSerialises" },
                values: new object[] { 1, 1, "[\r\n  0,\r\n  -1,\r\n  -1\r\n]" });

            migrationBuilder.InsertData(
                table: "Dresseurs",
                columns: new[] { "DresseurId", "Age", "DepotId", "FirstName", "Level", "Money", "Name", "StatistiquesId", "XpGaugeId" },
                values: new object[] { 1, 35, 1, "John", 5, 5000, "Doe", 1, 2 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ATK", "Achete", "AttacksIdsSerialises", "DEF", "DepotId", "Description", "Emplacement", "Equipe", "EvolutionId", "Health", "HpGaugeId", "Image", "Level", "Name", "Price", "TypesSerialises", "XpGaugeId" },
                values: new object[,]
                {
                    { 97, 1, false, "[\r\n  73,\r\n  29,\r\n  99,\r\n  31,\r\n  100\r\n]", 1, 0, "Hypno holds a pendulum in its hand. The arcing movement and glitter of the pendulum lull the foe into a deep state of hypnosis. While this Pokémon searches for prey, it polishes the pendulum.  Hypno holds a pendulum in its hand. The arcing movement and glitter of the pendulum lull the foe into a deep state of hypnosis. While this Pokémon searches for prey, it polishes the pendulum.", 0, false, 0, 85, 0, "/Resources/Images/97.png", 1, "Hypno", 100, "[\r\n  11\r\n]", 0 },
                    { 98, 1, false, "[\r\n  18,\r\n  61,\r\n  116,\r\n  95,\r\n  21\r\n]", 1, 0, "Krabby live on beaches, burrowed inside holes dug into the sand. On sandy beaches with little in the way of food, these Pokémon can be seen squabbling with each other over territory.  Krabby live on beaches, burrowed inside holes dug into the sand. On sandy beaches with little in the way of food, these Pokémon can be seen squabbling with each other over territory.", 0, false, 40, 30, 0, "/Resources/Images/98.png", 1, "Krabby", 100, "[\r\n  2\r\n]", 0 },
                    { 99, 1, false, "[\r\n  64,\r\n  61,\r\n  116,\r\n  36,\r\n  21\r\n]", 1, 0, "Kingler has an enormous, oversized claw. It waves this huge claw in the air to communicate with others. However, because the claw is so heavy, the Pokémon quickly tires.  Kingler has an enormous, oversized claw. It waves this huge claw in the air to communicate with others. However, because the claw is so heavy, the Pokémon quickly tires.", 0, false, 0, 55, 0, "/Resources/Images/99.png", 1, "Kingler", 100, "[\r\n  2\r\n]", 0 },
                    { 100, 1, false, "[\r\n  58,\r\n  2,\r\n  55,\r\n  56,\r\n  32\r\n]", 1, 0, "Voltorb is extremely sensitive—it explodes at the slightest of shocks. It is rumored that it was first created when a Poké Ball was exposed to a powerful pulse of energy.  Voltorb was first sighted at a company that manufactures Poké Balls. The link between that sighting and the fact that this Pokémon looks very similar to a Poké Ball remains a mystery.", 0, false, 41, 40, 0, "/Resources/Images/100.png", 1, "Voltorb", 100, "[\r\n  3\r\n]", 0 },
                    { 101, 1, false, "[\r\n  58,\r\n  2,\r\n  55,\r\n  56,\r\n  45\r\n]", 1, 0, "One of Electrode's characteristics is its attraction to Electricity. It is a problematical Pokémon that congregates mostly at Electrical power plants to feed on Electricity that has just been generated.  Electrode eats Electricity in the atmosphere. On days when lightning strikes, you can see this Pokémon exploding all over the place from eating too much Electricity.", 0, false, 0, 60, 0, "/Resources/Images/101.png", 1, "Electrode", 100, "[\r\n  3\r\n]", 0 },
                    { 102, 1, false, "[\r\n  29,\r\n  4,\r\n  31,\r\n  105\r\n]", 1, 0, "This Pokémon consists of six eggs that form a closely knit cluster. The six eggs attract each other and spin around. When cracks increasingly appear on the eggs, Exeggcute is close to evolution.  This Pokémon consists of six eggs that form a closely knit cluster. The six eggs attract each other and spin around. When cracks increasingly appear on the eggs, Exeggcute is close to evolution.", 0, false, 0, 60, 0, "/Resources/Images/102.png", 1, "Exeggcute", 100, "[\r\n  4,\r\n  11\r\n]", 0 },
                    { 103, 1, false, "[\r\n  29,\r\n  73,\r\n  4,\r\n  31,\r\n  7\r\n]", 1, 0, "Exeggutor originally came from the tropics. Its heads steadily grow larger from exposure to strong sunlight. It is said that when the heads fall off, they group together to form Exeggcute.  Exeggutor originally came from the tropics. Its heads steadily grow larger from exposure to strong sunlight. It is said that when the heads fall off, they group together to form Exeggcute.", 0, false, 0, 95, 0, "/Resources/Images/103.png", 1, "Exeggutor", 100, "[\r\n  4,\r\n  11\r\n]", 0 },
                    { 104, 1, false, "[\r\n  83,\r\n  117,\r\n  118,\r\n  42,\r\n  66\r\n]", 1, 0, "Cubone pines for the mother it will never see again. Seeing a likeness of its mother in the full moon, it cries. The stains on the skull the Pokémon wears are made by the tears it sheds.  Cubone pines for the mother it will never see again. Seeing a likeness of its mother in the full moon, it cries. The stains on the skull the Pokémon wears are made by the tears it sheds.", 0, false, 42, 50, 0, "/Resources/Images/104.png", 1, "Cubone", 100, "[\r\n  8\r\n]", 0 },
                    { 105, 1, false, "[\r\n  83,\r\n  117,\r\n  118,\r\n  42,\r\n  65\r\n]", 1, 0, "Marowak is the evolved form of a Cubone that has overcome its sadness at the loss of its mother and grown tough. This Pokémon's tempered and hardened spirit is not easily broken.  Marowak is the evolved form of a Cubone that has overcome its sadness at the loss of its mother and grown tough. This Pokémon's tempered and hardened spirit is not easily broken.", 0, false, 0, 60, 0, "/Resources/Images/105.png", 1, "Marowak", 100, "[\r\n  8\r\n]", 0 },
                    { 106, 1, false, "[\r\n  91,\r\n  117,\r\n  119,\r\n  90,\r\n  68,\r\n  59\r\n]", 1, 0, "Hitmonlee's legs freely contract and stretch. Using these springlike legs, it bowls over foes with devastating kicks. After battle, it rubs down its legs and loosens the muscles to overcome fatigue.  Hitmonlee's legs freely contract and stretch. Using these springlike legs, it bowls over foes with devastating kicks. After battle, it rubs down its legs and loosens the muscles to overcome fatigue.", 0, false, 0, 50, 0, "/Resources/Images/106.png", 1, "Hitmonlee", 100, "[\r\n  6\r\n]", 0 },
                    { 107, 1, false, "[\r\n  102,\r\n  117,\r\n  14,\r\n  98,\r\n  60,\r\n  59\r\n]", 1, 0, "Hitmonchan is said to possess the spirit of a boxer who had been working toward a world championship. This Pokémon has an indomitable spirit and will never give up in the face of adversity.  Hitmonchan is said to possess the spirit of a boxer who had been working toward a world championship. This Pokémon has an indomitable spirit and will never give up in the face of adversity.", 0, false, 0, 50, 0, "/Resources/Images/107.png", 1, "Hitmonchan", 100, "[\r\n  6\r\n]", 0 },
                    { 108, 1, false, "[\r\n  110,\r\n  73,\r\n  45,\r\n  119,\r\n  5\r\n]", 1, 0, "Whenever Lickitung comes across something new, it will unfailingly give it a lick. It does so because it memorizes things by texture and by taste. It is somewhat put off by sour things.  Whenever Lickitung comes across something new, it will unfailingly give it a lick. It does so because it memorizes things by texture and by taste. It is somewhat put off by sour things.", 0, false, 0, 90, 0, "/Resources/Images/108.png", 1, "Lickitung", 100, "[\r\n  0\r\n]", 0 },
                    { 109, 1, false, "[\r\n  49,\r\n  2,\r\n  113,\r\n  3,\r\n  52\r\n]", 1, 0, "Koffing embodies toxic substances. It mixes the toxins with raw garbage to set off a chemical reaction that results in a terribly powerful Poison gas. The higher the temperature, the more gas is concocted by this Pokémon.  If Koffing becomes agitated, it raises the toxicity of its internal gases and jets them out from all over its body. This Pokémon may also overinflate its round body, then explode.", 0, false, 43, 40, 0, "/Resources/Images/109.png", 1, "Koffing", 100, "[\r\n  7\r\n]", 0 },
                    { 110, 1, false, "[\r\n  49,\r\n  2,\r\n  3,\r\n  100,\r\n  52\r\n]", 1, 0, "Weezing alternately shrinks and inflates its twin bodies to mix together toxic gases inside. The more the gases are mixed, the more powerful the toxins become. The Pokémon also becomes more putrid.  Weezing loves the gases given off by rotted kitchen garbage. This Pokémon will find a dirty, unkempt house and make it its home. At night, when the people in the house are asleep, it will go through the trash.", 0, false, 0, 65, 0, "/Resources/Images/110.png", 1, "Weezing", 100, "[\r\n  7\r\n]", 0 },
                    { 111, 1, false, "[\r\n  83,\r\n  117,\r\n  66,\r\n  69,\r\n  119\r\n]", 1, 0, "Rhyhorn's brain is very small. It is so dense, while on a run it forgets why it started running in the first place. It apparently remembers sometimes if it demolishes something.  Rhyhorn runs in a straight line, smashing everything in its path. It is not bothered even if it rushes headlong into a block of Steel. This Pokémon may feel some pain from the collision the next day, however.", 0, false, 44, 80, 0, "/Resources/Images/111.png", 1, "Rhyhorn", 100, "[\r\n  8,\r\n  13\r\n]", 0 },
                    { 96, 1, false, "[\r\n  72,\r\n  29,\r\n  82,\r\n  99,\r\n  31\r\n]", 1, 0, "If your nose becomes itchy while you are sleeping, it's a sure sign that one of these Pokémon is standing above your pillow and trying to eat your dream through your nostrils.  If your nose becomes itchy while you are sleeping, it's a sure sign that one of these Pokémon is standing above your pillow and trying to eat your dream through your nostrils.", 0, false, 39, 60, 0, "/Resources/Images/96.png", 1, "Drowzee", 100, "[\r\n  11\r\n]", 0 },
                    { 95, 1, false, "[\r\n  104,\r\n  2,\r\n  62,\r\n  68,\r\n  115\r\n]", 1, 0, "Onix has a magnet in its brain. It acts as a compass so that this Pokémon does not lose direction while it is tunneling. As it grows older, its body becomes increasingly rounder and smoother.  Onix has a magnet in its brain. It acts as a compass so that this Pokémon does not lose direction while it is tunneling. As it grows older, its body becomes increasingly rounder and smoother.", 0, false, 0, 35, 0, "/Resources/Images/95.png", 1, "Onix", 100, "[\r\n  8,\r\n  13\r\n]", 0 },
                    { 94, 1, false, "[\r\n  85,\r\n  114,\r\n  100,\r\n  52,\r\n  53,\r\n  3\r\n]", 1, 0, "Sometimes, on a Dark night, your shadow thrown by a streetlight will suddenly and startlingly overtake you. It is actually a Gengar running past you, pretending to be your shadow.  Sometimes, on a Dark night, your shadow thrown by a streetlight will suddenly and startlingly overtake you. It is actually a Gengar running past you, pretending to be your shadow.", 0, false, 0, 60, 0, "/Resources/Images/94.png", 1, "Gengar", 100, "[\r\n  7,\r\n  15\r\n]", 0 },
                    { 93, 1, false, "[\r\n  114,\r\n  110,\r\n  100,\r\n  52,\r\n  3\r\n]", 1, 0, "Haunter is a dangerous Pokémon. If one beckons you while floating in Darkness, you must never approach it. This Pokémon will try to lick you with its tongue and steal your life away.  Haunter is a dangerous Pokémon. If one beckons you while floating in Darkness, you must never approach it. This Pokémon will try to lick you with its tongue and steal your life away.", 0, false, 0, 45, 0, "/Resources/Images/93.png", 1, "Haunter", 100, "[\r\n  7,\r\n  15\r\n]", 0 },
                    { 78, 1, false, "[\r\n  91,\r\n  9,\r\n  16,\r\n  48,\r\n  78\r\n]", 1, 0, "Rapidash usually can be seen casually cantering in the fields and plains. However, when this Pokémon turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph.  Rapidash usually can be seen casually cantering in the fields and plains. However, when this Pokémon turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph.", 0, false, 0, 65, 0, "/Resources/Images/78.png", 1, "Rapidash", 100, "[\r\n  1\r\n]", 0 },
                    { 79, 1, false, "[\r\n  22,\r\n  29,\r\n  21,\r\n  99,\r\n  31\r\n]", 1, 0, "Slowpoke uses its tail to catch prey by dipping it in Water at the side of a river. However, this Pokémon often forgets what it's doing and often spends entire days just loafing at Water's edge.  Slowpoke uses its tail to catch prey by dipping it in Water at the side of a river. However, this Pokémon often forgets what it's doing and often spends entire days just loafing at Water's edge.", 0, false, 0, 90, 0, "/Resources/Images/79.png", 1, "Slowpoke", 100, "[\r\n  2,\r\n  11\r\n]", 0 },
                    { 80, 1, false, "[\r\n  22,\r\n  29,\r\n  21,\r\n  31,\r\n  24\r\n]", 1, 0, "Slowbro's tail has a Shellder firmly attached with a bite. As a result, the tail can't be used for fishing anymore. This causes Slowbro to grudgingly swim and catch prey instead.  Slowbro's tail has a Shellder firmly attached with a bite. As a result, the tail can't be used for fishing anymore. This causes Slowbro to grudgingly swim and catch prey instead.", 0, false, 0, 95, 0, "/Resources/Images/80.png", 1, "Slowbro", 100, "[\r\n  2,\r\n  11\r\n]", 0 },
                    { 81, 1, false, "[\r\n  58,\r\n  54,\r\n  55,\r\n  106,\r\n  56\r\n]", 1, 0, "Magnemite floats in the air by emitting electromagnetic waves from the units at its sides. These waves block gravity. This Pokémon becomes incapable of flight if its internal Electrical supply is depleted.  Magnemite attaches itself to power lines to feed on Electricity. If your house has a power outage, check your circuit breakers. You may find a large number of this Pokémon clinging to the breaker box.", 0, false, 34, 25, 0, "/Resources/Images/81.png", 1, "Magnemite", 100, "[\r\n  9,\r\n  3\r\n]", 0 },
                    { 82, 1, false, "[\r\n  58,\r\n  54,\r\n  55,\r\n  106,\r\n  26\r\n]", 1, 0, "Magneton emits a powerful magnetic force that is fatal to electronics and precision instruments. Because of this, it is said that some towns warn people to keep this Pokémon inside a Poké Ball.  Magneton emits a powerful magnetic force that is fatal to mechanical devIces. As a result, large cities sound sirens to warn citizens of large-scale outbreaks of this Pokémon.", 0, false, 0, 50, 0, "/Resources/Images/82.png", 1, "Magneton", 100, "[\r\n  9,\r\n  3\r\n]", 0 },
                    { 83, 1, false, "[\r\n  107,\r\n  70,\r\n  35,\r\n  39,\r\n  103\r\n]", 1, 0, "Farfetch'd is always seen with a stalk from a plant of some sort. Apparently, there are good stalks and bad stalks. This Pokémon has been known to fight with others over stalks.  Farfetch'd is always seen with a stalk from a plant of some sort. Apparently, there are good stalks and bad stalks. This Pokémon has been known to fight with others over stalks.", 0, false, 0, 52, 0, "/Resources/Images/83.png", 1, "Farfetchd", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 84, 1, false, "[\r\n  46,\r\n  37,\r\n  47,\r\n  35,\r\n  108\r\n]", 1, 0, "Doduo's two heads contain completely identical brains. A scientific study reported that on rare occasions, there will be examples of this Pokémon possessing different sets of brains.  Doduo's two heads never sleep at the same time. Its two heads take turns sleeping, so one head can always keep watch for enemies while the other one sleeps.", 0, false, 35, 35, 0, "/Resources/Images/84.png", 1, "Doduo", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 85, 1, false, "[\r\n  77,\r\n  40,\r\n  47,\r\n  35,\r\n  39\r\n]", 1, 0, "Apparently, the heads aren't the only parts of the body that Dodrio has three of. It has three sets of hearts and lungs as well, so it is capable of running long distances without rest.  Watch out if Dodrio's three heads are looking in three separate directions. It's a sure sign that it is on its guard. Don't go near this Pokémon if it's being wary—it may decide to peck you.", 0, false, 0, 60, 0, "/Resources/Images/85.png", 1, "Dodrio", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 86, 1, false, "[\r\n  109,\r\n  22,\r\n  110,\r\n  19,\r\n  111,\r\n  20\r\n]", 1, 0, "Seel hunts for prey in the frigid sea underneath sheets of Ice. When it needs to breathe, it punches a hole through the Ice with the sharply protruding section of its head.  Seel hunts for prey in the frigid sea underneath sheets of Ice. When it needs to breathe, it punches a hole through the Ice with the sharply protruding section of its head.", 0, false, 36, 65, 0, "/Resources/Images/86.png", 1, "Seel", 100, "[\r\n  2\r\n]", 0 },
                    { 87, 1, false, "[\r\n  112,\r\n  109,\r\n  111,\r\n  19,\r\n  125\r\n]", 1, 0, "Dewgong loves to snooze on bitterly cold Ice. The sight of this Pokémon sleeping on a glacier was mistakenly thought to be a mermaid by a mariner long ago.  Dewgong loves to snooze on bitterly cold Ice. The sight of this Pokémon sleeping on a glacier was mistakenly thought to be a mermaid by a mariner long ago.", 0, false, 0, 90, 0, "/Resources/Images/87.png", 1, "Dewgong", 100, "[\r\n  2,\r\n  5\r\n]", 0 },
                    { 88, 1, false, "[\r\n  49,\r\n  83,\r\n  34,\r\n  113,\r\n  84,\r\n  3\r\n]", 1, 0, "Grimer emerged from the sludge that settled on a polluted seabed. This Pokémon loves anything filthy. It constantly leaks a horribly germ-infested fluid from all over its body.  Grimer's sludgy and rubbery body can be forced through any opening, however small it may be. This Pokémon enters sewer pipes to drink filthy wasteWater.", 0, false, 37, 80, 0, "/Resources/Images/88.png", 1, "Grimer", 100, "[\r\n  7\r\n]", 0 },
                    { 89, 1, false, "[\r\n  49,\r\n  34,\r\n  110,\r\n  52,\r\n  51,\r\n  53\r\n]", 1, 0, "This Pokémon's favorite food is anything that is repugnantly filthy. In dirty towns where people think nothing of throwing away litter on the streets, Muk are certain to gather.  From Muk's body seeps a foul fluid that gives off a nose-bendingly horrible stench. Just one drop of this Pokémon's body fluid can turn a pool stagnant and rancid.", 0, false, 0, 105, 0, "/Resources/Images/89.png", 1, "Muk", 100, "[\r\n  7\r\n]", 0 },
                    { 90, 1, false, "[\r\n  109,\r\n  2,\r\n  95,\r\n  21,\r\n  111\r\n]", 1, 0, "At night, this Pokémon uses its broad tongue to burrow a hole in the seafloor sand and then sleep in it. While it is sleeping, Shellder closes its shell, but leaves its tongue hanging out.  At night, this Pokémon uses its broad tongue to burrow a hole in the seafloor sand and then sleep in it. While it is sleeping, Shellder closes its shell, but leaves its tongue hanging out.", 0, false, 0, 30, 0, "/Resources/Images/90.png", 1, "Shellder", 100, "[\r\n  2\r\n]", 0 },
                    { 91, 1, false, "[\r\n  112,\r\n  109,\r\n  111,\r\n  25,\r\n  125\r\n]", 1, 0, "Cloyster is capable of swimming in the sea. It does so by swallowing Water, then jetting it out toward the rear. This Pokémon shoots spikes from its shell using the same system.  Cloyster is capable of swimming in the sea. It does so by swallowing Water, then jetting it out toward the rear. This Pokémon shoots spikes from its shell using the same system.", 0, false, 0, 50, 0, "/Resources/Images/91.png", 1, "Cloyster", 100, "[\r\n  2,\r\n  5\r\n]", 0 },
                    { 92, 1, false, "[\r\n  110,\r\n  85,\r\n  80,\r\n  52,\r\n  3\r\n]", 1, 0, "Gastly is largely composed of gaseous matter. When exposed to a strong wind, the gaseous body quickly dwindles away. Groups of this Pokémon cluster under the eaves of houses to escape the ravages of wind.  Gastly is largely composed of gaseous matter. When exposed to a strong wind, the gaseous body quickly dwindles away. Groups of this Pokémon cluster under the eaves of houses to escape the ravages of wind.", 0, false, 38, 30, 0, "/Resources/Images/92.png", 1, "Gastly", 100, "[\r\n  7,\r\n  15\r\n]", 0 },
                    { 112, 1, false, "[\r\n  83,\r\n  117,\r\n  71,\r\n  65,\r\n  68\r\n]", 1, 0, "Rhydon has a horn that serves as a drill. It is used for destroying Rocks and boulders. This Pokémon occasionally rams into streams of magma, but the armor-like hide prevents it from feeling the heat.  Rhydon's horn can crush even uncut diamonds. One sweeping blow of its tail can topple a building. This Pokémon's hide is extremely tough. Even direct cannon hits don't leave a scratch.", 0, false, 0, 105, 0, "/Resources/Images/112.png", 1, "Rhydon", 100, "[\r\n  8,\r\n  13\r\n]", 0 },
                    { 113, 1, false, "[\r\n  72,\r\n  73,\r\n  31,\r\n  82,\r\n  76,\r\n  45\r\n]", 1, 0, "Chansey lays nutritionally excellent eggs on an everyday basis. The eggs are so delicious, they are easily and eagerly devoured by even those people who have lost their appetite.  Chansey lays nutritionally excellent eggs on an everyday basis. The eggs are so delicious, they are easily and eagerly devoured by even those people who have lost their appetite.", 0, false, 0, 250, 0, "/Resources/Images/113.png", 1, "Chansey", 100, "[\r\n  0\r\n]", 0 },
                    { 114, 1, false, "[\r\n  1,\r\n  5,\r\n  3,\r\n  7\r\n]", 1, 0, "Tangela's vines snap off easily if they are grabbed. This happens without pain, allowing it to make a quick getaway. The lost vines are replaced by newly grown vines the very next day.  Tangela's vines snap off easily if they are grabbed. This happens without pain, allowing it to make a quick getaway. The lost vines are replaced by newly grown vines the very next day.", 0, false, 0, 65, 0, "/Resources/Images/114.png", 1, "Tangela", 100, "[\r\n  4\r\n]", 0 },
                    { 115, 1, false, "[\r\n  83,\r\n  91,\r\n  59,\r\n  65,\r\n  119\r\n]", 1, 0, "If you come across a young Kangaskhan playing by itself, you must never disturb it or attempt to catch it. The baby Pokémon's parent is sure to be in the area, and it will become violently enraged at you.  If you come across a young Kangaskhan playing by itself, you must never disturb it or attempt to catch it. The baby Pokémon's parent is sure to be in the area, and it will become violently enraged at you.", 0, false, 0, 105, 0, "/Resources/Images/115.png", 1, "Kangaskhan", 100, "[\r\n  0\r\n]", 0 },
                    { 136, 1, false, "[\r\n  9,\r\n  16,\r\n  13,\r\n  78\r\n]", 1, 0, "Flareon's fluffy fur has a functional purpose—it releases heat into the air so that its body does not get excessively hot. This Pokémon's body temperature can rise to a maximum of 1,650 degrees Fahrenheit.  Flareon's fluffy fur has a functional purpose—it releases heat into the air so that its body does not get excessively hot. This Pokémon's body temperature can rise to a maximum of 1,650 degrees Fahrenheit.", 0, false, 0, 65, 0, "/Resources/Images/136.png", 1, "Flareon", 100, "[\r\n  1\r\n]", 0 },
                    { 137, 1, false, "[\r\n  37,\r\n  2,\r\n  73,\r\n  82,\r\n  32,\r\n  55\r\n]", 1, 0, "Porygon is capable of reverting itself entirely back to program data and entering cyberspace. This Pokémon is copy protected so it cannot be duplicated by copying.  Porygon is capable of reverting itself entirely back to program data and entering cyberspace. This Pokémon is copy protected so it cannot be duplicated by copying.", 0, false, 0, 65, 0, "/Resources/Images/137.png", 1, "Porygon", 100, "[\r\n  0\r\n]", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ATK", "Achete", "AttacksIdsSerialises", "DEF", "DepotId", "Description", "Emplacement", "Equipe", "EvolutionId", "Health", "HpGaugeId", "Image", "Level", "Name", "Price", "TypesSerialises", "XpGaugeId" },
                values: new object[,]
                {
                    { 138, 1, false, "[\r\n  22,\r\n  61,\r\n  105,\r\n  124,\r\n  63\r\n]", 1, 0, "Omanyte is one of the ancient and long-since-extinct Pokémon that have been regenerated from fossils by people. If attacked by an enemy, it withdraws itself inside its hard shell.  Omanyte is one of the ancient and long-since-extinct Pokémon that have been regenerated from fossils by people. If attacked by an enemy, it withdraws itself inside its hard shell.", 0, false, 48, 35, 0, "/Resources/Images/138.png", 1, "Omanyte", 100, "[\r\n  13,\r\n  2\r\n]", 0 },
                    { 139, 1, false, "[\r\n  104,\r\n  22,\r\n  61,\r\n  105,\r\n  25,\r\n  62\r\n]", 1, 0, "Omastar uses its tentacles to capture its prey. It is believed to have become extinct because its shell grew too large and heavy, causing its movements to become too slow and ponderous.  Omastar uses its tentacles to capture its prey. It is believed to have become extinct because its shell grew too large and heavy, causing its movements to become too slow and ponderous.", 0, false, 0, 70, 0, "/Resources/Images/139.png", 1, "Omastar", 100, "[\r\n  13,\r\n  2\r\n]", 0 },
                    { 140, 1, false, "[\r\n  10,\r\n  61,\r\n  105,\r\n  19,\r\n  63\r\n]", 1, 0, "Kabuto is a Pokémon that has been regenerated from a fossil. However, in extremely rare cases, living examples have been discovered. The Pokémon has not changed at all for 300 million years.  Kabuto is a Pokémon that has been regenerated from a fossil. However, in extremely rare cases, living examples have been discovered. The Pokémon has not changed at all for 300 million years.", 0, false, 49, 30, 0, "/Resources/Images/140.png", 1, "Kabuto", 100, "[\r\n  13,\r\n  2\r\n]", 0 },
                    { 141, 1, false, "[\r\n  61,\r\n  70,\r\n  105,\r\n  21,\r\n  68\r\n]", 1, 0, "Kabutops swam underWater to hunt for its prey in ancient times. The Pokémon was apparently evolving from being a Water dweller to living on land as evident from the beginnings of change in its gills and legs.  Kabutops swam underWater to hunt for its prey in ancient times. The Pokémon was apparently evolving from being a Water dweller to living on land as evident from the beginnings of change in its gills and legs.", 0, false, 0, 60, 0, "/Resources/Images/141.png", 1, "Kabutops", 100, "[\r\n  13,\r\n  2\r\n]", 0 },
                    { 142, 1, false, "[\r\n  40,\r\n  23,\r\n  105,\r\n  115,\r\n  45\r\n]", 1, 0, "Aerodactyl is a Pokémon from the age of dinosaurs. It was regenerated from genetic material extracted from amber. It is imagined to have been the king of the skies in ancient times.  Aerodactyl is a Pokémon from the age of dinosaurs. It was regenerated from genetic material extracted from amber. It is imagined to have been the king of the skies in ancient times.", 0, false, 0, 80, 0, "/Resources/Images/142.png", 1, "Aerodactyl", 100, "[\r\n  10,\r\n  13\r\n]", 0 },
                    { 143, 1, false, "[\r\n  73,\r\n  110,\r\n  44,\r\n  45,\r\n  65\r\n]", 1, 0, "Snorlax's typical day consists of nothing more than eating and sleeping. It is such a docile Pokémon that there are children who use its expansive belly as a place to play.  Snorlax's typical day consists of nothing more than eating and sleeping. It is such a docile Pokémon that there are children who use its expansive belly as a place to play.", 0, false, 0, 160, 0, "/Resources/Images/143.png", 1, "Snorlax", 100, "[\r\n  0\r\n]", 0 },
                    { 144, 1, false, "[\r\n  112,\r\n  24,\r\n  111,\r\n  125\r\n]", 1, 0, "Articuno is a legendary bird Pokémon that can control Ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall.  Articuno is a legendary bird Pokémon that can control Ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall.", 0, false, 0, 90, 0, "/Resources/Images/144.png", 1, "Articuno", 100, "[\r\n  10,\r\n  5\r\n]", 0 },
                    { 145, 1, false, "[\r\n  54,\r\n  55,\r\n  56,\r\n  57\r\n]", 1, 0, "Zapdos is a legendary bird Pokémon that has the ability to control Electricity. It usually lives in thunderclouds. The Pokémon gains power if it is stricken by lightning bolts.  Zapdos is a legendary bird Pokémon that has the ability to control Electricity. It usually lives in thunderclouds. The Pokémon gains power if it is stricken by lightning bolts.", 0, false, 0, 90, 0, "/Resources/Images/145.png", 1, "Zapdos", 100, "[\r\n  10,\r\n  3\r\n]", 0 },
                    { 146, 1, false, "[\r\n  9,\r\n  16,\r\n  78,\r\n  13\r\n]", 1, 0, "Moltres is a legendary bird Pokémon that has the ability to control Fire. If this Pokémon is injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself.  Moltres is a legendary bird Pokémon that has the ability to control Fire. If this Pokémon is injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself.", 0, false, 0, 90, 0, "/Resources/Images/146.png", 1, "Moltres", 100, "[\r\n  10,\r\n  1\r\n]", 0 },
                    { 147, 1, false, "[\r\n  121,\r\n  50,\r\n  38,\r\n  20\r\n]", 1, 0, "Dratini continually molts and sloughs off its old skin. It does so because the life energy within its body steadily builds to reach uncontrollable levels.  Dratini continually molts and sloughs off its old skin. It does so because the life energy within its body steadily builds to reach uncontrollable levels.", 0, false, 50, 41, 0, "/Resources/Images/147.png", 1, "Dratini", 100, "[\r\n  16\r\n]", 0 },
                    { 148, 1, false, "[\r\n  121,\r\n  50,\r\n  20,\r\n  120\r\n]", 1, 0, "Dragonair stores an enormous amount of energy inside its body. It is said to alter weather conditions in its vicinity by discharging energy from the crystals on its neck and tail.  Dragonair stores an enormous amount of energy inside its body. It is said to alter weather conditions in its vicinity by discharging energy from the crystals on its neck and tail.", 0, false, 51, 61, 0, "/Resources/Images/148.png", 1, "Dragonair", 100, "[\r\n  16\r\n]", 0 },
                    { 149, 1, false, "[\r\n  121,\r\n  40,\r\n  120,\r\n  45,\r\n  17\r\n]", 1, 0, "Dragonite is capable of circling the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.  Dragonite is capable of circling the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.", 0, false, 0, 91, 0, "/Resources/Images/149.png", 1, "Dragonite", 100, "[\r\n  10,\r\n  16\r\n]", 0 },
                    { 150, 1, false, "[\r\n  101,\r\n  29,\r\n  31,\r\n  100,\r\n  45\r\n]", 1, 0, "Mewtwo is a Pokémon that was created by genetic manipulation. However, even though the scientific power of humans created this Pokémon's body, they failed to endow Mewtwo with a compassionate heart.  Mewtwo is a Pokémon that was created by genetic manipulation. However, even though the scientific power of humans created this Pokémon's body, they failed to endow Mewtwo with a compassionate heart.", 0, false, 0, 106, 0, "/Resources/Images/150.png", 1, "Mewtwo", 100, "[\r\n  11\r\n]", 0 },
                    { 135, 1, false, "[\r\n  54,\r\n  55,\r\n  56,\r\n  57\r\n]", 1, 0, "Jolteon's cells generate a low level of Electricity. This power is amplified by the static Electricity of its fur, enabling the Pokémon to drop thunderbolts. The bristling fur is made of Electrically charged needles.  Jolteon's cells generate a low level of Electricity. This power is amplified by the static Electricity of its fur, enabling the Pokémon to drop thunderbolts. The bristling fur is made of Electrically charged needles.", 0, false, 0, 65, 0, "/Resources/Images/135.png", 1, "Jolteon", 100, "[\r\n  3\r\n]", 0 },
                    { 134, 1, false, "[\r\n  22,\r\n  21,\r\n  25,\r\n  20\r\n]", 1, 0, "Vaporeon underwent a spontaneous mutation and grew fins and gills that allow it to live underWater. This Pokémon has the ability to freely control Water.  Vaporeon underwent a spontaneous mutation and grew fins and gills that allow it to live underWater. This Pokémon has the ability to freely control Water.", 0, false, 0, 130, 0, "/Resources/Images/134.png", 1, "Vaporeon", 100, "[\r\n  2\r\n]", 0 },
                    { 133, 1, false, "[\r\n  37,\r\n  2,\r\n  42,\r\n  108,\r\n  44\r\n]", 1, 0, "Eevee has an unstable genetic makeup that suddenly mutates due to the environment in which it lives. Radiation from various stones causes this Pokémon to evolve.  Eevee has an unstable genetic makeup that suddenly mutates due to the environment in which it lives. Radiation from various stones causes this Pokémon to evolve.", 0, false, 0, 55, 0, "/Resources/Images/133.png", 1, "Eevee", 100, "[\r\n  0\r\n]", 0 },
                    { 132, 1, false, "[\r\n  72,\r\n  28\r\n]", 1, 0, "Ditto rearranges its cell structure to transform itself into other shapes. However, if it tries to transform itself into something by relying on its memory, this Pokémon manages to get details wrong.  Ditto rearranges its cell structure to transform itself into other shapes. However, if it tries to transform itself into something by relying on its memory, this Pokémon manages to get details wrong.", 0, false, 0, 48, 0, "/Resources/Images/132.png", 1, "Ditto", 100, "[\r\n  0\r\n]", 0 },
                    { 116, 1, false, "[\r\n  22,\r\n  18,\r\n  95,\r\n  120,\r\n  26\r\n]", 1, 0, "If Horsea senses danger, it will reflexively spray a dense black ink from its mouth and try to escape. This Pokémon swims by cleverly flapping the fin on its back.  Horsea eats small insects and moss off of Rocks. If the ocean current turns fast, this Pokémon anchors itself by wrapping its tail around Rocks or coral to prevent being washed away.", 0, false, 45, 30, 0, "/Resources/Images/116.png", 1, "Horsea", 100, "[\r\n  2\r\n]", 0 },
                    { 117, 1, false, "[\r\n  22,\r\n  121,\r\n  125,\r\n  120,\r\n  25\r\n]", 1, 0, "Seadra generates whirlpools by spinning its body. The whirlpools are strong enough to swallow even fishing boats. This Pokémon weakens prey with these currents, then swallows it whole.  Seadra sleeps after wriggling itself between the branches of coral. Those trying to harvest coral are occasionally stung by this Pokémon's Poison barbs if they fail to notIce it.", 0, false, 0, 55, 0, "/Resources/Images/117.png", 1, "Seadra", 100, "[\r\n  2\r\n]", 0 },
                    { 118, 1, false, "[\r\n  46,\r\n  61,\r\n  21,\r\n  69,\r\n  20\r\n]", 1, 0, "Goldeen loves swimming wild and free in rivers and ponds. If one of these Pokémon is placed in an aquarium, it will shatter even the thickest glass with one ram of its horn and make its escape.  Goldeen is a very beautiful Pokémon with fins that billow elegantly in Water. However, don't let your guard down around this Pokémon—it could ram you powerfully with its horn.", 0, false, 46, 45, 0, "/Resources/Images/118.png", 1, "Goldeen", 100, "[\r\n  2\r\n]", 0 },
                    { 119, 1, false, "[\r\n  46,\r\n  34,\r\n  111,\r\n  48,\r\n  71\r\n]", 1, 0, "Seaking is very protective of its eggs. The male and female will take turns patrolling around their nest and eggs. The guarding of eggs by these Pokémon goes on for over a month.  In the autumn, Seaking males can be seen performing courtship dances in riverbeds to woo females. During this season, this Pokémon's body coloration is at its most beautiful.", 0, false, 0, 80, 0, "/Resources/Images/119.png", 1, "Seaking", 100, "[\r\n  2\r\n]", 0 },
                    { 120, 1, false, "[\r\n  37,\r\n  22,\r\n  2,\r\n  108,\r\n  95,\r\n  87\r\n]", 1, 0, "Staryu apparently communicates with the stars in the night sky by flashing the red core at the center of its body. If parts of its body are torn, this Pokémon simply regenerates the missing pieces and limbs.  Staryu's center section has an organ called the core that shines bright red. If you go to a beach toward the end of summer, the glowing cores of these Pokémon look like the stars in the sky.", 0, false, 0, 30, 0, "/Resources/Images/120.png", 1, "Staryu", 100, "[\r\n  2\r\n]", 0 },
                    { 121, 1, false, "[\r\n  37,\r\n  22,\r\n  2,\r\n  25,\r\n  87,\r\n  82,\r\n  31\r\n]", 1, 0, "Starmie swims through Water by spinning its star-shaped body as if it were a propeller on a ship. The core at the center of this Pokémon's body glows in seven colors.  Starmie's center section—the core—glows brightly in seven colors. Because of its luminous nature, this Pokémon has been given the nickname “the gem of the sea.\"", 0, false, 0, 60, 0, "/Resources/Images/121.png", 1, "Starmie", 100, "[\r\n  2,\r\n  11\r\n]", 0 },
                    { 122, 1, false, "[\r\n  29,\r\n  73,\r\n  82,\r\n  31,\r\n  100\r\n]", 1, 0, "Mr. Mime is a master of pantomime. Its gestures and motions convince watchers that something unseeable actually exists. Once the watchers are convinced, the unseeable thing exists as if it were real.  Mr. Mime is a master of pantomime. Its gestures and motions convince watchers that something unseeable actually exists. Once the watchers are convinced, the unseeable thing exists as if it were real.", 0, false, 0, 40, 0, "/Resources/Images/122.png", 1, "Mr-mime", 100, "[\r\n  17,\r\n  11\r\n]", 0 },
                    { 77, 1, false, "[\r\n  2,\r\n  9,\r\n  11,\r\n  92,\r\n  16\r\n]", 1, 0, "Ponyta is very weak at birth. It can barely stand up. This Pokémon becomes stronger by stumbling and falling to keep up with its parent.  Ponyta is very weak at birth. It can barely stand up. This Pokémon becomes stronger by stumbling and falling to keep up with its parent.", 0, false, 33, 50, 0, "/Resources/Images/77.png", 1, "Ponyta", 100, "[\r\n  1\r\n]", 0 },
                    { 123, 1, false, "[\r\n  70,\r\n  40,\r\n  86,\r\n  36,\r\n  30\r\n]", 1, 0, "Scyther is blindingly fast. Its blazing speed enhances the effectiveness of the twin scythes on its forearms. This Pokémon's scythes are so effective, they can slIce through thick logs in one wicked stroke.  Scyther is blindingly fast. Its blazing speed enhances the effectiveness of the twin scythes on its forearms. This Pokémon's scythes are so effective, they can slIce through thick logs in one wicked stroke.", 0, false, 0, 70, 0, "/Resources/Images/123.png", 1, "Scyther", 100, "[\r\n  10,\r\n  12\r\n]", 0 },
                    { 125, 1, false, "[\r\n  54,\r\n  91,\r\n  60,\r\n  56,\r\n  57\r\n]", 1, 0, "When a storm arrives, gangs of this Pokémon compete with each other to scale heights that are likely to be stricken by lightning bolts. Some towns use Electabuzz in place of lightning rods.  When a storm arrives, gangs of this Pokémon compete with each other to scale heights that are likely to be stricken by lightning bolts. Some towns use Electabuzz in place of lightning rods.", 0, false, 0, 65, 0, "/Resources/Images/125.png", 1, "Electabuzz", 100, "[\r\n  3\r\n]", 0 },
                    { 126, 1, false, "[\r\n  9,\r\n  89,\r\n  16,\r\n  14,\r\n  13\r\n]", 1, 0, "In battle, Magmar blows out intensely hot flames from all over its body to intimidate its opponent. This Pokémon's fiery bursts create heat waves that ignite Grass and trees in its surroundings.  In battle, Magmar blows out intensely hot flames from all over its body to intimidate its opponent. This Pokémon's fiery bursts create heat waves that ignite Grass and trees in its surroundings.", 0, false, 0, 65, 0, "/Resources/Images/126.png", 1, "Magmar", 100, "[\r\n  1\r\n]", 0 },
                    { 127, 1, false, "[\r\n  117,\r\n  70,\r\n  116,\r\n  36,\r\n  97\r\n]", 1, 0, "Pinsir has a pair of massive horns. Protruding from the surface of these horns are thorns. These thorns are driven deeply into the foe's body when the pincer closes, making it tough for the foe to escape.  Pinsir is astoundingly strong. It can grip a foe weighing twIce its weight in its horns and easily lift it. This Pokémon's movements turn sluggish in cold places.", 0, false, 0, 65, 0, "/Resources/Images/127.png", 1, "Pinsir", 100, "[\r\n  12\r\n]", 0 },
                    { 128, 1, false, "[\r\n  2,\r\n  73,\r\n  69,\r\n  115,\r\n  65\r\n]", 1, 0, "This Pokémon is not satisfied unless it is rampaging at all times. If there is no opponent for Tauros to battle, it will charge at thick trees and knock them down to calm itself.  This Pokémon is not satisfied unless it is rampaging at all times. If there is no opponent for Tauros to battle, it will charge at thick trees and knock them down to calm itself.", 0, false, 0, 75, 0, "/Resources/Images/128.png", 1, "Tauros", 100, "[\r\n  0\r\n]", 0 },
                    { 129, 1, false, "[\r\n  123,\r\n  28\r\n]", 1, 0, "Magikarp is virtually useless in battle as it can only splash around. As a result, it is considered to be weak. However, it is actually a very hardy Pokémon that can survive in any body of Water no matter how polluted it is.  Magikarp is a pathetic excuse for a Pokémon that is only capable of flopping and splashing. This behavior prompted scientists to undertake research into it.", 0, false, 47, 20, 0, "/Resources/Images/129.png", 1, "Magikarp", 100, "[\r\n  2\r\n]", 0 },
                    { 130, 1, false, "[\r\n  121,\r\n  23,\r\n  25,\r\n  38,\r\n  120\r\n]", 1, 0, "Once Gyarados goes on a rampage, its ferociously violent blood doesn't calm until it has burned everything down. There are records of this Pokémon's rampages lasting a whole month.  When Magikarp evolves into Gyarados, its brain cells undergo a structural transformation. It is said that this transformation is to blame for this Pokémon's wildly violent nature.", 0, false, 0, 95, 0, "/Resources/Images/130.png", 1, "Gyarados", 100, "[\r\n  10,\r\n  2\r\n]", 0 },
                    { 131, 1, false, "[\r\n  112,\r\n  109,\r\n  120,\r\n  24,\r\n  125\r\n]", 1, 0, "People have driven Lapras almost to the point of extinction. In the evenings, this Pokémon is said to sing plaintively as it seeks what few others of its kind still remain.  People have driven Lapras almost to the point of extinction. In the evenings, this Pokémon is said to sing plaintively as it seeks what few others of its kind still remain.", 0, false, 0, 130, 0, "/Resources/Images/131.png", 1, "Lapras", 100, "[\r\n  2,\r\n  5\r\n]", 0 },
                    { 124, 1, false, "[\r\n  112,\r\n  72,\r\n  122,\r\n  98,\r\n  99\r\n]", 1, 0, "Jynx walks rhythmically, swaying and shaking its hips as if it were dancing. Its motions are so bouncingly alluring, people seeing it are compelled to shake their hips without giving any thought to what they are doing.  Jynx walks rhythmically, swaying and shaking its hips as if it were dancing. Its motions are so bouncingly alluring, people seeing it are compelled to shake their hips without giving any thought to what they are doing.", 0, false, 0, 65, 0, "/Resources/Images/124.png", 1, "Jynx", 100, "[\r\n  5,\r\n  11\r\n]", 0 },
                    { 76, 1, false, "[\r\n  104,\r\n  61,\r\n  83,\r\n  68,\r\n  105,\r\n  65\r\n]", 1, 0, "Golem is known for rolling down from mountains. To prevent them from rolling into the homes of people downhill, grooves have been dug into the sides of mountains to serve as guideways for diverting this Pokémon's course.  Golem live up on mountains. If there is a large earthquake, these Pokémon will come rolling down off the mountains en masse to the foothills below.", 0, false, 0, 80, 0, "/Resources/Images/76.png", 1, "Golem", 100, "[\r\n  8,\r\n  13\r\n]", 0 },
                    { 75, 1, false, "[\r\n  104,\r\n  61,\r\n  83,\r\n  42,\r\n  68,\r\n  62\r\n]", 1, 0, "Rocks are Graveler's favorite food. This Pokémon will climb a mountain from the base to the summit, crunchingly feasting on Rocks all the while. Upon reaching the peak, it rolls back down to the bottom.  Graveler grows by feeding on Rocks. Apparently, it prefers to eat Rocks that are covered in moss. This Pokémon eats its way through a ton of Rocks on a daily basis.", 0, false, 0, 55, 0, "/Resources/Images/75.png", 1, "Graveler", 100, "[\r\n  8,\r\n  13\r\n]", 0 },
                    { 74, 1, false, "[\r\n  104,\r\n  2,\r\n  62,\r\n  63,\r\n  42\r\n]", 1, 0, "When Geodude sleeps deeply, it buries itself halfway into the Ground. It will not awaken even if hikers step on it unwittingly. In the morning, this Pokémon rolls downhill in search of food.  The longer a Geodude lives, the more its edges are chipped and worn away, making it more rounded in appearance. However, this Pokémon's heart will remain hard, craggy, and rough always.", 0, false, 32, 40, 0, "/Resources/Images/74.png", 1, "Geodude", 100, "[\r\n  8,\r\n  13\r\n]", 0 },
                    { 20, 1, false, "[\r\n  23,\r\n  37,\r\n  42,\r\n  43,\r\n  45\r\n]", 1, 0, "Raticate's sturdy fangs grow steadily. To keep them Ground down, it gnaws on Rocks and logs. It may even chew on the walls of houses.  Raticate's sturdy fangs grow steadily. To keep them Ground down, it gnaws on Rocks and logs. It may even chew on the walls of houses.", 0, false, 0, 55, 0, "/Resources/Images/20.png", 1, "Raticate", 100, "[\r\n  0\r\n]", 0 },
                    { 21, 1, false, "[\r\n  46,\r\n  37,\r\n  35,\r\n  47,\r\n  38\r\n]", 1, 0, "Spearow has a very loud cry that can be heard over half a mile away. If its high, keening cry is heard echoing all around, it is a sign that they are warning each other of danger.  Spearow has a very loud cry that can be heard over half a mile away. If its high, keening cry is heard echoing all around, it is a sign that they are warning each other of danger.", 0, false, 14, 40, 0, "/Resources/Images/21.png", 1, "Spearow", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 22, 1, false, "[\r\n  46,\r\n  40,\r\n  35,\r\n  48,\r\n  38\r\n]", 1, 0, "Fearow is recognized by its long neck and elongated beak. They are conveniently shaped for catching prey in soil or Water. It deftly moves its long and skinny beak to pluck prey.  Fearow is recognized by its long neck and elongated beak. They are conveniently shaped for catching prey in soil or Water. It deftly moves its long and skinny beak to pluck prey.", 0, false, 0, 65, 0, "/Resources/Images/22.png", 1, "Fearow", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 23, 1, false, "[\r\n  33,\r\n  49,\r\n  50,\r\n  3,\r\n  51\r\n]", 1, 0, "Ekans curls itself up in a spiral while it rests. Assuming this position allows it to quickly respond to a threat from any direction with a glare from its upraised head.  Ekans curls itself up in a spiral while it rests. Assuming this position allows it to quickly respond to a threat from any direction with a glare from its upraised head.", 0, false, 15, 35, 0, "/Resources/Images/23.png", 1, "Ekans", 100, "[\r\n  7\r\n]", 0 },
                    { 24, 1, false, "[\r\n  23,\r\n  49,\r\n  52,\r\n  53,\r\n  51\r\n]", 1, 0, "This Pokémon is terrifically strong in order to constrict things with its body. It can even flatten Steel oil drums. Once Arbok wraps its body around its foe, escaping its crunching embrace is impossible.  This Pokémon is terrifically strong in order to constrict things with its body. It can even flatten Steel oil drums. Once Arbok wraps its body around its foe, escaping its crunching embrace is impossible.", 0, false, 0, 60, 0, "/Resources/Images/24.png", 1, "Arbok", 100, "[\r\n  7\r\n]", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ATK", "Achete", "AttacksIdsSerialises", "DEF", "DepotId", "Description", "Emplacement", "Equipe", "EvolutionId", "Health", "HpGaugeId", "Image", "Level", "Name", "Price", "TypesSerialises", "XpGaugeId" },
                values: new object[,]
                {
                    { 25, 1, false, "[\r\n  54,\r\n  37,\r\n  55,\r\n  56,\r\n  57\r\n]", 1, 0, "This Pokémon has Electricity-storing pouches on its cheeks. These appear to become Electrically charged during the night while Pikachu sleeps. It occasionally discharges Electricity when it is dozy after waking up.  Whenever Pikachu comes across something new, it blasts it with a jolt of Electricity. If you come across a blackened berry, it's evidence that this Pokémon mistook the intensity of its charge.", 0, false, 0, 35, 0, "/Resources/Images/25.png", 1, "Pikachu", 100, "[\r\n  3\r\n]", 0 },
                    { 26, 1, false, "[\r\n  54,\r\n  58,\r\n  59,\r\n  60,\r\n  57\r\n]", 1, 0, "This Pokémon exudes a weak Electrical charge from all over its body that makes it take on a slight glow in Darkness. Raichu plants its tail in the Ground to discharge Electricity.  If the Electrical sacs become excessively charged, Raichu plants its tail in the Ground and discharges. Scorched patches of Ground will be found near this Pokémon's nest.", 0, false, 0, 60, 0, "/Resources/Images/26.png", 1, "Raichu", 100, "[\r\n  3\r\n]", 0 },
                    { 27, 1, false, "[\r\n  10,\r\n  61,\r\n  42,\r\n  62,\r\n  63\r\n]", 1, 0, "Sandshrew has a very dry hide that is extremely tough. The Pokémon can roll into a ball that repels any attack. At night, it burrows into the desert sand to sleep.  Sandshrew's body is configured to absorb Water without waste, enabling it to survive in an arid desert. This Pokémon curls up to protect itself from its enemies.", 0, false, 16, 50, 0, "/Resources/Images/27.png", 1, "Sandshrew", 100, "[\r\n  8\r\n]", 0 },
                    { 28, 1, false, "[\r\n  64,\r\n  61,\r\n  65,\r\n  63,\r\n  66\r\n]", 1, 0, "Sandslash can roll up its body as if it were a ball covered with large spikes. In battle, this Pokémon will try to make the foe flinch by jabbing it with its spines. It then leaps at the stunned foe to tear wildly with its sharp claws.  Sandslash's body is covered by tough spikes, which are hardened sections of its hide. Once a year, the old spikes fall out, to be replaced with new spikes that grow out from beneath the old ones.", 0, false, 0, 75, 0, "/Resources/Images/28.png", 1, "Sandslash", 100, "[\r\n  8\r\n]", 0 },
                    { 29, 1, false, "[\r\n  23,\r\n  33,\r\n  67,\r\n  44,\r\n  3\r\n]", 1, 0, "Nidoran has barbs that secrete a powerful Poison. They are thought to have developed as protection for this small-bodied Pokémon. When enraged, it releases a horrible toxin from its horn.", 0, false, 17, 55, 0, "/Resources/Images/29.png", 1, "Nidoran-f", 100, "[\r\n  7\r\n]", 0 },
                    { 30, 1, false, "[\r\n  23,\r\n  33,\r\n  67,\r\n  42,\r\n  3\r\n]", 1, 0, "When Nidorina are with their friends or family, they keep their barbs tucked away to prevent hurting each other. This Pokémon appears to become nervous if separated from the others.  When Nidorina are with their friends or family, they keep their barbs tucked away to prevent hurting each other. This Pokémon appears to become nervous if separated from the others.", 0, false, 0, 70, 0, "/Resources/Images/30.png", 1, "Nidorina", 100, "[\r\n  7\r\n]", 0 },
                    { 31, 1, false, "[\r\n  34,\r\n  23,\r\n  65,\r\n  53,\r\n  68\r\n]", 1, 0, "Nidoqueen's body is encased in extremely hard scales. It is adept at sending foes Flying with harsh tackles. This Pokémon is at its strongest when it is defending its young.  Nidoqueen's body is encased in extremely hard scales. It is adept at sending foes Flying with harsh tackles. This Pokémon is at its strongest when it is defending its young.", 0, false, 0, 90, 0, "/Resources/Images/31.png", 1, "Nidoqueen", 100, "[\r\n  7,\r\n  8\r\n]", 0 },
                    { 32, 1, false, "[\r\n  46,\r\n  33,\r\n  69,\r\n  44,\r\n  3\r\n]", 1, 0, "Nidoran has developed muscles for moving its ears. Thanks to them, the ears can be freely moved in any direction. Even the slightest sound does not escape this Pokémon's notIce.", 0, false, 18, 46, 0, "/Resources/Images/32.png", 1, "Nidoran-m", 100, "[\r\n  7\r\n]", 0 },
                    { 33, 1, false, "[\r\n  34,\r\n  33,\r\n  69,\r\n  42,\r\n  3\r\n]", 1, 0, "Nidorino has a horn that is harder than a diamond. If it senses a hostile presence, all the barbs on its back bristle up at once, and it challenges the foe with all its might.  Nidorino has a horn that is harder than a diamond. If it senses a hostile presence, all the barbs on its back bristle up at once, and it challenges the foe with all its might.", 0, false, 0, 61, 0, "/Resources/Images/33.png", 1, "Nidorino", 100, "[\r\n  7\r\n]", 0 },
                    { 34, 1, false, "[\r\n  34,\r\n  70,\r\n  65,\r\n  53,\r\n  71\r\n]", 1, 0, "Nidoking's thick tail packs enormously destructive power. With one swing, it can topple a metal transmission tower. Once this Pokémon goes on a rampage, there is no stopping it.  Nidoking's thick tail packs enormously destructive power. With one swing, it can topple a metal transmission tower. Once this Pokémon goes on a rampage, there is no stopping it.", 0, false, 0, 81, 0, "/Resources/Images/34.png", 1, "Nidoking", 100, "[\r\n  7,\r\n  8\r\n]", 0 },
                    { 19, 1, false, "[\r\n  2,\r\n  37,\r\n  42,\r\n  43,\r\n  44\r\n]", 1, 0, "Rattata is cautious in the extreme. Even while it is asleep, it constantly listens by moving its ears around. It is not picky about where it lives—it will make its nest anywhere.  Rattata is cautious in the extreme. Even while it is asleep, it constantly listens by moving its ears around. It is not picky about where it lives—it will make its nest anywhere.", 0, false, 13, 30, 0, "/Resources/Images/19.png", 1, "Rattata", 100, "[\r\n  0\r\n]", 0 },
                    { 35, 1, false, "[\r\n  72,\r\n  73,\r\n  74,\r\n  44,\r\n  75\r\n]", 1, 0, "On every night of a full moon, groups of this Pokémon come out to play. When dawn arrives, the tired CleFairy return to their quiet mountain retreats and go to sleep nestled up against each other.  On every night of a full moon, groups of this Pokémon come out to play. When dawn arrives, the tired CleFairy return to their quiet mountain retreats and go to sleep nestled up against each other.", 0, false, 0, 70, 0, "/Resources/Images/35.png", 1, "CleFairy", 100, "[\r\n  17\r\n]", 0 },
                    { 18, 1, false, "[\r\n  15,\r\n  40,\r\n  41,\r\n  35,\r\n  39\r\n]", 1, 0, "This Pokémon has a dazzling plumage of beautifully glossy feathers. Many Trainers are captivated by the striking beauty of the feathers on its head, compelling them to choose Pidgeot as their Pokémon.  This Pokémon has a dazzling plumage of beautifully glossy feathers. Many Trainers are captivated by the striking beauty of the feathers on its head, compelling them to choose Pidgeot as their Pokémon.", 0, false, 0, 83, 0, "/Resources/Images/18.png", 1, "Pidgeot", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 16, 1, false, "[\r\n  37,\r\n  2,\r\n  38,\r\n  35,\r\n  39\r\n]", 1, 0, "Pidgey has an extremely sharp sense of direction. It is capable of unerringly returning home to its nest, however far it may be removed from its familiar surroundings.  Pidgey has an extremely sharp sense of direction. It is capable of unerringly returning home to its nest, however far it may be removed from its familiar surroundings.", 0, false, 11, 40, 0, "/Resources/Images/16.png", 1, "Pidgey", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 1, 1, false, "[\r\n  1,\r\n  2,\r\n  3,\r\n  4,\r\n  5\r\n]", 1, 0, "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.  Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.", 0, false, 1, 45, 0, "/Resources/Images/1.png", 1, "Bulbasaur", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 2, 1, false, "[\r\n  6,\r\n  1,\r\n  3,\r\n  7,\r\n  5\r\n]", 1, 0, "There is a bud on this Pokémon's back. To support its weight, Ivysaur's legs and trunk grow thick and strong. If it starts spending more time lying in the sunlight, it's a sign that the bud will bloom into a large flower soon.  There is a bud on this Pokémon's back. To support its weight, Ivysaur's legs and trunk grow thick and strong. If it starts spending more time lying in the sunlight, it's a sign that the bud will bloom into a large flower soon.", 0, false, 2, 60, 0, "/Resources/Images/2.png", 1, "Ivysaur", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 3, 1, false, "[\r\n  6,\r\n  1,\r\n  3,\r\n  8,\r\n  7\r\n]", 1, 0, "There is a large flower on Venusaur's back. The flower is said to take on vivid colors if it gets plenty of nutrition and sunlight. The flower's aroma soothes the emotions of people.  There is a large flower on Venusaur's back. The flower is said to take on vivid colors if it gets plenty of nutrition and sunlight. The flower's aroma soothes the emotions of people.", 0, false, 0, 80, 0, "/Resources/Images/3.png", 1, "Venusaur", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 4, 1, false, "[\r\n  9,\r\n  10,\r\n  11,\r\n  12,\r\n  13\r\n]", 1, 0, "The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is enjoying itself. If the Pokémon becomes enraged, the flame burns fiercely.  The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is enjoying itself. If the Pokémon becomes enraged, the flame burns fiercely.", 0, false, 3, 39, 0, "/Resources/Images/4.png", 1, "Charmander", 100, "[\r\n  1\r\n]", 0 },
                    { 5, 1, false, "[\r\n  9,\r\n  10,\r\n  14,\r\n  12,\r\n  13\r\n]", 1, 0, "Charmeleon mercilessly destroys its foes using its sharp claws. If it encounters a strong foe, it turns aggressive. In this excited state, the flame at the tip of its tail flares with a bluish white color.  Charmeleon mercilessly destroys its foes using its sharp claws. If it encounters a strong foe, it turns aggressive. In this excited state, the flame at the tip of its tail flares with a bluish white color.", 0, false, 4, 58, 0, "/Resources/Images/5.png", 1, "Charmeleon", 100, "[\r\n  1\r\n]", 0 },
                    { 6, 1, false, "[\r\n  9,\r\n  15,\r\n  16,\r\n  17,\r\n  13\r\n]", 1, 0, "Charizard flies around the sky in search of powerful opponents. It breathes Fire of such great heat that it melts anything. However, it never turns its fiery breath on any opponent weaker than itself.  Charizard flies around the sky in search of powerful opponents. It breathes Fire of such great heat that it melts anything. However, it never turns its fiery breath on any opponent weaker than itself.", 0, false, 0, 78, 0, "/Resources/Images/6.png", 1, "Charizard", 100, "[\r\n  10,\r\n  1\r\n]", 0 },
                    { 7, 1, false, "[\r\n  18,\r\n  2,\r\n  19,\r\n  20,\r\n  21\r\n]", 1, 0, "Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in Water, enabling this Pokémon to swim at high speeds.  Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in Water, enabling this Pokémon to swim at high speeds.", 0, false, 5, 44, 0, "/Resources/Images/7.png", 1, "Squirtle", 100, "[\r\n  2\r\n]", 0 },
                    { 8, 1, false, "[\r\n  22,\r\n  23,\r\n  19,\r\n  24,\r\n  25\r\n]", 1, 0, "Its tail is large and covered with a rich, thick fur. The tail becomes increasingly deeper in color as Wartortle ages. The scratches on its shell are evidence of this Pokémon's toughness as a battler.  Its tail is large and covered with a rich, thick fur. The tail becomes increasingly deeper in color as Wartortle ages. The scratches on its shell are evidence of this Pokémon's toughness as a battler.", 0, false, 6, 59, 0, "/Resources/Images/8.png", 1, "Wartortle", 100, "[\r\n  2\r\n]", 0 },
                    { 9, 1, false, "[\r\n  22,\r\n  23,\r\n  26,\r\n  24,\r\n  25\r\n]", 1, 0, "Blastoise has Water spouts that protrude from its shell. The Water spouts are very accurate. They can shoot bullets of Water with enough accuracy to strike empty cans from a distance of over 160 feet.  Blastoise has Water spouts that protrude from its shell. The Water spouts are very accurate. They can shoot bullets of Water with enough accuracy to strike empty cans from a distance of over 160 feet.", 0, false, 0, 79, 0, "/Resources/Images/9.png", 1, "Blastoise", 100, "[\r\n  2\r\n]", 0 },
                    { 10, 1, false, "[\r\n  27,\r\n  2,\r\n  28\r\n]", 1, 0, "Caterpie has a voracious appetite. It can devour leaves bigger than its body right before your eyes. From its antenna, this Pokémon releases a terrifically strong odor.  Caterpie has a voracious appetite. It can devour leaves bigger than its body right before your eyes. From its antenna, this Pokémon releases a terrifically strong odor.", 0, false, 7, 45, 0, "/Resources/Images/10.png", 1, "Caterpie", 100, "[\r\n  12\r\n]", 0 },
                    { 11, 1, false, "[\r\n  27,\r\n  2,\r\n  28\r\n]", 1, 0, "The shell covering this Pokémon's body is as hard as an iron slab. Metapod does not move very much. It stays still because it is preparing its soft innards for evolution inside the hard shell.  The shell covering this Pokémon's body is as hard as an iron slab. Metapod does not move very much. It stays still because it is preparing its soft innards for evolution inside the hard shell.", 0, false, 8, 50, 0, "/Resources/Images/11.png", 1, "Metapod", 100, "[\r\n  12\r\n]", 0 },
                    { 12, 1, false, "[\r\n  27,\r\n  29,\r\n  30,\r\n  31,\r\n  32\r\n]", 1, 0, "Butterfree has a superior ability to search for delicious honey from flowers. It can even search out, extract, and carry honey from flowers that are blooming over six miles from its nest.  Butterfree has a superior ability to search for delicious honey from flowers. It can even search out, extract, and carry honey from flowers that are blooming over six miles from its nest.", 0, false, 0, 60, 0, "/Resources/Images/12.png", 1, "Butterfree", 100, "[\r\n  10,\r\n  12\r\n]", 0 },
                    { 13, 1, false, "[\r\n  27,\r\n  33,\r\n  28\r\n]", 1, 0, "Weedle has an extremely acute sense of smell. It is capable of distinguishing its favorite kinds of leaves from those it dislikes just by sniffing with its big red proboscis (nose).  Weedle has an extremely acute sense of smell. It is capable of distinguishing its favorite kinds of leaves from those it dislikes just by sniffing with its big red proboscis (nose).", 0, false, 9, 40, 0, "/Resources/Images/13.png", 1, "Weedle", 100, "[\r\n  7,\r\n  12\r\n]", 0 },
                    { 14, 1, false, "[\r\n  27,\r\n  33,\r\n  28\r\n]", 1, 0, "Kakuna remains virtually immobile as it clings to a tree. However, on the inside, it is extremely busy as it prepares for its coming evolution. This is evident from how hot the shell becomes to the touch.  Kakuna remains virtually immobile as it clings to a tree. However, on the inside, it is extremely busy as it prepares for its coming evolution. This is evident from how hot the shell becomes to the touch.", 0, false, 10, 45, 0, "/Resources/Images/14.png", 1, "Kakuna", 100, "[\r\n  7,\r\n  12\r\n]", 0 },
                    { 15, 1, false, "[\r\n  27,\r\n  34,\r\n  3,\r\n  35,\r\n  36\r\n]", 1, 0, "Beedrill is extremely territorial. No one should ever approach its nest—this is for their own safety. If angered, they will attack in a furious swarm.  Beedrill is extremely territorial. No one should ever approach its nest—this is for their own safety. If angered, they will attack in a furious swarm.", 0, false, 0, 65, 0, "/Resources/Images/15.png", 1, "Beedrill", 100, "[\r\n  7,\r\n  12\r\n]", 0 },
                    { 17, 1, false, "[\r\n  15,\r\n  40,\r\n  38,\r\n  35,\r\n  39\r\n]", 1, 0, "Pidgeotto claims a large area as its own territory. This Pokémon flies around, patrolling its living space. If its territory is violated, it shows no mercy in thoroughly punishing the foe with its sharp claws.  Pidgeotto claims a large area as its own territory. This Pokémon flies around, patrolling its living space. If its territory is violated, it shows no mercy in thoroughly punishing the foe with its sharp claws.", 0, false, 12, 63, 0, "/Resources/Images/17.png", 1, "Pidgeotto", 100, "[\r\n  0,\r\n  10\r\n]", 0 },
                    { 36, 1, false, "[\r\n  72,\r\n  73,\r\n  76,\r\n  31,\r\n  75\r\n]", 1, 0, "Clefable moves by skipping lightly as if it were Flying using its wings. Its bouncy step lets it even walk on Water. It is known to take strolls on lakes on quiet, moonlit nights.  Clefable moves by skipping lightly as if it were Flying using its wings. Its bouncy step lets it even walk on Water. It is known to take strolls on lakes on quiet, moonlit nights.", 0, false, 0, 95, 0, "/Resources/Images/36.png", 1, "Clefable", 100, "[\r\n  17\r\n]", 0 },
                    { 37, 1, false, "[\r\n  37,\r\n  9,\r\n  44,\r\n  13,\r\n  11\r\n]", 1, 0, "Inside Vulpix's body burns a flame that never goes out. During the daytime, when the temperatures rise, this Pokémon releases flames from its mouth to prevent its body from growing too hot.  At the time of its birth, Vulpix has one white tail. The tail separates into six if this Pokémon receives plenty of love from its Trainer. The six tails become magnifIcently curled.", 0, false, 0, 38, 0, "/Resources/Images/37.png", 1, "Vulpix", 100, "[\r\n  1\r\n]", 0 },
                    { 38, 1, false, "[\r\n  77,\r\n  9,\r\n  78,\r\n  13,\r\n  16\r\n]", 1, 0, "Legend has it that Ninetales came into being when nine wizards possessing sacred powers merged into one. This Pokémon is highly intelligent—it can understand human speech.  Ninetales casts a sinister light from its bright red eyes to gain total control over its foe's mind. This Pokémon is said to live for a thousand years.", 0, false, 0, 73, 0, "/Resources/Images/38.png", 1, "Ninetales", 100, "[\r\n  1\r\n]", 0 },
                    { 59, 1, false, "[\r\n  93,\r\n  23,\r\n  16,\r\n  13,\r\n  66\r\n]", 1, 0, "Arcanine is known for its high speed. It is said to be capable of running over 6,200 miles in a single day and night. The Fire that blazes wildly within this Pokémon's body is its source of power.  Arcanine is known for its high speed. It is said to be capable of running over 6,200 miles in a single day and night. The Fire that blazes wildly within this Pokémon's body is its source of power.", 0, false, 0, 90, 0, "/Resources/Images/59.png", 1, "Arcanine", 100, "[\r\n  1\r\n]", 0 },
                    { 60, 1, false, "[\r\n  18,\r\n  61,\r\n  95,\r\n  84,\r\n  44\r\n]", 1, 0, "Poliwag has a very thin skin. It is possible to see the Pokémon's spiral innards right through the skin. Despite its thinness, however, the skin is also very flexible. Even sharp fangs bounce right off it.  Poliwag has a very thin skin. It is possible to see the Pokémon's spiral innards right through the skin. Despite its thinness, however, the skin is also very flexible. Even sharp fangs bounce right off it.", 0, false, 27, 40, 0, "/Resources/Images/60.png", 1, "Poliwag", 100, "[\r\n  2\r\n]", 0 },
                    { 61, 1, false, "[\r\n  18,\r\n  61,\r\n  96,\r\n  84,\r\n  95\r\n]", 1, 0, "The surface of Poliwhirl's body is always wet and slick with a slimy fluid. Because of this slippery covering, it can easily slip and slide out of the clutches of any enemy in battle.  The surface of Poliwhirl's body is always wet and slick with a slimy fluid. Because of this slippery covering, it can easily slip and slide out of the clutches of any enemy in battle.", 0, false, 0, 65, 0, "/Resources/Images/61.png", 1, "Poliwhirl", 100, "[\r\n  2\r\n]", 0 },
                    { 62, 1, false, "[\r\n  18,\r\n  61,\r\n  25,\r\n  97,\r\n  98\r\n]", 1, 0, "Poliwrath's highly developed, brawny muscles never grow fatigued, however much it exercises. It is so tirelessly strong, this Pokémon can swim back and forth across the ocean without effort.  Poliwrath's highly developed, brawny muscles never grow fatigued, however much it exercises. It is so tirelessly strong, this Pokémon can swim back and forth across the ocean without effort.", 0, false, 0, 90, 0, "/Resources/Images/62.png", 1, "Poliwrath", 100, "[\r\n  6,\r\n  2\r\n]", 0 },
                    { 63, 1, false, "[\r\n  73,\r\n  99,\r\n  32,\r\n  100\r\n]", 1, 0, "Abra needs to sleep for eighteen hours a day. If it doesn't, this Pokémon loses its ability to use telekinetic powers. If it is attacked, Abra escapes using Teleport while it is still sleeping.  Abra sleeps for eighteen hours a day. However, it can sense the presence of foes even while it is sleeping. In such a situation, this Pokémon immediately teleports to safety.", 0, false, 28, 25, 0, "/Resources/Images/63.png", 1, "Abra", 100, "[\r\n  11\r\n]", 0 },
                    { 64, 1, false, "[\r\n  101,\r\n  29,\r\n  82,\r\n  76,\r\n  100\r\n]", 1, 0, "Kadabra holds a silver spoon in its hand. The spoon is used to amplify the alpha waves in its brain. Without the spoon, the Pokémon is said to be limited to half the usual amount of its telekinetic powers.  Kadabra emits a peculiar alpha wave if it develops a headache. Only those people with a particularly strong psyche can hope to become a Trainer of this Pokémon.", 0, false, 0, 40, 0, "/Resources/Images/64.png", 1, "Kadabra", 100, "[\r\n  11\r\n]", 0 },
                    { 65, 1, false, "[\r\n  101,\r\n  29,\r\n  31,\r\n  76,\r\n  100\r\n]", 1, 0, "Alakazam's brain continually grows, infinitely multiplying brain cells. This amazing brain gives this Pokémon an astoundingly high IQ of 5,000. It has a thorough memory of everything that has occurred in the world.  Alakazam's brain continually grows, making its head far too heavy to support with its neck. This Pokémon holds its head up using its psychokinetic power instead.", 0, false, 0, 55, 0, "/Resources/Images/65.png", 1, "Alakazam", 100, "[\r\n  11\r\n]", 0 },
                    { 66, 1, false, "[\r\n  91,\r\n  89,\r\n  90,\r\n  59,\r\n  88\r\n]", 1, 0, "Machop exercises by hefting around a Graveler as if it were a barbell. There are some Machop that travel the world in a quest to master all kinds of martial arts.  Machop's muscles are special—they never get sore no matter how much they are used in exercise. This Pokémon has sufficient power to hurl a hundred adult humans.", 0, false, 29, 70, 0, "/Resources/Images/66.png", 1, "Machop", 100, "[\r\n  6\r\n]", 0 },
                    { 67, 1, false, "[\r\n  91,\r\n  89,\r\n  97,\r\n  59,\r\n  88\r\n]", 1, 0, "Machoke undertakes bodybuilding every day even as it helps people with tough, physically demanding labor. On its days off, this Pokémon heads to the fields and mountains to exercise and train.  Machoke's thoroughly toned muscles possess the hardness of Steel. This Pokémon has so much strength, it can easily hold aloft a sumo wrestler on just one finger.", 0, false, 0, 80, 0, "/Resources/Images/67.png", 1, "Machoke", 100, "[\r\n  6\r\n]", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ATK", "Achete", "AttacksIdsSerialises", "DEF", "DepotId", "Description", "Emplacement", "Equipe", "EvolutionId", "Health", "HpGaugeId", "Image", "Level", "Name", "Price", "TypesSerialises", "XpGaugeId" },
                values: new object[,]
                {
                    { 68, 1, false, "[\r\n  102,\r\n  89,\r\n  68,\r\n  97,\r\n  88\r\n]", 1, 0, "Machamp is known as the Pokémon that has mastered every kind of martial arts. If it grabs hold of the foe with its four arms, the battle is all but over. The hapless foe is thrown far over the horizon.  Machamp has the power to hurl anything aside. However, trying to do any work requiring care and dexterity causes its arms to get tangled. This Pokémon tends to leap into action before it thinks.", 0, false, 0, 90, 0, "/Resources/Images/68.png", 1, "Machamp", 100, "[\r\n  6\r\n]", 0 },
                    { 69, 1, false, "[\r\n  1,\r\n  49,\r\n  5,\r\n  3,\r\n  50\r\n]", 1, 0, "Bellsprout's thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, this Pokémon spits a corrosive fluid that melts even iron.  Bellsprout's thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, this Pokémon spits a corrosive fluid that melts even iron.", 0, false, 30, 50, 0, "/Resources/Images/69.png", 1, "Bellsprout", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 70, 1, false, "[\r\n  6,\r\n  49,\r\n  5,\r\n  3,\r\n  4\r\n]", 1, 0, "Weepinbell has a large hook on its rear end. At night, the Pokémon hooks on to a tree branch and goes to sleep. If it moves around in its sleep, it may wake up to find itself on the Ground.  Weepinbell has a large hook on its rear end. At night, the Pokémon hooks on to a tree branch and goes to sleep. If it moves around in its sleep, it may wake up to find itself on the Ground.", 0, false, 0, 65, 0, "/Resources/Images/70.png", 1, "Weepinbell", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 71, 1, false, "[\r\n  6,\r\n  49,\r\n  103,\r\n  3,\r\n  7\r\n]", 1, 0, "Victreebel has a long vine that extends from its head. This vine is waved and flicked about as if it were an animal to attract prey. When an unsuspecting prey draws near, this Pokémon swallows it whole.  Victreebel has a long vine that extends from its head. This vine is waved and flicked about as if it were an animal to attract prey. When an unsuspecting prey draws near, this Pokémon swallows it whole.", 0, false, 0, 80, 0, "/Resources/Images/71.png", 1, "Victreebel", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 72, 1, false, "[\r\n  18,\r\n  33,\r\n  95,\r\n  21,\r\n  50\r\n]", 1, 0, "Tentacool absorbs sunlight and refracts it using Water inside its body to convert it into beam energy. This Pokémon shoots beams from the small round organ above its eyes.  Tentacool's body is largely composed of Water. If it is removed from the sea, it dries up like parchment. If this Pokémon happens to become dehydrated, put it back into the sea.", 0, false, 31, 40, 0, "/Resources/Images/72.png", 1, "Tentacool", 100, "[\r\n  7,\r\n  2\r\n]", 0 },
                    { 73, 1, false, "[\r\n  49,\r\n  34,\r\n  25,\r\n  53,\r\n  125\r\n]", 1, 0, "Tentacruel has tentacles that can be freely elongated and shortened at will. It ensnares prey with its tentacles and weakens the prey by dosing it with a harsh toxin. It can catch up to 80 prey at the same time.  Tentacruel has large red orbs on its head. The orbs glow before lashing the vicinity with a harsh ultrasonic blast. This Pokémon's outburst creates rough waves around it.", 0, false, 0, 80, 0, "/Resources/Images/73.png", 1, "Tentacruel", 100, "[\r\n  7,\r\n  2\r\n]", 0 },
                    { 58, 1, false, "[\r\n  9,\r\n  23,\r\n  92,\r\n  44,\r\n  13\r\n]", 1, 0, "Growlithe has a superb sense of smell. Once it smells anything, this Pokémon won't forget the scent, no matter what. It uses its advanced olfactory sense to determine the emotions of other living things.  Growlithe has a superb sense of smell. Once it smells anything, this Pokémon won't forget the scent, no matter what. It uses its advanced olfactory sense to determine the emotions of other living things.", 0, false, 0, 55, 0, "/Resources/Images/58.png", 1, "Growlithe", 100, "[\r\n  1\r\n]", 0 },
                    { 57, 1, false, "[\r\n  91,\r\n  89,\r\n  88,\r\n  90,\r\n  86\r\n]", 1, 0, "When Primeape becomes furious, its blood circulation is boosted. In turn, its muscles are made even stronger. However, it also becomes much less intelligent at the same time.  When Primeape becomes furious, its blood circulation is boosted. In turn, its muscles are made even stronger. However, it also becomes much less intelligent at the same time.", 0, false, 0, 65, 0, "/Resources/Images/57.png", 1, "Primeape", 100, "[\r\n  6\r\n]", 0 },
                    { 56, 1, false, "[\r\n  89,\r\n  10,\r\n  88,\r\n  90,\r\n  59\r\n]", 1, 0, "When Mankey starts shaking and its nasal breathing turns rough, it's a sure sign that it is becoming angry. However, because it goes into a towering rage almost instantly, it is impossible for anyone to flee its wrath.  When Mankey starts shaking and its nasal breathing turns rough, it's a sure sign that it is becoming angry. However, because it goes into a towering rage almost instantly, it is impossible for anyone to flee its wrath.", 0, false, 26, 40, 0, "/Resources/Images/56.png", 1, "Mankey", 100, "[\r\n  6\r\n]", 0 },
                    { 55, 1, false, "[\r\n  22,\r\n  29,\r\n  31,\r\n  25,\r\n  24\r\n]", 1, 0, "Golduck is the fastest swimmer among all Pokémon. It swims effortlessly, even in a rough, stormy sea. It sometimes rescues people from wrecked ships floundering in high seas.  The webbed flippers on its forelegs and hind legs and the streamlined body of Golduck give it frightening speed. This Pokémon is definitely much faster than even the most athletic swimmer.", 0, false, 0, 80, 0, "/Resources/Images/55.png", 1, "Golduck", 100, "[\r\n  2\r\n]", 0 },
                    { 39, 1, false, "[\r\n  72,\r\n  77,\r\n  74,\r\n  44,\r\n  79,\r\n  76\r\n]", 1, 0, "When this Pokémon sings, it never pauses to breathe. If it is in a battle against an opponent that does not easily fall asleep, Jigglypuff cannot breathe, endangering its life.  Jigglypuff's vocal cords can freely adjust the wavelength of its voIce. This Pokémon uses this ability to sing at precisely the right wavelength to make its foes most drowsy.", 0, false, 0, 115, 0, "/Resources/Images/39.png", 1, "Jigglypuff", 100, "[\r\n  0,\r\n  17\r\n]", 0 },
                    { 40, 1, false, "[\r\n  72,\r\n  77,\r\n  76,\r\n  45,\r\n  79\r\n]", 1, 0, "Wigglytuff's body is very flexible. By inhaling deeply, this Pokémon can inflate itself seemingly without end. Once inflated, Wigglytuff bounces along lightly like a balloon.  Wigglytuff has large, saucerlike eyes. The surfaces of its eyes are always covered with a thin layer of tears. If any dust gets in this Pokémon's eyes, it is quickly washed away.", 0, false, 0, 140, 0, "/Resources/Images/40.png", 1, "Wigglytuff", 100, "[\r\n  0,\r\n  17\r\n]", 0 },
                    { 41, 1, false, "[\r\n  37,\r\n  23,\r\n  67,\r\n  39,\r\n  3\r\n]", 1, 0, "Zubat avoids sunlight because exposure causes it to become unhealthy. During the daytime, it stays in caves or under the eaves of old houses, sleeping while hanging upside down.  Zubat remains quietly unmoving in a Dark spot during the bright daylight hours. It does so because prolonged exposure to the sun causes its body to become slightly burned.", 0, false, 19, 40, 0, "/Resources/Images/41.png", 1, "Zubat", 100, "[\r\n  10,\r\n  7\r\n]", 0 },
                    { 42, 1, false, "[\r\n  15,\r\n  23,\r\n  67,\r\n  39,\r\n  80\r\n]", 1, 0, "Golbat bites down on prey with its four fangs and drinks the victim's blood. It becomes active on inky Dark moonless nights, Flying around to attack people and Pokémon.  Golbat loves to drink the blood of living things. It is particularly active in the pitch black of night. This Pokémon flits around in the night skies, seeking fresh blood.", 0, false, 0, 75, 0, "/Resources/Images/42.png", 1, "Golbat", 100, "[\r\n  10,\r\n  7\r\n]", 0 },
                    { 43, 1, false, "[\r\n  6,\r\n  49,\r\n  4,\r\n  3,\r\n  75\r\n]", 1, 0, "Oddish searches for fertile, nutrient-rich soil, then plants itself. During the daytime, while it is planted, this Pokémon's feet are thought to change shape and become similar to the roots of trees.  During the daytime, Oddish buries itself in soil to absorb nutrients from the Ground using its entire body. The more fertile the soil, the glossier its leaves become.", 0, false, 20, 45, 0, "/Resources/Images/43.png", 1, "Oddish", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 44, 1, false, "[\r\n  6,\r\n  49,\r\n  8,\r\n  3,\r\n  75\r\n]", 1, 0, "From its mouth Gloom drips honey that smells absolutely horrible. Apparently, it loves the horrid stench. It sniffs the noxious fumes and then drools even more of its honey.  Gloom releases a foul fragrance from the pistil of its flower. When faced with danger, the stench worsens. If this Pokémon is feeling calm and secure, it does not release its usual stinky aroma.", 0, false, 0, 60, 0, "/Resources/Images/44.png", 1, "Gloom", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 45, 1, false, "[\r\n  6,\r\n  49,\r\n  8,\r\n  7,\r\n  75\r\n]", 1, 0, "Vileplume has the world's largest petals. They are used to attract prey that are then doused with toxic spores. Once the prey are immobilized, this Pokémon catches and devours them.  Vileplume's toxic pollen triggers atrocious allergy attacks. That's why it is advisable never to approach any attractive flowers in a jungle, however pretty they may be.", 0, false, 0, 75, 0, "/Resources/Images/45.png", 1, "Vileplume", 100, "[\r\n  7,\r\n  4\r\n]", 0 },
                    { 151, 1, false, "[\r\n  72,\r\n  41,\r\n  65,\r\n  31,\r\n  120,\r\n  57,\r\n  75,\r\n  16,\r\n  7,\r\n  45,\r\n  125\r\n]", 1, 0, "Mew is said to possess the genetic composition of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notIce even if it approaches people.  Mew is said to possess the genetic composition of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notIce even if it approaches people.", 0, false, 0, 100, 0, "/Resources/Images/151.png", 1, "Mew", 100, "[\r\n  11\r\n]", 0 },
                    { 46, 1, false, "[\r\n  10,\r\n  27,\r\n  81,\r\n  36,\r\n  4\r\n]", 1, 0, "Paras has parasitic mushrooms growing on its back called tochukaso. They grow large by drawing nutrients from this Bug Pokémon host. They are highly valued as a medicine for extending life.  Paras has parasitic mushrooms growing on its back called tochukaso. They grow large by drawing nutrients from this Bug Pokémon host. They are highly valued as a medicine for extending life.", 0, false, 21, 35, 0, "/Resources/Images/46.png", 1, "Paras", 100, "[\r\n  12,\r\n  4\r\n]", 0 },
                    { 48, 1, false, "[\r\n  27,\r\n  29,\r\n  67,\r\n  82,\r\n  32\r\n]", 1, 0, "Venonat is said to have evolved with a coat of thin, stiff hair that covers its entire body for protection. It possesses large eyes that never fail to spot even minuscule prey.  Venonat is said to have evolved with a coat of thin, stiff hair that covers its entire body for protection. It possesses large eyes that never fail to spot even minuscule prey.", 0, false, 22, 60, 0, "/Resources/Images/48.png", 1, "Venonat", 100, "[\r\n  7,\r\n  12\r\n]", 0 },
                    { 49, 1, false, "[\r\n  27,\r\n  29,\r\n  67,\r\n  31,\r\n  30\r\n]", 1, 0, "Venomoth is nocturnal—it is a Pokémon that only becomes active at night. Its favorite prey are small insects that gather around streetlights, attracted by the light in the Darkness.  Venomoth is nocturnal—it is a Pokémon that only becomes active at night. Its favorite prey are small insects that gather around streetlights, attracted by the light in the Darkness.", 0, false, 0, 70, 0, "/Resources/Images/49.png", 1, "Venomoth", 100, "[\r\n  7,\r\n  12\r\n]", 0 },
                    { 50, 1, false, "[\r\n  61,\r\n  10,\r\n  83,\r\n  42,\r\n  84,\r\n  63\r\n]", 1, 0, "Diglett are raised in most farms. The reason is simple— wherever this Pokémon burrows, the soil is left perfectly tilled for planting crops. This soil is made ideal for growing delicious vegetables.  Diglett are raised in most farms. The reason is simple— wherever this Pokémon burrows, the soil is left perfectly tilled for planting crops. This soil is made ideal for growing delicious vegetables.", 0, false, 23, 10, 0, "/Resources/Images/50.png", 1, "Diglett", 100, "[\r\n  8\r\n]", 0 },
                    { 51, 1, false, "[\r\n  85,\r\n  61,\r\n  83,\r\n  65,\r\n  84,\r\n  68\r\n]", 1, 0, "Dugtrio are actually triplets that emerged from one body. As a result, each triplet thinks exactly like the other two triplets. They work cooperatively to burrow endlessly.  Dugtrio are actually triplets that emerged from one body. As a result, each triplet thinks exactly like the other two triplets. They work cooperatively to burrow endlessly.", 0, false, 0, 35, 0, "/Resources/Images/51.png", 1, "Dugtrio", 100, "[\r\n  8\r\n]", 0 },
                    { 52, 1, false, "[\r\n  10,\r\n  23,\r\n  86,\r\n  52,\r\n  44\r\n]", 1, 0, "Meowth withdraws its sharp claws into its paws to slinkily sneak about without making any incriminating footsteps. For some reason, this Pokémon loves shiny coins that glitter with light.  Meowth withdraws its sharp claws into its paws to slinkily sneak about without making any incriminating footsteps. For some reason, this Pokémon loves shiny coins that glitter with light.", 0, false, 24, 40, 0, "/Resources/Images/52.png", 1, "Meowth", 100, "[\r\n  0\r\n]", 0 },
                    { 53, 1, false, "[\r\n  10,\r\n  77,\r\n  86,\r\n  87,\r\n  79\r\n]", 1, 0, "Persian has six bold whiskers that give it a look of toughness. The whiskers sense air movements to determine what is in the Pokémon's surrounding vicinity. It becomes docile if grabbed by the whiskers.  Persian has six bold whiskers that give it a look of toughness. The whiskers sense air movements to determine what is in the Pokémon's surrounding vicinity. It becomes docile if grabbed by the whiskers.", 0, false, 0, 65, 0, "/Resources/Images/53.png", 1, "Persian", 100, "[\r\n  0\r\n]", 0 },
                    { 54, 1, false, "[\r\n  22,\r\n  73,\r\n  82,\r\n  20,\r\n  88\r\n]", 1, 0, "If it uses its mysterious power, Psyduck can't remember having done so. It apparently can't form a memory of such an event because it goes into an altered state that is much like deep sleep.  Psyduck uses a mysterious power. When it does so, this Pokémon generates brain waves that are supposedly only seen in sleepers. This discovery spurred controversy among scholars.", 0, false, 25, 50, 0, "/Resources/Images/54.png", 1, "Psyduck", 100, "[\r\n  2\r\n]", 0 },
                    { 47, 1, false, "[\r\n  27,\r\n  70,\r\n  81,\r\n  36,\r\n  7\r\n]", 1, 0, "Parasect is known to infest large trees en masse and drain nutrients from the lower trunk and roots. When an infested tree dies, they move onto another tree all at once.  Parasect is known to infest large trees en masse and drain nutrients from the lower trunk and roots. When an infested tree dies, they move onto another tree all at once.", 0, false, 0, 60, 0, "/Resources/Images/47.png", 1, "Parasect", 100, "[\r\n  12,\r\n  4\r\n]", 0 },
                    { 152, 1, true, "[\r\n  1,\r\n  2,\r\n  3,\r\n  4,\r\n  5\r\n]", 1, 1, "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.  Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.", 0, false, 1, 45, 1, "/Resources/Images/1.png", 1, "Bulbasaur", 100, "[\r\n  7,\r\n  4\r\n]", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "DepotId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dresseurs",
                keyColumn: "DresseurId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 152);
        }
    }
}
