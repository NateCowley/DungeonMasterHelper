using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterHelper
{
    // In many of the lists located below, there are repeated elements. This was done 
    // in order to preserve the original tables as they were found in the source books for 
    // D&D 5e

    public static class Data
    {
		#region Utilities

		private static Random rand = new Random();

		public static bool DEVELOPMENT = true;

        private static string lowerFirstLetter(string str)
        {
            return str.First().ToString().ToLower() + str.Skip(1);
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
            if(numDice <= 0)
            {
                return -1;
            }

            int sum = 0;

            for(int i = 0; i < numDice; i++)
            {
                sum += rand.Next() % faceCount + 1;
            }

            return sum;
        }

        public static int statRoll4d6()
        {
            int sum = 0;
            int low = 20;

            for(int i = 0; i < 4; i++)
            {
                int next = roll(1, 6);
                sum += next;

                if(next < low)
                {
                    low = next;
                }
            }

            sum -= low;

            return sum;
        }

        public static string getRandomFrom(string[] arr)
        {
            return arr[rand.Next() % arr.Length];
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

		#endregion Utilities

		#region DMG

		// Chapter 1
		public static class World
        {
            public static readonly string[] forms_of_government =
            {
                "Autocracy",
                "Autocracy",
                "Autocracy",
                "Autocracy",
                "Autocracy",
                "Autocracy",
                "Autocracy",
                "Autocracy",
                "Bureaucracy",
                "Bureaucracy",
                "Bureaucracy",
                "Bureaucracy",
                "Bureaucracy",
                "Confederacy",
                "Confederacy",
                "Confederacy",
                "Confederacy",
                "Confederacy",
                "Confederacy",
                "Democracy",
                "Democracy",
                "Democracy",
                "Dictatorship",
                "Dictatorship",
                "Dictatorship",
                "Dictatorship",
                "Dictatorship",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Feudalism",
                "Gerontocracy",
                "Gerontocracy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Hierarchy",
                "Magocracy",
                "Magocracy",
                "Magocracy",
                "Matriarchy",
                "Matriarchy",
                "Militocracy",
                "Militocracy",
                "Militocracy",
                "Militocracy",
                "Militocracy",
                "Militocracy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Monarchy",
                "Oligarchy",
                "Oligarchy",
                "Oligarchy",
                "Oligarchy",
                "Patriarchy",
                "Patriarchy",
                "Meritocracy",
                "Meritocracy",
                "Meritocracy",
                "Plutocracy",
                "Plutocracy",
                "Republic",
                "Republic",
                "Republic",
                "Republic",
                "Republic",
                "Republic",
                "Republic",
                "Satrapy",
                "Satrapy",
                "Kleptocracy",
                "Theocracy",
                "Theocracy",
                "Theocracy",
                "Theocracy",
                "Theocracy"
            };

            public static readonly string[] forms_of_government_explanation =
            {
                // Autocracy
                "One hereditary ruler wields absolute power. The autocrat either is supported " +
                    "by a well-developed bureaucracy or military or stands as the only authority " +
                    "in an otherwise anarchic society. The dynastic ruler could be immortal or undead. " +
                    "Aundair and Karrnath, two kingdoms in the Eberron campaign setting, have autocrats " +
                    "with royal blood in their veins. Whereas Queen Aurala of Aundair relies on wizards " +
                    "and spies to enforce her will, Kaius, the vampire king of Karrnath, has a formidable " +
                    "army of living and undead soldiers under his command.",

                // Bureaucracy
                "Various departments compsoe the government, each responsible for an aspect of rule. " +
                    "The department heads, ministers, or secretaries answer to a figurehead autocrat " +
                    "or council.",

                // Confederacy
                "Each individual city or town within the confederacy governs itself, but all contribute " +
                    "to a league or federation that promotes (at least in theory) the common good of all " +
                    "member states. Conditions and attitudes toward the central government vary from place " +
                    "to place within the confederacy. The Lords' Alliance in the Forgotten Realms setting " +
                    "is a loose confederacy of cities, while the Mror Holds in the Eberron campaign setting " +
                    "is a confederacy of allied dwarf clans.",

                // Democracy
                "Citizens or their elected representatives determine the laws in a democracy. A bureaucracy " +
                    "or military carries out the day-to-day work of government, with positions filled through " +
                    "open elections.",

                // Dictatorship
                "One supreme ruler holds absolute authority, but his or her rule isn't necessarily dynastic. " +
                    "In other respects this resembles an autocracy. In the Greyhawk campaign setting, a " +
                    "half-demon named Iuz is the dictator of a conquered land that bears his name.",

                // Feudalism
                "The typical government of Europe in the Middle Ages, a feudalistic society consists of " +
                    "layers of lords and vassals. The vassals provide soldiers or scutage (payment in lieu " +
                    "of military service) to the lords, who in turn promise protection to their vassals.",

                // Gerontocracy
                "Elders preside over this society. In some cases, long-lived races such as elves or dragons " +
                    "are entrusted with the leadership of the land.",

                // Hierarchy
                "A feudal or bureaucratic government where every member, except one, is subordinate to " +
                    "another member. In the Draognlance campaign setting, the dragon armies of Krynn form " +
                    "a military hierarchy, with the Dragon Highlords as leaders under the dragon queen Takhisis.",

                // Kleptocracy
                "This governemtn is composed of groups or individuals primarily seeking wealth for themselves, " +
                    "often at the expense of their subjects. The grasping Bandit Kingddoms in the Greyhawk " +
                    "campaign setting are prime examples. A kingdom run by thieves' guilds would also fall " +
                    "into this category.",

                // Magocracy
                "The governing body is composed of spellcasters who rule directly as oligarchs or feudal " +
                    "lords, or participate in a democracy or bureaucracy. Examples include the Red Wizards " +
                    "of Thay in the Forgotten Realms campaign setting and the sorcerer-kings of Athas in " +
                    "the Dark Sun campaign setting.",

                // Matriarchy/Patriarchy
                "This society is governed by the eldest or most important members of one gender. Drow cities " +
                    "are examples of theocratic matriarchies, for each is ruled by a council of drow high " +
                    "priestesses who answer to Lolth, the Demon Queen of Spiders.",

                // Meritocracy
                "The most intelligent and educated people oversee the society, often with a bureaucracy to " +
                    "handle the day-to-day work of government. In the Forgotten Realms, scholarly monks " +
                    "preside over the fortress-library of Candlekeep, overseen by a master of lore called " +
                    "the Keeper.",

                // Militocracy
                "Military leaders run the nation under martial law, using the army and other armed forces. " +
                    "A militocracy might be based on an elite group of soldiers, an order of dragon riders, " +
                    "or a league of sea princes. Solamnia, a nation ruled by knights in the Dragonlance " +
                    "campaign setting, falls into this category.",

                // Monarchy
                "A single hereditary sovereign wears the crown. Unlike the autocrat, the monarch's powers " +
                    "are limited by law, and the ruler serves as the head of a democracy, feudal state, or " +
                    "militocracy. The kingdom of Breland, in the Eberron campaign setting, has both a " +
                    "parliament that makes laws and a monarch who enforces them.",

                // Oligarchy
                "A small number of absolute rulers share power, possibly dividing the land into districts " +
                    "or provinces under their control, or jointly ruling together. A group of adventurers " +
                    "who take control of a nation together migth form an oligarchy. The Free City of Greyhawk " +
                    "is an oligarchy composed of various faction leaders, wit ha Lord Mayor as its figurehead.",

                // Plutocracy
                "Society is governed by the wealthy. The elite form a ruling council, purchase representation " +
                    "at the court of a figurehead monarch, or rule by default because money is the true power " +
                    "in the realm. Many cities in the Forgotten Realms campaign setting, includeing Waterdeep " +
                    "and Baldur's Gate, are plutocracies.",

                // Republic
                "Government is entrusted to representatives of an established electorate who rule on behalf of " +
                    "the electors. Any democracy in which only landowners or certain classes can vote could be " +
                    "considered a republic.",

                // Satrapy
                "Conquerors and representatives of another government wield power, ruling the settlement or " +
                    "region as part of a larger empire. The satraps are bureaucrats and military officers, or " +
                    "unusual characters or monsters. The cities of Highport and Suderham in the Greyhawk " +
                    "campaign setting are satrapies controlled by agents of a visious gane of marauders known " +
                    "as the Slave Lords.",

                // Theocracy
                "Rulership falls to a direct representative or a collection of agents of a deity. The centers " +
                    "of power in a theocracy are usually located on sacred sites. In the Eberron campaign " +
                    "setting, the nation of Thrane is a theocracy devoted to the Silver Flame, a divine spirit " +
                    "that resides in Thrane's capital of Flamekeep."
            };

            public static readonly string[] world_shaking_events =
            {
                "Rise of a leader or an era",
                "Fall of a leader or an era",
                "Cataclysmic disaster",
                "Assault or invasion",
                "Rebellion, revolution, overthrow",
                "Extinction or depletion",
                "New organization",
                "Discovery, expansion, invention",
                "Prediction, omen, prophecy",
                "Myth and legend"
            };

            public static readonly string[] leader_types =
            {
                "Political",
                "Religious",
                "Military",
                "Crime/underworld",
                "Art/culture",
                "Philosophy/learning/magic"
            };

            public static readonly string[] cataclysmic_disasters =
            {
                "Earthquake",
                "Famin/drought",
                "Fire",
                "Flood",
                "Plauge/disease",
                "Rain of fire (meteoric impact)",
                "Storm (hurricane, tornado, tsunami)",
                "Volcanic eruption",
                "Magic gone awry or a planar warp",
                "Divine judgment"
            };

            public static readonly string[] invading_forces =
            {
                "A criminal enterprise",
                "Monsters or a unique monster",
                "A planar threat",
                "A past adversary reawakened, reborn, or resurgent",
                "A splinter faction",
                "A savage tribe",
                "A secret society",
                "A traitorous ally"
            };

            public static readonly string[] extinction_or_depletion =
            {
                "A kind of animal (insect, bird, fish, livestock",
                "Habitable land",
                "Magic or magic-users (all magic, specific kinds, or schools of magic",
                "A mineral resource (gems, metals, ores)",
                "A type of monster (unicorn, manticore, dragon)",
                "A people (family line, clan, culture, race)",
                "A kind of plant(crop, tree, herb, forest)",
                "A waterway (river, lake, ocean"
            };

            public static readonly string[] new_organizations =
            {
                "Crime syndicate/bandit confederacy",
                "Guild (masons, apothecaries, goldsmiths)",
                "Magical circle/society",
                "Military/knightly order",
                "New family dynasty/tribe/clan",
                "Philosophy/discipline dedicated to a principle or ideal",
                "Realm (village, town, duchy, kingdom",
                "Religion/sect/denomination",
                "School/university",
                "Secret society/cult/cabal"
            };

            public static readonly string[] discoveries =
            {
                "Ancient ruin/lost city of a legendary race",
                "Animal/monster/magical mutation",
                "Invention/technology/magic (helpful, destructive)",
                "New (or forgotten) god or planar entity",
                "New (or rediscovered) artifact or religious relic",
                "New land (island, continent, lost world, demiplane)",
                "Otherworldly object (planar portal, alien spacecraft)",
                "People (race, tribe, lost civilization, colony)",
                "Plant (miracle herb, fungal parasite, sentient plant)",
                "Resource or wealth (gold, gems, mithral)"

            };
        }

        // Chapter 2
        public static class Multiverse
        {
            public static readonly string[] astral_color_pools_plane =
            {
                "Ysgard",
                "Limbo",
                "Pandemonium",
                "The Abyss",
                "Carceri",
                "Hades",
                "Gehenna",
                "The Nine Hells",
                "Acheron",
                "Mechanus",
                "Arcadia",
                "Mount Celestia",
                "Bytopia",
                "Elysium",
                "The Beastlands",
                "Arborea",
                "The Outlands",
                "Ethereal Plane",
                "Material Plane",
                "Material Plane"
            };

            public static readonly string[] astral_color_pools_pool_color =
            {
                "Indigo",
                "Jet black",
                "Magenta",
                "Amethyst",
                "Olive",
                "Rust",
                "Russet",
                "Ruby",
                "Flame red",
                "Diamond blue",
                "Saffron",
                "Gold",
                "Amber",
                "Orange",
                "Emerald green",
                "Sapphire blue",
                "Leather brown",
                "Spiraling white",
                "Silver",
                "Silver"
            };

            public static readonly string[] psychic_wind_effects_location_effect =
            {
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Diverted; add 1d6 hours to travel time",
                "Blown off course; add 3d10 hours to travel time",
                "Blown off course; add 3d10 hours to travel time",
                "Blown off course; add 3d10 hours to travel time",
                "Blown off course; add 3d10 hours to travel time",
                "Lost; at the end of the travel time, characters arrive at " +
                    "a location other than the intended destination",
                "Lost; at the end of the travel time, characters arrive at " +
                    "a location other than the intended destination",
                "Lost; at the end of the travel time, characters arrive at " +
                    "a location other than the intended destination",
                "Lost; at the end of the travel time, characters arrive at " +
                    "a location other than the intended destination",
                "Sent through color pool to a random plane (roll on the Astral Color Pools table)",
                "Sent through color pool to a random plane (roll on the Astral Color Pools table)",
                "Sent through color pool to a random plane (roll on the Astral Color Pools table)",
                "Sent through color pool to a random plane (roll on the Astral Color Pools table)",
            };

            public static readonly string[] psychic_wind_effects_mental_effect =
            {
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself",
                "Short-term madness (see chapter 8)",
                "Short-term madness (see chapter 8)",
                "11 (2d10) psychic damage",
                "11 (2d10) psychic damage",
                "22 (4d10) psychic damage",
                "22 (4d10) psychic damage",
                "Long-term madness (see chapter 8)",
                "Long-term madness (see chapter 8)",
                "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake",
                "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake"
            };

            public static readonly string[] ethereal_curtains_plane =
            {
                "Material Plane",
                "Shadowfell",
                "Feywild",
                "Plane of Air",
                "Plane of Earth",
                "Plane of Fire",
                "Plane of Water",
                "Elemental Chaos"
            };

            public static readonly string[] ethereal_curtains_color_of_curtain =
            {
                "Bright turquoise",
                "Dusky gray",
                "Opulescent white",
                "Pale blue",
                "Reddish-brown",
                "Orange",
                "Green",
                "Swirling mix of colors"
            };

            public static readonly string[] ether_cyclone =
            {
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Extended journey",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Blown to the Border Ethereal of a random plane (roll on the Ethereal Curtains table",
                "Hurled into the Astral Plane"
            };

            public static readonly string[] feywild_time_warp =
            {
                "Days become minutes",
                "Days become minutes",
                "Days become hours",
                "Days become hours",
                "Days become hours",
                "Days become hours",
                "No change",
                "No change",
                "No change",
                "No change",
                "No change",
                "No change",
                "No change",
                "Days become weeks",
                "Days become weeks",
                "Days become weeks",
                "Days become weeks",
                "Days become months",
                "Days become months",
                "Days become years"
            };

            public static string getPsychicWindEffectsLocationEffect()
            {
                int num = Data.rand.Next() % 20 + 1;

                if(num < 9)
                {
                    return "Diverted; add " + ((rand.Next() % 6) + 1) + " hours to travel time";
                }
                else if(num < 13)
                {
                    return "Blown off course; add " + (((rand.Next() % 10) + 1) * 3) + " hours to travel time";
                }
                else if(num < 17)
                {
                    return "Lost; at the end of the travel time, characters arrive at a location other than the intended destination";
                }
                else
                {
                    num = rand.Next() % astral_color_pools_plane.Length;

                    string str = "";

                    if(num > 16)
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

                if(num < 13)
                {
                    return "Extended journey";
                }
                else if(num < 20)
                {
                    return "Blown to the Border Ethereal of the " + ethereal_curtains_plane[rand.Next() % ethereal_curtains_plane.Length];
                }
                else
                {
                    return "Hurled into the Astral Plane";
                }
            }

            public static string getShadowfellDespair()
            {
                int num = Data.rand.Next() % 6 + 1;

                if(num < 4)
                {
                    return "Apathy. The character has disadvantage on death saving throws and on Dexterity checks for initiative, and gains the following flaw: \"I don't believe I can make a difference to anyone or anything.\"";
                }
                else if(num < 6)
                {
                    return "Dread. The character has disadvantage on all saving throws and gains the following flaw: \"I am convinced that this place is going to kill me.\"";
                }
                else
                {
                    return "Madness. The character has disadvantage on ability checks and saving throws that use Intelligence, Wisdom, or Charisma, and gains the following flaw: \"I can't tell what's real anymore\"";
                }
            }

            public static string getAbyssalCorruption()
            {
                int num = Data.rand.Next() % 10 + 1;

                if(num < 5)
                {
                    return "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\"";
                }
                else if(num < 8)
                {
                    return "Bloodlust. The character gains the following flaw: \"I enjoy killing for its own sake, and once I start, it's hard to stop\"";
                }
                else if(num < 10)
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
            public static readonly string[] dungeon_goals =
            {
                "Stop the dungeon's monstrous inhabitatns from raiding the surface world.",
                "Foil a villain's evil scheme.",
                "Destroy a magical threat inside the dungeon.",
                "Acquire treasure.",
                "Find a particular item for a specific purpose.",
                "Retrieve a stolen item hidden in the dungeon.",
                "Find information needed for a special purpose.",
                "Rescue a captive.",
                "Discover the fate of a previous adventuring party.",
                "Find an NPC who disappeared in the area.",
                "Slay a dragon or some other challenging monster.",
                "Discover the nature and origin of a strange location or phenomenon.",
                "Pursue fleeing foes taking refuge in the dungeon.",
                "Escape from captivity in the dungeon.",
                "Clear a ruin so it can be rebuilt and reoccupied.",
                "Discover why a villain is interested in the dungeon.",
                "Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time.",
                "Parley with a villain in the dungeon.",
                "Hide from a threat outside the dungeon.",
                "Roll twice, ignoring results of 20."
            };

            public static readonly string[] wilderness_goals =
            {
                "Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why).",
                "Assess the scope of a natural or unnatural disaster.",
                "Escort an NPC to a destination.",
                "Arrive at a destination without being seen by the villain's forces.",
                "Stop monsters from raiding caravans and farms.",
                "Establish trade with a distant town.",
                "Map a new land.",
                "Find a place to establish a colony",
                "Find a natural resource",
                "Hunt a specific monster.",
                "Return home from a distant place.",
                "Obtain information from a reclusive hermit.",
                "Find an object that was lost in the wilds.",
                "Discover the fate of a missing group of explorers.",
                "Pursue fleeing foes.",
                "Assess the size of an approaching army.",
                "Escape the reign of a tyrant.",
                "Protect a wilderness site from attackers.",
                "Roll twice, ignoring results of 20."
            };

            public static readonly string[] other_goals =
            {
                "Seize control of a fortified location such as a fortress, town, or ship.",
                "Defend a location from attackers.",
                "Retrieve an object from inside a secure location in a settlement.",
                "Retrieve an object from a caravan.",
                "Salvage an object or goods from a lost vessel or caravan.",
                "Break a prisoner out of a jail or prison camp.",
                "Escape from a jail or prison camp.",
                "Successfully travel through an obstacle course to gain recognition or reward.",
                "Infiltrate a fortified location.",
                "Find the source of strange occurrences in a haunted house or other location.",
                "Interfere wit hthe operation of a business.",
                "Rescue a character, monster, or object from a natural or unnatural disaster."
            };

            public static readonly string[] adventure_villains =
            {
                "Beast or monstrosity with no particular agenda",
                "Aberration bent on corruption or domination",
                "Fiend bent on corruption or destruction",
                "Dragon bent on domination and plunder",
                "Giant bend on plunder",
                "Undead with any agenda",
                "Undead with any agenda",
                "Fey with a mysterious goal",
                "Humanoid cultist",
                "Humanoid cultist",
                "Humanoid conqueror",
                "Humanoid conqueror",
                "Humanoid seeking revenge",
                "Humanoid schemer seeking to rule",
                "Humanoid schemer seeking to rule",
                "Humanoid criminal mastermind",
                "Humanoid raider or ravager",
                "Humanoid raider or ravager",
                "Humanoid under a curse",
                "Misguided humanoid zealot"
            };

            public static readonly string[] adventure_allies =
            {
                "Skilled adventurer",
                "Inexperienced adventurer",
                "Enthusiastic commoner",
                "Soldier",
                "Priest",
                "Sage",
                "Revenge seeker",
                "Raving lunatic",
                "Celestial ally",
                "Fey ally",
                "Disguised monster",
                "Villain posing as an ally"
            };

            public static readonly string[] adventure_patrons =
            {
                "Retired adventurer",
                "Retired adventurer",
                "Local ruler",
                "Local ruler",
                "Military officer",
                "Military officer",
                "Temple official",
                "Temple official",
                "Sage",
                "Sage",
                "Respected elder",
                "Respected elder",
                "Deity or celestial",
                "Mysterious fey",
                "Old friend",
                "Former teacher",
                "Parent or other family member",
                "Desperate commoner",
                "Embattled merchant",
                "Villain posing as a patron"
            };

            public static readonly string[] adventure_introduction =
            {
                "While traveling in the wilderness, the characters fall into a sinkhole that opens " +
                    "beneath their feet, dropping them into the adventure location.",
                "While traveling in the wilderness, the characters notice the entrance to the adventure " +
                    "location.",
                "While traveling on a road, the characters are attacked by monsters that flee into the " +
                    "nearby adventure location.",
                "The adventurers find a map on a dead body. In addition to the map setting up the " +
                    "adventure, the adventure's villain wants the map.",
                "A mysterious magic item or a cruel villain teleports the characters to the adventure location",
                "A stranger approaches the characters in a tavern and urges them toward the adventure location.",
                "A town or village needs volunteers to go to the adventure location.",
                "An NPC the characters care about needs them to go to the adventure location.",
                "An NPC the characters must obey orders them to go to the adventure location.",
                "An NPC the characters respect asks them to go to the adventure location.",
                "One night, the characters all dream about entering the adventure location.",
                "A ghost appears and terrorizes a village. Research reveals that it can be put to rest " +
                    "only by entering the adventure location."
            };

            public static readonly string[] adventure_climax =
            {
                "The adventurers confront the main villain and a group of minions in a bloody battle to the finish.",
                "The adventurers chase the villain while dodgin obstacles designed to thwart them, leading to a final confrontation in or outside the villain's refuge.",
                "The actions of the adventurers or the villain result in a cataclysmic event that the adventurers must escape.",
                "The adventurers race to the site where the villain is bringing a master plan to its conclusion, arriving just as that plan is about to be completed.",
                "The villain and two or three lieutenants perform separate rites in a large room. The adventurers must disrupt all the rites at the same time.",
                "An ally betrays the adventurers as they're about to achieve their goal (Use this climax carefully, and don't overuse it).",
                "A portal opens to another plane of existence. Creatures on the other side spill out, forcing the adventurers to close the portal and deal with the villain at the same time.",
                "Traps, hazards, or animated objects turn against the adventurers while the main villain attacks.",
                "The dungeon begins to collapse while the adventurers face the main villain, who attempts to escape in the chaos.",
                "A threat more powerful than the adventurers appears, destroys the main villain, and then turns its attention on the characters.",
                "The adventurers must choose whether to pursue the fleeing main villain or save an NPC they care about or a group of innocents.",
                "The adventurers must discover the main villain's secret weakness before they can hope to defeat that villain."
            };

            public static readonly string[] event_based_villain_actions =
            {
                "Big event",
                "Crime spree",
                "Growing corruption",
                "One and done",
                "Serial crimes",
                "Step by step"
            };

            public static readonly string[] event_based_villain_actions_descriptions =
            {
                "Big Event. The villain's plans come to fruition during a festival, an astrological event, " +
                    "a holy (or unholy) rite, a royal wedding, the birth of a child, or some similar fixed " +
                    "time. The villain's activities up to that point are geared toward preparation for this event.",
                "Crime Spree. The villain commits acts taht become bolder and more heinous over time. " +
                    "A killer might start out by targeting the destitute in the city slums before moving " +
                    "up to a massacre in the marketplace, increasing the horror and the body count each time.",
                "Growing Corruption. As time passes, the villain's power and influence grow, affecting " +
                    "more victims across a larger area. This might take the form of armies conquering " +
                    "new territory, an evil cult recruiting new members, or a spreading plague. A " +
                    "pretender to the throne might attempt to secure the support of the kingdom's " +
                    "nobility in the days or weeks leading up to a coup, or a guild leader could " +
                    "corrupt the members of a town council or bribe officers of the watch.",
                "One and Done. The villain commits a single crime and then tries to avoid the " +
                    "consequences. Instead of an ongoing plan to commit more crimes, the villain's " +
                    "goal is to lie low or flee the scene.",
                "Serial Crimes. The villain commits crimes one after the other, but these acts are " +
                    "repetitive in nature, rather than escalating to greater heights of depravity. " +
                    "The trick to catching such a villain lies in determining the pattern underlying " +
                    "the crimes. Though serial killers are a common example of this type of villain, " +
                    "your villain could be a serial arsonist favoring a certain type of building, a " +
                    "magical sickness that affects spellcasters who cast a specific spell, a thief " +
                    "that targets a certain kind of merchant, or a doppelganger kidnapping and " +
                    "impersonating one noble after another.",
                "Step by Step. In pursuit of its goal, the villain carries out a specific set of " +
                    "actions in a particular sequence. A wizard might steal the items needed to " +
                    "create a phylactery and become a lich, or a cultist might kidnap the priests " +
                    "of seven good-aligned gods as a sacrifice. Alternativly, the villain could be " +
                    "following a trail to find the object of its revenge, killing one victim after " +
                    "another while moving ever closer to the real target."
            };

            public static readonly string[] event_based_goals =
            {
                "Bring the villain to justice.",
                "Clear the name of an innocent NPC.",
                "Protect or hide an NPC.",
                "Protect an object.",
                "Discover the nature and origin of a strange phenomenon that might be the villain's doing.",
                "Find a wanted fugitive.",
                "Overthrow a tyrant",
                "Uncover a conspiracy to overthrow a ruler.",
                "Negotiate peace between enemy nations or feuding families.",
                "Secure aid from a ruler or council.",
                "Help a villain find redemption",
                "Parley with a villain.",
                "Smuggle weapons to rebel forces.",
                "Stop a band of smugglers.",
                "Gather intelligence on an enemy force.",
                "Win a tournament",
                "Determine the villain's identity.",
                "Locate a stolen item.",
                "Make sure a wedding goes off without a hitch.",
                "Roll twice, ignoring results of 20."
            };

            public static readonly string[] framing_events =
            {
                "Anniversary of a monarch's reign",
                "Anniversary of a monarch's reign",
                "Anniversary of an important event",
                "Anniversary of an important event",
                "Arena event",
                "Arena event",
                "Arrival of a caravan or ship",
                "Arrival of a caravan or ship",
                "Arrival of a circus",
                "Arrival of a circus",
                "Arrival of an important NPC",
                "Arrival of an important NPC",
                "Arrival of marching modrons",
                "Arrival of marching modrons",
                "Artistic performance",
                "Artistic performance",
                "Athletic event",
                "Athletic event",
                "Birth of a child",
                "Birth of a child",
                "Birthday of an important NPC",
                "Birthday of an important NPC",
                "Civic festival",
                "Civic festival",
                "Comet appearance",
                "Comet appearance",
                "Commemoration of a past tragedy",
                "Commemoration of a past tragedy",
                "Consecration of a new temple",
                "Consecration of a new temple",
                "Coronation",
                "Coronation",
                "Council meeting",
                "Council meeting",
                "Equinox or solstice",
                "Equinox or solstice",
                "Execution",
                "Execution",
                "Fertility festival",
                "Fertility festival",
                "Full moon",
                "Full moon",
                "Funeral",
                "Funeral",
                "Graduation of cadets or wizards",
                "Graduation of cadets or wizards",
                "Harvest festival",
                "Harvest festival",
                "Holy day",
                "Holy day",
                "Investiture of a knight or other noble",
                "Investiture of a knight or other noble",
                "Lunar eclipse",
                "Lunar eclipse",
                "Midsummer festival",
                "Midsummer festival",
                "Midsummer festival",
                "Midsummer festival",
                "Midwinter festival",
                "Midwinter festival",
                "Migration of monsters",
                "Migration of monsters",
                "Monarch's ball",
                "Monarch's ball",
                "New moon",
                "New moon",
                "New year",
                "New year",
                "Pardoning of a prisoner",
                "Pardoning of a prisoner",
                "Planar conjunction",
                "Planar conjunction",
                "Planetary alignment",
                "Planetary alignment",
                "Priestly investiture",
                "Priestly investiture",
                "Procession of ghosts",
                "Procession of ghosts",
                "Remembrance for soldiers lost in war",
                "Remembrance for soldiers lost in war",
                "Royal address or proclamation",
                "Royal address or proclamation",
                "Royal audience day",
                "Royal audience day",
                "Signing a treaty",
                "Signing a treaty",
                "Solar eclipse",
                "Solar eclipse",
                "Tournament",
                "Tournament",
                "Tournament",
                "Trial",
                "Trial",
                "Trial",
                "Violent uprising",
                "Violent uprising",
                "Wedding or wedding anniversary",
                "Wedding or wedding anniversary",
                "Concurrence of two events (roll twice, ignoring results of 99 or 100)",
                "Concurrence of two events (roll twice, ignoring results of 99 or 100)"
            };

            public static readonly string[] moral_quandaries =
            {
                "Ally quandary",
                "Ally quandary",
                "Ally quandary",
                "Friend quandary",
                "Friend quandary",
                "Friend quandary",
                "Honor quandary",
                "Honor quandary",
                "Honor quandary",
                "Honor quandary",
                "Honor quandary",
                "Honor quandary",
                "Rescue quandary",
                "Rescue quandary",
                "Rescue quandary",
                "Rescue quandary",
                "Respect quandary",
                "Respect quandary",
                "Respect quandary",
                "Respect quandary"
            };

            public static readonly string[] moral_quandaries_descriptions =
            {
				"Ally Quandary. The adventurers have a better chance of achieving their goal with the help " +
					"of two individuals whose expertise is all but essential. However, these two NPCs hate " +
					"each other and refuse to work together even if the fate of the world hangs in the " +
					"balance. The adventurers must choose the NPC that is most likely to help them accomplish their goal.",
				"Friend Quandary. An NPC that one or more of the characters cares about makes an impossible " +
					"demand on the characters. A love interest might demand that a character turn away from " +
					"a dangerous quest. A dear friend might plead with the characters to spare the villain's " +
					"life, to prove that they are better than the villain. A weak NPC might beg for a chance " +
					"to win favor from the characters by undertaking a dangerous but essential mission.",
				"Honor Quandary. A character is forced to choose between victory and a personal oath or code " +
					"of honor. A paladin who has sworn the Oath of Virtue might realize that the clearest path " +
					"to success lies in deceit and subterfuge. A loyal cleric might be tempted to disobey the " +
					"orders of his or her faith. If you present this quandary, be sure to provide an opportunity " +
					"for a character to atone for violating his or her oath.",
				"Rescure Quandary. The adventurers must choose between catching or hurting the villain and saving " +
					"innocent lives. For example, the adventurers might learn that the villain is camped nearby, " +
					"but they also learn that another part of the villain's forces is about to march into a village " +
					"and burn it to the ground. The characters must choose between taking out the villain or " +
					"protecting innocent villagers, some of whom might be friends or family members.",
				"Respect Quandary. Two important allies give conflicting directions or advice to the adventurers. " +
					"Perhaps the high priest counsels the characters to negotiate peace with militaristic elves " +
					"in the nearby forest, while a veteran warrior urges them to prove their strength with a " +
					"decisive first strike. The adventurers can't follow both courses, and whichever ally they " +
					"choose, the other loses respect for them and might no longer aid them."
            };

            public static readonly string[] twists =
            {
                "The adventurers are racing against other creatures with the same or opposite goal.",
                "The adventurers become responsible for the safety of a noncombatant NPC.",
                "The adventurers are prohibited from killing the villain, but the villain has no compunctions about killing them.",
                "The adventurers have a time limit.",
                "The adventurers have received false or extraneous information.",
                "Completing an adventure goal fulfills a prophecy or prevents the fulfillment of a prophecy.",
                "The adventurers have two different goals, but they can complete only one.",
                "Completing the goal secretly helps the villain.",
                "The adventurers must cooperate with a known enemy to achieve the goal.",
                "The adventurers are under magical compulsion (such as a geas spell) to complete their goal."
            };

            public static readonly string[] side_quests =
            {
                "Find a specific item rumored to be in the area.",
                "Retrieve a stolen item in the villain's possession",
                "Receive information from an NPC in the area.",
                "Rescue a captive.",
                "Discover the fate of a missing NPC.",
                "Slay a specific monster.",
                "Discover the nature and origin of a strange phenomenon in the area.",
                "Secure the aid of a character or creature in the area."
            };

            public static string getDungeonGoal()
            {
                int num = Data.rand.Next() % dungeon_goals.Length;

                if(num == 19)
                {
                    num = Data.rand.Next() % (dungeon_goals.Length - 1);

                    return dungeon_goals[Data.rand.Next() % (dungeon_goals.Length - 1)] + " And " +
                        dungeon_goals[num].First().ToString().ToLower() + dungeon_goals[num].Skip(1);
                }

                return dungeon_goals[num];
            }

            public static string getWildernessGoal()
            {
                int num = Data.rand.Next() % wilderness_goals.Length;

                if(num == 0)
                {
                    string dg = getDungeonGoal();
                    dg = dg.First().ToString().ToLower() + dg.Skip(1);
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
                            strs[i] = getDungeonGoal();
                            strs[i] = strs[i].First().ToString().ToLower() + strs[i].Skip(1);
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

                    return event_based_goals[Data.rand.Next() % (event_based_goals.Length - 1)] + " And " +
                        event_based_goals[num].First().ToString().ToLower() + event_based_goals[num].Skip(1);
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
                        framing_events[num].First().ToString().ToLower() + framing_events[num].Skip(1);
                }

                return framing_events[num];
            }

            public static string getMoralQuandaries()
            {
                int num = Data.rand.Next() % 20 + 1;

                if(num < 4)
                {
                    return "Ally quandary";
                }
                else if(num < 7)
                {
                    return "Friend quandary";
                }
                else if(num < 13)
                {
                    return "Honor quandary";
                }
                else if(num < 17)
                {
                    return "Rescue quandary";
                }
                else
                {
                    return "Respect quandary";
                }
            }
        }

        // Chapter 4
        public static class NPC
        {
            public static readonly string[] npc_appearance = 
            {
                "Distinctive jewelry: earrings, necklace, circlet, bracelets",
                "Piercings",
                "Flamboyant or outlandish clothes",
                "Formal, clean clothes",
                "Ragged, dirty clothes",
                "Pronounced scar",
                "Missing teeth",
                "Missing fingers",
                "Unusual eye color (or two different colors)",
                "Tattoos",
                "Birthmark",
                "Unusual skin color",
                "Bald",
                "Braided beard or hair",
                "Unusual hair color",
                "Nervous eye twitch",
                "Distinctive nose",
                "Distinctive posture (crooked or rigid)",
                "Exceptionally beautiful",
                "Exceptionally ugly"
            };

            public static readonly string[] npc_high_abilities =
            {
                "Strength - powerful, brawny, strong as an ox",
                "Dexterity - lithe, agile, graceful",
                "Constitution - hardy, hale, healthy",
                "Intelligence - studious, learned, inquisitive",
                "Wisdom - perceptive, spiritual, insightful",
                "Charisma - persuasive, forceful, born leader"
            };

            public static readonly string[] npc_low_abilities =
            {
                "Strength - feeble, scrawny",
                "Dexterity - clumsy, fumbling",
                "Constitution - sickly, pale",
                "Intelligence - dim-witted, slow",
                "Wisdom - oblivious, absentminded",
                "Charisma - dull, boring"
            };

            public static readonly string[] npc_talents =
            {
                "Plays a musical instrument",
                "Speaks several languages fluently",
                "Unbelievably lucky",
                "Perfect memory",
                "Great with animals",
                "Great with children",
                "Great at solving puzzles",
                "Great at one game",
                "Great at impersonations",
                "Draws beautifully",
                "Sings beautifully",
                "Drinks everyone under the table",
                "Expert carpenter",
                "Expert cook",
                "Expert dart thrower and rock skipper",
                "Expert juggler",
                "Skilled acto and master of disguise",
                "Skilled dancer",
                "Knows thieves' cant"
            };

            public static readonly string[] npc_mannerisms =
            {
                "Prone to singing, whistling, or humming quietly",
                "Speaks in rhyme or some other peculiar way",
                "Particularly low or high voice",
                "Slurs words, lisps, or stutters",
                "Enunciates overly clearly",
                "Speaks loudly",
                "Whispers",
                "Uses flowery speech or long words",
                "Frequently uses the wrong word",
                "Uses colorful oaths and exclamations",
                "Makes constant jokes or puns",
                "Prone to predictions of doom",
                "Fidgets",
                "Squints",
                "Stares into the distance",
                "Chews something",
                "Paces",
                "Taps fingers",
                "Bites fingernails",
                "Twirls hair or tugs beard"
            };

            public static readonly string[] npc_interaction_traits =
            {
                "Argumentative",
                "Arrogant",
                "Blustering",
                "Rude",
                "Curious",
                "Friendly",
                "Honest",
                "Hot tempered",
                "Irritable",
                "Ponderous",
                "Quiet",
                "Suspicious"
            };

            public static readonly string[] npc_ideals_good =
            {
                "Beauty",
                "Charity",
                "Greater good",
                "Life",
                "Respect",
                "Self-sacrifice"
            };

            public static readonly string[] npc_ideals_evil =
            {
                "Domination",
                "Greed",
                "Might",
                "Pain",
                "Retribution",
                "Slaughter"
            };

            public static readonly string[] npc_ideals_lawful =
            {
                "Community",
                "Fairness",
                "Honor",
                "Logic",
                "Responsibility",
                "Tradition"
            };

            public static readonly string[] npc_ideals_chaotic =
            {
                "Change",
                "Creativity",
                "Freedom",
                "Independence",
                "No limits",
                "Whimsy"
            };

            public static readonly string[] npc_ideals_neutral =
            {
                "Balance",
                "Knowledge",
                "Live and let live",
                "Moderation",
                "Neutrality",
                "People"
            };

            public static readonly string[] npc_ideals_other =
            {
                "Aspiration",
                "Discovery",
                "Glory",
                "Nation",
                "Redemption",
                "Self-knowledge"
            };

            public static readonly string[][] ideals =
            {
                npc_ideals_good,
                npc_ideals_evil,
                npc_ideals_lawful,
                npc_ideals_chaotic,
                npc_ideals_neutral,
                npc_ideals_other
            };

            public static readonly string[] npc_bonds =
            {
                "Dedicated to fulfilling a personal life goal",
                "Protective of close family members",
                "Protective of colleagues or compatriots",
                "Loyal ot a benefactor, patron, or employer",
                "Captivated by a romantic interest",
                "Drawn to a special place",
                "Protective of a sentimental keepsake",
                "Protective of a valuable possession",
                "Out for revenge"
            };

            public static readonly string[] npc_flaws_and_secrets =
            {
                "Forbidden love or susceptibility to romance",
                "Enjoys decadent pleasures",
                "Arrogance",
                "Envies another creature's possessions or station",
                "Overpowering greed",
                "Prone to rage",
                "Has a powerful enemy",
                "Specific phobia",
                "Shameful or scandalous history",
                "Secret crime or misdeed",
                "Possession of forbidden lore",
                "Foolhardy bravery"
            };

            public static readonly string[] villains_scheme_objective =
            {
                "Immortality",
                "Influence",
                "Magic",
                "Mayhem",
                "Passion",
                "Power",
                "Revenge",
                "Wealth"
            };

            public static readonly string[] villains_scheme_immortality =
            {
                "Acquire a legendary item to prolog life",
                "Ascend to godhood",
                "Become undead or obtain a younger body",
                "Steal a planar creature's essence"
            };

            public static readonly string[] villains_scheme_influence =
            {
                "Seize a position of power or title",
                "Win a contest or tournament",
                "Win favor with a powerful individual",
                "Place a pawn in a position of power"
            };

            public static readonly string[] villains_scheme_magic =
            {
                "Obtain an ancient artifact",
                "Build a construct or magical device",
                "Carry out a deity's wishes",
                "Offer sacrifices to a deity",
                "Contact a lost deity or power",
                "Open a gate to another world"
            };

            public static readonly string[] villains_scheme_mayhem =
            {
                "Fulfill an apocalyptic prophecy",
                "Enact the vengeful will of a god or patron",
                "Spread a vile contagion",
                "Overthrow a government",
                "Trigger a natrual disaster",
                "Utterly destroy a bloodline or clan"
            };

            public static readonly string[] villains_scheme_passion =
            {
                "Prolong the life of a loved one",
                "Prove worthy of another person's love",
                "Raise or restore a dead loved one",
                "Destroy rivals for another person's affection"
            };

            public static readonly string[] villains_scheme_power =
            {
                "Conquer a region or incite a rebellion",
                "Seize control of an army",
                "Become the power behind the throne",
                "Gain the favor of a ruler"
            };

            public static readonly string[] villains_scheme_revenge =
            {
                "Avenge a past humiliation or insult",
                "Avenge a past imprisonment or injury",
                "Avenge the death of a loved one",
                "Retrieve stolen property and punish the thief"
            };

            public static readonly string[] villains_scheme_wealth =
            {
                "Control natrual resources or trade",
                "Marry into wealth",
                "Plunder ancient ruins",
                "Steal land, goods, or money"
            };

            public static readonly string[][] villains_scheme =
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

            public static readonly string[] villains_methods_agricultural_devestation =
            {
                "Blight",
                "Crop failure",
                "Drought",
                "Famine"
            };

            public static readonly string[] villains_methods_assault_or_beatings =
            {
                "Assault or beatings"
            };

            public static readonly string[] villains_methods_bounty_hunting_or_assassination =
            {
                "Bounty hunting or assassination"
            };

            public static readonly string[] villains_methods_captivity_or_coercion =
            {
                "Bribery",
                "Enticement",
                "Eviction",
                "Imprisonment",
                "Kidnapping",
                "Legal intimidation",
                "Press ganges",
                "Shackling",
                "Slavery",
                "Threats or harassment"
            };

            public static readonly string[] villains_methods_conficence_scams =
            {
                "Breach of contract",
                "Cheating",
                "Fast talking",
                "Fine print",
                "Fraud or swindling",
                "Quackery or tricks"
            };

            public static readonly string[] villains_methods_defamation =
            {
                "Framing",
                "Gossiping or slander",
                "Humiliation",
                "Libel or insults"
            };

            public static readonly string[] villains_methods_dueling =
            {
                "Dueling"
            };

            public static readonly string[] villains_methods_execution =
            {
                "Beheading",
                "Burning at the stake",
                "Burying alive",
                "Crucifixion",
                "Drawing and quartering",
                "Hanging",
                "Impalement",
                "Sacrifice (living)"
            };

            public static readonly string[] villains_methods_impersonation_or_disguise =
            {
                "Impersonation or disguise"
            };

            public static readonly string[] villains_methods_lying_or_perjury =
            {
                "Lying or perjury"
            };

            public static readonly string[] villains_methods_magical_mayhem =
            {
                "Hauntings",
                "Illusions",
                "Infernal bargains",
                "Mind control",
                "Petrification",
                "Raising or animating the dead",
                "Summoning monsters",
                "Weather control"
            };

            public static readonly string[] villains_methods_murder =
            {
                "Assassination",
                "Cannibalism",
                "Dismemberment",
                "Drowning",
                "Electrocution",
                "Euthanasia (involuntary)",
                "Disease",
                "Poisoning",
                "Stabbing",
                "Strangulation or suffocation"
            };

            public static readonly string[] villains_methods_neglect =
            {
                "Neglect"
            };

            public static readonly string[] villains_methods_politics =
            {
                "Betrayal or treason",
                "Conspiracy",
                "Espionage or spying",
                "Genocide",
                "Oppression",
                "Raising taxes"
            };

            public static readonly string[] villains_methods_religion =
            {
                "Curses",
                "Desecration",
                "False gods",
                "Heresy or cults"
            };

            public static readonly string[] villains_methods_stalking =
            {
                "Stalking"
            };

            public static readonly string[] villains_methods_theft_or_property_crime =
            {
                "Arson",
                "Blackmail or extortion",
                "Burglary",
                "Counterfeiting",
                "Highway robbery",
                "Looting",
                "Mugging",
                "Poaching",
                "Seizing property",
                "Smuggling"
            };

            public static readonly string[] villains_methods_torture =
            {
                "Acid",
                "Blinding",
                "Branding",
                "Racking",
                "Thumbscrews",
                "Whipping"
            };

            public static readonly string[] villains_methods_vice =
            {
                "Adultery",
                "Drugs or alcohol",
                "Gambling",
                "Seduction"
            };

            public static readonly string[] villains_methods_warfare =
            {
                "Ambush",
                "Invasion",
                "Massacre",
                "Mercenaries",
                "Rebellion",
                "Terrorism"
            };

            public static readonly string[][] villains_methods =
            {
                villains_methods_agricultural_devestation,
                villains_methods_assault_or_beatings,
                villains_methods_bounty_hunting_or_assassination,
                villains_methods_captivity_or_coercion,
                villains_methods_conficence_scams,
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

            public static readonly string[] weakness =
            {
                "A hidden object holds the villain's soul",
                "The villain's power is broken if the death of its true love is avenged",
                "The villain is weakened in the presence of a particular artifact",
                "A special weapon deals extra damage when used against the villain",
                "The villain is destroyed if it speaks its true name",
                "An ancient prophecy or riddle reveals how the villain can be overthrown",
                "The villain falls when an ancient enemy forgives its past actions",
                "The villain loses its power if a mystic bargain it struck long ago is completed"
            };

            public static string getNPCAbilities()
            {
                int num1 = roll(1, 6);
                int num2 = 0;

                do
                {
                    num2 = roll(1, 6);
                } while (num2 == num1);

                return npc_high_abilities[num1 - 1] + ", " + npc_low_abilities[num2 - 1];
            }
        }

        // Chapter 5
        public static class AdventureEnvironments
        {
            public static readonly string[] dungeon_location =
            {
                "A building in a city",
				"A building in a city",
				"A building in a city",
				"A building in a city",
				"Catacombs or sewers beneath a city",
				"Catacombs or sewers beneath a city",
				"Catacombs or sewers beneath a city",
				"Catacombs or sewers beneath a city",
				"Beneath a farmhouse",
				"Beneath a farmhouse",
				"Beneath a farmhouse",
				"Beneath a farmhouse",
				"Beneath a graveyard",
				"Beneath a graveyard",
				"Beneath a graveyard",
				"Beneath a graveyard",
				"Beneath a ruined castle",
				"Beneath a ruined castle",
				"Beneath a ruined castle",
				"Beneath a ruined castle",
				"Beneath a ruined castle",
				"Beneath a ruined castle",
				"Beneath a ruined city",
				"Beneath a ruined city",
				"Beneath a ruined city",
				"Beneath a ruined city",
				"Beneath a temple",
				"Beneath a temple",
				"Beneath a temple",
				"Beneath a temple",
				"In a chasm",
				"In a chasm",
				"In a chasm",
				"In a chasm",
				"In a cliff face",
				"In a cliff face",
				"In a cliff face",
				"In a cliff face",
				"In a desert",
				"In a desert",
				"In a desert",
				"In a desert",
				"In a forest",
				"In a forest",
				"In a forest",
				"In a forest",
				"In a glacier",
				"In a glacier",
				"In a glacier",
				"In a glacier",
				"In a gorge",
				"In a gorge",
				"In a gorge",
				"In a gorge",
				"In a jungle",
				"In a jungle",
				"In a jungle",
				"In a jungle",
				"In a mountain pass",
				"In a mountain pass",
				"In a mountain pass",
				"In a mountain pass",
				"In a swamp",
				"In a swamp",
				"In a swamp",
				"In a swamp",
				"Beneath or on top of a mesa",
				"Beneath or on top of a mesa",
				"Beneath or on top of a mesa",
				"Beneath or on top of a mesa",
				"In sea caves",
				"In sea caves",
				"In sea caves",
				"In sea caves",
				"In several connected mesas",
				"In several connected mesas",
				"In several connected mesas",
				"In several connected mesas",
				"On a mountain peak",
				"On a mountain peak",
				"On a mountain peak",
				"On a mountain peak",
				"On a promontory",
				"On a promontory",
				"On a promontory",
				"On a promontory",
				"On an island",
				"On an island",
				"On an island",
				"On an island",
				"Underwater",
				"Underwater",
				"Underwater",
				"Underwater",
				"Underwater",
				"Roll on the Exotic Location table",
				"Roll on the Exotic Location table",
				"Roll on the Exotic Location table",
				"Roll on the Exotic Location table",
				"Roll on the Exotic Location table",
			};

            public static readonly string[] dungeon_exotic_location =
            {
                "Among the branches of a tree",
                "Around a geyser",
                "Behind a waterfall",
                "Buried in an avalanche",
                "Buried in a sandstorm",
                "Buried in volcanic ash",
                "Castle or structure sunken in a swamp",
                "Castle or structure at the bottom of a sinkhole",
                "Floating on the sea",
                "In a meteorite",
                "On a demiplane or in a pocket dimension",
                "In an area devastated by a magical catastrophe",
                "On a cloud",
                "In the Feywild",
                "In the Shadowfell",
                "On an island in an underground sea",
                "In a volcano",
                "On the back of a Gargantuan living creature",
                "Sealed inside a magical dome of force",
                "Inside a Mordenkainen's magnificent mansion"
            };

            public static readonly string[] dungeon_creator =
            {
                "Beholder",
                "Cult or religious group",
                "Cult or religious group",
                "Cult or religious group",
                "Dwarves",
                "Dwarves",
                "Dwarves",
                "Dwarves",
                "Elves (including drow)",
                "Giants",
                "Hobgoblins",
                "Humans",
                "Humans",
                "Humans",
                "Humans",
                "Kuo-toa",
                "Lich",
                "Mind flayers",
                "Yuan-ti",
                "No creator (natural caverns"
            };

            public static readonly string[] cults_and_religious_groups =
            {
                "Demon-worshiping cult",
                "Devil-worshiping cult",
                "Elemental Air cult",
                "Elemental Air cult",
                "Elemental Earth cult",
                "Elemental Earth cult",
                "Elemental Fire cult",
                "Elemental Fire cult",
                "Elemental Water cult",
                "Elemental Water cult",
                "Worshipers of an evil deity",
                "Worshipers of an evil deity",
                "Worshipers of an evil deity",
                "Worshipers of an evil deity",
                "Worshipers of an evil deity",
                "Worshipers of a good deity",
                "Worshipers of a good deity",
                "Worshipers of a neutral deity",
                "Worshipers of a neutral deity",
                "Worshipers of a neutral deity"
            };

            public static readonly string[] npc_alignment =
            {
                "Lawful good",
				"Lawful good",
                "Neutral good",
                "Neutral good",
                "Chaotic good",
                "Chaotic good",
                "Lawful neutral",
                "Lawful neutral",
                "Neutral",
                "Neutral",
                "Chaotic neutral",
                "Lawful evil",
                "Lawful evil",
                "Neutral evil",
                "Neutral evil",
                "Chaotic evil",
                "Chaotic evil"
            };

            public static readonly string[] npc_class =
            {
                "Barbarian",
                "Bard",
                "Cleric",
                "Cleric",
                "Druid",
                "Fighter",
                "Fighter",
                "Monk",
                "Paladin",
                "Ranger",
                "Rogue",
                "Rogue",
                "Rogue",
                "Rogue",
                "Sorcerer",
                "Warlock",
                "Wizard",
                "Wizard",
                "Wizard",
                "Wizard"
            };

            public static readonly string[] dungeon_purpose =
            {
                "Death trap",
                "Lair",
                "Lair",
                "Lair",
                "Lair",
                "Maze",
                "Mine",
                "Mine",
                "Mine",
                "Planar gate",
                "Stronghold",
                "Stronghold",
                "Stronghold",
                "Stronghold",
                "Temple or shrine",
                "Temple or shrine",
                "Temple or shrine",
                "Tomb",
                "Tomb",
                "Treasure vault"
            };

            public static readonly string[] dungeon_history =
            {
                "Abandoned by creators",
                "Abandoned by creators",
                "Abandoned by creators",
                "Abandoned due to plague",
                "Conquered by invaders",
                "Conquered by invaders",
                "Conquered by invaders",
                "Conquered by invaders",
                "Creators destroyed by attacking raiders",
                "Creators destroyed by attacking raiders",
                "Creators destroyed by discovery made within the site",
                "Creators destroyed by internal conflict",
                "Creators destroyed by magical catastrophe",
                "Creators destroyed by natural disaster",
                "Creators destroyed by natural disaster",
                "Location cursed by the gods and shunned",
                "Original creator still in control",
                "Original creator still in control",
                "Overrun by planar creatures",
                "Site of a great miracle"
            };

            public static readonly string[] monuments =
            {
                "Sealed burial mound or pyramid",
                "Plundered burial mound or pyramid",
                "Faces carved into a mountainside or cliff",
                "Giant statues carved out of a mountainside or cliff",
                "Intact obelisk etched with a warning, historical lore, dedication, or religious iconography",
                "Intact obelisk etched with a warning, historical lore, dedication, or religious iconography",
                "Ruined or toppled obelisk",
                "Ruined or toppled obelisk",
                "Intact statue of a person or deity",
                "Intact statue of a person or deity",
                "Ruined or toppled statue of a person or deity",
                "Ruined or toppled statue of a person or deity",
                "Ruined or toppled statue of a person or deity",
                "Great stone wall, intact, with tower fortifications spaced at one-mile intervals",
                "Great stone wall in ruins",
                "Great stone arch",
                "Fountain",
                "Intact circle of standing stones",
                "Ruined or toppled circle of standing stones",
                "Totem pole"
            };

            public static readonly string[] weird_locales =
            {
                "Dead magic zone (similar to an antimagic field)",
                "Dead magic zone (similar to an antimagic field)",
                "Wild magic zone (roll on the Wild Magic Surge table in the Player's Handbook whenever a spell is cast within the zone)",
                "Boulder carved with talking faces",
                "Crystal cave that mystically answers questions",
                "Ancient tree containing a trapped spirit",
                "Battlefield where lingering fog occasionally assumes humanoid forms",
                "Battlefield where lingering fog occasionally assumes humanoid forms",
                "Permanent portal to another plane of existence",
                "Permanent portal to another plane of existence",
                "Wishing well",
                "Giant crystal shard protruding from the ground",
                "Wrecked ship, which might be nowhere near water",
                "Haunted hill or barrow mound",
                "Haunted hill or barrow mound",
                "River ferry guided by a skeletal captain",
                "Field of petrified soldiers or other creatures",
                "Forest of petrified or awakened trees",
                "Canyon containing a dragons' graveyard",
                "Floating earth mote with a tower on it"
            };

			public static readonly string[] weather_temperature =
			{
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"Normal for the season",
				"1d4 x 10 degrees Fahrenheit colder than normal",
				"1d4 x 10 degrees Fahrenheit colder than normal",
				"1d4 x 10 degrees Fahrenheit colder than normal",
				"1d4 x 10 degrees Fahrenheit hotter than normal",
				"1d4 x 10 degrees Fahrenheit hotter than normal",
				"1d4 x 10 degrees Fahrenheit hotter than normal"
			};

			public static readonly string[] weather_wind =
			{
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"Light",
				"Light",
				"Light",
				"Light",
				"Light",
				"Strong",
				"Strong",
				"Strong",
			};

			public static readonly string[] weather_precipitation =
			{
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"None",
				"Light rain or light snowfall",
				"Light rain or light snowfall",
				"Light rain or light snowfall",
				"Light rain or light snowfall",
				"Light rain or light snowfall",
				"Heavy rain or heavy snowfall",
				"Heavy rain or heavy snowfall",
				"Heavy rain or heavy snowfall",
			};

            public static readonly string[] race_relations =
            {
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Harmony",
                "Tension or rivalry",
                "Tension or rivalry",
                "Tension or rivalry",
                "Tension or rivalry",
                "Racial majority are conquerers",
                "Racial majority are conquerers",
                "Racial minority are rulers",
                "Racial minority are refugees",
                "Racial majority oppresses minority",
                "Racial minority oppresses majority"
            };

            public static readonly string[] rulers_status =
            {
                "Respected, fair, and just",
                "Respected, fair, and just",
                "Respected, fair, and just",
                "Respected, fair, and just",
                "Respected, fair, and just",
                "Feared tyrant",
                "Feared tyrant",
                "Feared tyrant",
                "Weakling manipulated by others",
                "Illegitimate ruler, simmering civial war",
                "Ruled or controlled by a powerful monster",
                "Mysterious, anonymous cabal",
                "Contested leadership, open fighting",
                "Cabal seized power openly",
                "Doltish lout",
                "On deathbed, claimants compete for power",
                "Iron-willed but respected",
                "Iron-willed but respected",
                "Religious leader",
                "Religious leader"
            };

            public static readonly string[] notable_traits =
            {
                "Canals in place of streets",
                "Massive statue or monument",
                "Grand temple",
                "Large fortress",
                "Verdant parks and orchards",
                "River divides town",
                "Major trade center",
                "Headquarters of a powerful family or guild",
                "Population mostly wealthy",
                "Destitue, rundown",
                "Awful smell (tanneries, open sewers)",
                "Center of trade for one specific good",
                "Site of many battles",
                "Site of a mythic or magical event",
                "Important library or archive",
                "Worship of all gods banned",
                "Sinister reputation",
                "Notable library or academy",
                "Site of important tomb or graveyard",
                "Built atop ancient ruins"
            };

            public static readonly string[] known_for_its =
            {
                "Delicious cuisine",
                "Rude people",
                "Greedy merchants",
                "Artists and writers",
                "Great hero/savior",
                "Flowers",
                "Hordes of beggars",
                "Tough warriors",
                "Dark magic",
                "Decadence",
                "Piety",
                "Gambling",
                "Godlessness",
                "Education",
                "Wines",
                "High fashion",
                "Political intrigue",
                "Powerful guilds",
                "Strong drink",
                "Patriotism"
            };

            public static readonly string[] current_calamity =
            {
                "Suspected vampire infestation",
                "New cult seeks converts",
                "Important figure died (murder suspected)",
                "War between rival thieves' guilds",
                "Plague or famine (sparks riots)",
                "Corrupt officials",
                "Marauding monsters",
                "Powerful wizard has moved into town",
                "Economic depression (trade disrupted)",
                "Flooding",
                "Undead stirring in cemeteries",
                "Prophecy of doom",
                "Brink of war",
                "Internal strife (leads to anarchy)",
                "Besieged by enemies",
                "Scandal threatens powerful families",
                "Dungeon discovered (adventurers flock to town)",
                "Religious sects struggle for power"
            };

			public static readonly string[] building_type =
			{
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Residence (roll once on the Residence table)",
				"Religious (roll once on the Religious table)",
				"Religious (roll once on the Religious table)",
				"Tavern (roll once on the Tavern table and twice on the Tavern Name Generator table",
				"Tavern (roll once on the Tavern table and twice on the Tavern Name Generator table",
				"Tavern (roll once on the Tavern table and twice on the Tavern Name Generator table",
				"Warehouse (roll once on the Warehouse table)",
				"Warehouse (roll once on the Warehouse table)",
				"Shop (roll once on the Shop table)",
				"Shop (roll once on the Shop table)",
				"Shop (roll once on the Shop table)"
			};

            public static readonly string[] residence =
            {
                "Abandoned squat",
                "Abandoned squat",
                "Middle-class home",
                "Middle-class home",
                "Middle-class home",
                "Middle-class home",
                "Middle-class home",
                "Middle-class home",
                "Upper-class home",
                "Upper-class home",
                "Crowded tenement",
                "Crowded tenement",
                "Crowded tenement",
                "Crowded tenement",
                "Crowded tenement",
                "Orphanage",
                "Orphanage",
                "Hidden slavers' den",
                "Front for a secret cult",
                "Lavish, guarded mansion"
            };

            public static readonly string[] religious_building =
            {
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a good or neutral deity",
                "Temple to a false deity (run by charlatan priests)",
                "Temple to a false deity (run by charlatan priests)",
                "Home of ascetics",
                "Abandoned shrine",
                "Abandoned shrine",
                "Library dedicated to religious study",
                "Library dedicated to religious study",
                "Hidden shrine to a fiend or an evil deity",
                "Hidden shrine to a fiend or an evil deity"
            };

            public static readonly string[] tavern =
            {
                "Quiet, low-key bar",
                "Quiet, low-key bar",
                "Quiet, low-key bar",
                "Quiet, low-key bar",
                "Quiet, low-key bar",
                "Raucous dive",
                "Raucous dive",
                "Raucous dive",
                "Raucous dive",
                "Thieves' guild hangout",
                "Gathering place for a secret society",
                "Upper-class dining club",
                "Upper-class dining club",
                "Gambling den",
                "Gambling den",
                "Caters to specific race or guild",
                "Caters to specific race or guild",
                "Members-only club",
                "Brothel",
                "Brothel"
            };

            public static readonly string[] tavern_name_first_part =
            {
                "The Silver",
                "The Golden",
                "The Staggering",
                "The Laughing",
                "The Prancing",
                "The Gilded",
                "The Running",
                "The Howling",
                "The Slaughtered",
                "The Leering",
                "The Drunken",
                "The Leaping",
                "The Roaring",
                "The Frowning",
                "The Lonely",
                "The Wandering",
                "The Mysterious",
                "The Barking",
                "The Black",
                "The Gleaming"
            };

            public static readonly string[] tavern_name_second_part =
            {
                "Eel",
                "Dolphin",
                "Dwarf",
                "Pegasus",
                "Pony",
                "Rose",
                "Stag",
                "Wolf",
                "Lamb",
                "Demon",
                "Goat",
                "Spirit",
                "Horde",
                "Jester",
                "Mountain",
                "Eagle",
                "Satyr",
                "Dog",
                "Spider",
                "Star"
            };

            public static readonly string[] warehouse =
            {
                "Empty or abandoned",
                "Empty or abandoned",
                "Empty or abandoned",
                "Empty or abandoned",
                "Heavily guarded, expensive goods",
                "Heavily guarded, expensive goods",
                "Cheap goods",
                "Cheap goods",
                "Cheap goods",
                "Cheap goods",
                "Bulk goods",
                "Bulk goods",
                "Bulk goods",
                "Bulk goods",
                "Live animals",
                "Weapons/armor",
                "Weapons/armor",
                "Goods from a distant land",
                "Goods from a distant land",
                "Secret smuggler's den"
            };

            public static readonly string[] shop =
            {
                "Pawnshop",
                "Herbs/incense",
                "Fruits/vegetables",
                "Dried meats",
                "Pottery",
                "Undertaker",
                "Books",
                "Moneylender",
                "Weapons/armor",
                "Chandler",
                "Smithy",
                "Carpenter",
                "Weaver",
                "Jeweler",
                "Baker",
                "Mapmaker",
                "Tailor",
                "Ropemaker",
                "Mason",
                "Scribe"
            };

            public static readonly string[] random_urban_encounters =
            {
                "Animals on the loose",
                "Announcement",
                "Brawl",
                "Bullies",
                "Companion",
                "Contest",
                "Corpse",
                "Draft",
                "Drunk",
                "Fire",
                "Found trinket",
                "Guard harassment",
                "Pickpocket",
                "Procession",
                "Protest",
                "Runaway cart",
                "Shady transaction",
                "Spectacle",
                "Urhin"
            };

            public static string getDungeonLocation()
            {
                int num = Data.rand.Next() % dungeon_location.Length + 1;

                if (num == dungeon_location.Length)
                {
                    return dungeon_exotic_location[Data.rand.Next() % dungeon_exotic_location.Length - 1];
                }

                return dungeon_location[num];
            }

            public static string getWeather_Temperature()
            {
                string str = "";

                int num = Data.rand.Next() % 20 + 1;

                if (num < 15)
                {
                    str = "Normal for the season";
                }
                else if (num < 18)
                {
                    str = (((rand.Next() % 4) + 1) * 10) + " degrees Fahrenheit colder than normal";
                }
                else
                {
                    str = (((rand.Next() % 4) + 1) * 10) + " degrees Fahrenheit hotter than normal";
                }

                return str;
            }

            public static string getWeatherWind()
            {
                int num = Data.rand.Next() % 20 + 1;

                if(num < 13)
                {
                    return "None";
                }
                else if(num < 18)
                {
                    return "Light";
                }
                else
                {
                    return "Strong";
                }
            }

            public static string getWeatherPrecipitation()
            {
                int num = Data.rand.Next() % 20 + 1;

                if(num < 13)
                {
                    return "None";
                }
                else if(num < 18)
                {
                    return "Light rain or light snowfall";
                }
                else
                {
                    return "Heavy rain or heavy snowfall";
                }
            }

            public static string getBuildingType()
            {
                int num = Data.rand.Next() % 20 + 1;

                if(num < 11)
                {
                    return "Residence: " + lowerFirstLetter(residence[Data.rand.Next() % residence.Length]);
                }
                else if(num < 13)
                {
                    return "Religious: " + lowerFirstLetter(religious_building[Data.rand.Next() % religious_building.Length]);
                }
                else if(num < 16)
                {
                    return "Tavern: " + lowerFirstLetter(tavern[Data.rand.Next() % tavern.Length]) + 
                        " by the name of " + tavern_name_first_part[Data.rand.Next() % tavern_name_first_part.Length] 
                        + " " + tavern_name_second_part[Data.rand.Next() % tavern_name_second_part.Length];
                }
                else if(num < 18)
                {
                    return "Warehouse: " + warehouse[Data.rand.Next() % warehouse.Length];
                }
                else
                {
                    return "Shop: " + shop[Data.rand.Next() % shop.Length];
                }
            }
        }

        // Chapter 6
        public static class BetweenAdventures
        {
            public static readonly string[] carousing =
            {
                "You are jailed for 1d4 days at the end of the downtime period on charges " +
                    "of disorderly conduct and disturbing the peace. You can pay a " +
                    "fine of 10 gp to avoid jail time, or you can try to resist arrest.",
                "You regain consciousness in a strange place with no memory of how " +
                    "you got there, and you have been robbed of 3d6x5 gp.",
                "You make an enemy. This person, business, or organization is now " +
                    "hostile to you. The DM determines the offended party. You decide how you offended them.",
                "You are caught up in a whirlwind romance. Roll a d20. On a 1-5, the romance ends badly. " +
                    "On a 6-10, the romance ends amicably. On an 11-20, the romance is ongoing."+
                    "You determine the identity of the love interest, subject to your DM's " +
                    "approval. If the romance ends badly, you might gain a new flaw. If it ends " +
                    "well or is ongoing, your new love interest might represent a new bond.",
                "You earn modest winnings from gambling and recuperate your lifestlye expenses for the time spent carousing.",
                "You earn modest winnings from gambling and recuperate your lifestlye expenses for the time spent carousing.",
                "You earn modest winnings from gambling and recuperate your lifestlye expenses for the time spent carousing.",
                "You earn modest winnings from gambling and recuperate your lifestlye expenses for the time spent carousing.",
                "You earn modest winnings from gambling. You recuperate your " +
                        "lifestyle expenses for the time spent carousing and gain 1d20x4 gp.",
                "You make a small fortune gambling. You recuperate your " +
                        "lifestyle expenses for the time spent carousing and gain 4d6x10 gp."
            };

            public static readonly string[] running_a_business =
            {
                "You ust pay one and a half times the business's maintenance cost for each of the days.",
                "You ust pay one and a half times the business's maintenance cost for each of the days.",
                "You must pay the business's full maintenance cost for each of the days.",
                "You must pay half the business's maintenance cost for each of the days. Profits cover the other half.",
                "The business covers its own maintenance cost for each of the days.",
                "The business covers its own maintenance cost for each of the days.",
                "The business covers its own maintenance cost for each of the days. It earns a profit of 1d6x5 gp.",
                "The business covers its own maintenance cost for each of the days. It earns a profit of 1d6x5 gp.",
                "The business covers its own maintenance cost for each of the days. It earns a profit of 2d8x5 gp.",
                "The business covers its own maintenance cost for each of the days. It earns a profit of 3d10x5 gp."
            };

            public static readonly string[] selling_a_magic_item =
            {
                "A buyer offering a tenth of the base price",
                "A buyer offering a tenth of the base price",
                "A buyer offering a quarter of the base price, and a shady buyer offering half the base price",
                "A buyer offering a quarter of the base price, and a shady buyer offering half the base price",
                "A buyer offering half the base price, and a shady buyer offering the full base price",
                "A buyer offering half the base price, and a shady buyer offering the full base price",
                "A buyer offering half the base price, and a shady buyer offering the full base price",
                "A buyer offering half the base price, and a shady buyer offering the full base price",
                "A buyer offering the full base price",
                "A shady buyer offering one and a half times the base price, no questions asked"
            };

            public static string getCarousing()
            {
                int num = roll(1, 100);

                if(num < 11)
                {
                    return "You are jailed for " + roll(1, 4) + "days " +
                        "at the end of the downtime period on charges of disorderly conduct " +
                        "and disturbing the peace. You can pay a fine of 10 gp to avoid jail " +
                        "time, or you can try to resist arrest.";
                }
                else if(num < 21)
                {
                    return "You regain consciousness in a strange place with no memory of how " +
                        "you got there, and you have been robbed of " + (roll(3, 6) * 5) + " gp.";
                }
                else if(num < 31)
                {
                    return "You make an enemy. This person, business, or organization is now " +
                        "hostile to you. The DM determines the offended party. You decide how you offended them.";
                }
                else if(num < 41)
                {
                    string res = "";
                    num = roll(1, 20);

                    if(num < 6)
                    {
                        res = "The romance ends badly. ";
                    }
                    else if(num < 11)
                    {
                        res = "The romance ends amicably. ";
                    }
                    else
                    {
                        res = "The romance is ongoing. ";
                    }

                    return "You are caught up in a whirlwind romance. " + res +
                        "You determine the identity of the love interest, subject to your DM's " +
                        "approval. If the romance ends badly, you might gain a new flaw. If it ends " +
                        "well or is ongoing, your new love interest might represent a new bond.";
                }
                else if(num < 81)
                {
                    return "You earn modest winnings from gambling and recuperate your " +
                        "lifestlye expenses for the time spent carousing.";
                }
                else if(num < 91)
                {
                    return "You earn modest winnings from gambling. You recuperate your " +
                        "lifestyle expenses for the time spent carousing and gain " + 
                        (roll(1, 20) * 4) + " gp.";
                }
                else
                {
                    return "You make a small fortune gambling. You recuperate your " +
                        "lifestyle expenses for the time spent carousing and gain " + 
                        (roll(4, 6) * 10) + " gp.";
                }
            }

            public static string getRunningABusiness()
            {
                int num = roll(1,10) - 1;

                if(num < 6)
                {
                    return running_a_business[num];
                }

                switch(num)
                {
                    case 6:
                    case 7:
                        {
                            return "The business covers its own maintenance cost for each of the days. It earns a profit of " + (roll(1, 6) * 5) + " gp.";
                        }
                    case 8:
                        {
                            return "The business covers its own maintenance cost for each of the days. It earns a profit of " + (roll(2, 8) * 5) + " gp.";
                        }
                    default:
                        {
                            return "The business covers its own maintenance cost for each of the days. It earns a profit of " + (roll(3, 10) * 5) + " gp.";
                        }
                }
            }
        }

        // Chapter 7
        public static class Treasure
        {
            public static readonly string[] gemstones10gp =
            {
                "Azurite (opaque mottled deep blue)",
                "Banded agate (translucent striped brown, blue, white, or red)",
                "Blue quartz (transparent pale blue)",
                "Eye agate (translucent circles of gray, white, brown, blue, or green)",
                "Hematite (opaque gray-black)",
                "Lapis lazuli (opaque light and dark blue with yellow flecks)",
                "Malachite (opaque striated light and dark green)",
                "Moss agate (translucent pink or yellow-white with mossy gray or green markings)",
                "Obsidian (opaque black)",
                "Rhodochrosite (opaque light pink)",
                "Tiger eye (translucent brown with golden center",
                "Turquoise (opaque light blue-green)"
            };

            public static readonly string[] gemstones50gp =
            {
                "Bloodstone (opaque dark gray with red flecks)",
                "Carnelian (opaque orange to red-brown)",
                "Chalcedony (opaque white)",
                "Chrysoprase (translucent green)",
                "Citrine (transparent pale yellow-brown)",
                "Jasper (opaque blue, black, or brown)",
                "Moonstone (translucent white with pale blue glow)",
                "Onyx (opaque bands of black and white, or pure black or white)",
                "Quartz (transparent white, smoky gray, or yellow)",
                "Sardonyx (opaque bands of red and white)",
                "Star rose quartz (translucent rosy stone with white star-shaped center)",
                "Zircon (transparent pale blue-green"
            };

            public static readonly string[] gemstones100gp =
            {
                "Amber (transparent watery gold to rich gold)",
                "Amethyst (transparent deep purple)",
                "Chrysoberyl (transparent yellow-green to pale green)",
                "Coral (opaque crimson)",
                "Garnet (trasnparent red, brown-green, or violet)",
                "Jade (trasnlucent light green, deep green, or white)",
                "Jet (opaque deep black)",
                "Pearl (opaque lustrous white, yellow, or pink)",
                "Spinel (trasnparent red, red-brown, or deep green)",
                "Tourmaline (trasnparent pale green, blue, brown, or red)"
            };

            public static readonly string[] gemstones500gp =
            {
                "Alexandrite (transparent dark green)",
                "Aquamarine (transparent pale blue-green)",
                "Black pearl (opaque pure black)",
                "Blue spinel (trasnparent deep blue)",
                "Peridot (trasnparent rich olive green)",
                "Topaz (transparent golden yellow)"
            };

            public static readonly string[] gemstones1000gp =
            {
                "Black opal (translucent dark green with black mottling and golden flecks)",
                "Blue sapphire (transparent blue-white to medium blue)",
                "Emerald (transparent deep bright green)",
                "Fire opal (translucent fiery red)",
                "Opal (translucent pale blue with green and golden mottling)",
                "Star ruby (translucent ruby with white star-shaped center)",
                "Star sapphire (translucent blue sapphire with white star-shaped center)",
                "Yellow sapphire (transparent fiery yellow or yellow-green)"
            };

            public static readonly string[] gemstones5000gp =
            {
                "Black sapphire (translucent lustrous black with glowing highlights)",
                "Diamond (transparent blue-white canary, pink, brown, or blue)",
                "Jacinth (transparent fiery orange)",
                "Ruby (transparent clear red to deep crimson)"
            };

            public static readonly string[] art_objects25gp =
            {
                "Silver ewer",
                "Carved bone statuette",
                "Small gold bracelet",
                "Cloth-of-gold vestments",
                "Black velvet mask stitched with silver thread",
                "Copper chalice with silver filigree",
                "Pair of engraved bone dice",
                "Small mirror set in a painted wooden frame",
                "Embroidered silk handkerchief",
                "Gold locket with a apainted portrait inside"
            };

            public static readonly string[] art_objects250gp =
            {
                "Gold ring set with bloodstones",
                "Carved ivory statuette",
                "Large gold bracelet",
                "Silver necklace wit ha gemstone pendant",
                "Bronze crown",
                "Silk robe wit hgold embroidery",
                "Large well-made tapestry",
                "Brass mug wit hjade inlay",
                "Box of turquoise animal figurines",
                "Gold bird cage with electrum filigree"
            };

            public static readonly string[] art_objects750gp =
            {
                "Silver chalice set with moonstones",
                "Silver-plated steel longsword with jet set in hilt",
                "Carved harp of exotic wood with ivory inlay and zircon gems",
                "Small gold idol",
                "Gold dragon comb set with red garnets as eyes",
                "Bottle stopper cork embossed wit hgold leaf and set with amethysts",
                "Ceremonial electrum dagger with a black pearl in the pommel",
                "Silver and gold brooch",
                "Obsidian statuette with gold fittings and inlay",
                "Painted gold war mask"
            };

            public static readonly string[] art_objects2500gp =
            {
                "Fine gold chain set with a fire opal",
                "Old masterpiece painting",
                "Embroidered silk and velvet mantle set with numerous moonstones",
                "Platinum bracelet set wit ha sapphire",
                "Embroidered glove set with jewel chips",
                "Jeweled anklet",
                "Gold music box",
                "Gold circlet set with four aquamarines",
                "Eye patch wit ha mock eye set in blue sapphire and moonstone",
                "A necklace string of small pink pearls"
            };

            public static readonly string[] art_objects7500gp =
            {
                "Jeweled gold crown",
                "Jeweled platinum ring",
                "Small gold statuette set with rubies",
                "Gold cup set with emeralds",
                "Gold jewelry box with platinum filigree",
                "Painted gold child's sarcophagus",
                "Jade game board with solid gold playing pieces",
                "Bejeweled ivory drinking horn with gold filigree"
            };

            public static readonly string[] individual_treasure_challenge0_4 =
            {
                "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp",
				"5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp",
				"5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp",
				"5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp",
				"5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp",
				"5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp", "5d6 (17) cp",
				"4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp",
				"4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp",
				"4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp",
				"4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp",
				"4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp",
				"4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp", "4d6 (14) sp",
				"3d6 (10) ep", "3d6 (10) ep", "3d6 (10) ep", "3d6 (10) ep", "3d6 (10) ep",
				"3d6 (10) ep", "3d6 (10) ep", "3d6 (10) ep", "3d6 (10) ep", "3d6 (10) ep",
				"3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp",
				"3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp",
				"3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp", "3d6 (10) gp",
				"1d6 (3) pp", "1d6 (3) pp", "1d6 (3) pp", "1d6 (3) pp", "1d6 (3) pp"
			};

			public static readonly string[] individual_treasure_challenge5_10 =
			{
				"4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep",
				"4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep",
				"4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep",
				"4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep",
				"4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep",
				"4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep", "4d6 x 100 (1,400) cp, 1d6 x 10 (35) ep",
				"6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp",
				"6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp",
				"6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp",
				"6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp",
				"6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp",
				"6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp", "6d6 x 10 (210) sp, 2d6 x 10 (70) gp",
				"3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp",
				"3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp", "3d6 x 10 (105) ep, 2d6 x 10 (70) gp",
				"4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp",
				"4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp",
				"4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp", "4d6 x 10 (140) gp",
				"2d6 x 10 (70) gp, 3d6 (10) pp", "2d6 x 10 (70) gp, 3d6 (10) pp", "2d6 x 10 (70) gp, 3d6 (10) pp", "2d6 x 10 (70) gp, 3d6 (10) pp", "2d6 x 10 (70) gp, 3d6 (10) pp"
			};

			public static readonly string[] individual_treasure_challenge11_16 =
			{
				"4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp",
				"4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp",
				"4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp",
				"4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp", "4d6 x 100 (1,400) sp, 1d6 x 100 (350) gp",
				"1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp",
				"1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp",
				"1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp", "1d6 x 100 (350) ep, 1d6 x 100 (350) gp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp", "2d6 x 100 (700) gp, 1d6 x 10 (35) pp",
				"2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp",
				"2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp",
				"2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp",
				"2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp",
				"2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp", "2d6 x 100 (700) gp, 2d6 x 10 (70) pp"
			};

			public static readonly string[] individual_treasure_challenge17_plus =
			{
				"2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp",
				"2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp",
				"2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp", "2d6 x 1,000 (7,000) ep, 8d6 x 100 (2,800) gp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp", "1d6 x 1,000 (3,500) gp, 1d6 x 100 (350) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp",
				"1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp", "1d6 x 1,000 (3,500) gp, 2d6 x 100 (700) pp"
			};

			public static readonly string[] treasure_hoard_challenge0_4 =
			{
				//01-06
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp",
				//07-16
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems",
				//17-26
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects",
				//27-36
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems",
				//37-44
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d6 times on Magic Item Table A",
				//45-52
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				//53-60
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				//61-65
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table B",
				//66-70
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				//71-75
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				//76-78
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 10 gp gems, Roll 1d4 times on Magic Item Table C",
				//79-80
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C",
				//81-85
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				//86-92
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				//93-97
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d4 (5) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				//98-99
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 25 gp art objects, Roll once on Magic Item Table G",
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 25 gp art objects, Roll once on Magic Item Table G",
				//00
				"6d6 x 100 (2,100) cp, 3d6 x 100 (1,050) sp, 2d6 x 10 (70) gp, " +
					"2d6 (7) 50 gp gems, Roll once on Magic Item Table G"
			};
			//need "get" functions for the following tables
			public static readonly string[] treasure_hoard_challenge5_10 =
			{
				//01-04
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp",
				//05-10
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects",
				//11-16
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems",
				//17-22
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems",
				//23-28
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " + 
					"2d4 (5) 250 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects",
				//29-32
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d6 times on Magic Item Table A",
				//33-36
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d6 times on Magic Item Table A",
				//37-40
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d6 times on Magic Item Table A",
				//41-44
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table A",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table A",
				//45-49
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table B",
				//50-54
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table B",
				//55-59
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table B",
				//60-63
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table B",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table B",
				//64-66
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table C",
				//67-69
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table C",
				//70-72
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table C",
				//73-74
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table C",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table C",
				//75-76
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll once on Magic Item Table D",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll once on Magic Item Table D",
				//77-78
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll once on Magic Item Table D",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll once on Magic Item Table D",
				//79
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll once on Magic Item Table D",
				//80
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table D",
				//81-84
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 25 gp art objects, Roll 1d4 times on Magic Item Table F",
				//85-88
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 50 gp gems, Roll 1d4 times on Magic Item Table F",
				//89-91
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table F",
				//92-94
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table F",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table F",
				//95-96
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table G",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll 1d4 times on Magic Item Table G",
				//97-98
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 250 gp art objects, Roll 1d4 times on Magic Item Table G",
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 250 gp art objects, Roll 1d4 times on Magic Item Table G",
				//99
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"3d6 (10) 100 gp gems, Roll once on Magic Item Table H",
				//00
				"2d6 x 100 (700) cp, 2d6 x 1,000 (7,000) sp, 6d6 x 100 (2,100) gp, 3d6 x 10 (105) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H"
			};

			public static readonly string[] treasure_hoard_challenge11_16 =
			{
				//01-03
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp",
				//04-06
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"2d4 (5) 250 gp art objects",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"2d4 (5) 250 gp art objects",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"2d4 (5) 250 gp art objects",
				//07-09
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"2d4 (5) 750 gp art objects",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"2d4 (5) 750 gp art objects",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"2d4 (5) 750 gp art objects",
				//10-12
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"3d6 (10) 500 gp gems",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"3d6 (10) 500 gp gems",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"3d6 (10) 500 gp gems",
				//13-15
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"3d6 (10) 1,000 gp gems",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"3d6 (10) 1,000 gp gems",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp" +
					"3d6 (10) 1,000 gp gems",
				//16-19
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				//20-23
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				//24-26
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				//27-29
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table A and 1d6 times on Magic Item Table B",
				//30-35
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d6 times on Magic Item Table C",
				//36-40
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d6 times on Magic Item Table C",
				//41-45
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d6 times on Magic Item Table C",
				//46-50
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table C",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table C",
				//51-54
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table D",
				//55-58
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table D",
				//59-62
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table D",
				//63-66
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table D",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table D",
				//67-68
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table E",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table E",
				//69-70
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll once on Magic Item Table E",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll once on Magic Item Table E",
				//71-72
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll once on Magic Item Table E",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll once on Magic Item Table E",
				//72-74
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table E",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table E",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table E",
				//75-76
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				//77-78
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				//79-80
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				//81-82
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table F and 1d4 times on Magic Item Table G",
				//83-85
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll 1d4 times on Magic Item Table H",
				//86-88
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table H",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table H",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll 1d4 times on Magic Item Table H",
				//89-90
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table H",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll 1d4 times on Magic Item Table H",
				//91-92
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H",
				//93-94
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table E",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 250 gp art objects, Roll once on Magic Item Table E",
				//95-96
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll once on Magic Item Table I",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"2d4 (5) 750 gp art objects, Roll once on Magic Item Table I",
				//97-98
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll once on Magic Item Table I",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 500 gp gems, Roll once on Magic Item Table I",
				//99-00
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table I",
				"4d6 x 1,000 (14,000) gp, 5d6 x 100 (1,750) pp, " +
					"3d6 (10) 1,000 gp gems, Roll once on Magic Item Table I"
			};

			public static readonly string[] treasure_hoard_challenge17_plus =
			{
				//01-02
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp",
				//03-05
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " + 
					"3d6 (10) 1,000 gp gems, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d8 times on Magic Item Table C",
				//06-08
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d8 times on Magic Item Table C",
				//09-11
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d8 times on Magic Item Table C",
				//12-14
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d8 times on Magic Item Table C",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d8 times on Magic Item Table C",
				//15-22
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table D",
				//23-30
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				//31-38
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table D",
				//39-46
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table D",
				//47-52
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d6 times on Magic Item Table E",
				//53-58
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				//59-63
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d6 times on Magic Item Table E",
				//64-68
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table E",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d6 times on Magic Item Table E",
				//69
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table G",
				//70
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table G",
				//71
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table G",
				//72
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table G",
				//73-74
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table H",
				//75-76
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table H",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table H",
				//77-78
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table H",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table H",
				//79-80
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table H",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table H",
				//81-85
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"3d6 (10) 1,000 gp gems, Roll 1d4 times on Magic Item Table I",
				//86-90
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d10 (5) 2,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				//91-95
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d4 (2) 7,500 gp art objects, Roll 1d4 times on Magic Item Table I",
				//96-00
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I",
				"12d6 x 1,000 (42,000) gp, 8d6 x 1,000 (28,000) pp, " +
					"1d8 (4) 5,000 gp gems, Roll 1d4 times on Magic Item Table I",
			};

			public static readonly string[] potion_miscibility =
			{
				//01
				"The mixture creates a magical explosion, dealing 6d10 force damage to the mixer and 1d10 force damage to each creature within 5 feet of the mixer.",
				//02-08
				"The mixture becomes an ingested poison of the DM's choice.",
				"The mixture becomes an ingested poison of the DM's choice.",
				"The mixture becomes an ingested poison of the DM's choice.",
				"The mixture becomes an ingested poison of the DM's choice.",
				"The mixture becomes an ingested poison of the DM's choice.",
				"The mixture becomes an ingested poison of the DM's choice.",
				"The mixture becomes an ingested poison of the DM's choice.",
				//09-15
				"Both potions lose their effects.",
				"Both potions lose their effects.",
				"Both potions lose their effects.",
				"Both potions lose their effects.",
				"Both potions lose their effects.",
				"Both potions lose their effects.",
				"Both potions lose their effects.",
				//16-25
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				"One potion loses its effect.",
				//26-35
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				"Both potions work, but with their numerical effects and durations halved. A potion has no effect if it can't be halved in this way.",
				//36-90
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				"Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.", "Both potions work normally.",
				//91-99
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				"The numerical effects and duration of one potion are doubled. If neither potion has anything to double in this way, they work normally.",
				//00
				"Only one potion works, but its effect is permanent. Choose the simplest effect to make permanent, or the one that seems the most fun. For example, a potion of healing might increase the drinker's hit point maximum by 4, or oil of etherealness migth permanently trap the user in the Ethereal Plane. At your discretion, an appropriate spell, such as dispel magic or remove curse, might end this lasting effect."
			};

			public static readonly string[] scroll_mishap =
			{
				"A surge of magical energy deals the caster 1d6 force damage per level of the spell",
				"The spell affects the caster or an ally (determined randomly) instead of the intended target, or it affects a random target nearby if the caster was the intended target.",
				"The spell affects a random location within the spell's range.",
				"The spell's effect is contrary to its normal one, but neither harmful nor beneficial. For instance, a fireball might produce an area of harmless cold.",
				"The caster suffers a minor but bizarre effect related to the spell. Such effects last only as long as the original spell's duration, or 1d10 minutes for spells that take effect instantaneously. For example, a fireball might cause smoke to billow from the caster's ears for 1d10 minutes.",
				"The spell activates after 1d12 hours. If the caster was the intended target, the spell takes effect normally. If the caster was not the intended target, the spell goes off in the general direction of the intended target, up to the spell's maximum range, if the target has moved away."
			};

			// used for creating artifacts
			public static readonly string[] who_created_it_or_who_was_intended_to_use_it =
			{
				"Aberration. The item was created by aberrations in ancient times, possibly for the use of favored humanoid thralls. When seen from the corner of the eye, the item seems to be moving.",
				"Human. The item was created during the heyday of a fallen human kingdom, or it is tied to a human legend. It might hold writing in a forgotten tongue or symbols whose significance is lost to the ages.",
				"Human. The item was created during the heyday of a fallen human kingdom, or it is tied to a human legend. It might hold writing in a forgotten tongue or symbols whose significance is lost to the ages.",
				"Celestial. The weapon is half the normal weight and inscribed with feathered wings, suns, and other symbols of good. Fiends find the item's presence repulsive.",
				"Dragon. This item is made from scales and talons shed by a dragon. Perhaps it incorporates precious metals and gems from the dragon's hoard. It grows slightly warm when within 120 feet of a dragon.",
				"Drow. The item is half the normal weight. It is black and inscribed with spiders and webs in honor of Lolth. it might function poorly, or disintegrate, if exposed to sunlight for 1 minute or more.",
				"Dwarf. The item is durable and has Dwarven runes worked into its design. It might be associated with a clan that would like to see it returned to their ancestral halls.",
				"Dwarf. The item is durable and has Dwarven runes worked into its design. It might be associated with a clan that would like to see it returned to their ancestral halls.",
				"Elemental Air. The item is half the normal weight and feels hollow. If it's made of fabric, it is diaphanous.",
				"Elemental Earth. This item might be crafted from stone. Any cloth of leather elements are studded with finely polished rock.",
				"Elemental Fire. This item is warm to the touch, and any metal parts are crafted from black iron. Sigils of flames cover its surface. Shades of red and orange are the prominent colors.",
				"Elemental Water. Lustrous fish scales replace leather or cloth on this item, and metal portions are instead crafted from seashells and worked coral as hard as any metal.",
				"Elf. The item is half the normal weight. It is adorned with symbold of nature: leaves, vines, stars, and the like.",
				"Elf. The item is half the normal weight. It is adorned with symbold of nature: leaves, vines, stars, and the like.",
				"Fey. The item is exquisitely crafted from the finest materials and glows with a pale radiance in moonlight, shedding dim light in a 5-foot radius. Any metal in the item is silver or mithral, rather than iron or steel.",
				"Fiend. The item is made of black iron or horn inscribed with runes, and any cloth or leather components are crafted from the hide of fiends. It is warm to the touch and features leering faces or vile runes engraved on its surface. Celestials find the item's presence repulsive.",
				"Giant. The item is larger than normal and was crafted by giants for use by their smaller allies.",
				"Gnome. The item is crafted to appear ordinary, and it might look worn. It could also incorporate gears and mechanical components, even if these aren't essential to the item's function.",
				"Undead. The item incorporates imagery of death, such as bones and skulls, and it might be crafted from parts of corpses. It feels cold to the touch."
			};

			// used for creating artifacts
			public static readonly string[] what_is_a_detail_from_its_history =
			{
				"Arcane. This item was created for an ancient order of spellcasters and bears the order's symbol.",
				"Bane. This item was created by the foes of a particular culture of kind of creature. If the culture or creatures are still around, they might recognize the item and single out the bearer as an enemy.",
				"Heroic. A great hero once wielded this item. Anyone who's familiar with the item's history expects great deeds from the new owner.",
				"Ornament. The item was created to honor a special occasion. Inset gemstones, gold or platinum inlays, and gold or silver filigree adorn its surface.",
				"Prophecy. The item features in a prophecy: its bearer is destined to play a key role in future events. Someone else who wants to play that role might try to steal the item, or someone who wants to prevent the prophecy from being fulfilled might try to kill the item's bearer.",
				"Religious. This item was used in religious ceremonies dedicated to a particular deity. It has holy symbols worked into it. The god's followers might try to persuade its owner to donate it to a temple, steal the item for themselves, or celebrate its use by a cleric or paladin of the same deity.",
				"Sinister. This item is linked to a deed of great evil, such as a massacre or an assassination. It might have a name or be closely associated with a villain who used it. Anyone familiar with the item's history is likely to treat it and its owner with suspicion.",
				"Symbol of Power. This item was once used as part of royal regalia or as a badge of high office. Its former owner or that person's descendants might desire it, or someone might mistakenly assume its new owner is the item's legitimate inheritor."
			};

			// used for creating artifacts
			public static readonly string[] what_minor_property_does_it_have =
			{
				"Beacon. The bearer can use a bonus action to cause the item to shed bright light in a 10-foot radius and dim light for an additional 10 feet, or to extinguish the light.",
				"Compass. The wielder can use an action to learn which way is north.",
				"Conscientious. When the bearer of this item contemplates or undertakes a malevolent act, the item enhances pangs of conscience.",
				"Delver. While underground, the bearer of this item always knows the item's depth below the surface and the direction to the nearest staircase, ramp, or other path leading upward.",
				"Gleaming. This itme never gets dirty.",
				"Guardian. The item whispers warnings to its bearer, granting a +2 bonus to initiative if the bearer isn't incapacitated",
				"Harmonious. Attuning to this item takes only 1 minute.",
				"Hidden Message. A message is hidden somewhere on the item. It might be visible only at a certain time of the year, under the light of one phase of the moon, or in a specific location.",
				"Key. The item is used to unlock a container, chamber, vault, or other entryway.",
				"Language. The bearer can speak and understand a language of the DM's choice while the item is on the bearer's person.",
				"Sentinel. Choose a kind of creature that is an enemy of the item's creator. This item glows faintly when such creatures are within 120 feet of it.",
				"Song Craft. Whenever this item is struck or is used to strike a foe, its bearer hears a fragment of an ancient song.",
				"Strange Material. The item was created from a material that is bizarre given its purpose. Its durability is unaffected.",
				"Temperate. The bearer suffers no harm in temperatures as cold as -20 degrees Fahrenheit or as warm as 120 degrees Fahrenheit.",
				"Unbreakable. The item can't be broken. Special means must be used to destroy it.",
				"War Leader. The bearer can use an action to cause his or her voice to carry clearly for up to 300 feet until the end of the bearer's next turn.",
				"Waterborne. This item floats on water and other liquids. Its bearer has advantage on Strength (Athletics) checks to swim.",
				"Wicked. When the bearer is presented with an opportunity to act in a selfish or malevolent way, the item heightens the bearer's urge to do so.",
				"Illusion. The item is imbued with illusion magic, allowing its bearer to alter the item's appearance in minor ways. Such alterations don't change how the item is worn, carried, or wielded, and they have no effect on its other magical properties. For example, the weare could make a red robe appear blue, or make a gold ring look like it's made of ivory. The item reverts to its true appearance when no one is carrying or wearing it.",
				"Roll twice, rerolling any additional 20s."
			};

			// used for creating artifacts
			public static readonly string[] what_quirk_does_it_have =
			{
				"Blissful. While in possession of the item, the bearer feels fortunate and optimistic about what the future holds. Butterflies and other harmless creatures might frolic in the item's presence.",
				"Confident. The item helps its bearer feel self-assured.",
				"Covetous. The item's bearer becomes obsessed with material wealth.",
				"Frail. The item crumbles, frays, chips, or cracks slightly when wielded, worn, or activated. This quirk has no effect on its properties, but if the item has seen much use, it looks decrepit.",
				"Hungry. This item's magical properties function only if fresh blood from a humanoid has been applied to it within the past 24 hours. It needs only a drop to activate.",
				"Loud. The item makes a loud noice -- such as a clang, a shout, or a resonating gong -- when used.",
				"Metamorphic. The item periodically and randomly alters its appearance in slight ways. The bearer has no control over these minor alterations, which have no effect on the item's use.",
				"Muttering. The item grumbles and mutters. A creature who listens carefully to the item might learn something useful.",
				"Painful. The bearer experiences a harmless flash of pain when using the item.",
				"Possessive. The item demands attunement when first wielded or worn, and it doesn't allow its bearer to attune to other items. (Other items already attuned to the bearer remain so until their attunemnt ends.)",
				"Repulsive. The bearer feels a sens of distaste when in contact with the item, and continues to sense discomfort while bearing it.",
				"Slothful. The bearer of this item feels slothful and lethargic. While attuned to the item, the bearer requires 10 hours to finish a long rest."
			};

			public static readonly string[] magic_item_table_a =
			{
				//01-50
				"Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing",
				"Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing",
				"Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing",
				"Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing",
				"Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing", "Potion of healing",
				//51-60
				"Spell scroll (cantrip)", "Spell scroll (cantrip)", "Spell scroll (cantrip)", "Spell scroll (cantrip)", "Spell scroll (cantrip)",
				"Spell scroll (cantrip)", "Spell scroll (cantrip)", "Spell scroll (cantrip)", "Spell scroll (cantrip)", "Spell scroll (cantrip)",
				//61-70
				"Potion of climbing", "Potion of climbing", "Potion of climbing", "Potion of climbing", "Potion of climbing",
				"Potion of climbing", "Potion of climbing", "Potion of climbing", "Potion of climbing", "Potion of climbing",
				//71-90
				"Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)",
				"Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)",
				"Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)",
				"Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)", "Spell scroll (1st level)",
				//91-94
				"Spell scroll (2nd level)", "Spell scroll (2nd level)", "Spell scroll (2nd level)", "Spell scroll (2nd level)",
				//95-98
				"Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing",
				//99
				"Bag of holding",
				//00
				"Driftglobe"
			};

			public static readonly string[] magic_item_table_b =
			{
				//01-15
				"Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing",
				"Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing",
				"Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing", "Potion of greater healing",
				//16-22
				"Potion of fire breath", "Potion of fire breath", "Potion of fire breath", "Potion of fire breath", "Potion of fire breath", "Potion of fire breath", "Potion of fire breath",
				//23-29
				"Potion of resistance", "Potion of resistance", "Potion of resistance", "Potion of resistance", "Potion of resistance", "Potion of resistance", "Potion of resistance",
				//30-34
				"Ammunition, +1", "Ammunition, +1", "Ammunition, +1", "Ammunition, +1", "Ammunition, +1",
				//35-39
				"Potion of animal friendship", "Potion of animal friendship", "Potion of animal friendship", "Potion of animal friendship", "Potion of animal friendship",
				//40-44
				"Potion of hill giant strength", "Potion of hill giant strength", "Potion of hill giant strength", "Potion of hill giant strength", "Potion of hill giant strength",
				//45-49
				"Potion of growth", "Potion of growth", "Potion of growth", "Potion of growth", "Potion of growth",
				//50-54
				"Potion of water breathing", "Potion of water breathing", "Potion of water breathing", "Potion of water breathing", "Potion of water breathing",
				//55-59
				"Spell scroll (2nd level)", "Spell scroll (2nd level)", "Spell scroll (2nd level)", "Spell scroll (2nd level)", "Spell scroll (2nd level)",
				//60-64
				"Spell scroll (3rd level)", "Spell scroll (3rd level)", "Spell scroll (3rd level)", "Spell scroll (3rd level)", "Spell scroll (3rd level)",
				//65-67
				"Bag of holding", "Bag of holding", "Bag of holding",
				//68-70
				"Keoghtom's ointment", "Keoghtom's ointment", "Keoghtom's ointment",
				//71-73
				"Oil of slipperiness", "Oil of slipperiness", "Oil of slipperiness",
				//74-75
				"Dust of disappearance", "Dust of disappearance",
				//76-77
				"Dust of dryness", "Dust of dryness",
				//78-79
				"Dust of sneezing and choking", "Dust of sneezing and choking",
				//80-81
				"Elemental gem", "Elemental gem",
				//82-83
				"Philter of love", "Philter of love",
				//84
				"Alchemy jug",
				//85
				"Cap of water breathing",
				//86
				"Cloak of the manta ray",
				//87
				"Driftglobe",
				//88
				"Goggles of night",
				//89
				"Helm of comprehending languages",
				//90
				"Immovable rod",
				//91
				"Lantern of revealing",
				//92
				"Mariner's armor",
				//93
				"Mithral armor",
				//94
				"Potion of poison",
				//95
				"Ring of swimming",
				//96
				"Robe of useful items",
				//97
				"Rope of climbing",
				//98
				"Saddle of the cavalier",
				//99
				"Wand of magic detection",
				//00
				"Wand of secrets"
			};

			public static readonly string[] magic_item_table_c =
			{
				//01-15
				"Potion of superior healing", "Potion of superior healing", "Potion of superior healing", "Potion of superior healing", "Potion of superior healing",
				"Potion of superior healing", "Potion of superior healing", "Potion of superior healing", "Potion of superior healing", "Potion of superior healing",
				"Potion of superior healing", "Potion of superior healing", "Potion of superior healing", "Potion of superior healing", "Potion of superior healing",
				//16-22
				"Spell scroll (4th level)", "Spell scroll (4th level)", "Spell scroll (4th level)", "Spell scroll (4th level)", "Spell scroll (4th level)", "Spell scroll (4th level)", "Spell scroll (4th level)",
				//23-27
				"Ammunition, +2", "Ammunition, +2", "Ammunition, +2", "Ammunition, +2", "Ammunition, +2",
				//28-32
				"Potion of clairvoyance", "Potion of clairvoyance", "Potion of clairvoyance", "Potion of clairvoyance", "Potion of clairvoyance",
				//33-37
				"Potion of diminution", "Potion of diminution", "Potion of diminution", "Potion of diminution", "Potion of diminution",
				//38-42
				"Potion of gaseous form", "Potion of gaseous form", "Potion of gaseous form", "Potion of gaseous form", "Potion of gaseous form",
				//43-47
				"Potion of frost giant strength", "Potion of frost giant strength", "Potion of frost giant strength", "Potion of frost giant strength", "Potion of frost giant strength",
				//48-52
				"Potion of stone giant strength", "Potion of stone giant strength", "Potion of stone giant strength", "Potion of stone giant strength", "Potion of stone giant strength",
				//53-57
				"Potion of heroism", "Potion of heroism", "Potion of heroism", "Potion of heroism", "Potion of heroism",
				//58-62
				"Potion of invulnerability", "Potion of invulnerability", "Potion of invulnerability", "Potion of invulnerability", "Potion of invulnerability",
				//63-67
				"Potion of mind reading", "Potion of mind reading", "Potion of mind reading", "Potion of mind reading", "Potion of mind reading",
				//68-72
				"Spell scroll (5th level)", "Spell scroll (5th level)", "Spell scroll (5th level)", "Spell scroll (5th level)", "Spell scroll (5th level)",
				//73-75
				"Elixir of health", "Elixir of health", "Elixir of health",
				//76-78
				"Oil of etherealness", "Oil of etherealness", "Oil of etherealness",
				//79-81
				"Potion of fire giant strength", "Potion of fire giant strength", "Potion of fire giant strength",
				//82-84
				"Quaal's feather token", "Quaal's feather token", "Quaal's feather token",
				//85-87
				"Scroll of protection", "Scroll of protection", "Scroll of protection",
				//88-89
				"Bag of beans", "Bag of beans",
				//90-91
				"Bead of force", "Bead of force",
				//92
				"Chime of opening",
				//93
				"Decanter of endless water",
				//94
				"Eyes of minute seeing",
				//95
				"Folding boat",
				//96
				"Heward's handy haversack",
				//97
				"Horseshoes of speed",
				//98
				"Necklace of fireballs",
				//99
				"Periapt of health",
				//00
				"Sending stones"
			};

			public static readonly string[] magic_item_table_d =
			{
				//01-20
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				//21-30
				"Potion of invisibility", "Potion of invisibility", "Potion of invisibility", "Potion of invisibility", "Potion of invisibility",
				"Potion of invisibility", "Potion of invisibility", "Potion of invisibility", "Potion of invisibility", "Potion of invisibility",
				//31-40
				"Potion of speed", "Potion of speed", "Potion of speed", "Potion of speed", "Potion of speed",
				"Potion of speed", "Potion of speed", "Potion of speed", "Potion of speed", "Potion of speed",
				//41-50
				"Spell scroll (6th level)", "Spell scroll (6th level)", "Spell scroll (6th level)", "Spell scroll (6th level)", "Spell scroll (6th level)",
				"Spell scroll (6th level)", "Spell scroll (6th level)", "Spell scroll (6th level)", "Spell scroll (6th level)", "Spell scroll (6th level)",
				//51-57
				"Spell scroll (7th level)", "Spell scroll (7th level)", "Spell scroll (7th level)", "Spell scroll (7th level)", "Spell scroll (7th level)", "Spell scroll (7th level)", "Spell scroll (7th level)",
				//58-62
				"Ammunition, +3", "Ammunition, +3", "Ammunition, +3", "Ammunition, +3", "Ammunition, +3",
				//63-67
				"Oil of sharpness", "Oil of sharpness", "Oil of sharpness", "Oil of sharpness", "Oil of sharpness",
				//68-72
				"Potion of flying", "Potion of flying", "Potion of flying", "Potion of flying", "Potion of flying",
				//73-77
				"Potion of cloud giant strength", "Potion of cloud giant strength", "Potion of cloud giant strength", "Potion of cloud giant strength", "Potion of cloud giant strength",
				//78-82
				"Potion of longevity", "Potion of longevity", "Potion of longevity", "Potion of longevity", "Potion of longevity",
				//83-87
				"Potion of vitality", "Potion of vitality", "Potion of vitality", "Potion of vitality", "Potion of vitality",
				//88-92
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				//93-95
				"Horseshoes of a zephyr", "Horseshoes of a zephyr", "Horseshoes of a zephyr",
				//96-98
				"Nolzur's marvelous pigments", "Nolzur's marvelous pigments",
				//99
				"Bag of devouring",
				//00
				"Portable hole"
			};

			public static readonly string[] magic_item_table_e =
			{
				//01-30
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				"Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)", "Spell scroll (8th level)",
				//31-55
				"Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength",
				"Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength",
				"Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength", "Potion of storm giant strength",
				//56-70
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				"Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing", "Potion of supreme healing",
				//71-85
				"Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)",
				"Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)",
				"Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)", "Spell scroll (9th level)",
				//86-93
				"Universal solvent", "Universal solvent", "Universal solvent", "Universal solvent", "Universal solvent", "Universal solvent", "Universal solvent", "Universal solvent", 
				//94-98
				"Arrow of slaying", "Arrow of slaying", "Arrow of slaying", "Arrow of slaying", "Arrow of slaying",
				//99-00
				"Sovereign glue", "Sovereign glue"
			};

			public static readonly string[] magic_item_table_f =
			{
				//01-15
				"Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", "Weapon, +1", 
				//16-18
				"Shield, +1", "Shield, +1","Shield, +1",
				//19-21
				"Sentinel shield", "Sentinel shield", "Sentinel shield",
				//22-23
				"Amulet of proof against detection and location", "Amulet of proof against detection and location",
				//24-25
				"Boots of elvenkind", "Boots of elvenkind",
				//26-27
				"Boots of striding and springing", "Boots of striding and springing",
				//28-29
				"Bracers of archery", "Bracers of archery",
				//30-31
				"Brooch of shielding", "Brooch of shielding",
				//32-33
				"Broom of flying", "Broom of flying",
				//34-35
				"Cloak of elvenkind", "Cloak of elvenkind",
				//36-37
				"Cloak of protection", "Cloak of protection",
				//38-39
				"Gauntlets of ogre power", "Gauntlets of ogre power",
				//40-41
				"Hat of disguise", "Hat of disguise",
				//42-43
				"Javelin of lightning", "Javelin of lightning",
				//44-45
				"Pearl of power", "Pearl of power",
				//46-47
				"Rod of the pact keeper, +1", "Rod of the pact keeper, +1",
				//48-49
				"Slippers of spider climbing", "Slippers of spider climbing",
				//50-51
				"Staff of the adder", "Staff of the adder",
				//52-53
				"Staff of the python", "Staff of the python",
				//54-55
				"Sword of vengeance", "Sword of vengeance",
				//56-57
				"Trident of fish command", "Trident of fish command",
				//58-59
				"Wand of magic missiles", "Wand of magic missiles",
				//60-61
				"Wand of the war mage, +1", "Wand of the war mage, +1",
				//62-63
				"Wand of web", "Wand of web",
				//64-65
				"Weapon of warning", "Weapon of warning",
				//66
				"Adamantine armor (chain mail",
				//67
				"Adamantine armor (chain shirt)",
				//68
				"Adamantine armor (scale mail)",
				//69
				"Bag of tricks (gray)",
				//70
				"Bag of tricks (rust)",
				//71
				"Bag of tricks (tan)",
				//72
				"Boots of the winterlands",
				//73
				"Circlet of blasting",
				//74
				"Deck of illusions",
				//75
				"Eversmoking bottle",
				//76
				"Eyes of charming",
				//77
				"Eyes of the eagle",
				//78
				"FIgurine of wondrous power (silver raven)",
				//79
				"Gem of brightness",
				//80
				"Gloves of missile snaring",
				//81
				"Gloves of swimming and climbing",
				//82
				"Gloves of thievery",
				//83
				"Headband of intellect",
				//84
				"Helm of telepathy",
				//85
				"Instrument of the bards (Doss lute)",
				//86
				"Instrument of the bards (Fochlucan bandore)",
				//87
				"Instrument of the bards (Mac-Fuimidh cittern)",
				//88
				"Medallion of thoughts",
				//89
				"Necklace of adaptation",
				//90
				"Periapt of wound closure",
				//91
				"Pipes of haunting",
				//92
				"Pipes of the sewers",
				//93
				"Ring of jumping",
				//94
				"Ring of mind shielding",
				//95
				"Ring of warmth",
				//96
				"Ring of water walking",
				//97
				"Quiver of Ehlonna",
				//98
				"Stone of good luck",
				//99
				"Wind fan",
				//00
				"Winged boots"
			};

			public static readonly string[] magic_item_table_g =
			{
				//01-11
				"Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", "Weapon, +2", 
				//12-14
				"Figurine of wondrous power (roll d8), 1 - Bronze griffon, 2 - Ebony fly, 3 - Golden lions, 4 - Ivory goats, 5 - Marble elephant, 6-7 - Onyx dog, 8 - Serpentine owl",
				"Figurine of wondrous power (roll d8), 1 - Bronze griffon, 2 - Ebony fly, 3 - Golden lions, 4 - Ivory goats, 5 - Marble elephant, 6-7 - Onyx dog, 8 - Serpentine owl",
				// the rest of the items are individual, starting at 15
				"Adamantine armor (breastplate)",
				"Adamantine armor (splint)",
				"Amulet of health",
				"Armor of vulnerability",
				"Arrow-catching shield",
				"Belt of dwarvenkind",
				"Belt of hill giant strength",
				"Berserker axe",
				"Boots of levitation",
				"Boots of speed",
				"Bowl of commanding water elementals",
				"Bracers of defense",
				"Brazier of commanding fire elementals",
				"Cape of the mountebank",
				"Censer of controlling air elementals",
				"Armor, +1 chain mail",
				"Armor of resistance (chain mail)",
				"Armor, +1 chain shirt",
				"Armor of resistance (chain shirt)",
				"Cloak of displacement",
				"Cloak of the bat",
				"Cube of force",
				"Daern's instant fortress",
				"Dagger of venom",
				"Dimensional shackles",
				"Dragon slayer",
				"Elven chain",
				"Flame tongue",
				"Gem of seeing",
				"Giant slayer",
				"Glamoured studded leather",
				"Helm of teleportation",
				"Horn of blasting",
				"Horn of Valhalla (silver or brass)",
				"Instrument of the bards (Canaith mandolin)",
				"Instrument of the bards (Cli lyre)",
				"Ioun stone (awareness)",
				"Ioun stone (protection)",
				"Ioun stone (reserve)",
				"Ioun stone (sustenance)",
				"Iron bands of Bilarro",
				"Armor, +1 leather",
				"Armor of resistance (leather)",
				"Mace of disruption",
				"Mace of smiting",
				"Mace of terror",
				"Mantle of spell resistance",
				"Necklace of prayer beads",
				"Periapt of proof against poison",
				"Ring of animal influence",
				"Ring of evasion",
				"Ring of feather falling",
				"Ring of free action",
				"Ring of protection",
				"Ring of resistance",
				"Ring of spell storing",
				"Ring of the ram",
				"Ring of X-ray vision",
				"Robe of eyes",
				"Rod of rulership",
				"Rod of the pact keeper, +2",
				"Rope of entanglement",
				"Armor, +1 scale mail",
				"Armor of resistance (scale mail)",
				"Shield, +2",
				"Shield of missile attraction",
				"Staff of charming",
				"Staff of healing",
				"Staff of swarming insects",
				"Staff of the woodlands",
				"Staff of withering",
				"Stone of controlling earth elementals",
				"Sun blade",
				"Sword of life stealing",
				"Sword of wounding",
				"Tentacle rod",
				"Vicious weapon",
				"Wand of binding",
				"Wand of enemy detection",
				"Wand of fear",
				"Wand of fireballs",
				"Wand of lightning bolts",
				"Wand of paralysis",
				"Wand of the war mage, +2",
				"Wand of wonder",
				"Wings of flying"
			};

			public static readonly string[] magic_item_table_h =
			{
				//01-10
				"Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", "Weapon, +3", 
				//11-12
				"Amulet of the planes", "Amulet of the planes",
				//12-14
				"Carpet of flying", "Carpet of flying", "Carpet of flying",
				//15-16
				"Crystal ball (very rare version)", "Crystal ball (very rare version)",
				//17-18
				"Ring of regeneration", "Ring of regeneration",
				//19-20
				"Ring of shooting stars", "Ring of shooting stars",
				//21-22
				"Ring of telekinesis", "Ring of telekinesis",
				//23-24
				"Robe of scintillating colors", "Robe of scintillating colors",
				//25-26
				"Robe of stars", "Robe of stars",
				//27-28
				"Rod of absorption", "Rod of absorption",
				//29-30
				"Rod of alertness", "Rod of alertness",
				//31-32
				"Rod of security", "Rod of security",
				//33-34
				"Rod of the pact keeper, +3", "Rod of the pact keeper, +3",
				//35-36
				"Scimitar of speed", "Scimitar of speed",
				//37-38
				"Shield, +3", "Shield, +3",
				//39-40
				"Staff of fire", "Staff of fire",
				//41-42
				"Staff of frost", "Staff of frost",
				//43-44
				"Staff of power", "Staff of power",
				//45-46
				"Staff of striking", "Staff of striking",
				//47-48
				"Staff of thunder and lightning", "Staff of thunder and lightning",
				//49-50
				"Sword of sharpness", "Sword of sharpness",
				//51-52
				"Wand of polymorph", "Wand of polymorph",
				//53-54
				"Wand of the war mage, +3", "Wand of the war mage, +3",
				// the remaining items are sequential, starting at 55
				"Adamantine armor (half plate)",
				"Adamantine armor (plate)",
				"Animated shield",
				"Belt of fire giant strength",
				"Belt of frost (or stone) giant strength",
				"Armor, +1 breastplate",
				"Armor of resistance (breastplate)",
				"Candle of invocation",
				"Armor, +2 chain mail",
				"Armor, +2 chain shirt",
				"Cloak of arachnida",
				"Dancing sword",
				"Demon armor",
				"Dragon scale mail",
				"Dwarven plate",
				"Dwarven thrower",
				"Efreeti bottle",
				"Figurine of wondrous poer (obsidian steed)",
				"Frost brand",
				"Helm of briliance",
				"Horn of Valhalla (bronze)",
				"Instrument of the bards (Anstruth harp)",
				"Ioun stone (absorption)",
				"Ioun stone (agility)",
				"Ioun stone (fortitude)",
				"Ioun stone (insight)",
				"Ioun stone (intellect)",
				"Ioun stone (leadership)",
				"Ioun stone (strength)",
				"Armor, +2 leather",
				"Manual of bodily health",
				"Manual of gainful exercise",
				"Manual of golems",
				"Manual of quickness of action",
				"Mirror of life trapping",
				"Nine lives stealer",
				"Oathbow",
				"Armor, +2 scale mail",
				"Spellguard shield",
				"Armor, +1 splint",
				"Armor of resistance (splint)",
				"Armor, +1 studded leather",
				"Armor of resistance (studded leather)",
				"Tome of clear thought",
				"Tome of leadership and influence",
				"Tome of understanding"
			};

			public static readonly string[] magic_item_table_i =
			{
				//01-05
				"Defender", "Defender", "Defender", "Defender", "Defender", 
				//06-10
				"Hammer of thunderbolts", "Hammer of thunderbolts", "Hammer of thunderbolts", "Hammer of thunderbolts", "Hammer of thunderbolts", 
				//11-15
				"Luck blade", "Luck blade", "Luck blade", "Luck blade", "Luck blade", 
				//16-20
				"Sword of answering", "Sword of answering", "Sword of answering", "Sword of answering", "Sword of answering", 
				//21-23
				"Holy avenger", "Holy avenger", "Holy avenger", 
				//24-26
				"Ring of djinni summoning", "Ring of djinni summoning", "Ring of djinni summoning",
				//27-29
				"Ring of invisibility", "Ring of invisibility", "Ring of invisibility",
				//30-32
				"Ring of spell turning", "Ring of spell turning", "Ring of spell turning",
				//33-35
				"Rod of lordly might", "Rod of lordly might", "Rod of lordly might",
				//36-38
				"Staff of the magi", "Staff of the magi", "Staff of the magi",
				//39-41
				"Vorpal sword", "Vorpal sword", "Vorpal sword",
				//42-43
				"Belt of cloud giant strength", "Belt of cloud giant strength",
				//44-45
				"Armor, +2 breastplate", "Armor, +2 breastplate",
				//46-47
				"Armor, +3 chain mail", "Armor, +3 chain mail",
				//48-49
				"Armor, +3 chain shirt", "Armor, +3 chain shirt",
				//50-51
				"Cloak of invisibility", "Cloak of invisibility",
				//52-53
				"Crystal ball (legendary version)", "Crystal ball (legendary version)",
				//54-55
				"Armor, +1 half plate", "Armor, +1 half plate",
				//56-57
				"Iron flask", "Iron flask",
				//58-59
				"Armor, +3 leather", "Armor, +3 leather",
				//60-61
				"Armor, +1 plate", "Armor, +1 plate",
				//62-63
				"Robe of the archmagi", "Robe of the archmagi",
				//64-65
				"Rod of resurrection", "Rod of resurrection",
				//66-67
				"Armor, +1 scale mail", "Armor, +1 scale mail",
				//68-69
				"Scarab of protection", "Scarab of protection",
				//70-71
				"Armor, +2 splint", "Armor, +2 splint",
				//72-73
				"Armor, +2 studded leather", "Armor, +2 studded leather",
				//74-75
				"Well of many worlds", "Well of many worlds",
				// the remaining items are sequential, starting at 76
				"Magic armor (roll d12), 1-2 - Armor, +2 half plate, 3-4 - Armor, +2 plate, 5-6 - Armor, +3 studded leather, 7-8 - Armor, +3 breastplate, 9-10 - Armor, +3 splint, 11 - Armor, +3 half plate, 12 - Armor, +3 plate",
				"Apparatus of Kwalish",
				"Armor of invulnerability",
				"Belt of storm giant strength",
				"Cubic gate",
				"Deck of many things",
				"Efreeti chain",
				"Armor of resistance (half plate)",
				"Horn of Valhalla (iron)",
				"Instrument of the bards (Ollamh harp)",
				"Ioun stone (greater absorption)",
				"Ioun stone (mastery)",
				"Ioun stone (regeneration)",
				"Plate armor of etherealness",
				"Plate armor of resistance",
				"Ring of air elemental command",
				"Ring of earth elemental command",
				"Ring of fire elemental command",
				"Ring of three wishes",
				"Ring of water elemental command",
				"Sphere of annihilation",
				"Talisman of pure good",
				"Talisman of the sphere",
				"Talisman of ultimate evil",
				"Tome of the stilled tongue"
			};

			public static readonly string[] creating_sentient_magic_items_communication =
			{
				//01-60
				"The item communicates by transmitting emotion to the creature carrying or wielding it",
				"The item communicates by transmitting emotion to the creature carrying or wielding it",
				"The item communicates by transmitting emotion to the creature carrying or wielding it",
				"The item communicates by transmitting emotion to the creature carrying or wielding it",
				"The item communicates by transmitting emotion to the creature carrying or wielding it",
				"The item communicates by transmitting emotion to the creature carrying or wielding it",
				//61-90
				"The item can speak, read, and understand one or more languages",
				"The item can speak, read, and understand one or more languages",
				"The item can speak, read, and understand one or more languages",
				//91-00
				"The item can speak, read, and understand one or more languages. In addition, the item can communicate telepathically with any character that carries or wields it"
			};

			public static readonly string[] creating_sentient_magic_items_senses =
			{
				"Hearing and normal vision out to 30 feet",
				"Hearing and normal vision out to 60 feet",
				"Hearing and normal vision out to 120 feet",
				"Hearing and darkvision out to 120 feet"
			};

			public static readonly string[] creating_sentient_magic_items_alignment =
			{
				//01-15
				"Lawful good", "Lawful good", "Lawful good", "Lawful good", "Lawful good",
				"Lawful good", "Lawful good", "Lawful good", "Lawful good", "Lawful good",
				"Lawful good", "Lawful good", "Lawful good", "Lawful good", "Lawful good",
				//16-35
				"Neutral good", "Neutral good", "Neutral good", "Neutral good", "Neutral good",
				"Neutral good", "Neutral good", "Neutral good", "Neutral good", "Neutral good",
				"Neutral good", "Neutral good", "Neutral good", "Neutral good", "Neutral good",
				"Neutral good", "Neutral good", "Neutral good", "Neutral good", "Neutral good",
				//36-50
				"Chaotic good", "Chaotic good", "Chaotic good", "Chaotic good", "Chaotic good",
				"Chaotic good", "Chaotic good", "Chaotic good", "Chaotic good", "Chaotic good",
				"Chaotic good", "Chaotic good", "Chaotic good", "Chaotic good", "Chaotic good",
				//51-63
				"Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral",
				"Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral", "Lawful neutral",
				//64-73
				"Neutral", "Neutral", "Neutral", "Neutral", "Neutral", "Neutral", "Neutral", "Neutral", "Neutral", "Neutral",
				//74-85
				"Chaotic neutral", "Chaotic neutral", "Chaotic neutral", "Chaotic neutral", "Chaotic neutral", "Chaotic neutral",
				"Chaotic neutral", "Chaotic neutral", "Chaotic neutral", "Chaotic neutral", "Chaotic neutral", "Chaotic neutral", 
				//86-89
				"Lawful evil", "Lawful evil", "Lawful evil", "Lawful evil",
				//90-96
				"Neutral evil", "Neutral evil", "Neutral evil", "Neutral evil", "Neutral evil", "Neutral evil",
				//97-00
				"Chaotic evil", "Chaotic evil", "Chaotic evil", "Chaotic evil"
			};

			public static readonly string[] creating_sentient_magic_items_special_purpose =
			{
				"Aligned: The item seeks to defeat or destroy those of a diametrically opposed alignment. (Such an item is never neutral.)",
				"Bane: The item seeks to defeat or destroy creatures of a particular kind, such as fiends, shapechangers, trolls, or wizards",
				"Protector: The item seeks to defend a particular race or kind of creature, such as elves or druids",
				"Crusader: The item seeks to defeat, weaken, or destroy the servants of a particular deity",
				"Templar: The item seeks to defend the servants and interests of a particular deity.",
				"Destroyer: The item craves destruction and goads its user to fight arbitrarily",
				"Glory Seeker: The item seeks renown as the greatest magic item in the world, by establishing its user as a famous or notorious figure",
				"Lore seeker: The item craves knowledge or is determined to solve a mystery, learn a secret, or unravel a cryptic prophecy",
				"Destiny seeker: The item is convinced that it and its wielder have key roles to play in future events",
				"Creator Seeker: The item seeks its creator and wants to understand why it was created"
			};

			public static readonly string[] moonblade_properties =
			{
				//01-40
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				"Increase the bonus to attack and damage rolls by 1, to a maximum of +3. Reroll if the moonblade already has a +3 bonus",
				//41-80
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				"The moonblade gains a randomly determined minor property (see \"Special Features\" earlier in this chapter)",
				//81-82
				"The moonblade gains the finesse property",
				"The moonblade gains the finesse property",
				//83-84
				"The moonblade gains the thrown property (range 20/60 feet)",
				"The moonblade gains the thrown property (range 20/60 feet)",
				//85-86
				"The moonblade functions as a defender",
				"The moonblade functions as a defender",
				//87-90
				"The moonblade scroes a critical hit on a roll of 19 or 20",
				"The moonblade scroes a critical hit on a roll of 19 or 20",
				"The moonblade scroes a critical hit on a roll of 19 or 20",
				"The moonblade scroes a critical hit on a roll of 19 or 20",
				//91-92
				"When you hit with an attack using the moonblade, the attack deals an extra 1d6 slashing damage",
				"When you hit with an attack using the moonblade, the attack deals an extra 1d6 slashing damage",
				//93-94
				"When you hit a creature of a specific type (such as dragon, fiend, or undead) with the moonblade, the target takes an extra 1d6 damage of one of these types: acid, cold, fire, lightning, or thunder",
				"When you hit a creature of a specific type (such as dragon, fiend, or undead) with the moonblade, the target takes an extra 1d6 damage of one of these types: acid, cold, fire, lightning, or thunder",
				//95-96
				"You can use a bonus action to cause the moonblade to flash brightly. Each creature that can see you and is within 30 feet of you must succeed on a DC 15 Constitution saving throw or become blinded for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. This property can't be used again until you take a short rest while attuned to the weapon",
				"You can use a bonus action to cause the moonblade to flash brightly. Each creature that can see you and is within 30 feet of you must succeed on a DC 15 Constitution saving throw or become blinded for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. This property can't be used again until you take a short rest while attuned to the weapon",
				//97-98
				"The moonblade functions as a ring of spell storing", "The moonblade functions as a ring of spell storing",
				//99
				"You can use an action to call forth an elfshadow, provided that you don't already have one serving you. The elfshadow appears in an unoccupied space within 120 feet of you. It uses the statistics for a shadow from the Monster Manual, except it is neutral, immune to effects that turn undead, and doesn't create new shadows. You control this creature, deciding how it acts and moves. It remains until it drops to 0 hit points or you dismiss it as an action",
				//00
				"The moonblade functions as a vorpal sword"
			};

			public static readonly string[] minor_beneficial_properties =
			{
				//01-20
				"While attuned to the artifact, you gain proficiency in one skill of the DM's choice",
				"While attuned to the artifact, you gain proficiency in one skill of the DM's choice",
				//21-30
				"While attuned to the artifact, you are immune to disease",
				//31-40
				"While attuned to the artifact, you can't be charmed or frightened",
				//41-50
				"While attuned to the artifact, you have resistance against one damage type of the DM's choice",
				//51-60
				"While attuned to the artifact, you can use an action to cast one cantrip (chosen by the DM) from it",
				//61-70
				"While attuned to the artifact, you can use an action to cast one 1st-level spell (chosen by the DM) from it. After you cast the spell, roll a d6. On a roll of 1-5, you can't cast it again until the next dawn",
				//71-80
				"As 61-70 above, except the spell is 2nd level",
				//81-90
				"As 61-70 above, except the spell is 3rd level",
				//91-00
				"While attuned to the artifact, you gain a +1 bonus to Armor Class"
			};

			public static readonly string[] major_beneficial_properties =
			{
				//01-20
				"While attuned to the artifact, one of your ability scores (DM's choice) increases by 2, to a maximum of 24",
				"While attuned to the artifact, one of your ability scores (DM's choice) increases by 2, to a maximum of 24",
				//21-30
				"While attuned to the artifact, you regain 1d6 hit points at the start of your turn if you have at least 1 hit point",
				//31-40
				"When you hit with a weapon attack while attuned to the artifact, the target takes an extra 1d6 damage of the weapon's type",
				//41-50
				"While attuned to the artifact, your walking speed increases by 10 feet",
				//51-60
				"While attuned to the artifact, you can use an action to cast one 4th-level spell (chosen by the DM) from it. After you cast the spell, roll a d6. On a roll of 1-5, you can't cast it again until the next dawn",
				//61-70
				"As 51-60 above, except the spell is 5th level",
				//71-80
				"As 51-60 above, except the spell is 6th level",
				//81-90
				"As 51-60 above, except the spell is 7th level",
				//91-00
				"While attuned to the artifact, you can't be blinded, deafened, petrified, or stunned"
			};

			public static readonly string[] minor_detrimental_properties =
			{
				//01-05
				"While attuned to the artifact, you have disadvantage on saving throws against spells",
				"While attuned to the artifact, you have disadvantage on saving throws against spells",
				"While attuned to the artifact, you have disadvantage on saving throws against spells",
				"While attuned to the artifact, you have disadvantage on saving throws against spells",
				"While attuned to the artifact, you have disadvantage on saving throws against spells",
				//06-10
				"The first time you touch a gem or piece of jewelry while attuned to this artifact, the value of the gem or jewelry is reduced by half",
				"The first time you touch a gem or piece of jewelry while attuned to this artifact, the value of the gem or jewelry is reduced by half",
				"The first time you touch a gem or piece of jewelry while attuned to this artifact, the value of the gem or jewelry is reduced by half",
				"The first time you touch a gem or piece of jewelry while attuned to this artifact, the value of the gem or jewelry is reduced by half",
				"The first time you touch a gem or piece of jewelry while attuned to this artifact, the value of the gem or jewelry is reduced by half",
				//11-15
				"While attuned to the artifact, you are blinded when you are more than 10 feet away from it",
				"While attuned to the artifact, you are blinded when you are more than 10 feet away from it",
				"While attuned to the artifact, you are blinded when you are more than 10 feet away from it",
				"While attuned to the artifact, you are blinded when you are more than 10 feet away from it",
				"While attuned to the artifact, you are blinded when you are more than 10 feet away from it",
				//16-20
				"While attuned to the artifact, you have disadvantage on saving throws against poison",
				"While attuned to the artifact, you have disadvantage on saving throws against poison",
				"While attuned to the artifact, you have disadvantage on saving throws against poison",
				"While attuned to the artifact, you have disadvantage on saving throws against poison",
				"While attuned to the artifact, you have disadvantage on saving throws against poison",
				//21-30
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				"While attuned to the artifact, you emit a sour stench noticeable from up to 10 feet away",
				//31-35
				"While attuned to the artifact, all holy water within 10 feet of you is destroyed",
				"While attuned to the artifact, all holy water within 10 feet of you is destroyed",
				"While attuned to the artifact, all holy water within 10 feet of you is destroyed",
				"While attuned to the artifact, all holy water within 10 feet of you is destroyed",
				"While attuned to the artifact, all holy water within 10 feet of you is destroyed",
				//36-40
				"While attuned to the artifact, you are physically ill and have disadvantage on any ability check or saving throw that uses Strength or Constitution",
				"While attuned to the artifact, you are physically ill and have disadvantage on any ability check or saving throw that uses Strength or Constitution",
				"While attuned to the artifact, you are physically ill and have disadvantage on any ability check or saving throw that uses Strength or Constitution",
				"While attuned to the artifact, you are physically ill and have disadvantage on any ability check or saving throw that uses Strength or Constitution",
				"While attuned to the artifact, you are physically ill and have disadvantage on any ability check or saving throw that uses Strength or Constitution",
				//41-45
				"While attuned to the artifact, your weight increases by 1d4 x 10 pounds",
				"While attuned to the artifact, your weight increases by 1d4 x 10 pounds",
				"While attuned to the artifact, your weight increases by 1d4 x 10 pounds",
				"While attuned to the artifact, your weight increases by 1d4 x 10 pounds",
				"While attuned to the artifact, your weight increases by 1d4 x 10 pounds",
				//46-50
				"While attuned to the artifact, your appearance changes as the DM decides",
				"While attuned to the artifact, your appearance changes as the DM decides",
				"While attuned to the artifact, your appearance changes as the DM decides",
				"While attuned to the artifact, your appearance changes as the DM decides",
				"While attuned to the artifact, your appearance changes as the DM decides",
				//51-55
				"While attuned to the artifact, you are deafened when you are more than 10 feet away from it",
				"While attuned to the artifact, you are deafened when you are more than 10 feet away from it",
				"While attuned to the artifact, you are deafened when you are more than 10 feet away from it",
				"While attuned to the artifact, you are deafened when you are more than 10 feet away from it",
				"While attuned to the artifact, you are deafened when you are more than 10 feet away from it",
				//56-60
				"While attuned to the artifact, your weight drops by 1d4 x 5 puounds",
				"While attuned to the artifact, your weight drops by 1d4 x 5 puounds",
				"While attuned to the artifact, your weight drops by 1d4 x 5 puounds",
				"While attuned to the artifact, your weight drops by 1d4 x 5 puounds",
				"While attuned to the artifact, your weight drops by 1d4 x 5 puounds",
				//61-65
				"While attuned to the artifact, you can't smell",
				"While attuned to the artifact, you can't smell",
				"While attuned to the artifact, you can't smell",
				"While attuned to the artifact, you can't smell",
				"While attuned to the artifact, you can't smell",
				//66-70
				"While attuned to the artifact, nonmagical flames are extinguished within 30 feet of you",
				"While attuned to the artifact, nonmagical flames are extinguished within 30 feet of you",
				"While attuned to the artifact, nonmagical flames are extinguished within 30 feet of you",
				"While attuned to the artifact, nonmagical flames are extinguished within 30 feet of you",
				"While attuned to the artifact, nonmagical flames are extinguished within 30 feet of you",
				//71-80
				"While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you", "While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you",
				"While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you", "While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you",
				"While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you", "While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you",
				"While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you", "While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you",
				"While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you", "While attuned to the artifact, other creatures can't take short or long rests while within 300 feet of you",
				//81-85
				"While attuned to the artifact, you deal 1d6 necrotic damage to any plant you touch that isn't a creature",
				"While attuned to the artifact, you deal 1d6 necrotic damage to any plant you touch that isn't a creature",
				"While attuned to the artifact, you deal 1d6 necrotic damage to any plant you touch that isn't a creature",
				"While attuned to the artifact, you deal 1d6 necrotic damage to any plant you touch that isn't a creature",
				"While attuned to the artifact, you deal 1d6 necrotic damage to any plant you touch that isn't a creature",
				//86-90
				"While attuned to the artifact, animals within 30 feet of you are hostile toward you",
				"While attuned to the artifact, animals within 30 feet of you are hostile toward you",
				"While attuned to the artifact, animals within 30 feet of you are hostile toward you",
				"While attuned to the artifact, animals within 30 feet of you are hostile toward you",
				"While attuned to the artifact, animals within 30 feet of you are hostile toward you",
				//91-95
				"While attuned to the artifact, you must eat and drink sixt times the normal amount each day",
				"While attuned to the artifact, you must eat and drink sixt times the normal amount each day",
				"While attuned to the artifact, you must eat and drink sixt times the normal amount each day",
				"While attuned to the artifact, you must eat and drink sixt times the normal amount each day",
				"While attuned to the artifact, you must eat and drink sixt times the normal amount each day",
				//96-00
				"While attuned to the artifact, your flaw is amplified in a way determined by the DM",
				"While attuned to the artifact, your flaw is amplified in a way determined by the DM",
				"While attuned to the artifact, your flaw is amplified in a way determined by the DM",
				"While attuned to the artifact, your flaw is amplified in a way determined by the DM",
				"While attuned to the artifact, your flaw is amplified in a way determined by the DM"
			};

			public static readonly string[] major_detrimental_properties =
			{
				//01-05
				"While you are attuned to the artifact, your body rots over the course of four days, after which the rotting stops. You lose your hair by the end of day 1, finger tips and toe tips by the end of day 2, lips and nose by the end of day 3, and ears by the end of day 4. A regenerate spell restores lost body parts",
				"While you are attuned to the artifact, your body rots over the course of four days, after which the rotting stops. You lose your hair by the end of day 1, finger tips and toe tips by the end of day 2, lips and nose by the end of day 3, and ears by the end of day 4. A regenerate spell restores lost body parts",
				"While you are attuned to the artifact, your body rots over the course of four days, after which the rotting stops. You lose your hair by the end of day 1, finger tips and toe tips by the end of day 2, lips and nose by the end of day 3, and ears by the end of day 4. A regenerate spell restores lost body parts",
				"While you are attuned to the artifact, your body rots over the course of four days, after which the rotting stops. You lose your hair by the end of day 1, finger tips and toe tips by the end of day 2, lips and nose by the end of day 3, and ears by the end of day 4. A regenerate spell restores lost body parts",
				"While you are attuned to the artifact, your body rots over the course of four days, after which the rotting stops. You lose your hair by the end of day 1, finger tips and toe tips by the end of day 2, lips and nose by the end of day 3, and ears by the end of day 4. A regenerate spell restores lost body parts",
				//06-10
				"While you are attuned to the artifact, you determine your alignment daily at dawn by rolling a d6 twice. On the first roll, a 1-2 indicates lawful, 3-4 neutral, and 5-6 chaotic. On the second roll, a 1-2 indicates good, 3-4 neutral, and 5-6 evil",
				"While you are attuned to the artifact, you determine your alignment daily at dawn by rolling a d6 twice. On the first roll, a 1-2 indicates lawful, 3-4 neutral, and 5-6 chaotic. On the second roll, a 1-2 indicates good, 3-4 neutral, and 5-6 evil",
				"While you are attuned to the artifact, you determine your alignment daily at dawn by rolling a d6 twice. On the first roll, a 1-2 indicates lawful, 3-4 neutral, and 5-6 chaotic. On the second roll, a 1-2 indicates good, 3-4 neutral, and 5-6 evil",
				"While you are attuned to the artifact, you determine your alignment daily at dawn by rolling a d6 twice. On the first roll, a 1-2 indicates lawful, 3-4 neutral, and 5-6 chaotic. On the second roll, a 1-2 indicates good, 3-4 neutral, and 5-6 evil",
				"While you are attuned to the artifact, you determine your alignment daily at dawn by rolling a d6 twice. On the first roll, a 1-2 indicates lawful, 3-4 neutral, and 5-6 chaotic. On the second roll, a 1-2 indicates good, 3-4 neutral, and 5-6 evil",
				//11-15
				"When you first attune to the artifact, it gives you a quest determined by the DM. You must complete this quest as if affected by the geas spell. Once you complete the quest, you are no longer affected by this property",
				"When you first attune to the artifact, it gives you a quest determined by the DM. You must complete this quest as if affected by the geas spell. Once you complete the quest, you are no longer affected by this property",
				"When you first attune to the artifact, it gives you a quest determined by the DM. You must complete this quest as if affected by the geas spell. Once you complete the quest, you are no longer affected by this property",
				"When you first attune to the artifact, it gives you a quest determined by the DM. You must complete this quest as if affected by the geas spell. Once you complete the quest, you are no longer affected by this property",
				"When you first attune to the artifact, it gives you a quest determined by the DM. You must complete this quest as if affected by the geas spell. Once you complete the quest, you are no longer affected by this property",
				//16-20
				"The artifact houses a bodiless life force that is hostile toward you. Each time you use an action to use one of the artifact's properties, there is a 50 percent chance that the life force tries to leave the artifact and enter your body. If you fail a DC 20 Charisma saving throw, it succeeds, and you become an NPC under the DM's control until the intruding life force is banished using magic such as the dispel evil and good spell",
				"The artifact houses a bodiless life force that is hostile toward you. Each time you use an action to use one of the artifact's properties, there is a 50 percent chance that the life force tries to leave the artifact and enter your body. If you fail a DC 20 Charisma saving throw, it succeeds, and you become an NPC under the DM's control until the intruding life force is banished using magic such as the dispel evil and good spell",
				"The artifact houses a bodiless life force that is hostile toward you. Each time you use an action to use one of the artifact's properties, there is a 50 percent chance that the life force tries to leave the artifact and enter your body. If you fail a DC 20 Charisma saving throw, it succeeds, and you become an NPC under the DM's control until the intruding life force is banished using magic such as the dispel evil and good spell",
				"The artifact houses a bodiless life force that is hostile toward you. Each time you use an action to use one of the artifact's properties, there is a 50 percent chance that the life force tries to leave the artifact and enter your body. If you fail a DC 20 Charisma saving throw, it succeeds, and you become an NPC under the DM's control until the intruding life force is banished using magic such as the dispel evil and good spell",
				"The artifact houses a bodiless life force that is hostile toward you. Each time you use an action to use one of the artifact's properties, there is a 50 percent chance that the life force tries to leave the artifact and enter your body. If you fail a DC 20 Charisma saving throw, it succeeds, and you become an NPC under the DM's control until the intruding life force is banished using magic such as the dispel evil and good spell",
				//21-25
				"Creatures with a challenge rating of 0, as well as plants that aren't creatures, drop to 0 hit points when within 10 feet of the artifact",
				"Creatures with a challenge rating of 0, as well as plants that aren't creatures, drop to 0 hit points when within 10 feet of the artifact",
				"Creatures with a challenge rating of 0, as well as plants that aren't creatures, drop to 0 hit points when within 10 feet of the artifact",
				"Creatures with a challenge rating of 0, as well as plants that aren't creatures, drop to 0 hit points when within 10 feet of the artifact",
				"Creatures with a challenge rating of 0, as well as plants that aren't creatures, drop to 0 hit points when within 10 feet of the artifact",
				//26-30
				"The artifact imprisons a death slaad (see the Monster Manual). Each time you use one of the artifact's properties as an action, the slaad has a 10 percent chance of escaping, whereupon it appears within 15 feet of you and attacks you",
				"The artifact imprisons a death slaad (see the Monster Manual). Each time you use one of the artifact's properties as an action, the slaad has a 10 percent chance of escaping, whereupon it appears within 15 feet of you and attacks you",
				"The artifact imprisons a death slaad (see the Monster Manual). Each time you use one of the artifact's properties as an action, the slaad has a 10 percent chance of escaping, whereupon it appears within 15 feet of you and attacks you",
				"The artifact imprisons a death slaad (see the Monster Manual). Each time you use one of the artifact's properties as an action, the slaad has a 10 percent chance of escaping, whereupon it appears within 15 feet of you and attacks you",
				"The artifact imprisons a death slaad (see the Monster Manual). Each time you use one of the artifact's properties as an action, the slaad has a 10 percent chance of escaping, whereupon it appears within 15 feet of you and attacks you",
				//31-35
				"While you are attuned to the artifact, creatures of a particular type other than humanoid (as chosen by the DM) are always hostile toward you",
				"While you are attuned to the artifact, creatures of a particular type other than humanoid (as chosen by the DM) are always hostile toward you",
				"While you are attuned to the artifact, creatures of a particular type other than humanoid (as chosen by the DM) are always hostile toward you",
				"While you are attuned to the artifact, creatures of a particular type other than humanoid (as chosen by the DM) are always hostile toward you",
				"While you are attuned to the artifact, creatures of a particular type other than humanoid (as chosen by the DM) are always hostile toward you",
				//36-40
				"The artifact dilutes magic potions within 10 feet of it, rendering them nonmagical",
				"The artifact dilutes magic potions within 10 feet of it, rendering them nonmagical",
				"The artifact dilutes magic potions within 10 feet of it, rendering them nonmagical",
				"The artifact dilutes magic potions within 10 feet of it, rendering them nonmagical",
				"The artifact dilutes magic potions within 10 feet of it, rendering them nonmagical",
				//41-45
				"The artifact erases magic scrolls within 10 feet of it, rendering them nonmagical",
				"The artifact erases magic scrolls within 10 feet of it, rendering them nonmagical",
				"The artifact erases magic scrolls within 10 feet of it, rendering them nonmagical",
				"The artifact erases magic scrolls within 10 feet of it, rendering them nonmagical",
				"The artifact erases magic scrolls within 10 feet of it, rendering them nonmagical",
				//46-50
				"Before useing one of the artifact's properties as an action, you must use a bonus action to draw blood, either from yourself or from a willing or incapacitated creature within your reach, using a piercing or slashing melee weapon. THe subject takes 1d4 damage of the appropriate type.",
				"Before useing one of the artifact's properties as an action, you must use a bonus action to draw blood, either from yourself or from a willing or incapacitated creature within your reach, using a piercing or slashing melee weapon. THe subject takes 1d4 damage of the appropriate type.",
				"Before useing one of the artifact's properties as an action, you must use a bonus action to draw blood, either from yourself or from a willing or incapacitated creature within your reach, using a piercing or slashing melee weapon. THe subject takes 1d4 damage of the appropriate type.",
				"Before useing one of the artifact's properties as an action, you must use a bonus action to draw blood, either from yourself or from a willing or incapacitated creature within your reach, using a piercing or slashing melee weapon. THe subject takes 1d4 damage of the appropriate type.",
				"Before useing one of the artifact's properties as an action, you must use a bonus action to draw blood, either from yourself or from a willing or incapacitated creature within your reach, using a piercing or slashing melee weapon. THe subject takes 1d4 damage of the appropriate type.",
				//51-60
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				"When you become attuned to the artifact, you gain a form of long-term madness (see chapter 8, \"Running the Game\")",
				//61-65
				"You take 4d10 psychic damage when you become attuned to the artifact",
				"You take 4d10 psychic damage when you become attuned to the artifact",
				"You take 4d10 psychic damage when you become attuned to the artifact",
				"You take 4d10 psychic damage when you become attuned to the artifact",
				"You take 4d10 psychic damage when you become attuned to the artifact",
				//66-70
				"You take 8d10 psychic damage when you become attuned to the artifact",
				"You take 8d10 psychic damage when you become attuned to the artifact",
				"You take 8d10 psychic damage when you become attuned to the artifact",
				"You take 8d10 psychic damage when you become attuned to the artifact",
				"You take 8d10 psychic damage when you become attuned to the artifact",
				//71-75
				"Before you can become attuned to the artifact, you must kill a creature of your alignment",
				"Before you can become attuned to the artifact, you must kill a creature of your alignment",
				"Before you can become attuned to the artifact, you must kill a creature of your alignment",
				"Before you can become attuned to the artifact, you must kill a creature of your alignment",
				"Before you can become attuned to the artifact, you must kill a creature of your alignment",
				//76-80
				"When you become attuned to the artifact, one of your ability scores is reduced by 2 at random. A greater restoration spell restores the ability to normal",
				"When you become attuned to the artifact, one of your ability scores is reduced by 2 at random. A greater restoration spell restores the ability to normal",
				"When you become attuned to the artifact, one of your ability scores is reduced by 2 at random. A greater restoration spell restores the ability to normal",
				"When you become attuned to the artifact, one of your ability scores is reduced by 2 at random. A greater restoration spell restores the ability to normal",
				"When you become attuned to the artifact, one of your ability scores is reduced by 2 at random. A greater restoration spell restores the ability to normal",
				//81-85
				"Each time you become attuned to the artifact, you age 3d10 years. You must succeed on a DC 10 Consitution saving throw or die from the shock. If you die, you are instantly transformed into a wight (see the Monster Manual) under the DM's control that is sworn to protect the artifact",
				"Each time you become attuned to the artifact, you age 3d10 years. You must succeed on a DC 10 Consitution saving throw or die from the shock. If you die, you are instantly transformed into a wight (see the Monster Manual) under the DM's control that is sworn to protect the artifact",
				"Each time you become attuned to the artifact, you age 3d10 years. You must succeed on a DC 10 Consitution saving throw or die from the shock. If you die, you are instantly transformed into a wight (see the Monster Manual) under the DM's control that is sworn to protect the artifact",
				"Each time you become attuned to the artifact, you age 3d10 years. You must succeed on a DC 10 Consitution saving throw or die from the shock. If you die, you are instantly transformed into a wight (see the Monster Manual) under the DM's control that is sworn to protect the artifact",
				"Each time you become attuned to the artifact, you age 3d10 years. You must succeed on a DC 10 Consitution saving throw or die from the shock. If you die, you are instantly transformed into a wight (see the Monster Manual) under the DM's control that is sworn to protect the artifact",
				//86-90
				"While attuned to the artifact, you lose the ability to speak.",
				"While attuned to the artifact, you lose the ability to speak.",
				"While attuned to the artifact, you lose the ability to speak.",
				"While attuned to the artifact, you lose the ability to speak.",
				"While attuned to the artifact, you lose the ability to speak.",
				//91-95
				"While attuned to the artifact, you have vulnerability to all damage",
				"While attuned to the artifact, you have vulnerability to all damage",
				"While attuned to the artifact, you have vulnerability to all damage",
				"While attuned to the artifact, you have vulnerability to all damage",
				"While attuned to the artifact, you have vulnerability to all damage",
				//96-00
				"When you become attuned to the artifact, there is a 10 percent chance that you attract the attention of a god that sends an avatar to wrest the artifact from you. The avatar has the same alignment as its creator and the statistics of an empyrean (see the Monster Manual). Once it obtains the artifact, the avatar vanishes",
				"When you become attuned to the artifact, there is a 10 percent chance that you attract the attention of a god that sends an avatar to wrest the artifact from you. The avatar has the same alignment as its creator and the statistics of an empyrean (see the Monster Manual). Once it obtains the artifact, the avatar vanishes",
				"When you become attuned to the artifact, there is a 10 percent chance that you attract the attention of a god that sends an avatar to wrest the artifact from you. The avatar has the same alignment as its creator and the statistics of an empyrean (see the Monster Manual). Once it obtains the artifact, the avatar vanishes",
				"When you become attuned to the artifact, there is a 10 percent chance that you attract the attention of a god that sends an avatar to wrest the artifact from you. The avatar has the same alignment as its creator and the statistics of an empyrean (see the Monster Manual). Once it obtains the artifact, the avatar vanishes",
				"When you become attuned to the artifact, there is a 10 percent chance that you attract the attention of a god that sends an avatar to wrest the artifact from you. The avatar has the same alignment as its creator and the statistics of an empyrean (see the Monster Manual). Once it obtains the artifact, the avatar vanishes"
			};

            public static string getIndividualTreasure_Challenge0_4()
            {
                int num = roll(1, 100);
                string total = "";

                if(num > 95)
                {
                    total += roll(1, 6) + " pp";
                }

                if(num > 70)
                {
                    if(total.Length > 0)
                    {
                        total += ", ";
                    }

                    total += roll(3, 6) + " gp";
                }

                if(num > 60)
                {
                    if (total.Length > 0)
                    {
                        total += ", ";
                    }

                    total += roll(3, 6) + " ep";
                }

                if(num > 30)
                {
                    if (total.Length > 0)
                    {
                        total += ", ";
                    }

                    total += roll(4, 6) + " sp";
                }

                if (total.Length > 0)
                {
                    total += ", ";
                }

                return total + roll(5, 6) + " cp";
            }

            public static string getIndividualTreasure_Challenge5_10()
            {
                int num = roll(1, 100);

                if (num > 95)
                {
                    return roll(3, 6) + " pp, " +
                        (roll(2, 6) * 10) + " gp, " +
                        (roll(3, 6) * 10) + " ep, " +
                        (roll(6, 6) * 10) + " sp, " +
                        (roll(4, 6) * 100) + " cp";
                }

                if (num > 70)
                {
                    return (roll(4,6) * 10) + " gp, " +
                        (roll(3, 6) * 10) + " ep, " +
                        (roll(6, 6) * 10) + " sp, " +
                        (roll(4, 6) * 100) + " cp";
                }

                if (num > 60)
                {
                    return (roll(2, 6) * 10) + " gp, " +
                        (roll(3, 6) * 10) + " ep, " +
                        (roll(6, 6) * 10) + " sp, " +
                        (roll(4, 6) * 100) + " cp";
                }

                if (num > 30)
                {
                    return (roll(2, 6) * 10) + " gp, " +
                        (roll(1, 6) * 10) + " ep, " +
                        (roll(6, 6) * 10) + " sp, " +
                        (roll(4, 6) * 100) + " cp";
                }

                return (roll(1,6) * 10) + " ep, " + (roll(4,6) * 100) + " cp";
            }

            public static string getIndividualTreasure_Challenge11_16()
            {
                int num = roll(1, 100);

                if (num > 75)
                {
                    return (roll(2, 6) * 10) + " pp, " +
                        (roll(2, 6) * 100) + " gp, " +
                        (roll(1, 6) * 100) + " ep, " +
                        (roll(4, 6) * 100) + " sp";
                }

                if (num > 35)
                {
                    return (roll(1, 6) * 10) + " pp, " +
                        (roll(2, 6) * 100) + " gp, " +
                        (roll(1, 6) * 100) + " ep, " +
                        (roll(4, 6) * 100) + " sp";
                }

                if (num > 20)
                {
                    return (roll(1, 6) * 100) + " gp, " +
                        (roll(1, 6) * 100) + " ep, " +
                        (roll(4, 6) * 100) + " sp";
                }

                return (roll(1, 6) * 100) + " gp, " +
                        (roll(4, 6) * 100) + " sp";
            }

            public static string getIndividualTreasure_Challenge17_Plus()
            {
                int num = roll(1, 100);

                if(num > 55)
                {
                    return (roll(2, 6) * 100) + " pp, " +
                        (roll(1, 6) * 1000) + " gp, " +
                        (roll(2, 6) * 1000) + " ep";
                }

                if(num > 15)
                {
                    return (roll(1, 6) * 100) + " pp, " +
                        (roll(1, 6) * 1000) + " gp, " +
                        (roll(2, 6) * 1000) + " ep";
                }

                return (roll(8, 6) * 100) + " gp, " +
                        (roll(2, 6) * 1000) + " ep";
            }
			//TODO
			public static string getTreasureHoardChallenge5_10()
			{
				// every result will include at least the below amount of coins,
				// will be combined with final result at the end
				string coins = (roll(6, 6) * 100).ToString() + " cp, " + (roll(3, 6) * 100).ToString() + " sp, " + (roll(2, 6) * 10).ToString() + " gp";

				int num = roll(1, 100);

				string res = ", ";

				switch(num)
				{
					//0-9
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
						break;
					case 6:
					case 7:
					case 8:
					case 9:

					//0-9
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
						res += roll(2, 6).ToString() + " 10 gp gems";
						break;
					case 16:
					case 17:
					case 18:
					case 19:

					//0-9
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:

					//0-9
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:

					//0-9
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:

					//0-9
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
					case 58:
					case 59:

					//0-9
					case 60:
					case 61:
					case 62:
					case 63:
					case 64:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:

					//0-9
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:

					//0-9
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:

					//0-9
					case 90:
					case 91:
					case 92:
					case 93:
					case 94:
					case 95:
					case 96:
					case 97:
					case 98:
					case 99:
				}

				return coins + res;
			}

			//TODO - create GET versions of treasure hoard tables
		}

		/*
		 * switch(num)
				{
					//0-9
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:

					//0-9
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:

					//0-9
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:

					//0-9
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:

					//0-9
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:

					//0-9
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
					case 58:
					case 59:

					//0-9
					case 60:
					case 61:
					case 62:
					case 63:
					case 64:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:

					//0-9
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:

					//0-9
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:

					//0-9
					case 90:
					case 91:
					case 92:
					case 93:
					case 94:
					case 95:
					case 96:
					case 97:
					case 98:
					case 99:
				}
		 */
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
}