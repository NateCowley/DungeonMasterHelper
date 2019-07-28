using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterHelper
{
    // In many of the lists located below, there are repeated elements. This was done 
    // in order to preserve the original tables as they were found in the DMG for 
    // D&D 5e

    public static class Data
    {

        private static Random rand = new Random();

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
        }
    }
}