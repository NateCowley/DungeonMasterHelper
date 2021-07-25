using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterHelper
{
	public static partial class Data
	{
		public static class TCE
		{
			// Chapter 1 - Classes
			public static partial class CharacterOptions
			{
				public static partial class Artificer
				{
					public static readonly Table experimental_elixir = new Table("Experimental Elixir", "Effect", Data.Rolls_String.d6, "", Data.Titles.TCE, 14, new TableRow[]
					{
						new TableRow(1,     TableRow.NOVALUE,       "Healing. The drinker regains a number of higt piotns equal to 2d4 + your Intelligence modifier."),
						new TableRow(2,     TableRow.NOVALUE,       "Swiftness. The drinker's walking speed increases by 10 feet for 1 hour."),
						new TableRow(3,     TableRow.NOVALUE,       "Resilience. The drinker gains a +1 bonus to AC for 10 minutes."),
						new TableRow(4,     TableRow.NOVALUE,       "Boldness. The drinker can roll a d4 and add the number rolled to every attack roll and saving throw they make for the next minute."),
						new TableRow(5,     TableRow.NOVALUE,       "Flight. The drinker gains a flying speed of 10 feet for 10 minutes."),
						new TableRow(6,    TableRow.NOVALUE,       "Transformation. The drinker's body is transformed as if by the alter self spell. The drinker determines the transformation caused by the spell, the effects of which last for 10 minutes."),
					});
				}

				public static partial class Barbarian
				{
					public static readonly Table origin_of_the_beast = new Table("Origin of the Beast", "Origin", Data.Rolls_String.d4, "", Data.Titles.TCE, 24, new TableRow[]
					{
						new TableRow(1,     TableRow.NOVALUE,       "One of your parents is a lycanthrope, and you've inherited some of their curse."),
						new TableRow(2,     TableRow.NOVALUE,       "You are descended from an archdruid and inherited the ability to partially change shape."),
						new TableRow(3,     TableRow.NOVALUE,       "A fey spirit gifted you with the ability to adopt different bestial aspects."),
						new TableRow(4,     TableRow.NOVALUE,       "An ancient animal spirit dwells within you, allowing you to walk this path."),
					});

					public static readonly Table wild_magic = new Table("Wild Magic", "Magical Effect", Data.Rolls_String.d8, "", Data.Titles.TCE, 26, new TableRow[]
					{
						new TableRow(1,     TableRow.NOVALUE,       "Shadowy tendrils lash around you . Each creature of your choice that you can see within 30 feet of you must succeed on a Constitution saving throw or take ldl2 necrotic damage. You also gain ldl2 temporary hit points."),
						new TableRow(2,     TableRow.NOVALUE,       "You teleport up to 30 feet to an unoccupied space you can see. Until your rage ends, you can use this effect again on each of your turns as a bonus action."),
						new TableRow(3,     TableRow.NOVALUE,       "An intangible spirit, which looks like a flumph or a pixie (your choice), appears within 5 feet of one creatuer of your choice that you can see within 30 feet of you. At the end of the current turn, the spirit explodes, and eac creature within 5 feet of it must succeed on a Dexterity saving throw or take 1d6 force damage. Until your rage ends, you can use this effect again, summoning another spirit, on each of your turns as a bonus action."),
						new TableRow(4,     TableRow.NOVALUE,       "Magic infuses one weapon of your choice that you are holding. Until your rage ends, the weapon's damage type changes to force, and it gains the light and thrown properties, with a normal range of 20 feet and a long range of 60 feet. If the weapon leaves your hand, the weapon reappears in your hand at the end of the current turn."),
						new TableRow(5,     TableRow.NOVALUE,       "Whenever a creature hits you with an attack roll before your rage ends, that creature takes 1d6 force damage, as magic lashes out in retribution."),
						new TableRow(6,     TableRow.NOVALUE,       "Until your rage ends, you are surrounded by multicolored, protective lights; you gain a +1 bonus to AC, and while within 10 feet of you, your allies gain the same bonus."),
						new TableRow(7,     TableRow.NOVALUE,       "Flowers and vines temporarily grow around you; until your rage ends, the ground within 15 feet of you is difficult terrain for your enemies."),
						new TableRow(8,     TableRow.NOVALUE,       "A bolt of light shoots from your chest. Another creature of your choice that you can see within 30 feet of you must succeed on a Constitution saving throw or take 1d6 radiant damage and be blinded until the start of your next turn. Until your rage ends, you can use this effect again on each of your turns as a bonus action."),
					});
				}

				public static partial class Sorceror
				{
					public static readonly Table manifestations_of_order = new Table("Manifestations of Order", "Manifestation", Data.Rolls_String.d6, "", Data.Titles.TCE, 69, new TableRow[]
					{
						new TableRow(1,     TableRow.NOVALUE,       "Spectral cogwheels hover behind you."),
						new TableRow(2,     TableRow.NOVALUE,       "The hands of a clock spin in your eyes."),
						new TableRow(3,     TableRow.NOVALUE,       "Your skin glows with a brassy sheen."),
						new TableRow(4,     TableRow.NOVALUE,       "Floating equations and geometric objects overlay your body."),
						new TableRow(5,     TableRow.NOVALUE,       "Your spellcasting focus temporarily takes the form of a Tiny clockwork mechanism"),
						new TableRow(6,		TableRow.NOVALUE,       "The ticking of gears or ringing of a clock can be heard by you and those affected by your magic."),
					});
				}

				public static partial class Warlock
				{
					public static readonly Table genie_kind = new Table("Genie Kind", "Kind - Element", Data.Rolls_String.d4, "", Data.Titles.TCE, 73, new TableRow[]
					{
						new TableRow(1,     TableRow.NOVALUE,       "Dao - Earth"),
						new TableRow(2,     TableRow.NOVALUE,       "Djinni -	Air"),
						new TableRow(3,     TableRow.NOVALUE,       "Efreeti - Fire"),
						new TableRow(4,     TableRow.NOVALUE,       "Marid - Water"),
					});

					public static readonly Table genies_vessel = new Table("Genie's Vessel", "Vessel", Data.Rolls_String.d6, "", Data.Titles.TCE, 74, new TableRow[]
					{
						new TableRow(1,     TableRow.NOVALUE,       "Oil lamp"),
						new TableRow(2,     TableRow.NOVALUE,       "Urn"),
						new TableRow(3,     TableRow.NOVALUE,       "Ring with a compartment"),
						new TableRow(4,     TableRow.NOVALUE,       "Stoppered bottle"),
						new TableRow(5,     TableRow.NOVALUE,       "Hollow statuette"),
						new TableRow(6,     TableRow.NOVALUE,       "Ornate lantern"),
					});
				}
			}

			// Chapter 2 - Group Patrons
			public static class GroupPatrons
			{
				public static readonly Table academy_type = new Table("Academy Type", "Academy Types", Data.Rolls_String.d6, "", Data.Titles.TCE, 84, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Boarding School. Students and faculty enjoy a familial relationship on a self-contained campus."),
					new TableRow(2,     TableRow.NOVALUE,       "Arcane Enclave. Drawn together by cutting-edge magical scholarship, the enclave's residents are hungry for secrets, reagents, and subjects."),
					new TableRow(3,     TableRow.NOVALUE,       "Secret Monastery. Ageless secrets remain the focus of contemplation and rigorous training at this site."),
					new TableRow(4,     TableRow.NOVALUE,       "Elite Institute. This cutthroat college of science or the arts accepts only the creme de la creme of society and talent."),
					new TableRow(5,     TableRow.NOVALUE,       "Vault of Secrets. This conspiracy strives to keep or eradicate all knowledge of a specific truth."),
					new TableRow(6,     TableRow.NOVALUE,       "Museum of Dreams. Magical communication or shared dreamscapes connect a network of wide-ranging specialists."),
				});

				public static readonly Table academy_contact = new Table("Academy Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 85, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Harried Functionary. A disintrested secretary conveys written correspondence to you from an exceptionally busy or aloof senior faculty member."),
					new TableRow(2,     TableRow.NOVALUE,       "Celebrated Instructor. Despite their throngs of ambitious assistants, a celebrity researcher considers you their star pupil."),
					new TableRow(3,     TableRow.NOVALUE,       "Wizened Fixture. A fantastically old, believed-to-be deceased librarian gives you assignments from the circulation desk they never leave."),
					new TableRow(4,     TableRow.NOVALUE,       "Infatuated Tourist. A flirtatious visiting scholar perceives your every report and donated discovery as a personal gift."),
					new TableRow(5,     TableRow.NOVALUE,       "Spectral Fragment. A haunted piece of the academy's collection compels you to complete its secret research."),
					new TableRow(6,     TableRow.NOVALUE,       "Distant Observer. A mysterious sponsor encourages your research from afar to avoird alerting nefarious forces embedded within the academy's bureaucracy."),
				});

				public static readonly Table academy_quests = new Table("Academy Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 86, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Aberrant Zoology. You undertake expeditions to document, capture, and explain beings antithetical to the natural order."),
					new TableRow(2,     TableRow.NOVALUE,       "Arcanodynamics. You investigate the ways magic underpins existence, exploring its flows and seeking ways to harness its nexuses."),
					new TableRow(3,     TableRow.NOVALUE,       "Forbidden History. You reveal the lost truths of the world's darkest ages, pursuing the history of purposefully hidden or taboo eras."),
					new TableRow(4,     TableRow.NOVALUE,       "Cryptogeography. You search for proof of a hidden land or that the world isn't structured as commonly assumed."),
					new TableRow(5,     TableRow.NOVALUE,       "Restorative Antiquarianism. You track clues leading to plundered artifacts and then restore them to their rightful owners."),
					new TableRow(6,     TableRow.NOVALUE,       "Evolutionary Divinity. You dare to explore what no mortal was meant to know: the origins of divinity."),
				});

				public static readonly Table ancient_being = new Table("Ancient Being", "Ancient Being", Data.Rolls_String.d6, "", Data.Titles.TCE, 86, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Elder Dragon. An ancient dragon seeks knowledge or power. It wishes to gather greater wealth for its hoard, its ambitions expanding in its advancing years."),
					new TableRow(2,     TableRow.NOVALUE,       "Lich. an undead spellcaster of immense power employs your group. Its interests are strangely diverse and seemingly benign. Perhaps it's not as evil as conventional adventuring wisdom suggests?"),
					new TableRow(3,     TableRow.NOVALUE,       "Bound Fiend. This fiend is bound to a location, either in its true form or as a possessing spirit. Whether trapped in an unbreakable circle of binding sigils or sealed as a spirit within a gigantic statue, the fiend's influence drives your group."),
					new TableRow(4,     TableRow.NOVALUE,       "Guardian Celestial. An angel or another powerful celestial takes an interest in a specific region of the Material Plane. It cultivates a network of mortal informants and agents to serve its agenda."),
					new TableRow(5,     TableRow.NOVALUE,       "The Endless. This person has lived many lifetimes because they can't die - at least not permanently. No matter the cause of their demise, they return. To all appearances, they are alive and mortal, but they control the amassed resources of an immortal."),
					new TableRow(6,     TableRow.NOVALUE,       "Primal Manifestation. Its existence defies mortal enderstanding; the being simply is. It could be a primordial force of nature awakened to self-awareness that now inhabits the landscape or an alien intellect that whispers through proxies, omens, and idols."),
				});

				public static readonly Table ancient_being_contact = new Table("Ancient Being Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 87, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table ancient_being_quests = new Table("Ancient Being Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 88, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table aristocrat_types = new Table("Aristocrat Types", "Aristocrats", Data.Rolls_String.d6, "", Data.Titles.TCE, 89, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table aristocrat_contact = new Table("Aristocrat Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 90, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table aristocrat_quests = new Table("Aristocrat Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 90, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table syndicate_types = new Table("Syndicate Types", "Syndicate", Data.Rolls_String.d6, "", Data.Titles.TCE, 91, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table syndicate_contact = new Table("Syndicate Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 92, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table syndicate_quests = new Table("Syndicate Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 93, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table guild_types = new Table("Guild Types", "Guild", Data.Rolls_String.d6, "", Data.Titles.TCE, 93, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table guild_contact = new Table("Guild Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 95, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table guild_quests = new Table("Guild Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 95, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table military_force_types = new Table("Military Force Types", "Military Organization", Data.Rolls_String.d6, "", Data.Titles.TCE, 96, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table military_force_contact = new Table("Commanding Officer", "Officer", Data.Rolls_String.d6, "", Data.Titles.TCE, 97, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table military_quests = new Table("Military Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 98, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table religious_order_types = new Table("Religious Order Types", "Religious Order", Data.Rolls_String.d6, "", Data.Titles.TCE, 98, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table religious_order_contact = new Table("Religious Order Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 99, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table religious_order_quests = new Table("Religious Order Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 100, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table sovereign_types = new Table("Sovereign Types", "Aristocrats", Data.Rolls_String.d6, "", Data.Titles.TCE, 101, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table sovereign_contact = new Table("Sovereign Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 102, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});

				public static readonly Table sovereign_quests = new Table("Sovereign Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 90, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       ""),
					new TableRow(2,     TableRow.NOVALUE,       ""),
					new TableRow(3,     TableRow.NOVALUE,       ""),
					new TableRow(4,     TableRow.NOVALUE,       ""),
					new TableRow(5,     TableRow.NOVALUE,       ""),
					new TableRow(6,     TableRow.NOVALUE,       ""),
				});
			}
		}
	}
}
