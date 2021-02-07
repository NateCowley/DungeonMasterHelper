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
		// Chapter 1
		public static class CharacterOptions
		{
			public static class ClassTables
			{
				public static class Barbarian
				{
					public static readonly Table personal_totems = new Table("Personal Totems", "Totem", Data.Rolls_String.d6, "", Data.Titles.XGE, 8, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A tuft of fur from a solitary wolf that you befriended during a hunt"),
						new TableRow(2, TableRow.NOVALUE, "Three eagle feathers given to you by a wise shaman, who told you they would play a role in determining your fate"),
						new TableRow(3, TableRow.NOVALUE, "A necklace made from the claws of a young cave bear that you slew singlehandedly as a child"),
						new TableRow(4, TableRow.NOVALUE, "A small leather pouch holding three stones that represent your ancestors"),
						new TableRow(5, TableRow.NOVALUE, "A few small bones from the first beast you killed, tied together with colored wool"),
						new TableRow(6, TableRow.NOVALUE, "An egg-sized stone in the shape of your spirit animal that appeared one day in your belt pouch"),
					});

					public static readonly Table tattoos = new Table("Tattoos", "Tattoo", Data.Rolls_String.d6, "", Data.Titles.XGE, 8, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "The wings of an eagle are spread wide across your upper back."),
						new TableRow(2, TableRow.NOVALUE, "Etched on the backs of your hands are the paws of a cave bear."),
						new TableRow(3, TableRow.NOVALUE, "The symbols of your clan are displayed in viny patterns along your arms."),
						new TableRow(4, TableRow.NOVALUE, "The antlers of an elk are inked across your back."),
						new TableRow(5, TableRow.NOVALUE, "Images of your spirit animal are tattooed along your weapon arm and hand."),
						new TableRow(6, TableRow.NOVALUE, "The eyes of a wolf are marked on your back to help you see and ward off evil spirits."),
					});

					public static readonly Table superstitions = new Table("Superstitions", "Superstitions", Data.Rolls_String.d6, "", Data.Titles.XGE, 9, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "If you disturb the bones of the dead, you inherit all the troubles that plagued them in life."),
						new TableRow(2, TableRow.NOVALUE, "Never trust a wizard. They're all devils in disguise, especially the friendly ones."),
						new TableRow(3, TableRow.NOVALUE, "Dwarves have lost their spirits, and are almost like the undead. That's why they live underground"),
						new TableRow(4, TableRow.NOVALUE, "Magical things bring trouble. Never sleep with a magic object within ten feet of you."),
						new TableRow(5, TableRow.NOVALUE, "When you walk through a graveyard, be sure to wear silver, or a ghost might jump into your body."),
						new TableRow(6, TableRow.NOVALUE, "If an elf looks you in the eyes, she's trying to read your thoughts."),
					});
				}

				public static class Bard
				{
					public static readonly Table defining_works = new Table("Defining Works", "Defining Work", Data.Rolls_String.d6, "", Data.Titles.XGE, 12, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "\"The Three Flambinis,\" a ribald song concerning mistaken identities and unfettered desire"),
						new TableRow(2, TableRow.NOVALUE, "\"Waltz of the Myconids,\" an upbeat tune that children in particular enjoy"),
						new TableRow(3, TableRow.NOVALUE, "\"Asmodeus's Golden Arse,\" a dramatic poem you claim was inspired by your personal visit to Avernus"),
						new TableRow(4, TableRow.NOVALUE, "\"The Pirates of Luskan,\" your firsthand account of being kidnapped by sea reavers as a child"),
						new TableRow(5, TableRow.NOVALUE, "\"A Hoop, Two Pigeons, and a Hell Hound,\" a subtle parody of an incompetent nobel"),
						new TableRow(6, TableRow.NOVALUE, "\"A Fool in the Abyss,\" a comedic poem about a jester's travels among demons"),
					});

					public static readonly Table instruments = new Table("Instruments", "Instrument", Data.Rolls_String.d6, "", Data.Titles.XGE, 12, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A masterfully crafted halfling fiddle"),
						new TableRow(2, TableRow.NOVALUE, "A mithral horn made by elves"),
						new TableRow(3, TableRow.NOVALUE, "A zither made with drow spider silk"),
						new TableRow(4, TableRow.NOVALUE, "An orcish drum"),
						new TableRow(5, TableRow.NOVALUE, "A wooden bullywug croak box"),
						new TableRow(6, TableRow.NOVALUE, "A tinker's harp of gnomish design"),
					});

					public static readonly Table embarrassments = new Table("Embarrassments", "Embarassment", Data.Rolls_String.d6, "", Data.Titles.XGE, 13, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "The time when your comedic song, \"Big Tom's Hijinks\"—which, by the way, you thought was brilliant—did not go over well with Big Tom"),
						new TableRow(2, TableRow.NOVALUE, "The matinee performance when a circus's owlbear got loose and terrorized the crowd"),
						new TableRow(3, TableRow.NOVALUE, "When your opening song was your enthusiastic but universally hated rendition of \"Song of the Froghemoth\""),
						new TableRow(4, TableRow.NOVALUE, "The first and last public performance of \"Mirt, Man about Town\""),
						new TableRow(5, TableRow.NOVALUE, "The time on stage when your wig caught fire and you threw it down—which set fire to the stage"),
						new TableRow(6, TableRow.NOVALUE, "When you sat on your lute by mistake during the final stanza of \"Starlight Serenade\""),
					});
				}

				public static class Cleric
				{
					public static readonly Table temples = new Table("Temples", "Temple", Data.Rolls_String.d6, "", Data.Titles.XGE, 17, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your temple is said to be the oldest surviving structure built to honor your god."),
						new TableRow(2, TableRow.NOVALUE, "Acolytes of several like-minded deities all received instruction together in your temple."),
						new TableRow(3, TableRow.NOVALUE, "You come from a temple famed for the brewery it operats. Some say you smell like one of its ales."),
						new TableRow(4, TableRow.NOVALUE, "Your temple is a fortress and a proving ground that trains warrior-priests."),
						new TableRow(5, TableRow.NOVALUE, "Your temple is a peaceful, humble place, filled with vegetable gardens and simple priests."),
						new TableRow(6, TableRow.NOVALUE, "You served in a temple in the Outer Planes."),
					});

					public static readonly Table keepsakes = new Table("Keepsakes", "Keepsake", Data.Rolls_String.d6, "", Data.Titles.XGE, 17, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "The finger bone of a saint"),
						new TableRow(2, TableRow.NOVALUE, "A metal-bound book that tells how to hunt and destroy infernal creatures"),
						new TableRow(3, TableRow.NOVALUE, "A pig's whistle that reminds you of your humble and beloved mentor"),
						new TableRow(4, TableRow.NOVALUE, "A braid of hair woven from the tail of a unicorn"),
						new TableRow(5, TableRow.NOVALUE, "A scroll that describes how best to rid the world of necromancers"),
						new TableRow(6, TableRow.NOVALUE, "A runestone said to be blessed by your god"),
					});

					public static readonly Table secrets = new Table("Secrets", "Secret", Data.Rolls_String.d6, "", Data.Titles.XGE, 17, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "An imp offers you counsel. You try to ignore the crature, but sometimes its advice is helpful."),
						new TableRow(2, TableRow.NOVALUE, "You believe that, in the final analysis, the gods are nothing more than ultrapowerful mortal creatures."),
						new TableRow(3, TableRow.NOVALUE, "You acknowledge the power of the gods, but you think that most evetns are dictated by pure chance."),
						new TableRow(4, TableRow.NOVALUE, "Even though you can work divine magic, you haev never truly felt the presence of a divine essence within yourself."),
						new TableRow(5, TableRow.NOVALUE, "You are plagued by nightmares that you believe are sent by your god as punishment for some unknown transgression."),
						new TableRow(6, TableRow.NOVALUE, "In times of despair, you feel that you are but a plaything of the gods, and you resent their remoteness."),
					});
				}

				public static class Druid
				{
					public static readonly Table treasured_items = new Table("Treasured Items", "Item", Data.Rolls_String.d6, "", Data.Titles.XGE, 21, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A twig from the meeting tree that stands in the center of your village"),
						new TableRow(2, TableRow.NOVALUE, "A vial of water from the source of a sacred river"),
						new TableRow(3, TableRow.NOVALUE, "Special herbs tied together in a bundle"),
						new TableRow(4, TableRow.NOVALUE, "A small bronze bowl engraved with animal images"),
						new TableRow(5, TableRow.NOVALUE, "A rattle made from a dried gourd and holly berries"),
						new TableRow(6, TableRow.NOVALUE, "A miniature golden sickle handed down to you by your mentor"),
					});

					public static readonly Table guiding_aspects = new Table("Guiding Aspects", "Guiding Aspect", Data.Rolls_String.d6, "", Data.Titles.XGE, 21, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Yew trees remind you of renewing your mind and spirit, letting the old die and the new spring forth."),
						new TableRow(2, TableRow.NOVALUE, "Oak trees represent strength and vitality. Meditating under an oak fills your body and mind with resolve and fortitude."),
						new TableRow(3, TableRow.NOVALUE, "The river's endless flow reminds you of the great span of the world. You seek to act with the long-term interests of nature in mind."),
						new TableRow(4, TableRow.NOVALUE, "The sea is a constanc, churning cauldron of power and chaos. It reminds you that accepting change is necessary to sustain yourself in the world."),
						new TableRow(5, TableRow.NOVALUE, "The birds in the sky are evidence that even the smallest creatures can survive if they remain above the fray."),
						new TableRow(6, TableRow.NOVALUE, "As demonstrated by the actions of the wolf, an individual's strength is nothing compared to the power of the pack."),
					});

					public static readonly Table mentors = new Table("Mentors", "Mentor", Data.Rolls_String.d6, "", Data.Titles.XGE, 21, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your mentor was a wise treant who taught you to think in terms of years and decades rather than days or months."),
						new TableRow(2, TableRow.NOVALUE, "You were tutored by a dryad who watched over a slumbering portal to the Abyss. During your training, you were tasked with watching for hidden threats to the world."),
						new TableRow(3, TableRow.NOVALUE, "Your tutor always interacted with you in the form of a falcon. You never saw the tutor's humanoid form."),
						new TableRow(4, TableRow.NOVALUE, "You were one of several youngsters who were mentored by and old druid, until one of your fellow pupils betrayed your group and killed your master."),
						new TableRow(5, TableRow.NOVALUE, "Your mentor has appeared to you only in visions. You have yet to meet this person, and you are not sure such a person exists in mortal form."),
						new TableRow(6, TableRow.NOVALUE, "Your mentor was a werebear who taught you to treat all living things with equal regard."),
					});
				}

				public static class Fighter
				{
					public static readonly Table heraldic_signs = new Table("Heraldic Signs", "Sign", Data.Rolls_String.d6, "", Data.Titles.XGE, 27, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A rampant golden draon on a green field, representing valor and a quest for wealth"),
						new TableRow(2, TableRow.NOVALUE, "The fist of a storm giant clutching lightning before a storm cloud, symbolizing wrath and power"),
						new TableRow(3, TableRow.NOVALUE, "Crossed greatswords in front of a castle gate, signifying the defense of a city or kingdom"),
						new TableRow(4, TableRow.NOVALUE, "A skull with a dagger through it, representing the doom you bring to your enemies"),
						new TableRow(5, TableRow.NOVALUE, "A phoenix in a ring of fire, an expression of an indomitable spirit"),
						new TableRow(6, TableRow.NOVALUE, "Three drops of blood beneath a horizontal sword blade on a black background, symbolizing three foes you have sworn to kill"),
					});

					public static readonly Table instructors = new Table("Instructors", "Instructor", Data.Rolls_String.d6, "", Data.Titles.XGE, 27, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Gladiator. Your instructor was a slave who fought for freedom in the arena, or one who willingly chose the gladiator's life to earn money and fame."),
						new TableRow(2, TableRow.NOVALUE, "Military. Your trainer served with a group of soldiers and knows much about working as a team."),
						new TableRow(3, TableRow.NOVALUE, "City Watch. Crowd control and peacekeeping are your instructor's specialties."),
						new TableRow(4, TableRow.NOVALUE, "Tribal Warrior. Your instructor grew up in a tribe, where fighting for one's life was practically an everyday occurrence."),
						new TableRow(5, TableRow.NOVALUE, "Street Fighter. Your trainer ecels at urban combat, combining close-quarters work with silence and efficiency."),
						new TableRow(6, TableRow.NOVALUE, "Weapon Master. Your mentor helped you to become one with your chosen weapon, by imparting highly specialized knowledge of how to wield it most effectively."),
					});

					public static readonly Table signature_styles = new Table("Signature Styles", "Superstitions", Data.Rolls_String.d6, "", Data.Titles.XGE, 28, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Elegant. You move with precise grace and total control, never using more energy than you need."),
						new TableRow(2, TableRow.NOVALUE, "Brutal. Your attacks rain down like hammer blows, meant to splinter bone or send blood flying."),
						new TableRow(3, TableRow.NOVALUE, "Cunning. You dart in to attack at just the right moment and use small-scale tactics to tilt the odds in your favor."),
						new TableRow(4, TableRow.NOVALUE, "Effortless. You rarely perspire or display anything other than a stoic expression in battle."),
						new TableRow(5, TableRow.NOVALUE, "Energetic. You sing and laugh during combat as your spirit soars. You are happiest when you have a foe in front of you and a weapon in hand."),
						new TableRow(6, TableRow.NOVALUE, "Sinister. You scowl and sneer while fighting, and you enjoy mocking your foes as you defeat them."),
					});
				}

				public static class Monk
				{
					public static readonly Table monasteries = new Table("Monasteries", "Monastery", Data.Rolls_String.d6, "", Data.Titles.XGE, 32, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your monastery is carved out of a mountainside, where it looms over a treacherous pass."),
						new TableRow(2, TableRow.NOVALUE, "Your monastery is high in the branches of an immense tree in the Feywild."),
						new TableRow(3, TableRow.NOVALUE, "Your monastery was founded long ago by a cloud giant and is inside a cloud castle that can be reached only by flying"),
						new TableRow(4, TableRow.NOVALUE, "Your monastery is built beside a volcanic system of hot springs, geysers, and sulfur pools. You regularly received visits from azer traders."),
						new TableRow(5, TableRow.NOVALUE, "Your monastery was founded by gnomes and is an underground labyrinth of tunnels and rooms."),
						new TableRow(6, TableRow.NOVALUE, "Your monastery was carved from an iceberg in the frozen reaches of the world."),
					});

					public static readonly Table tattoos = new Table("Monastic Icons", "Icon", Data.Rolls_String.d6, "", Data.Titles.XGE, 32, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Monkey. Quick reflexes and the ability to travel through the treetops are two of the reasons why your order admires the monkey."),
						new TableRow(2, TableRow.NOVALUE, "Dragon Turtle. The monks of your seaside monastery venerate the dragon turtle, reciting ancient prayers and offering garlands of flowers to honor this living spirit of the sea."),
						new TableRow(3, TableRow.NOVALUE, "Ki-rin. Your monastery sees its main purpose as watching over and protecting the land in the manner of the ki-rin."),
						new TableRow(4, TableRow.NOVALUE, "Owlbear. The monks of your monastery revere a family of owlbears and have coexisted with them for generations."),
						new TableRow(5, TableRow.NOVALUE, "Hydra. Your order signles out the hydra for its ability to unleash several attacks simultaneously."),
						new TableRow(6, TableRow.NOVALUE, "Dragon. A dragon once laired within your monastery. Its influence remains long after its deaparture."),
					});

					public static readonly Table masters = new Table("Masters", "Master", Data.Rolls_String.d6, "", Data.Titles.XGE, 33, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your master was a tyrant whom you had to defeat in single combat to complete your instruction."),
						new TableRow(2, TableRow.NOVALUE, "Your master was kindly and taught you to pursue the cause of peace."),
						new TableRow(3, TableRow.NOVALUE, "Your master was merciless in pushing you to your limits. You nearly lost an eye during one especially brutal practice session."),
						new TableRow(4, TableRow.NOVALUE, "Your master seemed goodhearted while tutoring you, but betrayed your monastery in the end."),
						new TableRow(5, TableRow.NOVALUE, "Your master was cold and distant. You suspect that the two of you might be related."),
						new TableRow(6, TableRow.NOVALUE, "Your master was kind and generous, never critical of your progress. Nevertheless, you feel you never fully lived up to the expectations placed on you."),
					});
				}

				public static class Paladin
				{
					public static readonly Table personal_goals = new Table("Personal Goals", "Goal", Data.Rolls_String.d6, "", Data.Titles.XGE, 36, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Peace. You fight so that future generatjions will not have to."),
						new TableRow(2, TableRow.NOVALUE, "Revenge. Your oath is the vehicle through which you will right an ancient wrong."),
						new TableRow(3, TableRow.NOVALUE, "Duty. You will live up to what you have sworn to do, or die trying."),
						new TableRow(4, TableRow.NOVALUE, "Leadership. You will win a great battle that bards will sing about, and in so doing, you will become an example to inspire others."),
						new TableRow(5, TableRow.NOVALUE, "Faith. You know your path is righteous, or else the gods would not have set you upon it."),
						new TableRow(6, TableRow.NOVALUE, "Glory. You will lead the world into a grand new era, one that will be branded with your name."),
					});

					public static readonly Table tattoos = new Table("Symbols", "Symbol", Data.Rolls_String.d6, "", Data.Titles.XGE, 36, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A dragon, emblematic of your nobility in peace and your ferocity in combat"),
						new TableRow(2, TableRow.NOVALUE, "A clenched fist, because you are always ready to fight for your beliefs"),
						new TableRow(3, TableRow.NOVALUE, "An upraised open hand, indicating your preference for diplomacy over combat"),
						new TableRow(4, TableRow.NOVALUE, "A red heart, showing the world your commitment to justice"),
						new TableRow(5, TableRow.NOVALUE, "A black heart, signifying that emotions such as pity do not sway your dedication to your oath"),
						new TableRow(6, TableRow.NOVALUE, "An unblinking eye, meaning that you are ever alert to all threats against your cause"),
					});

					public static readonly Table superstitions = new Table("Nemesis", "Nemesis", Data.Rolls_String.d6, "", Data.Titles.XGE, 37, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A mighty orc war chief who threatens to overrun and destroy everything you hold sacred"),
						new TableRow(2, TableRow.NOVALUE, "A fiend or a celestial, the agent of a power of the Outer Planes, who has been charged with corrupting or redeeming you, as appropriate"),
						new TableRow(3, TableRow.NOVALUE, "A dragon whose servants dog your steps"),
						new TableRow(4, TableRow.NOVALUE, "A high priest who seese you as a misguided fool and wants you to abandon your religion"),
						new TableRow(5, TableRow.NOVALUE, "A rival paladin who trained with you but became an oath-breaker and holds you responsible"),
						new TableRow(6, TableRow.NOVALUE, "A vampire who has sworn revenge against all paladins after being defeated by one"),
					});

					public static readonly Table temptations = new Table("Temptations", "Temptation", Data.Rolls_String.d6, "", Data.Titles.XGE, 37, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Fury. When your anger is roused, you have trouble thinking straight, and you fear you might do something you'll regret."),
						new TableRow(2, TableRow.NOVALUE, "Pride. Your deeds are noteworthy, and no one takes note of them more often than you."),
						new TableRow(3, TableRow.NOVALUE, "Lust. You can't resist an attractive face and a pleasant smile."),
						new TableRow(4, TableRow.NOVALUE, "Envy. You are mindful of what some famous folk have accomplished, and you feel inadequate when your deeds don't compare to theirs."),
						new TableRow(5, TableRow.NOVALUE, "Despair. You consider the great strength of the enemies you must defeat, and at times you see no way to achieve final victory."),
						new TableRow(6, TableRow.NOVALUE, "Greed. Regardless of how much glory and treasure you amass, it's never enough for you."),
					});
				}

				public static class Ranger
				{
					public static readonly Table views_of_the_world = new Table("Views of the World", "View", Data.Rolls_String.d6, "", Data.Titles.XGE, 40, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Towns and cities are the best places for those who can't survive on their own."),
						new TableRow(2, TableRow.NOVALUE, "The advancement of civilization is the best way to thwart chaos, but its reach must be monitored."),
						new TableRow(3, TableRow.NOVALUE, "Towns and cities are a necessary evil, but once the wilderness is purged of supernatural threats, we will need them no more."),
						new TableRow(4, TableRow.NOVALUE, "Walls are for cowards, who huddle behind them while others do the work of making the world safe."),
						new TableRow(5, TableRow.NOVALUE, "Visiting a town is not unpleasant, but after a few days I feel the irresistible call to return to the wild."),
						new TableRow(6, TableRow.NOVALUE, "Cities breed weakness by isolating folk from the harsh lessons of the wild."),
					});

					public static readonly Table homelands = new Table("Homelands", "Homeland", Data.Rolls_String.d6, "", Data.Titles.XGE, 40, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "You patrolled an ancient forest, darkened and courrupted by several crossings to the Shadowfell."),
						new TableRow(2, TableRow.NOVALUE, "As part of a group of nomads, you acquired the skills for surviving in the desert."),
						new TableRow(3, TableRow.NOVALUE, "Your early life in the Underdark prepared you for the challenges of combating its denizens."),
						new TableRow(4, TableRow.NOVALUE, "You dwelled on the edge of a swamp, in an area imperiled by land creatures as well as aquatic ones."),
						new TableRow(5, TableRow.NOVALUE, "Because you grew up among the peaks, finding the best path through the mountains is second nature to you."),
						new TableRow(6, TableRow.NOVALUE, "You wandered the far north, learning how to protect yourself and prosper in a realm overrun by ice."),
					});

					public static readonly Table sworn_enemies = new Table("Sworn Enemies", "Enemy", Data.Rolls_String.d6, "", Data.Titles.XGE, 41, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "You seek revenge on nature's behalf for the great transgressions your foe has committed."),
						new TableRow(2, TableRow.NOVALUE, "Your forebears or predecessors fought these creatures, and so shall you."),
						new TableRow(3, TableRow.NOVALUE, "You bear no enmity toward your foe. You stalk such creatures as a hunter tracks down a wild animal."),
						new TableRow(4, TableRow.NOVALUE, "You find your foe fascinating, and you collect books of tales and history concerning it."),
						new TableRow(5, TableRow.NOVALUE, "You collect tokens of your fallen enemies to remind you of each kill."),
						new TableRow(6, TableRow.NOVALUE, "You respect your chosen enemy, and you see your battles as a test of respective skills."),
					});
				}

				public static class Rogue
				{
					public static readonly Table guilty_pleasures = new Table("Guilty Pleasures", "Pleasure", Data.Rolls_String.d6, "", Data.Titles.XGE, 44, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Large gems"),
						new TableRow(2, TableRow.NOVALUE, "A smile from a pretty face"),
						new TableRow(3, TableRow.NOVALUE, "A new ring for your finger"),
						new TableRow(4, TableRow.NOVALUE, "the chance to deflate someone's ego"),
						new TableRow(5, TableRow.NOVALUE, "The finest food and drink"),
						new TableRow(6, TableRow.NOVALUE, "Adding to your collection of exotic coins"),
					});

					public static readonly Table adversaries = new Table("Adversaries", "Adversary", Data.Rolls_String.d6, "", Data.Titles.XGE, 44, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "The pirate captain on whose ship you once served; what you call moving on, the captain calls mutiny"),
						new TableRow(2, TableRow.NOVALUE, "A master spy to whom you unwittingly fed bad information, which led to the assassination ofthe wrong target"),
						new TableRow(3, TableRow.NOVALUE, "The master ofthe local thieves' guild, who wants you to join the organization or leave town"),
						new TableRow(4, TableRow.NOVALUE, "An art collector who uses illegal means to acquire masterpieces"),
						new TableRow(5, TableRow.NOVALUE, "A fence who uses you as a messenger to set up illicit meetings"),
						new TableRow(6, TableRow.NOVALUE, "The proprietor ofan illegal pit fighting arena where you once took bets"),
					});

					public static readonly Table superstitions = new Table("Benefactors", "Benefactor", Data.Rolls_String.d6, "", Data.Titles.XGE, 45, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A smuggler kept you from getting caught but lost a valuable shipment in doing so. Now you owe that person an equally valuable favor."),
						new TableRow(2, TableRow.NOVALUE, "The Beggar King has hidden you from your pursuers many times, in return for future considerations."),
						new TableRow(3, TableRow.NOVALUE, "A magistrate once kept you out ofjail in return for information on a powerful crime lord."),
						new TableRow(4, TableRow.NOVALUE, "Your parents used their savings to bail you out of trouble in your younger days and are now destitute."),
						new TableRow(5, TableRow.NOVALUE, "A dragon didn't eat you when it had a chance, and in return you promised to set aside choice pieces oftreasure for it."),
						new TableRow(6, TableRow.NOVALUE, "A druid once helped you out ofa tight spot; now any random animal you see could be that benefactor, perhaps come to claim a return favor."),
					});
				}

				public static class Sorceror
				{
					public static readonly Table arcane_origins = new Table("Arcane Origins", "Origin", Data.Rolls_String.d6, "", Data.Titles.XGE, 48, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your power arises from your family's bloodline. You are related to some powerful creature, or you inherited a blessing or a curse."),
						new TableRow(2, TableRow.NOVALUE, "You are the reincarnation ofa being from another plane ofexistence."),
						new TableRow(3, TableRow.NOVALUE, "A powerful entity entered the world. Its magic changed you."),
						new TableRow(4, TableRow.NOVALUE, "Your birth was prophesied in an ancient text, and you are foretold to use your power for terrible ends."),
						new TableRow(5, TableRow.NOVALUE, "You are the product of generations ofcareful, selective breeding."),
						new TableRow(6, TableRow.NOVALUE, "You were made in a vat by an alchemist."),
					});

					public static readonly Table reactions = new Table("Reactions", "Reaction", Data.Rolls_String.d6, "", Data.Titles.XGE, 48, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your powers are seen as a great blessing by those around you, and you are expected to use them in service to your community."),
						new TableRow(2, TableRow.NOVALUE, "Your powers caused destruction and even a death when they became evident, and you were treated as a criminal."),
						new TableRow(3, TableRow.NOVALUE, "Your neighbors hate and fear your power, causing them to shun you."),
						new TableRow(4, TableRow.NOVALUE, "You came to the attention ofa sinister cult that plans on exploiting your abilities."),
						new TableRow(5, TableRow.NOVALUE, "Peeple around you believe that your powers are a curse levied on your family for a past transgression."),
						new TableRow(6, TableRow.NOVALUE, "Your powers are believed to be tied to an ancient line ofmad kings that supposedly ended in a bloody revolt over a century ago."),
					});

					public static readonly Table supernatural_marks = new Table("Supernatural Marks", "Mark", Data.Rolls_String.d6, "", Data.Titles.XGE, 49, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your eyes are an unusual color, such as red."),
						new TableRow(2, TableRow.NOVALUE, "You have an extra toe on one foot."),
						new TableRow(3, TableRow.NOVALUE, "One ofyour ears is noticeably larger than the other."),
						new TableRow(4, TableRow.NOVALUE, "Your hair grows at a prodigious rate."),
						new TableRow(5, TableRow.NOVALUE, "You wrinkle your nose repeatedly while you are chewing."),
						new TableRow(6, TableRow.NOVALUE, "A red splotch appears on your neck once a day, then vanishes after an hour."),
					});

					public static readonly Table signs_of_sorcery = new Table("Signs of Sorcery", "Sign", Data.Rolls_String.d6, "", Data.Titles.XGE, 49, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "You deliver the verbal components of your spells in the booming voice of a titan."),
						new TableRow(2, TableRow.NOVALUE, "For a moment after you cast a spell, the area around you grows dark and gloomy."),
						new TableRow(3, TableRow.NOVALUE, "You sweat profusely while casting a spell and for a few seconds thereafter."),
						new TableRow(4, TableRow.NOVALUE, "Your hair and garments are briefly buffeted about, as if by a breeze, whenever you call forth a spell."),
						new TableRow(5, TableRow.NOVALUE, "If you are standing when you cast a spell, you rise six inches into the air and gently float back down."),
						new TableRow(6, TableRow.NOVALUE, "Illusory blue flames wreathe your head as you begin your casting, then abruptly disappear."),
					});
				}

				public static class Warlock
				{
					public static readonly Table patron_attitudes = new Table("Patron Attitudes", "Attitude", Data.Rolls_String.d6, "", Data.Titles.XGE, 53, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Your patron has guided and helped your family for generations and is kindly toward you."),
						new TableRow(2, TableRow.NOVALUE, "Each interaction with your capricious patron is a surprise, whether pleasant or painful."),
						new TableRow(3, TableRow.NOVALUE, "Your patron is the spirit ofa long-dead hero who sees your pact as a way for it to continue to influence the world."),
						new TableRow(4, TableRow.NOVALUE, "Your patron is a strict disciplinarian but treats you with a measure of respect."),
						new TableRow(5, TableRow.NOVALUE, "Your patron tricked you into a pact and treats you as a slave."),
						new TableRow(6, TableRow.NOVALUE, "You are mostly left to your own devices with no interference from your patron. Sometimes you dread the demands it will make when it does appear."),
					});

					public static readonly Table special_terms = new Table("Special Terms", "Term", Data.Rolls_String.d6, "", Data.Titles.XGE, 53, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "When directed, you must take immediate action against a specific enemy ofyour patron."),
						new TableRow(2, TableRow.NOVALUE, "Your pact tests your willpower; you are required to abstain from alcohol and other intoxicants."),
						new TableRow(3, TableRow.NOVALUE, "At least once a day, you must inscribe or carve your patron’s name or symbol on the wall ofa building."),
						new TableRow(4, TableRow.NOVALUE, "You must occasionally conduct bizarre rituals to maintain your pact."),
						new TableRow(5, TableRow.NOVALUE, "You can never wear the same outfit twice, since your patron finds such predictability to be boring."),
						new TableRow(6, TableRow.NOVALUE, "When you use an eldritch invocation, you must I speak your patron’s name aloud or risk incurring its displeasure."),
					});

					public static readonly Table binding_marks = new Table("Binding Marks", "Mark", Data.Rolls_String.d6, "", Data.Titles.XGE, 54, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "One of your eyes looks the same as one of your patron's eyes."),
						new TableRow(2, TableRow.NOVALUE, "Each time you wake up, the small blemish on your face appears in a different place."),
						new TableRow(3, TableRow.NOVALUE, "You display outward symptoms of a disease but suffer no ill effects from it."),
						new TableRow(4, TableRow.NOVALUE, "Your tongue is an unnatural color."),
						new TableRow(5, TableRow.NOVALUE, "You have a vestigial tail."),
						new TableRow(6, TableRow.NOVALUE, "Your nose glows in the dark."),
					});
				}

				public static class Wizard
				{
					public static readonly Table spellbooks = new Table("Spellbooks", "Spellbook", Data.Rolls_String.d6, "", Data.Titles.XGE, 58, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A tome with pages that are thin sheets of metal, spells etched into them with acid"),
						new TableRow(2, TableRow.NOVALUE, "Long straps of leather on which spells are written, wrapped around a stafffor ease oftransport"),
						new TableRow(3, TableRow.NOVALUE, "A battered tome filled with pictographs that only you can understand"),
						new TableRow(4, TableRow.NOVALUE, "Small stones inscribed with spells and kept in a cloth bag"),
						new TableRow(5, TableRow.NOVALUE, "A scorched book, ravaged by dragon fire, with the script ofyour spells barely visible on its pages"),
						new TableRow(6, TableRow.NOVALUE, "A tome full ofblack pages whose writing is visible only in dim light or darkness"),
					});

					public static readonly Table ambitions = new Table("Ambitions", "Ambition", Data.Rolls_String.d6, "", Data.Titles.XGE, 58, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "You will prove that the gods aren't as powerful as folk believe."),
						new TableRow(2, TableRow.NOVALUE, "Immortality is the end goal of your studies."),
						new TableRow(3, TableRow.NOVALUE, "If you can fully understand magic, you can unlock its use for all and usher in an era of equality."),
						new TableRow(4, TableRow.NOVALUE, "Magic is a dangerous tool. You use it to protect what you treasure."),
						new TableRow(5, TableRow.NOVALUE, "Arcane power must be taken away from those who would abuse it."),
						new TableRow(6, TableRow.NOVALUE, "You will become the greatest wizard the world has seen in generations."),
					});

					public static readonly Table eccentricities = new Table("Eccentricities", "Eccentricity", Data.Rolls_String.d6, "", Data.Titles.XGE, 59, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "You have the habit of tapping your foot incessantly, which often annoys those around you."),
						new TableRow(2, TableRow.NOVALUE, "Your memory is quite good, but you have no trouble pretending to be absentminded when it suits your purposes."),
						new TableRow(3, TableRow.NOVALUE, "You never enter a room without looking to see what’s hanging from the ceiling."),
						new TableRow(4, TableRow.NOVALUE, "Your most prized possession is a dead worm that you keep inside a potion vial."),
						new TableRow(5, TableRow.NOVALUE, "When you want people to leave you alone, you start talking to yourself. That usually does the trick."),
						new TableRow(6, TableRow.NOVALUE, "Your fashion sense and grooming, or more accurately lack thereof, sometimes cause others to assume you are a beggar."),
					});
				}
			}

			public static class Origins
			{
				public static readonly Table parents = new Table("Parents", "Parents", Data.Rolls_String.d100, "", Data.Titles.XGE, 62, new TableRow[]
				{
					new TableRow(1, 95, "You know who your parents are or were."),
					new TableRow(96, 100, "You do not know who your parents were."),
				});

				public static readonly Table half_elf_parents = new Table("Half-Elf Parents", "Parents", Data.Rolls_String.d8, "", Data.Titles.XGE, 62, new TableRow[]
				{
					new TableRow(1, 5, "One parent was an elf and the other was a human."),
					new TableRow(6, TableRow.NOVALUE, "One parent was an elf and the other was a half-elf."),
					new TableRow(7, TableRow.NOVALUE, "One parent was a human and the other was a half-elf."),
					new TableRow(8, TableRow.NOVALUE, "Both parents were half-elves."),
				});

				public static readonly Table half_orc_parents = new Table("Half-Orc Parents", "Parents", Data.Rolls_String.d8, "", Data.Titles.XGE, 62, new TableRow[]
				{
					new TableRow(1, 3, "One parent was an orc and the other human."),
					new TableRow(4, 5, "One parent was an orc and the other was a half-orc."),
					new TableRow(6, 7, "One parent was a human and the other was a half-orc."),
					new TableRow(8, TableRow.NOVALUE, "Both parents were half-orcs"),
				});

				public static readonly Table tiefling_parents = new Table("Tiefling Parents", "Parents", Data.Rolls_String.d8, "", Data.Titles.XGE, 62, new TableRow[]
				{
					new TableRow(1, 4, "Both parents were humans, their infernal heritage dormant until you came along."),
					new TableRow(5, 6, "One parent was a tiefling and the other was a human."),
					new TableRow(7, TableRow.NOVALUE, "One parent was a tiefling and the other was a devil."),
					new TableRow(8, TableRow.NOVALUE, "One parent was a human and the other was a devil."),
				});

				public static readonly Table birthplace = new Table("Birthplace", "Location", Data.Rolls_String.d8, "", Data.Titles.XGE, 62, new TableRow[]
				{
					new TableRow(1, 50, "Home"),
					new TableRow(51, 55, "Home of a family friend"),
					new TableRow(56, 63, "Home of a healer or midwife"),
					new TableRow(64, 65, "Carriage, cart, or wagon"),
					new TableRow(66, 68, "Barn, shed, or other outbuilding"),
					new TableRow(69, 70, "Cave"),
					new TableRow(71, 72, "Field"),
					new TableRow(73, 74, "Forest"),
					new TableRow(75, 77, "Temple"),
					new TableRow(78, TableRow.NOVALUE, "Battlefield"),
					new TableRow(79, 80, "Alley or street"),
					new TableRow(81, 82, "Brothel, tavern, or inn"),
					new TableRow(83, 84, "Castle, keep, tower, or palace"),
					new TableRow(85, TableRow.NOVALUE, "Sewer or rubbish heap"),
					new TableRow(86, 88, "Among people of a different race"),
					new TableRow(89, 91, "On board a boat or ship"),
					new TableRow(92, 93, "In a prison or in the headquarters of a secret organization"),
					new TableRow(94, 95, "In a sage's laboratory"),
					new TableRow(96, TableRow.NOVALUE, "In the Feywild"),
					new TableRow(97, TableRow.NOVALUE, "In the Shadowfell"),
					new TableRow(98, TableRow.NOVALUE, "On the Astral Plane or the Ethereal Plane"),
					new TableRow(99, TableRow.NOVALUE, "On an Inner Plane of your choice"),
					new TableRow(100, TableRow.NOVALUE, "On an Outer Plane of your choice"),
				});

				public static readonly Table number_of_siblings = new Table("Number of Siblings", "Siblings", Data.Rolls_String.d10, "", Data.Titles.XGE, 62, new TableRow[]
				{
					new TableRow(-1, 2, "None"),
					new TableRow(3, 4, "1d3"),
					new TableRow(5, 6, "1d4 + 1"),
					new TableRow(7, 8, "1d6 + 2"),
					new TableRow(9, 10, "1d8 + 3"),
				});

				public static readonly Table birth_order = new Table("Birth Order", "Birth Order", Data.Rolls_String.d6x2, "", Data.Titles.XGE, 63, new TableRow[]
				{
					new TableRow(2, TableRow.NOVALUE, "Twin, triplet, or quadruplet"),
					new TableRow(3, 7, "Older"),
					new TableRow(8, 12, "Younger"),
				});

				public static readonly Table family = new Table("Family", "Family", Data.Rolls_String.d100, "", Data.Titles.XGE, 63, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE, "None"),
					new TableRow(2, TableRow.NOVALUE, "Institution, such as an asylum"),
					new TableRow(3, TableRow.NOVALUE, "Temple"),
					new TableRow(4, 5, "Orphanage"),
					new TableRow(6, 7, "Guardian"),
					new TableRow(8, 15, "Paternal or maternal aunt, uncle, or both; or extended family such as a tribe or clan"),
					new TableRow(16, 25, "Paternal or maternal grandparent(s)"),
					new TableRow(26, 35, "Adoptive family (same or different race)"),
					new TableRow(36, 55, "Single father or stepmother"),
					new TableRow(56, 75, "Single mother or stepmother"),
					new TableRow(76, 100, "Mother and father"),
				});

				public static readonly Table absent_parent = new Table("Absent Parents", "Fate", Data.Rolls_String.d4, "", Data.Titles.XGE, 63, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE, "Your parent died (roll on the Cause of Death supplemental table)."),
					new TableRow(2, TableRow.NOVALUE, "Your parent was imprisoned, esnlaved, or otherwise taken away."),
					new TableRow(3, TableRow.NOVALUE, "Your parent abandoned you."),
					new TableRow(4, TableRow.NOVALUE, "Your parent disappeared to an unknown fate."),
				});

				public static readonly Table family_lifestyle = new Table("Family Lifestyle", "Lifestyle", Data.Rolls_String.d6x3, "", Data.Titles.XGE, 63, new TableRow[]
				{
					new TableRow(3, TableRow.NOVALUE, "Wretched (-40)"),
					new TableRow(4, 5, "Squalid (-20)"),
					new TableRow(6, 8, "Poor (-10)"),
					new TableRow(9, 12, "Modest (+0)"),
					new TableRow(13, 15, "Comfortable (+10)"),
					new TableRow(16, 17, "Wealthy (+20)"),
					new TableRow(18, TableRow.NOVALUE, "Aristocratic (+40)"),
				});

				public static readonly Table childhood_home = new Table("Childhood Home", "Home", Data.Rolls_String.d100, "Family Lifestyle modifier", Data.Titles.XGE, 64, new TableRow[]
				{
					new TableRow(-39, 0, "On the streets"),
					new TableRow(1, 20, "Rundown shack"),
					new TableRow(21, 30, "No permanent residence; you moved around a lot"),
					new TableRow(31, 40, "Encampment or village in the wilderness"),
					new TableRow(41, 50, "Apartment in a rundown neighborhood"),
					new TableRow(51, 70, "Small house"),
					new TableRow(71, 90, "Large house"),
					new TableRow(91, 110, "Mansion"),
					new TableRow(111, 140, "Palace or castle"),
				});

				public static readonly Table childhood_memories = new Table("Childhood Memories", "Memory", Data.Rolls_String.d6x3, "Cha mod", Data.Titles.XGE, 64, new TableRow[]
				{
					new TableRow(-2, 3, "I am still haunted by my childhood, when I was treated badly by my peers."),
					new TableRow(4, 5, "I spent most of my childhood alone, with no close friends."),
					new TableRow(6, 8, "Others saw me as being different or strange, and so I had few companions."),
					new TableRow(9, 12, "I had a few close friends and lived an ordinary childhood."),
					new TableRow(13, 15, "I had several friends, and my childhood was generally a happy one."),
					new TableRow(16, 17, "I always found it easy to make friends, and I loved being around people."),
					new TableRow(18, 23, "Eeryone knew who I was, and I had friends everywhere I went."),
				});
			}

			public static class PersonalDecisions
			{
				public static class Background
				{
					public static readonly Table acolyte = new Table("Acolyte", "I became an acolyte because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 64, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I ran away from home at an early age and found refuge in a temple."),
						new TableRow(2, TableRow.NOVALUE, "My family gave me to a temple, since they were unable or unwilling to care for me."),
						new TableRow(3, TableRow.NOVALUE, "I grew up in a household with strange religious convictions. Enterign the service of one or more gods seemed natural."),
						new TableRow(4, TableRow.NOVALUE, "An impassioned sermon struck a chord deep in my soul and moved me to serve the faith."),
						new TableRow(5, TableRow.NOVALUE, "I followed a childhood friend, a respected acquaintance, or someone I loved into religious service."),
						new TableRow(6, TableRow.NOVALUE, "After encountering a true servant of the gods, I was so inspired that I immediately entered the service of a religous group."),
					});

					public static readonly Table charlatan = new Table("Charlatan", "I became a charlatan because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 64, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I was left to my own devices, and my knack for manipulating others helped me survive."),
						new TableRow(2, TableRow.NOVALUE, "I learned early on that people are gullible and easy to exploit."),
						new TableRow(3, TableRow.NOVALUE, "I often got in trouble, but I managed to talk my way out of it every time."),
						new TableRow(4, TableRow.NOVALUE, "I took up with a confidence artist, from whom I learned my craft."),
						new TableRow(5, TableRow.NOVALUE, "After a charlatan fleeced my family, I decided to learn the trade so I would never be fooled by such deception again."),
						new TableRow(6, TableRow.NOVALUE, "I was poor or I feared becoming poor, so I learned the tricks I needed to keep myself out of poverty."),
					});

					public static readonly Table criminal = new Table("Criminal", "I became a criminal because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I resented authority in my younger days and saw a life of crime as the best way to fight against tyranny and oppression."),
						new TableRow(2, TableRow.NOVALUE, "Necessity forced me to take up the life, since it was the only way I could survive."),
						new TableRow(3, TableRow.NOVALUE, "I fell in with a gang of reprobates and ne'er-do-wells, and I learned my specialty from them."),
						new TableRow(4, TableRow.NOVALUE, "A parent or relative taught me my criminal specialty to prepare me for the family business."),
						new TableRow(5, TableRow.NOVALUE, "I left home and found a place in a thieves' guild or some other criminal organization"),
						new TableRow(6, TableRow.NOVALUE, "I was always bored, so I turned to crime to pass the time and discovered I was quite good at it."),
					});

					public static readonly Table entertainer = new Table("Entertainer", "I became an entertainer because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Members of my family made ends meet by performing, so it was fitting for me to follow their example."),
						new TableRow(2, TableRow.NOVALUE, "I always had a keen insight into other people, enough so that I could make them laugh or cry with my stories or songs."),
						new TableRow(3, TableRow.NOVALUE, "I ran away from home to follow a minstrel troupe."),
						new TableRow(4, TableRow.NOVALUE, "I saw a bard perform once, and I knew from that moment on what I was born to do."),
						new TableRow(5, TableRow.NOVALUE, "I earned coin by performing on street corners and eventually made a name for myself."),
						new TableRow(6, TableRow.NOVALUE, "A traveling entertainer took me in and taught me the trade."),
					});

					public static readonly Table folk_hero = new Table("Folk Hero", "I became a folk hero because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I learned what was right and wrong from my family."),
						new TableRow(2, TableRow.NOVALUE, "I was always enamored by tales of heroes and wished I could be something more than ordinary."),
						new TableRow(3, TableRow.NOVALUE, "I hated my mundane life, so when it was time for someone to step up and do the right thing, I took my chance."),
						new TableRow(4, TableRow.NOVALUE, "A parent or one of my relatives was an adventurer, and I was inspired by that person's courage."),
						new TableRow(5, TableRow.NOVALUE, "A mad old hermit spoke a prophecy when I was born, saying that I would accomplish great things."),
						new TableRow(6, TableRow.NOVALUE, "I have always stood up for those who are weaker than I am."),
					});

					public static readonly Table guild_artisan = new Table("Guild Artisan", "I became a a guild artisan because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I was apprenticed to a master who taught me the guild's business"),
						new TableRow(2, TableRow.NOVALUE, "I helped a guild artisan keep a secret or complete a task, and in return I was taken on as an apprentice."),
						new TableRow(3, TableRow.NOVALUE, "One of my family members who belonged to the guild made a place for me."),
						new TableRow(4, TableRow.NOVALUE, "I was always good with my hands, so I took the opportunity to learn a trade."),
						new TableRow(5, TableRow.NOVALUE, "I wanted to get away from my home situation and start a new life."),
						new TableRow(6, TableRow.NOVALUE, "I learned the essentials of my craft from a mentor but had to join the guild to finish my training."),
					});

					public static readonly Table hermit = new Table("Hermit", "I became a hermit because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "My enemies ruined my reputation, and I fled to the wilds to avoid furhter disparagement."),
						new TableRow(2, TableRow.NOVALUE, "I am comfortable with being isolated, as I seek inner peace."),
						new TableRow(3, TableRow.NOVALUE, "I never liked the people I called my friends, so it was easy for me to strike out on my own."),
						new TableRow(4, TableRow.NOVALUE, "I felt compelled to forsake my past, but did so with great reluctance, and sometimes I regret making that decision."),
						new TableRow(5, TableRow.NOVALUE, "I lost everything -- my home, my family, my friends. Going it alone was all I could do."),
						new TableRow(6, TableRow.NOVALUE, "Society's decadence disgusted me, so I decided to leave it behind."),
					});

					public static readonly Table noble = new Table("Noble", "I became a noble because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I come from an old and storied family, and it fell to me to preserve the family name."),
						new TableRow(2, TableRow.NOVALUE, "My family has been disgraced, and I intend to clear our name."),
						new TableRow(3, TableRow.NOVALUE, "My family recently came by its title, and that elevation thrust us into a new and strange world."),
						new TableRow(4, TableRow.NOVALUE, "My family has a title, but none of my ancestors have distinguished themselves since we gained it."),
						new TableRow(5, TableRow.NOVALUE, "My faimly is filled with remarkable people. I hope to live up to their example."),
						new TableRow(6, TableRow.NOVALUE, "I hope to increase my family's power and influence."),
					});

					public static readonly Table outlander = new Table("Outlander", "I became an outlander because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 65, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I spent a lot of time in the wilderness as a youngster, and I came to love that way of life."),
						new TableRow(2, TableRow.NOVALUE, "From a young age, I couldn't abide the stink of the cities and preferred to spend my time in nature."),
						new TableRow(3, TableRow.NOVALUE, "I came to understand the darkness that lurks in the wilds, and I vowed to combat it."),
						new TableRow(4, TableRow.NOVALUE, "My people lived on the dges of civilization, and I learned the methods of survival from my family."),
						new TableRow(5, TableRow.NOVALUE, "After a tragedy I retreated to the wilderness, leaving my old life behind."),
						new TableRow(6, TableRow.NOVALUE, "My family moved away from civilization, and I learned to adapt to my new environment."),
					});

					public static readonly Table sage = new Table("Sage", "I became a sage because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 66, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I was naturally curious, so I packed up and wnet to a university to learn more about the world."),
						new TableRow(2, TableRow.NOVALUE, "My mentor's teachings opened my mind to new possibilities in that field of study."),
						new TableRow(3, TableRow.NOVALUE, "I was always an avid reader, and I learned much about my favorite topic on my own."),
						new TableRow(4, TableRow.NOVALUE, "I discovered an old library and pored over the texts I found there. That experience awakened a hunger for more knowledge."),
						new TableRow(5, TableRow.NOVALUE, "I impressed a wizard who told me I was squandering my talents and should seek out an education to take advantage of my gifts."),
						new TableRow(6, TableRow.NOVALUE, "One of m parents or a relative gave me a basic education that whetted my appetite, and I left home to build on what I had learned."),
					});

					public static readonly Table sailor = new Table("Sailor", "I became a sailor because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 66, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I was press-ganged by pirates and forced to serve on their ship until I finally escaped."),
						new TableRow(2, TableRow.NOVALUE, "I wanted to see the world, so I signed on as a deckhand for a merchant ship."),
						new TableRow(3, TableRow.NOVALUE, "One of my relatives was a sailor who took me to sea."),
						new TableRow(4, TableRow.NOVALUE, "I needed to escape my community quickly, so I stowed away on a ship. When the crew found me, I was forced to work for my passage."),
						new TableRow(5, TableRow.NOVALUE, "Reavers attacked my community, so I found refuge on a ship until I could seek vengeance."),
						new TableRow(6, TableRow.NOVALUE, "I had few prospects where I was living, so I left to find my fortune elsewhere."),
					});

					public static readonly Table soldier = new Table("Soldier", "I became a soldier because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 66, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I joined the militia to help protect my community from monsters."),
						new TableRow(2, TableRow.NOVALUE, "A relative of mine was a soldier, and I wanted to carry on the family tradition."),
						new TableRow(3, TableRow.NOVALUE, "The local lord forced me to enlist in the army."),
						new TableRow(4, TableRow.NOVALUE, "War ravaged my homeland while I was growing up. Fighting was the only life I ever knew."),
						new TableRow(5, TableRow.NOVALUE, "I wanted fame and fortune, so I joined a mercenary company, selling my sword to the highest bidder."),
						new TableRow(6, TableRow.NOVALUE, "Invaders attacked my homeland. It was my duty to take up arms in defense of my people."),
					});

					public static readonly Table urchin = new Table("Urchin", "I became an urchin because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 66, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "Wanderlust caused me to leave my family to see the world. I look after myself."),
						new TableRow(2, TableRow.NOVALUE, "I ran away from a bad situation at home and made my own way in the world."),
						new TableRow(3, TableRow.NOVALUE, "Monsters wiped out my village, and I was the sole survivor. I had to find a way to survive."),
						new TableRow(4, TableRow.NOVALUE, "A notorious thief looked after me and other orphans, and we spied and stole to earn our keep."),
						new TableRow(5, TableRow.NOVALUE, "One day I woke up on the streets, alone and hungry, with no memory of my early childhood."),
						new TableRow(6, TableRow.NOVALUE, "My parents died, leaving no one to look after me. I raised myself."),
					});
				}

				public static class ClassTraining
				{
					public static readonly Table barbarian = new Table("Barbarian", "I became a barbarian because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 66, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "My devotion to my people lifted me in battle, making me powerful and dangerous."),
						new TableRow(2, TableRow.NOVALUE, "The spirits of my ancestors called on me to carry out a great task."),
						new TableRow(3, TableRow.NOVALUE, "I lost control in battle one day, and it was as if something else was manipulating my body, forcing it to kill every foe I could reach."),
						new TableRow(4, TableRow.NOVALUE, "I went on a spiritual journey to find myself and instead found a spirit animal to guide, protect, and inspire me."),
						new TableRow(5, TableRow.NOVALUE, "I was struck by lightning and lived. Afterward, I found a new strength within me that let me push beyond my limitations."),
						new TableRow(6, TableRow.NOVALUE, "My anger needed to be channeled into battle, or I risked becoming an indiscriminate killer."),
					});

					public static readonly Table bard = new Table("Bard", "I became a bard because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 66, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I awakened my latent bardic abilities through trial and error."),
						new TableRow(2, TableRow.NOVALUE, "I was a gifted performer and attracted the attention of a master bard who schooled me in the old techniques."),
						new TableRow(3, TableRow.NOVALUE, "I joined a loose society of scholars and orators to learn new techniques of performance and magic."),
						new TableRow(4, TableRow.NOVALUE, "I felt a calling to recount the deeds of champions and heroes, to bring them alive in song and story."),
						new TableRow(5, TableRow.NOVALUE, "I joined one of the great colleges to learn old lore, the secrets of magic, and the art of performance."),
						new TableRow(6, TableRow.NOVALUE, "I picked up a musical instrument one day and instantly discovered that I could play it."),
					});

					public static readonly Table cleric = new Table("Cleric", "I became a cleric because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 67, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A supernatural being in service to the gods called me to become a divine agent in the world."),
						new TableRow(2, TableRow.NOVALUE, "I saw the injustice and horror in the world and felt moved to take a stand against them."),
						new TableRow(3, TableRow.NOVALUE, "My god gave me an unmistakable sign. I dropped everythign to serve the divine."),
						new TableRow(4, TableRow.NOVALUE, "Although I was always devout, it wasn't until I completed a pilgrimage that I knew my true calling."),
						new TableRow(5, TableRow.NOVALUE, "I used to serve in my religion's bureaucracy but found I needed to work in the world, to bring the message of my faith to the darkest corners of the land."),
						new TableRow(6, TableRow.NOVALUE, "I realize that my god works through me, and I do as commanded, even though I don't know why I was chosen to serve."),
					});

					public static readonly Table druid = new Table("Druid", "I became a druid because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 67, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I saw too much devastation in the wild places, too much of nature's splendor ruined by the despoilers. I joined a circle of druids to fight back against the enemies of nature."),
						new TableRow(2, TableRow.NOVALUE, "I found a place among a group of druids after I fled a catastrophe."),
						new TableRow(3, TableRow.NOVALUE, "I have always had an affinity for animals, so I explored my talent to see how I could best use it."),
						new TableRow(4, TableRow.NOVALUE, "I befriended a druid and was moved by druidic teachings. I decided to follow my friend's guidance and give something back to the world."),
						new TableRow(5, TableRow.NOVALUE, "While I was growing up, I saw spirits all around me -- entities no one else could perceive. I sought out the druids to help me understand the visions and communicate with these beings."),
						new TableRow(6, TableRow.NOVALUE, "I have always felt disgust for creatures of unnatural origin. For this reason, I immersed myself in the study of the druidic mysteries and became a champion of the natural order."),
					});

					public static readonly Table fighter = new Table("Fighter", "I became a fighter because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 67, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I wanted to hone my combat skills, and so I joined a war college."),
						new TableRow(2, TableRow.NOVALUE, "I squired for a knight who taught me how to fight, care for a steed, and conduct myself with honor. I decided to take up that path for myself."),
						new TableRow(3, TableRow.NOVALUE, "Horrible monsters descended on my community, killing someone I loved. I took up arms to destroy those creatures and others of a similar nature."),
						new TableRow(4, TableRow.NOVALUE, "I joined the army and learned how to fight as part of a group."),
						new TableRow(5, TableRow.NOVALUE, "I grew up fighting, and I refined my talents by defending myself against people who crossed me."),
						new TableRow(6, TableRow.NOVALUE, "I could always pick up just about any weapon and know how to use it effectively."),
					});

					public static readonly Table monk = new Table("Monk", "I became a monk because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 67, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I was chosen to study at a secluded monastery. THere, I was taught the fundamental techniques required to eventually master a tradition."),
						new TableRow(2, TableRow.NOVALUE, "I sought instruction to gain a deeper understanding of existence and my place in the world."),
						new TableRow(3, TableRow.NOVALUE, "I stumbled into a portal to the Shadowfell and took refuge in a strange monastery, where I learned how to defend myself against the forces of darkness."),
						new TableRow(4, TableRow.NOVALUE, "I was overwhelmed with grief after losing someone close to me, and I sought the advice of philosophers to help me cope with my loss."),
						new TableRow(5, TableRow.NOVALUE, "I could feel that a special sort of power lay within me, so I sought out those who could help me call it forth and master it."),
						new TableRow(6, TableRow.NOVALUE, "I was wild and undisciplined as a youngster, but then I realized the error of my ways. I applied to a monastery and became a monk as a way to live a life of discipline."),
					});

					public static readonly Table paladin = new Table("Paladin", "I became a paladin because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 68, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "A fantastical being appeared before me and called on me to undertake a holy quest."),
						new TableRow(2, TableRow.NOVALUE, "One of my ancestors left a holy quest unfulfilled, so I intend to finish that work."),
						new TableRow(3, TableRow.NOVALUE, "The world is a dark and terrible place. I decided to serve as a beacon of light shining out against the gathering shadows."),
						new TableRow(4, TableRow.NOVALUE, "I served as a paladin's squire, learning all I needed to swear my own sacred oath."),
						new TableRow(5, TableRow.NOVALUE, "Evil must be opposed on all fronts. I feel compelled to seek out wickedness and purge it from the world."),
						new TableRow(6, TableRow.NOVALUE, "Becoming a paladin was a natural consequence of my unwavering faith. In taking my vows, I became the holy sword of my religion."),
					});

					public static readonly Table ranger = new Table("Ranger", "I became a ranger because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 68, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I found purpose while I honed my hunting skills by bringing down dangerous animals at the edge of civilization."),
						new TableRow(2, TableRow.NOVALUE, "I always had a way with animals, able to calm them with a soothing word and a touch."),
						new TableRow(3, TableRow.NOVALUE, "I suffer from terrible wanderlust, so being a ranger gave me a reason not to remain in one place for too long."),
						new TableRow(4, TableRow.NOVALUE, "I have seen what happens when the monsters come out from the dark. I took it upon myself ot become the first line of defense against the evils that lie beyond civilization's borders."),
						new TableRow(5, TableRow.NOVALUE, "I met a grizzled ranger who taught me woodcraft and the secrets of the wild lands."),
						new TableRow(6, TableRow.NOVALUE, "I served in an army, learning the precepts of my profession while blazing trails and scouting enemy encampments."),
					});

					public static readonly Table rogue = new Table("Rogue", "I became a rogue because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 68, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "I've always been nimble and quick of wit, so I decided to use those talents to help me make my way in the world."),
						new TableRow(2, TableRow.NOVALUE, "An assassin or a thief wronged me, so I focused my training on mastering the skills of my enemy to better combat foes of that sort."),
						new TableRow(3, TableRow.NOVALUE, "An experienced rogue saw something in me and taught me several useful tricks."),
						new TableRow(4, TableRow.NOVALUE, "I decided to turn my natural lucky streak into the basis of a career, though I still realize that improving my skills is esential."),
						new TableRow(5, TableRow.NOVALUE, "I took up with a group of ruffians who showed me how to get what I want through sneakiness rather than direct confrontation."),
						new TableRow(6, TableRow.NOVALUE, "I'm a sucker for a shiny bauble or a sack of coins, as long as I can get my ands on it without risking life and limb."),
					});

					public static readonly Table sorcerer = new Table("Sorcerer", "I became a sorcerer because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 68, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "When I was born, all the water in the house forze solid, the milk spoiled, or all the iron turned to copper. My family is convinced that this event was a harbinger of stranger things to come for me."),
						new TableRow(2, TableRow.NOVALUE, "I suffered a terrible emotional or physical strain, which brought forth my latent magical power. I have fought to control it ever since."),
						new TableRow(3, TableRow.NOVALUE, "My immediate family never spoke of my ancestors, and when I asked, they would change the subject. It wasn't until I started displaying strange talents that the full truth of my heritage came out."),
						new TableRow(4, TableRow.NOVALUE, "When a monster threatened one of my friends, I became filled with anxiety. I lashed out instinctively and blasted the wretched thing with a force that came from me."),
						new TableRow(5, TableRow.NOVALUE, "Sensing something special in me, a stranger taught me how to control my gift."),
						new TableRow(6, TableRow.NOVALUE, "After I escaped from a magical conflagration, I realized that thought I was unharmed, I was not unchanged. I began to exhibit unusual abilities that I am just beginning to understand."),
					});

					public static readonly Table warlock = new Table("Warlock", "I became a warlock because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 68, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "While wandering around in a forbidden place, I encountered an otherworldly being that offered to enter into a pact with me."),
						new TableRow(2, TableRow.NOVALUE, "I was examining a strange tome I found in an abandoned library when the entity that would become my patron suddenly appeared before me."),
						new TableRow(3, TableRow.NOVALUE, "I stumbled into the clutches of my patron after I accidentally stepped through a magical doorway."),
						new TableRow(4, TableRow.NOVALUE, "When I was faced with a terrible crisis, I prayed to any being who would listen, and the creature that answered became my patron."),
						new TableRow(5, TableRow.NOVALUE, "My future patron visited me in my dreams and offered great power in exchange for my service."),
						new TableRow(6, TableRow.NOVALUE, "One of my ancestors had a pact with my patron, so that entity was determined to bind me to the same agreement."),
					});

					public static readonly Table wizard = new Table("Wizard", "I became a wizard because ...", Data.Rolls_String.d6, "", Data.Titles.XGE, 69/*nice*/, new TableRow[]
					{
						new TableRow(1, TableRow.NOVALUE, "An old wizard chose me from among several candidates to serve an apprenticeship."),
						new TableRow(2, TableRow.NOVALUE, "When I became lost in a forest, a hedge wizard found me, took me in, and taught me the rudiments of magic."),
						new TableRow(3, TableRow.NOVALUE, "I grew up listening to tales of great wizards and knew I wanted to follow their path. I strove to be accepted at an academy of magic and succeeded."),
						new TableRow(4, TableRow.NOVALUE, "One of my relatives was an accomplished wizard who decided I was smart enough to learn the craft."),
						new TableRow(5, TableRow.NOVALUE, "While exploring an old tomb, library, or temple, I found a spellbook. I was immediately driven to learn all I could about becoming a wizard."),
						new TableRow(6, TableRow.NOVALUE, "I was a prodigy who demonstrated mastery of the arcane arts at an early age. When I became old enough to set out on my own, I did so to learn more magic and expand my power."),
					});
				}
			}

			public static class LifeEvents
			{
				public static readonly Table life_events_by_age_current_age = new Table("Life Events by Age", "Current Age", Data.Rolls_String.d100, "", Data.Titles.XGE, 69, new TableRow[]
				{
						new TableRow(1, 20, "20 years or younger - 1 life event"),
						new TableRow(21, 59, "21-30 - 1d4 life events"),
						new TableRow(60, 69, "31-40 - 1d6 life events"),
						new TableRow(70, 89, "41-50 - 1d8 life events"),
						new TableRow(90, 99, "51-60 years - 1d10 life events"),
						new TableRow(100, TableRow.NOVALUE, "61 years or older - 1d12"),
				});

				public static readonly Table life_events = new Table("Life Events", "Event", Data.Rolls_String.d100, "", Data.Titles.XGE, 69, new TableRow[]
				{
						new TableRow(1, 10, "You suffered a tragedy. Roll on the Tragedies table."),
						new TableRow(11, 20, "You gained a bit of good fortune. Roll on the Boons table."),
						new TableRow(21, 30, "You fell in love or got married. If you get this result more than once, you can choose to have a child instead. Work with your DM to determine the identity of your love interest."),
						new TableRow(31, 40, "You made an enemy of an adventurer. Roll a d6. An odd number indicates you are to blame for the rift, and an even number indicates you are blameless. Use the supplemental tables and work with your DM to determine this hostile character's identity and the danger this enemy poses to you."),
						new TableRow(41, 50, "You made a friend of an adventurer. Use the supplemental tables and work with your DM to add more detail to this friendly character and establish how your friendship began."),
						new TableRow(51, 70, "You spent time working in a job related to your background. Start the game with an extra 2d6 gp."),
						new TableRow(71, 75, "You met someone important. Use the supplemental tables to determine this character's identity and how this individual feels about you. Work out additional details with your DM as needed to fit this character into your backstory."),
						new TableRow(76, 80, "You went on an adventure. Roll on the Adventures table to see what happened to you. Work with your DM to determine the nature of the adventure and the creatures you encountered."),
						new TableRow(81, 85, "You had a supernatural experience. Roll on the Supernatural Events table to find out what it was."),
						new TableRow(86, 90, "You fought in a battle. Roll on the War table to learn what happened to you. Work with your DM to come up with the reason for the battle and the factions involved. It might have been a small conflict between your community and a band of orcs, or it could have been a major battle in a larger war."),
						new TableRow(91, 95, "You committed a crime or were wrongly accused of doing so. Roll on the Crime table to determine the nature of the offense and on the Punishment table to see what became of you."),
						new TableRow(96, 99, "You encountered something magical. Roll on the Arcane Matters table."),
						new TableRow(100, TableRow.NOVALUE, "Something truly strange happened to you. Roll on the Weird Stuff table."),
				});

				public static readonly Table adventures = new Table("Adventures", "Outcome", Data.Rolls_String.d100, "", Data.Titles.XGE, 70, new TableRow[]
				{
						new TableRow(1, 10, "You nearly died. You have nasty scars on your body, and you are missing an ear, 1d3 fingers, or 1d4 toes."),
						new TableRow(11, 20, "You suffered a grievous injury. Although the wound healed, it still pains you from time to time."),
						new TableRow(21, 30, "You were wounded, but in time you fully recovered."),
						new TableRow(31, 40, "You contracted a disease while exploring a filthy warren. You recovered from the disease, but you have a persistent cough, pockmarks on your skin, or prematurely gray hair."),
						new TableRow(41, 50, "You were poisoned by a trap or a monster. You recovered, but the next time you must make a saving throw against poison, you make the saving throw with disadvantage."),
						new TableRow(51, 60, "You lost something of sentimental value to you during your adventure. Remove one trinket from your possessions."),
						new TableRow(61, 70, "You were terribly frightened by something you encountered and ran away, abandoning your companions to their fate."),
						new TableRow(71, 80, "You learned a great deal during your adventure. The next time you make an ability check or a saving throw, you have advantage on the roll."),
						new TableRow(81, 90, "You found some treasure on your adventure. You have 2d6 gp left from your share of it."),
						new TableRow(91, 99, "You found a considerable amount of treasure on your adventure. You have 1d20 + 50 gp left from your share of it."),
						new TableRow(100, TableRow.NOVALUE, "You came across a common magic item (of the DM's choice)."),
				});

				public static readonly Table arcane_matters = new Table("Arcane Matters", "Magical Event", Data.Rolls_String.d10, "", Data.Titles.XGE, 70, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE, "You were charmed or frightened by a spell."),
					new TableRow(2, TableRow.NOVALUE, "You were injured by the effects of a spell."),
					new TableRow(3, TableRow.NOVALUE, "You witnessed a powerful spell bing cast by a cleric, druid, sorcerer, warlock, or a wizard"),
					new TableRow(4, TableRow.NOVALUE, "You drank a potion (of the DM's choice)."),
					new TableRow(5, TableRow.NOVALUE, "You found a spell scroll (of the DM's choice) and succeeded in casting the spell it contained."),
					new TableRow(6, TableRow.NOVALUE, "You were affected by teleportation magic."),
					new TableRow(7, TableRow.NOVALUE, "You turned invisible for a time."),
					new TableRow(8, TableRow.NOVALUE, "You identified an illusion for what it was."),
					new TableRow(9, TableRow.NOVALUE, "You saw a creature being conjured by magic."),
					new TableRow(10, TableRow.NOVALUE, "Your fortune was read by a diviner. Roll twice on the Life Events table, but don't apply the results. Instead, the DM picks one event as a portent of your future (which might or might not come true)."),
				});

				public static readonly Table boons = new Table("Boons", "Boon", Data.Rolls_String.d10, "", Data.Titles.XGE, 70, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE, "A friendly wizard gave you a spell scroll containing one cantirp (of the DM's choice)."),
					new TableRow(2, TableRow.NOVALUE, "You saved the life of a commoner, who now owes you a life debt. This individual accompanies you on your travels and performs mundane tasks for you, but will leave if neglected, abused, or imperiled. Determine details about this character by using the supplemental tables and working with your DM."),
					new TableRow(3, TableRow.NOVALUE, "You found a riding horse."),
					new TableRow(4, TableRow.NOVALUE, "You found some money. You have 1d20 gp in addition to your regular starting funds."),
					new TableRow(5, TableRow.NOVALUE, "A relative bequeathed you a simple weapon of your choice."),
					new TableRow(6, TableRow.NOVALUE, "You found something interesting. You gain one additional trinket."),
					new TableRow(7, TableRow.NOVALUE, "You once performed a service for a local temple. The next time you visit the temple, you can receive healing up to your hit point maximum."),
					new TableRow(8, TableRow.NOVALUE, "A friendly alchemist gifted you with a potion of healing or a flask of acid, as you choose."),
					new TableRow(9, TableRow.NOVALUE, "You found a treasure map."),
					new TableRow(10, TableRow.NOVALUE, "A distant relative left you a stipend that enables you to live at the comfortable lifestyle for 1d20 years. If you choose to live at a higher lifesylte, you reduce the price of the lifestyle by 2 gp during that time period."),
				});

				public static readonly Table crime = new Table("Crime", "Crime", Data.Rolls_String.d8, "", Data.Titles.XGE, 70, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE, "Murder"),
					new TableRow(2, TableRow.NOVALUE, "Theft"),
					new TableRow(3, TableRow.NOVALUE, "Burglary"),
					new TableRow(4, TableRow.NOVALUE, "Assault"),
					new TableRow(5, TableRow.NOVALUE, "Smuggling"),
					new TableRow(6, TableRow.NOVALUE, "Kidnapping"),
					new TableRow(7, TableRow.NOVALUE, "Extortion"),
					new TableRow(8, TableRow.NOVALUE, "Counterfeiting"),
				});

				public static readonly Table punishment = new Table("Punishment", "Punishment", Data.Rolls_String.d12, "", Data.Titles.XGE, 70, new TableRow[]
				{
					new TableRow(1, 3, "You did not commit the crime and were exonerated after being accused."),
					new TableRow(4, 6, "You committed the crime or helped do so, but nonetheless the authorities found you not guilty."),
					new TableRow(7, 8, "You were nearly caught in the act. You had to flee and are wanted in the community where the crime occurred."),
					new TableRow(9, 12, "You were caught and convicted. You spent time in jail, chained to an oar, or performing hard labor. You served a sentence of 1d4 years or succeeded in escaping after that much time."),
				});

				public static readonly Table supernatural_events = new Table("Supernatural Events", "Event", Data.Rolls_String.d100, "", Data.Titles.XGE, 71, new TableRow[]
				{
					new TableRow(1, 5,    "You were ensorcelled by a fey and enslaved for 1d6 years before you escaped."),
					new TableRow(6, 10,   "You saw a demon and ran away before it could do anything to you."),
					new TableRow(11, 15,  "A devil tempted you. Make a DC 10 Wisdom saving throw. On a failed save, your alignment shifts one step toward evil (if it's not evil already), and you start the game with an additional 1d20 + 50 gp."),
					new TableRow(16, 20,  "You woke up one morning miles from your home, with no idea how you got there."),
					new TableRow(21, 30,  "You visited a holy site and felt the presence of the divine there."),
					new TableRow(31, 40,  "You witnessed a falling red star, a face appearing in the frost, or some other bizarre happening. You are certain that it was an omen of some sort."),
					new TableRow(41, 50,  "You escaped certain death and believe it was the intervention of a god that saved you."),
					new TableRow(51, 60,  "You witnessed a minor miracle."),
					new TableRow(61, 70,  "You explored an empty house and found it to be haunted."),
					new TableRow(71, 75,  "You were briefly possessed. Roll a d6 to determine what type of creature possessed you: 1, celestial; 2, devil; 3, demon; 4, fey; 5, elemental; 6, undead."),
					new TableRow(76, 80,  "You saw a ghost."),
					new TableRow(81, 85,  "You saw a ghoul feeding on a corpse."),
					new TableRow(86, 90,  "A celestial or a fiend visited you in your dreams to give a warning of dangers to come."),
					new TableRow(91, 95,  "You briefly visited the Feywild or the Shadowfell."),
					new TableRow(96, 100, "You saw a portal that you believe leads to another plane of existence."),
				});

				public static readonly Table tragedies = new Table("Tragedies", "Tragedy", Data.Rolls_String.d12, "", Data.Titles.XGE, 71, new TableRow[]
				{
					new TableRow(1, 2, "A family member or a close friend died. Roll on the Cause of Death supplemental table to find out how."),
					new TableRow(3, TableRow.NOVALUE, "A friendship ended bitterly, and the other person is now hostile to you. The cause might have been a misunderstanding or something you or the former friend did."),
					new TableRow(4, TableRow.NOVALUE, "You lost all your possessions in a disaster, and you had to rebuild your life."),
					new TableRow(5, TableRow.NOVALUE, "You were imprisoned for a crime you didn't commit and spent 1d6 years at hard labor, in jail, or shackled to an oar in a slave galley."),
					new TableRow(6, TableRow.NOVALUE, "War ravaged your home community, reducing everything to rubble and ruin. In the aftermath, you either helped your town rebuild or moved somewhere else."),
					new TableRow(7, TableRow.NOVALUE, "A lover disappeared without a trace. You have been looking for that person ever since."),
					new TableRow(8, TableRow.NOVALUE, "A terrible blight in your home community caused crops to fail, and many starved. You lost a sibling or some other family member."),
					new TableRow(9, TableRow.NOVALUE, "You did something that brought terrible shame to you in the eyes of your family. You might have been involved in a scandal, dabbled in dark magic, or offended someone important. The attitude of your family members toward you becomes indifferent at best, thought they might eventually forgive you."),
					new TableRow(10, TableRow.NOVALUE, "For a reason you were never told, you were exiled from your community. You then either wandered in the wilderness for a time or promptly found a new place to live."),
					new TableRow(11, TableRow.NOVALUE, "A romantic relationship ended. Roll a d6. An odd number means it ended with bad feelings, while an even number means it ended amicably."),
					new TableRow(12, TableRow.NOVALUE, "A current or prospective romantic partner of yours died. Roll on the Cause of Death supplemental table to find out how. If the result is murder, roll a d12. On a 1, you were responsible, whether directly or indirectly."),
				});

				public static readonly Table war = new Table("War", "War Outcome", Data.Rolls_String.d12, "", Data.Titles.XGE, 71, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE, "You were knocked out and left for dead. You woke up hours later with no recollection of the battle."),
					new TableRow(2, 3, "You were badly injured in the fight, and you still bear the awful scars of those wounds."),
					new TableRow(4, TableRow.NOVALUE, "You ran away from the battle to save your life, but you still feel shame for your cowardice."),
					new TableRow(5, 7, "You suffered only minor injuries, and the wounds all healed without leaving scars."),
					new TableRow(8, 9, "You survived the battle, but you suffer from terrible nightmares in which you relive the experience."),
					new TableRow(10, 11, "You escaped the battle unscathed, though many of your friends were injured or lost."),
					new TableRow(12, TableRow.NOVALUE, "You acquitted yourself will in battle and are remembered as a hero. You might have received a medal for your bravery."),
				});

				public static readonly Table weird_stuff = new Table("Weird Stuff", "What Happened", Data.Rolls_String.d12, "", Data.Titles.XGE, 72, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE,   "You were turned into a toad and remained in that form for 1d4 weeks."),
					new TableRow(2, TableRow.NOVALUE,   "You were petrified and remained a stone statue for a time until someone freed you."),
					new TableRow(3, TableRow.NOVALUE,   "You were enslaved by a hag, a satyr, or some other being and lived in that creature's thrall for 1d6 years."),
					new TableRow(4, TableRow.NOVALUE,   "A dragon held you as prisoner for 1d4 months until adventurers killed it."),
					new TableRow(5, TableRow.NOVALUE,   "You were taken captive by a race of evil humanoids such as drow, kua-toa, or quaggoths. You lived as a slave in the Underdark until you escaped."),
					new TableRow(6, TableRow.NOVALUE,   "You served a powerful adventurer as a hireling. You have only recently left that service. Use the supplemental tables and work with your DM to determine the basic details about your former employer."),
					new TableRow(7, TableRow.NOVALUE,   "You went insane for 1d6 years and recently regained your sanity. A tic or some other bit of odd behavior might linger."),
					new TableRow(8, TableRow.NOVALUE,   "A lover of yours was secretly a silver dragon."),
					new TableRow(9, TableRow.NOVALUE,  "You were captured by a cult and nearly sacrificed on an alter to the foul being the cultists served. You escaped, but you fear they will find you."),
					new TableRow(10, TableRow.NOVALUE,  "You met a demigod, an archdevil, an archfey, a demon loard, or a titan, and you lived to tell the tale."),
					new TableRow(11, TableRow.NOVALUE,  "You were swallowed by a giant fish and spent a month in its gullet before you escaped."),
					new TableRow(12, TableRow.NOVALUE,  "A powerful being granted you a wish, but you squandered it on something frivolous."),
				});
			}

			public static class SupplementalTables
			{
				public static readonly Table alignment = new Table("Alignment", "Alignment", Data.Rolls_String.d6x3, "", Data.Titles.XGE, 72, new TableRow[]
				{
					new TableRow(3, TableRow.NOVALUE,   "Chaotic evil (50%) or chaotic neutral (50%)"),
					new TableRow(4, 5,                  "Lawful evil"),
					new TableRow(6, 8,                  "Neutral evil"),
					new TableRow(9, 12,                 "Neutral"),
					new TableRow(13, 15,                "Neutral good"),
					new TableRow(16, 17,                "Lawful good (50%) or lawful neutral (50%)"),
					new TableRow(18, TableRow.NOVALUE,  "Chaotic good (50%) or chaotic neutral (50%)"),
				});

				public static readonly Table cause_of_death = new Table("Cause of Death", "Cause of Death", Data.Rolls_String.d12, "", Data.Titles.XGE, 72, new TableRow[]
				{
					new TableRow(1, TableRow.NOVALUE,   "Unknown"),
					new TableRow(2, TableRow.NOVALUE,   "Murdered"),
					new TableRow(3, TableRow.NOVALUE,   "Killed in battle"),
					new TableRow(4, TableRow.NOVALUE,   "Accident related to class or occupation"),
					new TableRow(5, TableRow.NOVALUE,   "Accident unrelated to class or occupation"),
					new TableRow(6, 7,                  "Natural causes, such as disease or old age"),
					new TableRow(8, TableRow.NOVALUE,   "Apparent suicide"),
					new TableRow(9, TableRow.NOVALUE,   "Torn apart by an animal or a natural disaster"),
					new TableRow(10, TableRow.NOVALUE,  "Consumed by a monster"),
					new TableRow(11, TableRow.NOVALUE,  "Executed for a crime or tortured to death"),
					new TableRow(12, TableRow.NOVALUE,  "Bizarre event, such as being hit by a meteorite, struck down by an angry god, or killed by a hatching slaad egg"),
				});

				public static readonly Table class_table = new Table("Class", "Class", Data.Rolls_String.d100, "", Data.Titles.XGE, 72, new TableRow[]
				{
					new TableRow(1, 7, "Barbarian"),
					new TableRow(8, 14, "Bard"),
					new TableRow(15, 29, "Cleric"),
					new TableRow(30, 36, "Druid"),
					new TableRow(37, 52, "Fighter"),
					new TableRow(53, 58, "Monk"),
					new TableRow(59, 64, "Paladin"),
					new TableRow(65, 70, "Ranger"),
					new TableRow(71, 84, "Rogue"),
					new TableRow(85, 89, "Sorcerer"),
					new TableRow(90, 94, "Warlock"),
					new TableRow(95, 100, "Wizard"),
				});

				public static readonly Table occupation = new Table("Occupation", "Occupation", Data.Rolls_String.d100, "", Data.Titles.XGE, 72, new TableRow[]
				{
					new TableRow(1, 5,                  "Academic"),
					new TableRow(6, 10,                 "Adventurer (roll on the Class table)"),
					new TableRow(11, TableRow.NOVALUE,  "Aristocrat"),
					new TableRow(12, 26,                "Artisan or guild member"),
					new TableRow(27, 31,                "Criminal"),
					new TableRow(32, 36,                "Entertainer"),
					new TableRow(37, 38,                "Exile, hermit, or refugee"),
					new TableRow(39, 43,                "Explorer or wanderer"),
					new TableRow(44, 55,                "Farmer or herder"),
					new TableRow(56, 60,                "Hunter or trapper"),
					new TableRow(61, 75,                "Laborer"),
					new TableRow(76, 80,                "Merchant"),
					new TableRow(81, 85,                "Politician or bureaucrat"),
					new TableRow(86, 90,                "Priest"),
					new TableRow(91, 95,                "Sailor"),
					new TableRow(96, 100,               "Soldier"),
				});

				public static readonly Table race = new Table("Race", "Race", Data.Rolls_String.d100, "", Data.Titles.XGE, 73, new TableRow[]
				{
					new TableRow(1, 40,                 "Human"),
					new TableRow(41, 50,                "Dwarf"),
					new TableRow(51, 60,                "Elf"),
					new TableRow(61, 70,                "Halfling"),
					new TableRow(71, 75,                "Dragonborn"),
					new TableRow(76, 80,                "Gnome"),
					new TableRow(81, 85,                "Half-elf"),
					new TableRow(86, 90,                "Half-orc"),
					new TableRow(91, 95,                "Tiefling"),
					new TableRow(96, 100,               "DM's choice"),
				});

				public static readonly Table relationship = new Table("Relationship", "Relationship", Data.Rolls_String.d4x3, "", Data.Titles.XGE, 73, new TableRow[]
				{
					new TableRow(3, 4,                  "Hostile"),
					new TableRow(5, 10,                 "Friendly"),
					new TableRow(11, 12,                "Indifferent"),
				});

				public static readonly Table status = new Table("Status", "Status", Data.Rolls_String.d6x3, "", Data.Titles.XGE, 73, new TableRow[]
				{
					new TableRow(3, TableRow.NOVALUE,   "Dead (roll on the Cause of Death table)"),
					new TableRow(4, 5,                  "Missing or unknown"),
					new TableRow(6, 8,                  "Alive, but doing poorly due to injury, financial trouble, or relationship difficulties"),
					new TableRow(9, 12,                 "Alive and well"),
					new TableRow(13, 15,                "Alive and quite successful"),
					new TableRow(16, 17,                "Alive and infamous"),
					new TableRow(18, TableRow.NOVALUE,  "Alive and famous"),
				});
			}

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

				return Origins.childhood_memories[num];
			}
		}

		// Appendix B: Character Names
		public static class CharacterNames
		{
			public static class NonhumanNames
			{
				public static readonly Table dragonborn_female_names = new Table("Female Dragonborn Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 175, new TableRow[]
				{
					new TableRow(1, 2,    "Akra"),
					new TableRow(3, 4,    "Aasathra"),
					new TableRow(5, 6,    "Antrara"),
					new TableRow(7, 8,    "Arava"),
					new TableRow(9, 10,   "Biri"),
					new TableRow(11, 12,  "Blendaeth"),
					new TableRow(13, 14,  "Burana"),
					new TableRow(15, 16,  "Chassath"),
					new TableRow(17, 18,  "Daar"),
					new TableRow(19, 20,  "Dentratha"),
					new TableRow(21, 22,  "Doudra"),
					new TableRow(23, 24,  "Driindar"),
					new TableRow(25, 26,  "Eggren"),
					new TableRow(27, 28,  "Farideh"),
					new TableRow(29, 30,  "Findex"),
					new TableRow(31, 32,  "Furrele"),
					new TableRow(33, 34,  "Gesrethe"),
					new TableRow(35, 36,  "Gilkass"),
					new TableRow(37, 38,  "Harann"),
					new TableRow(39, 40,  "Havilar"),
					new TableRow(41, 42,  "Hethress"),
					new TableRow(43, 44,  "Hillanot"),
					new TableRow(45, 46,  "Jaxi"),
					new TableRow(47, 48,  "Jezean"),
					new TableRow(49, 50,  "Jheri"),
					new TableRow(51, 52,  "Kadana"),
					new TableRow(53, 54,  "Kava"),
					new TableRow(55, 56,  "Korinn"),
					new TableRow(57, 58,  "Megren"),
					new TableRow(59, 60,  "Mijira"),
					new TableRow(61, 62,  "Mishann"),
					new TableRow(63, 64,  "Nala"),
					new TableRow(65, 66,  "Nuthra"),
					new TableRow(67, 68,  "Perra"),
					new TableRow(69, 70,  "Pogranix"),
					new TableRow(71, 72,  "Pyxrin"),
					new TableRow(73, 74,  "Quespa"),
					new TableRow(75, 76,  "Raiann"),
					new TableRow(77, 78,  "Rezena"),
					new TableRow(79, 80,  "Ruloth"),
					new TableRow(81, 82,  "Saphara"),
					new TableRow(83, 84,  "Savaran"),
					new TableRow(85, 86,  "Sora"),
					new TableRow(87, 88,  "Surina"),
					new TableRow(89, 90,  "Synthrin"),
					new TableRow(91, 92,  "Tatyan"),
					new TableRow(93, 94,  "Thava"),
					new TableRow(95, 96,  "Uadjit"),
					new TableRow(97, 98,  "Vezera"),
					new TableRow(99, 100, "Zykroff"),
				});

				public static readonly Table dragonborn_male_names = new Table("Male Dragonborn Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 175, new TableRow[]
				{
					new TableRow(1, 2,    "Adrex"),
					new TableRow(3, 4,    "Arjhan"),
					new TableRow(5, 6,    "Azzakh"),
					new TableRow(7, 8,    "Balasar"),
					new TableRow(9, 10,   "Baradad"),
					new TableRow(11, 12,  "Bharash"),
					new TableRow(13, 14,  "Bidreked"),
					new TableRow(15, 16,  "Dadalan"),
					new TableRow(17, 18,  "Dazzazn"),
					new TableRow(19, 20,  "Direcris"),
					new TableRow(21, 22,  "Donaar"),
					new TableRow(23, 24,  "Fax"),
					new TableRow(25, 26,  "Gargax"),
					new TableRow(27, 28,  "Ghesh"),
					new TableRow(29, 30,  "Gorbundus"),
					new TableRow(31, 32,  "Greethen"),
					new TableRow(33, 34,  "Heskan"),
					new TableRow(35, 36,  "Hirrathak"),
					new TableRow(37, 38,  "Ildrex"),
					new TableRow(39, 40,  "Kaladan"),
					new TableRow(41, 42,  "Kerkad"),
					new TableRow(43, 44,  "Kiirith"),
					new TableRow(45, 46,  "Kriv"),
					new TableRow(47, 48,  "Maagog"),
					new TableRow(49, 50,  "Medrash"),
					new TableRow(51, 52,  "Mehen"),
					new TableRow(53, 54,  "Mozikth"),
					new TableRow(55, 56,  "Mreksh"),
					new TableRow(57, 58,  "Mugrunden"),
					new TableRow(59, 60,  "Nadarr"),
					new TableRow(61, 62,  "Nithther"),
					new TableRow(63, 64,  "Norkruuth"),
					new TableRow(65, 66,  "Nykkan"),
					new TableRow(67, 68,  "Pandjed"),
					new TableRow(69, 70,  "Patrin"),
					new TableRow(71, 72,  "Pijjirik"),
					new TableRow(73, 74,  "Quarethon"),
					new TableRow(75, 76,  "Rathkran"),
					new TableRow(77, 78,  "Rhogar"),
					new TableRow(79, 80,  "Rivaan"),
					new TableRow(81, 82,  "Sethrekar"),
					new TableRow(83, 84,  "Sharnash"),
					new TableRow(85, 86,  "Shedinn"),
					new TableRow(87, 88,  "Srorthen"),
					new TableRow(89, 90,  "Tarhun"),
					new TableRow(91, 92,  "Torinn"),
					new TableRow(93, 94,  "Trynnicus"),
					new TableRow(95, 96,  "Valorean"),
					new TableRow(97, 98,  "Vrondiss"),
					new TableRow(99, 100, "Zedaar"),
				});

				public static readonly Table dragonborn_clan_names = new Table("Dragonborn Clan Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 175, new TableRow[]
				{
					new TableRow(1, 2,    "Akambherylliax"),
					new TableRow(3, 4,    "Argenthrixus"),
					new TableRow(5, 6,    "Baharoosh"),
					new TableRow(7, 8,    "Beryntolthropal"),
					new TableRow(9, 10,   "Bhenkumbyrznaax"),
					new TableRow(11, 12,  "Caavylteradyn"),
					new TableRow(13, 14,  "Chumbxirinnish"),
					new TableRow(15, 16,  "Clethtinthiallor"),
					new TableRow(17, 18,  "Daardendrian"),
					new TableRow(19, 20,  "Delmirev"),
					new TableRow(21, 22,  "Dhyrktelonis"),
					new TableRow(23, 24,  "Ebynichtomonis"),
					new TableRow(25, 26,  "Esstyrlynn"),
					new TableRow(27, 28,  "Fharngnarthnost"),
					new TableRow(29, 30,  "Ghaallixirn"),
					new TableRow(31, 32,  "Grrrmmballhyst"),
					new TableRow(33, 34,  "Gygazzylyshrift"),
					new TableRow(35, 36,  "Hashpronyxadyn"),
					new TableRow(37, 38,  "Hshhsstoroth"),
					new TableRow(39, 40,  "Imbixtellrhyst"),
					new TableRow(41, 42,  "Jerynomonis"),
					new TableRow(43, 44,  "Jharthraxyn"),
					new TableRow(45, 46,  "Kerrhylon"),
					new TableRow(47, 48,  "Kimbatuul"),
					new TableRow(49, 50,  "Lhamboldennish"),
					new TableRow(51, 52,  "Linxakasendalor"),
					new TableRow(53, 54,  "Mohradyllion"),
					new TableRow(55, 56,  "Mystan"),
					new TableRow(57, 58,  "Nemmonis"),
					new TableRow(59, 60,  "Norixius"),
					new TableRow(61, 62,  "Ophinshtalajiir"),
					new TableRow(63, 64,  "Orexijandilin"),
					new TableRow(65, 66,  "Pfaphnyrennish"),
					new TableRow(67, 68,  "Phrahdrandon"),
					new TableRow(69, 70,  "Pyraxtallinost"),
					new TableRow(71, 72,  "Qyxpahrgh"),
					new TableRow(73, 74,  "Raghthroknaar"),
					new TableRow(75, 76,  "Shestendeliath"),
					new TableRow(77, 78,  "Skaarzborroosh"),
					new TableRow(79, 80,  "Sumnarghthrysh"),
					new TableRow(81, 82,  "Tiammanthyllish"),
					new TableRow(83, 84,  "Turnuroth"),
					new TableRow(85, 86,  "Umbyphrael"),
					new TableRow(87, 88,  "Vangdondalor"),
					new TableRow(89, 90,  "Verthisathurgiesh"),
					new TableRow(91, 92,  "Wivvyrholdalphiax"),
					new TableRow(93, 94,  "Wystongjiir"),
					new TableRow(95, 96,  "Xephyrbahnor"),
					new TableRow(97, 98,  "Yarjerit"),
					new TableRow(99, 100, "Zzzxaaxthroth"),
				});

				public static readonly Table dwarf_female_names = new Table("Female Dwarf Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 176, new TableRow[]
				{
					new TableRow(1, 2,    "Anbera"),
					new TableRow(3, 4,    "Artin"),
					new TableRow(5, 6,    "Audhild"),
					new TableRow(7, 8,    "Balifra"),
					new TableRow(9, 10,   "Barbena"),
					new TableRow(11, 12,  "Bardryn"),
					new TableRow(13, 14,  "Bolhild"),
					new TableRow(15, 16,  "Dagnal"),
					new TableRow(17, 18,  "Dariff"),
					new TableRow(19, 20,  "Delre"),
					new TableRow(21, 22,  "Diesa"),
					new TableRow(23, 24,  "Eldeth"),
					new TableRow(25, 26,  "Eridred"),
					new TableRow(27, 28,  "Falkrunn"),
					new TableRow(29, 30,  "Fallthra"),
					new TableRow(31, 32,  "Finellen"),
					new TableRow(33, 34,  "Gillydd"),
					new TableRow(35, 36,  "Gunnloda"),
					new TableRow(37, 38,  "Gurdis"),
					new TableRow(39, 40,  "Helgret"),
					new TableRow(41, 42,  "Helja"),
					new TableRow(43, 44,  "Hlin"),
					new TableRow(45, 46,  "Ilde"),
					new TableRow(47, 48,  "Jarana"),
					new TableRow(49, 50,  "Kathra"),
					new TableRow(51, 52,  "Kilia"),
					new TableRow(53, 54,  "Kristryd"),
					new TableRow(55, 56,  "Liftrasa"),
					new TableRow(57, 58,  "Marastyr"),
					new TableRow(59, 60,  "Mardred"),
					new TableRow(61, 62,  "Morana"),
					new TableRow(63, 64,  "Nalaed"),
					new TableRow(65, 66,  "Nora"),
					new TableRow(67, 68,  "Nurkara"),
					new TableRow(69, 70,  "Oriff"),
					new TableRow(71, 72,  "Ovina"),
					new TableRow(73, 74,  "Riswynn"),
					new TableRow(75, 76,  "Sannl"),
					new TableRow(77, 78,  "Therlin"),
					new TableRow(79, 80,  "Thodris"),
					new TableRow(81, 82,  "Torbera"),
					new TableRow(83, 84,  "Tordrid"),
					new TableRow(85, 86,  "Torgga"),
					new TableRow(87, 88,  "Urshar"),
					new TableRow(89, 90,  "Valida"),
					new TableRow(91, 92,  "Vistra"),
					new TableRow(93, 94,  "Vonana"),
					new TableRow(95, 96,  "Werydd"),
					new TableRow(97, 98,  "Whurdred"),
					new TableRow(99, 100, "Yurgunn"),
				});

				public static readonly Table dwarf_male_names = new Table("Male Dwarf Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 176, new TableRow[]
				{
					new TableRow(1, 2,    "Adrik"),
					new TableRow(3, 4,    "Alberich"),
					new TableRow(5, 6,    "Baern"),
					new TableRow(7, 8,    "Barendd"),
					new TableRow(9, 10,   "Beloril"),
					new TableRow(11, 12,  "Brottor"),
					new TableRow(13, 14,  "Dain"),
					new TableRow(15, 16,  "Dalgal"),
					new TableRow(17, 18,  "Darrak"),
					new TableRow(19, 20,  "Delg"),
					new TableRow(21, 22,  "Duergath"),
					new TableRow(23, 24,  "Dworic"),
					new TableRow(25, 26,  "Eberk"),
					new TableRow(27, 28,  "Einkil"),
					new TableRow(29, 30,  "Elaim"),
					new TableRow(31, 32,  "Erias"),
					new TableRow(33, 34,  "Fallond"),
					new TableRow(35, 36,  "Fargrim"),
					new TableRow(37, 38,  "Gardain"),
					new TableRow(39, 40,  "Gilthur"),
					new TableRow(41, 42,  "Gimgen"),
					new TableRow(43, 44,  "Gimurt"),
					new TableRow(45, 46,  "Harbek"),
					new TableRow(47, 48,  "Kildrak"),
					new TableRow(49, 50,  "Kilvar"),
					new TableRow(51, 52,  "Morgran"),
					new TableRow(53, 54,  "Morkral"),
					new TableRow(55, 56,  "Nalral"),
					new TableRow(57, 58,  "Nordak"),
					new TableRow(59, 60,  "Nuraval"),
					new TableRow(61, 62,  "Oloric"),
					new TableRow(63, 64,  "Olunt"),
					new TableRow(65, 66,  "Orsik"),
					new TableRow(67, 68,  "Oskar"),
					new TableRow(69, 70,  "Rangrim"),
					new TableRow(71, 72,  "Reirak"),
					new TableRow(73, 74,  "Rurik"),
					new TableRow(75, 76,  "Taklinn"),
					new TableRow(77, 78,  "Thoradin"),
					new TableRow(79, 80,  "Thorin"),
					new TableRow(81, 82,  "Thradal"),
					new TableRow(83, 84,  "Tordek"),
					new TableRow(85, 86,  "Traubon"),
					new TableRow(87, 88,  "Travok"),
					new TableRow(89, 90,  "Ulfgar"),
					new TableRow(91, 92,  "Uraim"),
					new TableRow(93, 94,  "Veit"),
					new TableRow(95, 96,  "Vonbin"),
					new TableRow(97, 98,  "Vondal"),
					new TableRow(99, 100, "Whurbin"),
				});

				public static readonly Table dwarf_clan_names = new Table("Dwarf Clan Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 176, new TableRow[]
				{
					new TableRow(1, 2,    "Aranore"),
					new TableRow(3, 4,    "Balderk"),
					new TableRow(5, 6,    "Battlehammer"),
					new TableRow(7, 8,    "Bigtoe"),
					new TableRow(9, 10,   "Bloodkith"),
					new TableRow(11, 12,  "Bofdann"),
					new TableRow(13, 14,  "Brawnanvil"),
					new TableRow(15, 16,  "Brazzik"),
					new TableRow(17, 18,  "Broodfist"),
					new TableRow(19, 20,  "Burrowfound"),
					new TableRow(21, 22,  "Caebrek"),
					new TableRow(23, 24,  "Daerdahk"),
					new TableRow(25, 26,  "Dankil"),
					new TableRow(27, 28,  "Darain"),
					new TableRow(29, 30,  "Deepdelver"),
					new TableRow(31, 32,  "Durthane"),
					new TableRow(33, 34,  "Eversharp"),
					new TableRow(35, 36,  "Fallack"),
					new TableRow(37, 38,  "Fireforge"),
					new TableRow(39, 40,  "Foamtankard"),
					new TableRow(41, 42,  "Frostbeard"),
					new TableRow(43, 44,  "Glanhig"),
					new TableRow(45, 46,  "Goblinbane"),
					new TableRow(47, 48,  "Goldfinder"),
					new TableRow(49, 50,  "Gorunn"),
					new TableRow(51, 52,  "Graybeard"),
					new TableRow(53, 54,  "Hammerstone"),
					new TableRow(55, 56,  "Helcral"),
					new TableRow(57, 58,  "Holderhek"),
					new TableRow(59, 60,  "Ironfist"),
					new TableRow(61, 62,  "Loderr"),
					new TableRow(63, 64,  "Lutgehr"),
					new TableRow(65, 66,  "Morigak"),
					new TableRow(67, 68,  "Orcfoe"),
					new TableRow(69, 70,  "Rakankrak"),
					new TableRow(71, 72,  "Ruby-Eye"),
					new TableRow(73, 74,  "Rumnaheim"),
					new TableRow(75, 76,  "Silveraxe"),
					new TableRow(77, 78,  "Silverstone"),
					new TableRow(79, 80,  "Steelfist"),
					new TableRow(81, 82,  "Stoutale"),
					new TableRow(83, 84,  "Strakeln"),
					new TableRow(85, 86,  "Strongheart"),
					new TableRow(87, 88,  "Thrahak"),
					new TableRow(89, 90,  "Torevir"),
					new TableRow(91, 92,  "Torunn"),
					new TableRow(93, 94,  "Trollbleeder"),
					new TableRow(95, 96,  "Trueanvil"),
					new TableRow(97, 98,  "Trueblood"),
					new TableRow(99, 100, "Ungart"),
				});

				public static readonly Table elf_child_names = new Table("Elf Child Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 176, new TableRow[]
				{
					new TableRow(1, 2,    "Ael"),
					new TableRow(3, 4,    "Ang"),
					new TableRow(5, 6,    "Ara"),
					new TableRow(7, 8,    "Ari"),
					new TableRow(9, 10,   "Arn"),
					new TableRow(11, 12,  "Aym"),
					new TableRow(13, 14,  "Broe"),
					new TableRow(15, 16,  "Bryn"),
					new TableRow(17, 18,  "Cael"),
					new TableRow(19, 20,  "Cy"),
					new TableRow(21, 22,  "Dae"),
					new TableRow(23, 24,  "Del"),
					new TableRow(25, 26,  "Eli"),
					new TableRow(27, 28,  "Eryn"),
					new TableRow(29, 30,  "Faen"),
					new TableRow(31, 32,  "Fera"),
					new TableRow(33, 34,  "Gaci"),
					new TableRow(35, 36,  "Gar"),
					new TableRow(37, 38,  "Innil"),
					new TableRow(39, 40,  "Jar"),
					new TableRow(41, 42,  "Kan"),
					new TableRow(43, 44,  "Koeth"),
					new TableRow(45, 46,  "Lael"),
					new TableRow(47, 48,  "Lue"),
					new TableRow(49, 50,  "Mai"),
					new TableRow(51, 52,  "Mara"),
					new TableRow(53, 54,  "Mella"),
					new TableRow(55, 56,  "Mya"),
					new TableRow(57, 58,  "Naeris"),
					new TableRow(59, 60,  "Naill"),
					new TableRow(61, 62,  "Nim"),
					new TableRow(63, 64,  "Phann"),
					new TableRow(65, 66,  "Py"),
					new TableRow(67, 68,  "Rael"),
					new TableRow(69, 70,  "Raer"),
					new TableRow(71, 72,  "Ren"),
					new TableRow(73, 74,  "Rinn"),
					new TableRow(75, 76,  "Rua"),
					new TableRow(77, 78,  "Sael"),
					new TableRow(79, 80,  "Sai"),
					new TableRow(81, 82,  "Sumi"),
					new TableRow(83, 84,  "Syllin"),
					new TableRow(85, 86,  "Ta"),
					new TableRow(87, 88,  "Thia"),
					new TableRow(89, 90,  "Tia"),
					new TableRow(91, 92,  "Traki"),
					new TableRow(93, 94,  "Vall"),
					new TableRow(95, 96,  "Von"),
					new TableRow(97, 98,  "Wil"),
					new TableRow(99, 100, "Za"),
				});

				public static readonly Table elf_female_adult_names = new Table("Female Elf Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 177, new TableRow[]
				{
					new TableRow(1, 2,    "Adrie"),
					new TableRow(3, 4,    "Ahinar"),
					new TableRow(5, 6,    "Althaea"),
					new TableRow(7, 8,    "Anastrianna"),
					new TableRow(9, 10,   "Andraste"),
					new TableRow(11, 12,  "Antinua"),
					new TableRow(13, 14,  "Arara"),
					new TableRow(15, 16,  "Baelitae"),
					new TableRow(17, 18,  "Bethrynna"),
					new TableRow(19, 20,  "Birel"),
					new TableRow(21, 22,  "Caelynn"),
					new TableRow(23, 24,  "Chaedi"),
					new TableRow(25, 26,  "Claira"),
					new TableRow(27, 28,  "Dara"),
					new TableRow(29, 30,  "Drusilia"),
					new TableRow(31, 32,  "Elama"),
					new TableRow(33, 34,  "Enna"),
					new TableRow(35, 36,  "Faral"),
					new TableRow(37, 38,  "Felosial"),
					new TableRow(39, 40,  "Hatae"),
					new TableRow(41, 42,  "Ielenia"),
					new TableRow(43, 44,  "Ilanis"),
					new TableRow(45, 46,  "Irann"),
					new TableRow(47, 48,  "Jarsali"),
					new TableRow(49, 50,  "Jelenneth"),
					new TableRow(51, 52,  "Keyleth"),
					new TableRow(53, 54,  "Leshanna"),
					new TableRow(55, 56,  "Lia"),
					new TableRow(57, 58,  "Maiathah"),
					new TableRow(59, 60,  "Malquis"),
					new TableRow(61, 62,  "Meriele"),
					new TableRow(63, 64,  "Mialee"),
					new TableRow(65, 66,  "Myathethil"),
					new TableRow(67, 68,  "Naivara"),
					new TableRow(69, 70,  "Quelenna"),
					new TableRow(71, 72,  "Quillathe"),
					new TableRow(73, 74,  "Ridaro"),
					new TableRow(75, 76,  "Sariel"),
					new TableRow(77, 78,  "Shanairla"),
					new TableRow(79, 80,  "Shava"),
					new TableRow(81, 82,  "Silaqui"),
					new TableRow(83, 84,  "Sumnes"),
					new TableRow(85, 86,  "Theirastra"),
					new TableRow(87, 88,  "Thiala"),
					new TableRow(89, 90,  "Tiaathque"),
					new TableRow(91, 92,  "Traulam"),
					new TableRow(93, 94,  "Vadania"),
					new TableRow(95, 96,  "Valanthe"),
					new TableRow(97, 98,  "Valna"),
					new TableRow(99, 100, "Xanaphia"),
				});

				public static readonly Table elf_male_adult_names = new Table("Male Elf Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 177, new TableRow[]
				{
					new TableRow(1, 2,    "Adran"),
					new TableRow(3, 4,    "Aelar"),
					new TableRow(5, 6,    "Aerdeth"),
					new TableRow(7, 8,    "Ahvain"),
					new TableRow(9, 10,   "Aramil"),
					new TableRow(11, 12,  "Arannis"),
					new TableRow(13, 14,  "Aust"),
					new TableRow(15, 16,  "Azaki"),
					new TableRow(17, 18,  "Beiro"),
					new TableRow(19, 20,  "Berrian"),
					new TableRow(21, 22,  "Caeldrim"),
					new TableRow(23, 24,  "Carric"),
					new TableRow(25, 26,  "Dayereth"),
					new TableRow(27, 28,  "Dreali"),
					new TableRow(29, 30,  "Efferil"),
					new TableRow(31, 32,  "Eiravel"),
					new TableRow(33, 34,  "Enialis"),
					new TableRow(35, 36,  "Erdan"),
					new TableRow(37, 38,  "Erevan"),
					new TableRow(39, 40,  "Fivin"),
					new TableRow(41, 42,  "Galinndan"),
					new TableRow(43, 44,  "Gennal"),
					new TableRow(45, 46,  "Hadarai"),
					new TableRow(47, 48,  "Halimath"),
					new TableRow(49, 50,  "Heian"),
					new TableRow(51, 52,  "Himo"),
					new TableRow(53, 54,  "Immeral"),
					new TableRow(55, 56,  "Ivellios"),
					new TableRow(57, 58,  "Korfel"),
					new TableRow(59, 60,  "Lamlis"),
					new TableRow(61, 62,  "Laucian"),
					new TableRow(63, 64,  "Lucan"),
					new TableRow(65, 66,  "Mindartis"),
					new TableRow(67, 68,  "Naal"),
					new TableRow(69, 70,  "Nutae"),
					new TableRow(71, 72,  "Paelias"),
					new TableRow(73, 74,  "Peren"),
					new TableRow(75, 76,  "Quarion"),
					new TableRow(77, 78,  "Riardon"),
					new TableRow(79, 80,  "Rolen"),
					new TableRow(81, 82,  "Soveliss"),
					new TableRow(83, 84,  "Suhnae"),
					new TableRow(85, 86,  "Thamior"),
					new TableRow(87, 88,  "Tharivol"),
					new TableRow(89, 90,  "Theren"),
					new TableRow(91, 92,  "Theriatis"),
					new TableRow(93, 94,  "Thervan"),
					new TableRow(95, 96,  "Uthemar"),
					new TableRow(97, 98,  "Vanuath"),
					new TableRow(99, 100, "Varis"),
				});

				public static readonly Table elf_family_names = new Table("Elf Family Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 177, new TableRow[]
				{
					new TableRow(1, 2,    "Aloro"),
					new TableRow(3, 4,    "Amakiir"),
					new TableRow(5, 6,    "Amastacia"),
					new TableRow(7, 8,    "Ariessus"),
					new TableRow(9, 10,   "Arnuanna"),
					new TableRow(11, 12,  "Berevan"),
					new TableRow(13, 14,  "Caerdonel"),
					new TableRow(15, 16,  "Caphaxath"),
					new TableRow(17, 18,  "Casilltenirra"),
					new TableRow(19, 20,  "Cithreth"),
					new TableRow(21, 22,  "Dalanthan"),
					new TableRow(23, 24,  "Aethalena"),
					new TableRow(25, 26,  "Erenaeth"),
					new TableRow(27, 28,  "Ethanasath"),
					new TableRow(29, 30,  "Fasharash"),
					new TableRow(31, 32,  "Firahel"),
					new TableRow(33, 34,  "Floshem"),
					new TableRow(35, 36,  "Galanodel"),
					new TableRow(37, 38,  "Goltorah"),
					new TableRow(39, 40,  "Hanali"),
					new TableRow(41, 42,  "Holimion"),
					new TableRow(43, 44,  "Horineth"),
					new TableRow(45, 46,  "Iathrana"),
					new TableRow(47, 48,  "Ilphelkiir"),
					new TableRow(49, 50,  "Iranapha"),
					new TableRow(51, 52,  "Koehlanna"),
					new TableRow(53, 54,  "Lathalas"),
					new TableRow(55, 56,  "Liadon"),
					new TableRow(57, 58,  "Meliamme"),
					new TableRow(59, 60,  "Mellerelel"),
					new TableRow(61, 62,  "Mystralath"),
					new TableRow(63, 64,  "Nailo"),
					new TableRow(65, 66,  "Netyoive"),
					new TableRow(67, 68,  "Ofandrus"),
					new TableRow(69, 70,  "Ostoroth"),
					new TableRow(71, 72,  "Othronus"),
					new TableRow(73, 74,  "Qualanthri"),
					new TableRow(75, 76,  "Raethran"),
					new TableRow(77, 78,  "Rothenel"),
					new TableRow(79, 80,  "Selevarun"),
					new TableRow(81, 82,  "Siannodel"),
					new TableRow(83, 84,  "Suithrasas"),
					new TableRow(85, 86,  "Sylvaranth"),
					new TableRow(87, 88,  "Teinithra"),
					new TableRow(89, 90,  "Tiltathana"),
					new TableRow(91, 92,  "Wasanthi"),
					new TableRow(93, 94,  "Withrethin"),
					new TableRow(95, 96,  "Xiloscient"),
					new TableRow(97, 98,  "Xistsrith"),
					new TableRow(99, 100, "Yaeldrin"),
				});

				public static readonly Table gnome_female_names = new Table("Female Gnome Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 178, new TableRow[]
				{
					new TableRow(1, 2,    "Abalaba"),
					new TableRow(3, 4,    "Bimpnottin"),
					new TableRow(5, 6,    "Breena"),
					new TableRow(7, 8,    "Buvvie"),
					new TableRow(9, 10,   "Callybon"),
					new TableRow(11, 12,  "Caramip"),
					new TableRow(13, 14,  "Carlin"),
					new TableRow(15, 16,  "Cumpen"),
					new TableRow(17, 18,  "Dalaba"),
					new TableRow(19, 20,  "Donella"),
					new TableRow(21, 22,  "Duvamil"),
					new TableRow(23, 24,  "Ella"),
					new TableRow(25, 26,  "Ellyjoybell"),
					new TableRow(27, 28,  "Ellywick"),
					new TableRow(29, 30,  "Enidda"),
					new TableRow(31, 32,  "Lilli"),
					new TableRow(33, 34,  "Loopmottin"),
					new TableRow(35, 36,  "Lorilla"),
					new TableRow(37, 38,  "Luthra"),
					new TableRow(39, 40,  "Mardnab"),
					new TableRow(41, 42,  "Meena"),
					new TableRow(43, 44,  "Menny"),
					new TableRow(45, 46,  "Mumpena"),
					new TableRow(47, 48,  "Nissa"),
					new TableRow(49, 50,  "Numba"),
					new TableRow(51, 52,  "Nyx"),
					new TableRow(53, 54,  "Oda"),
					new TableRow(55, 56,  "Oppah"),
					new TableRow(57, 58,  "Orla"),
					new TableRow(59, 60,  "Panana"),
					new TableRow(61, 62,  "Pyntle"),
					new TableRow(63, 64,  "Quilla"),
					new TableRow(65, 66,  "Ranala"),
					new TableRow(67, 68,  "Reddlepop"),
					new TableRow(69, 70,  "Roywyn"),
					new TableRow(71, 72,  "Salanop"),
					new TableRow(73, 74,  "Shamil"),
					new TableRow(75, 76,  "Siffress"),
					new TableRow(77, 78,  "Symma"),
					new TableRow(79, 80,  "Tana"),
					new TableRow(81, 82,  "Tenena"),
					new TableRow(83, 84,  "Tervaround"),
					new TableRow(85, 86,  "Tippletoe"),
					new TableRow(87, 88,  "Ulla"),
					new TableRow(89, 90,  "Unvera"),
					new TableRow(91, 92,  "Veloptima"),
					new TableRow(93, 94,  "Virra"),
					new TableRow(95, 96,  "Waywocket"),
					new TableRow(97, 98,  "Yebe"),
					new TableRow(99, 100, "Zanna"),
				});

				public static readonly Table gnome_male_names = new Table("Male Gnome Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 178, new TableRow[]
				{
					new TableRow(1, 2,    "Alston"),
					new TableRow(3, 4,    "Alvyn"),
					new TableRow(5, 6,    "Anverth"),
					new TableRow(7, 8,    "Arumawann"),
					new TableRow(9, 10,   "Bilbron"),
					new TableRow(11, 12,  "Boddynock"),
					new TableRow(13, 14,  "Brocc"),
					new TableRow(15, 16,  "Burgell"),
					new TableRow(17, 18,  "Cockaby"),
					new TableRow(19, 20,  "Crampernap"),
					new TableRow(21, 22,  "Dabbledob"),
					new TableRow(23, 24,  "Delebean"),
					new TableRow(25, 26,  "Dimble"),
					new TableRow(27, 28,  "Eberdeb"),
					new TableRow(29, 30,  "Eldon"),
					new TableRow(31, 32,  "Erky"),
					new TableRow(33, 34,  "Fablen"),
					new TableRow(35, 36,  "Fibblestib"),
					new TableRow(37, 38,  "Fonkin"),
					new TableRow(39, 40,  "Frouse"),
					new TableRow(41, 42,  "Frug"),
					new TableRow(43, 44,  "Gerbo"),
					new TableRow(45, 46,  "Gimble"),
					new TableRow(47, 48,  "Glim"),
					new TableRow(49, 50,  "Igden"),
					new TableRow(51, 52,  "Jabble"),
					new TableRow(53, 54,  "Jebeddo"),
					new TableRow(55, 56,  "Kellen"),
					new TableRow(57, 58,  "Kipper"),
					new TableRow(59, 60,  "Namfoodle"),
					new TableRow(61, 62,  "Oppleby"),
					new TableRow(63, 64,  "Orryn"),
					new TableRow(65, 66,  "Paggen"),
					new TableRow(67, 68,  "Pallabar"),
					new TableRow(69, 70,  "Pog"),
					new TableRow(71, 72,  "Qualen"),
					new TableRow(73, 74,  "Ribbles"),
					new TableRow(75, 76,  "Rimple"),
					new TableRow(77, 78,  "Roondar"),
					new TableRow(79, 80,  "Sapply"),
					new TableRow(81, 82,  "Seebo"),
					new TableRow(83, 84,  "Senteq"),
					new TableRow(85, 86,  "Sindri"),
					new TableRow(87, 88,  "Umpen"),
					new TableRow(89, 90,  "Warryn"),
					new TableRow(91, 92,  "Wiggens"),
					new TableRow(93, 94,  "Wobbles"),
					new TableRow(95, 96,  "Wrenn"),
					new TableRow(97, 98,  "Zaffrab"),
					new TableRow(99, 100, "Zook"),
				});

				public static readonly Table gnome_clan_names = new Table("Gnome Clan Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 178, new TableRow[]
				{
					new TableRow(1, 2,    "Albaratie"),
					new TableRow(3, 4,    "Bafflestone"),
					new TableRow(5, 6,    "Beren"),
					new TableRow(7, 8,    "Boondiggles"),
					new TableRow(9, 10,   "Cobblelob"),
					new TableRow(11, 12,  "Daergel"),
					new TableRow(13, 14,  "Dunben"),
					new TableRow(15, 16,  "Fabblestabble"),
					new TableRow(17, 18,  "Fapplestamp"),
					new TableRow(19, 20,  "Fiddlefen"),
					new TableRow(21, 22,  "Folkor"),
					new TableRow(23, 24,  "Garrick"),
					new TableRow(25, 26,  "Gimlen"),
					new TableRow(27, 28,  "Glittergem"),
					new TableRow(29, 30,  "Gobblefirn"),
					new TableRow(31, 32,  "Gummen"),
					new TableRow(33, 34,  "Horcusporcus"),
					new TableRow(35, 36,  "Humplebumple"),
					new TableRow(37, 38,  "Ironhide"),
					new TableRow(39, 40,  "Leffery"),
					new TableRow(41, 42,  "Lingenhall"),
					new TableRow(43, 44,  "Loofollue"),
					new TableRow(45, 46,  "Maekkelferce"),
					new TableRow(47, 48,  "Miggledy"),
					new TableRow(49, 50,  "Munggen"),
					new TableRow(51, 52,  "Murnig"),
					new TableRow(53, 54,  "Musgraben"),
					new TableRow(55, 56,  "Nackle"),
					new TableRow(57, 58,  "Ningel"),
					new TableRow(59, 60,  "Nopenstallen"),
					new TableRow(61, 62,  "Nucklestamp"),
					new TableRow(63, 64,  "Offund"),
					new TableRow(65, 66,  "Oomtrowl"),
					new TableRow(67, 68,  "Pilwicken"),
					new TableRow(69, 70,  "Pingun"),
					new TableRow(71, 72,  "Quillsharpener"),
					new TableRow(73, 74,  "Raulnor"),
					new TableRow(75, 76,  "Reese"),
					new TableRow(77, 78,  "Rofferton"),
					new TableRow(79, 80,  "Scheppen"),
					new TableRow(81, 82,  "Shadowcloak"),
					new TableRow(83, 84,  "Silverthread"),
					new TableRow(85, 86,  "Sympony"),
					new TableRow(87, 88,  "Tarkelby"),
					new TableRow(89, 90,  "Timbers"),
					new TableRow(91, 92,  "Turen"),
					new TableRow(93, 94,  "Umbodoben"),
					new TableRow(95, 96,  "Waggletop"),
					new TableRow(97, 98,  "Welber"),
					new TableRow(99, 100, "Wildwander"),
				});

				public static readonly Table halfling_female_names = new Table("Female Halfling Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 179, new TableRow[]
				{
					new TableRow(1, 2,    "Alain"),
					new TableRow(3, 4,    "Andry"),
					new TableRow(5, 6,    "Anne"),
					new TableRow(7, 8,    "Bella"),
					new TableRow(9, 10,   "Blossom"),
					new TableRow(11, 12,  "Bree"),
					new TableRow(13, 14,  "Callie"),
					new TableRow(15, 16,  "Chenna"),
					new TableRow(17, 18,  "Cora"),
					new TableRow(19, 20,  "Dee"),
					new TableRow(21, 22,  "Dell"),
					new TableRow(23, 24,  "Eida"),
					new TableRow(25, 26,  "Eran"),
					new TableRow(27, 28,  "Euphemia"),
					new TableRow(29, 30,  "Georgina"),
					new TableRow(31, 32,  "Gynnie"),
					new TableRow(33, 34,  "Harriet"),
					new TableRow(35, 36,  "Jasmine"),
					new TableRow(37, 38,  "Jillian"),
					new TableRow(39, 40,  "Jo"),
					new TableRow(41, 42,  "Kithri"),
					new TableRow(43, 44,  "Lavinia"),
					new TableRow(45, 46,  "Lidda"),
					new TableRow(47, 48,  "Maegan"),
					new TableRow(49, 50,  "Marigold"),
					new TableRow(51, 52,  "Merla"),
					new TableRow(53, 54,  "Myria"),
					new TableRow(55, 56,  "Nedda"),
					new TableRow(57, 58,  "Nikki"),
					new TableRow(59, 60,  "Nora"),
					new TableRow(61, 62,  "Olivia"),
					new TableRow(63, 64,  "Paela"),
					new TableRow(65, 66,  "Pearl"),
					new TableRow(67, 68,  "Pennie"),
					new TableRow(69, 70,  "Philomena"),
					new TableRow(71, 72,  "Portia"),
					new TableRow(73, 74,  "Robbie"),
					new TableRow(75, 76,  "Rose"),
					new TableRow(77, 78,  "Saral"),
					new TableRow(79, 80,  "Seraphina"),
					new TableRow(81, 82,  "Shaena"),
					new TableRow(83, 84,  "Stacee"),
					new TableRow(85, 86,  "Tawna"),
					new TableRow(87, 88,  "Thea"),
					new TableRow(89, 90,  "Trym"),
					new TableRow(91, 92,  "Tyna"),
					new TableRow(93, 94,  "Vani"),
					new TableRow(95, 96,  "Verna"),
					new TableRow(97, 98,  "Wella"),
					new TableRow(99, 100, "Willow"),
				});

				public static readonly Table halfling_male_names = new Table("Male Halfing Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 179, new TableRow[]
				{
					new TableRow(1, 2,    "Alton"),
					new TableRow(3, 4,    "Ander"),
					new TableRow(5, 6,    "Bernie"),
					new TableRow(7, 8,    "Bobbin"),
					new TableRow(9, 10,   "Cade"),
					new TableRow(11, 12,  "Callus"),
					new TableRow(13, 14,  "Corrin"),
					new TableRow(15, 16,  "Dannad"),
					new TableRow(17, 18,  "Danniel"),
					new TableRow(19, 20,  "Eddie"),
					new TableRow(21, 22,  "Egart"),
					new TableRow(23, 24,  "Eldon"),
					new TableRow(25, 26,  "Errich"),
					new TableRow(27, 28,  "Fildo"),
					new TableRow(29, 30,  "Finnan"),
					new TableRow(31, 32,  "Franklin"),
					new TableRow(33, 34,  "Garret"),
					new TableRow(35, 36,  "Garth"),
					new TableRow(37, 38,  "Gilbert"),
					new TableRow(39, 40,  "Gob"),
					new TableRow(41, 42,  "Harol"),
					new TableRow(43, 44,  "Igor"),
					new TableRow(45, 46,  "Jasper"),
					new TableRow(47, 48,  "Keith"),
					new TableRow(49, 50,  "Kevin"),
					new TableRow(51, 52,  "Lazam"),
					new TableRow(53, 54,  "Lerry"),
					new TableRow(55, 56,  "Lindal"),
					new TableRow(57, 58,  "Lyle"),
					new TableRow(59, 60,  "Merric"),
					new TableRow(61, 62,  "Mican"),
					new TableRow(63, 64,  "Milo"),
					new TableRow(65, 66,  "Morrin"),
					new TableRow(67, 68,  "Nebin"),
					new TableRow(69, 70,  "Nevil"),
					new TableRow(71, 72,  "Osborn"),
					new TableRow(73, 74,  "Ostran"),
					new TableRow(75, 76,  "Oswalt"),
					new TableRow(77, 78,  "Perrin"),
					new TableRow(79, 80,  "Poppy"),
					new TableRow(81, 82,  "Reed"),
					new TableRow(83, 84,  "Roscoe"),
					new TableRow(85, 86,  "Sam"),
					new TableRow(87, 88,  "Shardon"),
					new TableRow(89, 90,  "Tye"),
					new TableRow(91, 92,  "Ulmo"),
					new TableRow(93, 94,  "Wellby"),
					new TableRow(95, 96,  "Wendel"),
					new TableRow(97, 98,  "Wenner"),
					new TableRow(99, 100, "Wes"),
				});

				public static readonly Table halfling_family_names = new Table("Halfling Family Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 179, new TableRow[]
				{
					new TableRow(1, 2,    "Appleblossom"),
					new TableRow(3, 4,    "Bigheart"),
					new TableRow(5, 6,    "Brightmoon"),
					new TableRow(7, 8,    "Brushgather"),
					new TableRow(9, 10,   "Cherrycheeks"),
					new TableRow(11, 12,  "Copperkettle"),
					new TableRow(13, 14,  "Deephollow"),
					new TableRow(15, 16,  "Elderberry"),
					new TableRow(17, 18,  "Fastfoot"),
					new TableRow(19, 20,  "Fatrabbit"),
					new TableRow(21, 22,  "Glenfellow"),
					new TableRow(23, 24,  "Goldfound"),
					new TableRow(25, 26,  "Goodbarrel"),
					new TableRow(27, 28,  "Goodearth"),
					new TableRow(29, 30,  "Greenbottle"),
					new TableRow(31, 32,  "Greenleaf"),
					new TableRow(33, 34,  "High-hill"),
					new TableRow(35, 36,  "Hilltopple"),
					new TableRow(37, 38,  "Hogcollar"),
					new TableRow(39, 40,  "Honeypot"),
					new TableRow(41, 42,  "Jamjar"),
					new TableRow(43, 44,  "Kettlewhistle"),
					new TableRow(45, 46,  "Leagallow"),
					new TableRow(47, 48,  "Littlefoot"),
					new TableRow(49, 50,  "Nimblefingers"),
					new TableRow(51, 52,  "Porridgepot"),
					new TableRow(53, 54,  "Quickstep"),
					new TableRow(55, 56,  "Reedfellow"),
					new TableRow(57, 58,  "Shadowquick"),
					new TableRow(59, 60,  "Silvereyes"),
					new TableRow(61, 62,  "Smoothhands"),
					new TableRow(63, 64,  "Stonebridge"),
					new TableRow(65, 66,  "Stoutbridge"),
					new TableRow(67, 68,  "Stoutman"),
					new TableRow(69, 70,  "Strongbones"),
					new TableRow(71, 72,  "Sunmeadow"),
					new TableRow(73, 74,  "Swiftwhistle"),
					new TableRow(75, 76,  "Tallfellow"),
					new TableRow(77, 78,  "Tealeaf"),
					new TableRow(79, 80,  "Tenpenny"),
					new TableRow(81, 82,  "Thistletop"),
					new TableRow(83, 84,  "Thorngage"),
					new TableRow(85, 86,  "Tosscobble"),
					new TableRow(87, 88,  "Underbough"),
					new TableRow(89, 90,  "Underfoot"),
					new TableRow(91, 92,  "Warmwater"),
					new TableRow(93, 94,  "Whispermouse"),
					new TableRow(95, 96,  "Wildcloak"),
					new TableRow(97, 98,  "Wildheart"),
					new TableRow(99, 100, "Wiseacre"),
				});

				public static readonly Table half_orc_female_names = new Table("Female Half-Orc Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 179, new TableRow[]
				{
					new TableRow(1, 2,    "Arha"),
					new TableRow(3, 4,    "Baggi"),
					new TableRow(5, 6,    "Bendoo"),
					new TableRow(7, 8,    "Bilga"),
					new TableRow(9, 10,   "Brakka"),
					new TableRow(11, 12,  "Creega"),
					new TableRow(13, 14,  "Drenna"),
					new TableRow(15, 16,  "Ekk"),
					new TableRow(17, 18,  "Emen"),
					new TableRow(19, 20,  "Engong"),
					new TableRow(21, 22,  "Fistula"),
					new TableRow(23, 24,  "Gaaki"),
					new TableRow(25, 26,  "Gorga"),
					new TableRow(27, 28,  "Grai"),
					new TableRow(29, 30,  "Greeba"),
					new TableRow(31, 32,  "Grigi"),
					new TableRow(33, 34,  "Gynk"),
					new TableRow(35, 36,  "Hrathy"),
					new TableRow(37, 38,  "Huru"),
					new TableRow(39, 40,  "Ilga"),
					new TableRow(41, 42,  "Kabbarg"),
					new TableRow(43, 44,  "Kansif"),
					new TableRow(45, 46,  "Lagazi"),
					new TableRow(47, 48,  "Lezre"),
					new TableRow(49, 50,  "Murgen"),
					new TableRow(51, 52,  "Murook"),
					new TableRow(53, 54,  "Myev"),
					new TableRow(55, 56,  "Nagrette"),
					new TableRow(57, 58,  "Neega"),
					new TableRow(59, 60,  "Nella"),
					new TableRow(61, 62,  "Nogu"),
					new TableRow(63, 64,  "Oolah"),
					new TableRow(65, 66,  "Ootah"),
					new TableRow(67, 68,  "Ovak"),
					new TableRow(69, 70,  "Ownka"),
					new TableRow(71, 72,  "Puyet"),
					new TableRow(73, 74,  "Reeza"),
					new TableRow(75, 76,  "Shautha"),
					new TableRow(77, 78,  "Silgre"),
					new TableRow(79, 80,  "Sutha"),
					new TableRow(81, 82,  "Tagga"),
					new TableRow(83, 84,  "Tawar"),
					new TableRow(85, 86,  "Tomph"),
					new TableRow(87, 88,  "Ubada"),
					new TableRow(89, 90,  "Vanchu"),
					new TableRow(91, 92,  "Vola"),
					new TableRow(93, 94,  "Volen"),
					new TableRow(95, 96,  "Vorka"),
					new TableRow(97, 98,  "Yevelda"),
					new TableRow(99, 100, "Zagga"),
				});

				public static readonly Table half_orc_male_names = new Table("Male Half-Orc Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 180, new TableRow[]
				{
					new TableRow(1, 2,    "Argran"),
					new TableRow(3, 4,    "Braak"),
					new TableRow(5, 6,    "Brug"),
					new TableRow(7, 8,    "Cagak"),
					new TableRow(9, 10,   "Dench"),
					new TableRow(11, 12,  "Dorn"),
					new TableRow(13, 14,  "Dren"),
					new TableRow(15, 16,  "Druuk"),
					new TableRow(17, 18,  "Feng"),
					new TableRow(19, 20,  "Gell"),
					new TableRow(21, 22,  "Gnarsh"),
					new TableRow(23, 24,  "Grumbar"),
					new TableRow(25, 26,  "Gubrash"),
					new TableRow(27, 28,  "Hagren"),
					new TableRow(29, 30,  "Henk"),
					new TableRow(31, 32,  "Hogar"),
					new TableRow(33, 34,  "Holg"),
					new TableRow(35, 36,  "Imsh"),
					new TableRow(37, 38,  "Karash"),
					new TableRow(39, 40,  "Karg"),
					new TableRow(41, 42,  "Keth"),
					new TableRow(43, 44,  "Korag"),
					new TableRow(45, 46,  "Krusk"),
					new TableRow(47, 48,  "Lubash"),
					new TableRow(49, 50,  "Megged"),
					new TableRow(51, 52,  "Mhurren"),
					new TableRow(53, 54,  "Mord"),
					new TableRow(55, 56,  "Morg"),
					new TableRow(57, 58,  "Nil"),
					new TableRow(59, 60,  "Nybarg"),
					new TableRow(61, 62,  "Odorr"),
					new TableRow(63, 64,  "Ohr"),
					new TableRow(65, 66,  "Rendar"),
					new TableRow(67, 68,  "Resh"),
					new TableRow(69, 70,  "Ront"),
					new TableRow(71, 72,  "Rrath"),
					new TableRow(73, 74,  "Sark"),
					new TableRow(75, 76,  "Scrag"),
					new TableRow(77, 78,  "Sheggen"),
					new TableRow(79, 80,  "Shump"),
					new TableRow(81, 82,  "Tanglar"),
					new TableRow(83, 84,  "Tarak"),
					new TableRow(85, 86,  "Thar"),
					new TableRow(87, 88,  "Thokk"),
					new TableRow(89, 90,  "Trag"),
					new TableRow(91, 92,  "Ugarth"),
					new TableRow(93, 94,  "Varg"),
					new TableRow(95, 96,  "Vilberg"),
					new TableRow(97, 98,  "Yurk"),
					new TableRow(99, 100, "Zed"),
				});

				public static readonly Table tiefling_female_names = new Table("Female Tiefling Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 180, new TableRow[]
				{
					new TableRow(1, 2,    "Akta"),
					new TableRow(3, 4,    "Anakis"),
					new TableRow(5, 6,    "Armara"),
					new TableRow(7, 8,    "Astaro"),
					new TableRow(9, 10,   "Aym"),
					new TableRow(11, 12,  "Azza"),
					new TableRow(13, 14,  "Beleth"),
					new TableRow(15, 16,  "Bryseis"),
					new TableRow(17, 18,  "Bune"),
					new TableRow(19, 20,  "Criella"),
					new TableRow(21, 22,  "Damaia"),
					new TableRow(23, 24,  "Decarabia"),
					new TableRow(25, 26,  "Ea"),
					new TableRow(27, 28,  "Gadreel"),
					new TableRow(29, 30,  "Gomory"),
					new TableRow(31, 32,  "Hecat"),
					new TableRow(33, 34,  "Ishte"),
					new TableRow(35, 36,  "Jezebeth"),
					new TableRow(37, 38,  "Kali"),
					new TableRow(39, 40,  "Kallista"),
					new TableRow(41, 42,  "Kasdeya"),
					new TableRow(43, 44,  "Lerissa"),
					new TableRow(45, 46,  "Lilith"),
					new TableRow(47, 48,  "Makaria"),
					new TableRow(49, 50,  "Manea"),
					new TableRow(51, 52,  "Markosian"),
					new TableRow(53, 54,  "Mastema"),
					new TableRow(55, 56,  "Naamah"),
					new TableRow(57, 58,  "Nemeia"),
					new TableRow(59, 60,  "Nija"),
					new TableRow(61, 62,  "Orianna"),
					new TableRow(63, 64,  "Osah"),
					new TableRow(65, 66,  "Phelaia"),
					new TableRow(67, 68,  "Prosperine"),
					new TableRow(69, 70,  "Purah"),
					new TableRow(71, 72,  "Pyra"),
					new TableRow(73, 74,  "Rieta"),
					new TableRow(75, 76,  "Ronobe"),
					new TableRow(77, 78,  "Ronwe"),
					new TableRow(79, 80,  "Seddit"),
					new TableRow(81, 82,  "Seere"),
					new TableRow(83, 84,  "Sekhmet"),
					new TableRow(85, 86,  "Semyaza"),
					new TableRow(87, 88,  "Shava"),
					new TableRow(89, 90,  "Shax"),
					new TableRow(91, 92,  "Sorath"),
					new TableRow(93, 94,  "Uzza"),
					new TableRow(95, 96,  "Vapula"),
					new TableRow(97, 98,  "Vepar"),
					new TableRow(99, 100, "Verin"),
				});

				public static readonly Table tiefling_male_names = new Table("Male Tiefling Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 180, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table tiefling_virtue_names = new Table("Tiefling Virtue Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 180, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});
			}

			public static class HumanNames
			{
				public static readonly Table human_arabic_female_names = new Table("Female Arabic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 181, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_arabic_male_names = new Table("Male Arabic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 181, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_celtic_female_names = new Table("Female Celtic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_celtic_male_names = new Table("Male Celtic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_chinese_female_names = new Table("Female Chinese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_chinese_male_names = new Table("Male Chinese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_egyptian_female_names = new Table("Female Egyptian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 183, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_egyptian_male_names = new Table("Male Egpytian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 183, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_english_female_names = new Table("Female English Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 184, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_english_male_names = new Table("Male English Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 184, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_french_female_names = new Table("Female French Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_french_male_names = new Table("Male French Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_german_female_names = new Table("Female German Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_german_male_names = new Table("Male German Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_greek_female_names = new Table("Female Greek Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_greek_male_names = new Table("Male Greek Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_indian_female_names = new Table("Female Indian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_indian_male_names = new Table("Male Indian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_japanese_female_names = new Table("Female Japanese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 187, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_japanese_male_names = new Table("Male Japanese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 187, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_mesoamerican_female_names = new Table("Female Mesoamerican Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 188, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_mesoamerican_male_names = new Table("Male Mesoamerican Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 188, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_niger_congo_female_names = new Table("Female Niger-Congo Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_niger_congo_male_names = new Table("Male Niger-Congo Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_norse_female_names = new Table("Female Norse Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_norse_male_names = new Table("Male Norse Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_polynesian_female_names = new Table("Female Polynesian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_polynesian_male_names = new Table("Male Polynesian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_roman_female_names = new Table("Female Roman Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_roman_male_names = new Table("Male Roman Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_slavic_female_names = new Table("Female Slavic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 191, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_slavic_male_names = new Table("Male Slavic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 191, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_spanish_female_names = new Table("Female Spanish Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 192, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});

				public static readonly Table human_spanish_male_names = new Table("Male Spanish Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 192, new TableRow[]
				{
					new TableRow(1, 2,    ""),
					new TableRow(3, 4,    ""),
					new TableRow(5, 6,    ""),
					new TableRow(7, 8,    ""),
					new TableRow(9, 10,   ""),
					new TableRow(11, 12,  ""),
					new TableRow(13, 14,  ""),
					new TableRow(15, 16,  ""),
					new TableRow(17, 18,  ""),
					new TableRow(19, 20,  ""),
					new TableRow(21, 22,  ""),
					new TableRow(23, 24,  ""),
					new TableRow(25, 26,  ""),
					new TableRow(27, 28,  ""),
					new TableRow(29, 30,  ""),
					new TableRow(31, 32,  ""),
					new TableRow(33, 34,  ""),
					new TableRow(35, 36,  ""),
					new TableRow(37, 38,  ""),
					new TableRow(39, 40,  ""),
					new TableRow(41, 42,  ""),
					new TableRow(43, 44,  ""),
					new TableRow(45, 46,  ""),
					new TableRow(47, 48,  ""),
					new TableRow(49, 50,  ""),
					new TableRow(51, 52,  ""),
					new TableRow(53, 54,  ""),
					new TableRow(55, 56,  ""),
					new TableRow(57, 58,  ""),
					new TableRow(59, 60,  ""),
					new TableRow(61, 62,  ""),
					new TableRow(63, 64,  ""),
					new TableRow(65, 66,  ""),
					new TableRow(67, 68,  ""),
					new TableRow(69, 70,  ""),
					new TableRow(71, 72,  ""),
					new TableRow(73, 74,  ""),
					new TableRow(75, 76,  ""),
					new TableRow(77, 78,  ""),
					new TableRow(79, 80,  ""),
					new TableRow(81, 82,  ""),
					new TableRow(83, 84,  ""),
					new TableRow(85, 86,  ""),
					new TableRow(87, 88,  ""),
					new TableRow(89, 90,  ""),
					new TableRow(91, 92,  ""),
					new TableRow(93, 94,  ""),
					new TableRow(95, 96,  ""),
					new TableRow(97, 98,  ""),
					new TableRow(99, 100, ""),
				});
			}
		}
	}
}