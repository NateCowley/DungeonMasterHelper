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

	// TODO: check values for tables, I apparently didn't create the simple types well enough,
	// numbers are off for the current tables

	public static partial class Data
	{
		public static class DMG
		{
			// Chapter 1
			public static class World
			{
				public static readonly Table forms_of_government = new Table("Forms of Government", "Government", Data.Rolls_String.d100, "", Data.Titles.DMG, 18, new TableRow[]{
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
				new TableRow(95, TableRow.NOVALUE, "Kleptocracy"),
				new TableRow(96, 100, "Theocracy"),
			});

				public static readonly Table forms_of_government_explanation = new Table("Forms of Government Explanations", "Government", Data.Rolls_String.d20, "", Data.Titles.DMG, 18, new TableRow[]{
				new TableRow(1, 8, "One hereditary ruler wields absolute power. The autocrat either is supported by a well-developed bureaucracy or military or stands as the only authority in an otherwise anarchic society. The dynastic ruler could be immortal or undead. Aundair and Karrnath, two kingdoms in the Eberron campaign setting, have autocrats with royal blood in their veins. Whereas Queen Aurala of Aundair relies on wizards and spies to enforce her will, Kaius, the vampire king of Karrnath, has a formidable army of living and undead soldiers under his command."),
				new TableRow(9, 13, "Various departments compsoe the government, each responsible for an aspect of rule. The department heads, ministers, or secretaries answer to a figurehead autocrat or council."),
				new TableRow(14, 19, "Each individual city or town within the confederacy governs itself, but all contribute to a league or federation that promotes (at least in theory) the common good of all member states. Conditions and attitudes toward the central government vary from place to place within the confederacy. The Lords' Alliance in the Forgotten Realms setting is a loose confederacy of cities, while the Mror Holds in the Eberron campaign setting is a confederacy of allied dwarf clans."),
				new TableRow(20, 22, "Citizens or their elected representatives determine the laws in a democracy. A bureaucracy or military carries out the day-to-day work of government, with positions filled through open elections."),
				new TableRow(23, 27, "One supreme ruler holds absolute authority, but his or her rule isn't necessarily dynastic. In other respects this resembles an autocracy. In the Greyhawk campaign setting, a half-demon named Iuz is the dictator of a conquered land that bears his name."),
				new TableRow(28, 42, "The typical government of Europe in the Middle Ages, a feudalistic society consists of layers of lords and vassals. The vassals provide soldiers or scutage (payment in lieu of military service) to the lords, who in turn promise protection to their vassals."),
				new TableRow(43, 44, "Elders preside over this society. In some cases, long-lived races such as elves or dragons are entrusted with the leadership of the land."),
				new TableRow(45, 53, "A feudal or bureaucratic government where every member, except one, is subordinate to another member. In the Draognlance campaign setting, the dragon armies of Krynn form a military hierarchy, with the Dragon Highlords as leaders under the dragon queen Takhisis."),
				new TableRow(54, 56, "The governing body is composed of spellcasters who rule directly as oligarchs or feudal lords, or participate in a democracy or bureaucracy. Examples include the Red Wizards of Thay in the Forgotten Realms campaign setting and the sorcerer-kings of Athas in the Dark Sun campaign setting."),
				new TableRow(57, 58, "This society is governed by the eldest or most important members of one gender. Drow cities are examples of theocratic matriarchies, for each is ruled by a council of drow high priestesses who answer to Lolth, the Demon Queen of Spiders."),
				new TableRow(59, 64, "Military leaders run the nation under martial law, using the army and other armed forces. A militocracy might be based on an elite group of soldiers, an order of dragon riders, or a league of sea princes. Solamnia, a nation ruled by knights in the Dragonlance campaign setting, falls into this category."),
				new TableRow(65, 74, "A single hereditary sovereign wears the crown. Unlike the autocrat, the monarch's powers are limited by law, and the ruler serves as the head of a democracy, feudal state, or militocracy. The kingdom of Breland, in the Eberron campaign setting, has both a parliament that makes laws and a monarch who enforces them."),
				new TableRow(75, 78, "A small number of absolute rulers share power, possibly dividing the land into districts or provinces under their control, or jointly ruling together. A group of adventurers who take control of a nation together migth form an oligarchy. The Free City of Greyhawk is an oligarchy composed of various faction leaders, wit ha Lord Mayor as its figurehead."),
				new TableRow(79, 80, "This society is governed by the eldest or most important members of one gender. Drow cities are examples of theocratic matriarchies, for each is ruled by a council of drow high priestesses who answer to Lolth, the Demon Queen of Spiders."),
				new TableRow(81, 83, "The most intelligent and educated people oversee the society, often with a bureaucracy to handle the day-to-day work of government. In the Forgotten Realms, scholarly monks preside over the fortress-library of Candlekeep, overseen by a master of lore called the Keeper."),
				new TableRow(84, 85, "Society is governed by the wealthy. The elite form a ruling council, purchase representation at the court of a figurehead monarch, or rule by default because money is the true power in the realm. Many cities in the Forgotten Realms campaign setting, includeing Waterdeep and Baldur's Gate, are plutocracies."),
				new TableRow(86, 92, "Government is entrusted to representatives of an established electorate who rule on behalf of the electors. Any democracy in which only landowners or certain classes can vote could be considered a republic."),
				new TableRow(93, 94, "Conquerors and representatives of another government wield power, ruling the settlement or region as part of a larger empire. The satraps are bureaucrats and military officers, or unusual characters or monsters. The cities of Highport and Suderham in the Greyhawk campaign setting are satrapies controlled by agents of a visious gane of marauders known as the Slave Lords."),
				new TableRow(95, TableRow.NOVALUE, "This government is composed of groups or individuals primarily seeking wealth for themselves, often at the expense of their subjects. The grasping Bandit Kingdoms in the Greyhawk campaign setting are prime examples. A kingdom run by thieves' guilds would also fall into this category."),
				new TableRow(96, 100, "Rulership falls to a direct representative or a collection of agents of a deity. The centers of power in a theocracy are usually located on sacred sites. In the Eberron campaign setting, the nation of Thrane is a theocracy devoted to the Silver Flame, a divine spirit that resides in Thrane's capital of Flamekeep."),
			});

				public static readonly Table world_shaking_events = new Table("World Shaking Events", "Event", Data.Rolls_String.d10, "", Data.Titles.DMG, 27, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Rise of a leader or an era"),
				new TableRow(2, TableRow.NOVALUE, "Fall of a leader or an era"),
				new TableRow(3, TableRow.NOVALUE, "Cataclysmic disaster"),
				new TableRow(4, TableRow.NOVALUE, "Assault or invasion"),
				new TableRow(5, TableRow.NOVALUE, "Rebellion, revolution, overthrow"),
				new TableRow(6, TableRow.NOVALUE, "Extinction or depletion"),
				new TableRow(7, TableRow.NOVALUE, "New organization"),
				new TableRow(8, TableRow.NOVALUE, "Discovery, expansion, invention"),
				new TableRow(9, TableRow.NOVALUE, "Prediction, omen, prophecy"),
				new TableRow(10, TableRow.NOVALUE, "Myth and legend"),
			});

				public static readonly Table leader_types = new Table("Leader Types", "Leader Type", Data.Rolls_String.d6, "", Data.Titles.DMG, 27, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Political"),
				new TableRow(2, TableRow.NOVALUE, "Religious"),
				new TableRow(3, TableRow.NOVALUE, "Military"),
				new TableRow(4, TableRow.NOVALUE, "Crime/underworld"),
				new TableRow(5, TableRow.NOVALUE, "Art/culture"),
				new TableRow(6, TableRow.NOVALUE, "Philosophy/learning/magic"),
			});

				public static readonly Table cataclysmic_distasters = new Table("Cataclysmic Disasters", "Cataclysmic Distaster", Data.Rolls_String.d10, "", Data.Titles.DMG, 28, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Earthquake"),
				new TableRow(2, TableRow.NOVALUE, "Famin/drought"),
				new TableRow(3, TableRow.NOVALUE, "Fire"),
				new TableRow(4, TableRow.NOVALUE, "Flood"),
				new TableRow(5, TableRow.NOVALUE, "Plauge/disease"),
				new TableRow(6, TableRow.NOVALUE, "Rain of fire (meteoric impact)"),
				new TableRow(7, TableRow.NOVALUE, "Storm (hurricane, tornado, tsunami)"),
				new TableRow(8, TableRow.NOVALUE, "Volcanic eruption"),
				new TableRow(9, TableRow.NOVALUE, "Magic gone awry or a planar warp"),
				new TableRow(10, TableRow.NOVALUE, "Divine judgment"),
			});

				public static readonly Table invading_forces = new Table("Invading Forces", "Invading Force", Data.Rolls_String.d8, "", Data.Titles.DMG, 29, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "A criminal enterprise"),
				new TableRow(2, TableRow.NOVALUE, "Monsters or a unique monster"),
				new TableRow(3, TableRow.NOVALUE, "A planar threat"),
				new TableRow(4, TableRow.NOVALUE, "A past adversary reawakened, reborn, or resurgent"),
				new TableRow(5, TableRow.NOVALUE, "A splinter faction"),
				new TableRow(6, TableRow.NOVALUE, "A savage tribe"),
				new TableRow(7, TableRow.NOVALUE, "A secret society"),
				new TableRow(8, TableRow.NOVALUE, "A traitorous ally"),
			});

				public static readonly Table extinction_or_depletion = new Table("Extinction or Depletion", "Lost Resource", Data.Rolls_String.d8, "", Data.Titles.DMG, 30, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "A kind of animal (insect, bird, fish, livestock"),
				new TableRow(2, TableRow.NOVALUE, "Habitable land"),
				new TableRow(3, TableRow.NOVALUE, "Magic or magic-users (all magic, specific kinds, or schools of magic"),
				new TableRow(4, TableRow.NOVALUE, "A mineral resource (gems, metals, ores)"),
				new TableRow(5, TableRow.NOVALUE, "A type of monster (unicorn, manticore, dragon)"),
				new TableRow(6, TableRow.NOVALUE, "A people (family line, clan, culture, race)"),
				new TableRow(7, TableRow.NOVALUE, "A kind of plant(crop, tree, herb, forest)"),
				new TableRow(8, TableRow.NOVALUE, "A waterway (river, lake, ocean"),
			});

				public static readonly Table new_organizations = new Table("New Organizations", "New Organization", Data.Rolls_String.d10, "", Data.Titles.DMG, 31, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Crime syndicate/bandit confederacy"),
				new TableRow(2, TableRow.NOVALUE, "Guild (masons, apothecaries, goldsmiths)"),
				new TableRow(3, TableRow.NOVALUE, "Magical circle/society"),
				new TableRow(4, TableRow.NOVALUE, "Military/knightly order"),
				new TableRow(5, TableRow.NOVALUE, "New family dynasty/tribe/clan"),
				new TableRow(6, TableRow.NOVALUE, "Philosophy/discipline dedicated to a principle or ideal"),
				new TableRow(7, TableRow.NOVALUE, "Realm (village, town, duchy, kingdom"),
				new TableRow(8, TableRow.NOVALUE, "Religion/sect/denomination"),
				new TableRow(9, TableRow.NOVALUE, "School/university"),
				new TableRow(10, TableRow.NOVALUE, "Secret society/cult/cabal"),
			});

				public static readonly Table discoveries = new Table("Discoveries", "Discovery", Data.Rolls_String.d10, "", Data.Titles.DMG, 31, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Ancient ruin/lost city of a legendary race"),
				new TableRow(2, TableRow.NOVALUE, "Animal/monster/magical mutation"),
				new TableRow(3, TableRow.NOVALUE, "Invention/technology/magic (helpful, destructive)"),
				new TableRow(4, TableRow.NOVALUE, "New (or forgotten) god or planar entity"),
				new TableRow(5, TableRow.NOVALUE, "New (or rediscovered) artifact or religious relic"),
				new TableRow(6, TableRow.NOVALUE, "New land (island, continent, lost world, demiplane)"),
				new TableRow(7, TableRow.NOVALUE, "Otherworldly object (planar portal, alien spacecraft)"),
				new TableRow(8, TableRow.NOVALUE, "People (race, tribe, lost civilization, colony)"),
				new TableRow(9, TableRow.NOVALUE, "Plant (miracle herb, fungal parasite, sentient plant)"),
				new TableRow(10, TableRow.NOVALUE, "Resource or wealth (gold, gems, mithral)"),
			});
			}

			// Chapter 2
			public static class Multiverse
			{
				public static readonly Table astral_color_pools = new Table("Astral Color Pools", "Plane, Color", Data.Rolls_String.d20, "", Data.Titles.DMG, 47, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Ysgard, Indigo"),
				new TableRow(2, TableRow.NOVALUE, "Limbo, Jet black"),
				new TableRow(3, TableRow.NOVALUE, "Pandemonium, Magenta"),
				new TableRow(4, TableRow.NOVALUE, "The Abyss, Amethyst"),
				new TableRow(5, TableRow.NOVALUE, "Carceri, Olive"),
				new TableRow(6, TableRow.NOVALUE, "Hades, Rust"),
				new TableRow(7, TableRow.NOVALUE, "Gehenna, Russet"),
				new TableRow(8, TableRow.NOVALUE, "The Nine Hells, Ruby"),
				new TableRow(9, TableRow.NOVALUE, "Acheron, Flame red"),
				new TableRow(10, TableRow.NOVALUE, "Mechanus, Diamond blue"),
				new TableRow(11, TableRow.NOVALUE, "Arcadia, Saffron"),
				new TableRow(12, TableRow.NOVALUE, "Mount Celestia, Gold"),
				new TableRow(13, TableRow.NOVALUE, "Bytopia, Amber"),
				new TableRow(14, TableRow.NOVALUE, "Elysium, Orange"),
				new TableRow(15, TableRow.NOVALUE, "The Beastlands, Emerald green"),
				new TableRow(16, TableRow.NOVALUE, "Arborea, Saphire blue"),
				new TableRow(17, TableRow.NOVALUE, "The Outlands, Leather brown"),
				new TableRow(18, TableRow.NOVALUE, "Ethereal Plane, Spiraling white"),
				new TableRow(19, 20, "Material Plane, Silver"),
			});

				public static readonly Table psychic_wind_effects_location_effect = new Table("Psychic Wind Effects - Location", "Location Effect", Data.Rolls_String.d20, "", Data.Titles.DMG, 48, new TableRow[]{
				new TableRow(1, 8, "Diverted; add 1d6 hours to travel time"),
				new TableRow(9, 12, "Blown off course; add 3d10 hours to travel time"),
				new TableRow(13, 16, "Lost; at the end of the travel time, characters arrive at a location other than the intended destination"),
				new TableRow(17, 20, "Sent through color pool to a random plane (roll on the Astral Color Pools table)"),
			});

				public static readonly Table psychic_wind_effects_mental_effects = new Table("Psychic Wind Effects - Mental Effects", "Mental Effect", Data.Rolls_String.d20, "", Data.Titles.DMG, 48, new TableRow[]{
				new TableRow(1, 8, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"),
				new TableRow(9, 10, "Short-term madness (see chapter 8)"),
				new TableRow(11, 12, "11 (2d10) psychic damage"),
				new TableRow(13, 16, "22 (4d10) psychic damage"),
				new TableRow(17, 18, "Long-term madness (see chapter 8)"),
				new TableRow(19, 20, "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake"),
			});

				public static readonly Table ethereal_curtains = new Table("Ethereal Curtains - Plane", "Plane, Color of Curtain", Data.Rolls_String.d8, "", Data.Titles.DMG, 49, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Material Plane, Bright turquoise"),
				new TableRow(2, TableRow.NOVALUE, "Shadowfell, Dusky gray"),
				new TableRow(3, TableRow.NOVALUE, "Feywild, Opulescent white"),
				new TableRow(4, TableRow.NOVALUE, "Plane of Air, Pale blue"),
				new TableRow(5, TableRow.NOVALUE, "Plane of Earth, Reddish-brown"),
				new TableRow(6, TableRow.NOVALUE, "Plane of Fire, Orange"),
				new TableRow(7, TableRow.NOVALUE, "Plane of Water, Green"),
				new TableRow(8, TableRow.NOVALUE, "Elemental Chaos, Swirling mix of colors"),
			});

				public static readonly Table ether_cyclone = new Table("Ether Cyclone", "Effect", Data.Rolls_String.d20, "", Data.Titles.DMG, 49, new TableRow[]{
				new TableRow(1, 12, "Extended journey"),
				new TableRow(13, 19, "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table"),
				new TableRow(20, TableRow.NOVALUE, "Hurled into the Astral Plane"),
			});

				public static readonly Table feywild_time_warp = new Table("Feywild Time Warp", "Result", Data.Rolls_String.d20, "", Data.Titles.DMG, 50, new TableRow[]{
				new TableRow(1, 2, "Days become minutes"),
				new TableRow(3, 6, "Days become hours"),
				new TableRow(7, 13, "No change"),
				new TableRow(14, 17, "Days become weeks"),
				new TableRow(18, 19, "Days become months"),
				new TableRow(20, TableRow.NOVALUE, "Days become years"),
			});

				public static readonly Table shadowfell_despair = new Table("Shadowfell Despair", "Effect", Data.Rolls_String.d6, "", Data.Titles.DMG, 52, new TableRow[]
				{
				new TableRow(1, 3, "Apathy. The character has disadvantage on death saving throws and on Dexterity checks for initiative, and gains the following flaw: \"I don't believe I can make a difference to anyone or anything.\""),
				new TableRow(4, 5, "Dread. The character has disadvantage on all saving throws and gains the following flaw: \"I am convinced that this place is going to kill me.\""),
				new TableRow(6, TableRow.NOVALUE, "Madness. The character has disadvantage on ability checks and saving throws that use Intelligence, Wisdom, or Charisma, and gains the following flaw: \"I can't tell what's real anymore\"")
				});

				public static readonly Table abyssal_corruption = new Table("Abyssal Corruption", "Result", Data.Rolls_String.d10, "", Data.Titles.DMG, 62, new TableRow[]
				{
				new TableRow(1, 4, "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\""),
				new TableRow(5, 7, "Bloodlust. The character gains the following flaw: \"I enjoy killing for its own sake, and once I start, it's hard to stop\""),
				new TableRow(8, 9, "Mad Ambition. The character gains the following flaw: \"I am destined to rule the Abyss, and my companions are tools to that end.\""),
				new TableRow(10, TableRow.NOVALUE, "Demonic Possession. The character is possessed by a demonic entity until freed by Dispel Evil and Good or similar magic. Whenever the possessed character rolls a 1 on an attack roll, ability check, or saving throw, the demon takes control of the character and determines the character's behavior. At the end of each of the possessed character's turns, he or she can make a DC 15 Charisma saving throw. On a success, the character regains control until he or she rolls another 1.")
				});

				public static string getPsychicWindEffectsLocationEffect()
				{
					int num = roll(1, 20);

					if (num < 9)
					{
						return "Diverted; add " + roll(1, 6) + " hours to travel time";
					}
					else if (num < 13)
					{
						return "Blown off course; add " + (roll(1, 10) * 3) + " hours to travel time";
					}
					else if (num < 17)
					{
						return "Lost; at the end of the travel time, characters arrive at a location other than the intended destination";
					}
					else
					{
						num = roll(1, astral_color_pools.MaxRoll);

						string str = "";

						if (num > 17)
						{
							str = "The ";
						}

						string s = astral_color_pools[num];

						return "Sent through color pool to " + str + s.Substring(0, s.IndexOf(','));
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
					int num = roll(1, 20);

					if (num < 13)
					{
						return "Extended journey";
					}
					else if (num < 20)
					{
						string s = ethereal_curtains[roll(1, ethereal_curtains.MaxRoll)];
						return "Blown to the Border Ethereal of the " + s.Substring(0, s.IndexOf(','));
					}
					else
					{
						return "Hurled into the Astral Plane";
					}
				}
			}

			// Chapter 3
			public static class Adventures
			{
				public static readonly Table dungeon_goals = new Table("Dungeon Goals", "Goal", Data.Rolls_String.d20, "", Data.Titles.DMG, 73, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Stop the dungeon's monstrous inhabitants from raiding the surface world."),
				new TableRow(2, TableRow.NOVALUE, "Foil a villain's evil scheme."),
				new TableRow(3, TableRow.NOVALUE, "Destroy a magical threat inside the dungeon."),
				new TableRow(4, TableRow.NOVALUE, "Acquire treasure."),
				new TableRow(5, TableRow.NOVALUE, "Find a particular item for a specific purpose."),
				new TableRow(6, TableRow.NOVALUE, "Retrieve a stolen item hidden in the dungeon."),
				new TableRow(7, TableRow.NOVALUE, "Find information needed for a special purpose."),
				new TableRow(8, TableRow.NOVALUE, "Rescue a captive."),
				new TableRow(9, TableRow.NOVALUE, "Discover the fate of a previous adventuring party."),
				new TableRow(10, TableRow.NOVALUE, "Find an NPC who disappeared in the area."),
				new TableRow(11, TableRow.NOVALUE, "Slay a dragon or some other challenging monster."),
				new TableRow(12, TableRow.NOVALUE, "Discover the nature and origin of a strange location or phenomenon."),
				new TableRow(13, TableRow.NOVALUE, "Pursue fleeing foes taking refuge in the dungeon."),
				new TableRow(14, TableRow.NOVALUE, "Escape from captivity in the dungeon."),
				new TableRow(15, TableRow.NOVALUE, "Clear a ruin so it can be rebuilt and reoccupied."),
				new TableRow(16, TableRow.NOVALUE, "Discover why a villain is interested in the dungeon."),
				new TableRow(17, TableRow.NOVALUE, "Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time."),
				new TableRow(18, TableRow.NOVALUE, "Parley with a villain in the dungeon."),
				new TableRow(19, TableRow.NOVALUE, "Hide from a threat outside the dungeon."),
				new TableRow(20, TableRow.NOVALUE, "Roll twice, ignoring results of 20."),
			});

				public static readonly Table wilderness_goals = new Table("Wilderness Goals", "Goal", Data.Rolls_String.d20, "", Data.Titles.DMG, 73, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why)."),
				new TableRow(2, TableRow.NOVALUE, "Assess the scope of a natural or unnatural disaster."),
				new TableRow(3, TableRow.NOVALUE, "Escort an NPC to a destination."),
				new TableRow(4, TableRow.NOVALUE, "Arrive at a destination without being seen by the villain's forces."),
				new TableRow(5, TableRow.NOVALUE, "Stop monsters from raiding caravans and farms."),
				new TableRow(6, TableRow.NOVALUE, "Establish trade with a distant town."),
				new TableRow(7, TableRow.NOVALUE, "Protect a caravan traveling to a distant town."),
				new TableRow(8, TableRow.NOVALUE, "Map a new land."),
				new TableRow(9, TableRow.NOVALUE, "Find a place to establish a colony"),
				new TableRow(10, TableRow.NOVALUE, "Find a natural resource"),
				new TableRow(11, TableRow.NOVALUE, "Hunt a specific monster."),
				new TableRow(12, TableRow.NOVALUE, "Return home from a distant place."),
				new TableRow(13, TableRow.NOVALUE, "Obtain information from a reclusive hermit."),
				new TableRow(14, TableRow.NOVALUE, "Find an object that was lost in the wilds."),
				new TableRow(15, TableRow.NOVALUE, "Discover the fate of a missing group of explorers."),
				new TableRow(16, TableRow.NOVALUE, "Pursue fleeing foes."),
				new TableRow(17, TableRow.NOVALUE, "Assess the size of an approaching army."),
				new TableRow(18, TableRow.NOVALUE, "Escape the reign of a tyrant."),
				new TableRow(19, TableRow.NOVALUE, "Protect a wilderness site from attackers."),
				new TableRow(20, TableRow.NOVALUE, "Roll twice, ignoring results of 20."),
			});

				public static readonly Table other_goals = new Table("Other Goals", "Goal", Data.Rolls_String.d12, "", Data.Titles.DMG, 74, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Seize control of a fortified location such as a fortress, town, or ship."),
				new TableRow(2, TableRow.NOVALUE, "Defend a location from attackers."),
				new TableRow(3, TableRow.NOVALUE, "Retrieve an object from inside a secure location in a settlement."),
				new TableRow(4, TableRow.NOVALUE, "Retrieve an object from a caravan."),
				new TableRow(5, TableRow.NOVALUE, "Salvage an object or goods from a lost vessel or caravan."),
				new TableRow(6, TableRow.NOVALUE, "Break a prisoner out of a jail or prison camp."),
				new TableRow(7, TableRow.NOVALUE, "Escape from a jail or prison camp."),
				new TableRow(8, TableRow.NOVALUE, "Successfully travel through an obstacle course to gain recognition or reward."),
				new TableRow(9, TableRow.NOVALUE, "Infiltrate a fortified location."),
				new TableRow(10, TableRow.NOVALUE, "Find the source of strange occurrences in a haunted house or other location."),
				new TableRow(11, TableRow.NOVALUE, "Interfere wit hthe operation of a business."),
				new TableRow(12, TableRow.NOVALUE, "Rescue a character, monster, or object from a natural or unnatural disaster."),
			});

				public static readonly Table adventure_villains = new Table("Adventure Villains", "Villain", Data.Rolls_String.d20, "", Data.Titles.DMG, 74, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Beast or monstrosity with no particular agenda"),
				new TableRow(2, TableRow.NOVALUE, "Aberration bent on corruption or domination"),
				new TableRow(3, TableRow.NOVALUE, "Fiend bent on corruption or destruction"),
				new TableRow(4, TableRow.NOVALUE, "Dragon bent on domination and plunder"),
				new TableRow(5, TableRow.NOVALUE, "Giant bend on plunder"),
				new TableRow(6, 7, "Undead with any agenda"),
				new TableRow(8, TableRow.NOVALUE, "Fey with a mysterious goal"),
				new TableRow(9, 10, "Humanoid cultist"),
				new TableRow(11, 12, "Humanoid conqueror"),
				new TableRow(13, TableRow.NOVALUE, "Humanoid seeking revenge"),
				new TableRow(14, 15, "Humanoid schemer seeking to rule"),
				new TableRow(16, TableRow.NOVALUE, "Humanoid criminal mastermind"),
				new TableRow(17, 18, "Humanoid raider or ravager"),
				new TableRow(19, TableRow.NOVALUE, "Humanoid under a curse"),
				new TableRow(20, TableRow.NOVALUE, "Misguided humanoid zealot"),
			});

				public static readonly Table adventure_allies = new Table("Adventure Allies", "Ally", Data.Rolls_String.d12, "", Data.Titles.DMG, 74, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Skilled adventurer"),
				new TableRow(2, TableRow.NOVALUE, "Inexperienced adventurer"),
				new TableRow(3, TableRow.NOVALUE, "Enthusiastic commoner"),
				new TableRow(4, TableRow.NOVALUE, "Soldier"),
				new TableRow(5, TableRow.NOVALUE, "Priest"),
				new TableRow(6, TableRow.NOVALUE, "Sage"),
				new TableRow(7, TableRow.NOVALUE, "Revenge seeker"),
				new TableRow(8, TableRow.NOVALUE, "Raving lunatic"),
				new TableRow(9, TableRow.NOVALUE, "Celestial ally"),
				new TableRow(10, TableRow.NOVALUE, "Fey ally"),
				new TableRow(11, TableRow.NOVALUE, "Disguised monster"),
				new TableRow(12, TableRow.NOVALUE, "Villain posing as an ally"),
			});

				public static readonly Table adventure_patrons = new Table("Adventure Patrons", "Patron", Data.Rolls_String.d20, "", Data.Titles.DMG, 74, new TableRow[]{
				new TableRow(1, 2, "Retired adventurer"),
				new TableRow(3, 4, "Local ruler"),
				new TableRow(5, 6, "Military officer"),
				new TableRow(7, 8, "Temple official"),
				new TableRow(9, 10, "Sage"),
				new TableRow(11, 12, "Respected elder"),
				new TableRow(13, TableRow.NOVALUE, "Deity or celestial"),
				new TableRow(14, TableRow.NOVALUE, "Mysterious fey"),
				new TableRow(15, TableRow.NOVALUE, "Old friend"),
				new TableRow(16, TableRow.NOVALUE, "Former teacher"),
				new TableRow(17, TableRow.NOVALUE, "Parent or other family member"),
				new TableRow(18, TableRow.NOVALUE, "Desperate commoner"),
				new TableRow(19, TableRow.NOVALUE, "Embattled merchant"),
				new TableRow(20, TableRow.NOVALUE, "Villain posing as a patron"),
			});

				public static readonly Table adventure_introduction = new Table("Adventure Introduction", "Introduction", Data.Rolls_String.d12, "", Data.Titles.DMG, 74, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location."),
				new TableRow(2, TableRow.NOVALUE, "While traveling in the wilderness, the characters notice the entrance to the adventure location."),
				new TableRow(3, TableRow.NOVALUE, "While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location."),
				new TableRow(4, TableRow.NOVALUE, "The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map."),
				new TableRow(5, TableRow.NOVALUE, "A mysterious magic item or a cruel villain teleports the characters to the adventure location"),
				new TableRow(6, TableRow.NOVALUE, "A stranger approaches the characters in a tavern and urges them toward the adventure location."),
				new TableRow(7, TableRow.NOVALUE, "A town or village needs volunteers to go to the adventure location."),
				new TableRow(8, TableRow.NOVALUE, "An NPC the characters care about needs them to go to the adventure location."),
				new TableRow(9, TableRow.NOVALUE, "An NPC the characters must obey orders them to go to the adventure location."),
				new TableRow(10, TableRow.NOVALUE, "An NPC the characters respect asks them to go to the adventure location."),
				new TableRow(11, TableRow.NOVALUE, "One night, the characters all dream about entering the adventure location."),
				new TableRow(12, TableRow.NOVALUE, "A ghost appears and terrorizes a village. Research reveals that it can be put to rest only by entering the adventure location."),
			});

				public static readonly Table adventure_climax = new Table("Adventure Climax", "Climax", Data.Rolls_String.d12, "", Data.Titles.DMG, 75, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "The adventurers confront the main villain and a group of minions in a bloody battle to the finish."),
				new TableRow(2, TableRow.NOVALUE, "The adventurers chase the villain while dodgin obstacles designed to thwart them, leading to a final confrontation in or outside the villain's refuge."),
				new TableRow(3, TableRow.NOVALUE, "The actions of the adventurers or the villain result in a cataclysmic event that the adventurers must escape."),
				new TableRow(4, TableRow.NOVALUE, "The adventurers race to the site where the villain is bringing a master plan to its conclusion, arriving just as that plan is about to be completed."),
				new TableRow(5, TableRow.NOVALUE, "The villain and two or three lieutenants perform separate rites in a large room. The adventurers must disrupt all the rites at the same time."),
				new TableRow(6, TableRow.NOVALUE, "An ally betrays the adventurers as they're about to achieve their goal (Use this climax carefully, and don't overuse it)."),
				new TableRow(7, TableRow.NOVALUE, "A portal opens to another plane of existence. Creatures on the other side spill out, forcing the adventurers to close the portal and deal with the villain at the same time."),
				new TableRow(8, TableRow.NOVALUE, "Traps, hazards, or animated objects turn against the adventurers while the main villain attacks."),
				new TableRow(9, TableRow.NOVALUE, "The dungeon begins to collapse while the adventurers face the main villain, who attempts to escape in the chaos."),
				new TableRow(10, TableRow.NOVALUE, "A threat more powerful than the adventurers appears, destroys the main villain, and then turns its attention on the characters."),
				new TableRow(11, TableRow.NOVALUE, "The adventurers must choose whether to pursue the fleeing main villain or save an NPC they care about or a group of innocents."),
				new TableRow(12, TableRow.NOVALUE, "The adventurers must discover the main villain's secret weakness before they can hope to defeat that villain."),
			});

				public static readonly Table event_based_villain_actions = new Table("Event Based Villain Actions", "Type of Actions", Data.Rolls_String.d6, "", Data.Titles.DMG, 75, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Big event"),
				new TableRow(2, TableRow.NOVALUE, "Crime spree"),
				new TableRow(3, TableRow.NOVALUE, "Growing corruption"),
				new TableRow(4, TableRow.NOVALUE, "One and done"),
				new TableRow(5, TableRow.NOVALUE, "Serial crimes"),
				new TableRow(6, TableRow.NOVALUE, "Step by step"),
			});

				public static readonly Table event_based_villain_actions_descriptions = new Table("Event Based Villain Actions - Descriptions", "Type of Actions", Data.Rolls_String.d6, "", Data.Titles.DMG, 75, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Big Event. The villain's plans come to fruition during a festival, an astrological event, a holy (or unholy) rite, a royal wedding, the birth of a child, or some similar fixed time. The villain's activities up to that point are geared toward preparation for this event."),
				new TableRow(2, TableRow.NOVALUE, "Crime Spree. The villain commits acts taht become bolder and more heinous over time. A killer might start out by targeting the destitute in the city slums before moving up to a massacre in the marketplace, increasing the horror and the body count each time."),
				new TableRow(3, TableRow.NOVALUE, "Growing Corruption. As time passes, the villain's power and influence grow, affecting more victims across a larger area. This might take the form of armies conquering new territory, an evil cult recruiting new members, or a spreading plague. A pretender to the throne might attempt to secure the support of the kingdom's nobility in the days or weeks leading up to a coup, or a guild leader could corrupt the members of a town council or bribe officers of the watch."),
				new TableRow(4, TableRow.NOVALUE, "One and Done. The villain commits a single crime and then tries to avoid the consequences. Instead of an ongoing plan to commit more crimes, the villain's goal is to lie low or flee the scene."),
				new TableRow(5, TableRow.NOVALUE, "Serial Crimes. The villain commits crimes one after the other, but these acts are repetitive in nature, rather than escalating to greater heights of depravity. The trick to catching such a villain lies in determining the pattern underlying the crimes. Though serial killers are a common example of this type of villain, your villain could be a serial arsonist favoring a certain type of building, a magical sickness that affects spellcasters who cast a specific spell, a thief that targets a certain kind of merchant, or a doppelganger kidnapping and impersonating one noble after another."),
				new TableRow(6, TableRow.NOVALUE, "Step by Step. In pursuit of its goal, the villain carries out a specific set of actions in a particular sequence. A wizard might steal the items needed to create a phylactery and become a lich, or a cultist might kidnap the priests of seven good-aligned gods as a sacrifice. Alternativly, the villain could be following a trail to find the object of its revenge, killing one victim after another while moving ever closer to the real target."),
			});

				public static readonly Table event_based_goals = new Table("Event Based Goals", "Goal", Data.Rolls_String.d20, "", Data.Titles.DMG, 76, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Bring the villain to justice."),
				new TableRow(2, TableRow.NOVALUE, "Clear the name of an innocent NPC."),
				new TableRow(3, TableRow.NOVALUE, "Protect or hide an NPC."),
				new TableRow(4, TableRow.NOVALUE, "Protect an object."),
				new TableRow(5, TableRow.NOVALUE, "Discover the nature and origin of a strange phenomenon that might be the villain's doing."),
				new TableRow(6, TableRow.NOVALUE, "Find a wanted fugitive."),
				new TableRow(7, TableRow.NOVALUE, "Overthrow a tyrant"),
				new TableRow(8, TableRow.NOVALUE, "Uncover a conspiracy to overthrow a ruler."),
				new TableRow(9, TableRow.NOVALUE, "Negotiate peace between enemy nations or feuding families."),
				new TableRow(10, TableRow.NOVALUE, "Secure aid from a ruler or council."),
				new TableRow(11, TableRow.NOVALUE, "Help a villain find redemption"),
				new TableRow(12, TableRow.NOVALUE, "Parley with a villain."),
				new TableRow(13, TableRow.NOVALUE, "Smuggle weapons to rebel forces."),
				new TableRow(14, TableRow.NOVALUE, "Stop a band of smugglers."),
				new TableRow(15, TableRow.NOVALUE, "Gather intelligence on an enemy force."),
				new TableRow(16, TableRow.NOVALUE, "Win a tournament"),
				new TableRow(17, TableRow.NOVALUE, "Determine the villain's identity."),
				new TableRow(18, TableRow.NOVALUE, "Locate a stolen item."),
				new TableRow(19, TableRow.NOVALUE, "Make sure a wedding goes off without a hitch."),
				new TableRow(20, TableRow.NOVALUE, "Roll twice, ignoring results of 20."),
			});

				public static readonly Table framing_events = new Table("Framing Events", "Event", Data.Rolls_String.d100, "", Data.Titles.DMG, 79, new TableRow[]{
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

				public static readonly Table moral_quandaries = new Table("Moral Quandaries", "Quandary", Data.Rolls_String.d20, "", Data.Titles.DMG, 79, new TableRow[]{
				new TableRow(1, 3, "Ally quandary"),
				new TableRow(4, 6, "Friend quandary"),
				new TableRow(7, 12, "Honor quandary"),
				new TableRow(13, 16, "Rescue quandary"),
				new TableRow(17, 20, "Respect quandary"),
			});

				public static readonly Table moral_quandaries_descriptions = new Table("Moral Quandaries - Descriptions", " Quandary", Data.Rolls_String.d20, "", Data.Titles.DMG, 80, new TableRow[]{
				new TableRow(1, 3, "Ally Quandary. The adventurers have a better chance of achieving their goal with the help of two individuals whose expertise is all but essential. However, these two NPCs hate each other and refuse to work together even if the fate of the world hangs in the balance. The adventurers must choose the NPC that is most likely to help them accomplish their goal."),
				new TableRow(4, 6, "Friend Quandary. An NPC that one or more of the characters cares about makes an impossible demand on the characters. A love interest might demand that a character turn away from a dangerous quest. A dear friend might plead with the characters to spare the villain's life, to prove that they are better than the villain. A weak NPC might beg for a chance to win favor from the characters by undertaking a dangerous but essential mission."),
				new TableRow(7, 12, "Honor Quandary. A character is forced to choose between victory and a personal oath or code of honor. A paladin who has sworn the Oath of Virtue might realize that the clearest path to success lies in deceit and subterfuge. A loyal cleric might be tempted to disobey the orders of his or her faith. If you present this quandary, be sure to provide an opportunity for a character to atone for violating his or her oath."),
				new TableRow(13, 16, "Rescue Quandary. The adventurers must choose between catching or hurting the villain and saving innocent lives. For example, the adventurers might learn that the villain is camped nearby, but they also learn that another part of the villain's forces is about to march into a village and burn it to the ground. The characters must choose between taking out the villain or protecting innocent villagers, some of whom might be friends or family members."),
				new TableRow(17, 20, "Respect Quandary. Two important allies give conflicting directions or advice to the adventurers. Perhaps the high priest counsels the characters to negotiate peace with militaristic elves in the nearby forest, while a veteran warrior urges them to prove their strength with a decisive first strike. The adventurers can't follow both courses, and whichever ally they choose, the other loses respect for them and might no longer aid them."),
			});

				public static readonly Table twists = new Table("Twists", "Twist", Data.Rolls_String.d10, "", Data.Titles.DMG, 80, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "The adventurers are racing against other creatures with the same or opposite goal."),
				new TableRow(2, TableRow.NOVALUE, "The adventurers become responsible for the safety of a noncombatant NPC."),
				new TableRow(3, TableRow.NOVALUE, "The adventurers are prohibited from killing the villain, but the villain has no compunctions about killing them."),
				new TableRow(4, TableRow.NOVALUE, "The adventurers have a time limit."),
				new TableRow(5, TableRow.NOVALUE, "The adventurers have received false or extraneous information."),
				new TableRow(6, TableRow.NOVALUE, "Completing an adventure goal fulfills a prophecy or prevents the fulfillment of a prophecy."),
				new TableRow(7, TableRow.NOVALUE, "The adventurers have two different goals, but they can complete only one."),
				new TableRow(8, TableRow.NOVALUE, "Completing the goal secretly helps the villain."),
				new TableRow(9, TableRow.NOVALUE, "The adventurers must cooperate with a known enemy to achieve the goal."),
				new TableRow(10, TableRow.NOVALUE, "The adventurers are under magical compulsion (such as a geas spell) to complete their goal."),
			});

				public static readonly Table side_quests = new Table("Side Quests", "Side Quest", Data.Rolls_String.d8, "", Data.Titles.DMG, 81, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Find a specific item rumored to be in the area."),
				new TableRow(2, TableRow.NOVALUE, "Retrieve a stolen item in the villain's possession"),
				new TableRow(3, TableRow.NOVALUE, "Receive information from an NPC in the area."),
				new TableRow(4, TableRow.NOVALUE, "Rescue a captive."),
				new TableRow(5, TableRow.NOVALUE, "Discover the fate of a missing NPC."),
				new TableRow(6, TableRow.NOVALUE, "Slay a specific monster."),
				new TableRow(7, TableRow.NOVALUE, "Discover the nature and origin of a strange phenomenon in the area."),
				new TableRow(8, TableRow.NOVALUE, "Secure the aid of a character or creature in the area."),
			});

				public static string getDungeonGoal()
				{
					int num = roll(1, dungeon_goals.MaxRoll);

					if (num == 20)
					{
						num = roll(1, dungeon_goals.MaxRoll - 1);
						int num2 = roll(1, dungeon_goals.MaxRoll - 1);

						while (num2 == num)
						{
							num2 = roll(1, dungeon_goals.MaxRoll - 1);
						}

						// need to chop off the "." at the end of the first part
						string fp = dungeon_goals[num];

						return fp.Substring(0, fp.Length - 1) + " and " + lowerFirstLetter(dungeon_goals[num2]);
					}

					return dungeon_goals[num];
				}

				public static string getWildernessGoal()
				{
					int num = roll(1, wilderness_goals.MaxRoll);

					if (num == 1)
					{
						string dg = lowerFirstLetter(getDungeonGoal());

						return "Locate a dungeon or other site of interest to " + dg;
					}

					if (num == 20)
					{
						num = roll(1, wilderness_goals.MaxRoll - 1);

						string[] strs = { "", "" };

						while (strs[0] == strs[1])
						{
							for (int i = 0; i < 2; i++)
							{
								num = roll(1, wilderness_goals.MaxRoll - 1);

								if (num == 1)
								{
									strs[i] = lowerFirstLetter(getDungeonGoal());
									strs[i] = "Locate a dungeon or other site of interest to " + strs[i];
								}
								else
								{
									strs[i] = wilderness_goals[num];
								}
							}
						}

						return strs[0].Substring(0, strs[0].Length - 1) + ", and " + lowerFirstLetter(strs[1]);
					}

					return wilderness_goals[num];
				}

				public static string getEventBasedGoals()
				{
					int num = roll(1, dungeon_goals.MaxRoll);

					if (num == 20)
					{
						num = roll(1, dungeon_goals.MaxRoll - 1);
						int num2 = roll(1, dungeon_goals.MaxRoll - 1);

						while (num2 == num)
						{
							num2 = roll(1, dungeon_goals.MaxRoll - 1);
						}

						string fp = event_based_goals[num];

						return fp.Substring(0, fp.Length - 1) + " and " + lowerFirstLetter(event_based_goals[num2]);
					}

					return event_based_goals[num];
				}

				public static string getFramingEvents()
				{
					int num = roll(1, framing_events.MaxRoll);

					// if num == 99 or 100
					if (num > framing_events.MaxRoll - 2)
					{
						num = roll(1, framing_events.MaxRoll - 2);

						int num2 = roll(1, framing_events.MaxRoll - 2);

						while (num2 == num)
						{
							num2 = roll(1, framing_events.MaxRoll - 2);
						}

						string fp = framing_events[num];

						return fp.Substring(0, fp.Length - 1) + ", and " + lowerFirstLetter(framing_events[num2]);
					}

					return framing_events[num];
				}
			}

			// Chapter 4
			public static class NPC
			{
				public static readonly Table npc_appearance = new Table("NPC Appearance", "Feature", Data.Rolls_String.d20, "", Data.Titles.DMG, 89, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Distinctive jewelry: earrings, necklace, circlet, bracelets"),
				new TableRow(2, TableRow.NOVALUE, "Piercings"),
				new TableRow(3, TableRow.NOVALUE, "Flamboyant or outlandish clothes"),
				new TableRow(4, TableRow.NOVALUE, "Formal, clean clothes"),
				new TableRow(5, TableRow.NOVALUE, "Ragged, dirty clothes"),
				new TableRow(6, TableRow.NOVALUE, "Pronounced scar"),
				new TableRow(7, TableRow.NOVALUE, "Missing teeth"),
				new TableRow(8, TableRow.NOVALUE, "Missing fingers"),
				new TableRow(9, TableRow.NOVALUE, "Unusual eye color (or two different colors)"),
				new TableRow(10, TableRow.NOVALUE, "Tattoos"),
				new TableRow(11, TableRow.NOVALUE, "Birthmark"),
				new TableRow(12, TableRow.NOVALUE, "Unusual skin color"),
				new TableRow(13, TableRow.NOVALUE, "Bald"),
				new TableRow(14, TableRow.NOVALUE, "Braided beard or hair"),
				new TableRow(15, TableRow.NOVALUE, "Unusual hair color"),
				new TableRow(16, TableRow.NOVALUE, "Nervous eye twitch"),
				new TableRow(17, TableRow.NOVALUE, "Distinctive nose"),
				new TableRow(18, TableRow.NOVALUE, "Distinctive posture (crooked or rigid)"),
				new TableRow(19, TableRow.NOVALUE, "Exceptionally beautiful"),
				new TableRow(20, TableRow.NOVALUE, "Exceptionally ugly"),
			});

				public static readonly Table npc_high_abilities = new Table("NPC High Abilities", "High Ability", Data.Rolls_String.d6, "", Data.Titles.DMG, 89, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Strength - powerful, brawny, strong as an ox"),
				new TableRow(2, TableRow.NOVALUE, "Dexterity - lithe, agile, graceful"),
				new TableRow(3, TableRow.NOVALUE, "Constitution - hardy, hale, healthy"),
				new TableRow(4, TableRow.NOVALUE, "Intelligence - studious, learned, inquisitive"),
				new TableRow(5, TableRow.NOVALUE, "Wisdom - perceptive, spiritual, insightful"),
				new TableRow(6, TableRow.NOVALUE, "Charisma - persuasive, forceful, born leader"),
			});

				public static readonly Table npc_low_abilities = new Table("NPC Low Abilities", "Low Ability", Data.Rolls_String.d6, "", Data.Titles.DMG, 89, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Strength - feeble, scrawny"),
				new TableRow(2, TableRow.NOVALUE, "Dexterity - clumsy, fumbling"),
				new TableRow(3, TableRow.NOVALUE, "Constitution - sickly, pale"),
				new TableRow(4, TableRow.NOVALUE, "Intelligence - dim-witted, slow"),
				new TableRow(5, TableRow.NOVALUE, "Wisdom - oblivious, absentminded"),
				new TableRow(6, TableRow.NOVALUE, "Charisma - dull, boring"),
			});

				public static readonly Table npc_talents = new Table("NPC Talents", "Talent", Data.Rolls_String.d20, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Plays a musical instrument"),
				new TableRow(2, TableRow.NOVALUE, "Speaks several languages fluently"),
				new TableRow(3, TableRow.NOVALUE, "Unbelievably lucky"),
				new TableRow(4, TableRow.NOVALUE, "Perfect memory"),
				new TableRow(5, TableRow.NOVALUE, "Great with animals"),
				new TableRow(6, TableRow.NOVALUE, "Great with children"),
				new TableRow(7, TableRow.NOVALUE, "Great at solving puzzles"),
				new TableRow(8, TableRow.NOVALUE, "Great at one game"),
				new TableRow(9, TableRow.NOVALUE, "Great at impersonations"),
				new TableRow(10, TableRow.NOVALUE, "Draws beautifully"),
				new TableRow(11, TableRow.NOVALUE, "Paints beautifully"),
				new TableRow(12, TableRow.NOVALUE, "Sings beautifully"),
				new TableRow(13, TableRow.NOVALUE, "Drinks everyone under the table"),
				new TableRow(14, TableRow.NOVALUE, "Expert carpenter"),
				new TableRow(15, TableRow.NOVALUE, "Expert cook"),
				new TableRow(16, TableRow.NOVALUE, "Expert dart thrower and rock skipper"),
				new TableRow(17, TableRow.NOVALUE, "Expert juggler"),
				new TableRow(18, TableRow.NOVALUE, "Skilled actor and master of disguise"),
				new TableRow(19, TableRow.NOVALUE, "Skilled dancer"),
				new TableRow(20, TableRow.NOVALUE, "Knows thieves' cant"),
			});

				public static readonly Table npc_mannerisms = new Table("NPC Mannerisms", "Mannerism", Data.Rolls_String.d20, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Prone to singing, whistling, or humming quietly"),
				new TableRow(2, TableRow.NOVALUE, "Speaks in rhyme or some other peculiar way"),
				new TableRow(3, TableRow.NOVALUE, "Particularly low or high voice"),
				new TableRow(4, TableRow.NOVALUE, "Slurs words, lisps, or stutters"),
				new TableRow(5, TableRow.NOVALUE, "Enunciates overly clearly"),
				new TableRow(6, TableRow.NOVALUE, "Speaks loudly"),
				new TableRow(7, TableRow.NOVALUE, "Whispers"),
				new TableRow(8, TableRow.NOVALUE, "Uses flowery speech or long words"),
				new TableRow(9, TableRow.NOVALUE, "Frequently uses the wrong word"),
				new TableRow(10, TableRow.NOVALUE, "Uses colorful oaths and exclamations"),
				new TableRow(11, TableRow.NOVALUE, "Makes constant jokes or puns"),
				new TableRow(12, TableRow.NOVALUE, "Prone to predictions of doom"),
				new TableRow(13, TableRow.NOVALUE, "Fidgets"),
				new TableRow(14, TableRow.NOVALUE, "Squints"),
				new TableRow(15, TableRow.NOVALUE, "Stares into the distance"),
				new TableRow(16, TableRow.NOVALUE, "Chews something"),
				new TableRow(17, TableRow.NOVALUE, "Paces"),
				new TableRow(18, TableRow.NOVALUE, "Taps fingers"),
				new TableRow(19, TableRow.NOVALUE, "Bites fingernails"),
				new TableRow(20, TableRow.NOVALUE, "Twirls hair or tugs beard"),
			});

				public static readonly Table npc_interaction_traits = new Table("NPC Interactions Traits", "Trait", Data.Rolls_String.d12, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Argumentative"),
				new TableRow(2, TableRow.NOVALUE, "Arrogant"),
				new TableRow(3, TableRow.NOVALUE, "Blustering"),
				new TableRow(4, TableRow.NOVALUE, "Rude"),
				new TableRow(5, TableRow.NOVALUE, "Curious"),
				new TableRow(6, TableRow.NOVALUE, "Friendly"),
				new TableRow(7, TableRow.NOVALUE, "Honest"),
				new TableRow(8, TableRow.NOVALUE, "Hot tempered"),
				new TableRow(9, TableRow.NOVALUE, "Irritable"),
				new TableRow(10, TableRow.NOVALUE, "Ponderous"),
				new TableRow(11, TableRow.NOVALUE, "Quiet"),
				new TableRow(12, TableRow.NOVALUE, "Suspicious"),
			});

				public static readonly Table npc_ideals_good = new Table("NPC Ideals Good", "Good Ideal", Data.Rolls_String.d6, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Beauty"),
				new TableRow(2, TableRow.NOVALUE, "Charity"),
				new TableRow(3, TableRow.NOVALUE, "Greater good"),
				new TableRow(4, TableRow.NOVALUE, "Life"),
				new TableRow(5, TableRow.NOVALUE, "Respect"),
				new TableRow(6, TableRow.NOVALUE, "Self-sacrifice"),
			});

				public static readonly Table npc_ideals_evil = new Table("NPC Ideals Evil", "Evil Ideal", Data.Rolls_String.d6, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Domination"),
				new TableRow(2, TableRow.NOVALUE, "Greed"),
				new TableRow(3, TableRow.NOVALUE, "Might"),
				new TableRow(4, TableRow.NOVALUE, "Pain"),
				new TableRow(5, TableRow.NOVALUE, "Retribution"),
				new TableRow(6, TableRow.NOVALUE, "Slaughter"),
			});

				public static readonly Table npc_ideals_lawful = new Table("NPC Ideals Lawful", "Lawful Ideal", Data.Rolls_String.d6, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Community"),
				new TableRow(2, TableRow.NOVALUE, "Fairness"),
				new TableRow(3, TableRow.NOVALUE, "Honor"),
				new TableRow(4, TableRow.NOVALUE, "Logic"),
				new TableRow(5, TableRow.NOVALUE, "Responsibility"),
				new TableRow(6, TableRow.NOVALUE, "Tradition"),
			});

				public static readonly Table npc_ideals_chaotic = new Table("NPC Ideals Chaotic", "Chaotic Ideal", Data.Rolls_String.d6, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Change"),
				new TableRow(2, TableRow.NOVALUE, "Creativity"),
				new TableRow(3, TableRow.NOVALUE, "Freedom"),
				new TableRow(4, TableRow.NOVALUE, "Independence"),
				new TableRow(5, TableRow.NOVALUE, "No limits"),
				new TableRow(6, TableRow.NOVALUE, "Whimsy"),
			});

				public static readonly Table npc_ideals_neutral = new Table("NPC Ideals Neutral", "Neutral Ideal", Data.Rolls_String.d6, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Balance"),
				new TableRow(2, TableRow.NOVALUE, "Knowledge"),
				new TableRow(3, TableRow.NOVALUE, "Live and let live"),
				new TableRow(4, TableRow.NOVALUE, "Moderation"),
				new TableRow(5, TableRow.NOVALUE, "Neutrality"),
				new TableRow(6, TableRow.NOVALUE, "People"),
			});

				public static readonly Table npc_ideals_other = new Table("NPC Ideals Other", "Other Ideal", Data.Rolls_String.d6, "", Data.Titles.DMG, 90, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Aspiration"),
				new TableRow(2, TableRow.NOVALUE, "Discovery"),
				new TableRow(3, TableRow.NOVALUE, "Glory"),
				new TableRow(4, TableRow.NOVALUE, "Nation"),
				new TableRow(5, TableRow.NOVALUE, "Redemption"),
				new TableRow(6, TableRow.NOVALUE, "Self-knowledge"),
			});

				public static readonly Table npc_bonds = new Table("NPC Bonds", "Bond", Data.Rolls_String.d10, "", Data.Titles.DMG, 91, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Dedicated to fulfilling a personal life goal"),
				new TableRow(2, TableRow.NOVALUE, "Protective of close family members"),
				new TableRow(3, TableRow.NOVALUE, "Protective of colleagues or compatriots"),
				new TableRow(4, TableRow.NOVALUE, "Loyal ot a benefactor, patron, or employer"),
				new TableRow(5, TableRow.NOVALUE, "Captivated by a romantic interest"),
				new TableRow(6, TableRow.NOVALUE, "Drawn to a special place"),
				new TableRow(7, TableRow.NOVALUE, "Protective of a sentimental keepsake"),
				new TableRow(8, TableRow.NOVALUE, "Protective of a valuable possession"),
				new TableRow(9, TableRow.NOVALUE, "Out for revenge"),
			});

				public static readonly Table npc_flaws_and_secrets = new Table("NPC Flaws and Secrets", "Flaw or Secret", Data.Rolls_String.d12, "", Data.Titles.DMG, 91, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Forbidden love or susceptibility to romance"),
				new TableRow(2, TableRow.NOVALUE, "Enjoys decadent pleasures"),
				new TableRow(3, TableRow.NOVALUE, "Arrogance"),
				new TableRow(4, TableRow.NOVALUE, "Envies another creature's possessions or station"),
				new TableRow(5, TableRow.NOVALUE, "Overpowering greed"),
				new TableRow(6, TableRow.NOVALUE, "Prone to rage"),
				new TableRow(7, TableRow.NOVALUE, "Has a powerful enemy"),
				new TableRow(8, TableRow.NOVALUE, "Specific phobia"),
				new TableRow(9, TableRow.NOVALUE, "Shameful or scandalous history"),
				new TableRow(10, TableRow.NOVALUE, "Secret crime or misdeed"),
				new TableRow(11, TableRow.NOVALUE, "Possession of forbidden lore"),
				new TableRow(12, TableRow.NOVALUE, "Foolhardy bravery"),
			});

				public static readonly Table villains_scheme_objective = new Table("Villains Scheme", "Objective and Scheme", Data.Rolls_String.d8, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Immortality"),
				new TableRow(2, TableRow.NOVALUE, "Influence"),
				new TableRow(3, TableRow.NOVALUE, "Magic"),
				new TableRow(4, TableRow.NOVALUE, "Mayhem"),
				new TableRow(5, TableRow.NOVALUE, "Passion"),
				new TableRow(6, TableRow.NOVALUE, "Power"),
				new TableRow(7, TableRow.NOVALUE, "Revenge"),
				new TableRow(8, TableRow.NOVALUE, "Wealth"),
			});

				public static readonly Table villains_scheme_immortality = new Table("Villains Scheme - Immortality", "Immortality", Data.Rolls_String.d4, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Acquire a legendary item to prolog life"),
				new TableRow(2, TableRow.NOVALUE, "Ascend to godhood"),
				new TableRow(3, TableRow.NOVALUE, "Become undead or obtain a younger body"),
				new TableRow(4, TableRow.NOVALUE, "Steal a planar creature's essence"),
			});

				public static readonly Table villains_scheme_influence = new Table("Villains Scheme - Influence", "Influence", Data.Rolls_String.d4, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Seize a position of power or title"),
				new TableRow(2, TableRow.NOVALUE, "Win a contest or tournament"),
				new TableRow(3, TableRow.NOVALUE, "Win favor with a powerful individual"),
				new TableRow(4, TableRow.NOVALUE, "Place a pawn in a position of power"),
			});

				public static readonly Table villains_scheme_magic = new Table("Villains Scheme - Magic", "Magic", Data.Rolls_String.d6, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Obtain an ancient artifact"),
				new TableRow(2, TableRow.NOVALUE, "Build a construct or magical device"),
				new TableRow(3, TableRow.NOVALUE, "Carry out a deity's wishes"),
				new TableRow(4, TableRow.NOVALUE, "Offer sacrifices to a deity"),
				new TableRow(5, TableRow.NOVALUE, "Contact a lost deity or power"),
				new TableRow(6, TableRow.NOVALUE, "Open a gate to another world"),
			});

				public static readonly Table villains_scheme_mayhem = new Table("Villains Scheme - Mayhem", "Mayhem", Data.Rolls_String.d8, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Fulfill an apocalyptic prophecy"),
				new TableRow(2, TableRow.NOVALUE, "Enact the vengeful will of a god or patron"),
				new TableRow(3, TableRow.NOVALUE, "Spread a vile contagion"),
				new TableRow(4, TableRow.NOVALUE, "Overthrow a government"),
				new TableRow(5, TableRow.NOVALUE, "Trigger a natrual disaster"),
				new TableRow(6, TableRow.NOVALUE, "Utterly destroy a bloodline or clan"),
			});

				public static readonly Table villains_scheme_passion = new Table("Villains Scheme - Passion", "Passion", Data.Rolls_String.d4, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Prolong the life of a loved one"),
				new TableRow(2, TableRow.NOVALUE, "Prove worthy of another person's love"),
				new TableRow(3, TableRow.NOVALUE, "Raise or restore a dead loved one"),
				new TableRow(4, TableRow.NOVALUE, "Destroy rivals for another person's affection"),
			});

				public static readonly Table villains_scheme_power = new Table("Villains Scheme - Power", "Power", Data.Rolls_String.d4, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Conquer a region or incite a rebellion"),
				new TableRow(2, TableRow.NOVALUE, "Seize control of an army"),
				new TableRow(3, TableRow.NOVALUE, "Become the power behind the throne"),
				new TableRow(4, TableRow.NOVALUE, "Gain the favor of a ruler"),
			});

				public static readonly Table villains_scheme_revenge = new Table("Villains Scheme - Revenge", "Revenge", Data.Rolls_String.d4, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Avenge a past humiliation or insult"),
				new TableRow(2, TableRow.NOVALUE, "Avenge a past imprisonment or injury"),
				new TableRow(3, TableRow.NOVALUE, "Avenge the death of a loved one"),
				new TableRow(4, TableRow.NOVALUE, "Retrieve stolen property and punish the thief"),
			});

				public static readonly Table villains_scheme_wealth = new Table("Villains Scheme - Wealth", "Wealth", Data.Rolls_String.d4, "", Data.Titles.DMG, 94, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Control natural resources or trade"),
				new TableRow(2, TableRow.NOVALUE, "Marry into wealth"),
				new TableRow(3, TableRow.NOVALUE, "Plunder ancient ruins"),
				new TableRow(4, TableRow.NOVALUE, "Steal land, goods, or money"),
			});

				public static readonly Table villains_methods = new Table("Villains Methods", "Methods", Data.Rolls_String.d20, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Agricultural devastation"),
				new TableRow(2, TableRow.NOVALUE, "Assault or beatings"),
				new TableRow(3, TableRow.NOVALUE, "Bounty hunting or assassination"),
				new TableRow(4, TableRow.NOVALUE, "Captivity or coercion"),
				new TableRow(5, TableRow.NOVALUE, "Confidence scams"),
				new TableRow(6, TableRow.NOVALUE, "Defamation"),
				new TableRow(7, TableRow.NOVALUE, "Dueling"),
				new TableRow(8, TableRow.NOVALUE, "Execution"),
				new TableRow(9, TableRow.NOVALUE, "Impersonation or disguise"),
				new TableRow(10, TableRow.NOVALUE, "Lying or perjury"),
				new TableRow(11, TableRow.NOVALUE, "Magical mayhem"),
				new TableRow(12, TableRow.NOVALUE, "Murder"),
				new TableRow(13, TableRow.NOVALUE, "Neglect"),
				new TableRow(14, TableRow.NOVALUE, "Politics"),
				new TableRow(15, TableRow.NOVALUE, "Religion"),
				new TableRow(16, TableRow.NOVALUE, "Stalking"),
				new TableRow(17, TableRow.NOVALUE, "Theft or Property Crime"),
				new TableRow(18, TableRow.NOVALUE, "Torture"),
				new TableRow(19, TableRow.NOVALUE, "Vice"),
				new TableRow(20, TableRow.NOVALUE, "Warfare"),
			});

				public static readonly Table villains_methods_agricultural_devastation = new Table("Villains Methods - Agricultural Devastation", "Agricultural Devastation", Data.Rolls_String.d4, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Blight"),
				new TableRow(2, TableRow.NOVALUE, "Crop failure"),
				new TableRow(3, TableRow.NOVALUE, "Drought"),
				new TableRow(4, TableRow.NOVALUE, "Famine"),
			});

				public static readonly Table villains_methods_assault_or_beatings = new Table("Villains Methods - Assault or Beatings", "Assault or Beatings", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Assault or beatings"),
			});

				public static readonly Table villains_methods_bounty_hunting_or_assassination = new Table("Villains Methods - Bounty Hunting or Assassination", "Bounty Hunting or Assassination", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Bounty hunting or assassination"),
			});

				public static readonly Table villains_methods_captivity_or_coercion = new Table("Villains Methods - Captivity or Coercion", "Captivity or Coercion", Data.Rolls_String.d10, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Bribery"),
				new TableRow(2, TableRow.NOVALUE, "Enticement"),
				new TableRow(3, TableRow.NOVALUE, "Eviction"),
				new TableRow(4, TableRow.NOVALUE, "Imprisonment"),
				new TableRow(5, TableRow.NOVALUE, "Kidnapping"),
				new TableRow(6, TableRow.NOVALUE, "Legal intimidation"),
				new TableRow(7, TableRow.NOVALUE, "Press gangs"),
				new TableRow(8, TableRow.NOVALUE, "Shackling"),
				new TableRow(9, TableRow.NOVALUE, "Slavery"),
				new TableRow(10, TableRow.NOVALUE, "Threats or harassment"),
			});

				public static readonly Table villains_methods_confidence_scams = new Table("Villains Methods - Confidence Scams", "Confidence Scams", Data.Rolls_String.d6, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Breach of contract"),
				new TableRow(2, TableRow.NOVALUE, "Cheating"),
				new TableRow(3, TableRow.NOVALUE, "Fast talking"),
				new TableRow(4, TableRow.NOVALUE, "Fine print"),
				new TableRow(5, TableRow.NOVALUE, "Fraud or swindling"),
				new TableRow(6, TableRow.NOVALUE, "Quackery or tricks"),
			});

				public static readonly Table villains_methods_defamation = new Table("Villains Methods - Defamation", "Defamation", Data.Rolls_String.d4, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Framing"),
				new TableRow(2, TableRow.NOVALUE, "Gossipping or slander"),
				new TableRow(3, TableRow.NOVALUE, "Humiliation"),
				new TableRow(4, TableRow.NOVALUE, "Libel or insults"),
			});

				public static readonly Table villains_methods_dueling = new Table("Villains Methods - Dueling", "Dueling", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Dueling"),
			});

				public static readonly Table villains_methods_execution = new Table("Villains Methods - Execution", "Execution", Data.Rolls_String.d8, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Beheading"),
				new TableRow(2, TableRow.NOVALUE, "Burning at the stake"),
				new TableRow(3, TableRow.NOVALUE, "Burying alive"),
				new TableRow(4, TableRow.NOVALUE, "Crucifixion"),
				new TableRow(5, TableRow.NOVALUE, "Drawing and quartering"),
				new TableRow(6, TableRow.NOVALUE, "Hanging"),
				new TableRow(7, TableRow.NOVALUE, "Impalement"),
				new TableRow(8, TableRow.NOVALUE, "Sacrifice (living)"),
			});

				public static readonly Table villains_methods_impersonation_or_disguise = new Table("Villains Methods - Impersonation or Disguise", "Impersonation or Disguise", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Impersonation or disguise"),
			});

				public static readonly Table villains_methods_lying_or_perjury = new Table("Villains Methods - Lying or Perjury", "Lying or Perjury", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Lying or perjury"),
			});

				public static readonly Table villains_methods_magical_mayhem = new Table("Villains Methods - Magical Mayhem", "Magical Mayhem", Data.Rolls_String.d8, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Hauntings"),
				new TableRow(2, TableRow.NOVALUE, "Illusions"),
				new TableRow(3, TableRow.NOVALUE, "Infernal bargains"),
				new TableRow(4, TableRow.NOVALUE, "Mind control"),
				new TableRow(5, TableRow.NOVALUE, "Petrification"),
				new TableRow(6, TableRow.NOVALUE, "Raising or animating the dead"),
				new TableRow(7, TableRow.NOVALUE, "Summoning monsters"),
				new TableRow(8, TableRow.NOVALUE, "Weather control"),
			});

				public static readonly Table villains_methods_murder = new Table("Villains Methods - Murder", "Murder", Data.Rolls_String.d10, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Assassination"),
				new TableRow(2, TableRow.NOVALUE, "Cannibalism"),
				new TableRow(3, TableRow.NOVALUE, "Dismemberment"),
				new TableRow(4, TableRow.NOVALUE, "Drowning"),
				new TableRow(5, TableRow.NOVALUE, "Electrocution"),
				new TableRow(6, TableRow.NOVALUE, "Euthanasia (involuntary)"),
				new TableRow(7, TableRow.NOVALUE, "Disease"),
				new TableRow(8, TableRow.NOVALUE, "Poisoning"),
				new TableRow(9, TableRow.NOVALUE, "Stabbing"),
				new TableRow(10, TableRow.NOVALUE, "Strangulation or suffocation"),
			});

				public static readonly Table villains_methods_neglect = new Table("Villains Methods - Neglect", "Neglet", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Neglect"),
			});

				public static readonly Table villains_methods_politics = new Table("Villains Methods - Politics", "Politics", Data.Rolls_String.d6, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Betrayal or treason"),
				new TableRow(2, TableRow.NOVALUE, "Conspiracy"),
				new TableRow(3, TableRow.NOVALUE, "Espionage or spying"),
				new TableRow(4, TableRow.NOVALUE, "Genocide"),
				new TableRow(5, TableRow.NOVALUE, "Oppression"),
				new TableRow(6, TableRow.NOVALUE, "Raising taxes"),
			});

				public static readonly Table villains_methods_religion = new Table("Villains Methods - Religion", "Religion", Data.Rolls_String.d4, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Curses"),
				new TableRow(2, TableRow.NOVALUE, "Desecration"),
				new TableRow(3, TableRow.NOVALUE, "False gods"),
				new TableRow(4, TableRow.NOVALUE, "Heresy or cults"),
			});

				public static readonly Table villains_methods_stalking = new Table("Villains Methods - Stalking", "Stalking", "-", "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Stalking"),
			});

				public static readonly Table villains_methods_theft_or_property_crime = new Table("Villains Methods - Theft or Property Crime", "Theft or Property Crime", Data.Rolls_String.d10, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Arson"),
				new TableRow(2, TableRow.NOVALUE, "Blackmail or extortion"),
				new TableRow(3, TableRow.NOVALUE, "Burglary"),
				new TableRow(4, TableRow.NOVALUE, "Counterfeiting"),
				new TableRow(5, TableRow.NOVALUE, "Highway robbery"),
				new TableRow(6, TableRow.NOVALUE, "Looting"),
				new TableRow(7, TableRow.NOVALUE, "Mugging"),
				new TableRow(8, TableRow.NOVALUE, "Poaching"),
				new TableRow(9, TableRow.NOVALUE, "Seizing property"),
				new TableRow(10, TableRow.NOVALUE, "Smuggling"),
			});

				public static readonly Table villains_methods_torture = new Table("Villains Methods - Torture", "Torture", Data.Rolls_String.d6, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Acid"),
				new TableRow(2, TableRow.NOVALUE, "Blinding"),
				new TableRow(3, TableRow.NOVALUE, "Branding"),
				new TableRow(4, TableRow.NOVALUE, "Racking"),
				new TableRow(5, TableRow.NOVALUE, "Thumbscrews"),
				new TableRow(6, TableRow.NOVALUE, "Whipping"),
			});

				public static readonly Table villains_methods_vice = new Table("Villains Methods - Vice", "Vice", Data.Rolls_String.d4, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Adultery"),
				new TableRow(2, TableRow.NOVALUE, "Drugs or alcohol"),
				new TableRow(3, TableRow.NOVALUE, "Gambling"),
				new TableRow(4, TableRow.NOVALUE, "Seduction"),
			});

				public static readonly Table villains_methods_warfare = new Table("Villains Methods - Warfare", "Warfare", Data.Rolls_String.d6, "", Data.Titles.DMG, 95, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Ambush"),
				new TableRow(2, TableRow.NOVALUE, "Invasion"),
				new TableRow(3, TableRow.NOVALUE, "Massacre"),
				new TableRow(4, TableRow.NOVALUE, "Mercenaries"),
				new TableRow(5, TableRow.NOVALUE, "Rebellion"),
				new TableRow(6, TableRow.NOVALUE, "Terrorism"),
			});

				public static readonly Table villains_weakness = new Table("Villain's Weakness", "Weakness", Data.Rolls_String.d8, "", Data.Titles.DMG, 96, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "A hidden object holds the villain's soul"),
				new TableRow(2, TableRow.NOVALUE, "The villain's power is broken if the death of its true love is avenged"),
				new TableRow(3, TableRow.NOVALUE, "The villain is weakened in the presence of a particular artifact"),
				new TableRow(4, TableRow.NOVALUE, "A special weapon deals extra damage when used against the villain"),
				new TableRow(5, TableRow.NOVALUE, "The villain is destroyed if it speaks its true name"),
				new TableRow(6, TableRow.NOVALUE, "An ancient prophecy or riddle reveals how the villain can be overthrown"),
				new TableRow(7, TableRow.NOVALUE, "The villain falls when an ancient enemy forgives its past actions"),
				new TableRow(8, TableRow.NOVALUE, "The villain loses its power if a mystic bargain it struck long ago is completed"),
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

					if (ideal == -1)
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
				public static readonly Table dungeon_location = new Table("Dungeon Location", "Location", Data.Rolls_String.d100, "", Data.Titles.DMG, 99, new TableRow[]{
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

				public static readonly Table dungeon_exotic_location = new Table("Dungeon Exotic Location", "Location", Data.Rolls_String.d100, "", Data.Titles.DMG, 99, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Among the branches of a tree"),
				new TableRow(2, TableRow.NOVALUE, "Around a geyser"),
				new TableRow(3, TableRow.NOVALUE, "Behind a waterfall"),
				new TableRow(4, TableRow.NOVALUE, "Buried in an avalanche"),
				new TableRow(5, TableRow.NOVALUE, "Buried in a sandstorm"),
				new TableRow(6, TableRow.NOVALUE, "Buried in volcanic ash"),
				new TableRow(7, TableRow.NOVALUE, "Castle or structure sunken in a swamp"),
				new TableRow(8, TableRow.NOVALUE, "Castle or structure at the bottom of a sinkhole"),
				new TableRow(9, TableRow.NOVALUE, "Floating on the sea"),
				new TableRow(10, TableRow.NOVALUE, "In a meteorite"),
				new TableRow(11, TableRow.NOVALUE, "On a demiplane or in a pocket dimension"),
				new TableRow(12, TableRow.NOVALUE, "In an area devastated by a magical catastrophe"),
				new TableRow(13, TableRow.NOVALUE, "On a cloud"),
				new TableRow(14, TableRow.NOVALUE, "In the Feywild"),
				new TableRow(15, TableRow.NOVALUE, "In the Shadowfell"),
				new TableRow(16, TableRow.NOVALUE, "On an island in an underground sea"),
				new TableRow(17, TableRow.NOVALUE, "In a volcano"),
				new TableRow(18, TableRow.NOVALUE, "On the back of a Gargantuan living creature"),
				new TableRow(19, TableRow.NOVALUE, "Sealed inside a magical dome of force"),
				new TableRow(20, TableRow.NOVALUE, "Inside a Mordenkainen's magnificent mansion"),
			});

				public static readonly Table dungeon_creator = new Table("Dungeon Creator", "Creator", Data.Rolls_String.d20, "", Data.Titles.DMG, 100, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Beholder"),
				new TableRow(2, 4, "Cult or religious group"),
				new TableRow(5, 8, "Dwarves"),
				new TableRow(9, TableRow.NOVALUE, "Elves (including drow)"),
				new TableRow(10, TableRow.NOVALUE, "Giants"),
				new TableRow(11, TableRow.NOVALUE, "Hobgoblins"),
				new TableRow(12, 15, "Humans"),
				new TableRow(16, TableRow.NOVALUE, "Kuo-toa"),
				new TableRow(17, TableRow.NOVALUE, "Lich"),
				new TableRow(18, TableRow.NOVALUE, "Mind flayers"),
				new TableRow(19, TableRow.NOVALUE, "Yuan-ti"),
				new TableRow(20, TableRow.NOVALUE, "No creator (natural caverns"),
			});

				public static readonly Table cults_and_religious_groups = new Table("Cults and Religious Groups", "Cult or Religious Group", Data.Rolls_String.d20, "", Data.Titles.DMG, 100, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Demon-worshiping cult"),
				new TableRow(2, TableRow.NOVALUE, "Devil-worshiping cult"),
				new TableRow(3, 4, "Elemental Air cult"),
				new TableRow(5, 6, "Elemental Earth cult"),
				new TableRow(7, 8, "Elemental Fire cult"),
				new TableRow(9, 10, "Elemental Water cult"),
				new TableRow(11, 15, "Worshipers of an evil deity"),
				new TableRow(16, 17, "Worshipers of a good deity"),
				new TableRow(18, 20, "Worshipers of a neutral deity"),
			});

				public static readonly Table npc_alignment = new Table("NPC Alignment", "Alignment", Data.Rolls_String.d20, "", Data.Titles.DMG, 100, new TableRow[]{
				new TableRow(1, 2, "Lawful good"),
				new TableRow(3, 4, "Neutral good"),
				new TableRow(5, 6, "Chaotic good"),
				new TableRow(7, 8, "Lawful neutral"),
				new TableRow(9, 10, "Neutral"),
				new TableRow(11, TableRow.NOVALUE, "Chaotic neutral"),
				new TableRow(12, 13, "Lawful evil"),
				new TableRow(14, 15, "Neutral evil"),
				new TableRow(16, 17, "Chaotic evil"),
			});

				public static readonly Table npc_class = new Table("NPC Class", "Class", Data.Rolls_String.d20, "", Data.Titles.DMG, 101, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Barbarian"),
				new TableRow(2, TableRow.NOVALUE, "Bard"),
				new TableRow(3, 4, "Cleric"),
				new TableRow(5, TableRow.NOVALUE, "Druid"),
				new TableRow(6, 7, "Fighter"),
				new TableRow(8, TableRow.NOVALUE, "Monk"),
				new TableRow(9, TableRow.NOVALUE, "Paladin"),
				new TableRow(10, TableRow.NOVALUE, "Ranger"),
				new TableRow(11, 14, "Rogue"),
				new TableRow(15, TableRow.NOVALUE, "Sorcerer"),
				new TableRow(16, TableRow.NOVALUE, "Warlock"),
				new TableRow(17, 20, "Wizard"),
			});

				public static readonly Table dungeon_purpose = new Table("Dungeon Purpose", "Purpose", Data.Rolls_String.d20, "", Data.Titles.DMG, 101, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Death trap"),
				new TableRow(2, 5, "Lair"),
				new TableRow(6, TableRow.NOVALUE, "Maze"),
				new TableRow(7, 9, "Mine"),
				new TableRow(10, TableRow.NOVALUE, "Planar gate"),
				new TableRow(11, 14, "Stronghold"),
				new TableRow(15, 17, "Temple or shrine"),
				new TableRow(18, 19, "Tomb"),
				new TableRow(20, TableRow.NOVALUE, "Treasure vault"),
			});

				public static readonly Table dungeon_history = new Table("Dungeon History", "Key Event", Data.Rolls_String.d20, "", Data.Titles.DMG, 101, new TableRow[]{
				new TableRow(1, 3, "Abandoned by creators"),
				new TableRow(4, TableRow.NOVALUE, "Abandoned due to plague"),
				new TableRow(5, 8, "Conquered by invaders"),
				new TableRow(9, 10, "Creators destroyed by attacking raiders"),
				new TableRow(11, TableRow.NOVALUE, "Creators destroyed by discovery made within the site"),
				new TableRow(12, TableRow.NOVALUE, "Creators destroyed by internal conflict"),
				new TableRow(13, TableRow.NOVALUE, "Creators destroyed by magical catastrophe"),
				new TableRow(14, 15, "Creators destroyed by natural disaster"),
				new TableRow(16, TableRow.NOVALUE, "Location cursed by the gods and shunned"),
				new TableRow(17, 18, "Original creator still in control"),
				new TableRow(19, TableRow.NOVALUE, "Overrun by planar creatures"),
				new TableRow(20, TableRow.NOVALUE, "Site of a great miracle"),
			});

				public static readonly Table monuments = new Table("Monuments", "Monument", Data.Rolls_String.d20, "", Data.Titles.DMG, 108, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Sealed burial mound or pyramid"),
				new TableRow(2, TableRow.NOVALUE, "Plundered burial mound or pyramid"),
				new TableRow(3, TableRow.NOVALUE, "Faces carved into a mountainside or cliff"),
				new TableRow(4, TableRow.NOVALUE, "Giant statues carved out of a mountainside or cliff"),
				new TableRow(5, 6, "Intact obelisk etched with a warning, historical lore, dedication, or religious iconography"),
				new TableRow(7, 8, "Ruined or toppled obelisk"),
				new TableRow(9, 10, "Intact statue of a person or deity"),
				new TableRow(11, 13, "Ruined or toppled statue of a person or deity"),
				new TableRow(14, TableRow.NOVALUE, "Great stone wall, intact, with tower fortifications spaced at one-mile intervals"),
				new TableRow(15, TableRow.NOVALUE, "Great stone wall in ruins"),
				new TableRow(16, TableRow.NOVALUE, "Great stone arch"),
				new TableRow(17, TableRow.NOVALUE, "Fountain"),
				new TableRow(18, TableRow.NOVALUE, "Intact circle of standing stones"),
				new TableRow(19, TableRow.NOVALUE, "Ruined or toppled circle of standing stones"),
				new TableRow(20, TableRow.NOVALUE, "Totem pole"),
			});

				public static readonly Table weird_locales = new Table("Weird Locales", "Locale", Data.Rolls_String.d20, "", Data.Titles.DMG, 109, new TableRow[]{
				new TableRow(1, 2, "Dead magic zone (similar to an antimagic field)"),
				new TableRow(3, TableRow.NOVALUE, "Wild magic zone (roll on the Wild Magic Surge table in the Player's Handbook whenever a spell is cast within the zone)"),
				new TableRow(4, TableRow.NOVALUE, "Boulder carved with talking faces"),
				new TableRow(5, TableRow.NOVALUE, "Crystal cave that mystically answers questions"),
				new TableRow(6, TableRow.NOVALUE, "Ancient tree containing a trapped spirit"),
				new TableRow(7, 8, "Battlefield where lingering fog occasionally assumes humanoid forms"),
				new TableRow(9, 10, "Permanent portal to another plane of existence"),
				new TableRow(11, TableRow.NOVALUE, "Wishing well"),
				new TableRow(12, TableRow.NOVALUE, "Giant crystal shard protruding from the ground"),
				new TableRow(13, TableRow.NOVALUE, "Wrecked ship, which might be nowhere near water"),
				new TableRow(14, 15, "Haunted hill or barrow mound"),
				new TableRow(16, TableRow.NOVALUE, "River ferry guided by a skeletal captain"),
				new TableRow(17, TableRow.NOVALUE, "Field of petrified soldiers or other creatures"),
				new TableRow(18, TableRow.NOVALUE, "Forest of petrified or awakened trees"),
				new TableRow(19, TableRow.NOVALUE, "Canyon containing a dragons' graveyard"),
				new TableRow(20, TableRow.NOVALUE, "Floating earth mote with a tower on it"),
			});

				public static readonly Table weather_temperature = new Table("Weather Temperature", "Temperature", Data.Rolls_String.d20, "", Data.Titles.DMG, 109, new TableRow[]{
				new TableRow(1, 14, "Normal for the season"),
				new TableRow(15, 17, "1d4 x 10 degrees Fahrenheit colder than normal"),
				new TableRow(18, 20, "1d4 x 10 degrees Fahrenheit hotter than normal"),
			});

				public static readonly Table weather_wind = new Table("Weather - Wind", "Wind", Data.Rolls_String.d20, "", Data.Titles.DMG, 109, new TableRow[]{
				new TableRow(1, 12, "None"),
				new TableRow(13, 17, "Light"),
				new TableRow(18, 20, "Strong"),
			});

				public static readonly Table weather_precipitation = new Table("Weather - Precipitation", "Precipitation", Data.Rolls_String.d20, "", Data.Titles.DMG, 109, new TableRow[]{
				new TableRow(1, 12, "None"),
				new TableRow(13, 17, "Light rain or light snowfall"),
				new TableRow(18, 20, "Heavy rain or heavy snowfall"),
			});

				public static readonly Table race_relations = new Table("Race Relations", "Result", Data.Rolls_String.d20, "", Data.Titles.DMG, 112, new TableRow[]{
				new TableRow(1, 10, "Harmony"),
				new TableRow(11, 14, "Tension or rivalry"),
				new TableRow(15, 16, "Racial majority are conquerers"),
				new TableRow(17, TableRow.NOVALUE, "Racial minority are rulers"),
				new TableRow(18, TableRow.NOVALUE, "Racial minority are refugees"),
				new TableRow(19, TableRow.NOVALUE, "Racial majority oppresses minority"),
				new TableRow(20, TableRow.NOVALUE, "Racial minority oppresses majority"),
			});

				public static readonly Table rulers_status = new Table("Ruler's Status", "Ruler", Data.Rolls_String.d20, "", Data.Titles.DMG, 112, new TableRow[]{
				new TableRow(1, 5, "Respected, fair, and just"),
				new TableRow(6, 8, "Feared tyrant"),
				new TableRow(9, TableRow.NOVALUE, "Weakling manipulated by others"),
				new TableRow(10, TableRow.NOVALUE, "Illegitimate ruler, simmering civial war"),
				new TableRow(11, TableRow.NOVALUE, "Ruled or controlled by a powerful monster"),
				new TableRow(12, TableRow.NOVALUE, "Mysterious, anonymous cabal"),
				new TableRow(13, TableRow.NOVALUE, "Contested leadership, open fighting"),
				new TableRow(14, TableRow.NOVALUE, "Cabal seized power openly"),
				new TableRow(15, TableRow.NOVALUE, "Doltish lout"),
				new TableRow(16, TableRow.NOVALUE, "On deathbed, claimants compete for power"),
				new TableRow(17, 18, "Iron-willed but respected"),
				new TableRow(19, 20, "Religious leader"),
			});

				public static readonly Table notable_traits = new Table("Notable Traits", "Trait", Data.Rolls_String.d20, "", Data.Titles.DMG, 112, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Canals in place of streets"),
				new TableRow(2, TableRow.NOVALUE, "Massive statue or monument"),
				new TableRow(3, TableRow.NOVALUE, "Grand temple"),
				new TableRow(4, TableRow.NOVALUE, "Large fortress"),
				new TableRow(5, TableRow.NOVALUE, "Verdant parks and orchards"),
				new TableRow(6, TableRow.NOVALUE, "River divides town"),
				new TableRow(7, TableRow.NOVALUE, "Major trade center"),
				new TableRow(8, TableRow.NOVALUE, "Headquarters of a powerful family or guild"),
				new TableRow(9, TableRow.NOVALUE, "Population mostly wealthy"),
				new TableRow(10, TableRow.NOVALUE, "Destitue, rundown"),
				new TableRow(11, TableRow.NOVALUE, "Awful smell (tanneries, open sewers)"),
				new TableRow(12, TableRow.NOVALUE, "Center of trade for one specific good"),
				new TableRow(13, TableRow.NOVALUE, "Site of many battles"),
				new TableRow(14, TableRow.NOVALUE, "Site of a mythic or magical event"),
				new TableRow(15, TableRow.NOVALUE, "Important library or archive"),
				new TableRow(16, TableRow.NOVALUE, "Worship of all gods banned"),
				new TableRow(17, TableRow.NOVALUE, "Sinister reputation"),
				new TableRow(18, TableRow.NOVALUE, "Notable library or academy"),
				new TableRow(19, TableRow.NOVALUE, "Site of important tomb or graveyard"),
				new TableRow(20, TableRow.NOVALUE, "Built atop ancient ruins"),
			});

				public static readonly Table known_for_its = new Table("Known for its", "Feature", Data.Rolls_String.d20, "", Data.Titles.DMG, 112, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Delicious cuisine"),
				new TableRow(2, TableRow.NOVALUE, "Rude people"),
				new TableRow(3, TableRow.NOVALUE, "Greedy merchants"),
				new TableRow(4, TableRow.NOVALUE, "Artists and writers"),
				new TableRow(5, TableRow.NOVALUE, "Great hero/savior"),
				new TableRow(6, TableRow.NOVALUE, "Flowers"),
				new TableRow(7, TableRow.NOVALUE, "Hordes of beggars"),
				new TableRow(8, TableRow.NOVALUE, "Tough warriors"),
				new TableRow(9, TableRow.NOVALUE, "Dark magic"),
				new TableRow(10, TableRow.NOVALUE, "Decadence"),
				new TableRow(11, TableRow.NOVALUE, "Piety"),
				new TableRow(12, TableRow.NOVALUE, "Gambling"),
				new TableRow(13, TableRow.NOVALUE, "Godlessness"),
				new TableRow(14, TableRow.NOVALUE, "Education"),
				new TableRow(15, TableRow.NOVALUE, "Wines"),
				new TableRow(16, TableRow.NOVALUE, "High fashion"),
				new TableRow(17, TableRow.NOVALUE, "Political intrigue"),
				new TableRow(18, TableRow.NOVALUE, "Powerful guilds"),
				new TableRow(19, TableRow.NOVALUE, "Strong drink"),
				new TableRow(20, TableRow.NOVALUE, "Patriotism"),
			});

				public static readonly Table current_calamity = new Table("Current Calamity", "Calamity", Data.Rolls_String.d20, "", Data.Titles.DMG, 112, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Suspected vampire infestation"),
				new TableRow(2, TableRow.NOVALUE, "New cult seeks converts"),
				new TableRow(3, TableRow.NOVALUE, "Important figure died (murder suspected)"),
				new TableRow(4, TableRow.NOVALUE, "War between rival thieves' guilds"),
				new TableRow(5, 6, "Plague or famine (sparks riots)"),
				new TableRow(7, TableRow.NOVALUE, "Corrupt officials"),
				new TableRow(8, 9, "Marauding monsters"),
				new TableRow(10, TableRow.NOVALUE, "Powerful wizard has moved into town"),
				new TableRow(11, TableRow.NOVALUE, "Economic depression (trade disrupted)"),
				new TableRow(12, TableRow.NOVALUE, "Flooding"),
				new TableRow(13, TableRow.NOVALUE, "Undead stirring in cemeteries"),
				new TableRow(14, TableRow.NOVALUE, "Prophecy of doom"),
				new TableRow(15, TableRow.NOVALUE, "Brink of war"),
				new TableRow(16, TableRow.NOVALUE, "Internal strife (leads to anarchy)"),
				new TableRow(17, TableRow.NOVALUE, "Besieged by enemies"),
				new TableRow(18, TableRow.NOVALUE, "Scandal threatens powerful families"),
				new TableRow(19, TableRow.NOVALUE, "Dungeon discovered (adventurers flock to town)"),
				new TableRow(20, TableRow.NOVALUE, "Religious sects struggle for power"),
			});

				public static readonly Table building_type = new Table("Building Type", "Type", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, 10, "Residence (roll once on the Residence table)"),
				new TableRow(11, 12, "Religious (roll once on the Religious table)"),
				new TableRow(13, 15, "Tavern (roll once on the Tavern table and twice on the Tavern Name Generator table"),
				new TableRow(16, 17, "Warehouse (roll once on the Warehouse table)"),
				new TableRow(18, 20, "Shop (roll once on the Shop table)"),
				});

				public static readonly Table residence = new Table("Residence", "Type", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, 2, "Abandoned squat"),
				new TableRow(3, 8, "Middle-class home"),
				new TableRow(9, 10, "Upper-class home"),
				new TableRow(11, 15, "Crowded tenement"),
				new TableRow(16, 17, "Orphanage"),
				new TableRow(18, TableRow.NOVALUE, "Hidden slavers' den"),
				new TableRow(19, TableRow.NOVALUE, "Front for a secret cult"),
				new TableRow(20, TableRow.NOVALUE, "Lavish, guarded mansion"),
			});

				public static readonly Table religious_building = new Table("Religious Building", "Type", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, 10, "Temple to a good or neutral deity"),
				new TableRow(11, 12, "Temple to a false deity (run by charlatan priests)"),
				new TableRow(13, TableRow.NOVALUE, "Home of ascetics"),
				new TableRow(14, 15, "Abandoned shrine"),
				new TableRow(16, 17, "Library dedicated to religious study"),
				new TableRow(18, 19, "Hidden shrine to a fiend or an evil deity"),
			});

				public static readonly Table tavern = new Table("Tavern", "Type", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, 5, "Quiet, low-key bar"),
				new TableRow(6, 9, "Raucous dive"),
				new TableRow(10, TableRow.NOVALUE, "Thieves' guild hangout"),
				new TableRow(11, TableRow.NOVALUE, "Gathering place for a secret society"),
				new TableRow(12, 13, "Upper-class dining club"),
				new TableRow(14, 15, "Gambling den"),
				new TableRow(16, 17, "Caters to specific race or guild"),
				new TableRow(18, TableRow.NOVALUE, "Members-only club"),
				new TableRow(19, 20, "Brothel"),
			});

				public static readonly Table tavern_name_first_part = new Table("Tavern Name - First Part", "First Part", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "The Silver"),
				new TableRow(2, TableRow.NOVALUE, "The Golden"),
				new TableRow(3, TableRow.NOVALUE, "The Staggering"),
				new TableRow(4, TableRow.NOVALUE, "The Laughing"),
				new TableRow(5, TableRow.NOVALUE, "The Prancing"),
				new TableRow(6, TableRow.NOVALUE, "The Gilded"),
				new TableRow(7, TableRow.NOVALUE, "The Running"),
				new TableRow(8, TableRow.NOVALUE, "The Howling"),
				new TableRow(9, TableRow.NOVALUE, "The Slaughtered"),
				new TableRow(10, TableRow.NOVALUE, "The Leering"),
				new TableRow(11, TableRow.NOVALUE, "The Drunken"),
				new TableRow(12, TableRow.NOVALUE, "The Leaping"),
				new TableRow(13, TableRow.NOVALUE, "The Roaring"),
				new TableRow(14, TableRow.NOVALUE, "The Frowning"),
				new TableRow(15, TableRow.NOVALUE, "The Lonely"),
				new TableRow(16, TableRow.NOVALUE, "The Wandering"),
				new TableRow(17, TableRow.NOVALUE, "The Mysterious"),
				new TableRow(18, TableRow.NOVALUE, "The Barking"),
				new TableRow(19, TableRow.NOVALUE, "The Black"),
				new TableRow(20, TableRow.NOVALUE, "The Gleaming"),
			});

				public static readonly Table tavern_name_second_part = new Table("Tavern Name - Second Part", "Second Part", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Eel"),
				new TableRow(2, TableRow.NOVALUE, "Dolphin"),
				new TableRow(3, TableRow.NOVALUE, "Dwarf"),
				new TableRow(4, TableRow.NOVALUE, "Pegasus"),
				new TableRow(5, TableRow.NOVALUE, "Pony"),
				new TableRow(6, TableRow.NOVALUE, "Rose"),
				new TableRow(7, TableRow.NOVALUE, "Stag"),
				new TableRow(8, TableRow.NOVALUE, "Wolf"),
				new TableRow(9, TableRow.NOVALUE, "Lamb"),
				new TableRow(10, TableRow.NOVALUE, "Demon"),
				new TableRow(11, TableRow.NOVALUE, "Goat"),
				new TableRow(12, TableRow.NOVALUE, "Spirit"),
				new TableRow(13, TableRow.NOVALUE, "Horde"),
				new TableRow(14, TableRow.NOVALUE, "Jester"),
				new TableRow(15, TableRow.NOVALUE, "Mountain"),
				new TableRow(16, TableRow.NOVALUE, "Eagle"),
				new TableRow(17, TableRow.NOVALUE, "Satyr"),
				new TableRow(18, TableRow.NOVALUE, "Dog"),
				new TableRow(19, TableRow.NOVALUE, "Spider"),
				new TableRow(20, TableRow.NOVALUE, "Star"),
			});

				public static readonly Table warehouse = new Table("Warehouse", "Type", Data.Rolls_String.d20, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, 4, "Empty or abandoned"),
				new TableRow(5, 6, "Heavily guarded, expensive goods"),
				new TableRow(7, 10, "Cheap goods"),
				new TableRow(11, 14, "Bulk goods"),
				new TableRow(15, TableRow.NOVALUE, "Live animals"),
				new TableRow(16, 17, "Weapons/armor"),
				new TableRow(18, 19, "Goods from a distant land"),
				new TableRow(20, TableRow.NOVALUE, "Secret smuggler's den"),
			});

				public static readonly Table shop = new Table("Shop", "Type", Data.Rolls_String.d20, "", Data.Titles.DMG, 114, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Pawnshop"),
				new TableRow(2, TableRow.NOVALUE, "Herbs/incense"),
				new TableRow(3, TableRow.NOVALUE, "Fruits/vegetables"),
				new TableRow(4, TableRow.NOVALUE, "Dried meats"),
				new TableRow(5, TableRow.NOVALUE, "Pottery"),
				new TableRow(6, TableRow.NOVALUE, "Undertaker"),
				new TableRow(7, TableRow.NOVALUE, "Books"),
				new TableRow(8, TableRow.NOVALUE, "Moneylender"),
				new TableRow(9, TableRow.NOVALUE, "Weapons/armor"),
				new TableRow(10, TableRow.NOVALUE, "Chandler"),
				new TableRow(11, TableRow.NOVALUE, "Smithy"),
				new TableRow(12, TableRow.NOVALUE, "Carpenter"),
				new TableRow(13, TableRow.NOVALUE, "Weaver"),
				new TableRow(14, TableRow.NOVALUE, "Jeweler"),
				new TableRow(15, TableRow.NOVALUE, "Baker"),
				new TableRow(16, TableRow.NOVALUE, "Mapmaker"),
				new TableRow(17, TableRow.NOVALUE, "Tailor"),
				new TableRow(18, TableRow.NOVALUE, "Ropemaker"),
				new TableRow(19, TableRow.NOVALUE, "Mason"),
				new TableRow(20, TableRow.NOVALUE, "Scribe"),
			});

				public static readonly Table random_urban_encounters = new Table("Random Urban Encounters", "Encounter", Data.Rolls_String.d12_plus_d8, "", Data.Titles.DMG, 113, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Animals on the loose"),
				new TableRow(2, TableRow.NOVALUE, "Announcement"),
				new TableRow(3, TableRow.NOVALUE, "Brawl"),
				new TableRow(4, TableRow.NOVALUE, "Bullies"),
				new TableRow(5, TableRow.NOVALUE, "Companion"),
				new TableRow(6, TableRow.NOVALUE, "Contest"),
				new TableRow(7, TableRow.NOVALUE, "Corpse"),
				new TableRow(8, TableRow.NOVALUE, "Draft"),
				new TableRow(9, TableRow.NOVALUE, "Drunk"),
				new TableRow(10, TableRow.NOVALUE, "Fire"),
				new TableRow(11, TableRow.NOVALUE, "Found trinket"),
				new TableRow(12, TableRow.NOVALUE, "Guard harassment"),
				new TableRow(13, TableRow.NOVALUE, "Pickpocket"),
				new TableRow(14, TableRow.NOVALUE, "Procession"),
				new TableRow(15, TableRow.NOVALUE, "Protest"),
				new TableRow(16, TableRow.NOVALUE, "Runaway cart"),
				new TableRow(17, TableRow.NOVALUE, "Shady transaction"),
				new TableRow(18, TableRow.NOVALUE, "Spectacle"),
				new TableRow(19, TableRow.NOVALUE, "Urchin"),
			});
			}

			// Chapter 6
			public static class BetweenAdventures
			{
				public static readonly Table carousing = new Table("Carousing", "Result", Data.Rolls_String.d100, "level", Data.Titles.DMG, 128, new TableRow[]{
				new TableRow(1, 10, "You are jailed for 1d4 days at the end of the downtime period on charges of disorderly conduct and disturbing the peace. You can pay a fine of 10 gp to avoid jail time, or you can try to resist arrest."),
				new TableRow(1, 10, "You are jailed for 1d4 days at the end of the downtime period on charges of disorderly conduct and disturbing the peace. You can pay a fine of 10 gp to avoid jail time, or you can try to resist arrest."),
				new TableRow(11, 20, "You regain consciousness in a strange place with no memory of how you got there, and you have been robbed of 3d6x5 gp."),
				new TableRow(21, 30, "You make an enemy. This person, business, or organization is now hostile to you. The DM determines the offended party. You decide how you offended them."),
				new TableRow(31, 40, "You are caught up in a whirlwind romance. Roll a d20. On a 1-5, the romance ends badly. On a 6-10, the romance ends amicably. On an 11-20, the romance is ongoing.You determine the identity of the love interest, subject to your DM's approval. If the romance ends badly, you might gain a new flaw. If it ends well or is ongoing, your new love interest might represent a new bond."),
				new TableRow(41, 80, "You earn modest winnings from gambling and recuperate your lifestlye expenses for the time spent carousing."),
				new TableRow(81, 90, "You earn modest winnings from gambling. You recuperate your lifestyle expenses for the time spent carousing and gain 1d20x4 gp."),
				new TableRow(90, 100, "You make a small fortune gambling. You recuperate your lifestyle expenses for the time spent carousing and gain 4d6x10 gp."),
			});

				public static readonly Table running_a_business = new Table("Running a Business", "Result", Data.Rolls_String.d100, "Days", Data.Titles.DMG, 129, new TableRow[]{
				new TableRow(1, 20, "You ust pay one and a half times the business's maintenance cost for each of the days."),
				new TableRow(21, 30, "You must pay the business's full maintenance cost for each of the days."),
				new TableRow(31, 40, "You must pay half the business's maintenance cost for each of the days. Profits cover the other half."),
				new TableRow(41, 60, "The business covers its own maintenance cost for each of the days."),
				new TableRow(61, 80, "The business covers its own maintenance cost for each of the days. It earns a profit of 1d6x5 gp."),
				new TableRow(81, 90, "The business covers its own maintenance cost for each of the days. It earns a profit of 2d8x5 gp."),
				new TableRow(91, 100, "The business covers its own maintenance cost for each of the days. It earns a profit of 3d10x5 gp."),
			});

				public static readonly Table selling_a_magic_item = new Table("Selling a Magic Item", "You Find...", Data.Rolls_String.d100, "Mod", Data.Titles.DMG, 130, new TableRow[]{
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
				public static readonly Table gemstones10gp = new Table("10 GP Gemstones", "Stone Description", Data.Rolls_String.d12, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Azurite (opaque mottled deep blue)"),
				new TableRow(2, TableRow.NOVALUE, "Banded agate (translucent striped brown, blue, white, or red)"),
				new TableRow(3, TableRow.NOVALUE, "Blue quartz (transparent pale blue)"),
				new TableRow(4, TableRow.NOVALUE, "Eye agate (translucent circles of gray, white, brown, blue, or green)"),
				new TableRow(5, TableRow.NOVALUE, "Hematite (opaque gray-black)"),
				new TableRow(6, TableRow.NOVALUE, "Lapis lazuli (opaque light and dark blue with yellow flecks)"),
				new TableRow(7, TableRow.NOVALUE, "Malachite (opaque striated light and dark green)"),
				new TableRow(8, TableRow.NOVALUE, "Moss agate (translucent pink or yellow-white with mossy gray or green markings)"),
				new TableRow(9, TableRow.NOVALUE, "Obsidian (opaque black)"),
				new TableRow(10, TableRow.NOVALUE, "Rhodochrosite (opaque light pink)"),
				new TableRow(11, TableRow.NOVALUE, "Tiger eye (translucent brown with golden center"),
				new TableRow(12, TableRow.NOVALUE, "Turquoise (opaque light blue-green)"),
			});

				public static readonly Table gemstones50gp = new Table("50 GP Gemstones", "Stone Description", Data.Rolls_String.d12, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Bloodstone (opaque dark gray with red flecks)"),
				new TableRow(2, TableRow.NOVALUE, "Carnelian (opaque orange to red-brown)"),
				new TableRow(3, TableRow.NOVALUE, "Chalcedony (opaque white)"),
				new TableRow(4, TableRow.NOVALUE, "Chrysoprase (translucent green)"),
				new TableRow(5, TableRow.NOVALUE, "Citrine (transparent pale yellow-brown)"),
				new TableRow(6, TableRow.NOVALUE, "Jasper (opaque blue, black, or brown)"),
				new TableRow(7, TableRow.NOVALUE, "Moonstone (translucent white with pale blue glow)"),
				new TableRow(8, TableRow.NOVALUE, "Onyx (opaque bands of black and white, or pure black or white)"),
				new TableRow(9, TableRow.NOVALUE, "Quartz (transparent white, smoky gray, or yellow)"),
				new TableRow(10, TableRow.NOVALUE, "Sardonyx (opaque bands of red and white)"),
				new TableRow(11, TableRow.NOVALUE, "Star rose quartz (translucent rosy stone with white star-shaped center)"),
				new TableRow(12, TableRow.NOVALUE, "Zircon (transparent pale blue-green"),
			});

				public static readonly Table gemstones100gp = new Table("100 GP Gemstones", "Stone Description", Data.Rolls_String.d10, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Amber (transparent watery gold to rich gold)"),
				new TableRow(2, TableRow.NOVALUE, "Amethyst (transparent deep purple)"),
				new TableRow(3, TableRow.NOVALUE, "Chrysoberyl (transparent yellow-green to pale green)"),
				new TableRow(4, TableRow.NOVALUE, "Coral (opaque crimson)"),
				new TableRow(5, TableRow.NOVALUE, "Garnet (trasnparent red, brown-green, or violet)"),
				new TableRow(6, TableRow.NOVALUE, "Jade (trasnlucent light green, deep green, or white)"),
				new TableRow(7, TableRow.NOVALUE, "Jet (opaque deep black)"),
				new TableRow(8, TableRow.NOVALUE, "Pearl (opaque lustrous white, yellow, or pink)"),
				new TableRow(9, TableRow.NOVALUE, "Spinel (trasnparent red, red-brown, or deep green)"),
				new TableRow(10, TableRow.NOVALUE, "Tourmaline (trasnparent pale green, blue, brown, or red)"),
			});

				public static readonly Table gemstones500gp = new Table("500 GP Gemstones", "Stone Description", Data.Rolls_String.d6, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Alexandrite (transparent dark green)"),
				new TableRow(2, TableRow.NOVALUE, "Aquamarine (transparent pale blue-green)"),
				new TableRow(3, TableRow.NOVALUE, "Black pearl (opaque pure black)"),
				new TableRow(4, TableRow.NOVALUE, "Blue spinel (trasnparent deep blue)"),
				new TableRow(5, TableRow.NOVALUE, "Peridot (trasnparent rich olive green)"),
				new TableRow(6, TableRow.NOVALUE, "Topaz (transparent golden yellow)"),
			});

				public static readonly Table gemstones1000gp = new Table("1,000 GP Gemstones", "Stone Description", Data.Rolls_String.d8, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Black opal (translucent dark green with black mottling and golden flecks)"),
				new TableRow(2, TableRow.NOVALUE, "Blue sapphire (transparent blue-white to medium blue)"),
				new TableRow(3, TableRow.NOVALUE, "Emerald (transparent deep bright green)"),
				new TableRow(4, TableRow.NOVALUE, "Fire opal (translucent fiery red)"),
				new TableRow(5, TableRow.NOVALUE, "Opal (translucent pale blue with green and golden mottling)"),
				new TableRow(6, TableRow.NOVALUE, "Star ruby (translucent ruby with white star-shaped center)"),
				new TableRow(7, TableRow.NOVALUE, "Star sapphire (translucent blue sapphire with white star-shaped center)"),
				new TableRow(8, TableRow.NOVALUE, "Yellow sapphire (transparent fiery yellow or yellow-green)"),
			});

				public static readonly Table gemstones5000gp = new Table("5,000 GP Gemstones", "Stone Description", Data.Rolls_String.d4, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Black sapphire (translucent lustrous black with glowing highlights)"),
				new TableRow(2, TableRow.NOVALUE, "Diamond (transparent blue-white canary, pink, brown, or blue)"),
				new TableRow(3, TableRow.NOVALUE, "Jacinth (transparent fiery orange)"),
				new TableRow(4, TableRow.NOVALUE, "Ruby (transparent clear red to deep crimson)"),
			});

				public static readonly Table art_objects25gp = new Table("25 GP Art Objects", "Object", Data.Rolls_String.d10, "", Data.Titles.DMG, 134, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Silver ewer"),
				new TableRow(2, TableRow.NOVALUE, "Carved bone statuette"),
				new TableRow(3, TableRow.NOVALUE, "Small gold bracelet"),
				new TableRow(4, TableRow.NOVALUE, "Cloth-of-gold vestments"),
				new TableRow(5, TableRow.NOVALUE, "Black velvet mask stitched with silver thread"),
				new TableRow(6, TableRow.NOVALUE, "Copper chalice with silver filigree"),
				new TableRow(7, TableRow.NOVALUE, "Pair of engraved bone dice"),
				new TableRow(8, TableRow.NOVALUE, "Small mirror set in a painted wooden frame"),
				new TableRow(9, TableRow.NOVALUE, "Embroidered silk handkerchief"),
				new TableRow(10, TableRow.NOVALUE, "Gold locket with a apainted portrait inside"),
			});

				public static readonly Table art_objects250gp = new Table("250 GP Art Objects", "Object", Data.Rolls_String.d10, "", Data.Titles.DMG, 135, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Gold ring set with bloodstones"),
				new TableRow(2, TableRow.NOVALUE, "Carved ivory statuette"),
				new TableRow(3, TableRow.NOVALUE, "Large gold bracelet"),
				new TableRow(4, TableRow.NOVALUE, "Silver necklace wit ha gemstone pendant"),
				new TableRow(5, TableRow.NOVALUE, "Bronze crown"),
				new TableRow(6, TableRow.NOVALUE, "Silk robe wit hgold embroidery"),
				new TableRow(7, TableRow.NOVALUE, "Large well-made tapestry"),
				new TableRow(8, TableRow.NOVALUE, "Brass mug wit hjade inlay"),
				new TableRow(9, TableRow.NOVALUE, "Box of turquoise animal figurines"),
				new TableRow(10, TableRow.NOVALUE, "Gold bird cage with electrum filigree"),
			});

				public static readonly Table art_objects750gp = new Table("750 GP Art Objects", "Object", Data.Rolls_String.d10, "", Data.Titles.DMG, 135, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Silver chalice set with moonstones"),
				new TableRow(2, TableRow.NOVALUE, "Silver-plated steel longsword with jet set in hilt"),
				new TableRow(3, TableRow.NOVALUE, "Carved harp of exotic wood with ivory inlay and zircon gems"),
				new TableRow(4, TableRow.NOVALUE, "Small gold idol"),
				new TableRow(5, TableRow.NOVALUE, "Gold dragon comb set with red garnets as eyes"),
				new TableRow(6, TableRow.NOVALUE, "Bottle stopper cork embossed wit hgold leaf and set with amethysts"),
				new TableRow(7, TableRow.NOVALUE, "Ceremonial electrum dagger with a black pearl in the pommel"),
				new TableRow(8, TableRow.NOVALUE, "Silver and gold brooch"),
				new TableRow(9, TableRow.NOVALUE, "Obsidian statuette with gold fittings and inlay"),
				new TableRow(10, TableRow.NOVALUE, "Painted gold war mask"),
			});

				public static readonly Table art_objects2500gp = new Table("2,500 GP Art Objects", "Object", Data.Rolls_String.d10, "", Data.Titles.DMG, 135, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Fine gold chain set with a fire opal"),
				new TableRow(2, TableRow.NOVALUE, "Old masterpiece painting"),
				new TableRow(3, TableRow.NOVALUE, "Embroidered silk and velvet mantle set with numerous moonstones"),
				new TableRow(4, TableRow.NOVALUE, "Platinum bracelet set wit ha sapphire"),
				new TableRow(5, TableRow.NOVALUE, "Embroidered glove set with jewel chips"),
				new TableRow(6, TableRow.NOVALUE, "Jeweled anklet"),
				new TableRow(7, TableRow.NOVALUE, "Gold music box"),
				new TableRow(8, TableRow.NOVALUE, "Gold circlet set with four aquamarines"),
				new TableRow(9, TableRow.NOVALUE, "Eye patch wit ha mock eye set in blue sapphire and moonstone"),
				new TableRow(10, TableRow.NOVALUE, "A necklace string of small pink pearls"),
			});

				public static readonly Table art_objects7500gp = new Table("7,500 GP Art Objects", "Object", Data.Rolls_String.d8, "", Data.Titles.DMG, 135, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Jeweled gold crown"),
				new TableRow(2, TableRow.NOVALUE, "Jeweled platinum ring"),
				new TableRow(3, TableRow.NOVALUE, "Small gold statuette set with rubies"),
				new TableRow(4, TableRow.NOVALUE, "Gold cup set with emeralds"),
				new TableRow(5, TableRow.NOVALUE, "Gold jewelry box with platinum filigree"),
				new TableRow(6, TableRow.NOVALUE, "Painted gold child's sarcophagus"),
				new TableRow(7, TableRow.NOVALUE, "Jade game board with solid gold playing pieces"),
				new TableRow(8, TableRow.NOVALUE, "Bejeweled ivory drinking horn with gold filigree"),
			});

				public static readonly Table individual_treasure_challenge0_4 = new Table("Individual Treasure: Challenge 0-4", "Coins", Data.Rolls_String.d100, "", Data.Titles.DMG, 136, new TableRow[]{
				new TableRow(1, 30, "5d6 (17) cp"),
				new TableRow(31, 60, "4d6 (14) sp"),
				new TableRow(61, 70, "3d6 (10) ep"),
				new TableRow(71, 85, "3d6 (10) gp"),
				new TableRow(86, 90, "1d6 (3) pp"),
			});

				public static readonly Table individual_treasure_challenge5_10 = new Table("Individual Treasure: Challenge 5-10", "Coins", Data.Rolls_String.d100, "", Data.Titles.DMG, 136, new TableRow[]{
				new TableRow(1, 30, "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep"),
				new TableRow(31, 60, "6d6 x 10 (210) sp, 2d6 x 10 (70) gp"),
				new TableRow(61, 70, "3d6 x 10 (105) ep, 2d6 x 10 (70) gp"),
				new TableRow(71, 85, "4d6 x 10 (140) gp"),
				new TableRow(86, 90, "2d6 x 10 (70) gp, 3d6 (10) pp"),
			});

				public static readonly Table individual_treasure_challenge11_16 = new Table("Individual Treasure: Challenge 11-16", "Coins", Data.Rolls_String.d100, "", Data.Titles.DMG, 136, new TableRow[]{
				new TableRow(1, 20, "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp"),
				new TableRow(21, 35, "1d6 x 100 (350) ep, 1d6 x 100 (350) gp"),
				new TableRow(36, 75, "2d6 x 100 (700) gp, 1d6 x 10 (35) pp"),
				new TableRow(76, 100, "2d6 x 100 (700) gp, 2d6 x 10 (70) pp"),
			});

				public static readonly Table individual_treasure_challenge17_plus = new Table("Individual Treasure: Challenge 17+", "Coins", Data.Rolls_String.d100, "", Data.Titles.DMG, 136, new TableRow[]{
				new TableRow(1, 15, "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp"),
				new TableRow(16, 55, "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp"),
				new TableRow(56, 100, "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp"),
			});

				public static readonly Table treasure_hoard_challenge0_4 = new Table("Treasure Hoard: Challenge 0-4", "Coins, Gems or Art Objects, Magic Items", Data.Rolls_String.d100, "", Data.Titles.DMG, 137, new TableRow[]{
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
				new TableRow(76, TableRow.NOVALUE, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp 2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(77, 78, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(79, 80, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C"),
				new TableRow(81, 85, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C"),
				new TableRow(86, 92, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F"),
				new TableRow(93, 97, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F"),
				new TableRow(98, 99, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 25 gp art objects, Roll once on Magic Item Table G"),
				new TableRow(100, TableRow.NOVALUE, "6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, 2d6 (7) 50 gp gems, Roll once on Magic Item Table G"),
			});

				public static readonly Table treasure_hoard_challenge5_10 = new Table("Treasure Hoard: Challenge 5-10", "Coins, Gems or Art Objects, Magic Items", Data.Rolls_String.d100, "", Data.Titles.DMG, 137, new TableRow[]{
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
				new TableRow(79, TableRow.NOVALUE, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll once on Magic Item Table D"),
				new TableRow(80, TableRow.NOVALUE, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll once on Magic Item Table D"),
				new TableRow(81, 84, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F"),
				new TableRow(85, 88, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table F"),
				new TableRow(89, 91, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table F"),
				new TableRow(92, 94, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table F"),
				new TableRow(95, 96, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table G"),
				new TableRow(97, 98, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 250 gp art objects, Roll 1d4 times on Magic Item Table G"),
				new TableRow(99, TableRow.NOVALUE, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 3d6 (10) 100 gp gems, Roll once on Magic Item Table H"),
				new TableRow(100, TableRow.NOVALUE, "2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, 2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H"),
			});

				public static readonly Table treasure_hoard_challenge11_16 = new Table("Treasure Hoard: Challenge 11-16", "Coins, Gems or Art Objects, Magic Items", Data.Rolls_String.d100, "", Data.Titles.DMG, 138, new TableRow[]{
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

				public static readonly Table treasure_hoard_challenge17_plus = new Table("Treasure Hoard: Challenge 17+", "Coins, Gems or Art Objects, Magic Items", Data.Rolls_String.d100, "", Data.Titles.DMG, 139, new TableRow[]{
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
				new TableRow(69, TableRow.NOVALUE, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table G"),
				new TableRow(70, TableRow.NOVALUE, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table G"),
				new TableRow(71, TableRow.NOVALUE, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table G"),
				new TableRow(72, TableRow.NOVALUE, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table G"),
				new TableRow(73, 74, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H"),
				new TableRow(75, 76, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table H"),
				new TableRow(77, 78, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table H"),
				new TableRow(79, 80, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table H"),
				new TableRow(81, 85, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I"),
				new TableRow(86, 90, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I"),
				new TableRow(91, 95, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I"),
				new TableRow(96, 100, "12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, 1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I"),
			});

				public static readonly Table potion_miscibility = new Table("Potion Miscibility", "Result", Data.Rolls_String.d100, "", Data.Titles.DMG, 140, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "The mixture creates a magical explosion, dealing 6d10 force damage to the mixer and 1d10 force damage to each creature within 5 feet of the mixer."),
				new TableRow(2, 8, "The mixture becomes an ingested poison of the DM's choice."),
				new TableRow(9, 15, "Both potions lose their effects."),
				new TableRow(16, 25, "One potion loses its effect."),
				new TableRow(26, 35, "Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way."),
				new TableRow(36, 90, "Both potions work normally."),
				new TableRow(91, 99, "The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally."),
				new TableRow(100, TableRow.NOVALUE, "Only one potion works, but its effect is permanent. Choose the simplest effect to make permanent, or the one that seems the most fun. For example, a potion of healing might increase the drinker's hit point maximum by 4, or oil of etherealness migth permanently trap the user in the Ethereal Plane. At your discretion, an appropriate spell, such as dispel magic or remove curse, might end this lasting effect."),
			});

				public static readonly Table scroll_mishap = new Table("Scroll Mishap", "Result", Data.Rolls_String.d100, "", Data.Titles.DMG, 140, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "A surge of magical energy deals the caster 1d6 force damage per level of the spell"),
				new TableRow(2, TableRow.NOVALUE, "The spell affects the caster or an ally (determined randomly) instead of the intended target, or it affects a random target nearby if the caster was the intended target."),
				new TableRow(3, TableRow.NOVALUE, "The spell affects a random location within the spell's range."),
				new TableRow(4, TableRow.NOVALUE, "The spell's effect is contrary to its normal one, but neither harmful nor beneficial. For instance, a fireball might produce an area of harmless cold."),
				new TableRow(5, TableRow.NOVALUE, "The caster suffers a minor but bizarre effect related to the spell. Such effects last only as long as the original spell's duration, or 1d10 minutes for spells that take effect instantaneously. For example, a fireball might cause smoke to billow from the caster's ears for 1d10 minutes."),
				new TableRow(6, TableRow.NOVALUE, "The spell activates after 1d12 hours. If the caster was the intended target, the spell takes effect normally. If the caster was not the intended target, the spell goes off in the general direction of the intended target, up to the spell's maximum range, if the target has moved away."),
			});

				public static readonly Table who_created_it_or_who_was_intended_to_use_it = new Table("Who Created It or Who Was Intended to Use It?", "Creator or Intended User", Data.Rolls_String.d100, "", Data.Titles.DMG, 142, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Aberration. The item was created by aberrations in ancient times, possibly for the use of favored humanoid thralls. When seen from the corner of the eye, the item seems to be moving."),
				new TableRow(2, 4, "Human. The item was created during the heyday of a fallen human kingdom, or it is tied to a human legend. It might hold writing in a forgotten tongue or symbols whose significance is lost to the ages."),
				new TableRow(5, TableRow.NOVALUE, "Celestial. The weapon is half the normal weight and inscribed with feathered wings, suns, and other symbols of good. Fiends find the item's presence repulsive."),
				new TableRow(6, TableRow.NOVALUE, "Dragon. This item is made from scales and talons shed by a dragon. Perhaps it incorporates precious metals and gems from the dragon's hoard. It grows slightly warm when within 120 feet of a dragon."),
				new TableRow(7, TableRow.NOVALUE, "Drow. The item is half the normal weight. It is black and inscribed with spiders and webs in honor of Lolth. it might function poorly, or disintegrate, if exposed to sunlight for 1 minute or more."),
				new TableRow(8, 9, "Dwarf. The item is durable and has Dwarven runes worked into its design. It might be associated with a clan that would like to see it returned to their ancestral halls."),
				new TableRow(10, TableRow.NOVALUE, "Elemental Air. The item is half the normal weight and feels hollow. If it's made of fabric, it is diaphanous."),
				new TableRow(11, TableRow.NOVALUE, "Elemental Earth. This item might be crafted from stone. Any cloth of leather elements are studded with finely polished rock."),
				new TableRow(12, TableRow.NOVALUE, "Elemental Fire. This item is warm to the touch, and any metal parts are crafted from black iron. Sigils of flames cover its surface. Shades of red and orange are the prominent colors."),
				new TableRow(13, TableRow.NOVALUE, "Elemental Water. Lustrous fish scales replace leather or cloth on this item, and metal portions are instead crafted from seashells and worked coral as hard as any metal."),
				new TableRow(14, 15, "Elf. The item is half the normal weight. It is adorned with symbold of nature: leaves, vines, stars, and the like."),
				new TableRow(16, TableRow.NOVALUE, "Fey. The item is exquisitely crafted from the finest materials and glows with a pale radiance in moonlight, shedding dim light in a 5-foot radius. Any metal in the item is silver or mithral, rather than iron or steel."),
				new TableRow(17, TableRow.NOVALUE, "Fiend. The item is made of black iron or horn inscribed with runes, and any cloth or leather components are crafted from the hide of fiends. It is warm to the touch and features leering faces or vile runes engraved on its surface. Celestials find the item's presence repulsive."),
				new TableRow(18, TableRow.NOVALUE, "Giant. The item is larger than normal and was crafted by giants for use by their smaller allies."),
				new TableRow(19, TableRow.NOVALUE, "Gnome. The item is crafted to appear ordinary, and it might look worn. It could also incorporate gears and mechanical components, even if these aren't essential to the item's function."),
				new TableRow(20, TableRow.NOVALUE, "Undead. The item incorporates imagery of death, such as bones and skulls, and it might be crafted from parts of corpses. It feels cold to the touch."),
			});

				public static readonly Table what_is_a_detail_from_its_history = new Table("What Is a Detail from Its History?", "History", Data.Rolls_String.d100, "", Data.Titles.DMG, 142, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Arcane. This item was created for an ancient order of spellcasters and bears the order's symbol."),
				new TableRow(2, TableRow.NOVALUE, "Bane. This item was created by the foes of a particular culture of kind of creature. If the culture or creatures are still around, they might recognize the item and single out the bearer as an enemy."),
				new TableRow(3, TableRow.NOVALUE, "Heroic. A great hero once wielded this item. Anyone who's familiar with the item's history expects great deeds from the new owner."),
				new TableRow(4, TableRow.NOVALUE, "Ornament. The item was created to honor a special occasion. Inset gemstones, gold or platinum inlays, and gold or silver filigree adorn its surface."),
				new TableRow(5, TableRow.NOVALUE, "Prophecy. The item features in a prophecy: its bearer is destined to play a key role in future events. Someone else who wants to play that role might try to steal the item, or someone who wants to prevent the prophecy from being fulfilled might try to kill the item's bearer."),
				new TableRow(6, TableRow.NOVALUE, "Religious. This item was used in religious ceremonies dedicated to a particular deity. It has holy symbols worked into it. The god's followers might try to persuade its owner to donate it to a temple, steal the item for themselves, or celebrate its use by a cleric or paladin of the same deity."),
				new TableRow(7, TableRow.NOVALUE, "Sinister. This item is linked to a deed of great evil, such as a massacre or an assassination. It might have a name or be closely associated with a villain who used it. Anyone familiar with the item's history is likely to treat it and its owner with suspicion."),
				new TableRow(8, TableRow.NOVALUE, "Symbol of Power. This item was once used as part of royal regalia or as a badge of high office. Its former owner or that person's descendants might desire it, or someone might mistakenly assume its new owner is the item's legitimate inheritor."),
			});

				public static readonly Table what_minor_property_does_it_have = new Table("What Minor Property does It Have?", "Minor Property", Data.Rolls_String.d100, "", Data.Titles.DMG, 143, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Beacon. The bearer can use a bonus action to cause the item to shed bright light in a 10-foot radius and dim light for an additional 10 feet, or to extinguish the light."),
				new TableRow(2, TableRow.NOVALUE, "Compass. The wielder can use an action to learn which way is north."),
				new TableRow(3, TableRow.NOVALUE, "Conscientious. When the bearer of this item contemplates or undertakes a malevolent act, the item enhances pangs of conscience."),
				new TableRow(4, TableRow.NOVALUE, "Delver. While underground, the bearer of this item always knows the item's depth below the surface and the direction to the nearest staircase, ramp, or other path leading upward."),
				new TableRow(5, TableRow.NOVALUE, "Gleaming. This itme never gets dirty."),
				new TableRow(6, TableRow.NOVALUE, "Guardian. The item whispers warnings to its bearer, granting a +2 bonus to initiative if the bearer isn't incapacitated"),
				new TableRow(7, TableRow.NOVALUE, "Harmonious. Attuning to this item takes only 1 minute."),
				new TableRow(8, TableRow.NOVALUE, "Hidden Message. A message is hidden somewhere on the item. It might be visible only at a certain time of the year, under the light of one phase of the moon, or in a specific location."),
				new TableRow(9, TableRow.NOVALUE, "Key. The item is used to unlock a container, chamber, vault, or other entryway."),
				new TableRow(10, TableRow.NOVALUE, "Language. The bearer can speak and understand a language of the DM's choice while the item is on the bearer's person."),
				new TableRow(11, TableRow.NOVALUE, "Sentinel. Choose a kind of creature that is an enemy of the item's creator. This item glows faintly when such creatures are within 120 feet of it."),
				new TableRow(12, TableRow.NOVALUE, "Song Craft. Whenever this item is struck or is used to strike a foe, its bearer hears a fragment of an ancient song."),
				new TableRow(13, TableRow.NOVALUE, "Strange Material. The item was created from a material that is bizarre given its purpose. Its durability is unaffected."),
				new TableRow(14, TableRow.NOVALUE, "Temperate. The bearer suffers no harm in temperatures as cold as -20 degrees Fahrenheit or as warm as 120 degrees Fahrenheit."),
				new TableRow(15, TableRow.NOVALUE, "Unbreakable. The item can't be broken. Special means must be used to destroy it."),
				new TableRow(16, TableRow.NOVALUE, "War Leader. The bearer can use an action to cause his or her voice to carry clearly for up to 300 feet until the end of the bearer's next turn."),
				new TableRow(17, TableRow.NOVALUE, "Waterborne. This item floats on water and other liquids. Its bearer has advantage on Strength (Athletics) checks to swim."),
				new TableRow(18, TableRow.NOVALUE, "Wicked. When the bearer is presented with an opportunity to act in a selfish or malevolent way, the item heightens the bearer's urge to do so."),
				new TableRow(19, TableRow.NOVALUE, "Illusion. The item is imbued with illusion magic, allowing its bearer to alter the item's appearance in minor ways. Such alterations don't change how the item is worn, carried, or wielded, and they have no effect on its other magical properties. For example, the weare could make a red robe appear blue, or make a gold ring look like it's made of ivory. The item reverts to its true appearance when no one is carrying or wearing it."),
				new TableRow(20, TableRow.NOVALUE, "Roll twice, rerolling any additional 20s."),
			});

				public static readonly Table what_quirk_does_it_have = new Table("What Quirk does It Have?", "Quirk", Data.Rolls_String.d100, "", Data.Titles.DMG, 143, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Blissful. While in possession of the item, the bearer feels fortunate and optimistic about what the future holds. Butterflies and other harmless creatures might frolic in the item's presence."),
				new TableRow(2, TableRow.NOVALUE, "Confident. The item helps its bearer feel self-assured."),
				new TableRow(3, TableRow.NOVALUE, "Covetous. The item's bearer becomes obsessed with material wealth."),
				new TableRow(4, TableRow.NOVALUE, "Frail. The item crumbles, frays, chips, or cracks slightly when wielded, worn, or activated. This quirk has no effect on its properties, but if the item has seen much use, it looks decrepit."),
				new TableRow(5, TableRow.NOVALUE, "Hungry. This item's magical properties function only if fresh blood from a humanoid has been applied to it within the past 24 hours. It needs only a drop to activate."),
				new TableRow(6, TableRow.NOVALUE, "Loud. The item makes a loud noice -- such as a clang, a shout, or a resonating gong -- when used."),
				new TableRow(7, TableRow.NOVALUE, "Metamorphic. The item periodically and randomly alters its appearance in slight ways. The bearer has no control over these minor alterations, which have no effect on the item's use."),
				new TableRow(8, TableRow.NOVALUE, "Muttering. The item grumbles and mutters. A creature who listens carefully to the item might learn something useful."),
				new TableRow(9, TableRow.NOVALUE, "Painful. The bearer experiences a harmless flash of pain when using the item."),
				new TableRow(10, TableRow.NOVALUE, "Possessive. The item demands attunement when first wielded or worn, and it doesn't allow its bearer to attune to other items. (Other items already attuned to the bearer remain so until their attunemnt ends.)"),
				new TableRow(11, TableRow.NOVALUE, "Repulsive. The bearer feels a sens of distaste when in contact with the item, and continues to sense discomfort while bearing it."),
				new TableRow(12, TableRow.NOVALUE, "Slothful. The bearer of this item feels slothful and lethargic. While attuned to the item, the bearer requires 10 hours to finish a long rest."),
			});

				public static readonly Table magic_item_table_a = new Table("Magic Item Table A", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 144, new TableRow[]{
				new TableRow(1, 50, "Potion of healing"),
				new TableRow(51, 60, "Spell scroll (cantrip)"),
				new TableRow(61, 70, "Potion of climbing"),
				new TableRow(71, 90, "Spell scroll (1st level)"),
				new TableRow(91, 94, "Spell scroll (2nd level)"),
				new TableRow(95, 98, "Potion of greater healing"),
				new TableRow(99, TableRow.NOVALUE, "Bag of holding"),
				new TableRow(100, TableRow.NOVALUE, "Driftglobe"),
			});

				public static readonly Table magic_item_table_b = new Table("Magic Item Table B", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 144, new TableRow[]{
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
				new TableRow(84, TableRow.NOVALUE, "Alchemy jug"),
				new TableRow(85, TableRow.NOVALUE, "Cap of water breathing"),
				new TableRow(86, TableRow.NOVALUE, "Cloak of the manta ray"),
				new TableRow(87, TableRow.NOVALUE, "Driftglobe"),
				new TableRow(88, TableRow.NOVALUE, "Goggles of night"),
				new TableRow(89, TableRow.NOVALUE, "Helm of comprehending languages"),
				new TableRow(90, TableRow.NOVALUE, "Immovable rod"),
				new TableRow(91, TableRow.NOVALUE, "Lantern of revealing"),
				new TableRow(92, TableRow.NOVALUE, "Mariner's armor"),
				new TableRow(93, TableRow.NOVALUE, "Mithral armor"),
				new TableRow(94, TableRow.NOVALUE, "Potion of poison"),
				new TableRow(95, TableRow.NOVALUE, "Ring of swimming"),
				new TableRow(96, TableRow.NOVALUE, "Robe of useful items"),
				new TableRow(97, TableRow.NOVALUE, "Rope of climbing"),
				new TableRow(98, TableRow.NOVALUE, "Saddle of the cavalier"),
				new TableRow(99, TableRow.NOVALUE, "Wand of magic detection"),
				new TableRow(100, TableRow.NOVALUE, "Wand of secrets"),
			});

				public static readonly Table magic_item_table_c = new Table("Magic Item Table C", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 145, new TableRow[]{
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
				new TableRow(92, TableRow.NOVALUE, "Chime of opening"),
				new TableRow(93, TableRow.NOVALUE, "Decanter of endless water"),
				new TableRow(94, TableRow.NOVALUE, "Eyes of minute seeing"),
				new TableRow(95, TableRow.NOVALUE, "Folding boat"),
				new TableRow(96, TableRow.NOVALUE, "Heward's handy haversack"),
				new TableRow(97, TableRow.NOVALUE, "Horseshoes of speed"),
				new TableRow(98, TableRow.NOVALUE, "Necklace of fireballs"),
				new TableRow(99, TableRow.NOVALUE, "Periapt of health"),
				new TableRow(100, TableRow.NOVALUE, "Sending stones"),
			});

				public static readonly Table magic_item_table_d = new Table("Magic Item Table D", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 145, new TableRow[]{
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
				new TableRow(96, 98, "Nolzur's marvelous pigments"),
				new TableRow(99, TableRow.NOVALUE, "Bag of devouring"),
				new TableRow(100, TableRow.NOVALUE, "Portable hole"),
			});

				public static readonly Table magic_item_table_e = new Table("Magic Item Table E", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 145, new TableRow[]{
				new TableRow(1, 30, "Spell scroll (8th level)"),
				new TableRow(31, 55, "Potion of storm giant strength"),
				new TableRow(56, 70, "Potion of supreme healing"),
				new TableRow(71, 85, "Spell scroll (9th level)"),
				new TableRow(86, 93, "Universal solvent"),
				new TableRow(94, 98, "Arrow of slaying"),
				new TableRow(99, 100, "Sovereign glue"),
			});

				public static readonly Table magic_item_table_f = new Table("Magic Item Table F", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 146, new TableRow[]{
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
				new TableRow(66, TableRow.NOVALUE, "Adamantine armor (chain mail"),
				new TableRow(67, TableRow.NOVALUE, "Adamantine armor (chain shirt)"),
				new TableRow(68, TableRow.NOVALUE, "Adamantine armor (scale mail)"),
				new TableRow(69, TableRow.NOVALUE, "Bag of tricks (gray)"),
				new TableRow(70, TableRow.NOVALUE, "Bag of tricks (rust)"),
				new TableRow(71, TableRow.NOVALUE, "Bag of tricks (tan)"),
				new TableRow(72, TableRow.NOVALUE, "Boots of the winterlands"),
				new TableRow(73, TableRow.NOVALUE, "Circlet of blasting"),
				new TableRow(74, TableRow.NOVALUE, "Deck of illusions"),
				new TableRow(75, TableRow.NOVALUE, "Eversmoking bottle"),
				new TableRow(76, TableRow.NOVALUE, "Eyes of charming"),
				new TableRow(77, TableRow.NOVALUE, "Eyes of the eagle"),
				new TableRow(78, TableRow.NOVALUE, "FIgurine of wondrous power (silver raven)"),
				new TableRow(79, TableRow.NOVALUE, "Gem of brightness"),
				new TableRow(80, TableRow.NOVALUE, "Gloves of missile snaring"),
				new TableRow(81, TableRow.NOVALUE, "Gloves of swimming and climbing"),
				new TableRow(82, TableRow.NOVALUE, "Gloves of thievery"),
				new TableRow(83, TableRow.NOVALUE, "Headband of intellect"),
				new TableRow(84, TableRow.NOVALUE, "Helm of telepathy"),
				new TableRow(85, TableRow.NOVALUE, "Instrument of the bards (Doss lute)"),
				new TableRow(86, TableRow.NOVALUE, "Instrument of the bards (Fochlucan bandore)"),
				new TableRow(87, TableRow.NOVALUE, "Instrument of the bards (Mac-Fuimidh cittern)"),
				new TableRow(88, TableRow.NOVALUE, "Medallion of thoughts"),
				new TableRow(89, TableRow.NOVALUE, "Necklace of adaptation"),
				new TableRow(90, TableRow.NOVALUE, "Periapt of wound closure"),
				new TableRow(91, TableRow.NOVALUE, "Pipes of haunting"),
				new TableRow(92, TableRow.NOVALUE, "Pipes of the sewers"),
				new TableRow(93, TableRow.NOVALUE, "Ring of jumping"),
				new TableRow(94, TableRow.NOVALUE, "Ring of mind shielding"),
				new TableRow(95, TableRow.NOVALUE, "Ring of warmth"),
				new TableRow(96, TableRow.NOVALUE, "Ring of water walking"),
				new TableRow(97, TableRow.NOVALUE, "Quiver of Ehlonna"),
				new TableRow(98, TableRow.NOVALUE, "Stone of good luck"),
				new TableRow(99, TableRow.NOVALUE, "Wind fan"),
				new TableRow(100, TableRow.NOVALUE, "Winged boots"),
			});

				public static readonly Table magic_item_table_g = new Table("Magic Item Table G", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 147, new TableRow[]{
				new TableRow(1, 11, "Weapon, +2"),
				new TableRow(12, 13, "Figurine of wondrous power (roll d8), 1 - Bronze griffon, 2 - Ebony fly, 3 - Golden lions, 4 - Ivory goats, 5 - Marble elephant, 6-7 - Onyx dog, 8 - Serpentine owl"),
				new TableRow(14, TableRow.NOVALUE, "Adamantine armor (breastplate)"),
				new TableRow(15, TableRow.NOVALUE, "Adamantine armor (splint)"),
				new TableRow(16, TableRow.NOVALUE, "Amulet of health"),
				new TableRow(17, TableRow.NOVALUE, "Armor of vulnerability"),
				new TableRow(18, TableRow.NOVALUE, "Arrow-catching shield"),
				new TableRow(19, TableRow.NOVALUE, "Belt of dwarvenkind"),
				new TableRow(20, TableRow.NOVALUE, "Belt of hill giant strength"),
				new TableRow(21, TableRow.NOVALUE, "Berserker axe"),
				new TableRow(22, TableRow.NOVALUE, "Boots of levitation"),
				new TableRow(23, TableRow.NOVALUE, "Boots of speed"),
				new TableRow(24, TableRow.NOVALUE, "Bowl of commanding water elementals"),
				new TableRow(25, TableRow.NOVALUE, "Bracers of defense"),
				new TableRow(26, TableRow.NOVALUE, "Brazier of commanding fire elementals"),
				new TableRow(27, TableRow.NOVALUE, "Cape of the mountebank"),
				new TableRow(28, TableRow.NOVALUE, "Censer of controlling air elementals"),
				new TableRow(29, TableRow.NOVALUE, "Armor, +1 chain mail"),
				new TableRow(30, TableRow.NOVALUE, "Armor of resistance (chain mail)"),
				new TableRow(31, TableRow.NOVALUE, "Armor, +1 chain shirt"),
				new TableRow(32, TableRow.NOVALUE, "Armor of resistance (chain shirt)"),
				new TableRow(33, TableRow.NOVALUE, "Cloak of displacement"),
				new TableRow(34, TableRow.NOVALUE, "Cloak of the bat"),
				new TableRow(35, TableRow.NOVALUE, "Cube of force"),
				new TableRow(36, TableRow.NOVALUE, "Daern's instant fortress"),
				new TableRow(37, TableRow.NOVALUE, "Dagger of venom"),
				new TableRow(38, TableRow.NOVALUE, "Dimensional shackles"),
				new TableRow(39, TableRow.NOVALUE, "Dragon slayer"),
				new TableRow(40, TableRow.NOVALUE, "Elven chain"),
				new TableRow(41, TableRow.NOVALUE, "Flame tongue"),
				new TableRow(42, TableRow.NOVALUE, "Gem of seeing"),
				new TableRow(43, TableRow.NOVALUE, "Giant slayer"),
				new TableRow(44, TableRow.NOVALUE, "Glamoured studded leather"),
				new TableRow(45, TableRow.NOVALUE, "Helm of teleportation"),
				new TableRow(46, TableRow.NOVALUE, "Horn of blasting"),
				new TableRow(47, TableRow.NOVALUE, "Horn of Valhalla (silver or brass)"),
				new TableRow(48, TableRow.NOVALUE, "Instrument of the bards (Canaith mandolin)"),
				new TableRow(49, TableRow.NOVALUE, "Instrument of the bards (Cli lyre)"),
				new TableRow(50, TableRow.NOVALUE, "Ioun stone (awareness)"),
				new TableRow(51, TableRow.NOVALUE, "Ioun stone (protection)"),
				new TableRow(52, TableRow.NOVALUE, "Ioun stone (reserve)"),
				new TableRow(53, TableRow.NOVALUE, "Ioun stone (sustenance)"),
				new TableRow(54, TableRow.NOVALUE, "Iron bands of Bilarro"),
				new TableRow(55, TableRow.NOVALUE, "Armor, +1 leather"),
				new TableRow(56, TableRow.NOVALUE, "Armor of resistance (leather)"),
				new TableRow(57, TableRow.NOVALUE, "Mace of disruption"),
				new TableRow(58, TableRow.NOVALUE, "Mace of smiting"),
				new TableRow(59, TableRow.NOVALUE, "Mace of terror"),
				new TableRow(60, TableRow.NOVALUE, "Mantle of spell resistance"),
				new TableRow(61, TableRow.NOVALUE, "Necklace of prayer beads"),
				new TableRow(62, TableRow.NOVALUE, "Periapt of proof against poison"),
				new TableRow(63, TableRow.NOVALUE, "Ring of animal influence"),
				new TableRow(64, TableRow.NOVALUE, "Ring of evasion"),
				new TableRow(65, TableRow.NOVALUE, "Ring of feather falling"),
				new TableRow(66, TableRow.NOVALUE, "Ring of free action"),
				new TableRow(67, TableRow.NOVALUE, "Ring of protection"),
				new TableRow(68, TableRow.NOVALUE, "Ring of resistance"),
				new TableRow(69, TableRow.NOVALUE, "Ring of spell storing"),
				new TableRow(70, TableRow.NOVALUE, "Ring of the ram"),
				new TableRow(71, TableRow.NOVALUE, "Ring of X-ray vision"),
				new TableRow(72, TableRow.NOVALUE, "Robe of eyes"),
				new TableRow(73, TableRow.NOVALUE, "Rod of rulership"),
				new TableRow(74, TableRow.NOVALUE, "Rod of the pact keeper, +2"),
				new TableRow(75, TableRow.NOVALUE, "Rope of entanglement"),
				new TableRow(76, TableRow.NOVALUE, "Armor, +1 scale mail"),
				new TableRow(77, TableRow.NOVALUE, "Armor of resistance (scale mail)"),
				new TableRow(78, TableRow.NOVALUE, "Shield, +2"),
				new TableRow(79, TableRow.NOVALUE, "Shield of missile attraction"),
				new TableRow(80, TableRow.NOVALUE, "Staff of charming"),
				new TableRow(81, TableRow.NOVALUE, "Staff of healing"),
				new TableRow(82, TableRow.NOVALUE, "Staff of swarming insects"),
				new TableRow(83, TableRow.NOVALUE, "Staff of the woodlands"),
				new TableRow(84, TableRow.NOVALUE, "Staff of withering"),
				new TableRow(85, TableRow.NOVALUE, "Stone of controlling earth elementals"),
				new TableRow(86, TableRow.NOVALUE, "Sun blade"),
				new TableRow(87, TableRow.NOVALUE, "Sword of life stealing"),
				new TableRow(88, TableRow.NOVALUE, "Sword of wounding"),
				new TableRow(89, TableRow.NOVALUE, "Tentacle rod"),
				new TableRow(90, TableRow.NOVALUE, "Vicious weapon"),
				new TableRow(91, TableRow.NOVALUE, "Wand of binding"),
				new TableRow(92, TableRow.NOVALUE, "Wand of enemy detection"),
				new TableRow(93, TableRow.NOVALUE, "Wand of fear"),
				new TableRow(94, TableRow.NOVALUE, "Wand of fireballs"),
				new TableRow(95, TableRow.NOVALUE, "Wand of lightning bolts"),
				new TableRow(96, TableRow.NOVALUE, "Wand of paralysis"),
				new TableRow(97, TableRow.NOVALUE, "Wand of the war mage, +2"),
				new TableRow(98, TableRow.NOVALUE, "Wand of wonder"),
				new TableRow(99, TableRow.NOVALUE, "Wings of flying"),
			});

				public static readonly Table magic_item_table_h = new Table("Magic Item Table H", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 148, new TableRow[]{
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
				new TableRow(56, TableRow.NOVALUE, "Adamantine armor (half plate)"),
				new TableRow(57, TableRow.NOVALUE, "Adamantine armor (plate)"),
				new TableRow(58, TableRow.NOVALUE, "Animated shield"),
				new TableRow(59, TableRow.NOVALUE, "Belt of fire giant strength"),
				new TableRow(60, TableRow.NOVALUE, "Belt of frost (or stone) giant strength"),
				new TableRow(61, TableRow.NOVALUE, "Armor, +1 breastplate"),
				new TableRow(62, TableRow.NOVALUE, "Armor of resistance (breastplate)"),
				new TableRow(63, TableRow.NOVALUE, "Candle of invocation"),
				new TableRow(64, TableRow.NOVALUE, "Armor, +2 chain mail"),
				new TableRow(65, TableRow.NOVALUE, "Armor, +2 chain shirt"),
				new TableRow(66, TableRow.NOVALUE, "Cloak of arachnida"),
				new TableRow(67, TableRow.NOVALUE, "Dancing sword"),
				new TableRow(68, TableRow.NOVALUE, "Demon armor"),
				new TableRow(69, TableRow.NOVALUE, "Dragon scale mail"),
				new TableRow(70, TableRow.NOVALUE, "Dwarven plate"),
				new TableRow(71, TableRow.NOVALUE, "Dwarven thrower"),
				new TableRow(72, TableRow.NOVALUE, "Efreeti bottle"),
				new TableRow(73, TableRow.NOVALUE, "Figurine of wondrous poer (obsidian steed)"),
				new TableRow(74, TableRow.NOVALUE, "Frost brand"),
				new TableRow(75, TableRow.NOVALUE, "Helm of briliance"),
				new TableRow(76, TableRow.NOVALUE, "Horn of Valhalla (bronze)"),
				new TableRow(77, TableRow.NOVALUE, "Instrument of the bards (Anstruth harp)"),
				new TableRow(78, TableRow.NOVALUE, "Ioun stone (absorption)"),
				new TableRow(79, TableRow.NOVALUE, "Ioun stone (agility)"),
				new TableRow(80, TableRow.NOVALUE, "Ioun stone (fortitude)"),
				new TableRow(81, TableRow.NOVALUE, "Ioun stone (insight)"),
				new TableRow(82, TableRow.NOVALUE, "Ioun stone (intellect)"),
				new TableRow(83, TableRow.NOVALUE, "Ioun stone (leadership)"),
				new TableRow(84, TableRow.NOVALUE, "Ioun stone (strength)"),
				new TableRow(85, TableRow.NOVALUE, "Armor, +2 leather"),
				new TableRow(86, TableRow.NOVALUE, "Manual of bodily health"),
				new TableRow(87, TableRow.NOVALUE, "Manual of gainful exercise"),
				new TableRow(88, TableRow.NOVALUE, "Manual of golems"),
				new TableRow(89, TableRow.NOVALUE, "Manual of quickness of action"),
				new TableRow(90, TableRow.NOVALUE, "Mirror of life trapping"),
				new TableRow(91, TableRow.NOVALUE, "Nine lives stealer"),
				new TableRow(92, TableRow.NOVALUE, "Oathbow"),
				new TableRow(93, TableRow.NOVALUE, "Armor, +2 scale mail"),
				new TableRow(94, TableRow.NOVALUE, "Spellguard shield"),
				new TableRow(95, TableRow.NOVALUE, "Armor, +1 splint"),
				new TableRow(96, TableRow.NOVALUE, "Armor of resistance (splint)"),
				new TableRow(97, TableRow.NOVALUE, "Armor, +1 studded leather"),
				new TableRow(98, TableRow.NOVALUE, "Armor of resistance (studded leather)"),
				new TableRow(99, TableRow.NOVALUE, "Tome of clear thought"),
				new TableRow(100, TableRow.NOVALUE, "Tome of leadership and influence"),
				new TableRow(101, TableRow.NOVALUE, "Tome of understanding"),
			});

				public static readonly Table magic_item_table_i = new Table("Magic Item Table I", "Magic Item", Data.Rolls_String.d100, "", Data.Titles.DMG, 149, new TableRow[]{
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
				new TableRow(76, TableRow.NOVALUE, "Magic armor (roll d12), 1-2 - Armor, +2 half plate, 3-4 - Armor, +2 plate, 5-6 - Armor, +3 studded leather, 7-8 - Armor, +3 breastplate, 9-10 - Armor, +3 splint, 11 - Armor, +3 half plate, 12 - Armor, +3 plate"),
				new TableRow(77, TableRow.NOVALUE, "Apparatus of Kwalish"),
				new TableRow(78, TableRow.NOVALUE, "Armor of invulnerability"),
				new TableRow(79, TableRow.NOVALUE, "Belt of storm giant strength"),
				new TableRow(80, TableRow.NOVALUE, "Cubic gate"),
				new TableRow(81, TableRow.NOVALUE, "Deck of many things"),
				new TableRow(82, TableRow.NOVALUE, "Efreeti chain"),
				new TableRow(83, TableRow.NOVALUE, "Armor of resistance (half plate)"),
				new TableRow(84, TableRow.NOVALUE, "Horn of Valhalla (iron)"),
				new TableRow(85, TableRow.NOVALUE, "Instrument of the bards (Ollamh harp)"),
				new TableRow(86, TableRow.NOVALUE, "Ioun stone (greater absorption)"),
				new TableRow(87, TableRow.NOVALUE, "Ioun stone (mastery)"),
				new TableRow(88, TableRow.NOVALUE, "Ioun stone (regeneration)"),
				new TableRow(89, TableRow.NOVALUE, "Plate armor of etherealness"),
				new TableRow(90, TableRow.NOVALUE, "Plate armor of resistance"),
				new TableRow(91, TableRow.NOVALUE, "Ring of air elemental command"),
				new TableRow(92, TableRow.NOVALUE, "Ring of earth elemental command"),
				new TableRow(93, TableRow.NOVALUE, "Ring of fire elemental command"),
				new TableRow(94, TableRow.NOVALUE, "Ring of three wishes"),
				new TableRow(95, TableRow.NOVALUE, "Ring of water elemental command"),
				new TableRow(96, TableRow.NOVALUE, "Sphere of annihilation"),
				new TableRow(97, TableRow.NOVALUE, "Talisman of pure good"),
				new TableRow(98, TableRow.NOVALUE, "Talisman of the sphere"),
				new TableRow(99, TableRow.NOVALUE, "Talisman of ultimate evil"),
				new TableRow(100, TableRow.NOVALUE, "Tome of the stilled tongue"),
			});

				public static readonly Table armor_of_resistance_damage_type = new Table("Armor of Resistance", "Damage Type", Data.Rolls_String.d10, "", Data.Titles.DMG, 152, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Acid"),
				new TableRow(2, TableRow.NOVALUE, "Cold"),
				new TableRow(3, TableRow.NOVALUE, "Fire"),
				new TableRow(4, TableRow.NOVALUE, "Force"),
				new TableRow(5, TableRow.NOVALUE, "Lightning"),
				new TableRow(6, TableRow.NOVALUE, "Necrotic"),
				new TableRow(7, TableRow.NOVALUE, "Poison"),
				new TableRow(8, TableRow.NOVALUE, "Psychic"),
				new TableRow(9, TableRow.NOVALUE, "Radiant"),
				new TableRow(10, TableRow.NOVALUE, "Thunder"),
			});

				public static readonly Table bag_of_beans_effect = new Table("Bag of Beans Effect", "Effect", Data.Rolls_String.d100, "", Data.Titles.DMG, 153, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "5d4 toadstools sprout. If a creature eats a toadstool, roll any die. On an odd roll, the eater must succeed on a DC 15 Constitution saving throw or take 5d6 poison damage and become poisoned for 1 hour. On an even roll, the eater gains 5d6 temporary hit points for 1 hour."),
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
				new TableRow(100, TableRow.NOVALUE, "A giant beanstalk sprouts, growing to a height of the DM's choice. The top leads where the DM chooses, such as to a great view, a cloud giant's castle, or a different plane of existence."),
			});

				public static readonly Table gray_bag_of_tricks = new Table("Gray Bag of Tricks", "Creature", Data.Rolls_String.d8, "", Data.Titles.DMG, 154, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Weasel"),
				new TableRow(2, TableRow.NOVALUE, "Giant rat"),
				new TableRow(3, TableRow.NOVALUE, "Badger"),
				new TableRow(4, TableRow.NOVALUE, "Boar"),
				new TableRow(5, TableRow.NOVALUE, "Panther"),
				new TableRow(6, TableRow.NOVALUE, "Giant badger"),
				new TableRow(7, TableRow.NOVALUE, "Dire wolf"),
				new TableRow(8, TableRow.NOVALUE, "Giant elk"),
			});

				public static readonly Table rust_bag_of_tricks = new Table("Rust Bag of Tricks", "Creature", Data.Rolls_String.d8, "", Data.Titles.DMG, 154, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Rat"),
				new TableRow(2, TableRow.NOVALUE, "Owl"),
				new TableRow(3, TableRow.NOVALUE, "Mastiff"),
				new TableRow(4, TableRow.NOVALUE, "Goat"),
				new TableRow(5, TableRow.NOVALUE, "Giant goat"),
				new TableRow(6, TableRow.NOVALUE, "Giant boar"),
				new TableRow(7, TableRow.NOVALUE, "Lion"),
				new TableRow(8, TableRow.NOVALUE, "Brown bear"),
			});

				public static readonly Table tan_bag_of_tricks = new Table("Tan Bag of Tricks", "Creature", Data.Rolls_String.d8, "", Data.Titles.DMG, 154, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Jackal"),
				new TableRow(2, TableRow.NOVALUE, "Ape"),
				new TableRow(3, TableRow.NOVALUE, "Baboon"),
				new TableRow(4, TableRow.NOVALUE, "Axe beak"),
				new TableRow(5, TableRow.NOVALUE, "Black bear"),
				new TableRow(6, TableRow.NOVALUE, "Giant weasel"),
				new TableRow(7, TableRow.NOVALUE, "Giant hyena"),
				new TableRow(8, TableRow.NOVALUE, "Tiger"),
			});

				public static readonly Table candle_of_invocation_alignment = new Table("Candle of Invocation", "Alignment", Data.Rolls_String.d20, "", Data.Titles.DMG, 157, new TableRow[]{
				new TableRow(1, 2, "Chaotic evil"),
				new TableRow(3, 4, "Chaotic neutral"),
				new TableRow(5, 7, "Chaotic good"),
				new TableRow(8, 9, "Neutral evil"),
				new TableRow(10, 11, "Neutral"),
				new TableRow(12, 13, "Neutral good"),
				new TableRow(14, 15, "Lawful evil"),
				new TableRow(16, 17, "Lawful neutral"),
				new TableRow(18, 20, "Lawful good"),
			});

				public static readonly Table carpet_of_flying = new Table("Carpet of Flying", "Size, Capacity, Flying Speed", Data.Rolls_String.d100, "", Data.Titles.DMG, 157, new TableRow[]{
				new TableRow(1, 20, "3 ft. x 5 ft., 200 lb., 80 feet"),
				new TableRow(21, 55, "4 ft. x 6 ft., 400 lb., 60 feet"),
				new TableRow(56, 80, "5 ft. x 7 ft., 600 lb., 40 feet"),
				new TableRow(81, 100, "6 ft. x 9 ft., 800 lb., 30 feet"),
			});

				public static readonly Table efreeti_bottle_effect = new Table("Efreeti Bottle Effect", "Effect", Data.Rolls_String.d100, "", Data.Titles.DMG, 167, new TableRow[]{
				new TableRow(1, 10, "The efreeti attacks you. After fighting for 5 rounds, the efreeti disappears, and the bottle loses its magic."),
				new TableRow(11, 90, "The efreeti serves you for 1 hour, doing as you command. Then the efreeti returns to the bottle, and a new stopper contains it. The stopper can't be removed for 24 hours. The next two times the bottle is opened, the same effect occurs. If the bottle is opened a fourth time, the efreeti excapes and disappears, and the bottle loses its magic."),
				new TableRow(91, 100, "The efreeti can cast the wish spell three times for you. It disappears when it grans the final wish or after 1 hour, and the bottle loses its magic."),
			});

				public static readonly Table horn_of_valhalla = new Table("Horn of Valhalla", "Horn Type, Berserkers Summoned, Requirement", Data.Rolls_String.d100, "", Data.Titles.DMG, 175, new TableRow[]{
				new TableRow(1, 40, "Silver, 2d4 + 2, None"),
				new TableRow(41, 75, "Brass, 3d4 + 3, Proficiency with all simple weapons"),
				new TableRow(76, 90, "Bronze, 4d4 + 4, Proficiency with all medium armor"),
				new TableRow(91, 100, "Iron, 5d4 + 5, Proficiency with all martial weapons"),
			});

				public static readonly Table iron_flask_contents = new Table("Iron Flask Contents", "Contents", Data.Rolls_String.d100, "", Data.Titles.DMG, 178, new TableRow[]{
				new TableRow(1, 50, "Empty"),
				new TableRow(51, TableRow.NOVALUE, "Arcanaloth"),
				new TableRow(52, TableRow.NOVALUE, "Cambion"),
				new TableRow(53, 54, "Dao"),
				new TableRow(55, 57, "Demon (type 1)"),
				new TableRow(58, 60, "Demon (type 2)"),
				new TableRow(61, 62, "Demon (type 3)"),
				new TableRow(63, 64, "Demon (type 4)"),
				new TableRow(65, TableRow.NOVALUE, "Demon (type 5)"),
				new TableRow(66, TableRow.NOVALUE, "Demon (type 6)"),
				new TableRow(67, TableRow.NOVALUE, "Deva"),
				new TableRow(68, 69, "Devil (greater)"),
				new TableRow(70, 72, "Devil (lesser)"),
				new TableRow(73, 74, "Djinni"),
				new TableRow(75, 76, "Efreeti"),
				new TableRow(77, 78, "Elemental (any)"),
				new TableRow(79, TableRow.NOVALUE, "Githyanki knight"),
				new TableRow(80, TableRow.NOVALUE, "Githzerai zerth"),
				new TableRow(81, 82, "Invisible stalker"),
				new TableRow(83, 84, "Marid"),
				new TableRow(85, 86, "Mezzoloth"),
				new TableRow(87, 88, "Night hag"),
				new TableRow(89, 90, "Nycaloth"),
				new TableRow(91, TableRow.NOVALUE, "Planetar"),
				new TableRow(92, 93, "Salamander"),
				new TableRow(94, 95, "Slaad (any)"),
				new TableRow(96, TableRow.NOVALUE, "Solar"),
				new TableRow(97, 98, "Succubus/incubus"),
				new TableRow(99, TableRow.NOVALUE, "Ultroloth"),
				new TableRow(100, TableRow.NOVALUE, "Xorn"),
			});

				public static readonly Table manual_of_golems = new Table("Manual of Golems", "Golem, Time, Cost", Data.Rolls_String.d20, "", Data.Titles.DMG, 180, new TableRow[]{
				new TableRow(1, 5, "Clay, 30 days, 65,000 gp"),
				new TableRow(6, 17, "Flesh, 60 days, 50,000 gp"),
				new TableRow(18, TableRow.NOVALUE, "Iron, 120 days, 100,000 gp"),
				new TableRow(19, 20, "Stone, 90 days, 80,000 gp"),
			});

				public static readonly Table necklace_of_prayer_beads = new Table("Necklace of Prayer Beads", "Bead of..., Spell", Data.Rolls_String.d20, "", Data.Titles.DMG, 182, new TableRow[]{
				new TableRow(1, 6, "Blessing, Bless"),
				new TableRow(7, 12, "Curing, Curing"),
				new TableRow(13, 16, "Favor, Greater restoration"),
				new TableRow(17, 18, "Smiting, Branding smite"),
				new TableRow(19, TableRow.NOVALUE, "Summons, Planar ally"),
				new TableRow(20, TableRow.NOVALUE, "Wind walking, Wind walk"),
			});

				public static readonly Table potion_of_resistance_damage_type = new Table("Potion of Resistance", "Damage Type", Data.Rolls_String.d10, "", Data.Titles.DMG, 188, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Acid"),
				new TableRow(2, TableRow.NOVALUE, "Cold"),
				new TableRow(3, TableRow.NOVALUE, "Fire"),
				new TableRow(4, TableRow.NOVALUE, "Force"),
				new TableRow(5, TableRow.NOVALUE, "Lightning"),
				new TableRow(6, TableRow.NOVALUE, "Necrotic"),
				new TableRow(7, TableRow.NOVALUE, "Poison"),
				new TableRow(8, TableRow.NOVALUE, "Psychic"),
				new TableRow(9, TableRow.NOVALUE, "Radiant"),
				new TableRow(10, TableRow.NOVALUE, "Thunder"),
			});

				public static readonly Table quaals_feather_token = new Table("Quaals Feather Token", "Feather Token", Data.Rolls_String.d100, "", Data.Titles.DMG, 188, new TableRow[]{
				new TableRow(1, 20, "Anchor"),
				new TableRow(21, 35, "Bird"),
				new TableRow(36, 50, "Fan"),
				new TableRow(51, 65, "Swan boat"),
				new TableRow(66, 90, "Tree"),
				new TableRow(91, 100, "Whip"),
			});

				public static readonly Table ring_of_resistance = new Table("Ring of Resistance", "Damage Type", Data.Rolls_String.d10, "", Data.Titles.DMG, 192, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Acid - Pearl"),
				new TableRow(2, TableRow.NOVALUE, "Cold - Tourmaline"),
				new TableRow(3, TableRow.NOVALUE, "Fire - Garnet"),
				new TableRow(4, TableRow.NOVALUE, "Force - Sapphire"),
				new TableRow(5, TableRow.NOVALUE, "Lightning - Citrine"),
				new TableRow(6, TableRow.NOVALUE, "Necrotic - Jet"),
				new TableRow(7, TableRow.NOVALUE, "Poison - Amethyst"),
				new TableRow(8, TableRow.NOVALUE, "Psychic - Jade"),
				new TableRow(9, TableRow.NOVALUE, "Radiant - Topaz"),
				new TableRow(10, TableRow.NOVALUE, "Thunder - Spinel"),
			});

				public static readonly Table robe_of_useful_items = new Table("Robe of Useful Items", "Patch", Data.Rolls_String.d100, "", Data.Titles.DMG, 195, new TableRow[]{
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

				public static readonly Table scroll_of_protection_creature_type = new Table("Scroll of Protection", "Creature Type", Data.Rolls_String.d100, "", Data.Titles.DMG, 199, new TableRow[]{
				new TableRow(1, 10, "Aberrations"),
				new TableRow(11, 20, "Beasts"),
				new TableRow(21, 30, "Celestials"),
				new TableRow(31, 40, "Elementals"),
				new TableRow(41, 50, "Fey"),
				new TableRow(51, 75, "Fiends"),
				new TableRow(76, 80, "Plants"),
				new TableRow(81, 100, "Undead"),
			});

				public static readonly Table sphere_of_annihilation_planar_portal_contact_result = new Table("Sphere of Annihilation Planar Portal Contact", "Result", Data.Rolls_String.d100, "", Data.Titles.DMG, 201, new TableRow[]{
				new TableRow(1, 50, "The sphere is destoyed."),
				new TableRow(51, 85, "The sphere moves through the portal or into the extradimensional space."),
				new TableRow(86, 100, "A spatial rift sends each creature and object within 180 feet of the sphere, including the sphere, to a random plane of existence."),
			});

				public static readonly Table wand_of_wonder_effect = new Table("Wand of Wonder", "Effect", Data.Rolls_String.d100, "", Data.Titles.DMG, 212, new TableRow[]{
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

				public static readonly Table creating_sentient_magic_items_communication = new Table("Creating Sentient Magic Items - Communication", "Communication", Data.Rolls_String.d100, "", Data.Titles.DMG, 214, new TableRow[]{
				new TableRow(1, 6, "The item communicates by transmitting emotion to the creature carrying or wielding it"),
				new TableRow(7, 9, "The item can speak, read, and understand one or more languages"),
				new TableRow(10, TableRow.NOVALUE, "The item can speak, read, and understand one or more languages. In addition, the item can communicate telepathically with any character that carries or wields it"),
			});

				public static readonly Table creating_sentient_magic_items_senses = new Table("Creating Sentient Magic Items - Senses", "Senses", Data.Rolls_String.d4, "", Data.Titles.DMG, 214, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Hearing and normal vision out to 30 feet"),
				new TableRow(2, TableRow.NOVALUE, "Hearing and normal vision out to 60 feet"),
				new TableRow(3, TableRow.NOVALUE, "Hearing and normal vision out to 120 feet"),
				new TableRow(4, TableRow.NOVALUE, "Hearing and darkvision out to 120 feet"),
			});

				public static readonly Table creating_sentient_magic_items_alignment = new Table("Creating Sentient Magic Items - Alignment", "Alignment", Data.Rolls_String.d100, "", Data.Titles.DMG, 216, new TableRow[]{
				new TableRow(1, 15, "Lawful good"),
				new TableRow(16, 35, "Neutral good"),
				new TableRow(36, 50, "Chaotic good"),
				new TableRow(51, 63, "Lawful neutral"),
				new TableRow(64, 73, "Neutral"),
				new TableRow(74, 85, "Chaotic neutral"),
				new TableRow(86, 89, "Lawful evil"),
				new TableRow(90, 96, "Neutral evil"),
				new TableRow(97, 100, "Chaotic evil"),
			});

				public static readonly Table creating_sentient_magic_items_special_purpose = new Table("Creating Sentient Magic Items - Special Purpose", "Purpose", Data.Rolls_String.d10, "", Data.Titles.DMG, 216, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Aligned: The item seeks to defeat or destroy those of a diametrically opposed alignment. (Such an item is never neutral.)"),
				new TableRow(2, TableRow.NOVALUE, "Bane: The item seeks to defeat or destroy creatures of a particular kind, such as fiends, shapechangers, trolls, or wizards"),
				new TableRow(3, TableRow.NOVALUE, "Protector: The item seeks to defend a particular race or kind of creature, such as elves or druids"),
				new TableRow(4, TableRow.NOVALUE, "Crusader: The item seeks to defeat, weaken, or destroy the servants of a particular deity"),
				new TableRow(5, TableRow.NOVALUE, "Templar: The item seeks to defend the servants and interests of a particular deity."),
				new TableRow(6, TableRow.NOVALUE, "Destroyer: The item craves destruction and goads its user to fight arbitrarily"),
				new TableRow(7, TableRow.NOVALUE, "Glory Seeker: The item seeks renown as the greatest magic item in the world, by establishing its user as a famous or notorious figure"),
				new TableRow(8, TableRow.NOVALUE, "Lore seeker: The item craves knowledge or is determined to solve a mystery, learn a secret, or unravel a cryptic prophecy"),
				new TableRow(9, TableRow.NOVALUE, "Destiny seeker: The item is convinced that it and its wielder have key roles to play in future events"),
				new TableRow(10, TableRow.NOVALUE, "Creator Seeker: The item seeks its creator and wants to understand why it was created"),
			});

				public static readonly Table moonblade_properties = new Table("Moonblade Properties", "Property", Data.Rolls_String.d100, "", Data.Titles.DMG, 217, new TableRow[]{
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
				new TableRow(99, TableRow.NOVALUE, "You can use an action to call forth an elfshadow, provided that you don't already have one serving you. The elfshadow appears in an unoccupied space within 120 feet of you. It uses the statistics for a shadow from the Monster Manual, except it is neutral, immune to effects that turn undead, and doesn't create new shadows. You control this creature, deciding how it acts and moves. It remains until it drops to 0 hit points or you dismiss it as an action"),
				new TableRow(100, TableRow.NOVALUE, "The moonblade functions as a vorpal sword"),
			});

				public static readonly Table minor_beneficial_properties = new Table("Minor Beneficial Properties", "Property", Data.Rolls_String.d100, "", Data.Titles.DMG, 219, new TableRow[]{
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

				public static readonly Table major_beneficial_properties = new Table("Major Beneficial Properties", "Property", Data.Rolls_String.d100, "", Data.Titles.DMG, 219, new TableRow[]{
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

				public static readonly Table minor_detrimental_properties = new Table("Minor Detrimental Properties", "Property", Data.Rolls_String.d100, "", Data.Titles.DMG, 220, new TableRow[]{
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

				public static readonly Table major_detrimental_properties = new Table("Major Detrimental Properties", "Property", Data.Rolls_String.d100, "", Data.Titles.DMG, 220, new TableRow[]{
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
			}

			// Chapter 8
			public static class RunningTheGame
			{
				public static readonly Table urban_chase_complications = new Table("Urban Chase Complications", "Complication", Data.Rolls_String.d20, "", Data.Titles.DMG, 254, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "A large obstacle such as a horse or car blocks your way. Make a DC 15 Dexterity (Acorbatics) check to get past the obstacle. On a failed check, the obstacle counts as 10 fet of difficult terrain."),
				new TableRow(2, TableRow.NOVALUE, "A crowd blocks yoru way. Make a DC 10 Strength (Athletics) or Dexterity (Acrobatics) check (your choice) to make your way through the crowd unimpeded. On a failed check, the crowd counts as 10 feet of difficult terrain."),
				new TableRow(3, TableRow.NOVALUE, "A larget stained-glass window or similar barrier blocks your path. Make a DC 10 Strength saving throw to smash through the barrier and keep going. On a failed save, you bounce off the barrier and fall prone."),
				new TableRow(4, TableRow.NOVALUE, "A maze of barrels, crates, or similar obstacles stands in your way. Make a DC 10 Dexterity (Acrobatics) or Intelligence check (your choice) to navigate the maze. On a failed check, the maze counts as 10 feet of difficult terrain."),
				new TableRow(5, TableRow.NOVALUE, "The ground beneath your feet is slippery with rain, spilled oil, or some other liquid. Make a DC 10 Dexterity saving throw. On a failed save, you fall prone."),
				new TableRow(6, TableRow.NOVALUE, "You come upon a pack of dogs fighting over food. Make a DC 10 dexterity (Acrobatics) check to get through the pack unimpeded. On a failed check, you are bitten and take 1d4 piercing damage, and the dogs count as 5 feet of difficult terrain."),
				new TableRow(7, TableRow.NOVALUE, "You run into a brawl in progress. Make a DC 15 Strength (Athletics), Dexterity (Acrobatics), or Charisma (Intimidation) check (your choice) to get past the brawlers unimpeded. On a failed check, you take 2d4 bludgeoning damage, and the brawlers count as 10 feet of difficult terrain."),
				new TableRow(8, TableRow.NOVALUE, "A beggar blocks your way. Make a DC 10 Strength (Athletics), Dexterity (Acrobatics), or Charisma (Intimidation) check (your choice) to slip past the beggar. You succeed automatically if you toss the beggar a coin. On a failed check, the beggar counts as 5 feet of difficult terrain."),
				new TableRow(9, TableRow.NOVALUE, "An overzealous guard (see the Monster Manual for game statistics) mistakes you for someone else. If you move 20 feet or more on your turn, the guard makes an opportunity attack against you with a spear (+3 to hit; 1d6 + 1 piercing damage on a hit)."),
				new TableRow(10, TableRow.NOVALUE, "You are forced to make a sharp turn to avoid colliding with something impassable. Make a DC 10 Dexterity saving throw to navigate the turn. On a failed save, you collide with something hard and take 1d4 bludgeoning damage."),
				new TableRow(11, 20, "No complication."),
			});

				public static readonly Table wilderness_chase_complications = new Table("Wilderness Chase Complications", "Complication", Data.Rolls_String.d100, "", Data.Titles.DMG, 254, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Your path takes you through a rough patch of brush. Make a DC 10 Strength (Athletics) or Dexterity (Acrobatics) check (your choice) to get past the brush. On a failed check, the brush counts as 5 feet of difficult terrain."),
				new TableRow(2, TableRow.NOVALUE, "Uneven ground threatens to slow your progress. Make a DC 10 Dexterity (Acrobatics) check to navigate the area. On a failed check, the ground coutns as 10 feet of difficult terrain."),
				new TableRow(3, TableRow.NOVALUE, "You run through a swarm of insects (see the Monster Manual for game statistics, with the DM choosing whiever kind of insects makes the most sens). The swarm makes an opportunity attack against you (+3 to hit; 4d4 piercing damage on a hit)."),
				new TableRow(4, TableRow.NOVALUE, "A stream, ravine, or rock bed blocks your path. Make a DC 10 Strength (Athletics) or Dexterity (Acrobatics) check (your choice) to cross the impediment. On a failed check, the impediment counts as 10 feet of difficult terrain."),
				new TableRow(5, TableRow.NOVALUE, "Make a DC 10 Constitution saving throw. On a failed save, you are blinded by blowing sand, dirt, ash, snow, or pollen until the end of your turn. While blinded in this way, your speed is halved."),
				new TableRow(6, TableRow.NOVALUE, "A sudden drop catches you by surprise. Make a DC 10 Dexterity saving throw to navigate the impediment. On a failed save, you fall 1d4 x 5 feet, taking 1d6 bludgeoning damage per 10 feet fallen as normal, and land prone."),
				new TableRow(7, TableRow.NOVALUE, "You blunder into a hunter's snare. Make a DC 15 Dexterity saving throw to avoid it. On a failed save, you are caught in a net and restrained. See chapter 5, \"Equipment,\" of the Player's Handbook for rules on escaping a net."),
				new TableRow(8, TableRow.NOVALUE, "You are caught in a stampede of spooked animals. Make a DC 10 Dexterity saving throw. On a failed save, you are knocked about and take 1d4 bludgeoning damage and 1d4 piercing damage."),
				new TableRow(9, TableRow.NOVALUE, "Your path takes you near a patch of razorvine. Make a DC 15 Dexterity saving thro or use 10 feet of movement (your choice) to avoid the razorvine. On a failed save, you take 1d10 slashing damage."),
				new TableRow(10, TableRow.NOVALUE, "A creature indigenous to the area chases after you. The DM chooses a creature appropriate for the terrain."),
				new TableRow(11, 20, "No complication."),
			});

				public static readonly Table poisons = new Table("Poisons", "Item, Type, Price per Dose", Data.Rolls_String.d100, "", Data.Titles.DMG, 257, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Assassin's blood, Ingested, 150 gp"),
				new TableRow(2, TableRow.NOVALUE, "Burnt othur fumes, Inhaled, 500 gp"),
				new TableRow(3, TableRow.NOVALUE, "Carrion crawler mucus, Contact, 200 gp"),
				new TableRow(4, TableRow.NOVALUE, "Drow poison, Injury, 200 gp"),
				new TableRow(5, TableRow.NOVALUE, "Essence of ether, Inhaled, 300 gp"),
				new TableRow(6, TableRow.NOVALUE, "Malice, Inhaled, 250 gp"),
				new TableRow(7, TableRow.NOVALUE, "Midnight tears, Ingested, 1,500 gp"),
				new TableRow(8, TableRow.NOVALUE, "Oil of taggit, Contact, 400 gp"),
				new TableRow(9, TableRow.NOVALUE, "Pale tincture, Ingested, 250 gp"),
				new TableRow(10, TableRow.NOVALUE, "Purple worm poison, Injury, 2,000 gp"),
				new TableRow(11, TableRow.NOVALUE, "Serpent venom, Injury, 200 gp"),
				new TableRow(12, TableRow.NOVALUE, "Torpor, Ingested, 600 gp"),
				new TableRow(13, TableRow.NOVALUE, "Truth serum, Ingested, 150 gp"),
				new TableRow(14, TableRow.NOVALUE, "Wyvern poison, Injury, 1,200 gp"),
			});

				public static readonly Table poisons_descriptions = new Table("Poison Descriptions", "", Data.Rolls_String.d100, "", Data.Titles.DMG, 257, new TableRow[]
				{
				new TableRow(1, TableRow.NOVALUE, "Assassin's Blood (Ingested). A creature subjected to this poison must make a DC 10 Constitution saving throw. On a failed save, it takes 6 (1d12) poison damage and is poisoned for 24 hours. On a successful save, the creature takes half damage and isn't poisoned."),
				new TableRow(2, TableRow.NOVALUE, "Burnt Othur Fumes (Inhaled). A creature subjected to this poison must succeed on a DC 13 Constitution saving throw or take 10 (3d6) poison damage, and must repeat the saving throw at the start of each of its turns. On each successive failed save, the character takes 3 (1d6) poison damage. After three successful saves, the poison ends."),
				new TableRow(3, TableRow.NOVALUE, "Carrion Crawler Mucus (Contact). This poison must be harvested from a dead or incapacitated carrion crawler. A creature subjected to this poison must succeed on a DC 13 Constitution saving throw or be poisoned for 1 minute. The poisoned creature is paralyzed. The creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success."),
				new TableRow(4, TableRow.NOVALUE, "Drow Poison (Injury). This poison is typically made only be the drow, and only in a place far removed from sunlight. A creature subjected to this poison must succeed on a DC 13 Constitution saving throw or be poisoned for 1 hour. If the saving throw fails by 5 or more, the creature is also unconscious while poisoned in this way. The creature wakes up if it takes damage or if another creature takes an action to shake it awake."),
				new TableRow(5, TableRow.NOVALUE, "Essence of Ether (Inhaled). A creature subjected to this poison must succeed on a DC 15 Constitution saving throw or become poisoned for 8 hours. The poisoned creature is unconscious. The creature wakes up if it takes damage or if another creature takes an action to shake it awake."),
				new TableRow(6, TableRow.NOVALUE, "Malice (Inhaled). A creature subjected to this poison must succeed on a DC 15 Constitution saving throw or become poisoned for 1 hour. The poisoned creature is blinded."),
				new TableRow(7, TableRow.NOVALUE, "Midnight Tears (Ingested). A creature that ingests this poison suffers no effect until the stroke of mignight. If the poison has not been neutralized before then, the creature must succeed on a DC 17 Constitution saving throw, taking 31 (9d6) poison damage on a failed save, or half as much damage on a successful one."),
				new TableRow(8, TableRow.NOVALUE, "Oil of Taggit (Contact). A creature subjected to this poison must succeed on a DC 13 Constitution saving throw or become poisoned for 24 hours. The poisoned creature is unconscious. The creature wakes up if it takes damage."),
				new TableRow(9, TableRow.NOVALUE, "Pale Tincture (Ingested). A creature subjected to this poison must succeed on a DC 16 Constitution saving throw or take 3 (1d6) poison damage and become poisoned. The poisoned creature must repeat the saving throw every 24 hours, taking 3 (1d6) poison damage on a failed save. Until this poison ends, the damage the poison deals can't be healed by any means. After seven successful saving throws, the effect ends and the creature can heal normally."),
				new TableRow(10, TableRow.NOVALUE, "Purple Worm Poison (Injury). This poison must be harvested from a dead or incapacitated purple worm. A creature subjected to this poison must make a DC 19 Constitution saving throw, taking 42 (12d6) poison damage on a failed save, or half as much damage on a successful one."),
				new TableRow(11, TableRow.NOVALUE, "Serpent Venom (Injury). This poison must be harvested from a dead or incapacitated giant poisonous snake. A creature subjected to this poison must succeed on a DC 11 Constitution saving throw, taking 10 (3d6) poison damage on a failed save, or half as much damage on a successful one."),
				new TableRow(12, TableRow.NOVALUE, "Torpor (Ingested). A creature subjected to this poison must succeed on a DC 15 Constitution saving throw or become poisoned for 4d6 hours. The poisoned creature is incapacitated."),
				new TableRow(13, TableRow.NOVALUE, "Truth Serum (Ingested). A creature subjected to this poison must succeed on a DC 11 Constitution saving throw or become poisoned for 1 hour. The poisoned creature can't knowingly speak a lie, as if under the effect of a zone of truth spell."),
				new TableRow(14, TableRow.NOVALUE, "Wyvern Poison (Injury). This poison must be harvested form a dead or incapacitated wyvern. A creature subjected to this poison must make a DC 15 Constitution saving throw, taking 24 (7d6) poison damage on a failed save, or half as much damage on a successful one."),
				});

				public static readonly Table short_term_madness = new Table("Short-Term Madness", "Effect (lasts 1d10 mnutes)", Data.Rolls_String.d100, "", Data.Titles.DMG, 259, new TableRow[]{
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

				public static readonly Table long_term_madness = new Table("Long-Term Madness", "Effect (lasts 1d10 x 10 hours)", Data.Rolls_String.d100, "", Data.Titles.DMG, 260, new TableRow[]{
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

				public static readonly Table indefinite_madness = new Table("Indefinite Madness", "Flaw (lasts until cured)", Data.Rolls_String.d100, "", Data.Titles.DMG, 260, new TableRow[]{
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
				public static readonly Table lingering_injuries = new Table("Lingering Injuries", "Injury", Data.Rolls_String.d20, "", Data.Titles.DMG, 272, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "Lose an Eye. You have disadvantage on Wisdom (Perception) checks that rely on sight and on ranged attack rolls. Magic such as the regenerate spell can restore the lost eye. If you have no eyes left after sustaining this injury, you're blinded."),
				new TableRow(2, TableRow.NOVALUE, "Lose an Arm or a Hand. You can no longer hold anything with two hands, and you can hold only a single object at a time. Magic such as the regenerate spell can restore the lost appendage."),
				new TableRow(3, TableRow.NOVALUE, "Lose a Foot or Leg. Your speed on foot is halved, and you must use a cane or crutch to move unless you have a peg leg or other prosthesis. You fall prone after using the Dash action. You have disadvantage on Dexterity checks made to balance. Magic such as the regenerate spell can restore the lost appendage."),
				new TableRow(4, TableRow.NOVALUE, "Limp. Your speed on foot is reduced by 5 feet. You must make a DC 10 Dexterity saving throw after using the Dash action. If you fail the save, you fall prone. Magical healing removes the limp."),
				new TableRow(5, 7, "Internal Injury. Whenever you attempt an action in combat, you must make a DC 15 Constitution saving throw. On a failed save, you lose your action and cant use reactions until the start of your next turn. The injury heals if you receive magical healing or if you spend ten days doing nothing but resting."),
				new TableRow(8, 10, "Broken Ribs. This has the same effect as Internal Injury above, except that the save DC is 10."),
				new TableRow(11, 13, "Horribel Scar. You are disfigured to the extent that the wound can't be easily concealed. You have disadvantage on Charisma (Persuasion) checks and advantage on Charisma (Intimidation) checks. Magical healing of 6th level or higher, such as heal and regenerate, removes the scar."),
				new TableRow(14, 16, "Festering Wound. Your hit point maximum is reduced by 1 every 24 hours the wound persists. If your hit point maximum drops to 0, you die. The wound heals if you receive magical healing. Alternatively, someone can tend to the wound and make a DC 15 Wisdom (Medicine) check once every 24 hours. After ten sucesses, the wound heals."),
				new TableRow(17, 20, "Minor Scar. The scar doesn't have any adverse effect. Magical healing of 6th level or higher, such as heal and regenerate, removes the scar."),
			});

				public static readonly Table system_shock = new Table("System Shock", "Effect", Data.Rolls_String.d10, "", Data.Titles.DMG, 272, new TableRow[]{
				new TableRow(1, TableRow.NOVALUE, "The creature drops to 0 hit points."),
				new TableRow(2, 3, "The creature drops to 0 hit points but is stable."),
				new TableRow(4, 5, "The creature is stunned until the end of its next turn."),
				new TableRow(6, 7, "The creature can't take reactions and has disadvantage on attack rolls and ability checks until the end of its next turn."),
				new TableRow(8, 10, "The creature can't take reactions until the end of its next turn."),
			});
			}
		}
	}
}