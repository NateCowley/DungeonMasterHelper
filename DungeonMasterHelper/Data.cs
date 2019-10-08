using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DungeonMasterHelper
{
	// In many of the lists located below, there are repeated elements. This was done 
	// in order to preserve the original tables as they were found in the source books for 
	// D&D 5e

	// TODO: create complete tables/gets, get results by rolling on tables, check tables for spelling errors

	public static class Data
	{
		#region Utilities

		private static Random rand = new Random();

		public static readonly bool INDEVELOPMENT = true;

		private static string lowerFirstLetter(string str)
		{
			return str.First().ToString().ToLower() + (str.Skip(1)).ToString();
		}

		/// <summary>
		/// Simulates a roll of the dice.
		/// For example, calling roll(3, 6) is the equivalent of rolling 3d6.
		/// </summary>
		/// <param name="numDice"></param>
		/// <param name="faceCount"></param>
		/// <returns></returns>
		public static int roll(int numDice, int faceCount)
		{
			if (numDice <= 0)
			{
				return -1;
			}

			int sum = 0;

			for (int i = 0; i < numDice; i++)
			{
				sum += rand.Next() % faceCount + 1;
			}

			return sum;
		}

		public static int statRoll4d6()
		{
			int sum = 0;
			int low = 20;

			for (int i = 0; i < 4; i++)
			{
				int next = roll(1, 6);
				sum += next;

				if (next < low)
				{
					low = next;
				}
			}

			sum -= low;

			return sum;
		}

		public static string getSingleRandomFrom(string[] arr)
		{
			return arr[rand.Next() % arr.Length];
		}

		public static string getSingleRandomFrom(Table t)
		{
			return t[rand.Next() % t.Length];
		}

		public static string getMultipleRandomFrom(int numItems, string[] table)
		{
			string res = "";

			for (int i = 0; i < numItems; i++)
			{
				res += getSingleRandomFrom(table);

				if (i + 1 == numItems)
				{
					res += ", ";
				}
			}

			return res;
		}

		/// <summary>
		/// Returns a duplicate free copy of the table.
		/// Useful for displaying the raw values of a table.
		/// </summary>
		/// <param name="table"></param>
		/// <returns></returns>
		public static string getTableValues(string[] table)
		{
			string str = "";
			string dup = "";

			for (int i = 0; i < table.Length; i++)
			{
				if (table[i] != dup)
				{
					str += table[i] + "\n";
					dup = table[i];
				}
			}

			return str;
		}

		public static TableRow[] getTable(string[] table)
		{
			int start = 0;
			List<TableRow> list = new List<TableRow>();
			string entry = "";

			for (int i = 0; i < table.Length; i++)
			{
				if (entry != table[i])
				{
					entry = table[i];
					start = i + 1;

					while (i < table.Length && entry == table[i])
					{
						i++;
					}
				}

				if (start >= i)
				{
					list.Add(new TableRow(start, TableRow.EMPTY, entry));
				}
				else
				{
					list.Add(new TableRow(start, i, entry));
				}

				// look, it could be done better, i know
				// don't even @ me right now
				i--;
			}

			return list.ToArray();
		}

		// this version is used when getting a table that is split into
		// multiple parts, such as the Horn of Valhalla's table
		public static TableRow[] getTable(string[][] tables)
		{
			int start = 0;
			List<TableRow> list = new List<TableRow>();
			string entry = "";

			for (int i = 0; i < tables[0].Length; i++)
			{
				if (entry != tables[0][i])
				{
					entry = tables[0][i];
					start = i + 1;

					while (i < tables[0].Length && entry == tables[0][i])
					{
						i++;
					}
				}

				// get the entries in the other tables that match the row in current table
				string otherEntries = "";

				for (int j = 1; j < tables.Length; j++)
				{
					otherEntries += " " + tables[j][start - 1];
				}

				if (start >= i)
				{
					list.Add(new TableRow(start, TableRow.EMPTY, entry + otherEntries));
				}
				else
				{
					list.Add(new TableRow(start, i, entry + otherEntries));
				}

				// look, it could be done better, i know
				// don't even @ me right now
				i--;
			}

			return list.ToArray();
		}

		// this method returns a table as a single, [almost always] multiline string
		public static string getTableAsString(string[] table)
		{
			string res = "";

			TableRow[] rows = getTable(table);

			for (int i = 0; i < rows.Length; i++)
			{
				res += rows[i] + "\n";
			}

			return res;
		}

		public static string getTableAsString(string[][] table)
		{
			string res = "";

			TableRow[] rows = getTable(table);

			for (int i = 0; i < rows.Length; i++)
			{
				res += rows[i] + "\n";
			}

			return res;
		}

		public static void showTable(Table t)
		{
			MessageBox.Show(t.ToString(), t.Name);
		}

		#endregion Utilities

		#region Global

		public static readonly Table damage_type = new Table("Damage Type", new TableRow[]{
			new TableRow(1, -1, "Acid"),
			new TableRow(2, -1, "Bludgeoning"),
			new TableRow(3, -1, "Cold"),
			new TableRow(4, -1, "Fire"),
			new TableRow(5, -1, "Force"),
			new TableRow(6, -1, "Lightning"),
			new TableRow(7, -1, "Necrotic"),
			new TableRow(8, -1, "Piercing"),
			new TableRow(9, -1, "Poison"),
			new TableRow(10, -1, "Psychic"),
			new TableRow(11, -1, "Radiant"),
			new TableRow(12, -1, "Slashing"),
			new TableRow(13, -1, "Thunder"),
		});

		public enum Rarity
		{
			COMMON,
			UNCOMMON,
			RARE,
			VERYRARE,
			LEGENDARY
		}

		public enum Ideal
		{
			GOOD,
			EVIL,
			LAWFUL,
			CHAOTIC,
			NEUTRAL,
			OTHER
		}

		#endregion Global

		#region DMG

		// Chapter 1
		public static class World
		{
			public static readonly Table forms_of_government = new Table("Forms of Government", new TableRow[]{
				new TableRow(1, 8, "Autocracy"),
				new TableRow(9, 13, "Bureaucracy"),
				new TableRow(14, 19, "Confederacy"),
				new TableRow(20, 22, "Democracy"),
				new TableRow(23, 27, "Dictatorship"),
				new TableRow(28, 42, "Feudalism"),
				new TableRow(43, 44, "Gerontocracy"),
				new TableRow(45, 53, "Hierarchy"),
				new TableRow(54, 56, "Magocracy"),
				new TableRow(57, 58, "Matriarchy"),
				new TableRow(59, 64, "Militocracy"),
				new TableRow(65, 74, "Monarchy"),
				new TableRow(75, 78, "Oligarchy"),
				new TableRow(79, 80, "Patriarchy"),
				new TableRow(81, 83, "Meritocracy"),
				new TableRow(84, 85, "Plutocracy"),
				new TableRow(86, 92, "Republic"),
				new TableRow(93, 94, "Satrapy"),
				new TableRow(95, -1, "Kleptocracy"),
				new TableRow(96, 100, "Theocracy"),
			});

			public static readonly Table forms_of_government_explanation = new Table("Forms of Government Explanations", new TableRow[]{
				new TableRow(1, -1, "One hereditary ruler wields absolute power. The autocrat either is supported by a well-developed bureaucracy or military or stands as the only authority in an otherwise anarchic society. The dynastic ruler could be immortal or undead. Aundair and Karrnath, two kingdoms in the Eberron campaign setting, have autocrats with royal blood in their veins. Whereas Queen Aurala of Aundair relies on wizards and spies to enforce her will, Kaius, the vampire king of Karrnath, has a formidable army of living and undead soldiers under his command."),
				new TableRow(2, -1, "Various departments compsoe the government, each responsible for an aspect of rule. The department heads, ministers, or secretaries answer to a figurehead autocrat or council."),
				new TableRow(3, -1, "Each individual city or town within the confederacy governs itself, but all contribute to a league or federation that promotes (at least in theory) the common good of all member states. Conditions and attitudes toward the central government vary from place to place within the confederacy. The Lords' Alliance in the Forgotten Realms setting is a loose confederacy of cities, while the Mror Holds in the Eberron campaign setting is a confederacy of allied dwarf clans."),
				new TableRow(4, -1, "Citizens or their elected representatives determine the laws in a democracy. A bureaucracy or military carries out the day-to-day work of government, with positions filled through open elections."),
				new TableRow(5, -1, "One supreme ruler holds absolute authority, but his or her rule isn't necessarily dynastic. In other respects this resembles an autocracy. In the Greyhawk campaign setting, a half-demon named Iuz is the dictator of a conquered land that bears his name."),
				new TableRow(6, -1, "The typical government of Europe in the Middle Ages, a feudalistic society consists of layers of lords and vassals. The vassals provide soldiers or scutage (payment in lieu of military service) to the lords, who in turn promise protection to their vassals."),
				new TableRow(7, -1, "Elders preside over this society. In some cases, long-lived races such as elves or dragons are entrusted with the leadership of the land."),
				new TableRow(8, -1, "A feudal or bureaucratic government where every member, except one, is subordinate to another member. In the Draognlance campaign setting, the dragon armies of Krynn form a military hierarchy, with the Dragon Highlords as leaders under the dragon queen Takhisis."),
				new TableRow(9, -1, "This governemtn is composed of groups or individuals primarily seeking wealth for themselves, often at the expense of their subjects. The grasping Bandit Kingddoms in the Greyhawk campaign setting are prime examples. A kingdom run by thieves' guilds would also fall into this category."),
				new TableRow(10, -1, "The governing body is composed of spellcasters who rule directly as oligarchs or feudal lords, or participate in a democracy or bureaucracy. Examples include the Red Wizards of Thay in the Forgotten Realms campaign setting and the sorcerer-kings of Athas in the Dark Sun campaign setting."),
				new TableRow(11, -1, "This society is governed by the eldest or most important members of one gender. Drow cities are examples of theocratic matriarchies, for each is ruled by a council of drow high priestesses who answer to Lolth, the Demon Queen of Spiders."),
				new TableRow(12, -1, "The most intelligent and educated people oversee the society, often with a bureaucracy to handle the day-to-day work of government. In the Forgotten Realms, scholarly monks preside over the fortress-library of Candlekeep, overseen by a master of lore called the Keeper."),
				new TableRow(13, -1, "Military leaders run the nation under martial law, using the army and other armed forces. A militocracy might be based on an elite group of soldiers, an order of dragon riders, or a league of sea princes. Solamnia, a nation ruled by knights in the Dragonlance campaign setting, falls into this category."),
				new TableRow(14, -1, "A single hereditary sovereign wears the crown. Unlike the autocrat, the monarch's powers are limited by law, and the ruler serves as the head of a democracy, feudal state, or militocracy. The kingdom of Breland, in the Eberron campaign setting, has both a parliament that makes laws and a monarch who enforces them."),
				new TableRow(15, -1, "A small number of absolute rulers share power, possibly dividing the land into districts or provinces under their control, or jointly ruling together. A group of adventurers who take control of a nation together migth form an oligarchy. The Free City of Greyhawk is an oligarchy composed of various faction leaders, wit ha Lord Mayor as its figurehead."),
				new TableRow(16, -1, "Society is governed by the wealthy. The elite form a ruling council, purchase representation at the court of a figurehead monarch, or rule by default because money is the true power in the realm. Many cities in the Forgotten Realms campaign setting, includeing Waterdeep and Baldur's Gate, are plutocracies."),
				new TableRow(17, -1, "Government is entrusted to representatives of an established electorate who rule on behalf of the electors. Any democracy in which only landowners or certain classes can vote could be considered a republic."),
				new TableRow(18, -1, "Conquerors and representatives of another government wield power, ruling the settlement or region as part of a larger empire. The satraps are bureaucrats and military officers, or unusual characters or monsters. The cities of Highport and Suderham in the Greyhawk campaign setting are satrapies controlled by agents of a visious gane of marauders known as the Slave Lords."),
				new TableRow(19, -1, "Rulership falls to a direct representative or a collection of agents of a deity. The centers of power in a theocracy are usually located on sacred sites. In the Eberron campaign setting, the nation of Thrane is a theocracy devoted to the Silver Flame, a divine spirit that resides in Thrane's capital of Flamekeep."),
			});

			public static readonly Table world_shaking_events = new Table("World Shaking Events", new TableRow[]{
				new TableRow(1, -1, "Rise of a leader or an era"),
				new TableRow(2, -1, "Fall of a leader or an era"),
				new TableRow(3, -1, "Cataclysmic disaster"),
				new TableRow(4, -1, "Assault or invasion"),
				new TableRow(5, -1, "Rebellion, revolution, overthrow"),
				new TableRow(6, -1, "Extinction or depletion"),
				new TableRow(7, -1, "New organization"),
				new TableRow(8, -1, "Discovery, expansion, invention"),
				new TableRow(9, -1, "Prediction, omen, prophecy"),
				new TableRow(10, -1, "Myth and legend"),
			});

			public static readonly Table leader_types = new Table("Leader Types", new TableRow[]{
				new TableRow(1, -1, "Political"),
				new TableRow(2, -1, "Religious"),
				new TableRow(3, -1, "Military"),
				new TableRow(4, -1, "Crime/underworld"),
				new TableRow(5, -1, "Art/culture"),
				new TableRow(6, -1, "Philosophy/learning/magic"),
			});

			public static readonly Table cataclysmic_distasters = new Table("Cataclysmic Disasters", new TableRow[]{
				new TableRow(1, -1, "Earthquake"),
				new TableRow(2, -1, "Famin/drought"),
				new TableRow(3, -1, "Fire"),
				new TableRow(4, -1, "Flood"),
				new TableRow(5, -1, "Plauge/disease"),
				new TableRow(6, -1, "Rain of fire (meteoric impact)"),
				new TableRow(7, -1, "Storm (hurricane, tornado, tsunami)"),
				new TableRow(8, -1, "Volcanic eruption"),
				new TableRow(9, -1, "Magic gone awry or a planar warp"),
				new TableRow(10, -1, "Divine judgment"),
			});

			public static readonly Table invading_forces = new Table("Invading Forces", new TableRow[]{
				new TableRow(1, -1, "A criminal enterprise"),
				new TableRow(2, -1, "Monsters or a unique monster"),
				new TableRow(3, -1, "A planar threat"),
				new TableRow(4, -1, "A past adversary reawakened, reborn, or resurgent"),
				new TableRow(5, -1, "A splinter faction"),
				new TableRow(6, -1, "A savage tribe"),
				new TableRow(7, -1, "A secret society"),
				new TableRow(8, -1, "A traitorous ally"),
			});

			public static readonly Table extinction_or_depletion = new Table("Extinction or Depletion", new TableRow[]{
				new TableRow(1, -1, "A kind of animal (insect, bird, fish, livestock"),
				new TableRow(2, -1, "Habitable land"),
				new TableRow(3, -1, "Magic or magic-users (all magic, specific kinds, or schools of magic"),
				new TableRow(4, -1, "A mineral resource (gems, metals, ores)"),
				new TableRow(5, -1, "A type of monster (unicorn, manticore, dragon)"),
				new TableRow(6, -1, "A people (family line, clan, culture, race)"),
				new TableRow(7, -1, "A kind of plant(crop, tree, herb, forest)"),
				new TableRow(8, -1, "A waterway (river, lake, ocean"),
			});

			public static readonly Table new_organizations = new Table("New Organizations", new TableRow[]{
				new TableRow(1, -1, "Crime syndicate/bandit confederacy"),
				new TableRow(2, -1, "Guild (masons, apothecaries, goldsmiths)"),
				new TableRow(3, -1, "Magical circle/society"),
				new TableRow(4, -1, "Military/knightly order"),
				new TableRow(5, -1, "New family dynasty/tribe/clan"),
				new TableRow(6, -1, "Philosophy/discipline dedicated to a principle or ideal"),
				new TableRow(7, -1, "Realm (village, town, duchy, kingdom"),
				new TableRow(8, -1, "Religion/sect/denomination"),
				new TableRow(9, -1, "School/university"),
				new TableRow(10, -1, "Secret society/cult/cabal"),
			});

			public static readonly Table discoveries = new Table("Discoveries", new TableRow[]{
				new TableRow(1, -1, "Ancient ruin/lost city of a legendary race"),
				new TableRow(2, -1, "Animal/monster/magical mutation"),
				new TableRow(3, -1, "Invention/technology/magic (helpful, destructive)"),
				new TableRow(4, -1, "New (or forgotten) god or planar entity"),
				new TableRow(5, -1, "New (or rediscovered) artifact or religious relic"),
				new TableRow(6, -1, "New land (island, continent, lost world, demiplane)"),
				new TableRow(7, -1, "Otherworldly object (planar portal, alien spacecraft)"),
				new TableRow(8, -1, "People (race, tribe, lost civilization, colony)"),
				new TableRow(9, -1, "Plant (miracle herb, fungal parasite, sentient plant)"),
				new TableRow(10, -1, "Resource or wealth (gold, gems, mithral)"),
			});
		}

		// Chapter 2
		public static class Multiverse
		{
			public static readonly Table astral_color_pools_plane = new Table("Astral Color Pools - Plane", new TableRow[]{
				new TableRow(1, -1, "Ysgard"),
				new TableRow(2, -1, "Limbo"),
				new TableRow(3, -1, "Pandemonium"),
				new TableRow(4, -1, "The Abyss"),
				new TableRow(5, -1, "Carceri"),
				new TableRow(6, -1, "Hades"),
				new TableRow(7, -1, "Gehenna"),
				new TableRow(8, -1, "The Nine Hells"),
				new TableRow(9, -1, "Acheron"),
				new TableRow(10, -1, "Mechanus"),
				new TableRow(11, -1, "Arcadia"),
				new TableRow(12, -1, "Mount Celestia"),
				new TableRow(13, -1, "Bytopia"),
				new TableRow(14, -1, "Elysium"),
				new TableRow(15, -1, "The Beastlands"),
				new TableRow(16, -1, "Arborea"),
				new TableRow(17, -1, "The Outlands"),
				new TableRow(18, -1, "Ethereal Plane"),
				new TableRow(19, 20, "Material Plane"),
			});

			public static readonly Table astral_color_pools_pool_color = new Table("Astral Color Pools - Pool Color", new TableRow[]{
				new TableRow(1, -1, "Indigo"),
				new TableRow(2, -1, "Jet black"),
				new TableRow(3, -1, "Magenta"),
				new TableRow(4, -1, "Amethyst"),
				new TableRow(5, -1, "Olive"),
				new TableRow(6, -1, "Rust"),
				new TableRow(7, -1, "Russet"),
				new TableRow(8, -1, "Ruby"),
				new TableRow(9, -1, "Flame red"),
				new TableRow(10, -1, "Diamond blue"),
				new TableRow(11, -1, "Saffron"),
				new TableRow(12, -1, "Gold"),
				new TableRow(13, -1, "Amber"),
				new TableRow(14, -1, "Orange"),
				new TableRow(15, -1, "Emerald green"),
				new TableRow(16, -1, "Sapphire blue"),
				new TableRow(17, -1, "Leather brown"),
				new TableRow(18, -1, "Spiraling white"),
				new TableRow(19, 20, "Silver"),
			});

			public static readonly Table psychic_wind_effects_location_effect = new Table("Psychic Wind Effects - Location", new TableRow[]{
				new TableRow(1, 8, "Diverted; add 1d6 hours to travel time"),
				new TableRow(9, 12, "Blown off course; add 3d10 hours to travel time"),
				new TableRow(13, 16, "Lost; at the end of the travel time, characters arrive at a location other than the intended destination"),
				new TableRow(17, 20, "Sent through color pool to a random plane (roll on the Astral Color Pools table)"),
			});

			public static readonly Table psychic_wind_effects_mental_effects = new Table("Psychic Wind Effects - Mental Effects", new TableRow[]{
				new TableRow(1, 8, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"),
				new TableRow(9, 10, "Short-term madness (see chapter 8)"),
				new TableRow(11, 12, "11 (2d10) psychic damage"),
				new TableRow(13, 16, "22 (4d10) psychic damage"),
				new TableRow(17, 18, "Long-term madness (see chapter 8)"),
				new TableRow(19, 20, "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake"),
			});

			public static readonly Table ethereal_curtains_plane = new Table("Ethereal Curtains - Plane", new TableRow[]{
				new TableRow(1, -1, "Material Plane"),
				new TableRow(2, -1, "Shadowfell"),
				new TableRow(3, -1, "Feywild"),
				new TableRow(4, -1, "Plane of Air"),
				new TableRow(5, -1, "Plane of Earth"),
				new TableRow(6, -1, "Plane of Fire"),
				new TableRow(7, -1, "Plane of Water"),
				new TableRow(8, -1, "Elemental Chaos"),
			});

			public static readonly Table ethereal_curtains_color_of_curtain = new Table("Ethereal Curtains - Color of Curtain", new TableRow[]{
				new TableRow(1, -1, "Bright turquoise"),
				new TableRow(2, -1, "Dusky gray"),
				new TableRow(3, -1, "Opulescent white"),
				new TableRow(4, -1, "Pale blue"),
				new TableRow(5, -1, "Reddish-brown"),
				new TableRow(6, -1, "Orange"),
				new TableRow(7, -1, "Green"),
				new TableRow(8, -1, "Swirling mix of colors"),
			});

			public static readonly Table ether_cyclone = new Table("Ether Cyclone", new TableRow[]{
				new TableRow(1, 12, "Extended journey"),
				new TableRow(13, 19, "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table"),
				new TableRow(20, -1, "Hurled into the Astral Plane"),
			});

			public static readonly Table feywild_time_warp = new Table("Feywild Time Warp", new TableRow[]{
				new TableRow(1, 2, "Days become minutes"),
				new TableRow(3, 6, "Days become hours"),
				new TableRow(7, 13, "No change"),
				new TableRow(14, 17, "Days become weeks"),
				new TableRow(18, 19, "Days become months"),
				new TableRow(20, -1, "Days become years"),
			});

			public static readonly Table shadowfell_despair = new Table("Shadowfell Despair", new TableRow[]
			{
				new TableRow(1, 3, "Apathy. The character has disadvantage on death saving throws and on Dexterity checks for initiative, and gains the following flaw: \"I don't believe I can make a difference to anyone or anything.\""),
				new TableRow(4, 5, "Dread. The character has disadvantage on all saving throws and gains the following flaw: \"I am convinced that this place is going to kill me.\""),
				new TableRow(6, -1, "Madness. The character has disadvantage on ability checks and saving throws that use Intelligence, Wisdom, or Charisma, and gains the following flaw: \"I can't tell what's real anymore\"")
			});

			public static string getPsychicWindEffectsLocationEffect()
			{
				int num = Data.rand.Next() % 20 + 1;

				if (num < 9)
				{
					return "Diverted; add " + ((rand.Next() % 6) + 1) + " hours to travel time";
				}
				else if (num < 13)
				{
					return "Blown off course; add " + (((rand.Next() % 10) + 1) * 3) + " hours to travel time";
				}
				else if (num < 17)
				{
					return "Lost; at the end of the travel time, characters arrive at a location other than the intended destination";
				}
				else
				{
					num = rand.Next() % astral_color_pools_plane.Length;

					string str = "";

					if (num > 16)
					{
						str = "the ";
					}

					return "Sent through color pool to " + str + astral_color_pools_plane[rand.Next() % astral_color_pools_plane.Length];
				}
			}

			public static string getPsychicWindEffectsMentalEffect()
			{
				int num = Data.rand.Next() % 20 + 1;

				if (num < 9)
				{
					return "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself";
				}
				else if (num < 11)
				{
					return "Short-term madness";
				}
				else if (num < 13)
				{
					return "11 (2d10) psychic damage";
				}
				else if (num < 17)
				{
					return "22 (4d10) psychic damage";
				}
				else if (num < 19)
				{
					return "Long-term madness";
				}
				else
				{
					return "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake";
				}
			}

			public static string getEtherCyclone()
			{
				int num = Data.rand.Next() % 20 + 1;

				if (num < 13)
				{
					return "Extended journey";
				}
				else if (num < 20)
				{
					return "Blown to the Border Ethereal of the " + ethereal_curtains_plane[rand.Next() % ethereal_curtains_plane.Length].Entry;
				}
				else
				{
					return "Hurled into the Astral Plane";
				}
			}

			public static string getAbyssalCorruption()
			{
				int num = Data.rand.Next() % 10 + 1;

				if (num < 5)
				{
					return "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\"";
				}
				else if (num < 8)
				{
					return "Bloodlust. The character gains the following flaw: \"I enjoy killing for its own sake, and once I start, it's hard to stop\"";
				}
				else if (num < 10)
				{
					return "Mad Ambition. The character gains the following flaw: \"I am destined to rule the Abyss, and my companions are tools to that end\"";
				}
				else
				{
					return "Demonic Possession. The character is possessed by a demonic entity until freed by dispel evil and good or similar magic. Whenever the possessed " +
						"character rolls a 1 on an attack roll, ability check, or saving throw, the demon takes control of the character and determines the character's behavior. " +
						"At the end of each of the possessed character's turns, he or she can make a DC 15 Charisma saving throw. On a success, the character regains control until he or she rolls another 1.";
				}
			}
		}

		// Chapter 3
		public static class Adventures
		{

			public static readonly Table dungeon_goals = new Table("Dungeon Goals", new TableRow[]{
				new TableRow(1, -1, "Stop the dungeon's monstrous inhabitants from raiding the surface world."),
				new TableRow(2, -1, "Foil a villain's evil scheme."),
				new TableRow(3, -1, "Destroy a magical threat inside the dungeon."),
				new TableRow(4, -1, "Acquire treasure."),
				new TableRow(5, -1, "Find a particular item for a specific purpose."),
				new TableRow(6, -1, "Retrieve a stolen item hidden in the dungeon."),
				new TableRow(7, -1, "Find information needed for a special purpose."),
				new TableRow(8, -1, "Rescue a captive."),
				new TableRow(9, -1, "Discover the fate of a previous adventuring party."),
				new TableRow(10, -1, "Find an NPC who disappeared in the area."),
				new TableRow(11, -1, "Slay a dragon or some other challenging monster."),
				new TableRow(12, -1, "Discover the nature and origin of a strange location or phenomenon."),
				new TableRow(13, -1, "Pursue fleeing foes taking refuge in the dungeon."),
				new TableRow(14, -1, "Escape from captivity in the dungeon."),
				new TableRow(15, -1, "Clear a ruin so it can be rebuilt and reoccupied."),
				new TableRow(16, -1, "Discover why a villain is interested in the dungeon."),
				new TableRow(17, -1, "Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time."),
				new TableRow(18, -1, "Parley with a villain in the dungeon."),
				new TableRow(19, -1, "Hide from a threat outside the dungeon."),
				new TableRow(20, -1, "Roll twice, ignoring results of 20."),
			});

			public static readonly Table wilderness_goals = new Table("Wilderness Goals", new TableRow[]{
				new TableRow(1, -1, "Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why)."),
				new TableRow(2, -1, "Assess the scope of a natural or unnatural disaster."),
				new TableRow(3, -1, "Escort an NPC to a destination."),
				new TableRow(4, -1, "Arrive at a destination without being seen by the villain's forces."),
				new TableRow(5, -1, "Stop monsters from raiding caravans and farms."),
				new TableRow(6, -1, "Establish trade with a distant town."),
				new TableRow(7, -1, "Map a new land."),
				new TableRow(8, -1, "Find a place to establish a colony"),
				new TableRow(9, -1, "Find a natural resource"),
				new TableRow(10, -1, "Hunt a specific monster."),
				new TableRow(11, -1, "Return home from a distant place."),
				new TableRow(12, -1, "Obtain information from a reclusive hermit."),
				new TableRow(13, -1, "Find an object that was lost in the wilds."),
				new TableRow(14, -1, "Discover the fate of a missing group of explorers."),
				new TableRow(15, -1, "Pursue fleeing foes."),
				new TableRow(16, -1, "Assess the size of an approaching army."),
				new TableRow(17, -1, "Escape the reign of a tyrant."),
				new TableRow(18, -1, "Protect a wilderness site from attackers."),
				new TableRow(19, -1, "Roll twice, ignoring results of 20."),
			});

			public static readonly Table other_goals = new Table("Other Goals", new TableRow[]{
				new TableRow(1, -1, "Seize control of a fortified location such as a fortress, town, or ship."),
				new TableRow(2, -1, "Defend a location from attackers."),
				new TableRow(3, -1, "Retrieve an object from inside a secure location in a settlement."),
				new TableRow(4, -1, "Retrieve an object from a caravan."),
				new TableRow(5, -1, "Salvage an object or goods from a lost vessel or caravan."),
				new TableRow(6, -1, "Break a prisoner out of a jail or prison camp."),
				new TableRow(7, -1, "Escape from a jail or prison camp."),
				new TableRow(8, -1, "Successfully travel through an obstacle course to gain recognition or reward."),
				new TableRow(9, -1, "Infiltrate a fortified location."),
				new TableRow(10, -1, "Find the source of strange occurrences in a haunted house or other location."),
				new TableRow(11, -1, "Interfere wit hthe operation of a business."),
				new TableRow(12, -1, "Rescue a character, monster, or object from a natural or unnatural disaster."),
			});

			public static readonly Table adventure_villains = new Table("Adventure Villains", new TableRow[]{
				new TableRow(1, -1, "Beast or monstrosity with no particular agenda"),
				new TableRow(2, -1, "Aberration bent on corruption or domination"),
				new TableRow(3, -1, "Fiend bent on corruption or destruction"),
				new TableRow(4, -1, "Dragon bent on domination and plunder"),
				new TableRow(5, -1, "Giant bend on plunder"),
				new TableRow(6, 7, "Undead with any agenda"),
				new TableRow(8, -1, "Fey with a mysterious goal"),
				new TableRow(9, 10, "Humanoid cultist"),
				new TableRow(11, 12, "Humanoid conqueror"),
				new TableRow(13, -1, "Humanoid seeking revenge"),
				new TableRow(14, 15, "Humanoid schemer seeking to rule"),
				new TableRow(16, -1, "Humanoid criminal mastermind"),
				new TableRow(17, 18, "Humanoid raider or ravager"),
				new TableRow(19, -1, "Humanoid under a curse"),
				new TableRow(20, -1, "Misguided humanoid zealot"),
			});

			public static readonly Table adventure_allies = new Table("Adventure Allies", new TableRow[]{
				new TableRow(1, -1, "Skilled adventurer"),
				new TableRow(2, -1, "Inexperienced adventurer"),
				new TableRow(3, -1, "Enthusiastic commoner"),
				new TableRow(4, -1, "Soldier"),
				new TableRow(5, -1, "Priest"),
				new TableRow(6, -1, "Sage"),
				new TableRow(7, -1, "Revenge seeker"),
				new TableRow(8, -1, "Raving lunatic"),
				new TableRow(9, -1, "Celestial ally"),
				new TableRow(10, -1, "Fey ally"),
				new TableRow(11, -1, "Disguised monster"),
				new TableRow(12, -1, "Villain posing as an ally"),
			});

			public static readonly Table adventure_patrons = new Table("Adventure Patrons", new TableRow[]{
				new TableRow(1, 2, "Retired adventurer"),
				new TableRow(3, 4, "Local ruler"),
				new TableRow(5, 6, "Military officer"),
				new TableRow(7, 8, "Temple official"),
				new TableRow(9, 10, "Sage"),
				new TableRow(11, 12, "Respected elder"),
				new TableRow(13, -1, "Deity or celestial"),
				new TableRow(14, -1, "Mysterious fey"),
				new TableRow(15, -1, "Old friend"),
				new TableRow(16, -1, "Former teacher"),
				new TableRow(17, -1, "Parent or other family member"),
				new TableRow(18, -1, "Desperate commoner"),
				new TableRow(19, -1, "Embattled merchant"),
				new TableRow(20, -1, "Villain posing as a patron"),
			});

			public static readonly Table adventure_introduction = new Table("Adventure Introduction", new TableRow[]{
				new TableRow(1, -1, "While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location."),
				new TableRow(2, -1, "While traveling in the wilderness, the characters notice the entrance to the adventure location."),
				new TableRow(3, -1, "While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location."),
				new TableRow(4, -1, "The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map."),
				new TableRow(5, -1, "A mysterious magic item or a cruel villain teleports the characters to the adventure location"),
				new TableRow(6, -1, "A stranger approaches the characters in a tavern and urges them toward the adventure location."),
				new TableRow(7, -1, "A town or village needs volunteers to go to the adventure location."),
				new TableRow(8, -1, "An NPC the characters care about needs them to go to the adventure location."),
				new TableRow(9, -1, "An NPC the characters must obey orders them to go to the adventure location."),
				new TableRow(10, -1, "An NPC the characters respect asks them to go to the adventure location."),
				new TableRow(11, -1, "One night, the characters all dream about entering the adventure location."),
				new TableRow(12, -1, "A ghost appears and terrorizes a village. Research reveals that it can be put to rest only by entering the adventure location."),
			});

			public static readonly Table adventure_climax = new Table("Adventure Climax", new TableRow[]{
				new TableRow(1, -1, "The adventurers confront the main villain and a group of minions in a bloody battle to the finish."),
				new TableRow(2, -1, "The adventurers chase the villain while dodgin obstacles designed to thwart them, leading to a final confrontation in or outside the villain's refuge."),
				new TableRow(3, -1, "The actions of the adventurers or the villain result in a cataclysmic event that the adventurers must escape."),
				new TableRow(4, -1, "The adventurers race to the site where the villain is bringing a master plan to its conclusion, arriving just as that plan is about to be completed."),
				new TableRow(5, -1, "The villain and two or three lieutenants perform separate rites in a large room. The adventurers must disrupt all the rites at the same time."),
				new TableRow(6, -1, "An ally betrays the adventurers as they're about to achieve their goal (Use this climax carefully, and don't overuse it)."),
				new TableRow(7, -1, "A portal opens to another plane of existence. Creatures on the other side spill out, forcing the adventurers to close the portal and deal with the villain at the same time."),
				new TableRow(8, -1, "Traps, hazards, or animated objects turn against the adventurers while the main villain attacks."),
				new TableRow(9, -1, "The dungeon begins to collapse while the adventurers face the main villain, who attempts to escape in the chaos."),
				new TableRow(10, -1, "A threat more powerful than the adventurers appears, destroys the main villain, and then turns its attention on the characters."),
				new TableRow(11, -1, "The adventurers must choose whether to pursue the fleeing main villain or save an NPC they care about or a group of innocents."),
				new TableRow(12, -1, "The adventurers must discover the main villain's secret weakness before they can hope to defeat that villain."),
			});

			public static readonly Table event_based_villain_actions = new Table("Event Based Villain Actions", new TableRow[]{
				new TableRow(1, -1, "Big event"),
				new TableRow(2, -1, "Crime spree"),
				new TableRow(3, -1, "Growing corruption"),
				new TableRow(4, -1, "One and done"),
				new TableRow(5, -1, "Serial crimes"),
				new TableRow(6, -1, "Step by step"),
			});

			public static readonly Table event_based_villain_actions_descriptions = new Table("Event Based Villain Actions - Descriptions", new TableRow[]{
				new TableRow(1, -1, "Big Event. The villain's plans come to fruition during a festival, an astrological event, a holy (or unholy) rite, a royal wedding, the birth of a child, or some similar fixed time. The villain's activities up to that point are geared toward preparation for this event."),
				new TableRow(2, -1, "Crime Spree. The villain commits acts taht become bolder and more heinous over time. A killer might start out by targeting the destitute in the city slums before moving up to a massacre in the marketplace, increasing the horror and the body count each time."),
				new TableRow(3, -1, "Growing Corruption. As time passes, the villain's power and influence grow, affecting more victims across a larger area. This might take the form of armies conquering new territory, an evil cult recruiting new members, or a spreading plague. A pretender to the throne might attempt to secure the support of the kingdom's nobility in the days or weeks leading up to a coup, or a guild leader could corrupt the members of a town council or bribe officers of the watch."),
				new TableRow(4, -1, "One and Done. The villain commits a single crime and then tries to avoid the consequences. Instead of an ongoing plan to commit more crimes, the villain's goal is to lie low or flee the scene."),
				new TableRow(5, -1, "Serial Crimes. The villain commits crimes one after the other, but these acts are repetitive in nature, rather than escalating to greater heights of depravity. The trick to catching such a villain lies in determining the pattern underlying the crimes. Though serial killers are a common example of this type of villain, your villain could be a serial arsonist favoring a certain type of building, a magical sickness that affects spellcasters who cast a specific spell, a thief that targets a certain kind of merchant, or a doppelganger kidnapping and impersonating one noble after another."),
				new TableRow(6, -1, "Step by Step. In pursuit of its goal, the villain carries out a specific set of actions in a particular sequence. A wizard might steal the items needed to create a phylactery and become a lich, or a cultist might kidnap the priests of seven good-aligned gods as a sacrifice. Alternativly, the villain could be following a trail to find the object of its revenge, killing one victim after another while moving ever closer to the real target."),
			});

			public static readonly Table event_based_goals = new Table("Event Based Goals", new TableRow[]{
				new TableRow(1, -1, "Bring the villain to justice."),
				new TableRow(2, -1, "Clear the name of an innocent NPC."),
				new TableRow(3, -1, "Protect or hide an NPC."),
				new TableRow(4, -1, "Protect an object."),
				new TableRow(5, -1, "Discover the nature and origin of a strange phenomenon that might be the villain's doing."),
				new TableRow(6, -1, "Find a wanted fugitive."),
				new TableRow(7, -1, "Overthrow a tyrant"),
				new TableRow(8, -1, "Uncover a conspiracy to overthrow a ruler."),
				new TableRow(9, -1, "Negotiate peace between enemy nations or feuding families."),
				new TableRow(10, -1, "Secure aid from a ruler or council."),
				new TableRow(11, -1, "Help a villain find redemption"),
				new TableRow(12, -1, "Parley with a villain."),
				new TableRow(13, -1, "Smuggle weapons to rebel forces."),
				new TableRow(14, -1, "Stop a band of smugglers."),
				new TableRow(15, -1, "Gather intelligence on an enemy force."),
				new TableRow(16, -1, "Win a tournament"),
				new TableRow(17, -1, "Determine the villain's identity."),
				new TableRow(18, -1, "Locate a stolen item."),
				new TableRow(19, -1, "Make sure a wedding goes off without a hitch."),
				new TableRow(20, -1, "Roll twice, ignoring results of 20."),
			});

			public static readonly Table framing_events = new Table("Framing Events", new TableRow[]{
				new TableRow(1, 2, "Anniversary of a monarch's reign"),
				new TableRow(3, 4, "Anniversary of an important event"),
				new TableRow(5, 6, "Arena event"),
				new TableRow(7, 8, "Arrival of a caravan or ship"),
				new TableRow(9, 10, "Arrival of a circus"),
				new TableRow(11, 12, "Arrival of an important NPC"),
				new TableRow(13, 14, "Arrival of marching modrons"),
				new TableRow(15, 16, "Artistic performance"),
				new TableRow(17, 18, "Athletic event"),
				new TableRow(19, 20, "Birth of a child"),
				new TableRow(21, 22, "Birthday of an important NPC"),
				new TableRow(23, 24, "Civic festival"),
				new TableRow(25, 26, "Comet appearance"),
				new TableRow(27, 28, "Commemoration of a past tragedy"),
				new TableRow(29, 30, "Consecration of a new temple"),
				new TableRow(31, 32, "Coronation"),
				new TableRow(33, 34, "Council meeting"),
				new TableRow(35, 36, "Equinox or solstice"),
				new TableRow(37, 38, "Execution"),
				new TableRow(39, 40, "Fertility festival"),
				new TableRow(41, 42, "Full moon"),
				new TableRow(43, 44, "Funeral"),
				new TableRow(45, 46, "Graduation of cadets or wizards"),
				new TableRow(47, 48, "Harvest festival"),
				new TableRow(49, 50, "Holy day"),
				new TableRow(51, 52, "Investiture of a knight or other noble"),
				new TableRow(53, 54, "Lunar eclipse"),
				new TableRow(55, 58, "Midsummer festival"),
				new TableRow(59, 60, "Midwinter festival"),
				new TableRow(61, 62, "Migration of monsters"),
				new TableRow(63, 64, "Monarch's ball"),
				new TableRow(65, 66, "New moon"),
				new TableRow(67, 68, "New year"),
				new TableRow(69, 70, "Pardoning of a prisoner"),
				new TableRow(71, 72, "Planar conjunction"),
				new TableRow(73, 74, "Planetary alignment"),
				new TableRow(75, 76, "Priestly investiture"),
				new TableRow(77, 78, "Procession of ghosts"),
				new TableRow(79, 80, "Remembrance for soldiers lost in war"),
				new TableRow(81, 82, "Royal address or proclamation"),
				new TableRow(83, 84, "Royal audience day"),
				new TableRow(85, 86, "Signing a treaty"),
				new TableRow(87, 88, "Solar eclipse"),
				new TableRow(89, 91, "Tournament"),
				new TableRow(92, 94, "Trial"),
				new TableRow(95, 96, "Violent uprising"),
				new TableRow(97, 98, "Wedding or wedding anniversary"),
				new TableRow(99, 100, "Concurrence of two events (roll twice, ignoring results of 99 or 100)"),
			});

			public static readonly Table moral_quandaries = new Table("Moral Quandaries", new TableRow[]{
				new TableRow(1, 3, "Ally quandary"),
				new TableRow(4, 6, "Friend quandary"),
				new TableRow(7, 12, "Honor quandary"),
				new TableRow(13, 16, "Rescue quandary"),
				new TableRow(17, 20, "Respect quandary"),
			});

			public static readonly Table moral_quandaries_descriptions = new Table("Moral Quandaries - Descriptions", new TableRow[]{
				new TableRow(1, -1, "Ally Quandary. The adventurers have a better chance of achieving their goal with the help of two individuals whose expertise is all but essential. However, these two NPCs hate each other and refuse to work together even if the fate of the world hangs in the balance. The adventurers must choose the NPC that is most likely to help them accomplish their goal."),
				new TableRow(2, -1, "Friend Quandary. An NPC that one or more of the characters cares about makes an impossible demand on the characters. A love interest might demand that a character turn away from a dangerous quest. A dear friend might plead with the characters to spare the villain's life, to prove that they are better than the villain. A weak NPC might beg for a chance to win favor from the characters by undertaking a dangerous but essential mission."),
				new TableRow(3, -1, "Honor Quandary. A character is forced to choose between victory and a personal oath or code of honor. A paladin who has sworn the Oath of Virtue might realize that the clearest path to success lies in deceit and subterfuge. A loyal cleric might be tempted to disobey the orders of his or her faith. If you present this quandary, be sure to provide an opportunity for a character to atone for violating his or her oath."),
				new TableRow(4, -1, "Rescure Quandary. The adventurers must choose between catching or hurting the villain and saving innocent lives. For example, the adventurers might learn that the villain is camped nearby, but they also learn that another part of the villain's forces is about to march into a village and burn it to the ground. The characters must choose between taking out the villain or protecting innocent villagers, some of whom might be friends or family members."),
				new TableRow(5, -1, "Respect Quandary. Two important allies give conflicting directions or advice to the adventurers. Perhaps the high priest counsels the characters to negotiate peace with militaristic elves in the nearby forest, while a veteran warrior urges them to prove their strength with a decisive first strike. The adventurers can't follow both courses, and whichever ally they choose, the other loses respect for them and might no longer aid them."),
			});

			public static readonly Table twist = new Table("Twist", new TableRow[]{
				new TableRow(1, -1, "The adventurers are racing against other creatures with the same or opposite goal."),
				new TableRow(2, -1, "The adventurers become responsible for the safety of a noncombatant NPC."),
				new TableRow(3, -1, "The adventurers are prohibited from killing the villain, but the villain has no compunctions about killing them."),
				new TableRow(4, -1, "The adventurers have a time limit."),
				new TableRow(5, -1, "The adventurers have received false or extraneous information."),
				new TableRow(6, -1, "Completing an adventure goal fulfills a prophecy or prevents the fulfillment of a prophecy."),
				new TableRow(7, -1, "The adventurers have two different goals, but they can complete only one."),
				new TableRow(8, -1, "Completing the goal secretly helps the villain."),
				new TableRow(9, -1, "The adventurers must cooperate with a known enemy to achieve the goal."),
				new TableRow(10, -1, "The adventurers are under magical compulsion (such as a geas spell) to complete their goal."),
			});

			public static readonly Table side_quests = new Table("Side Quests", new TableRow[]{
				new TableRow(1, -1, "Find a specific item rumored to be in the area."),
				new TableRow(2, -1, "Retrieve a stolen item in the villain's possession"),
				new TableRow(3, -1, "Receive information from an NPC in the area."),
				new TableRow(4, -1, "Rescue a captive."),
				new TableRow(5, -1, "Discover the fate of a missing NPC."),
				new TableRow(6, -1, "Slay a specific monster."),
				new TableRow(7, -1, "Discover the nature and origin of a strange phenomenon in the area."),
				new TableRow(8, -1, "Secure the aid of a character or creature in the area."),
			});

			public static string getDungeonGoal()
			{
				int num = Data.rand.Next() % dungeon_goals.Length;

				if (num == 19)
				{
					num = Data.rand.Next() % (dungeon_goals.Length - 1);

					return dungeon_goals[Data.rand.Next() % (dungeon_goals.Length - 1)] + " and " +
						dungeon_goals[num].Entry.ToLower();
				}

				return dungeon_goals[num];
			}

			public static string getWildernessGoal()
			{
				int num = Data.rand.Next() % wilderness_goals.Length;

				num = 0;

				if (num == 0)
				{
					string dg = getDungeonGoal().ToLower();

					return "Locate a dungeon or other site of interest to " + dg;
				}

				if (num == 19)
				{
					num = Data.rand.Next() % (wilderness_goals.Length - 1);

					string[] strs = { "", "" };

					for (int i = 0; i < 2; i++)
					{
						num = Data.rand.Next() % (wilderness_goals.Length - 1);

						if (num == 0)
						{
							strs[i] = getDungeonGoal().ToLower();
							strs[i] = "Locate a dungeon or other site of interest to " + strs[i];
						}
						else
						{
							strs[i] = wilderness_goals[num];
						}
					}

					return strs[0] + " " + strs[1];
				}

				return wilderness_goals[num];
			}

			public static string getEventBasedGoals()
			{
				int num = Data.rand.Next() % dungeon_goals.Length;

				if (num == 19)
				{
					num = Data.rand.Next() % (dungeon_goals.Length - 1);

					return event_based_goals[Data.rand.Next() % (event_based_goals.Length - 1)] + " and " +
						event_based_goals[num].Entry.ToLower();
				}

				return event_based_goals[num];
			}

			public static string getFramingEvents()
			{
				int num = Data.rand.Next() % framing_events.Length;

				if (num > framing_events.Length - 3)
				{
					num = Data.rand.Next() % (framing_events.Length - 2);
					
					return framing_events[Data.rand.Next() % (framing_events.Length - 2)] + " and " +
						framing_events[num].Entry.ToLower();
				}

				return framing_events[num];
			}
		}

		// Chapter 4
		public static class NPC
		{
			public static readonly Table npc_appearance = new Table("NPC Appearance", new TableRow[]{
				new TableRow(1, -1, "Distinctive jewelry: earrings, necklace, circlet, bracelets"),
				new TableRow(2, -1, "Piercings"),
				new TableRow(3, -1, "Flamboyant or outlandish clothes"),
				new TableRow(4, -1, "Formal, clean clothes"),
				new TableRow(5, -1, "Ragged, dirty clothes"),
				new TableRow(6, -1, "Pronounced scar"),
				new TableRow(7, -1, "Missing teeth"),
				new TableRow(8, -1, "Missing fingers"),
				new TableRow(9, -1, "Unusual eye color (or two different colors)"),
				new TableRow(10, -1, "Tattoos"),
				new TableRow(11, -1, "Birthmark"),
				new TableRow(12, -1, "Unusual skin color"),
				new TableRow(13, -1, "Bald"),
				new TableRow(14, -1, "Braided beard or hair"),
				new TableRow(15, -1, "Unusual hair color"),
				new TableRow(16, -1, "Nervous eye twitch"),
				new TableRow(17, -1, "Distinctive nose"),
				new TableRow(18, -1, "Distinctive posture (crooked or rigid)"),
				new TableRow(19, -1, "Exceptionally beautiful"),
				new TableRow(20, -1, "Exceptionally ugly"),
			});

			public static readonly Table npc_high_abilities = new Table("NPC High Abilities", new TableRow[]{
				new TableRow(1, -1, "Strength - powerful, brawny, strong as an ox"),
				new TableRow(2, -1, "Dexterity - lithe, agile, graceful"),
				new TableRow(3, -1, "Constitution - hardy, hale, healthy"),
				new TableRow(4, -1, "Intelligence - studious, learned, inquisitive"),
				new TableRow(5, -1, "Wisdom - perceptive, spiritual, insightful"),
				new TableRow(6, -1, "Charisma - persuasive, forceful, born leader"),
			});

			public static readonly Table npc_low_abilities = new Table("NPC Low Abilities", new TableRow[]{
				new TableRow(1, -1, "Strength - feeble, scrawny"),
				new TableRow(2, -1, "Dexterity - clumsy, fumbling"),
				new TableRow(3, -1, "Constitution - sickly, pale"),
				new TableRow(4, -1, "Intelligence - dim-witted, slow"),
				new TableRow(5, -1, "Wisdom - oblivious, absentminded"),
				new TableRow(6, -1, "Charisma - dull, boring"),
			});

			public static readonly Table npc_talents = new Table("NPC Talents", new TableRow[]{
				new TableRow(1, -1, "Plays a musical instrument"),
				new TableRow(2, -1, "Speaks several languages fluently"),
				new TableRow(3, -1, "Unbelievably lucky"),
				new TableRow(4, -1, "Perfect memory"),
				new TableRow(5, -1, "Great with animals"),
				new TableRow(6, -1, "Great with children"),
				new TableRow(7, -1, "Great at solving puzzles"),
				new TableRow(8, -1, "Great at one game"),
				new TableRow(9, -1, "Great at impersonations"),
				new TableRow(10, -1, "Draws beautifully"),
				new TableRow(11, -1, "Sings beautifully"),
				new TableRow(12, -1, "Drinks everyone under the table"),
				new TableRow(13, -1, "Expert carpenter"),
				new TableRow(14, -1, "Expert cook"),
				new TableRow(15, -1, "Expert dart thrower and rock skipper"),
				new TableRow(16, -1, "Expert juggler"),
				new TableRow(17, -1, "Skilled acto and master of disguise"),
				new TableRow(18, -1, "Skilled dancer"),
				new TableRow(19, -1, "Knows thieves' cant"),
			});

			public static readonly Table npc_mannerisms = new Table("NPC Mannerisms", new TableRow[]{
				new TableRow(1, -1, "Prone to singing, whistling, or humming quietly"),
				new TableRow(2, -1, "Speaks in rhyme or some other peculiar way"),
				new TableRow(3, -1, "Particularly low or high voice"),
				new TableRow(4, -1, "Slurs words, lisps, or stutters"),
				new TableRow(5, -1, "Enunciates overly clearly"),
				new TableRow(6, -1, "Speaks loudly"),
				new TableRow(7, -1, "Whispers"),
				new TableRow(8, -1, "Uses flowery speech or long words"),
				new TableRow(9, -1, "Frequently uses the wrong word"),
				new TableRow(10, -1, "Uses colorful oaths and exclamations"),
				new TableRow(11, -1, "Makes constant jokes or puns"),
				new TableRow(12, -1, "Prone to predictions of doom"),
				new TableRow(13, -1, "Fidgets"),
				new TableRow(14, -1, "Squints"),
				new TableRow(15, -1, "Stares into the distance"),
				new TableRow(16, -1, "Chews something"),
				new TableRow(17, -1, "Paces"),
				new TableRow(18, -1, "Taps fingers"),
				new TableRow(19, -1, "Bites fingernails"),
				new TableRow(20, -1, "Twirls hair or tugs beard"),
			});

			public static readonly Table npc_interaction_traits = new Table("NPC Interactions Traits", new TableRow[]{
				new TableRow(1, -1, "Argumentative"),
				new TableRow(2, -1, "Arrogant"),
				new TableRow(3, -1, "Blustering"),
				new TableRow(4, -1, "Rude"),
				new TableRow(5, -1, "Curious"),
				new TableRow(6, -1, "Friendly"),
				new TableRow(7, -1, "Honest"),
				new TableRow(8, -1, "Hot tempered"),
				new TableRow(9, -1, "Irritable"),
				new TableRow(10, -1, "Ponderous"),
				new TableRow(11, -1, "Quiet"),
				new TableRow(12, -1, "Suspicious"),
			});

			public static readonly Table npc_ideals_good = new Table("NPC Ideals Good", new TableRow[]{
				new TableRow(1, -1, "Beauty"),
				new TableRow(2, -1, "Charity"),
				new TableRow(3, -1, "Greater good"),
				new TableRow(4, -1, "Life"),
				new TableRow(5, -1, "Respect"),
				new TableRow(6, -1, "Self-sacrifice"),
			});

			public static readonly Table npc_ideals_evil = new Table("NPC Ideals Evil", new TableRow[]{
				new TableRow(1, -1, "Domination"),
				new TableRow(2, -1, "Greed"),
				new TableRow(3, -1, "Might"),
				new TableRow(4, -1, "Pain"),
				new TableRow(5, -1, "Retribution"),
				new TableRow(6, -1, "Slaughter"),
			});

			public static readonly Table npc_ideals_lawful = new Table("NPC Ideals Lawful", new TableRow[]{
				new TableRow(1, -1, "Community"),
				new TableRow(2, -1, "Fairness"),
				new TableRow(3, -1, "Honor"),
				new TableRow(4, -1, "Logic"),
				new TableRow(5, -1, "Responsibility"),
				new TableRow(6, -1, "Tradition"),
			});

			public static readonly Table npc_ideals_chaotic = new Table("NPC Ideals Chaotic", new TableRow[]{
				new TableRow(1, -1, "Change"),
				new TableRow(2, -1, "Creativity"),
				new TableRow(3, -1, "Freedom"),
				new TableRow(4, -1, "Independence"),
				new TableRow(5, -1, "No limits"),
				new TableRow(6, -1, "Whimsy"),
			});

			public static readonly Table npc_ideals_neutral = new Table("NPC Ideals Neutral", new TableRow[]{
				new TableRow(1, -1, "Balance"),
				new TableRow(2, -1, "Knowledge"),
				new TableRow(3, -1, "Live and let live"),
				new TableRow(4, -1, "Moderation"),
				new TableRow(5, -1, "Neutrality"),
				new TableRow(6, -1, "People"),
			});

			public static readonly Table npc_ideals_other = new Table("NPC Ideals Other", new TableRow[]{
				new TableRow(1, -1, "Aspiration"),
				new TableRow(2, -1, "Discovery"),
				new TableRow(3, -1, "Glory"),
				new TableRow(4, -1, "Nation"),
				new TableRow(5, -1, "Redemption"),
				new TableRow(6, -1, "Self-knowledge"),
			});

			public static readonly Table npc_bonds = new Table("NPC Bonds", new TableRow[]{
				new TableRow(1, -1, "Dedicated to fulfilling a personal life goal"),
				new TableRow(2, -1, "Protective of close family members"),
				new TableRow(3, -1, "Protective of colleagues or compatriots"),
				new TableRow(4, -1, "Loyal ot a benefactor, patron, or employer"),
				new TableRow(5, -1, "Captivated by a romantic interest"),
				new TableRow(6, -1, "Drawn to a special place"),
				new TableRow(7, -1, "Protective of a sentimental keepsake"),
				new TableRow(8, -1, "Protective of a valuable possession"),
				new TableRow(9, -1, "Out for revenge"),
			});

			public static readonly Table npc_flaws_and_secrets = new Table("NPC Flaws and Secrets", new TableRow[]{
				new TableRow(1, -1, "Forbidden love or susceptibility to romance"),
				new TableRow(2, -1, "Enjoys decadent pleasures"),
				new TableRow(3, -1, "Arrogance"),
				new TableRow(4, -1, "Envies another creature's possessions or station"),
				new TableRow(5, -1, "Overpowering greed"),
				new TableRow(6, -1, "Prone to rage"),
				new TableRow(7, -1, "Has a powerful enemy"),
				new TableRow(8, -1, "Specific phobia"),
				new TableRow(9, -1, "Shameful or scandalous history"),
				new TableRow(10, -1, "Secret crime or misdeed"),
				new TableRow(11, -1, "Possession of forbidden lore"),
				new TableRow(12, -1, "Foolhardy bravery"),
			});

			public static readonly Table villains_scheme_objective = new Table("Villains Scheme - Objective", new TableRow[]{
				new TableRow(1, -1, "Immortality"),
				new TableRow(2, -1, "Influence"),
				new TableRow(3, -1, "Magic"),
				new TableRow(4, -1, "Mayhem"),
				new TableRow(5, -1, "Passion"),
				new TableRow(6, -1, "Power"),
				new TableRow(7, -1, "Revenge"),
				new TableRow(8, -1, "Wealth"),
			});

			public static readonly Table villains_scheme_immortality = new Table("Villains Scheme - Immortality", new TableRow[]{
				new TableRow(1, -1, "Acquire a legendary item to prolog life"),
				new TableRow(2, -1, "Ascend to godhood"),
				new TableRow(3, -1, "Become undead or obtain a younger body"),
				new TableRow(4, -1, "Steal a planar creature's essence"),
			});

			public static readonly Table villains_scheme_influence = new Table("Villains Scheme - Influence", new TableRow[]{
				new TableRow(1, -1, "Seize a position of power or title"),
				new TableRow(2, -1, "Win a contest or tournament"),
				new TableRow(3, -1, "Win favor with a powerful individual"),
				new TableRow(4, -1, "Place a pawn in a position of power"),
			});

			public static readonly Table villains_scheme_magic = new Table("Villains Scheme - Magic", new TableRow[]{
				new TableRow(1, -1, "Obtain an ancient artifact"),
				new TableRow(2, -1, "Build a construct or magical device"),
				new TableRow(3, -1, "Carry out a deity's wishes"),
				new TableRow(4, -1, "Offer sacrifices to a deity"),
				new TableRow(5, -1, "Contact a lost deity or power"),
				new TableRow(6, -1, "Open a gate to another world"),
			});

			public static readonly Table villains_scheme_mayhem = new Table("Villains Scheme - Mayhem", new TableRow[]{
				new TableRow(1, -1, "Fulfill an apocalyptic prophecy"),
				new TableRow(2, -1, "Enact the vengeful will of a god or patron"),
				new TableRow(3, -1, "Spread a vile contagion"),
				new TableRow(4, -1, "Overthrow a government"),
				new TableRow(5, -1, "Trigger a natrual disaster"),
				new TableRow(6, -1, "Utterly destroy a bloodline or clan"),
			});

			public static readonly Table villains_scheme_passion = new Table("Villains Scheme - Passion", new TableRow[]{
				new TableRow(1, -1, "Prolong the life of a loved one"),
				new TableRow(2, -1, "Prove worthy of another person's love"),
				new TableRow(3, -1, "Raise or restore a dead loved one"),
				new TableRow(4, -1, "Destroy rivals for another person's affection"),
			});

			public static readonly Table villains_scheme_power = new Table("Villains Scheme - Power", new TableRow[]{
				new TableRow(1, -1, "Conquer a region or incite a rebellion"),
				new TableRow(2, -1, "Seize control of an army"),
				new TableRow(3, -1, "Become the power behind the throne"),
				new TableRow(4, -1, "Gain the favor of a ruler"),
			});

			public static readonly Table villains_scheme_revenge = new Table("Villains Scheme - Revenge", new TableRow[]{
				new TableRow(1, -1, "Avenge a past humiliation or insult"),
				new TableRow(2, -1, "Avenge a past imprisonment or injury"),
				new TableRow(3, -1, "Avenge the death of a loved one"),
				new TableRow(4, -1, "Retrieve stolen property and punish the thief"),
			});

			public static readonly Table villains_scheme_wealth = new Table("Villains Scheme - Wealth", new TableRow[]{
				new TableRow(1, -1, "Control natural resources or trade"),
				new TableRow(2, -1, "Marry into wealth"),
				new TableRow(3, -1, "Plunder ancient ruins"),
				new TableRow(4, -1, "Steal land, goods, or money"),
			});

			public static readonly Table villains_methods_agricultural_devastation = new Table("Villains Methods - Agricultural Devastation", new TableRow[]{
				new TableRow(1, -1, "Blight"),
				new TableRow(2, -1, "Crop failure"),
				new TableRow(3, -1, "Drought"),
				new TableRow(4, -1, "Famine"),
			});

			public static readonly Table villains_methods_assault_or_beatings = new Table("Villains Methods - Assault or Beatings", new TableRow[]{
				new TableRow(1, -1, "Assault or beatings"),
			});

			public static readonly Table villains_methods_bounty_hunting_or_assassination = new Table("Villains Methods - Bounty Hunting or Assassination", new TableRow[]{
				new TableRow(1, -1, "Bounty hunting or assassination"),
			});

			public static readonly Table villains_methods_captivity_or_coercion = new Table("Villains Methods - Captivity or Coercion", new TableRow[]{
				new TableRow(1, -1, "Bribery"),
				new TableRow(2, -1, "Enticement"),
				new TableRow(3, -1, "Eviction"),
				new TableRow(4, -1, "Imprisonment"),
				new TableRow(5, -1, "Kidnapping"),
				new TableRow(6, -1, "Legal intimidation"),
				new TableRow(7, -1, "Press gangs"),
				new TableRow(8, -1, "Shackling"),
				new TableRow(9, -1, "Slavery"),
				new TableRow(10, -1, "Threats or harassment"),
			});

			public static readonly Table villains_methods_confidence_scams = new Table("Villains Methods - Confidence Scams", new TableRow[]{
				new TableRow(1, -1, "Breach of contract"),
				new TableRow(2, -1, "Cheating"),
				new TableRow(3, -1, "Fast talking"),
				new TableRow(4, -1, "Fine print"),
				new TableRow(5, -1, "Fraud or swindling"),
				new TableRow(6, -1, "Quackery or tricks"),
			});

			public static readonly Table villains_methods_defamation = new Table("Villains Methods - Defamation", new TableRow[]{
				new TableRow(1, -1, "Framing"),
				new TableRow(2, -1, "Gossipping or slander"),
				new TableRow(3, -1, "Humiliation"),
				new TableRow(4, -1, "Libel or insults"),
			});

			public static readonly Table villains_methods_dueling = new Table("Villains Methods - Dueling", new TableRow[]{
				new TableRow(1, -1, "Dueling"),
			});

			public static readonly Table villains_methods_execution = new Table("Villains Methods - Execution", new TableRow[]{
				new TableRow(1, -1, "Beheading"),
				new TableRow(2, -1, "Burning at the stake"),
				new TableRow(3, -1, "Burying alive"),
				new TableRow(4, -1, "Crucifixion"),
				new TableRow(5, -1, "Drawing and quartering"),
				new TableRow(6, -1, "Hanging"),
				new TableRow(7, -1, "Impalement"),
				new TableRow(8, -1, "Sacrifice (living)"),
			});

			public static readonly Table villains_methods_impersonation_or_disguise = new Table("Villains Methods - Impersonation or Disguise", new TableRow[]{
				new TableRow(1, -1, "Impersonation or disguise"),
			});

			public static readonly Table villains_methods_lying_or_perjury = new Table("Villains Methods - Lying or Perjury", new TableRow[]{
				new TableRow(1, -1, "Lying or perjury"),
			});

			public static readonly Table villains_methods_magical_mayhem = new Table("Villains Methods - Magical Mayhem", new TableRow[]{
				new TableRow(1, -1, "Hauntings"),
				new TableRow(2, -1, "Illusions"),
				new TableRow(3, -1, "Infernal bargains"),
				new TableRow(4, -1, "Mind control"),
				new TableRow(5, -1, "Petrification"),
				new TableRow(6, -1, "Raising or animating the dead"),
				new TableRow(7, -1, "Summoning monsters"),
				new TableRow(8, -1, "Weather control"),
			});

			public static readonly Table villains_methods_murder = new Table("Villains Methods - Murder", new TableRow[]{
				new TableRow(1, -1, "Assassination"),
				new TableRow(2, -1, "Cannibalism"),
				new TableRow(3, -1, "Dismemberment"),
				new TableRow(4, -1, "Drowning"),
				new TableRow(5, -1, "Electrocution"),
				new TableRow(6, -1, "Euthanasia (involuntary)"),
				new TableRow(7, -1, "Disease"),
				new TableRow(8, -1, "Poisoning"),
				new TableRow(9, -1, "Stabbing"),
				new TableRow(10, -1, "Strangulation or suffocation"),
			});

			public static readonly Table villains_methods_neglect = new Table("Villains Methods - Neglect", new TableRow[]{
				new TableRow(1, -1, "Neglect"),
			});

			public static readonly Table villains_methods_politics = new Table("Villains Methods - Politics", new TableRow[]{
				new TableRow(1, -1, "Betrayal or treason"),
				new TableRow(2, -1, "Conspiracy"),
				new TableRow(3, -1, "Espionage or spying"),
				new TableRow(4, -1, "Genocide"),
				new TableRow(5, -1, "Oppression"),
				new TableRow(6, -1, "Raising taxes"),
			});

			public static readonly Table villains_methods_religion = new Table("Villains Methods - Religion", new TableRow[]{
				new TableRow(1, -1, "Curses"),
				new TableRow(2, -1, "Desecration"),
				new TableRow(3, -1, "False gods"),
				new TableRow(4, -1, "Heresy or cults"),
			});

			public static readonly Table villains_methods_stalking = new Table("Villains Methods - Stalking", new TableRow[]{
				new TableRow(1, -1, "Stalking"),
			});

			public static readonly Table villains_methods_theft_or_property_crime = new Table("Villains Methods - Theft or Property Crime", new TableRow[]{
				new TableRow(1, -1, "Arson"),
				new TableRow(2, -1, "Blackmail or extortion"),
				new TableRow(3, -1, "Burglary"),
				new TableRow(4, -1, "Counterfeiting"),
				new TableRow(5, -1, "Highway robbery"),
				new TableRow(6, -1, "Looting"),
				new TableRow(7, -1, "Mugging"),
				new TableRow(8, -1, "Poaching"),
				new TableRow(9, -1, "Seizing property"),
				new TableRow(10, -1, "Smuggling"),
			});

			public static readonly Table villains_methods_torture = new Table("Villains Methods - Torture", new TableRow[]{
				new TableRow(1, -1, "Acid"),
				new TableRow(2, -1, "Blinding"),
				new TableRow(3, -1, "Branding"),
				new TableRow(4, -1, "Racking"),
				new TableRow(5, -1, "Thumbscrews"),
				new TableRow(6, -1, "Whipping"),
			});

			public static readonly Table villains_methods_vice = new Table("Villains Methods - Vice", new TableRow[]{
				new TableRow(1, -1, "Adultery"),
				new TableRow(2, -1, "Drugs or alcohol"),
				new TableRow(3, -1, "Gambling"),
				new TableRow(4, -1, "Seduction"),
			});

			public static readonly Table villains_methods_warfare = new Table("Villains Methods - Warfare", new TableRow[]{
				new TableRow(1, -1, "Ambush"),
				new TableRow(2, -1, "Invasion"),
				new TableRow(3, -1, "Massacre"),
				new TableRow(4, -1, "Mercenaries"),
				new TableRow(5, -1, "Rebellion"),
				new TableRow(6, -1, "Terrorism"),
			});

			public static readonly Table villains_weakness = new Table("Villain's Weakness", new TableRow[]{
				new TableRow(1, -1, "A hidden object holds the villain's soul"),
				new TableRow(2, -1, "The villain's power is broken if the death of its true love is avenged"),
				new TableRow(3, -1, "The villain is weakened in the presence of a particular artifact"),
				new TableRow(4, -1, "A special weapon deals extra damage when used against the villain"),
				new TableRow(5, -1, "The villain is destroyed if it speaks its true name"),
				new TableRow(6, -1, "An ancient prophecy or riddle reveals how the villain can be overthrown"),
				new TableRow(7, -1, "The villain falls when an ancient enemy forgives its past actions"),
				new TableRow(8, -1, "The villain loses its power if a mystic bargain it struck long ago is completed"),
			});

			public static string getNPCIdeals(int ideal = -1)
			{
				Table[] ideals =
				{
					npc_ideals_good,
					npc_ideals_evil,
					npc_ideals_lawful,
					npc_ideals_chaotic,
					npc_ideals_neutral,
					npc_ideals_other
				};

				if(ideal == -1)
				{
					return ideals[roll(1, 6) - 1].rollOnTable();
				}

				return ideals[ideal].rollOnTable();
			}

			public static string getNPCAbilities(bool getDifferentAbilities = true)
			{
				int num1 = roll(1, 6);
				int num2 = 0;

				do
				{
					num2 = roll(1, 6);
				} while (num2 == num1 && getDifferentAbilities == true);

				return npc_high_abilities[num1 - 1] + ", " + npc_low_abilities[num2 - 1];
			}

			public static string getVillainsScheme()
			{
				Table[] schemes = 
				{
					villains_scheme_immortality,
					villains_scheme_influence,
					villains_scheme_magic,
					villains_scheme_mayhem,
					villains_scheme_passion,
					villains_scheme_power,
					villains_scheme_revenge,
					villains_scheme_wealth
				};

				int index = roll(1, 8) - 1;

				return schemes[index].Name + " - " + schemes[index].rollOnTable();
			}

			public static string getVillainsMethods()
			{
				Table[] methods =
				{
					villains_methods_agricultural_devastation,
					villains_methods_assault_or_beatings,
					villains_methods_bounty_hunting_or_assassination,
					villains_methods_captivity_or_coercion,
					villains_methods_confidence_scams,
					villains_methods_defamation,
					villains_methods_dueling,
					villains_methods_execution,
					villains_methods_impersonation_or_disguise,
					villains_methods_lying_or_perjury,
					villains_methods_magical_mayhem,
					villains_methods_murder,
					villains_methods_neglect,
					villains_methods_politics,
					villains_methods_religion,
					villains_methods_stalking,
					villains_methods_theft_or_property_crime,
					villains_methods_torture,
					villains_methods_vice,
					villains_methods_warfare
				};

				int index = roll(1, 20) - 1;

				return methods[index].Name + " - " + methods[index].rollOnTable();
			}
		}

		// Chapter 5
		public static class AdventureEnvironments
		{
			public static readonly Table dungeon_location = new Table("Dungeon Location", new TableRow[]{
				new TableRow(1, 4, "A building in a city"),
				new TableRow(5, 8, "Catacombs or sewers beneath a city"),
				new TableRow(9, 12, "Beneath a farmhouse"),
				new TableRow(13, 16, "Beneath a graveyard"),
				new TableRow(17, 22, "Beneath a ruined castle"),
				new TableRow(23, 26, "Beneath a ruined city"),
				new TableRow(27, 30, "Beneath a temple"),
				new TableRow(31, 34, "In a chasm"),
				new TableRow(35, 38, "In a cliff face"),
				new TableRow(39, 42, "In a desert"),
				new TableRow(43, 46, "In a forest"),
				new TableRow(47, 50, "In a glacier"),
				new TableRow(51, 54, "In a gorge"),
				new TableRow(55, 58, "In a jungle"),
				new TableRow(59, 62, "In a mountain pass"),
				new TableRow(63, 66, "In a swamp"),
				new TableRow(67, 70, "Beneath or on top of a mesa"),
				new TableRow(71, 74, "In sea caves"),
				new TableRow(75, 78, "In several connected mesas"),
				new TableRow(79, 82, "On a mountain peak"),
				new TableRow(83, 86, "On a promontory"),
				new TableRow(87, 90, "On an island"),
				new TableRow(91, 95, "Underwater"),
				new TableRow(96, 100, "Roll on the Exotic Location table"),
			});

			public static readonly Table dungeon_exotic_location = new Table("Dungeon Exotic Location", new TableRow[]{
				new TableRow(1, -1, "Among the branches of a tree"),
				new TableRow(2, -1, "Around a geyser"),
				new TableRow(3, -1, "Behind a waterfall"),
				new TableRow(4, -1, "Buried in an avalanche"),
				new TableRow(5, -1, "Buried in a sandstorm"),
				new TableRow(6, -1, "Buried in volcanic ash"),
				new TableRow(7, -1, "Castle or structure sunken in a swamp"),
				new TableRow(8, -1, "Castle or structure at the bottom of a sinkhole"),
				new TableRow(9, -1, "Floating on the sea"),
				new TableRow(10, -1, "In a meteorite"),
				new TableRow(11, -1, "On a demiplane or in a pocket dimension"),
				new TableRow(12, -1, "In an area devastated by a magical catastrophe"),
				new TableRow(13, -1, "On a cloud"),
				new TableRow(14, -1, "In the Feywild"),
				new TableRow(15, -1, "In the Shadowfell"),
				new TableRow(16, -1, "On an island in an underground sea"),
				new TableRow(17, -1, "In a volcano"),
				new TableRow(18, -1, "On the back of a Gargantuan living creature"),
				new TableRow(19, -1, "Sealed inside a magical dome of force"),
				new TableRow(20, -1, "Inside a Mordenkainen's magnificent mansion"),
			});

			public static readonly Table dungeon_creator = new Table("Dungeon Creator", new TableRow[]{
				new TableRow(1, -1, "Beholder"),
				new TableRow(2, 4, "Cult or religious group"),
				new TableRow(5, 8, "Dwarves"),
				new TableRow(9, -1, "Elves (including drow)"),
				new TableRow(10, -1, "Giants"),
				new TableRow(11, -1, "Hobgoblins"),
				new TableRow(12, 15, "Humans"),
				new TableRow(16, -1, "Kuo-toa"),
				new TableRow(17, -1, "Lich"),
				new TableRow(18, -1, "Mind flayers"),
				new TableRow(19, -1, "Yuan-ti"),
				new TableRow(20, -1, "No creator (natural caverns"),
			});

			public static readonly Table cults_and_religious_groups = new Table("Cults and Religious Groups", new TableRow[]{
				new TableRow(1, -1, "Demon-worshiping cult"),
				new TableRow(2, -1, "Devil-worshiping cult"),
				new TableRow(3, 4, "Elemental Air cult"),
				new TableRow(5, 6, "Elemental Earth cult"),
				new TableRow(7, 8, "Elemental Fire cult"),
				new TableRow(9, 10, "Elemental Water cult"),
				new TableRow(11, 15, "Worshipers of an evil deity"),
				new TableRow(16, 17, "Worshipers of a good deity"),
				new TableRow(18, 20, "Worshipers of a neutral deity"),
			});

			public static readonly Table npc_alignment = new Table("NPC Alignment", new TableRow[]{
				new TableRow(1, 2, "Lawful good"),
				new TableRow(3, 4, "Neutral good"),
				new TableRow(5, 6, "Chaotic good"),
				new TableRow(7, 8, "Lawful neutral"),
				new TableRow(9, 10, "Neutral"),
				new TableRow(11, -1, "Chaotic neutral"),
				new TableRow(12, 13, "Lawful evil"),
				new TableRow(14, 15, "Neutral evil"),
				new TableRow(16, 17, "Chaotic evil"),
			});

			public static readonly Table npc_class = new Table("NPC Class", new TableRow[]{
				new TableRow(1, -1, "Barbarian"),
				new TableRow(2, -1, "Bard"),
				new TableRow(3, 4, "Cleric"),
				new TableRow(5, -1, "Druid"),
				new TableRow(6, 7, "Fighter"),
				new TableRow(8, -1, "Monk"),
				new TableRow(9, -1, "Paladin"),
				new TableRow(10, -1, "Ranger"),
				new TableRow(11, 14, "Rogue"),
				new TableRow(15, -1, "Sorcerer"),
				new TableRow(16, -1, "Warlock"),
				new TableRow(17, 20, "Wizard"),
			});

			public static readonly Table dungeon_purpose = new Table("Dungeon Purpose", new TableRow[]{
				new TableRow(1, -1, "Death trap"),
				new TableRow(2, 5, "Lair"),
				new TableRow(6, -1, "Maze"),
				new TableRow(7, 9, "Mine"),
				new TableRow(10, -1, "Planar gate"),
				new TableRow(11, 14, "Stronghold"),
				new TableRow(15, 17, "Temple or shrine"),
				new TableRow(18, 19, "Tomb"),
				new TableRow(20, -1, "Treasure vault"),
			});

			public static readonly Table dungeon_history = new Table("Dungeon History", new TableRow[]{
				new TableRow(1, 3, "Abandoned by creators"),
				new TableRow(4, -1, "Abandoned due to plague"),
				new TableRow(5, 8, "Conquered by invaders"),
				new TableRow(9, 10, "Creators destroyed by attacking raiders"),
				new TableRow(11, -1, "Creators destroyed by discovery made within the site"),
				new TableRow(12, -1, "Creators destroyed by internal conflict"),
				new TableRow(13, -1, "Creators destroyed by magical catastrophe"),
				new TableRow(14, 15, "Creators destroyed by natural disaster"),
				new TableRow(16, -1, "Location cursed by the gods and shunned"),
				new TableRow(17, 18, "Original creator still in control"),
				new TableRow(19, -1, "Overrun by planar creatures"),
				new TableRow(20, -1, "Site of a great miracle"),
			});

			public static readonly Table monuments = new Table("Monuments", new TableRow[]{
				new TableRow(1, -1, "Sealed burial mound or pyramid"),
				new TableRow(2, -1, "Plundered burial mound or pyramid"),
				new TableRow(3, -1, "Faces carved into a mountainside or cliff"),
				new TableRow(4, -1, "Giant statues carved out of a mountainside or cliff"),
				new TableRow(5, 6, "Intact obelisk etched with a warning, historical lore, dedication, or religious iconography"),
				new TableRow(7, 8, "Ruined or toppled obelisk"),
				new TableRow(9, 10, "Intact statue of a person or deity"),
				new TableRow(11, 13, "Ruined or toppled statue of a person or deity"),
				new TableRow(14, -1, "Great stone wall, intact, with tower fortifications spaced at one-mile intervals"),
				new TableRow(15, -1, "Great stone wall in ruins"),
				new TableRow(16, -1, "Great stone arch"),
				new TableRow(17, -1, "Fountain"),
				new TableRow(18, -1, "Intact circle of standing stones"),
				new TableRow(19, -1, "Ruined or toppled circle of standing stones"),
				new TableRow(20, -1, "Totem pole"),
			});

			public static readonly Table weird_locales = new Table("Weird Locales", new TableRow[]{
				new TableRow(1, 2, "Dead magic zone (similar to an antimagic field)"),
				new TableRow(3, -1, "Wild magic zone (roll on the Wild Magic Surge table in the Player's Handbook whenever a spell is cast within the zone)"),
				new TableRow(4, -1, "Boulder carved with talking faces"),
				new TableRow(5, -1, "Crystal cave that mystically answers questions"),
				new TableRow(6, -1, "Ancient tree containing a trapped spirit"),
				new TableRow(7, 8, "Battlefield where lingering fog occasionally assumes humanoid forms"),
				new TableRow(9, 10, "Permanent portal to another plane of existence"),
				new TableRow(11, -1, "Wishing well"),
				new TableRow(12, -1, "Giant crystal shard protruding from the ground"),
				new TableRow(13, -1, "Wrecked ship, which might be nowhere near water"),
				new TableRow(14, 15, "Haunted hill or barrow mound"),
				new TableRow(16, -1, "River ferry guided by a skeletal captain"),
				new TableRow(17, -1, "Field of petrified soldiers or other creatures"),
				new TableRow(18, -1, "Forest of petrified or awakened trees"),
				new TableRow(19, -1, "Canyon containing a dragons' graveyard"),
				new TableRow(20, -1, "Floating earth mote with a tower on it"),
			});

			public static readonly Table weather_temperature = new Table("Weather Temperature", new TableRow[]{
				new TableRow(1, 14, "Normal for the season"),
				new TableRow(15, 17, "1d4 x 10 degrees Fahrenheit colder than normal"),
				new TableRow(18, 20, "1d4 x 10 degrees Fahrenheit hotter than normal"),
			});

			public static readonly Table weather_wind = new Table("Weather - Wind", new TableRow[]{
				new TableRow(1, 12, "None"),
				new TableRow(13, 17, "Light"),
				new TableRow(18, 20, "Strong"),
			});

			public static readonly Table weather_precipitation = new Table("Weather - Precipitation", new TableRow[]{
				new TableRow(1, 12, "None"),
				new TableRow(13, 17, "Light rain or light snowfall"),
				new TableRow(18, 20, "Heavy rain or heavy snowfall"),
			});

			public static readonly Table race_relations = new Table("Race Relations", new TableRow[]{
				new TableRow(1, 10, "Harmony"),
				new TableRow(11, 14, "Tension or rivalry"),
				new TableRow(15, 16, "Racial majority are conquerers"),
				new TableRow(17, -1, "Racial minority are rulers"),
				new TableRow(18, -1, "Racial minority are refugees"),
				new TableRow(19, -1, "Racial majority oppresses minority"),
				new TableRow(20, -1, "Racial minority oppresses majority"),
			});

			public static readonly Table rulers_status = new Table("Rulers Status", new TableRow[]{
				new TableRow(1, 5, "Respected, fair, and just"),
				new TableRow(6, 8, "Feared tyrant"),
				new TableRow(9, -1, "Weakling manipulated by others"),
				new TableRow(10, -1, "Illegitimate ruler, simmering civial war"),
				new TableRow(11, -1, "Ruled or controlled by a powerful monster"),
				new TableRow(12, -1, "Mysterious, anonymous cabal"),
				new TableRow(13, -1, "Contested leadership, open fighting"),
				new TableRow(14, -1, "Cabal seized power openly"),
				new TableRow(15, -1, "Doltish lout"),
				new TableRow(16, -1, "On deathbed, claimants compete for power"),
				new TableRow(17, 18, "Iron-willed but respected"),
				new TableRow(19, 20, "Religious leader"),
			});

			public static readonly Table notable_traits = new Table("Notable Traits", new TableRow[]{
				new TableRow(1, -1, "Canals in place of streets"),
				new TableRow(2, -1, "Massive statue or monument"),
				new TableRow(3, -1, "Grand temple"),
				new TableRow(4, -1, "Large fortress"),
				new TableRow(5, -1, "Verdant parks and orchards"),
				new TableRow(6, -1, "River divides town"),
				new TableRow(7, -1, "Major trade center"),
				new TableRow(8, -1, "Headquarters of a powerful family or guild"),
				new TableRow(9, -1, "Population mostly wealthy"),
				new TableRow(10, -1, "Destitue, rundown"),
				new TableRow(11, -1, "Awful smell (tanneries, open sewers)"),
				new TableRow(12, -1, "Center of trade for one specific good"),
				new TableRow(13, -1, "Site of many battles"),
				new TableRow(14, -1, "Site of a mythic or magical event"),
				new TableRow(15, -1, "Important library or archive"),
				new TableRow(16, -1, "Worship of all gods banned"),
				new TableRow(17, -1, "Sinister reputation"),
				new TableRow(18, -1, "Notable library or academy"),
				new TableRow(19, -1, "Site of important tomb or graveyard"),
				new TableRow(20, -1, "Built atop ancient ruins"),
			});

			public static readonly Table known_for_its = new Table("Known for its", new TableRow[]{
				new TableRow(1, -1, "Delicious cuisine"),
				new TableRow(2, -1, "Rude people"),
				new TableRow(3, -1, "Greedy merchants"),
				new TableRow(4, -1, "Artists and writers"),
				new TableRow(5, -1, "Great hero/savior"),
				new TableRow(6, -1, "Flowers"),
				new TableRow(7, -1, "Hordes of beggars"),
				new TableRow(8, -1, "Tough warriors"),
				new TableRow(9, -1, "Dark magic"),
				new TableRow(10, -1, "Decadence"),
				new TableRow(11, -1, "Piety"),
				new TableRow(12, -1, "Gambling"),
				new TableRow(13, -1, "Godlessness"),
				new TableRow(14, -1, "Education"),
				new TableRow(15, -1, "Wines"),
				new TableRow(16, -1, "High fashion"),
				new TableRow(17, -1, "Political intrigue"),
				new TableRow(18, -1, "Powerful guilds"),
				new TableRow(19, -1, "Strong drink"),
				new TableRow(20, -1, "Patriotism"),
			});

			public static readonly Table current_calamity = new Table("Current Calamity", new TableRow[]{
				new TableRow(1, -1, "Suspected vampire infestation"),
				new TableRow(2, -1, "New cult seeks converts"),
				new TableRow(3, -1, "Important figure died (murder suspected)"),
				new TableRow(4, -1, "War between rival thieves' guilds"),
				new TableRow(5, 6, "Plague or famine (sparks riots)"),
				new TableRow(7, -1, "Corrupt officials"),
				new TableRow(8, 9, "Marauding monsters"),
				new TableRow(10, -1, "Powerful wizard has moved into town"),
				new TableRow(11, -1, "Economic depression (trade disrupted)"),
				new TableRow(12, -1, "Flooding"),
				new TableRow(13, -1, "Undead stirring in cemeteries"),
				new TableRow(14, -1, "Prophecy of doom"),
				new TableRow(15, -1, "Brink of war"),
				new TableRow(16, -1, "Internal strife (leads to anarchy)"),
				new TableRow(17, -1, "Besieged by enemies"),
				new TableRow(18, -1, "Scandal threatens powerful families"),
				new TableRow(19, -1, "Dungeon discovered (adventurers flock to town)"),
				new TableRow(20, -1, "Religious sects struggle for power"),
			});

			public static readonly Table building_type = new Table("Building Type", new TableRow[]{
				new TableRow(1, 10, "Residence (roll once on the Residence table)"),
				new TableRow(11, 12, "Religious (roll once on the Religious table)"),
				new TableRow(13, 15, "Tavern (roll once on the Tavern table and twice on the Tavern Name Generator table"),
				new TableRow(16, 17, "Warehouse (roll once on the Warehouse table)"),
				new TableRow(18, 20, "Shop (roll once on the Shop table)"),
				});

			public static readonly Table residence = new Table("Residence", new TableRow[]{
				new TableRow(1, 2, "Abandoned squat"),
				new TableRow(3, 8, "Middle-class home"),
				new TableRow(9, 10, "Upper-class home"),
				new TableRow(11, 15, "Crowded tenement"),
				new TableRow(16, 17, "Orphanage"),
				new TableRow(18, -1, "Hidden slavers' den"),
				new TableRow(19, -1, "Front for a secret cult"),
				new TableRow(20, -1, "Lavish, guarded mansion"),
			});

			public static readonly Table religious_building = new Table("Religious Building", new TableRow[]{
				new TableRow(1, 10, "Temple to a good or neutral deity"),
				new TableRow(11, 12, "Temple to a false deity (run by charlatan priests)"),
				new TableRow(13, -1, "Home of ascetics"),
				new TableRow(14, 15, "Abandoned shrine"),
				new TableRow(16, 17, "Library dedicated to religious study"),
				new TableRow(18, 19, "Hidden shrine to a fiend or an evil deity"),
			});

			public static readonly Table tavern = new Table("Tavern", new TableRow[]{
				new TableRow(1, 5, "Quiet, low-key bar"),
				new TableRow(6, 9, "Raucous dive"),
				new TableRow(10, -1, "Thieves' guild hangout"),
				new TableRow(11, -1, "Gathering place for a secret society"),
				new TableRow(12, 13, "Upper-class dining club"),
				new TableRow(14, 15, "Gambling den"),
				new TableRow(16, 17, "Caters to specific race or guild"),
				new TableRow(18, -1, "Members-only club"),
				new TableRow(19, 20, "Brothel"),
			});

			public static readonly Table tavern_name_first_part = new Table("Tavern Name - First Part", new TableRow[]{
				new TableRow(1, -1, "The Silver"),
				new TableRow(2, -1, "The Golden"),
				new TableRow(3, -1, "The Staggering"),
				new TableRow(4, -1, "The Laughing"),
				new TableRow(5, -1, "The Prancing"),
				new TableRow(6, -1, "The Gilded"),
				new TableRow(7, -1, "The Running"),
				new TableRow(8, -1, "The Howling"),
				new TableRow(9, -1, "The Slaughtered"),
				new TableRow(10, -1, "The Leering"),
				new TableRow(11, -1, "The Drunken"),
				new TableRow(12, -1, "The Leaping"),
				new TableRow(13, -1, "The Roaring"),
				new TableRow(14, -1, "The Frowning"),
				new TableRow(15, -1, "The Lonely"),
				new TableRow(16, -1, "The Wandering"),
				new TableRow(17, -1, "The Mysterious"),
				new TableRow(18, -1, "The Barking"),
				new TableRow(19, -1, "The Black"),
				new TableRow(20, -1, "The Gleaming"),
			});

			public static readonly Table tavern_name_second_part = new Table("Tavern Name - Second Part", new TableRow[]{
				new TableRow(1, -1, "Eel"),
				new TableRow(2, -1, "Dolphin"),
				new TableRow(3, -1, "Dwarf"),
				new TableRow(4, -1, "Pegasus"),
				new TableRow(5, -1, "Pony"),
				new TableRow(6, -1, "Rose"),
				new TableRow(7, -1, "Stag"),
				new TableRow(8, -1, "Wolf"),
				new TableRow(9, -1, "Lamb"),
				new TableRow(10, -1, "Demon"),
				new TableRow(11, -1, "Goat"),
				new TableRow(12, -1, "Spirit"),
				new TableRow(13, -1, "Horde"),
				new TableRow(14, -1, "Jester"),
				new TableRow(15, -1, "Mountain"),
				new TableRow(16, -1, "Eagle"),
				new TableRow(17, -1, "Satyr"),
				new TableRow(18, -1, "Dog"),
				new TableRow(19, -1, "Spider"),
				new TableRow(20, -1, "Star"),
			});

			public static readonly Table warehouse = new Table("Warehouse", new TableRow[]{
				new TableRow(1, 4, "Empty or abandoned"),
				new TableRow(5, 6, "Heavily guarded, expensive goods"),
				new TableRow(7, 10, "Cheap goods"),
				new TableRow(11, 14, "Bulk goods"),
				new TableRow(15, -1, "Live animals"),
				new TableRow(16, 17, "Weapons/armor"),
				new TableRow(18, 19, "Goods from a distant land"),
				new TableRow(20, -1, "Secret smuggler's den"),
			});

			public static readonly Table shop = new Table("Shop", new TableRow[]{
				new TableRow(1, -1, "Pawnshop"),
				new TableRow(2, -1, "Herbs/incense"),
				new TableRow(3, -1, "Fruits/vegetables"),
				new TableRow(4, -1, "Dried meats"),
				new TableRow(5, -1, "Pottery"),
				new TableRow(6, -1, "Undertaker"),
				new TableRow(7, -1, "Books"),
				new TableRow(8, -1, "Moneylender"),
				new TableRow(9, -1, "Weapons/armor"),
				new TableRow(10, -1, "Chandler"),
				new TableRow(11, -1, "Smithy"),
				new TableRow(12, -1, "Carpenter"),
				new TableRow(13, -1, "Weaver"),
				new TableRow(14, -1, "Jeweler"),
				new TableRow(15, -1, "Baker"),
				new TableRow(16, -1, "Mapmaker"),
				new TableRow(17, -1, "Tailor"),
				new TableRow(18, -1, "Ropemaker"),
				new TableRow(19, -1, "Mason"),
				new TableRow(20, -1, "Scribe"),
			});

			public static readonly Table random_urban_encounters = new Table("Random Urban Encounters", new TableRow[]{
				new TableRow(1, -1, "Animals on the loose"),
				new TableRow(2, -1, "Announcement"),
				new TableRow(3, -1, "Brawl"),
				new TableRow(4, -1, "Bullies"),
				new TableRow(5, -1, "Companion"),
				new TableRow(6, -1, "Contest"),
				new TableRow(7, -1, "Corpse"),
				new TableRow(8, -1, "Draft"),
				new TableRow(9, -1, "Drunk"),
				new TableRow(10, -1, "Fire"),
				new TableRow(11, -1, "Found trinket"),
				new TableRow(12, -1, "Guard harassment"),
				new TableRow(13, -1, "Pickpocket"),
				new TableRow(14, -1, "Procession"),
				new TableRow(15, -1, "Protest"),
				new TableRow(16, -1, "Runaway cart"),
				new TableRow(17, -1, "Shady transaction"),
				new TableRow(18, -1, "Spectacle"),
				new TableRow(19, -1, "Urchin"),
			});
		}

		// Chapter 6
		public static class BetweenAdventures
		{
			public static readonly Table carousing = new Table("Carousing", new TableRow[]{
				new TableRow(1, 10, "You are jailed for 1d4 days at the end of the downtime period on charges of disorderly conduct and disturbing the peace. You can pay a fine of 10 gp to avoid jail time, or you can try to resist arrest."),
				new TableRow(1, 10, "You are jailed for 1d4 days at the end of the downtime period on charges of disorderly conduct and disturbing the peace. You can pay a fine of 10 gp to avoid jail time, or you can try to resist arrest."),
				new TableRow(11, 20, "You regain consciousness in a strange place with no memory of how you got there, and you have been robbed of 3d6x5 gp."),
				new TableRow(21, 30, "You make an enemy. This person, business, or organization is now hostile to you. The DM determines the offended party. You decide how you offended them."),
				new TableRow(31, 40, "You are caught up in a whirlwind romance. Roll a d20. On a 1-5, the romance ends badly. On a 6-10, the romance ends amicably. On an 11-20, the romance is ongoing.You determine the identity of the love interest, subject to your DM's approval. If the romance ends badly, you might gain a new flaw. If it ends well or is ongoing, your new love interest might represent a new bond."),
				new TableRow(41, 80, "You earn modest winnings from gambling and recuperate your lifestlye expenses for the time spent carousing."),
				new TableRow(81, 90, "You earn modest winnings from gambling. You recuperate your lifestyle expenses for the time spent carousing and gain 1d20x4 gp."),
				new TableRow(90, 100, "You make a small fortune gambling. You recuperate your lifestyle expenses for the time spent carousing and gain 4d6x10 gp."),
			});

			public static readonly Table running_a_business = new Table("Running a Business", new TableRow[]{
				new TableRow(1, 20, "You ust pay one and a half times the business's maintenance cost for each of the days."),
				new TableRow(21, 30, "You must pay the business's full maintenance cost for each of the days."),
				new TableRow(31, 40, "You must pay half the business's maintenance cost for each of the days. Profits cover the other half."),
				new TableRow(41, 60, "The business covers its own maintenance cost for each of the days."),
				new TableRow(61, 80, "The business covers its own maintenance cost for each of the days. It earns a profit of 1d6x5 gp."),
				new TableRow(81, 90, "The business covers its own maintenance cost for each of the days. It earns a profit of 2d8x5 gp."),
				new TableRow(91, 100, "The business covers its own maintenance cost for each of the days. It earns a profit of 3d10x5 gp."),
			});

			public static readonly Table selling_a_magic_item = new Table("Selling a Magic Item", new TableRow[]{
				new TableRow(1, 20, "A buyer offering a tenth of the base price"),
				new TableRow(21, 40, "A buyer offering a quarter of the base price, and a shady buyer offering half the base price"),
				new TableRow(41, 80, "A buyer offering half the base price, and a shady buyer offering the full base price"),
				new TableRow(81, 90, "A buyer offering the full base price"),
				new TableRow(91, 100, "A shady buyer offering one and a half times the base price, no questions asked"),
			});

			public static string getCarousing(int playerLevel = 0)
			{
				return carousing.rollOnTable(playerLevel);
			}
		}

		// Chapter 7
		public static class Treasure
		{
			public static readonly Table gemstones10gp = new Table("10 GP Gemstones", new TableRow[]{
				new TableRow(1, -1, "Azurite (opaque mottled deep blue)"),
				new TableRow(2, -1, "Banded agate (translucent striped brown, blue, white, or red)"),
				new TableRow(3, -1, "Blue quartz (transparent pale blue)"),
				new TableRow(4, -1, "Eye agate (translucent circles of gray, white, brown, blue, or green)"),
				new TableRow(5, -1, "Hematite (opaque gray-black)"),
				new TableRow(6, -1, "Lapis lazuli (opaque light and dark blue with yellow flecks)"),
				new TableRow(7, -1, "Malachite (opaque striated light and dark green)"),
				new TableRow(8, -1, "Moss agate (translucent pink or yellow-white with mossy gray or green markings)"),
				new TableRow(9, -1, "Obsidian (opaque black)"),
				new TableRow(10, -1, "Rhodochrosite (opaque light pink)"),
				new TableRow(11, -1, "Tiger eye (translucent brown with golden center"),
				new TableRow(12, -1, "Turquoise (opaque light blue-green)"),
			});

			public static readonly Table gemstones50gp = new Table("50 GP Gemstones", new TableRow[]{
				new TableRow(1, -1, "Bloodstone (opaque dark gray with red flecks)"),
				new TableRow(2, -1, "Carnelian (opaque orange to red-brown)"),
				new TableRow(3, -1, "Chalcedony (opaque white)"),
				new TableRow(4, -1, "Chrysoprase (translucent green)"),
				new TableRow(5, -1, "Citrine (transparent pale yellow-brown)"),
				new TableRow(6, -1, "Jasper (opaque blue, black, or brown)"),
				new TableRow(7, -1, "Moonstone (translucent white with pale blue glow)"),
				new TableRow(8, -1, "Onyx (opaque bands of black and white, or pure black or white)"),
				new TableRow(9, -1, "Quartz (transparent white, smoky gray, or yellow)"),
				new TableRow(10, -1, "Sardonyx (opaque bands of red and white)"),
				new TableRow(11, -1, "Star rose quartz (translucent rosy stone with white star-shaped center)"),
				new TableRow(12, -1, "Zircon (transparent pale blue-green"),
			});

			public static readonly Table gemstones100gp = new Table("100 GP Gemstones", new TableRow[]{
				new TableRow(1, -1, "Amber (transparent watery gold to rich gold)"),
				new TableRow(2, -1, "Amethyst (transparent deep purple)"),
				new TableRow(3, -1, "Chrysoberyl (transparent yellow-green to pale green)"),
				new TableRow(4, -1, "Coral (opaque crimson)"),
				new TableRow(5, -1, "Garnet (trasnparent red, brown-green, or violet)"),
				new TableRow(6, -1, "Jade (trasnlucent light green, deep green, or white)"),
				new TableRow(7, -1, "Jet (opaque deep black)"),
				new TableRow(8, -1, "Pearl (opaque lustrous white, yellow, or pink)"),
				new TableRow(9, -1, "Spinel (trasnparent red, red-brown, or deep green)"),
				new TableRow(10, -1, "Tourmaline (trasnparent pale green, blue, brown, or red)"),
			});

			public static readonly Table gemstones500gp = new Table("500 GP Gemstones", new TableRow[]{
				new TableRow(1, -1, "Alexandrite (transparent dark green)"),
				new TableRow(2, -1, "Aquamarine (transparent pale blue-green)"),
				new TableRow(3, -1, "Black pearl (opaque pure black)"),
				new TableRow(4, -1, "Blue spinel (trasnparent deep blue)"),
				new TableRow(5, -1, "Peridot (trasnparent rich olive green)"),
				new TableRow(6, -1, "Topaz (transparent golden yellow)"),
			});

			public static readonly Table gemstones1000gp = new Table("1,000 GP Gemstones", new TableRow[]{
				new TableRow(1, -1, "Black opal (translucent dark green with black mottling and golden flecks)"),
				new TableRow(2, -1, "Blue sapphire (transparent blue-white to medium blue)"),
				new TableRow(3, -1, "Emerald (transparent deep bright green)"),
				new TableRow(4, -1, "Fire opal (translucent fiery red)"),
				new TableRow(5, -1, "Opal (translucent pale blue with green and golden mottling)"),
				new TableRow(6, -1, "Star ruby (translucent ruby with white star-shaped center)"),
				new TableRow(7, -1, "Star sapphire (translucent blue sapphire with white star-shaped center)"),
				new TableRow(8, -1, "Yellow sapphire (transparent fiery yellow or yellow-green)"),
			});

			public static readonly Table gemstones5000gp = new Table("5,000 GP Gemstones", new TableRow[]{
				new TableRow(1, -1, "Black sapphire (translucent lustrous black with glowing highlights)"),
				new TableRow(2, -1, "Diamond (transparent blue-white canary, pink, brown, or blue)"),
				new TableRow(3, -1, "Jacinth (transparent fiery orange)"),
				new TableRow(4, -1, "Ruby (transparent clear red to deep crimson)"),
			});

			public static readonly Table art_objects25gp = new Table("25 GP Art Objects", new TableRow[]{
				new TableRow(1, -1, "Silver ewer"),
				new TableRow(2, -1, "Carved bone statuette"),
				new TableRow(3, -1, "Small gold bracelet"),
				new TableRow(4, -1, "Cloth-of-gold vestments"),
				new TableRow(5, -1, "Black velvet mask stitched with silver thread"),
				new TableRow(6, -1, "Copper chalice with silver filigree"),
				new TableRow(7, -1, "Pair of engraved bone dice"),
				new TableRow(8, -1, "Small mirror set in a painted wooden frame"),
				new TableRow(9, -1, "Embroidered silk handkerchief"),
				new TableRow(10, -1, "Gold locket with a apainted portrait inside"),
			});

			public static readonly Table art_objects250gp = new Table("250 GP Art Objects", new TableRow[]{
				new TableRow(1, -1, "Gold ring set with bloodstones"),
				new TableRow(2, -1, "Carved ivory statuette"),
				new TableRow(3, -1, "Large gold bracelet"),
				new TableRow(4, -1, "Silver necklace wit ha gemstone pendant"),
				new TableRow(5, -1, "Bronze crown"),
				new TableRow(6, -1, "Silk robe wit hgold embroidery"),
				new TableRow(7, -1, "Large well-made tapestry"),
				new TableRow(8, -1, "Brass mug wit hjade inlay"),
				new TableRow(9, -1, "Box of turquoise animal figurines"),
				new TableRow(10, -1, "Gold bird cage with electrum filigree"),
			});

			public static readonly Table art_objects750gp = new Table("750 GP Art Objects", new TableRow[]{
				new TableRow(1, -1, "Silver chalice set with moonstones"),
				new TableRow(2, -1, "Silver-plated steel longsword with jet set in hilt"),
				new TableRow(3, -1, "Carved harp of exotic wood with ivory inlay and zircon gems"),
				new TableRow(4, -1, "Small gold idol"),
				new TableRow(5, -1, "Gold dragon comb set with red garnets as eyes"),
				new TableRow(6, -1, "Bottle stopper cork embossed wit hgold leaf and set with amethysts"),
				new TableRow(7, -1, "Ceremonial electrum dagger with a black pearl in the pommel"),
				new TableRow(8, -1, "Silver and gold brooch"),
				new TableRow(9, -1, "Obsidian statuette with gold fittings and inlay"),
				new TableRow(10, -1, "Painted gold war mask"),
			});

			public static readonly Table art_objects2500gp = new Table("2,500 GP Art Objects", new TableRow[]{
				new TableRow(1, -1, "Fine gold chain set with a fire opal"),
				new TableRow(2, -1, "Old masterpiece painting"),
				new TableRow(3, -1, "Embroidered silk and velvet mantle set with numerous moonstones"),
				new TableRow(4, -1, "Platinum bracelet set wit ha sapphire"),
				new TableRow(5, -1, "Embroidered glove set with jewel chips"),
				new TableRow(6, -1, "Jeweled anklet"),
				new TableRow(7, -1, "Gold music box"),
				new TableRow(8, -1, "Gold circlet set with four aquamarines"),
				new TableRow(9, -1, "Eye patch wit ha mock eye set in blue sapphire and moonstone"),
				new TableRow(10, -1, "A necklace string of small pink pearls"),
			});

			public static readonly Table art_objects7500gp = new Table("7,500 GP Art Objects", new TableRow[]{
				new TableRow(1, -1, "Jeweled gold crown"),
				new TableRow(2, -1, "Jeweled platinum ring"),
				new TableRow(3, -1, "Small gold statuette set with rubies"),
				new TableRow(4, -1, "Gold cup set with emeralds"),
				new TableRow(5, -1, "Gold jewelry box with platinum filigree"),
				new TableRow(6, -1, "Painted gold child's sarcophagus"),
				new TableRow(7, -1, "Jade game board with solid gold playing pieces"),
				new TableRow(8, -1, "Bejeweled ivory drinking horn with gold filigree"),
			});

			public static readonly Table individual_treasure_challenge0_4 = new Table("Individual Treasure: Challenge 0-4", new TableRow[]{
				new TableRow(1, 30, "5d6 (17) cp"),
				new TableRow(31, 60, "4d6 (14) sp"),
				new TableRow(61, 70, "3d6 (10) ep"),
				new TableRow(71, 85, "3d6 (10) gp"),
				new TableRow(86, 90, "1d6 (3) pp"),
			});

			public static readonly Table individual_treasure_challenge5_10 = new Table("Individual Treasure: Challenge 5-10", new TableRow[]{
				new TableRow(1, 30, "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep"),
				new TableRow(31, 60, "6d6 x 10 (210) sp, 2d6 x 10 (70) gp"),
				new TableRow(61, 70, "3d6 x 10 (105) ep, 2d6 x 10 (70) gp"),
				new TableRow(71, 85, "4d6 x 10 (140) gp"),
				new TableRow(86, 90, "2d6 x 10 (70) gp, 3d6 (10) pp"),
			});

			public static readonly Table individual_treasure_challenge11_16 = new Table("Individual Treasure: Challenge 11-16", new TableRow[]{
				new TableRow(1, 20, "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp"),
				new TableRow(21, 35, "1d6 x 100 (350) ep, 1d6 x 100 (350) gp"),
				new TableRow(36, 75, "2d6 x 100 (700) gp, 1d6 x 10 (35) pp"),
				new TableRow(76, 100, "2d6 x 100 (700) gp, 2d6 x 10 (70) pp"),
			});

			public static readonly Table individual_treasure_challenge17_plus = new Table("Individual Treasure: Challenge 17+", new TableRow[]{
				new TableRow(1, 15, "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp"),
				new TableRow(16, 55, "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp"),
				new TableRow(56, 100, "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp"),
			});

			public static readonly Table treasure_hoard_challenge0_4 = new Table("Treasure Hoard: Challenge 0-4", new TableRow[]{
				new TableRow(1, 6, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp"),
				new TableRow(7, 16, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 10 gp gems"),
				new TableRow(17, 26, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects"),
				new TableRow(27, 36, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems"),
				new TableRow(37, 44, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A"),
				new TableRow(45, 52, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A"),
				new TableRow(53, 60, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A"),
				new TableRow(61, 65, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table B"),
				new TableRow(66, 70, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B"),
				new TableRow(71, 75, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table B"),
				new TableRow(76, -1, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp 2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(77, 78, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(79, 80, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C"),
				new TableRow(81, 85, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(86, 92, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F"),
				new TableRow(93, 97, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F"),
				new TableRow(98, 99, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 25 gp art objects, Roll once on Magic Item Table G"),
				new TableRow(100, -1, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems, Roll once on Magic Item Table G"),
			});

			public static readonly Table treasure_hoard_challenge5_10 = new Table("Treasure Hoard: Challenge 5-10", new TableRow[]{
				new TableRow(1, 4, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp"),
				new TableRow(5, 10, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects"),
				new TableRow(11, 16, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems"),
				new TableRow(17, 22, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems"),
				new TableRow(23, 28, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects"),
				new TableRow(29, 32, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A"),
				new TableRow(33, 36, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems, Roll 1d6 times on Magic Item Table A"),
				new TableRow(37, 40, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d6 times on Magic Item Table A"),
				new TableRow(41, 44, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table A"),
				new TableRow(45, 49, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B"),
				new TableRow(50, 54, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table B"),
				new TableRow(55, 59, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table B"),
				new TableRow(60, 63, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table B"),
				new TableRow(64, 66, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C"),
				new TableRow(67, 69, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(70, 72, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(73, 74, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table C"),
				new TableRow(75, 76, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects, Roll once on Magic Item Table D"),
				new TableRow(77, 78, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems, Roll once on Magic Item Table D"),
				new TableRow(79, -1, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll once on Magic Item Table D"),
				new TableRow(80, -1, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll once on Magic Item Table D"),
				new TableRow(81, 84, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F"),
				new TableRow(85, 88, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table F"),
				new TableRow(89, 91, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table F"),
				new TableRow(92, 94, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table F"),
				new TableRow(95, 96, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table G"),
				new TableRow(97, 98, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 250 gp art objects, Roll 1d4 times on Magic Item Table G"),
				new TableRow(99, -1, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll once on Magic Item Table H"),
				new TableRow(100, -1, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H"),
			});

			public static readonly Table treasure_hoard_challenge11_16 = new Table("Treasure Hoard: Challenge 11-16", new TableRow[]{
				new TableRow(1, 3, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp"),
				new TableRow(4, 6, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp2d4 (5) 250 gp art objects"),
				new TableRow(7, 9, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp2d4 (5) 750 gp art objects"),
				new TableRow(10, 12, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp3d6 (10) 500 gp gems"),
				new TableRow(13, 15, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp3d6 (10) 1,000 gp gems"),
				new TableRow(16, 19, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B"),
				new TableRow(20, 23, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B"),
				new TableRow(24, 26, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B"),
				new TableRow(27, 29, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B"),
				new TableRow(30, 35, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C"),
				new TableRow(36, 40, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll 1d6 times on Magic Item Table C"),
				new TableRow(41, 45, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll 1d6 times on Magic Item Table C"),
				new TableRow(46, 50, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table C"),
				new TableRow(51, 54, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table D"),
				new TableRow(55, 58, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table D"),
				new TableRow(59, 62, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table D"),
				new TableRow(63, 66, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table D"),
				new TableRow(67, 68, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll once on Magic Item Table E"),
				new TableRow(69, 70, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll once on Magic Item Table E"),
				new TableRow(71, 72, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll once on Magic Item Table E"),
				new TableRow(73, 75, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll once on Magic Item Table E"),
				new TableRow(76, 77, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G"),
				new TableRow(78, 79, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G"),
				new TableRow(80, 81, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G"),
				new TableRow(82, 83, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G"),
				new TableRow(84, 86, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H"),
				new TableRow(87, 89, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table H"),
				new TableRow(90, 91, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table H"),
				new TableRow(92, 93, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H"),
				new TableRow(94, 95, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 250 gp art objects, Roll once on Magic Item Table E"),
				new TableRow(96, 97, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 2d4 (5) 750 gp art objects, Roll once on Magic Item Table I"),
				new TableRow(98, 99, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 500 gp gems, Roll once on Magic Item Table I"),
				new TableRow(100, 101, "4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, 3d6 (10) 1,000 gp gems, Roll once on Magic Item Table I"),
			});

			public static readonly Table treasure_hoard_challenge17_plus = new Table("Treasure Hoard: Challenge 17+", new TableRow[]{
				new TableRow(1, 2, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp"),
				new TableRow(3, 5, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d8 times on Magic Item Table C"),
				new TableRow(6, 8, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d8 times on Magic Item Table C"),
				new TableRow(9, 11, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d8 times on Magic Item Table C"),
				new TableRow(12, 14, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d8 times on Magic Item Table C"),
				new TableRow(15, 22, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D"),
				new TableRow(23, 30, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D"),
				new TableRow(31, 38, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D"),
				new TableRow(39, 46, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D"),
				new TableRow(47, 52, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E"),
				new TableRow(53, 58, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E"),
				new TableRow(59, 63, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table E"),
				new TableRow(64, 68, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table E"),
				new TableRow(69, -1, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table G"),
				new TableRow(70, -1, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table G"),
				new TableRow(71, -1, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table G"),
				new TableRow(72, -1, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table G"),
				new TableRow(73, 74, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H"),
				new TableRow(75, 76, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table H"),
				new TableRow(77, 78, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table H"),
				new TableRow(79, 80, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table H"),
				new TableRow(81, 85, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I"),
				new TableRow(86, 90, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I"),
				new TableRow(91, 95, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I"),
				new TableRow(96, 100, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I"),
			});

			public static readonly Table potion_miscibility = new Table("Potion Miscibility", new TableRow[]{
				new TableRow(1, -1, "The mixture creates a magical explosion, dealing 6d10 force damage to the mixer and 1d10 force damage to each creature within 5 feet of the mixer."),
				new TableRow(2, 8, "The mixture becomes an ingested poison of the DM's choice."),
				new TableRow(9, 15, "Both potions lose their effects."),
				new TableRow(16, 25, "One potion loses its effect."),
				new TableRow(26, 35, "Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way."),
				new TableRow(36, 90, "Both potions work normally."),
				new TableRow(91, 99, "The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally."),
				new TableRow(100, -1, "Only one potion works, but its effect is permanent. Choose the simplest effect to make permanent, or the one that seems the most fun. For example, a potion of healing might increase the drinker's hit point maximum by 4, or oil of etherealness migth permanently trap the user in the Ethereal Plane. At your discretion, an appropriate spell, such as dispel magic or remove curse, might end this lasting effect."),
			});

			public static readonly Table scroll_mishap = new Table("Scroll Mishap", new TableRow[]{
				new TableRow(1, -1, "A surge of magical energy deals the caster 1d6 force damage per level of the spell"),
				new TableRow(2, -1, "The spell affects the caster or an ally (determined randomly) instead of the intended target, or it affects a random target nearby if the caster was the intended target."),
				new TableRow(3, -1, "The spell affects a random location within the spell's range."),
				new TableRow(4, -1, "The spell's effect is contrary to its normal one, but neither harmful nor beneficial. For instance, a fireball might produce an area of harmless cold."),
				new TableRow(5, -1, "The caster suffers a minor but bizarre effect related to the spell. Such effects last only as long as the original spell's duration, or 1d10 minutes for spells that take effect instantaneously. For example, a fireball might cause smoke to billow from the caster's ears for 1d10 minutes."),
				new TableRow(6, -1, "The spell activates after 1d12 hours. If the caster was the intended target, the spell takes effect normally. If the caster was not the intended target, the spell goes off in the general direction of the intended target, up to the spell's maximum range, if the target has moved away."),
			});

			public static readonly Table who_created_it_or_who_was_intended_to_use_it = new Table("Who Created It or Who Was Intended to Use It?", new TableRow[]{
				new TableRow(1, -1, "Aberration. The item was created by aberrations in ancient times, possibly for the use of favored humanoid thralls. When seen from the corner of the eye, the item seems to be moving."),
				new TableRow(2, 4, "Human. The item was created during the heyday of a fallen human kingdom, or it is tied to a human legend. It might hold writing in a forgotten tongue or symbols whose significance is lost to the ages."),
				new TableRow(5, -1, "Celestial. The weapon is half the normal weight and inscribed with feathered wings, suns, and other symbols of good. Fiends find the item's presence repulsive."),
				new TableRow(6, -1, "Dragon. This item is made from scales and talons shed by a dragon. Perhaps it incorporates precious metals and gems from the dragon's hoard. It grows slightly warm when within 120 feet of a dragon."),
				new TableRow(7, -1, "Drow. The item is half the normal weight. It is black and inscribed with spiders and webs in honor of Lolth. it might function poorly, or disintegrate, if exposed to sunlight for 1 minute or more."),
				new TableRow(8, 9, "Dwarf. The item is durable and has Dwarven runes worked into its design. It might be associated with a clan that would like to see it returned to their ancestral halls."),
				new TableRow(10, -1, "Elemental Air. The item is half the normal weight and feels hollow. If it's made of fabric, it is diaphanous."),
				new TableRow(11, -1, "Elemental Earth. This item might be crafted from stone. Any cloth of leather elements are studded with finely polished rock."),
				new TableRow(12, -1, "Elemental Fire. This item is warm to the touch, and any metal parts are crafted from black iron. Sigils of flames cover its surface. Shades of red and orange are the prominent colors."),
				new TableRow(13, -1, "Elemental Water. Lustrous fish scales replace leather or cloth on this item, and metal portions are instead crafted from seashells and worked coral as hard as any metal."),
				new TableRow(14, 15, "Elf. The item is half the normal weight. It is adorned with symbold of nature: leaves, vines, stars, and the like."),
				new TableRow(16, -1, "Fey. The item is exquisitely crafted from the finest materials and glows with a pale radiance in moonlight, shedding dim light in a 5-foot radius. Any metal in the item is silver or mithral, rather than iron or steel."),
				new TableRow(17, -1, "Fiend. The item is made of black iron or horn inscribed with runes, and any cloth or leather components are crafted from the hide of fiends. It is warm to the touch and features leering faces or vile runes engraved on its surface. Celestials find the item's presence repulsive."),
				new TableRow(18, -1, "Giant. The item is larger than normal and was crafted by giants for use by their smaller allies."),
				new TableRow(19, -1, "Gnome. The item is crafted to appear ordinary, and it might look worn. It could also incorporate gears and mechanical components, even if these aren't essential to the item's function."),
				new TableRow(20, -1, "Undead. The item incorporates imagery of death, such as bones and skulls, and it might be crafted from parts of corpses. It feels cold to the touch."),
			});

			public static readonly Table what_is_a_detail_from_its_history = new Table("What Is a Detail from Its History?", new TableRow[]{
				new TableRow(1, -1, "Arcane. This item was created for an ancient order of spellcasters and bears the order's symbol."),
				new TableRow(2, -1, "Bane. This item was created by the foes of a particular culture of kind of creature. If the culture or creatures are still around, they might recognize the item and single out the bearer as an enemy."),
				new TableRow(3, -1, "Heroic. A great hero once wielded this item. Anyone who's familiar with the item's history expects great deeds from the new owner."),
				new TableRow(4, -1, "Ornament. The item was created to honor a special occasion. Inset gemstones, gold or platinum inlays, and gold or silver filigree adorn its surface."),
				new TableRow(5, -1, "Prophecy. The item features in a prophecy: its bearer is destined to play a key role in future events. Someone else who wants to play that role might try to steal the item, or someone who wants to prevent the prophecy from being fulfilled might try to kill the item's bearer."),
				new TableRow(6, -1, "Religious. This item was used in religious ceremonies dedicated to a particular deity. It has holy symbols worked into it. The god's followers might try to persuade its owner to donate it to a temple, steal the item for themselves, or celebrate its use by a cleric or paladin of the same deity."),
				new TableRow(7, -1, "Sinister. This item is linked to a deed of great evil, such as a massacre or an assassination. It might have a name or be closely associated with a villain who used it. Anyone familiar with the item's history is likely to treat it and its owner with suspicion."),
				new TableRow(8, -1, "Symbol of Power. This item was once used as part of royal regalia or as a badge of high office. Its former owner or that person's descendants might desire it, or someone might mistakenly assume its new owner is the item's legitimate inheritor."),
			});

			public static readonly Table what_minor_property_does_it_have = new Table("What Minor Property does It Have?", new TableRow[]{
				new TableRow(1, -1, "Beacon. The bearer can use a bonus action to cause the item to shed bright light in a 10-foot radius and dim light for an additional 10 feet, or to extinguish the light."),
				new TableRow(2, -1, "Compass. The wielder can use an action to learn which way is north."),
				new TableRow(3, -1, "Conscientious. When the bearer of this item contemplates or undertakes a malevolent act, the item enhances pangs of conscience."),
				new TableRow(4, -1, "Delver. While underground, the bearer of this item always knows the item's depth below the surface and the direction to the nearest staircase, ramp, or other path leading upward."),
				new TableRow(5, -1, "Gleaming. This itme never gets dirty."),
				new TableRow(6, -1, "Guardian. The item whispers warnings to its bearer, granting a +2 bonus to initiative if the bearer isn't incapacitated"),
				new TableRow(7, -1, "Harmonious. Attuning to this item takes only 1 minute."),
				new TableRow(8, -1, "Hidden Message. A message is hidden somewhere on the item. It might be visible only at a certain time of the year, under the light of one phase of the moon, or in a specific location."),
				new TableRow(9, -1, "Key. The item is used to unlock a container, chamber, vault, or other entryway."),
				new TableRow(10, -1, "Language. The bearer can speak and understand a language of the DM's choice while the item is on the bearer's person."),
				new TableRow(11, -1, "Sentinel. Choose a kind of creature that is an enemy of the item's creator. This item glows faintly when such creatures are within 120 feet of it."),
				new TableRow(12, -1, "Song Craft. Whenever this item is struck or is used to strike a foe, its bearer hears a fragment of an ancient song."),
				new TableRow(13, -1, "Strange Material. The item was created from a material that is bizarre given its purpose. Its durability is unaffected."),
				new TableRow(14, -1, "Temperate. The bearer suffers no harm in temperatures as cold as -20 degrees Fahrenheit or as warm as 120 degrees Fahrenheit."),
				new TableRow(15, -1, "Unbreakable. The item can't be broken. Special means must be used to destroy it."),
				new TableRow(16, -1, "War Leader. The bearer can use an action to cause his or her voice to carry clearly for up to 300 feet until the end of the bearer's next turn."),
				new TableRow(17, -1, "Waterborne. This item floats on water and other liquids. Its bearer has advantage on Strength (Athletics) checks to swim."),
				new TableRow(18, -1, "Wicked. When the bearer is presented with an opportunity to act in a selfish or malevolent way, the item heightens the bearer's urge to do so."),
				new TableRow(19, -1, "Illusion. The item is imbued with illusion magic, allowing its bearer to alter the item's appearance in minor ways. Such alterations don't change how the item is worn, carried, or wielded, and they have no effect on its other magical properties. For example, the weare could make a red robe appear blue, or make a gold ring look like it's made of ivory. The item reverts to its true appearance when no one is carrying or wearing it."),
				new TableRow(20, -1, "Roll twice, rerolling any additional 20s."),
			});

			public static readonly Table what_quirk_does_it_have = new Table("What Quirk does It Have?", new TableRow[]{
				new TableRow(1, -1, "Blissful. While in possession of the item, the bearer feels fortunate and optimistic about what the future holds. Butterflies and other harmless creatures might frolic in the item's presence."),
				new TableRow(2, -1, "Confident. The item helps its bearer feel self-assured."),
				new TableRow(3, -1, "Covetous. The item's bearer becomes obsessed with material wealth."),
				new TableRow(4, -1, "Frail. The item crumbles, frays, chips, or cracks slightly when wielded, worn, or activated. This quirk has no effect on its properties, but if the item has seen much use, it looks decrepit."),
				new TableRow(5, -1, "Hungry. This item's magical properties function only if fresh blood from a humanoid has been applied to it within the past 24 hours. It needs only a drop to activate."),
				new TableRow(6, -1, "Loud. The item makes a loud noice -- such as a clang, a shout, or a resonating gong -- when used."),
				new TableRow(7, -1, "Metamorphic. The item periodically and randomly alters its appearance in slight ways. The bearer has no control over these minor alterations, which have no effect on the item's use."),
				new TableRow(8, -1, "Muttering. The item grumbles and mutters. A creature who listens carefully to the item might learn something useful."),
				new TableRow(9, -1, "Painful. The bearer experiences a harmless flash of pain when using the item."),
				new TableRow(10, -1, "Possessive. The item demands attunement when first wielded or worn, and it doesn't allow its bearer to attune to other items. (Other items already attuned to the bearer remain so until their attunemnt ends.)"),
				new TableRow(11, -1, "Repulsive. The bearer feels a sens of distaste when in contact with the item, and continues to sense discomfort while bearing it."),
				new TableRow(12, -1, "Slothful. The bearer of this item feels slothful and lethargic. While attuned to the item, the bearer requires 10 hours to finish a long rest."),
			});

			public static readonly Table magic_item_table_a = new Table("Magic Item Table A", new TableRow[]{
				new TableRow(1, 50, "Potion of healing"),
				new TableRow(51, 60, "Spell scroll (cantrip)"),
				new TableRow(61, 70, "Potion of climbing"),
				new TableRow(71, 90, "Spell scroll (1st level)"),
				new TableRow(91, 94, "Spell scroll (2nd level)"),
				new TableRow(95, 98, "Potion of greater healing"),
				new TableRow(99, -1, "Bag of holding"),
				new TableRow(100, -1, "Driftglobe"),
			});

			public static readonly Table magic_item_table_b = new Table("Magic Item Table B", new TableRow[]{
				new TableRow(1, 15, "Potion of greater healing"),
				new TableRow(16, 22, "Potion of fire breath"),
				new TableRow(23, 29, "Potion of resistance"),
				new TableRow(30, 34, "Ammunition, +1"),
				new TableRow(35, 39, "Potion of animal friendship"),
				new TableRow(40, 44, "Potion of hill giant strength"),
				new TableRow(45, 49, "Potion of growth"),
				new TableRow(50, 54, "Potion of water breathing"),
				new TableRow(55, 59, "Spell scroll (2nd level)"),
				new TableRow(60, 64, "Spell scroll (3rd level)"),
				new TableRow(65, 67, "Bag of holding"),
				new TableRow(68, 70, "Keoghtom's ointment"),
				new TableRow(71, 73, "Oil of slipperiness"),
				new TableRow(74, 75, "Dust of disappearance"),
				new TableRow(76, 77, "Dust of dryness"),
				new TableRow(78, 79, "Dust of sneezing and choking"),
				new TableRow(80, 81, "Elemental gem"),
				new TableRow(82, 83, "Philter of love"),
				new TableRow(84, -1, "Alchemy jug"),
				new TableRow(85, -1, "Cap of water breathing"),
				new TableRow(86, -1, "Cloak of the manta ray"),
				new TableRow(87, -1, "Driftglobe"),
				new TableRow(88, -1, "Goggles of night"),
				new TableRow(89, -1, "Helm of comprehending languages"),
				new TableRow(90, -1, "Immovable rod"),
				new TableRow(91, -1, "Lantern of revealing"),
				new TableRow(92, -1, "Mariner's armor"),
				new TableRow(93, -1, "Mithral armor"),
				new TableRow(94, -1, "Potion of poison"),
				new TableRow(95, -1, "Ring of swimming"),
				new TableRow(96, -1, "Robe of useful items"),
				new TableRow(97, -1, "Rope of climbing"),
				new TableRow(98, -1, "Saddle of the cavalier"),
				new TableRow(99, -1, "Wand of magic detection"),
				new TableRow(100, -1, "Wand of secrets"),
			});

			public static readonly Table magic_item_table_c = new Table("Magic Item Table C", new TableRow[]{
				new TableRow(1, 15, "Potion of superior healing"),
				new TableRow(16, 22, "Spell scroll (4th level)"),
				new TableRow(23, 27, "Ammunition, +2"),
				new TableRow(28, 32, "Potion of clairvoyance"),
				new TableRow(33, 37, "Potion of diminution"),
				new TableRow(38, 42, "Potion of gaseous form"),
				new TableRow(43, 47, "Potion of frost giant strength"),
				new TableRow(48, 52, "Potion of stone giant strength"),
				new TableRow(53, 57, "Potion of heroism"),
				new TableRow(58, 62, "Potion of invulnerability"),
				new TableRow(63, 67, "Potion of mind reading"),
				new TableRow(68, 72, "Spell scroll (5th level)"),
				new TableRow(73, 75, "Elixir of health"),
				new TableRow(76, 78, "Oil of etherealness"),
				new TableRow(79, 81, "Potion of fire giant strength"),
				new TableRow(82, 84, "Quaal's feather token"),
				new TableRow(85, 87, "Scroll of protection"),
				new TableRow(88, 89, "Bag of beans"),
				new TableRow(90, 91, "Bead of force"),
				new TableRow(92, -1, "Chime of opening"),
				new TableRow(93, -1, "Decanter of endless water"),
				new TableRow(94, -1, "Eyes of minute seeing"),
				new TableRow(95, -1, "Folding boat"),
				new TableRow(96, -1, "Heward's handy haversack"),
				new TableRow(97, -1, "Horseshoes of speed"),
				new TableRow(98, -1, "Necklace of fireballs"),
				new TableRow(99, -1, "Periapt of health"),
				new TableRow(100, -1, "Sending stones"),
			});

			public static readonly Table magic_item_table_d = new Table("Magic Item Table D", new TableRow[]{
				new TableRow(1, 20, "Potion of supreme healing"),
				new TableRow(21, 30, "Potion of invisibility"),
				new TableRow(31, 40, "Potion of speed"),
				new TableRow(41, 50, "Spell scroll (6th level)"),
				new TableRow(51, 57, "Spell scroll (7th level)"),
				new TableRow(58, 62, "Ammunition, +3"),
				new TableRow(63, 67, "Oil of sharpness"),
				new TableRow(68, 72, "Potion of flying"),
				new TableRow(73, 77, "Potion of cloud giant strength"),
				new TableRow(78, 82, "Potion of longevity"),
				new TableRow(83, 87, "Potion of vitality"),
				new TableRow(88, 92, "Spell scroll (8th level)"),
				new TableRow(93, 95, "Horseshoes of a zephyr"),
				new TableRow(96, 97, "Nolzur's marvelous pigments"),
				new TableRow(98, -1, "Bag of devouring"),
				new TableRow(99, -1, "Portable hole"),
			});

			public static readonly Table magic_item_table_e = new Table("Magic Item Table E", new TableRow[]{
				new TableRow(1, 30, "Spell scroll (8th level)"),
				new TableRow(31, 45, "Potion of storm giant strength"),
				new TableRow(46, 60, "Potion of supreme healing"),
				new TableRow(61, 75, "Spell scroll (9th level)"),
				new TableRow(76, 83, "Universal solvent"),
				new TableRow(84, 88, "Arrow of slaying"),
				new TableRow(89, 90, "Sovereign glue"),
			});

			public static readonly Table magic_item_table_f = new Table("Magic Item Table F", new TableRow[]{
				new TableRow(1, 15, "Weapon, +1"),
				new TableRow(16, 18, "Shield, +1"),
				new TableRow(19, 21, "Sentinel shield"),
				new TableRow(22, 23, "Amulet of proof against detection and location"),
				new TableRow(24, 25, "Boots of elvenkind"),
				new TableRow(26, 27, "Boots of striding and springing"),
				new TableRow(28, 29, "Bracers of archery"),
				new TableRow(30, 31, "Brooch of shielding"),
				new TableRow(32, 33, "Broom of flying"),
				new TableRow(34, 35, "Cloak of elvenkind"),
				new TableRow(36, 37, "Cloak of protection"),
				new TableRow(38, 39, "Gauntlets of ogre power"),
				new TableRow(40, 41, "Hat of disguise"),
				new TableRow(42, 43, "Javelin of lightning"),
				new TableRow(44, 45, "Pearl of power"),
				new TableRow(46, 47, "Rod of the pact keeper, +1"),
				new TableRow(48, 49, "Slippers of spider climbing"),
				new TableRow(50, 51, "Staff of the adder"),
				new TableRow(52, 53, "Staff of the python"),
				new TableRow(54, 55, "Sword of vengeance"),
				new TableRow(56, 57, "Trident of fish command"),
				new TableRow(58, 59, "Wand of magic missiles"),
				new TableRow(60, 61, "Wand of the war mage, +1"),
				new TableRow(62, 63, "Wand of web"),
				new TableRow(64, 65, "Weapon of warning"),
				new TableRow(66, -1, "Adamantine armor (chain mail"),
				new TableRow(67, -1, "Adamantine armor (chain shirt)"),
				new TableRow(68, -1, "Adamantine armor (scale mail)"),
				new TableRow(69, -1, "Bag of tricks (gray)"),
				new TableRow(70, -1, "Bag of tricks (rust)"),
				new TableRow(71, -1, "Bag of tricks (tan)"),
				new TableRow(72, -1, "Boots of the winterlands"),
				new TableRow(73, -1, "Circlet of blasting"),
				new TableRow(74, -1, "Deck of illusions"),
				new TableRow(75, -1, "Eversmoking bottle"),
				new TableRow(76, -1, "Eyes of charming"),
				new TableRow(77, -1, "Eyes of the eagle"),
				new TableRow(78, -1, "FIgurine of wondrous power (silver raven)"),
				new TableRow(79, -1, "Gem of brightness"),
				new TableRow(80, -1, "Gloves of missile snaring"),
				new TableRow(81, -1, "Gloves of swimming and climbing"),
				new TableRow(82, -1, "Gloves of thievery"),
				new TableRow(83, -1, "Headband of intellect"),
				new TableRow(84, -1, "Helm of telepathy"),
				new TableRow(85, -1, "Instrument of the bards (Doss lute)"),
				new TableRow(86, -1, "Instrument of the bards (Fochlucan bandore)"),
				new TableRow(87, -1, "Instrument of the bards (Mac-Fuimidh cittern)"),
				new TableRow(88, -1, "Medallion of thoughts"),
				new TableRow(89, -1, "Necklace of adaptation"),
				new TableRow(90, -1, "Periapt of wound closure"),
				new TableRow(91, -1, "Pipes of haunting"),
				new TableRow(92, -1, "Pipes of the sewers"),
				new TableRow(93, -1, "Ring of jumping"),
				new TableRow(94, -1, "Ring of mind shielding"),
				new TableRow(95, -1, "Ring of warmth"),
				new TableRow(96, -1, "Ring of water walking"),
				new TableRow(97, -1, "Quiver of Ehlonna"),
				new TableRow(98, -1, "Stone of good luck"),
				new TableRow(99, -1, "Wind fan"),
				new TableRow(100, -1, "Winged boots"),
			});

			public static readonly Table magic_item_table_g = new Table("Magic Item Table G", new TableRow[]{
				new TableRow(1, 11, "Weapon, +2"),
				new TableRow(12, 13, "Figurine of wondrous power (roll d8), 1 - Bronze griffon, 2 - Ebony fly, 3 - Golden lions, 4 - Ivory goats, 5 - Marble elephant, 6-7 - Onyx dog, 8 - Serpentine owl"),
				new TableRow(14, -1, "Adamantine armor (breastplate)"),
				new TableRow(15, -1, "Adamantine armor (splint)"),
				new TableRow(16, -1, "Amulet of health"),
				new TableRow(17, -1, "Armor of vulnerability"),
				new TableRow(18, -1, "Arrow-catching shield"),
				new TableRow(19, -1, "Belt of dwarvenkind"),
				new TableRow(20, -1, "Belt of hill giant strength"),
				new TableRow(21, -1, "Berserker axe"),
				new TableRow(22, -1, "Boots of levitation"),
				new TableRow(23, -1, "Boots of speed"),
				new TableRow(24, -1, "Bowl of commanding water elementals"),
				new TableRow(25, -1, "Bracers of defense"),
				new TableRow(26, -1, "Brazier of commanding fire elementals"),
				new TableRow(27, -1, "Cape of the mountebank"),
				new TableRow(28, -1, "Censer of controlling air elementals"),
				new TableRow(29, -1, "Armor, +1 chain mail"),
				new TableRow(30, -1, "Armor of resistance (chain mail)"),
				new TableRow(31, -1, "Armor, +1 chain shirt"),
				new TableRow(32, -1, "Armor of resistance (chain shirt)"),
				new TableRow(33, -1, "Cloak of displacement"),
				new TableRow(34, -1, "Cloak of the bat"),
				new TableRow(35, -1, "Cube of force"),
				new TableRow(36, -1, "Daern's instant fortress"),
				new TableRow(37, -1, "Dagger of venom"),
				new TableRow(38, -1, "Dimensional shackles"),
				new TableRow(39, -1, "Dragon slayer"),
				new TableRow(40, -1, "Elven chain"),
				new TableRow(41, -1, "Flame tongue"),
				new TableRow(42, -1, "Gem of seeing"),
				new TableRow(43, -1, "Giant slayer"),
				new TableRow(44, -1, "Glamoured studded leather"),
				new TableRow(45, -1, "Helm of teleportation"),
				new TableRow(46, -1, "Horn of blasting"),
				new TableRow(47, -1, "Horn of Valhalla (silver or brass)"),
				new TableRow(48, -1, "Instrument of the bards (Canaith mandolin)"),
				new TableRow(49, -1, "Instrument of the bards (Cli lyre)"),
				new TableRow(50, -1, "Ioun stone (awareness)"),
				new TableRow(51, -1, "Ioun stone (protection)"),
				new TableRow(52, -1, "Ioun stone (reserve)"),
				new TableRow(53, -1, "Ioun stone (sustenance)"),
				new TableRow(54, -1, "Iron bands of Bilarro"),
				new TableRow(55, -1, "Armor, +1 leather"),
				new TableRow(56, -1, "Armor of resistance (leather)"),
				new TableRow(57, -1, "Mace of disruption"),
				new TableRow(58, -1, "Mace of smiting"),
				new TableRow(59, -1, "Mace of terror"),
				new TableRow(60, -1, "Mantle of spell resistance"),
				new TableRow(61, -1, "Necklace of prayer beads"),
				new TableRow(62, -1, "Periapt of proof against poison"),
				new TableRow(63, -1, "Ring of animal influence"),
				new TableRow(64, -1, "Ring of evasion"),
				new TableRow(65, -1, "Ring of feather falling"),
				new TableRow(66, -1, "Ring of free action"),
				new TableRow(67, -1, "Ring of protection"),
				new TableRow(68, -1, "Ring of resistance"),
				new TableRow(69, -1, "Ring of spell storing"),
				new TableRow(70, -1, "Ring of the ram"),
				new TableRow(71, -1, "Ring of X-ray vision"),
				new TableRow(72, -1, "Robe of eyes"),
				new TableRow(73, -1, "Rod of rulership"),
				new TableRow(74, -1, "Rod of the pact keeper, +2"),
				new TableRow(75, -1, "Rope of entanglement"),
				new TableRow(76, -1, "Armor, +1 scale mail"),
				new TableRow(77, -1, "Armor of resistance (scale mail)"),
				new TableRow(78, -1, "Shield, +2"),
				new TableRow(79, -1, "Shield of missile attraction"),
				new TableRow(80, -1, "Staff of charming"),
				new TableRow(81, -1, "Staff of healing"),
				new TableRow(82, -1, "Staff of swarming insects"),
				new TableRow(83, -1, "Staff of the woodlands"),
				new TableRow(84, -1, "Staff of withering"),
				new TableRow(85, -1, "Stone of controlling earth elementals"),
				new TableRow(86, -1, "Sun blade"),
				new TableRow(87, -1, "Sword of life stealing"),
				new TableRow(88, -1, "Sword of wounding"),
				new TableRow(89, -1, "Tentacle rod"),
				new TableRow(90, -1, "Vicious weapon"),
				new TableRow(91, -1, "Wand of binding"),
				new TableRow(92, -1, "Wand of enemy detection"),
				new TableRow(93, -1, "Wand of fear"),
				new TableRow(94, -1, "Wand of fireballs"),
				new TableRow(95, -1, "Wand of lightning bolts"),
				new TableRow(96, -1, "Wand of paralysis"),
				new TableRow(97, -1, "Wand of the war mage, +2"),
				new TableRow(98, -1, "Wand of wonder"),
				new TableRow(99, -1, "Wings of flying"),
			});

			public static readonly Table magic_item_table_h = new Table("Magic Item Table H", new TableRow[]{
				new TableRow(1, 10, "Weapon, +3"),
				new TableRow(11, 12, "Amulet of the planes"),
				new TableRow(13, 15, "Carpet of flying"),
				new TableRow(16, 17, "Crystal ball (very rare version)"),
				new TableRow(18, 19, "Ring of regeneration"),
				new TableRow(20, 21, "Ring of shooting stars"),
				new TableRow(22, 23, "Ring of telekinesis"),
				new TableRow(24, 25, "Robe of scintillating colors"),
				new TableRow(26, 27, "Robe of stars"),
				new TableRow(28, 29, "Rod of absorption"),
				new TableRow(30, 31, "Rod of alertness"),
				new TableRow(32, 33, "Rod of security"),
				new TableRow(34, 35, "Rod of the pact keeper, +3"),
				new TableRow(36, 37, "Scimitar of speed"),
				new TableRow(38, 39, "Shield, +3"),
				new TableRow(40, 41, "Staff of fire"),
				new TableRow(42, 43, "Staff of frost"),
				new TableRow(44, 45, "Staff of power"),
				new TableRow(46, 47, "Staff of striking"),
				new TableRow(48, 49, "Staff of thunder and lightning"),
				new TableRow(50, 51, "Sword of sharpness"),
				new TableRow(52, 53, "Wand of polymorph"),
				new TableRow(54, 55, "Wand of the war mage, +3"),
				new TableRow(56, -1, "Adamantine armor (half plate)"),
				new TableRow(57, -1, "Adamantine armor (plate)"),
				new TableRow(58, -1, "Animated shield"),
				new TableRow(59, -1, "Belt of fire giant strength"),
				new TableRow(60, -1, "Belt of frost (or stone) giant strength"),
				new TableRow(61, -1, "Armor, +1 breastplate"),
				new TableRow(62, -1, "Armor of resistance (breastplate)"),
				new TableRow(63, -1, "Candle of invocation"),
				new TableRow(64, -1, "Armor, +2 chain mail"),
				new TableRow(65, -1, "Armor, +2 chain shirt"),
				new TableRow(66, -1, "Cloak of arachnida"),
				new TableRow(67, -1, "Dancing sword"),
				new TableRow(68, -1, "Demon armor"),
				new TableRow(69, -1, "Dragon scale mail"),
				new TableRow(70, -1, "Dwarven plate"),
				new TableRow(71, -1, "Dwarven thrower"),
				new TableRow(72, -1, "Efreeti bottle"),
				new TableRow(73, -1, "Figurine of wondrous poer (obsidian steed)"),
				new TableRow(74, -1, "Frost brand"),
				new TableRow(75, -1, "Helm of briliance"),
				new TableRow(76, -1, "Horn of Valhalla (bronze)"),
				new TableRow(77, -1, "Instrument of the bards (Anstruth harp)"),
				new TableRow(78, -1, "Ioun stone (absorption)"),
				new TableRow(79, -1, "Ioun stone (agility)"),
				new TableRow(80, -1, "Ioun stone (fortitude)"),
				new TableRow(81, -1, "Ioun stone (insight)"),
				new TableRow(82, -1, "Ioun stone (intellect)"),
				new TableRow(83, -1, "Ioun stone (leadership)"),
				new TableRow(84, -1, "Ioun stone (strength)"),
				new TableRow(85, -1, "Armor, +2 leather"),
				new TableRow(86, -1, "Manual of bodily health"),
				new TableRow(87, -1, "Manual of gainful exercise"),
				new TableRow(88, -1, "Manual of golems"),
				new TableRow(89, -1, "Manual of quickness of action"),
				new TableRow(90, -1, "Mirror of life trapping"),
				new TableRow(91, -1, "Nine lives stealer"),
				new TableRow(92, -1, "Oathbow"),
				new TableRow(93, -1, "Armor, +2 scale mail"),
				new TableRow(94, -1, "Spellguard shield"),
				new TableRow(95, -1, "Armor, +1 splint"),
				new TableRow(96, -1, "Armor of resistance (splint)"),
				new TableRow(97, -1, "Armor, +1 studded leather"),
				new TableRow(98, -1, "Armor of resistance (studded leather)"),
				new TableRow(99, -1, "Tome of clear thought"),
				new TableRow(100, -1, "Tome of leadership and influence"),
				new TableRow(101, -1, "Tome of understanding"),
			});

			public static readonly Table magic_item_table_i = new Table("Magic Item Table I", new TableRow[]{
				new TableRow(1, 5, "Defender"),
				new TableRow(6, 10, "Hammer of thunderbolts"),
				new TableRow(11, 15, "Luck blade"),
				new TableRow(16, 20, "Sword of answering"),
				new TableRow(21, 23, "Holy avenger"),
				new TableRow(24, 26, "Ring of djinni summoning"),
				new TableRow(27, 29, "Ring of invisibility"),
				new TableRow(30, 32, "Ring of spell turning"),
				new TableRow(33, 35, "Rod of lordly might"),
				new TableRow(36, 38, "Staff of the magi"),
				new TableRow(39, 41, "Vorpal sword"),
				new TableRow(42, 43, "Belt of cloud giant strength"),
				new TableRow(44, 45, "Armor, +2 breastplate"),
				new TableRow(46, 47, "Armor, +3 chain mail"),
				new TableRow(48, 49, "Armor, +3 chain shirt"),
				new TableRow(50, 51, "Cloak of invisibility"),
				new TableRow(52, 53, "Crystal ball (legendary version)"),
				new TableRow(54, 55, "Armor, +1 half plate"),
				new TableRow(56, 57, "Iron flask"),
				new TableRow(58, 59, "Armor, +3 leather"),
				new TableRow(60, 61, "Armor, +1 plate"),
				new TableRow(62, 63, "Robe of the archmagi"),
				new TableRow(64, 65, "Rod of resurrection"),
				new TableRow(66, 67, "Armor, +1 scale mail"),
				new TableRow(68, 69, "Scarab of protection"),
				new TableRow(70, 71, "Armor, +2 splint"),
				new TableRow(72, 73, "Armor, +2 studded leather"),
				new TableRow(74, 75, "Well of many worlds"),
				new TableRow(76, -1, "Magic armor (roll d12), 1-2 - Armor, +2 half plate, 3-4 - Armor, +2 plate, 5-6 - Armor, +3 studded leather, 7-8 - Armor, +3 breastplate, 9-10 - Armor, +3 splint, 11 - Armor, +3 half plate, 12 - Armor, +3 plate"),
				new TableRow(77, -1, "Apparatus of Kwalish"),
				new TableRow(78, -1, "Armor of invulnerability"),
				new TableRow(79, -1, "Belt of storm giant strength"),
				new TableRow(80, -1, "Cubic gate"),
				new TableRow(81, -1, "Deck of many things"),
				new TableRow(82, -1, "Efreeti chain"),
				new TableRow(83, -1, "Armor of resistance (half plate)"),
				new TableRow(84, -1, "Horn of Valhalla (iron)"),
				new TableRow(85, -1, "Instrument of the bards (Ollamh harp)"),
				new TableRow(86, -1, "Ioun stone (greater absorption)"),
				new TableRow(87, -1, "Ioun stone (mastery)"),
				new TableRow(88, -1, "Ioun stone (regeneration)"),
				new TableRow(89, -1, "Plate armor of etherealness"),
				new TableRow(90, -1, "Plate armor of resistance"),
				new TableRow(91, -1, "Ring of air elemental command"),
				new TableRow(92, -1, "Ring of earth elemental command"),
				new TableRow(93, -1, "Ring of fire elemental command"),
				new TableRow(94, -1, "Ring of three wishes"),
				new TableRow(95, -1, "Ring of water elemental command"),
				new TableRow(96, -1, "Sphere of annihilation"),
				new TableRow(97, -1, "Talisman of pure good"),
				new TableRow(98, -1, "Talisman of the sphere"),
				new TableRow(99, -1, "Talisman of ultimate evil"),
				new TableRow(100, -1, "Tome of the stilled tongue"),
			});

			public static readonly Table armor_of_resistance_damage_type = new Table("Armor of Resistance Damage Type", new TableRow[]{
				new TableRow(1, -1, "Acid"),
				new TableRow(2, -1, "Cold"),
				new TableRow(3, -1, "Fire"),
				new TableRow(4, -1, "Force"),
				new TableRow(5, -1, "Lightning"),
				new TableRow(6, -1, "Necrotic"),
				new TableRow(7, -1, "Poison"),
				new TableRow(8, -1, "Psychic"),
				new TableRow(9, -1, "Radiant"),
				new TableRow(10, -1, "Thunder"),
			});

			public static readonly Table bag_of_beans_effect = new Table("Bag of Beans Effect", new TableRow[]{
				new TableRow(1, -1, "5d4 toadstools sprout. If a creature eats a toadstool, roll any die. On an odd roll, the eater must succeed on a DC 15 Constitution saving throw or take 5d6 poison damage and become poisoned for 1 hour. On an even roll, the eater gains 5d6 temporary hit points for 1 hour."),
				new TableRow(2, 10, "A geyser erupts and sprouts water, beer, berry juice, tea, vinegar, wine, or oil (DM's choice) 30 feet into the air for 1d12 rounds."),
				new TableRow(11, 20, "A treant sprouts (see the Monster Manual for statistics). There's a 50 percent chance that the treant is chaotic evil and attacks"),
				new TableRow(21, 30, "An animate, immobile stone statue in your likeness rises. It makes verbal threats against you. If you leave it and others come near, it describes you as the most heinous of villains and directs the newcomers to find and attack you. If you are on the same plane of existence as the statue, it nows where you are. The statue becomes inanimate after 24 hours."),
				new TableRow(31, 40, "A campfire with blue flames springs forth and burns for 24 hours (or until it is extinguished)."),
				new TableRow(41, 50, "1d6 + 6 shriekers sprout (see the Monster Manual for statistics)."),
				new TableRow(51, 60, "1d4 + 8 bright pink toads crawl forth. Whenever a toad is touched, it transforms into a large or smaller monster of the DM's choice. The monster remains for 1 minute, then disappears in a puff of smoke."),
				new TableRow(61, 70, "A hungry bulette (see the Monster Manual for statistics) burrows up and attacks."),
				new TableRow(71, 80, "A fruit tree grows. It has 1d10 + 20 fruit, 1d8 of which act as randomly determined magic potions, while one acts as an ingested poison of the DM's choice. The tree vanishes after 1 hour. Picked fruit remains, retaining any magic for 30 days."),
				new TableRow(81, 90, "A nest of 1d4 + 3 eggs springs up. Any creature that eats an egg must make a DC 20 Constitution saving throw. On a successful save, a creature permanently increases its lowest ability score by 1, randomly choosing among equally low scores. On a failed save, the creature takes 10d6 force damage from an internal magical explosion."),
				new TableRow(91, 99, "A pyramid with a 60-foot-square base bursts upward. Inside is a sarcophagus containing a mummy lord (see the Monster Manual for statistics). The pyramid is treated as the mummy lord's lair, and its sarcophagus contains treasure of the DM's choice."),
				new TableRow(100, -1, "A giant beanstalk sprouts, growing to a height of the DM's choice. The top leads where the DM chooses, such as to a great view, a cloud giant's castle, or a different plane of existence."),
			});

			public static readonly Table gray_bag_of_tricks = new Table("Gray Bag of Tricks", new TableRow[]{
				new TableRow(1, -1, "Weasel"),
				new TableRow(2, -1, "Giant rat"),
				new TableRow(3, -1, "Badger"),
				new TableRow(4, -1, "Boar"),
				new TableRow(5, -1, "Panther"),
				new TableRow(6, -1, "Giant badger"),
				new TableRow(7, -1, "Dire wolf"),
				new TableRow(8, -1, "Giant elk"),
			});

			public static readonly Table rust_bag_of_tricks = new Table("Rust Bag of Tricks", new TableRow[]{
				new TableRow(1, -1, "Rat"),
				new TableRow(2, -1, "Owl"),
				new TableRow(3, -1, "Mastiff"),
				new TableRow(4, -1, "Goat"),
				new TableRow(5, -1, "Giant goat"),
				new TableRow(6, -1, "Giant boar"),
				new TableRow(7, -1, "Lion"),
				new TableRow(8, -1, "Brown bear"),
			});

			public static readonly Table tan_bag_of_tricks = new Table("Tan Bag of Tricks", new TableRow[]{
				new TableRow(1, -1, "Jackal"),
				new TableRow(2, -1, "Ape"),
				new TableRow(3, -1, "Baboon"),
				new TableRow(4, -1, "Axe beak"),
				new TableRow(5, -1, "Black bear"),
				new TableRow(6, -1, "Giant weasel"),
				new TableRow(7, -1, "Giant hyena"),
				new TableRow(8, -1, "Tiger"),
			});

			public static readonly Table candle_of_invocation_alignment = new Table("Candle of Invocation Alignment", new TableRow[]{
				new TableRow(1, -1, "Chaotic evil"),
				new TableRow(2, -1, "Chaotic neutral"),
				new TableRow(3, -1, "Chaotic good"),
				new TableRow(4, -1, "Neutral evil"),
				new TableRow(5, -1, "Neutral"),
				new TableRow(6, -1, "Neutral good"),
				new TableRow(7, -1, "Lawful evil"),
				new TableRow(8, -1, "Lawful neutral"),
				new TableRow(9, -1, "Lawful good"),
			});

			public static readonly Table carpet_of_flying_size = new Table("Carpet of Flying - Size", new TableRow[]{
				new TableRow(1, 20, "3 ft. x 5 ft."),
				new TableRow(21, 55, "4 ft. x 6 ft."),
				new TableRow(56, 80, "5 ft. x 7 ft."),
				new TableRow(81, 100, "6 ft. x 9 ft."),
			});

			public static readonly Table carpet_of_flying_capacity = new Table("Carpet of Flying - Capacity", new TableRow[]{
				new TableRow(1, 20, "200 lb."),
				new TableRow(21, 55, "400 lb."),
				new TableRow(56, 80, "600 lb."),
				new TableRow(81, 100, "800 lb."),
			});

			public static readonly Table carpet_of_flying_flying_speed = new Table("Carpet of Flying - Speed", new TableRow[]{
				new TableRow(1, 20, "80 feet"),
				new TableRow(21, 55, "60 feet"),
				new TableRow(56, 80, "40 feet"),
				new TableRow(81, 100, "30 feet"),
			});

			public static readonly Table efreeti_bottle_effect = new Table("Efreeti Bottle Effect", new TableRow[]{
				new TableRow(1, 10, "The efreeti attacks you. After fighting for 5 rounds, the efreeti disappears, and the bottle loses its magic."),
				new TableRow(11, 90, "The efreeti serves you for 1 hour, doing as you command. Then the efreeti returns to the bottle, and a new stopper contains it. The stopper can't be removed for 24 hours. The next two times the bottle is opened, the same effect occurs. If the bottle is opened a fourth time, the efreeti excapes and disappears, and the bottle loses its magic."),
				new TableRow(91, 100, "The efreeti can cast the wish spell three times for you. It disappears when it grans the final wish or after 1 hour, and the bottle loses its magic."),
			});

			public static readonly Table horn_of_valhalla_horn_type = new Table("Horn of Valhalla - Horn Type", new TableRow[]{
				new TableRow(1, 40, "Silver"),
				new TableRow(41, 75, "Brass"),
				new TableRow(76, 90, "Bronze"),
				new TableRow(91, 100, "Iron"),
			});

			public static readonly Table horn_of_valhalla_berserkers_summoned = new Table("Horn of Valhalla - Berserkers Summoned", new TableRow[]{
				new TableRow(1, 40, "2d4 + 2"),
				new TableRow(41, 75, "3d4 + 3"),
				new TableRow(76, 90, "4d4 + 4"),
				new TableRow(91, 100, "5d4 + 5"),
			});

			public static readonly Table horn_of_valhalla_requirement = new Table("Horn of Valhalla - Requirements", new TableRow[]{
				new TableRow(1, 40, "None"),
				new TableRow(41, 75, "Proficiency with all simple weapons"),
				new TableRow(76, 90, "Proficiency with  all medium armor"),
				new TableRow(91, 100, "Proficiency with all martial weapons"),
			});

			public static readonly Table iron_flask_contents = new Table("Iron Flask Contents", new TableRow[]{
				new TableRow(1, 50, "Empty"),
				new TableRow(51, -1, "Arcanaloth"),
				new TableRow(52, -1, "Cambion"),
				new TableRow(53, 54, "Dao"),
				new TableRow(55, 57, "Demon (type 1)"),
				new TableRow(58, 60, "Demon (type 2)"),
				new TableRow(61, 62, "Demon (type 3)"),
				new TableRow(63, 64, "Demon (type 4)"),
				new TableRow(65, -1, "Demon (type 5)"),
				new TableRow(66, -1, "Demon (type 6)"),
				new TableRow(67, -1, "Deva"),
				new TableRow(68, 69, "Devil (greater)"),
				new TableRow(70, 72, "Devil (lesser)"),
				new TableRow(73, -1, "Djinni"),
				new TableRow(74, 75, "Efreeti"),
				new TableRow(76, 77, "Elemental (any)"),
				new TableRow(78, -1, "Githyanki knight"),
				new TableRow(79, -1, "Githzerai zerth"),
				new TableRow(80, 81, "Invisible stalker"),
				new TableRow(82, 83, "Marid"),
				new TableRow(84, 85, "Mezzoloth"),
				new TableRow(86, 87, "Night hag"),
				new TableRow(88, 89, "Nycaloth"),
				new TableRow(90, -1, "Planetar"),
				new TableRow(91, 92, "Salamander"),
				new TableRow(93, 94, "Slaad (any)"),
				new TableRow(95, -1, "Solar"),
				new TableRow(96, 97, "Succubus/incubus"),
				new TableRow(98, -1, "Ultroloth"),
				new TableRow(99, -1, "Xorn"),
			});

			public static readonly Table manual_of_golems_golem = new Table("Manual of Golems - Golem", new TableRow[]{
				new TableRow(1, 5, "Clay"),
				new TableRow(6, 17, "Flesh"),
				new TableRow(18, -1, "Iron"),
				new TableRow(19, 20, "Stone"),
			});

			public static readonly Table manual_of_golems_time = new Table("Manual of Golems - Time", new TableRow[]{
				new TableRow(1, 5, "30 days"),
				new TableRow(6, 17, "60 days"),
				new TableRow(18, -1, "120 days"),
				new TableRow(19, 20, "90 days"),
			});

			public static readonly Table manual_of_golems_cost = new Table("Manual of Golems - Cost", new TableRow[]{
				new TableRow(1, 5, "65,000 gp"),
				new TableRow(6, 17, "50,000 gp"),
				new TableRow(18, -1, "100,000 gp"),
				new TableRow(19, 20, "80,000 gp"),
			});

			public static readonly Table necklace_of_prayer_beads_bead_of = new Table("Necklace of Prayer Beads - Bead of", new TableRow[]{
				new TableRow(1, 6, "Blessing"),
				new TableRow(7, 12, "Curing"),
				new TableRow(13, 16, "Favor"),
				new TableRow(17, 18, "Smiting"),
				new TableRow(19, -1, "Summons"),
				new TableRow(20, -1, "Wind walking"),
			});

			public static readonly Table necklace_of_prayer_beads_spell = new Table("Necklace of Prayer Beads - Spell", new TableRow[]{
				new TableRow(1, 6, "Bless"),
				new TableRow(7, 12, "Cure wounds (2nd level) or lesser restoration"),
				new TableRow(13, 16, "Greater restoration"),
				new TableRow(17, 18, "Branding smite"),
				new TableRow(19, -1, "Planar ally"),
				new TableRow(20, -1, "Wind walk"),
			});

			public static readonly Table potion_of_resistance_damage_type = new Table("Potion of Resistance Damage Type", new TableRow[]{
				new TableRow(1, -1, "Acid"),
				new TableRow(2, -1, "Cold"),
				new TableRow(3, -1, "Fire"),
				new TableRow(4, -1, "Force"),
				new TableRow(5, -1, "Lightning"),
				new TableRow(6, -1, "Necrotic"),
				new TableRow(7, -1, "Poison"),
				new TableRow(8, -1, "Psychic"),
				new TableRow(9, -1, "Radiant"),
				new TableRow(10, -1, "Thunder"),
			});

			public static readonly Table quaals_feather_token = new Table("Quaals Feather Token", new TableRow[]{
				new TableRow(1, 20, "Anchor"),
				new TableRow(21, 35, "Bird"),
				new TableRow(36, 50, "Fan"),
				new TableRow(51, 65, "Swan boat"),
				new TableRow(66, 90, "Tree"),
				new TableRow(91, 100, "Whip"),
			});

			public static readonly Table ring_of_resistance = new Table("Ring of Resistance", new TableRow[]{
				new TableRow(1, -1, "Acid - Pearl"),
				new TableRow(2, -1, "Cold - Tourmaline"),
				new TableRow(3, -1, "Fire - Garnet"),
				new TableRow(4, -1, "Force - Sapphire"),
				new TableRow(5, -1, "Lightning - Citrine"),
				new TableRow(6, -1, "Necrotic - Jet"),
				new TableRow(7, -1, "Poison - Amethyst"),
				new TableRow(8, -1, "Psychic - Jade"),
				new TableRow(9, -1, "Radiant - Topaz"),
				new TableRow(10, -1, "Thunder - Spinel"),
			});

			public static readonly Table robe_of_useful_items = new Table("Robe of Useful Items", new TableRow[]{
				new TableRow(1, 8, "Bag of 100 gp"),
				new TableRow(9, 15, "Silver coffer (1 foot long, 6 inches wide and deep) worth 500 gp"),
				new TableRow(16, 22, "Iron door (up to 10 feet wide and 10 feet high, barred on one side of your choice), which you can place in an opening you can reach; it conforms to fit the opening, attaching and hinging itself"),
				new TableRow(23, 30, "10 gems worth 100 gp each"),
				new TableRow(31, 44, "Wooden ladder (24 feet long)"),
				new TableRow(45, 51, "A riding horse with saddle bags (see the Monster Manual for statistics)"),
				new TableRow(52, 59, "Pit (a cube 10 feet on a side), which you can place on the ground within 10 feet of you"),
				new TableRow(60, 68, "4 potions of healing"),
				new TableRow(69, 75, "Rowboat (12 feet long)"),
				new TableRow(76, 83, "Spell scroll containing one spell of 1st to 3rd level"),
				new TableRow(84, 90, "2 mastiffs (see the Monster Manual for statistics)"),
				new TableRow(91, 96, "Window (2 feet by 4 feet, up to 2 feet deep), which you can place on a vertical surface you can reach"),
				new TableRow(97, 100, "Portable ram"),
			});

			public static readonly Table scroll_of_protection_creature_type = new Table("Scroll of Protection Creature Type", new TableRow[]{
				new TableRow(1, 10, "Aberrations"),
				new TableRow(11, 20, "Beasts"),
				new TableRow(21, 30, "Celestials"),
				new TableRow(31, 40, "Elementals"),
				new TableRow(41, 50, "Fey"),
				new TableRow(51, 75, "Fiends"),
				new TableRow(76, 80, "Plants"),
				new TableRow(81, 100, "Undead"),
			});

			public static readonly Table sphere_of_annihilation_planar_portal_contact_result = new Table("Sphere of Annihilation Planar Portal Contact Result", new TableRow[]{
				new TableRow(1, 50, "The sphere is destoyed."),
				new TableRow(51, 85, "The sphere moves through the portal or into the extradimensional space."),
				new TableRow(86, 100, "A spatial rift sends each creature and object within 180 feet of the sphere, including the sphere, to a random plane of existence."),
			});

			public static readonly Table wand_of_wonder_effect = new Table("Wand of Wonder Effect", new TableRow[]{
				new TableRow(1, 5, "You cast slow."),
				new TableRow(6, 10, "You cast faerie fire."),
				new TableRow(11, 15, "You are stunned until the start of your next turn, believing something awesome just happened."),
				new TableRow(16, 20, "You cast gust of wind."),
				new TableRow(21, 25, "You cast detect thoughts on the target you choose. If you didn't target a creature, you instead take 1d6 psychic damage."),
				new TableRow(26, 30, "You cast stinking cloud."),
				new TableRow(31, 33, "Heavy rain falls in a 60-foot radius centered on the target. The area becomes lightly obscured. The rain falls until the start of your next turn."),
				new TableRow(34, 36, "An animal appears in the unoccupied space nearest the target. The animal isn't under your control and acts as it normally would. Roll a d100 to determine which animal appears. On a 01-25, a rhinoceros appears; on a 26-50, an elephant appears; and on a 51-100, a rat appears. See the Monster Manual for the animal's statistics."),
				new TableRow(37, 46, "You cast lightning bolt."),
				new TableRow(47, 49, "A cloud of 600 oversized butterflies fills a 30-foot radius centered on the target. The area becomes heavily obscured. The butterfiles remain for 10 minutes."),
				new TableRow(50, 53, "You enlarge the target as if you had cast enlarge/reduce. If the target can't be affected by that spell, or if you didn't target a creature, you become the target."),
				new TableRow(54, 58, "You cast darkness"),
				new TableRow(59, 62, "Grass grows on the ground in a 60-foot radius centered on the target. If grass is already there, it grows to ten times its normal size and remains overgorwn for 1 minute."),
				new TableRow(63, 65, "An object of the DM's choice disappears into the Ethereal Plane. The object must be neither worn nor carried, within 120 feet of the target, and no larger than 10 feet in any dimension."),
				new TableRow(66, 69, "You shrink yourself as if you had cast enlarge/reduce on yourself."),
				new TableRow(70, 79, "You cast fireball."),
				new TableRow(80, 84, "You cast invisibility on yourself."),
				new TableRow(85, 87, "Leaves grow from the target. If you chose a point in space as the target, leaves sprout from the creature nearest to that point. Unless they are picked off, the leaves turn brown and fall off after 24 hours."),
				new TableRow(88, 90, "A stream of 1d4 x 10 gems, each worth 1 gp, shoots rom the wand's tip in a line 30 feet long and 5 feet wide. Each gem deals 1 bludgeoning damage, and the total damage of the gems is divided equally among all creatures in the line."),
				new TableRow(91, 95, "A burst of colorful shimmering light extends from you in a 30-foot radius. You and each creature in the area that can see must succeed on a DC 15 Constitution saving throw or become blinded for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on a success."),
				new TableRow(96, 97, "The target's skin turns bright blue for 1d10 days. If you chose a point in space, the creature nearest to that point is affected."),
				new TableRow(98, 100, "If you targeted a creature, it must make a DC 15 Constitution saving throw. If you didn't target a creature, you become the target and must make the saving throw. If the saving throw fails by 5 or more, the target is instantly petrified. On any other failed save, the target is restrained and begins to turn to stone. While restrained in this way, the target must repeat the saving throw at the end of its next turn, becoming petrified on a failure or ending the effect on a success. The petrification lasts until the target is freed by the greater restoration spell or similar magic."),
			});

			public static readonly Table creating_sentient_magic_items_communication = new Table("Creating Sentient Magic Items - Communication", new TableRow[]{
				new TableRow(1, 6, "The item communicates by transmitting emotion to the creature carrying or wielding it"),
				new TableRow(7, 9, "The item can speak, read, and understand one or more languages"),
				new TableRow(10, -1, "The item can speak, read, and understand one or more languages. In addition, the item can communicate telepathically with any character that carries or wields it"),
			});

			public static readonly Table creating_sentient_magic_items_senses = new Table("Creating Sentient Magic Items - Senses", new TableRow[]{
				new TableRow(1, -1, "Hearing and normal vision out to 30 feet"),
				new TableRow(2, -1, "Hearing and normal vision out to 60 feet"),
				new TableRow(3, -1, "Hearing and normal vision out to 120 feet"),
				new TableRow(4, -1, "Hearing and darkvision out to 120 feet"),
			});

			public static readonly Table creating_sentient_magic_items_alignment = new Table("Creating Sentient Magic Items - Alignment", new TableRow[]{
				new TableRow(1, 15, "Lawful good"),
				new TableRow(16, 35, "Neutral good"),
				new TableRow(36, 50, "Chaotic good"),
				new TableRow(51, 63, "Lawful neutral"),
				new TableRow(64, 73, "Neutral"),
				new TableRow(74, 85, "Chaotic neutral"),
				new TableRow(86, 89, "Lawful evil"),
				new TableRow(90, 95, "Neutral evil"),
				new TableRow(96, 99, "Chaotic evil"),
			});

			public static readonly Table creating_sentient_magic_items_special_purpose = new Table("Creating Sentient Magic Items - Special Purpose", new TableRow[]{
				new TableRow(1, -1, "Aligned: The item seeks to defeat or destroy those of a diametrically opposed alignment. (Such an item is never neutral.)"),
				new TableRow(2, -1, "Bane: The item seeks to defeat or destroy creatures of a particular kind, such as fiends, shapechangers, trolls, or wizards"),
				new TableRow(3, -1, "Protector: The item seeks to defend a particular race or kind of creature, such as elves or druids"),
				new TableRow(4, -1, "Crusader: The item seeks to defeat, weaken, or destroy the servants of a particular deity"),
				new TableRow(5, -1, "Templar: The item seeks to defend the servants and interests of a particular deity."),
				new TableRow(6, -1, "Destroyer: The item craves destruction and goads its user to fight arbitrarily"),
				new TableRow(7, -1, "Glory Seeker: The item seeks renown as the greatest magic item in the world, by establishing its user as a famous or notorious figure"),
				new TableRow(8, -1, "Lore seeker: The item craves knowledge or is determined to solve a mystery, learn a secret, or unravel a cryptic prophecy"),
				new TableRow(9, -1, "Destiny seeker: The item is convinced that it and its wielder have key roles to play in future events"),
				new TableRow(10, -1, "Creator Seeker: The item seeks its creator and wants to understand why it was created"),
			});

			public static readonly Table moonblade_properties = new Table("Moonblade Properties", new TableRow[]{
				new TableRow(1, 40, "Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus"),
				new TableRow(41, 80, "The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)"),
				new TableRow(81, 82, "The moonblade gains the finesse property"),
				new TableRow(83, 84, "The moonblade gains the thrown property (range 20/60 feet)"),
				new TableRow(85, 86, "The moonblade functions as a defender"),
				new TableRow(87, 90, "The moonblade scroes a critical hit on a roll of 19 or 20"),
				new TableRow(91, 92, "When you hit with an attack using the moonblade, the attack deals an extra 1d6 slashing damage"),
				new TableRow(93, 94, "When you hit a creature of a specific type (such as dragon, fiend, or undead) with the moonblade, the target takes an extra 1d6 damage of one of these types: acid, cold, fire, lightning, or thunder"),
				new TableRow(95, 96, "You can use a bonus action to cause the moonblade to flash brightly. Each creature that can see you and is within 30 feet of you must succeed on a DC 15 Constitution saving throw or become blinded for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. This property can't be used again until you take a short rest while attuned to the weapon"),
				new TableRow(97, 98, "The moonblade functions as a ring of spell storing"),
				new TableRow(99, -1, "You can use an action to call forth an elfshadow, provided that you don't already have one serving you. The elfshadow appears in an unoccupied space within 120 feet of you. It uses the statistics for a shadow from the Monster Manual, except it is neutral, immune to effects that turn undead, and doesn't create new shadows. You control this creature, deciding how it acts and moves. It remains until it drops to 0 hit points or you dismiss it as an action"),
				new TableRow(100, -1, "The moonblade functions as a vorpal sword"),
			});

			public static readonly Table minor_beneficial_properties = new Table("Minor Beneficial Properties", new TableRow[]{
				new TableRow(1, 20, "While attuned to the artifact, you gain proficiency in one skill of the DM's choice"),
				new TableRow(21, 30, "While attuned to the artifact, you are immune to disease"),
				new TableRow(31, 40, "While attuned to the artifact, you can't be charmed or frightened"),
				new TableRow(41, 50, "While attuned to the artifact, you have resistance against one damage type of the DM's choice"),
				new TableRow(51, 60, "While attuned to the artifact, you can use an action to cast one cantrip (chosen by the DM) from it"),
				new TableRow(61, 70, "While attuned to the artifact, you can use an action to cast one 1st-level spell (chosen by the DM) from it. After you cast the spell, roll a d6. On a roll of 1-5, you can't cast it again until the next dawn"),
				new TableRow(71, 80, "As 61-70 above, except the spell is 2nd level"),
				new TableRow(81, 90, "As 61-70 above, except the spell is 3rd level"),
				new TableRow(91, 100, "While attuned to the artifact, you gain a +1 bonus to Armor Class"),
			});

			public static readonly Table major_beneficial_properties = new Table("Major Beneficial Properties", new TableRow[]{
				new TableRow(1, 20, "While attuned to the artifact, one of your ability scores (DM's choice) increases by 2, to a maximum of 24"),
				new TableRow(21, 30, "While attuned to the artifact, you regain 1d6 hit points at the start of your turn if you have at least 1 hit point"),
				new TableRow(31, 40, "When you hit with a weapon attack while attuned to the artifact, the target takes an extra 1d6 damage of the weapon's type"),
				new TableRow(41, 50, "While attuned to the artifact, your walking speed increases by 10 feet"),
				new TableRow(51, 60, "While attuned to the artifact, you can use an action to cast one 4th-level spell (chosen by the DM) from it. After you cast the spell, roll a d6. On a roll of 1-5, you can't cast it again until the next dawn"),
				new TableRow(61, 70, "As 51-60 above, except the spell is 5th level"),
				new TableRow(71, 80, "As 51-60 above, except the spell is 6th level"),
				new TableRow(81, 90, "As 51-60 above, except the spell is 7th level"),
				new TableRow(91, 100, "While attuned to the artifact, you can't be blinded, deafened, petrified, or stunned"),
			});

			public static readonly Table minor_detrimental_properties = new Table("Minor Detrimental Properties", new TableRow[]{
				new TableRow(1, 5, "While attuned to the artifact, you have disadvantage on saving throws against spells"),
				new TableRow(6, 10, "The first time you touch a gem or piece of jewelry while attuned to this artifact, the value of the gem or jewelry is reduced by half"),
				new TableRow(11, 15, "While attuned to the artifact, you are blinded when you are more than 10 feet away from it"),
				new TableRow(16, 20, "While attuned to the artifact, you have disadvantage on saving throws against poison"),
				new TableRow(21, 30, "While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away"),
				new TableRow(31, 35, "While attuned to the artifact, all holy water within 10 feet of you is destroyed"),
				new TableRow(36, 40, "While attuned to the artifact, you are physically ill and have disadvantage on any ability check or saving throw that uses Strength or Constitution"),
				new TableRow(41, 45, "While attuned to the artifact, your weight increases by 1d4 x 10 pounds"),
				new TableRow(46, 50, "While attuned to the artifact, your appearance changes as the DM decides"),
				new TableRow(51, 55, "While attuned to the artifact, you are deafened when you are more than 10 feet away from it"),
				new TableRow(56, 60, "While attuned to the artifact, your weight drops by 1d4 x 5 puounds"),
				new TableRow(61, 65, "While attuned to the artifact, you can't smell"),
				new TableRow(66, 70, "While attuned to the artifact, nonmagical flames are extinguished within 30 feet of you"),
				new TableRow(71, 80, "While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you"),
				new TableRow(81, 85, "While attuned to the artifact, you deal 1d6 necrotic damage to any plant you touch that isn't a creature"),
				new TableRow(86, 90, "While attuned to the artifact, animals within 30 feet of you are hostile toward you"),
				new TableRow(91, 95, "While attuned to the artifact, you must eat and drink sixt times the normal amount each day"),
				new TableRow(96, 100, "While attuned to the artifact, your flaw is amplified in a way determined by the DM"),
			});

			public static readonly Table major_detrimental_properties = new Table("Major Detrimental Properties", new TableRow[]{
				new TableRow(1, 5, "While you are attuned to the artifact, your body rots over the course of four days, after which the rotting stops. You lose your hair by the end of day 1, finger tips and toe tips by the end of day 2, lips and nose by the end of day 3, and ears by the end of day 4. A regenerate spell restores lost body parts"),
				new TableRow(6, 10, "While you are attuned to the artifact, you determine your alignment daily at dawn by rolling a d6 twice. On the first roll, a 1-2 indicates lawful, 3-4 neutral, and 5-6 chaotic. On the second roll, a 1-2 indicates good, 3-4 neutral, and 5-6 evil"),
				new TableRow(11, 15, "When you first attune to the artifact, it gives you a quest determined by the DM. You must complete this quest as if affected by the geas spell. Once you complete the quest, you are no longer affected by this property"),
				new TableRow(16, 20, "The artifact houses a bodiless life force that is hostile toward you. Each time you use an action to use one of the artifact's properties, there is a 50 percent chance that the life force tries to leave the artifact and enter your body. If you fail a DC 20 Charisma saving throw, it succeeds, and you become an NPC under the DM's control until the intruding life force is banished using magic such as the dispel evil and good spell"),
				new TableRow(21, 25, "Creatures with a challenge rating of 0, as well as plants that aren't creatures, drop to 0 hit points when within 10 feet of the artifact"),
				new TableRow(26, 30, "The artifact imprisons a death slaad (see the Monster Manual). Each time you use one of the artifact's properties as an action, the slaad has a 10 percent chance of escaping, whereupon it appears within 15 feet of you and attacks you"),
				new TableRow(31, 35, "While you are attuned to the artifact, creatures of a particular type other than humanoid (as chosen by the DM) are always hostile toward you"),
				new TableRow(36, 40, "The artifact dilutes magic potions within 10 feet of it, rendering them nonmagical"),
				new TableRow(41, 45, "The artifact erases magic scrolls within 10 feet of it, rendering them nonmagical"),
				new TableRow(46, 50, "Before useing one of the artifact's properties as an action, you must use a bonus action to draw blood, either from yourself or from a willing or incapacitated creature within your reach, using a piercing or slashing melee weapon. THe subject takes 1d4 damage of the appropriate type."),
				new TableRow(51, 60, "When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")"),
				new TableRow(61, 65, "You take 4d10 psychic damage when you become attuned to the artifact"),
				new TableRow(66, 70, "You take 8d10 psychic damage when you become attuned to the artifact"),
				new TableRow(71, 75, "Before you can become attuned to the artifact, you must kill a creature of your alignment"),
				new TableRow(76, 80, "When you become attuned to the artifact, one of your ability scores is reduced by 2 at random. A greater restoration spell restores the ability to normal"),
				new TableRow(81, 85, "Each time you become attuned to the artifact, you age 3d10 years. You must succeed on a DC 10 Consitution saving throw or die from the shock. If you die, you are instantly transformed into a wight (see the Monster Manual) under the DM's control that is sworn to protect the artifact"),
				new TableRow(86, 90, "While attuned to the artifact, you lose the ability to speak."),
				new TableRow(91, 95, "While attuned to the artifact, you have vulnerability to all damage"),
				new TableRow(96, 100, "When you become attuned to the artifact, there is a 10 percent chance that you attract the attention of a god that sends an avatar to wrest the artifact from you. The avatar has the same alignment as its creator and the statistics of an empyrean (see the Monster Manual). Once it obtains the artifact, the avatar vanishes"),
			});

			public static string getCarpetOfFlying()
			{
				Table[] cof =
				{
					carpet_of_flying_size,
					carpet_of_flying_capacity,
					carpet_of_flying_flying_speed
				};

				int num = roll(1, 100);

				return cof[0].rollOnTable(num) + ", " + cof[1].rollOnTable(num) + ", " + cof[2].rollOnTable(num);
			}
			
			public static string getHornOfValhalla()
			{
				Table[] hov =
				{
					horn_of_valhalla_horn_type,
					horn_of_valhalla_berserkers_summoned,
					horn_of_valhalla_requirement
				};

				int num = roll(1, 100);

				return hov[0].rollOnTable(num) + ", " + hov[1].rollOnTable(num) + ", " + hov[2].rollOnTable(num);
			}

			public static string getManualOfGolems()
			{
				Table[] mog =
				{
					manual_of_golems_golem,
					manual_of_golems_time,
					manual_of_golems_cost
				};

				int num = roll(1, 20);

				return mog[0].rollOnTable(num) + ", " + mog[1].rollOnTable(num) + ", " + mog[2].rollOnTable(num);
			}

			public static string getNecklaceOfPrayerBeads()
			{
				Table[] nopb =
				{
					necklace_of_prayer_beads_bead_of,
					necklace_of_prayer_beads_spell
				};

				int num = roll(1, 20);

				return nopb[0].rollOnTable(num) + ", " + nopb[1].rollOnTable(num);
			}
		}

		// Chapter 8
		public static class RunningTheGame
		{
			public static readonly Table urban_chase_complications = new Table("Urban Chase Complications", new TableRow[]{
				new TableRow(1, -1, "A large obstacle such as a horse or car blocks your way. Make a DC 15 Dexterity (Acorbatics) check to get past the obstacle. On a failed check, the obstacle counts as 10 fet of difficult terrain."),
				new TableRow(2, -1, "A crowd blocks yoru way. Make a DC 10 Strength (Athletics) or Dexterity (Acrobatics) check (your choice) to make your way through the crowd unimpeded. On a failed check, the crowd counts as 10 feet of difficult terrain."),
				new TableRow(3, -1, "A larget stained-glass window or similar barrier blocks your path. Make a DC 10 Strength saving throw to smash through the barrier and keep going. On a failed save, you bounce off the barrier and fall prone."),
				new TableRow(4, -1, "A maze of barrels, crates, or similar obstacles stands in your way. Make a DC 10 Dexterity (Acrobatics) or Intelligence check (your choice) to navigate the maze. On a failed check, the maze counts as 10 feet of difficult terrain."),
				new TableRow(5, -1, "The ground beneath your feet is slippery with rain, spilled oil, or some other liquid. Make a DC 10 Dexterity saving throw. On a failed save, you fall prone."),
				new TableRow(6, -1, "You come upon a pack of dogs fighting over food. Make a DC 10 dexterity (Acrobatics) check to get through the pack unimpeded. On a failed check, you are bitten and take 1d4 piercing damage, and the dogs count as 5 feet of difficult terrain."),
				new TableRow(7, -1, "You run into a brawl in progress. Make a DC 15 Strength (Athletics), Dexterity (Acrobatics), or Charisma (Intimidation) check (your choice) to get past the brawlers unimpeded. On a failed check, you take 2d4 bludgeoning damage, and the brawlers count as 10 feet of difficult terrain."),
				new TableRow(8, -1, "A beggar blocks your way. Make a DC 10 Strength (Athletics), Dexterity (Acrobatics), or Charisma (Intimidation) check (your choice) to slip past the beggar. You succeed automatically if you toss the beggar a coin. On a failed check, the beggar counts as 5 feet of difficult terrain."),
				new TableRow(9, -1, "An overzealous guard (see the Monster Manual for game statistics) mistakes you for someone else. If you move 20 feet or more on your turn, the guard makes an opportunity attack against you with a spear (+3 to hit; 1d6 + 1 piercing damage on a hit)."),
				new TableRow(10, -1, "You are forced to make a sharp turn to avoid colliding with something impassable. Make a DC 10 Dexterity saving throw to navigate the turn. On a failed save, you collide with something hard and take 1d4 bludgeoning damage."),
				new TableRow(11, 20, "No complication."),
			});

			public static readonly Table wilderness_chase_complications = new Table("Wilderness Chase Complications", new TableRow[]{
				new TableRow(1, -1, "Your path takes you through a rough patch of brush. Make a DC 10 Strength (Athletics) or Dexterity (Acrobatics) check (your choice) to get past the brush. On a failed check, the brush counts as 5 feet of difficult terrain."),
				new TableRow(2, -1, "Uneven ground threatens to slow your progress. Make a DC 10 Dexterity (Acrobatics) check to navigate the area. On a failed check, the ground coutns as 10 feet of difficult terrain."),
				new TableRow(3, -1, "You run through a swarm of insects (see the Monster Manual for game statistics, with the DM choosing whiever kind of insects makes the most sens). The swarm makes an opportunity attack against you (+3 to hit; 4d4 piercing damage on a hit)."),
				new TableRow(4, -1, "A stream, ravine, or rock bed blocks your path. Make a DC 10 Strength (Athletics) or Dexterity (Acrobatics) check (your choice) to cross the impediment. On a failed check, the impediment counts as 10 feet of difficult terrain."),
				new TableRow(5, -1, "Make a DC 10 Constitution saving throw. On a failed save, you are blinded by blowing sand, dirt, ash, snow, or pollen until the end of your turn. While blinded in this way, your speed is halved."),
				new TableRow(6, -1, "A sudden drop catches you by surprise. Make a DC 10 Dexterity saving throw to navigate the impediment. On a failed save, you fall 1d4 x 5 feet, taking 1d6 bludgeoning damage per 10 feet fallen as normal, and land prone."),
				new TableRow(7, -1, "You blunder into a hunter's snare. Make a DC 15 Dexterity saving throw to avoid it. On a failed save, you are caught in a net and restrained. See chapter 5, \"Equipment,\" of the Player's Handbook for rules on escaping a net."),
				new TableRow(8, -1, "You are caught in a stampede of spooked animals. Make a DC 10 Dexterity saving throw. On a failed save, you are knocked about and take 1d4 bludgeoning damage and 1d4 piercing damage."),
				new TableRow(9, -1, "Your path takes you near a patch of razorvine. Make a DC 15 Dexterity saving thro or use 10 feet of movement (your choice) to avoid the razorvine. On a failed save, you take 1d10 slashing damage."),
				new TableRow(10, -1, "A creature indigenous to the area chases after you. The DM chooses a creature appropriate for the terrain."),
				new TableRow(11, 20, "No complication."),
			});

			public static readonly Table poisons_item = new Table("Poisons - Item", new TableRow[]{
				new TableRow(1, -1, "Assassin's blood"),
				new TableRow(2, -1, "Burnt othur fumes"),
				new TableRow(3, -1, "Carrion crawler mucus"),
				new TableRow(4, -1, "Drow poison"),
				new TableRow(5, -1, "Essence of ether"),
				new TableRow(6, -1, "Malice"),
				new TableRow(7, -1, "Midnight tears"),
				new TableRow(8, -1, "Oil of taggit"),
				new TableRow(9, -1, "Pale tincture"),
				new TableRow(10, -1, "Purple worm poison"),
				new TableRow(11, -1, "Serpent venom"),
				new TableRow(12, -1, "Torpor"),
				new TableRow(13, -1, "Truth serum"),
				new TableRow(14, -1, "Wyvern poison"),
			});

			public static readonly Table poisons_type = new Table("Poisons - Type", new TableRow[]{
				new TableRow(1, -1, "Ingested"),
				new TableRow(2, -1, "Inhaled"),
				new TableRow(3, -1, "Contact"),
				new TableRow(4, -1, "Injury"),
				new TableRow(5, 6, "Inhaled"),
				new TableRow(7, -1, "Ingested"),
				new TableRow(8, -1, "Contact"),
				new TableRow(9, -1, "Ingested"),
				new TableRow(10, 11, "Injury"),
				new TableRow(12, 13, "Ingested"),
				new TableRow(14, -1, "Injury"),
			});

			public static readonly Table poisons_price_per_dose = new Table("Poisons Price Per Dose", new TableRow[]{
				new TableRow(1, -1, "150 gp"),
				new TableRow(2, -1, "500 gp"),
				new TableRow(3, 4, "200 gp"),
				new TableRow(5, -1, "300 gp"),
				new TableRow(6, -1, "250 gp"),
				new TableRow(7, -1, "1,500 gp"),
				new TableRow(8, -1, "400 gp"),
				new TableRow(9, -1, "250 gp"),
				new TableRow(10, -1, "2,000 gp"),
				new TableRow(11, -1, "200 gp"),
				new TableRow(12, -1, "600 gp"),
				new TableRow(13, -1, "150 gp"),
				new TableRow(14, -1, "1,200 gp"),
			});

			public static readonly Table short_term_madness = new Table("Short-Term Madness", new TableRow[]{
				new TableRow(1, 20, "The character retreats into his or her mind and becomes paralyzed. The effect ends if the character takes any damage."),
				new TableRow(21, 30, "The character becomes incapacitated and spends the duration screaming, laughing or weeping."),
				new TableRow(31, 40, "The character becomes frightened and must use his or her action and movement each round to flee from the source of hte fear."),
				new TableRow(41, 50, "The character begins babling and is incapable of normal speech or spellcasting."),
				new TableRow(51, 60, "The character must use his or her action each round to attack the nearest creature."),
				new TableRow(61, 70, "The character experiences vivid hallucinations and has disadvantage on ability checks."),
				new TableRow(71, 75, "The character does whatever anyone tells him or her to do that isn't obviously self-destructive."),
				new TableRow(76, 80, "The character experiences an overpowering urge to eat something strange such as dirt, slime, or offal."),
				new TableRow(81, 90, "The character is stunned."),
				new TableRow(91, 100, "The character falls unconscious."),
			});

			public static readonly Table long_term_madness = new Table("Long-Term Madness", new TableRow[]{
				new TableRow(1, 10, "The character feels compelled to repeat a specific activity over and over, such as washing hands, touching things, praying, or counting coins."),
				new TableRow(11, 20, "The character experiences vivid hallucinations and has disadvantage on ability checks."),
				new TableRow(21, 30, "The character suffers extreme paranoia. The character has disadvantage on Wisdom and Charisma checks."),
				new TableRow(31, 40, "The character regards something (usually the source of madness) with intense revulsion, as if affected by the antipathy effect of the antipathy/sympathy spell."),
				new TableRow(41, 45, "The character experiences a powerful delusion. Choose a potion. The character imagines that he or she is under its effects."),
				new TableRow(46, 55, "The character becomes attached to a \"lucky charm,\" such as a person or an object, and has disadvantage on attack rolls, ability checks, and saving throws while more than 30 feet form it."),
				new TableRow(56, 65, "The character is blinded (25%) or deafened (75%)."),
				new TableRow(66, 75, "The character experiences uncontrollable tremors or tics, which impose disadvantage on attack rolls, ability checks, and saving throws that involve Strength or Dexterity."),
				new TableRow(76, 85, "The character suffers from partial amnesia. The character knows who he or she is and retains racial traits and class features, but doesn't recognize other people or remember anything that happened before the madness took effect."),
				new TableRow(86, 90, "Whenever the character takes damage, he or she must succeed on a DC 15 Wisdom saving throw or be affected as though he or she failed a saving throw against the confusion spell. The confusion effect lasts for 1 minute."),
				new TableRow(91, 95, "The character loses the ability to speak."),
				new TableRow(96, 100, "The character falls unconscious. No amount of jostling or damage can wake the character."),
			});

			public static readonly Table indefinite_madness = new Table("Indefinite Madness", new TableRow[]{
				new TableRow(1, 15, "Beng drunk keeps me sane."),
				new TableRow(16, 25, "I keep whatever I find."),
				new TableRow(26, 30, "I try to become more like someone else I know -- adopting his or her style of dress, mannerisms, and name."),
				new TableRow(31, 35, "I must bend the truth, exaggerate, or outright lie to be interesting to other people."),
				new TableRow(36, 45, "Achieving my goal is the only thing of interest to me, and I'll ignore everything else to pursue it."),
				new TableRow(46, 50, "I find it hard to care about anything that goes on around me."),
				new TableRow(51, 55, "I don't like the way people judge me all the time."),
				new TableRow(56, 70, "I am the smartest, wisest, strongest, fastest, and most beautiful person I know."),
				new TableRow(71, 80, "I am convinced that powerful enemies are hunting me, and their agents are everywhere I go. I am sure they're watching me all the time."),
				new TableRow(81, 85, "There's only one person I can truest. And only I can see this special friend."),
				new TableRow(86, 95, "I can't take anything seriously. The more serious the situation, the funnier I find it."),
				new TableRow(96, 100, "I've discovered that I really like killing people."),
			});

			public static string getPoison(int num = -1)
			{
				if(num == -1 || num > 14)
				{
					num = roll(1, 14);
				}

				Table[] cof =
				{
					poisons_item,
					poisons_type,
					poisons_price_per_dose
				};

				return cof[0].rollOnTable(num) + ", " + cof[1].rollOnTable(num) + ", " + cof[2].rollOnTable(num);
			}

			public static string getShortTermMadnessDuration()
			{
				return roll(1, 10).ToString() + " minutes";
			}
			
			public static string getLongTermMadnessDuration()
			{
				return (roll(1, 10) * 10).ToString() + " hours";
			}

		}

		// Chapter 9
		public static class DungeonMastersWorkshop
		{
			public static readonly Table lingering_injuries = new Table("Lingering Injuries", new TableRow[]{
				new TableRow(1, -1, "Lose an Eye. You have disadvantage on Wisdom (Perception) checks that rely on sight and on ranged attack rolls. Magic such as the regenerate spell can restore the lost eye. If you have no eyes left after sustaining this injury, you're blinded."),
				new TableRow(2, -1, "Lose an Arm or a Hand. You can no longer hold anything with two hands, and you can hold only a single object at a time. Magic such as the regenerate spell can restore the lost appendage."),
				new TableRow(3, -1, "Lose a Foot or Leg. Your speed on foot is halved, and you must use a cane or crutch to move unless you have a peg leg or other prosthesis. You fall prone after using the Dash action. You have disadvantage on Dexterity checks made to balance. Magic such as the regenerate spell can restore the lost appendage."),
				new TableRow(4, -1, "Limp. Your speed on foot is reduced by 5 feet. You must make a DC 10 Dexterity saving throw after using the Dash action. If you fail the save, you fall prone. Magical healing removes the limp."),
				new TableRow(5, 7, "Internal Injury. Whenever you attempt an action in combat, you must make a DC 15 Constitution saving throw. On a failed save, you lose your action and cant use reactions until the start of your next turn. The injury heals if you receive magical healing or if you spend ten days doing nothing but resting."),
				new TableRow(8, 10, "Broken Ribs. This has the same effect as Internal Injury above, except that the save DC is 10."),
				new TableRow(11, 13, "Horribel Scar. You are disfigured to the extent that the wound can't be easily concealed. You have disadvantage on Charisma (Persuasion) checks and advantage on Charisma (Intimidation) checks. Magical healing of 6th level or higher, such as heal and regenerate, removes the scar."),
				new TableRow(14, 16, "Festering Wound. Your hit point maximum is reduced by 1 every 24 hours the wound persists. If your hit point maximum drops to 0, you die. The wound heals if you receive magical healing. Alternatively, someone can tend to the wound and make a DC 15 Wisdom (Medicine) check once every 24 hours. After ten sucesses, the wound heals."),
				new TableRow(17, 20, "Minor Scar. The scar doesn't have any adverse effect. Magical healing of 6th level or higher, such as heal and regenerate, removes the scar."),
			});

			public static readonly Table system_shock = new Table("System Shock", new TableRow[]{
				new TableRow(1, -1, "The creature drops to 0 hit points."),
				new TableRow(2, 3, "The creature drops to 0 hit points but is stable."),
				new TableRow(4, 5, "The creature is stunned until the end of its next turn."),
				new TableRow(6, 7, "The creature can't take reactions and has disadvantage on attack rolls and ability checks until the end of its next turn."),
				new TableRow(8, 10, "The creature can't take reactions until the end of its next turn."),
			});
		}

		// Appendix A
		public static class RandomDungeons
		{
			public static readonly string[] starting_area =
			{
				"Square, 20 x 20 ft.; passage on each wall",
				"Square, 20 x 20 ft.; door on two walls, passage in third wall",
				"Square, 40 x 40 ft.: doors on three walls",
				"Rectangle, 80 x 20 ft., with row of pillars down the middle; two passages leading from each long wall, doors on each short wall",
				"Rectangle, 20 x 40 ft.; passage on each wall",
				"Circle, 40 ft. diameter; one passage at each cardinal direction",
				"Circle, 40 ft. diameter; one passage in each cardinal direction; well in middle of room (might lead down to lower level)",
				"Square, 20 x 20 ft.; door on two walls, passage on third wall, secret door on fourth wall",
				"Passage, 10 ft. wide; T intersection",
				"Passage, 10 ft. wide; four-way intersection"
			};

			public static readonly string[] passage =
			{

			};
		}

		#endregion DMG

		#region XGE

		// Chapter 1
		public static class CharacterOptions
		{
			public static readonly string[] parents =
			{
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You know who your parents are or were.",
				"You do not know who your parents were."
			};

			public static readonly string[] half_elf_parents =
			{
				"One parent was an elf and the other was a human.",
				"One parent was an elf and the other was a human.",
				"One parent was an elf and the other was a human.",
				"One parent was an elf and the other was a human.",
				"One parent was an elf and the other was a human.",
				"One parent was an elf and the other was a half-elf.",
				"One parent was a human and the other was a half-elf.",
				"Both parents were half-elves."
			};

			public static readonly string[] half_orc_parents =
			{
				"One parent was an orc and the other was a human.",
				"One parent was an orc and the other was a human.",
				"One parent was an orc and the other was a human.",
				"One parent was an orc and the other was a half-orc.",
				"One parent was an orc and the other was a half-orc.",
				"One parent was a human and the other was a half-orc.",
				"One parent was a human and the other was a half-orc.",
				"Both parents were half-orcs."
			};

			public static readonly string[] tiefling_parents =
			{
				"Both parents were humans, their infernal heritage dormant until you came along.",
				"Both parents were humans, their infernal heritage dormant until you came along.",
				"Both parents were humans, their infernal heritage dormant until you came along.",
				"Both parents were humans, their infernal heritage dormant until you came along.",
				"One parent was a tiefling and the other was a human.",
				"One parent was a tiefling and the other was a devil.",
				"One parent was a human and the other was a devil."
			};

			public static readonly string[] birthplace =
			{
				"Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home",
				"Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home",
				"Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home",
				"Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home",
				"Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home", "Home",
				"Home of a family friend", "Home of a family friend", "Home of a family friend", "Home of a family friend", "Home of a family friend",
				"Home of a healer or midwife", "Home of a healer or midwife", "Home of a healer or midwife", "Home of a healer or midwife",
				"Home of a healer or midwife", "Home of a healer or midwife", "Home of a healer or midwife", "Home of a healer or midwife",
				"Carriage, cart, or wagon", "Carriage, cart, or wagon",
				"Barn, shed, or other outbuilding", "Barn, shed, or other outbuilding", "Barn, shed, or other outbuilding",
				"Cave", "Cave",
				"Field", "Field",
				"Forest", "Forest",
				"Temple", "Temple", "Temple",
				"Battlefield",
				"Alley or street", "Alley or street",
				"Brothel, tavern, or inn", "Brothel, tavern, or inn",
				"Castle, keep, tower, or palace", "Castle, keep, tower, or palace",
				"Sewer or rubbish heap",
				"Among people of a different race", "Among people of a different race", "Among people of a different race",
				"On board a boat or a ship", "On board a boat or a ship", "On board a boat or a ship",
				"In a prison or in the headquarters of a secret organization",
				"In a prison or in the headquarters of a secret organization",
				"In a sage's laboratory", "In a sage's laboratory",
				"In the Feywild",
				"In the Shadowfell",
				"On the Astral Plane or the Ethereal Plane",
				"On an Inner Plane of your choice",
				"On an Outer Plane of your choice"
			};

			public static readonly string[] number_of_siblings =
			{
				"None",
				"None",
				"1d3",
				"1d3",
				"1d4 + 1",
				"1d4 + 1",
				"1d6 + 2",
				"1d6 + 2",
				"1d8 + 3",
				"1d8 + 3"
			};

			public static readonly string[] birth_order =
			{
				"Twin, triplet, or quadruplet",
				"Older", "Older", "Older", "Older", "Older",
				"Younger", "Younger", "Younger", "Younger", "Younger"
			};

			public static readonly string[] family =
			{
				"None",
				"Institution, such as an asylum",
				"Temple",
				"Orphanage", "Orphanage",
				"Guardian", "Guardian",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Paternal or maternal grandparent(s)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Adoptive family (same or different race)",
				"Single father or stepfather", "Single father or stepfather", "Single father or stepfather", "Single father or stepfather",
				"Single father or stepfather", "Single father or stepfather", "Single father or stepfather", "Single father or stepfather",
				"Single father or stepfather", "Single father or stepfather", "Single father or stepfather", "Single father or stepfather",
				"Single father or stepfather", "Single father or stepfather", "Single father or stepfather", "Single father or stepfather",
				"Single father or stepfather", "Single father or stepfather", "Single father or stepfather", "Single father or stepfather",
				"Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother",
				"Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother",
				"Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother",
				"Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother",
				"Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother", "Single mother or stepmother",
				"Mother and father", "Mother and father", "Mother and father", "Mother and father", "Mother and father",
				"Mother and father", "Mother and father", "Mother and father", "Mother and father", "Mother and father",
				"Mother and father", "Mother and father", "Mother and father", "Mother and father", "Mother and father",
				"Mother and father", "Mother and father", "Mother and father", "Mother and father", "Mother and father"
			};

			public static readonly string[] absent_parent =
			{
				"Your parent died (roll on the Cause of Death supplemental table).",
				"Your parent was imprisone, enslaved, or otherwise taken away.",
				"Your parent abandoned you.",
				"Your parent disappeared to an unknown fate."
			};

			public static readonly string[] family_lifestyle =
			{
				"Wretched",
				"Squalid", "Squalid",
				"Poor", "Poor",
				"Modest", "Modest",
				"Modest", "Modest",
				"Comfortable", "Comfortable", "Comfortable",
				"Wealthy", "Wealthy",
				"Aristocratic"
			};

			public static readonly string[] childhood_home =
			{
				"On the streets",
				"Rundown shack", "Rundown shack",
				"No permanent residence; you moved around a lot",
				"Encampment or village in the wilderness",
				"Apartment in a rundown neighborhood",
				"Small house", "Small house",
				"Large house", "Large house",
				"Mansion", "Mansion",
				"Palace or castle"
			};

			public static readonly string[] childhood_memories =
			{
				"I am still haunted by my childhood, when I was treated badly by my peers.",
				"I spent most of my childhood alone, with no close friends.",
				"I spent most of my childhood alone, with no close friends.",
				"Others saw me as being different or strange, and so I had few companions.",
				"Others saw me as being different or strange, and so I had few companions.",
				"Others saw me as being different or strange, and so I had few companions.",
				"I had a few close friends and lived an ordinary childhood.",
				"I had a few close friends and lived an ordinary childhood.",
				"I had a few close friends and lived an ordinary childhood.",
				"I had a few close friends and lived an ordinary childhood.",
				"I had several friends, and my childhood was generally a happy one.",
				"I had several friends, and my childhood was generally a happy one.",
				"I had several friends, and my childhood was generally a happy one.",
				"I always found it easy to make friends, and I loved being around people.",
				"I always found it easy to make friends, and I loved being around people.",
				"Everyone knew who I was, and I had friends everywhere I went."
			};

			public static class PersonalDecisions
			{
				public static class Background
				{
					public static readonly string[] acolyte =
					{
						"I ran away from home at an early age and found refuge in a temple.",
						"My family gave me to a temple, since they were unable or unwilling to care for me.",
						"I grew up in a household with strong religious convictions. Entering the service of one or more gods seemed natural.",
						"An impassioned sermon struck a chord deep in my soul and moved me to serve the faith.",
						"I followed a childhood friend, a respected acquaintance, or someone I loved into religious service.",
						"After encountering a true servant of the gods, I was so inspired that I immediately entered the service of a religious group."
					};

					public static readonly string[] charlatan =
					{
						"I was left to my own devices, and my knack for manipulating others helped me survive.",
						"I learned early on that people are gullible and easy to exploit.",
						"I often got in trouble, but I managed to talk my way out of it every time.",
						"I took up with a confidence artist, from whom I learned my craft.",
						"After a charlatan fleeced my family, I decided to learn the trade so I would never be fooled by such deception again.",
						"I was poor or I feared becoming poor, so I learned the tricks I needed to keep myself out of poverty."
					};

					public static readonly string[] criminal =
					{
						"I resented authority in my younger days and saw a life of crime as the best way to fight against tyranny and oppression.",
						"Necessity forced me to take up the life, since it was the only way I could survive.",
						"I fell in with a gang of reprobates and ne'er-do-wells, and I learned my specialty from them.",
						"A parent or relative taught me my criminal specialty to prepare me for the family business.",
						"I left home and found a place in a thieves' guild or some other criminal organization",
						"I was always bored, so I turned to crime to pass the time and discovered I was quite good at it."
					};

					public static readonly string[] entertainer =
					{
						"Members of my family made ends meet by performing, so it was fitting for me to follow their example.",
						"I always had a keen insight into other people, enough so that I could make them laugh or cry with my stories or songs.",
						"I ran away from home to follow a minstrel troupe.",
						"I saw a bard perform once, and I knew from that moment on what I was born to do.",
						"I earned coin by performing on street corners and eventually made a name for myself.",
						"A traveling entertainer took me in and taught me the trade."
					};

					public static readonly string[] folk_hero =
					{
						"I learned what was right and wrong from my family.",
						"I was always enamored by tales of heroes and wished I could be something more than ordinary.",
						"I hated my mundane life, so when it was time for someone to step up and do the right thing, I took my chance.",
						"A parent or one of my relatives was an adventurer, and I was inspired by that person's courage.",
						"A mad old hermit spoke a prophecy when I was born, saying that I would accomplish great things.",
						"I have always stood up for those who are weaker than I am."
					};

					public static readonly string[] guild_artisan =
					{
						"I was apprenticed to a master who taught me the guild's business",
						"I helped a guild artisan keep a secret or complete a task, and in return I was taken on as an apprentice.",
						"One of my family members who belonged to the guild made a place for me.",
						"I was always good with my hands, so I took the opportunity to learn a trade.",
						"I wnated to get away from my home situation and start a new life.",
						"I learned the essentials of my craft from a mentor but had to join the guild to finish my training."
					};

					public static readonly string[] hermit =
					{
						"My enemies ruined my reputation, and I fled to the wilds to avoid furhter disparagement.",
						"I am comfortable with being isolated, as I seek inner peace.",
						"I never liked the people I called my friends, so it was easy for me to strike out on my own.",
						"I felt compelled to forsake my past, but did so with great reluctance, and sometimes I regret making that decision.",
						"I lost everything -- my home, my family, my friends. Going it alone was all I could do.",
						"Society's decadence disgusted me, so I decided to leave it behind."
					};

					public static readonly string[] noble =
					{
						"I come from an old and storied family, and it fell to me to preserve the family name.",
						"My family has been disgraced, and I intend to clear our name.",
						"My family recently came by its title, and that elevation thrust us into a new and strange world.",
						"My family has a title, but none of my ancestors have distinguished themselves since we gained it.",
						"My faimly is filled with remarkable people. I hope to live up to their example.",
						"I hope to increase my family's power and influence."
					};

					public static readonly string[] outlander =
					{
						"I spent a lot of time in the wilderness as a youngster, and I came to love that way of life.",
						"From a young age, I couldn't abide the stink of the cities and preferred to spend my time in nature.",
						"I came to understand the darkness that lurks in the wilds, and I vowed to combat it.",
						"My people lived on the dges of civilization, and I learned the methods of survival from my family.",
						"After a tragedy I retreated to the wilderness, leaving my old life behind.",
						"My family moved away from civilization, and I learned to adapt to my new environment."
					};

					public static readonly string[] sage =
					{
						"I was naturally curious, so I packed up and wnet to a university to learn more about the world.",
						"My mentor's teachings opened my mind to new possibilities in that field of study.",
						"I was always an avid reader, and I learned much about my favorite topic on my own.",
						"I discovered an old library and pored over the texts I found there. That experience awakened a hunger for more knowledge.",
						"I impressed a wizard who told me I was squandering my talents and should seek out an education to take advantage of my gifts.",
						"One of m parents or a relative gave me a basic education that whetted my appetite, and I left home to build on what I had learned."
					};

					public static readonly string[] sailor =
					{
						"I was press-ganged by pirates and forced to serve on their ship until I finally escaped.",
						"I wanted to see the world, so I signed on as a deckhand for a merchant ship.",
						"One of my relatives was a sailor who took me to sea.",
						"I needed to escape my community quickly, so I stowed away on a ship. When the crew found me, I was forced to work for my passage.",
						"Reavers attacked my community, so I found refuge on a ship until I could seek vengeance.",
						"I had few prospects where I was living, so I left to find my fortune elsewhere."
					};

					public static readonly string[] soldier =
					{
						"I joined the militia to help protect my community from monsters.",
						"A relative of mine was a soldier, and I wanted to carry on the family tradition.",
						"The local lord forced me to enlist in the army.",
						"War ravaged my homeland while I was growing up. Fighting was the only life I ever knew.",
						"I wanted fame and fortune, so I joined a mercenary company, selling my sword to the highest bidder.",
						"Invaders attacked my homeland. It was my duty to take up arms in defense of my people."
					};

					public static readonly string[] urchin =
					{
						"Wanderlust caused me to leave my family to see the world. I look after myself.",
						"I ran away from a bad situation at home and made my own way in the world.",
						"Monsters wiped out my village, and I was the sole survivor. I had to find a way to survive.",
						"A notorious thief looked after me and other orphans, and we spied and stole to earn our keep.",
						"One day I woke up on the streets, alone and hungry, with no memory of my early childhood.",
						"My parents died, leaving no one to look after me. I raised myself."
					};
				}

				public static class ClassTraining
				{
					public static string[] barbarian =
					{
						"My devotion to my people lifted me in battle, making me powerful and dangerous.",
						"The spirits of my ancestors called on me to carry out a great task.",
						"I lost control in battle one day, and it was as if something else was manipulating my body, forcing it to kill every foe I could reach.",
						"I wnet on a spiritual journey to find myself and instead found a spirit animal to guide, protect, and inspire me.",
						"I was struck by lightning and lived. Afterward, I found a new strength within me that let me push beyond my limitations.",
						"My anger needed to be channeled into battle, or I risked becoming an indiscriminate killer."
					};

					public static string[] bard =
					{
						"I awakened my latent bardic abilities through trial and error.",
						"I was a gifted performer and attracted the attention of a master bard who schooled me in the old techniques.",
						"I joined a loose society of scholars and orators to learn new techniques of performance and magic.",
						"I felt a calling to recount the deeds of champions and heroes, to bring them alive in song and story.",
						"I joined one of the great colleges to learn old lore, the secrets of magic, and the art of performance.",
						"I picked up a musical instrument one day and instantly discovered that I could play it."
					};

					public static string[] cleric =
					{
						"A supernatural being in service to the gods called me to become a divine agent in the world.",
						"I saw the injustice and horror in the world and felt moved to take a stand against them.",
						"My god gave me an unmistakable sign. I dropped everythign to serve the divine.",
						"Although I was always devout, it wasn't until I completed a pilgrimage that I knew my true calling.",
						"I used to serve in my religion's bureaucracy but found I needed to work in the world, to bring the message of my faith to the darkest corners of the land.",
						"I realize that my god works through me, and I do as commanded, even though I don't know why I was chosen to serve."
					};

					public static string[] druid =
					{
						"I saw too much devastation in the wild places, too much of nature's splendor ruined by the despoilers. I joined a circle of druids to fight back against the enemies of nature.",
						"I found a place among a group of druids after I fled a catastrophe.",
						"I have always had an affinity for animals, so I explored my talent to see how I could best use it.",
						"I befriended a druid and was moved by druidic teachings. I decided to follow my friend's guidance and give something back to the world.",
						"While I was growing up, I saw spirits all around me -- entities no one else could perceive. I sought out the druids to help me understand the visions and communicate with these beings.",
						"I have always felt disgust for creatures of unnatural origin. For this reason, I immersed myself in the study of the druidic mysteries and became a champion of the natural order."
					};

					public static string[] fighter =
					{
						"I wanted to hone my combat skills, and so I joined a war college.",
						"I squired for a knight who taught me how to fight, care for a steed, and conduct myself with honor. I decided to take up that path for myself.",
						"Horrible monsters descended on my community, killing someone I loved. I took up arms to destroy those creatures and others of a similar nature.",
						"I joined the army and learned how to fight as part of a group.",
						"I grew up fighting, and I refined my talents by defending myself against people who crossed me.",
						"I could always pick up just about any weapon and know how to use it effectively."
					};

					public static string[] monk =
					{
						"I was chosen to study at a secluded monastery. THere, I was taught the fundamental techniques required to eventually master a tradition.",
						"I sought instruction to gain a deeper understanding of existence and my place in the world.",
						"I stumbled into a portal to the Shadowfell and took refuge in a strange monastery, where I learned how to defend myself against the forces of darkness.",
						"I was overwhelmed with grief after losing someone close to me, and I sought the advice of philosophers to help me cope with my loss.",
						"I could feel that a special sort of power lay within me, so I sought out those who could help me call it forth and master it.",
						"I was wild and undisciplined as a youngster, but then I realized the error of my ways. I applied to a monastery and became a monk as a way to live a life of discipline."
					};

					public static string[] paladin =
					{
						"A fantastical being appeared before me and called on me to undertake a holy quest.",
						"One of my ancestors left a holy quest unfulfilled, so I intend to finish that work.",
						"The world is a dark and terrible place. I decided to serve as a beacon of light shining out against the gathering shadows.",
						"I served as a paladin's squire, learning all I needed to swear my own sacred oath.",
						"Evil must be opposed on all fronts. I feel compelled to seek out wickedness and purge it from the world.",
						"Becoming a paladin was a natural consequence of my unwavering faith. In taking my vows, I became the holy sword of my religion."
					};

					public static string[] ranger =
					{
						"I found purpose while I honed my hunting skills by bringing down dangerous animals at the edge of civilization.",
						"I always had a way with animals, able to calm them with a soothing word and a touch.",
						"I suffer from terrible wanderlust, so being a ranger gave me a reason not to remain in one place for too long.",
						"I have seen what happens when the monsters come out from the dark. I took it upon myself ot become the first line of defense against the evils that lie beyond civilization's borders.",
						"I met a grizzled ranger who taught me woodcraft and the secrets of the wild lands.",
						"I served in an army, learning the precepts of my profession while blazing trails and scouting enemy encampments."
					};

					public static string[] rogue =
					{
						"I've always been nimble and quick of wit, so I decided to use those talents to help me make my way in the world.",
						"An assassin or a thief wronged me, so I focused my training on mastering the skills of my enemy to better combat foes of that sort.",
						"An experienced rogue saw something in me and taught me several useful tricks.",
						"I decided to turn my natural lucky streak into the basis of a career, though I still realize that improving my skills is esential.",
						"I took up with a group of ruffians who showed me how to get what I want through sneakiness rather than direct confrontation.",
						"I'm a sucker for a shiny bauble or a sack of coins, as long as I can get my ands on it without risking life and limb."
					};

					public static string[] sorcerer =
					{
						"When I was born, all the water in the house forze solid, the milk spoiled, or all the iron turned to copper. My family is convinced that this event was a harbinger of stranger things to come for me.",
						"I suffered a terrible emotional or physical strain, which brought forth my latent magical power. I have fought to control it ever since.",
						"My immediate family never spoke of my ancestors, and when I asked, they would change the subject. It wasn't until I started displaying strange talents that the full truth of my heritage came out.",
						"When a monster threatened one of my friends, I became filled with anxiety. I lashed out instinctively and blasted the wretched thing with a force that came from me.",
						"Sensing something special in me, a stranger taught me how to control my gift.",
						"After I escaped from a magical conflagration, I realized that thought I was unharmed, I was not unchanged. I began to exhibit unusual abilities that I am just beginning to understand."
					};

					public static string[] warlock =
					{
						"While wandering around in a forbidden place, I encountered an otherworldly being that offered to enter into a pact with me.",
						"I was examining a strange tome I found in an abandoned library when the entity that would become my patron suddenly appeared before me.",
						"I stumbled into the clutches of my patron after I accidentally stepped through a magical doorway.",
						"When I was faced with a terrible crisis, I prayed to any being who would listen, and the creature that answered became my patron.",
						"My future patron visited me in my dreams and offered great power in exchange for my service.",
						"One of my ancestors had a pact with my patron, so that entity was determined to bind me to the same agreement."
					};

					public static string[] wizard =
					{
						"An old wizard chose me from among several candidates to serve an apprenticeship.",
						"When I became lost in a forest, a hedge wizard found me, took me in, and taught me the rudiments of magic.",
						"I grew up listening to tales of great wizards and knew I wanted to follow their path. I strove to be accepted at an academy of magic and succeeded.",
						"One of my relatives was an accomplished wizard who decided I was smart enough to learn the craft.",
						"While exploring an old tomb, library, or temple, I found a spellbook. I was immediately driven to learn all I could about becoming a wizard.",
						"I was a prodigy who demonstrated mastery of the arcane arts at an early age. When I became old enough to set out on my own, I did so to learn more magic and expand my power."
					};
				}
			}

			public static string[] life_events_by_age_current_age =
			{
				"20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger",
				"20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger",
				"20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger",
				"20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger", "20 years or younger",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"21-30 years", "21-30 years", "21-30 years", "21-30 years",
				"31-40 years", "31-40 years", "31-40 years", "31-40 years", "31-40 years",
				"31-40 years", "31-40 years", "31-40 years", "31-40 years", "31-40 years",
				"41-50 years", "41-50 years", "41-50 years", "41-50 years", "41-50 years",
				"41-50 years", "41-50 years", "41-50 years", "41-50 years", "41-50 years",
				"41-50 years", "41-50 years", "41-50 years", "41-50 years", "41-50 years",
				"41-50 years", "41-50 years", "41-50 years", "41-50 years", "41-50 years",
				"51-60 years", "51-60 years", "51-60 years", "51-60 years", "51-60 years",
				"51-60 years", "51-60 years", "51-60 years", "51-60 years", "51-60 years",
				"61 years or older"
			};

			public static string[] life_events =
			{
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You suffered a tragedy. Roll on the Tragedies table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You gained a bit of good fortune. Roll on the Boons table.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You spent time working in a job related to your background. Start the game with an extra 2d6 gp.",
				"You met someone important. Use the supplemental tables to determine this character's identity and how this individual feels about you. Work out additional details with your DM as needed to fit this character into your backstory.",
				"You met someone important. Use the supplemental tables to determine this character's identity and how this individual feels about you. Work out additional details with your DM as needed to fit this character into your backstory.",
				"You met someone important. Use the supplemental tables to determine this character's identity and how this individual feels about you. Work out additional details with your DM as needed to fit this character into your backstory.",
				"You met someone important. Use the supplemental tables to determine this character's identity and how this individual feels about you. Work out additional details with your DM as needed to fit this character into your backstory.",
				"You met someone important. Use the supplemental tables to determine this character's identity and how this individual feels about you. Work out additional details with your DM as needed to fit this character into your backstory.",
				"You went on an adventure. Roll on the Adventures table to see what happened to you. Work with your DM to determine the nature of the adventure and the creatures you encountered.",
				"You went on an adventure. Roll on the Adventures table to see what happened to you. Work with your DM to determine the nature of the adventure and the creatures you encountered.",
				"You went on an adventure. Roll on the Adventures table to see what happened to you. Work with your DM to determine the nature of the adventure and the creatures you encountered.",
				"You went on an adventure. Roll on the Adventures table to see what happened to you. Work with your DM to determine the nature of the adventure and the creatures you encountered.",
				"You went on an adventure. Roll on the Adventures table to see what happened to you. Work with your DM to determine the nature of the adventure and the creatures you encountered.",
				"You had a supernatural experience. Roll on the Supernatural Events table to find out what it was.",
				"You had a supernatural experience. Roll on the Supernatural Events table to find out what it was.",
				"You had a supernatural experience. Roll on the Supernatural Events table to find out what it was.",
				"You had a supernatural experience. Roll on the Supernatural Events table to find out what it was.",
				"You had a supernatural experience. Roll on the Supernatural Events table to find out what it was.",
				"You fought in a battle. Roll on the War table to learn what happened to you. Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war.",
				"You fought in a battle. Roll on the War table to learn what happened to you. Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war.",
				"You fought in a battle. Roll on the War table to learn what happened to you. Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war.",
				"You fought in a battle. Roll on the War table to learn what happened to you. Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war.",
				"You fought in a battle. Roll on the War table to learn what happened to you. Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war.",
				"You committed a crime or were wrongly accused of doing so. Roll on the Crime table to determine the nature of the offense and on the Punishment table to see what became of you.",
				"You committed a crime or were wrongly accused of doing so. Roll on the Crime table to determine the nature of the offense and on the Punishment table to see what became of you.",
				"You committed a crime or were wrongly accused of doing so. Roll on the Crime table to determine the nature of the offense and on the Punishment table to see what became of you.",
				"You committed a crime or were wrongly accused of doing so. Roll on the Crime table to determine the nature of the offense and on the Punishment table to see what became of you.",
				"You committed a crime or were wrongly accused of doing so. Roll on the Crime table to determine the nature of the offense and on the Punishment table to see what became of you.",
				"You encountered something magical. Roll on the Arcane Matters table.",
				"You encountered something magical. Roll on the Arcane Matters table.",
				"You encountered something magical. Roll on the Arcane Matters table.",
				"You encountered something magical. Roll on the Arcane Matters table.",
				"Something truly strange happened to you. Roll on the Weird Stuff table."
			};

			public static string[] adventures =
			{
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You suffered a grievous injury. Although the wound healed, it still pains you from time to time.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You were wounded, but in time you fully recovered.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found some treasure on your adventure. You have 2d6 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it.",
				"You came across a common magic item (of the DM's choice)."
			};

			public static string[] arcane_matters =
			{
				"You were charmed or frightened by a spell.",
				"You were injured by the effects of a spell.",
				"You witnessed a powerful spell bing cast by a cleric, druid, sorcerer, warlock, or a wizard",
				"You drank a potion (of the DM's choice).",
				"You found a spell scroll (of the DM's choice) and succeeded in casting the spell it contained.",
				"You were affected by teleportation magic.",
				"You turned invisible for a time.",
				"You identified an illusion for what it was.",
				"You saw a creature being conjured by magic.",
				"Your fortune was read by a diviner. Roll twice on the Life Events table, but don't apply the results. Instead, the DM picks one event as a portent of your future (which might or might not come true)."
			};

			public static string[] boons =
			{
				"A friendly wizard gave you a spell scroll containing one cantirp (of the DM's choice).",
				"You saved the life of a commoner, who now owes you a life debt. This individual accompanies you on your travels and performs mundane tasks for you, but will leave if neglected, abused, or imperiled. Determine details about this character by using the supplemental tables and working with your DM.",
				"You found a riding horse.",
				"You found some money. You have 1d20 gp in addition to your regular starting funds.",
				"A relative bequeathed you a simple weapon of your choice.",
				"You found something interesting. You gain one additional trinket.",
				"You once performed a service for a local temple. The next time you visit the temple, you can receive healing up to your hit point maximum.",
				"A friendly alchemist gifted you with a potion of healing or a flask of acid, as you choose.",
				"You found a treasure map.",
				"A distant relative left you a stipend that enables you to live at the comfortable lifestyle for 1d20 years. If you choose to live at a higher lifesylte, you reduce the price of the lifestyle by 2 gp during that time period."
			};

			public static string[] crime =
			{
				"Murder",
				"Theft",
				"Burglary",
				"Assault",
				"Smuggling",
				"Kidnapping",
				"Extortion",
				"Counterfeiting"
			};

			public static string[] punishment =
			{
				"You did not commit the crime and were exonerated after being accused.",
				"You committed the crime or helped do so, but nonetheless the authorities found you not guilty.",
				"You were nearly caught in the act. You had to flee and are wanted in the community where the crime occurred.",
				"You were caught and convicted. You spent time in jail, chained to an oar, or performing hard labor. You served a sentence of 1d4 years or succeeded in escaping after that much time."
			};

			public static string[] supernatural_events =
			{
				"You were ensorcelled by a fey and enslaved for 1d6 years before you escaped.",
				"You saw a demon and ran away before it could do anything to you.",
				"A devil tempted you. Make a DC 10 Wisdom saving throw. On a failed save, your alignment shifts one step toward evil (if it's not evil already), and you start the game with an additional 1d20 + 50 gp.",
				"You woke up one morning miles from your home, with no idea how you got there.",
				"You visited a holy site and felt the presence of the divine there.",
				"You visited a holy site and felt the presence of the divine there.",
				"You witnessed a falling red star, a face appearing in the frost, or some other bizarre happening. You are certain that it was an omen of some sort.",
				"You witnessed a falling red star, a face appearing in the frost, or some other bizarre happening. You are certain that it was an omen of some sort.",
				"You escaped certain death and believe it was the intervention of a god that saved you.",
				"You escaped certain death and believe it was the intervention of a god that saved you.",
				"You witnessed a minor miracle.",
				"You witnessed a minor miracle.",
				"You explored an empty house and found it to be haunted.",
				"You explored an empty house and found it to be haunted.",
				"You were briefly possessed. Roll a d6 to determine what type of creature possessed you: 1, celestial; 2, devil; 3, demon; 4, fey; 5, elemental; 6, undead.",
				"You saw a ghost.",
				"You saw a ghoul feeding on a corpse.",
				"A celestial or a fiend visited you in your dreams to give a warning of dangers to come.",
				"You briefly visited the Feywild or the Shadowfell.",
				"You saw a portal that you believe leads to another plane of existence."
			};

			public static string[] tragedies =
			{
				"A family member or a close friend died. Roll on the Cause of Death supplemental table to find out how.",
				"A family member or a close friend died. Roll on the Cause of Death supplemental table to find out how.",
				"A friendship ended bitterly, and the other person is now hostile to you. The cause might have been a misunderstanding or something you or the former friend did.",
				"You lost all your possessions in a disaster, and you had to rebuild your life.",
				"You were imprisoned for a crime you didn't commit and spent 1d6 years at hard labor, in jail, or shackled to an oar in a slave galley.",
				"War ravaged your home community, reducing everything to rubble and ruin. In the aftermath, you either helped your town rebuild or moved somewhere else.",
				"A lover disappeared without a trace. You have been looking for that person ever since.",
				"A terrible blight in your home community caused crops to fail, and many starved. You lost a sibling or some other family member.",
				"You did something that brought terrible shame to you in the eyes of your family. You might have been involved in a scandal, dabbled in dark magic, or offended someone important. The attitude of your family members toward you becomes indifferent at best, thought they might eventually forgive you.",
				"For a reason you were never told, you were exiled from your community. You then either wandered in the wilderness for a time or promptly found a new place to live.",
				"A romantic relationship ended. Roll a d6. An odd number means it ended with bad feelings, while an even number means it ended amicably.",
				"A current or prospective romantic partner of yours died. Roll on the Cause of Death supplemental table to find out how. If the result is murder, roll a d12. On a 1, you were responsible, whether directly or indirectly."
			};

			public static string[] war =
			{
				"You were knocked out and left for dead. You woke up hours later with no recollection of the battle.",
				"You were badly injured in the fight, and you still bear the awful scars of those wounds.",
				"You were badly injured in the fight, and you still bear the awful scars of those wounds.",
				"You ran away from the battle to save your life, but you still feel shame for your cowardice.",
				"You suffered only minor injuries, and the wounds all healed without leaving scars.",
				"You suffered only minor injuries, and the wounds all healed without leaving scars.",
				"You survived the battle, but you suffer from terrible nightmares in which you relive the experience.",
				"You survived the battle, but you suffer from terrible nightmares in which you relive the experience.",
				"You escaped the battle unscathed, though many of your friends were injured or lost.",
				"You escaped the battle unscathed, though many of your friends were injured or lost.",
				"You acquitted yourself will in battle and are remembered as a hero. You might have received a medal for your bravery."
			};

			public static string[] weird_stuff =
			{
				"You were turned into a toad and remained in that form for 1d4 weeks.",
				"You were petrified and remained a stone statue for a time until someone freed you.",
				"You were enslaved by a hag, a satyr, or some other being and lived in that creature's thrall for 1d6 years.",
				"A dragon held you as prisoner for 1d4 months until adventurers killed it.",
				"You were taken captive by a race of evil humanoids such as drow, kua-toa, or quaggoths. You lived as a slave in the Underdark until you escaped.",
				"You served a powerful adventurer as a hireling. You have only recently left that service. Use the supplemental tables and work with your DM to determine the basic details about your former employer.",
				"You went insane for 1d6 years and recently regained your sanity. A tic or some other bit of odd behavior might linger.",
				"A lover of yours was secretly a silver dragon.",
				"You were captured by a cult and nearly sacrificed on an alter to the foul being the cultists served. You escaped, but you fear they will find you.",
				"You met a demigod, an archdevil, an archfey, a demon loard, or a titan, and you lived to tell the tale.",
				"You were swallowed by a giant fish and spent a month in its gullet before you escaped.",
				"A powerful being granted you a wish, but you squandered it on something frivolous."
			};

			public static string[] alignment =
			{
				"Chaotic evil (50%) or chaotic neutral (50%)",
				"Lawful evil", "Lawful evil",
				"Neutral evil", "Neutral evil", "Neutral evil",
				"Neutral", "Neutral", "Neutral", "Neutral",
				"Neutral good", "Neutral good", "Neutral good",
				"Lawful good (50%) or lawful neutral (50%)", "Lawful good (50%) or lawful neutral (50%)",
				"Chaotic good (50%) or chaotic neutral (50%)"
			};

			public static string getNumberOfSiblings()
			{
				int num = roll(1, 10) - 1;

				switch (num)
				{
					case 1:
					case 2:
						{
							return "None";
						}
					case 3:
					case 4:
						{
							return roll(1, 3).ToString();
						}
					case 5:
					case 6:
						{
							return (roll(1, 4) + 1).ToString();
						}
					case 7:
					case 8:
						{
							return (roll(1, 6) + 2).ToString();
						}
					case 9:
					case 10:
						{
							return (roll(1, 8) + 3).ToString();
						}
				}

				return "";
			}

			public static int getFamilyLifestyleModifier()
			{
				int num = roll(3, 6);

				switch (num)
				{
					case 3:
						return -40;
					case 4:
					case 5:
						return -20;
					case 6:
					case 7:
					case 8:
						return -10;
					case 9:
					case 10:
					case 11:
					case 12:
						return 0;
					case 13:
					case 14:
					case 15:
						return 10;
					case 16:
					case 17:
						return 20;
					case 18:
						return 40;
				}

				return -1;
			}

			public static string getChildhoodHome()
			{
				int mod = getFamilyLifestyleModifier();

				int num = roll(1, 100) + mod;

				if (num > 110)
				{
					return "Palace or castle";
				}
				else if (num > 90)
				{
					return "Mansion";
				}
				else if (num > 70)
				{
					return "Large House";
				}
				else if (num > 50)
				{
					return "Small house";
				}
				else if (num > 40)
				{
					return "Apartment in a rundown neighborhood";
				}
				else if (num > 30)
				{
					return "Encampment or village in the wilderness";
				}
				else if (num > 20)
				{
					return "No permanent residence; you moved around a lot";
				}
				else if (num > 0)
				{
					return "Rundown shack";
				}
				else
				{
					return "On the streets";
				}
			}

			public static string getChildhoodHome(int mod)
			{
				int num = roll(1, 100) + mod;

				if (num > 110)
				{
					return "Palace or castle";
				}
				else if (num > 90)
				{
					return "Mansion";
				}
				else if (num > 70)
				{
					return "Large House";
				}
				else if (num > 50)
				{
					return "Small house";
				}
				else if (num > 40)
				{
					return "Apartment in a rundown neighborhood";
				}
				else if (num > 30)
				{
					return "Encampment or village in the wilderness";
				}
				else if (num > 20)
				{
					return "No permanent residence; you moved around a lot";
				}
				else if (num > 0)
				{
					return "Rundown shack";
				}
				else
				{
					return "On the streets";
				}
			}

			public static string getChildhoodMemories(int mod)
			{
				int num = (roll(3, 6) + mod);

				if (num > 17)
				{
					return "Everyone knew who I was, and I had friends everywhere I went.";
				}

				if (num < 4)
				{
					return "I am still haunted by my childhood, when I was treated badly by my peers.";
				}

				num -= 3;

				while (num > 14)
				{
					num--;
				}

				if (num < 0)
				{
					num = 0;
				}

				return childhood_memories[num];
			}
		}

		#endregion XGE
	}

	public class TableRow
	{
		public static readonly int EMPTY = -1;
		private readonly int minRoll, maxRoll;
		private readonly string entry;

		public string Entry
		{
			get { return entry; }
		}

		public int Min
		{
			get { return minRoll; }
		}

		public int Max
		{
			get { return maxRoll; }
		}

		public TableRow() { }

		public TableRow(int min, int max, string str)
		{
			minRoll = min;
			maxRoll = max;
			entry = str;
		}

		public static implicit operator String(TableRow tr)
		{
			return tr.Entry;
		}

		public override string ToString()
		{
			string res = "";

			if (minRoll < 10)
			{
				res += "0";
			}
			else if (minRoll == 100)
			{
				return res + "00       " + entry;
			}

			res += minRoll.ToString();

			if (maxRoll != EMPTY)
			{
				res += "-";
				if (maxRoll < 10)
				{
					res += "0" + maxRoll.ToString();
				}
				else if (maxRoll == 100)
				{
					res += "00";
				}
				else
				{
					res += maxRoll.ToString();
				}
			}
			else
			{
				res += "     ";
			}

			res += "  " + entry;

			return res;
		}

		public bool numInRange(int num)
		{
			return num >= minRoll && num <= maxRoll;
		}
	}

	public class Table
	{
		private string tableName;
		private TableRow[] tableRows;
		private int length = 0;
		private int maxRoll = 0;

		public string Name
		{
			get
			{
				return tableName;
			}
		}

		public TableRow[] Entries
		{
			get
			{
				return tableRows;
			}
		}

		public int Length
		{
			get
			{
				return length;
			}
		}

		public int MaxRoll
		{
			get
			{
				return maxRoll;
			}
		}

		public TableRow this[int i]
		{
			get { return tableRows[i]; }
		}

		public Table(string name, TableRow[] entries)
		{
			tableName = name;
			tableRows = entries;
			length = entries.Length;
			maxRoll = entries[length - 1].Max;
		}

		public string rollOnTable(int modifier = 0)
		{
			modifier += Data.roll(1, maxRoll);

			for (int i = 0; i < length; i++)
			{
				if(Entries[i].numInRange(modifier))
				{
					return Entries[i];
				}
			}

			return "Error in Table.rollOnTable";
		}
		
	}
}