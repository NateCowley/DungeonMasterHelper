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
		public static class XGE
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
					new TableRow(1, 2,    "Abad"),
					new TableRow(3, 4,    "Ahrim"),
					new TableRow(5, 6,    "Akmen"),
					new TableRow(7, 8,    "Amnon"),
					new TableRow(9, 10,   "Andram"),
					new TableRow(11, 12,  "Astar"),
					new TableRow(13, 14,  "Balam"),
					new TableRow(15, 16,  "Barakas"),
					new TableRow(17, 18,  "Bathin"),
					new TableRow(19, 20,  "Caim"),
					new TableRow(21, 22,  "Chem"),
					new TableRow(23, 24,  "Cimer"),
					new TableRow(25, 26,  "Cressel"),
					new TableRow(27, 28,  "Damakos"),
					new TableRow(29, 30,  "Ekemon"),
					new TableRow(31, 32,  "Euron"),
					new TableRow(33, 34,  "Fenriz"),
					new TableRow(35, 36,  "Forcas"),
					new TableRow(37, 38,  "Habor"),
					new TableRow(39, 40,  "Iados"),
					new TableRow(41, 42,  "Kairon"),
					new TableRow(43, 44,  "Leucis"),
					new TableRow(45, 46,  "Mamnen"),
					new TableRow(47, 48,  "Mantus"),
					new TableRow(49, 50,  "Marbas"),
					new TableRow(51, 52,  "Melech"),
					new TableRow(53, 54,  "Merihim"),
					new TableRow(55, 56,  "Modean"),
					new TableRow(57, 58,  "Mordai"),
					new TableRow(59, 60,  "Mormo"),
					new TableRow(61, 62,  "Morthos"),
					new TableRow(63, 64,  "Nicor"),
					new TableRow(65, 66,  "Nirgel"),
					new TableRow(67, 68,  "Oriax"),
					new TableRow(69, 70,  "Paymon"),
					new TableRow(71, 72,  "Pelaios"),
					new TableRow(73, 74,  "Purson"),
					new TableRow(75, 76,  "Qemuel"),
					new TableRow(77, 78,  "Raam"),
					new TableRow(79, 80,  "Rimmon"),
					new TableRow(81, 82,  "Sammal"),
					new TableRow(83, 84,  "Skamos"),
					new TableRow(85, 86,  "Tethren"),
					new TableRow(87, 88,  "Thamuz"),
					new TableRow(89, 90,  "Therai"),
					new TableRow(91, 92,  "Valafar"),
					new TableRow(93, 94,  "Vassago"),
					new TableRow(95, 96,  "Xappan"),
					new TableRow(97, 98,  "Zepar"),
					new TableRow(99, 100, "Zephan"),
					});

					public static readonly Table tiefling_virtue_names = new Table("Tiefling Virtue Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 180, new TableRow[]
					{
					new TableRow(1, 2,    "Ambition"),
					new TableRow(3, 4,    "Art"),
					new TableRow(5, 6,    "Carrion"),
					new TableRow(7, 8,    "Chant"),
					new TableRow(9, 10,   "Creed"),
					new TableRow(11, 12,  "Death"),
					new TableRow(13, 14,  "Debauchery"),
					new TableRow(15, 16,  "Despair"),
					new TableRow(17, 18,  "Doom"),
					new TableRow(19, 20,  "Doubt"),
					new TableRow(21, 22,  "Dread"),
					new TableRow(23, 24,  "Ecstasy"),
					new TableRow(25, 26,  "Ennui"),
					new TableRow(27, 28,  "Entropy"),
					new TableRow(29, 30,  "Excellence"),
					new TableRow(31, 32,  "Fear"),
					new TableRow(33, 34,  "Glory"),
					new TableRow(35, 36,  "Gluttony"),
					new TableRow(37, 38,  "Grief"),
					new TableRow(39, 40,  "Hate"),
					new TableRow(41, 42,  "Hope"),
					new TableRow(43, 44,  "Horror"),
					new TableRow(45, 46,  "Ideal"),
					new TableRow(47, 48,  "Ignominy"),
					new TableRow(49, 50,  "Laughter"),
					new TableRow(51, 52,  "Love"),
					new TableRow(53, 54,  "Lust"),
					new TableRow(55, 56,  "Mayhem"),
					new TableRow(57, 58,  "Mockery"),
					new TableRow(59, 60,  "Murder"),
					new TableRow(61, 62,  "Muse"),
					new TableRow(63, 64,  "Music"),
					new TableRow(65, 66,  "Mystery"),
					new TableRow(67, 68,  "Nowhere"),
					new TableRow(69, 70,  "Open"),
					new TableRow(71, 72,  "Pain"),
					new TableRow(73, 74,  "Passion"),
					new TableRow(75, 76,  "Poetry"),
					new TableRow(77, 78,  "Quest"),
					new TableRow(79, 80,  "Random"),
					new TableRow(81, 82,  "Reverance"),
					new TableRow(83, 84,  "Revulsion"),
					new TableRow(85, 86,  "Sorrow"),
					new TableRow(87, 88,  "Temerity"),
					new TableRow(89, 90,  "Torment"),
					new TableRow(91, 92,  "Tragedy"),
					new TableRow(93, 94,  "Vice"),
					new TableRow(95, 96,  "Virtue"),
					new TableRow(97, 98,  "Weary"),
					new TableRow(99, 100, "Wit"),
					});
				}

				public static class HumanNames
				{
					public static readonly Table human_arabic_female_names = new Table("Female Arabic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 181, new TableRow[]
					{
					new TableRow(1, 2,    "Aaliyah"),
					new TableRow(3, 4,    "Aida"),
					new TableRow(5, 6,    "Akilah"),
					new TableRow(7, 8,    "Alia"),
					new TableRow(9, 10,   "Amina"),
					new TableRow(11, 12,  "Atefeh"),
					new TableRow(13, 14,  "Chaima"),
					new TableRow(15, 16,  "Dalia"),
					new TableRow(17, 18,  "Ehsan"),
					new TableRow(19, 20,  "Elham"),
					new TableRow(21, 22,  "Farah"),
					new TableRow(23, 24,  "Fatemah"),
					new TableRow(25, 26,  "Gamila"),
					new TableRow(27, 28,  "Iesha"),
					new TableRow(29, 30,  "Inbar"),
					new TableRow(31, 32,  "Kamaria"),
					new TableRow(33, 34,  "Khadija"),
					new TableRow(35, 36,  "Layla"),
					new TableRow(37, 38,  "Lupe"),
					new TableRow(39, 40,  "Nabila"),
					new TableRow(41, 42,  "Nadine"),
					new TableRow(43, 44,  "Naima"),
					new TableRow(45, 46,  "Najila"),
					new TableRow(47, 48,  "Najwa"),
					new TableRow(49, 50,  "Nakia"),
					new TableRow(51, 52,  "Nashwa"),
					new TableRow(53, 54,  "Nawra"),
					new TableRow(55, 56,  "Nuha"),
					new TableRow(57, 58,  "Nura"),
					new TableRow(59, 60,  "Oma"),
					new TableRow(61, 62,  "Qadira"),
					new TableRow(63, 64,  "Qamar"),
					new TableRow(65, 66,  "Qistina"),
					new TableRow(67, 68,  "Rahima"),
					new TableRow(69, 70,  "Rihanna"),
					new TableRow(71, 72,  "Saadia"),
					new TableRow(73, 74,  "Sabah"),
					new TableRow(75, 76,  "Sada"),
					new TableRow(77, 78,  "Saffron"),
					new TableRow(79, 80,  "Sahar"),
					new TableRow(81, 82,  "Salma"),
					new TableRow(83, 84,  "Shatha"),
					new TableRow(85, 86,  "Tahira"),
					new TableRow(87, 88,  "Takisha"),
					new TableRow(89, 90,  "Thana"),
					new TableRow(91, 92,  "Yadira"),
					new TableRow(93, 94,  "Zahra"),
					new TableRow(95, 96,  "Zaida"),
					new TableRow(97, 98,  "Zaina"),
					new TableRow(99, 100, "Zeinab"),
					});

					public static readonly Table human_arabic_male_names = new Table("Male Arabic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 181, new TableRow[]
					{
					new TableRow(1, 2,    "Abbad"),
					new TableRow(3, 4,    "Abdul"),
					new TableRow(5, 6,    "Achmed"),
					new TableRow(7, 8,    "Akeem"),
					new TableRow(9, 10,   "Alif"),
					new TableRow(11, 12,  "Amir"),
					new TableRow(13, 14,  "Asim"),
					new TableRow(15, 16,  "Bashir"),
					new TableRow(17, 18,  "Bassam"),
					new TableRow(19, 20,  "Fahim"),
					new TableRow(21, 22,  "Farid"),
					new TableRow(23, 24,  "Farouk"),
					new TableRow(25, 26,  "Fayez"),
					new TableRow(27, 28,  "Fayyaad"),
					new TableRow(29, 30,  "Fazil"),
					new TableRow(31, 32,  "Hakim"),
					new TableRow(33, 34,  "Halil"),
					new TableRow(35, 36,  "Hamid"),
					new TableRow(37, 38,  "Hazim"),
					new TableRow(39, 40,  "Heydar"),
					new TableRow(41, 42,  "Hussein"),
					new TableRow(43, 44,  "Jabari"),
					new TableRow(45, 46,  "Jafar"),
					new TableRow(47, 48,  "Jahid"),
					new TableRow(49, 50,  "Jamal"),
					new TableRow(51, 52,  "Kalim"),
					new TableRow(53, 54,  "Karim"),
					new TableRow(55, 56,  "Kazim"),
					new TableRow(57, 58,  "Khadim"),
					new TableRow(59, 60,  "Khalid"),
					new TableRow(61, 62,  "Mahmud"),
					new TableRow(63, 64,  "Mansour"),
					new TableRow(65, 66,  "Musharraf"),
					new TableRow(67, 68,  "Mustafa"),
					new TableRow(69, 70,  "Nadir"),
					new TableRow(71, 72,  "Nazim"),
					new TableRow(73, 74,  "Omar"),
					new TableRow(75, 76,  "Qadir"),
					new TableRow(77, 78,  "Qusay"),
					new TableRow(79, 80,  "Rafiq"),
					new TableRow(81, 82,  "Rakim"),
					new TableRow(83, 84,  "Rashad"),
					new TableRow(85, 86,  "Rauf"),
					new TableRow(87, 88,  "Saladin"),
					new TableRow(89, 90,  "Sami"),
					new TableRow(91, 92,  "Samir"),
					new TableRow(93, 94,  "Talib"),
					new TableRow(95, 96,  "Tamir"),
					new TableRow(97, 98,  "Tariq"),
					new TableRow(99, 100, "Yazid"),
					});

					public static readonly Table human_celtic_female_names = new Table("Female Celtic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
					{
					new TableRow(1, 2,    "Aife"),
					new TableRow(3, 4,    "Aina"),
					new TableRow(5, 6,    "Alane"),
					new TableRow(7, 8,    "Ardena"),
					new TableRow(9, 10,   "Arienh"),
					new TableRow(11, 12,  "Beatha"),
					new TableRow(13, 14,  "Birgit"),
					new TableRow(15, 16,  "Briann"),
					new TableRow(17, 18,  "Caomh"),
					new TableRow(19, 20,  "Cara"),
					new TableRow(21, 22,  "Cinnia"),
					new TableRow(23, 24,  "Cordelia"),
					new TableRow(25, 26,  "Deheune"),
					new TableRow(27, 28,  "Divone"),
					new TableRow(29, 30,  "Donia"),
					new TableRow(31, 32,  "Doreena"),
					new TableRow(33, 34,  "Elsha"),
					new TableRow(35, 36,  "Enid"),
					new TableRow(37, 38,  "Ethne"),
					new TableRow(39, 40,  "Evelina"),
					new TableRow(41, 42,  "Fianna"),
					new TableRow(43, 44,  "Genevieve"),
					new TableRow(45, 46,  "Gilda"),
					new TableRow(47, 48,  "Gitta"),
					new TableRow(49, 50,  "Grania"),
					new TableRow(51, 52,  "Gwyndolin"),
					new TableRow(53, 54,  "Idelisa"),
					new TableRow(55, 56,  "Isolde"),
					new TableRow(57, 58,  "Keelin"),
					new TableRow(59, 60,  "Kennocha"),
					new TableRow(61, 62,  "Lavena"),
					new TableRow(63, 64,  "Lesley"),
					new TableRow(65, 66,  "Linnette"),
					new TableRow(67, 68,  "Lyonesse"),
					new TableRow(69, 70,  "Mabina"),
					new TableRow(71, 72,  "Marvina"),
					new TableRow(73, 74,  "Mavis"),
					new TableRow(75, 76,  "Mirna"),
					new TableRow(77, 78,  "Morgan"),
					new TableRow(79, 80,  "Muriel"),
					new TableRow(81, 82,  "Nareena"),
					new TableRow(83, 84,  "Oriana"),
					new TableRow(85, 86,  "Regan"),
					new TableRow(87, 88,  "Ronat"),
					new TableRow(89, 90,  "Rowena"),
					new TableRow(91, 92,  "Selma"),
					new TableRow(93, 94,  "Ula"),
					new TableRow(95, 96,  "Venetia"),
					new TableRow(97, 98,  "Wynne"),
					new TableRow(99, 100, "Yseult"),
					});

					public static readonly Table human_celtic_male_names = new Table("Male Celtic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
					{
					new TableRow(1, 2,    "Airell"),
					new TableRow(3, 4,    "Airic"),
					new TableRow(5, 6,    "Alan"),
					new TableRow(7, 8,    "Anghus"),
					new TableRow(9, 10,   "Aodh"),
					new TableRow(11, 12,  "Bardon"),
					new TableRow(13, 14,  "Bearacb"),
					new TableRow(15, 16,  "Bevyn"),
					new TableRow(17, 18,  "Boden"),
					new TableRow(19, 20,  "Bran"),
					new TableRow(21, 22,  "Brasil"),
					new TableRow(23, 24,  "Bredon"),
					new TableRow(25, 26,  "Brian"),
					new TableRow(27, 28,  "Bricriu"),
					new TableRow(29, 30,  "Bryant"),
					new TableRow(31, 32,  "Cadman"),
					new TableRow(33, 34,  "Caradoc"),
					new TableRow(35, 36,  "Cedric"),
					new TableRow(37, 38,  "Conalt"),
					new TableRow(39, 40,  "Conchobar"),
					new TableRow(41, 42,  "Condon"),
					new TableRow(43, 44,  "Darcy"),
					new TableRow(45, 46,  "Devin"),
					new TableRow(47, 48,  "Dillion"),
					new TableRow(49, 50,  "Donaghy"),
					new TableRow(51, 52,  "Donall"),
					new TableRow(53, 54,  "Duer"),
					new TableRow(55, 56,  "Eghan"),
					new TableRow(57, 58,  "Ewyn"),
					new TableRow(59, 60,  "Ferghus"),
					new TableRow(61, 62,  "Galvyn"),
					new TableRow(63, 64,  "Gildas"),
					new TableRow(65, 66,  "Guy"),
					new TableRow(67, 68,  "Harvey"),
					new TableRow(69, 70,  "Iden"),
					new TableRow(71, 72,  "Irven"),
					new TableRow(73, 74,  "Karney"),
					new TableRow(75, 76,  "Kayne"),
					new TableRow(77, 78,  "Kelvyn"),
					new TableRow(79, 80,  "Kunsgnos"),
					new TableRow(81, 82,  "Leigh"),
					new TableRow(83, 84,  "Maccus"),
					new TableRow(85, 86,  "Moryn"),
					new TableRow(87, 88,  "Neale"),
					new TableRow(89, 90,  "Owyn"),
					new TableRow(91, 92,  "Pryderi"),
					new TableRow(93, 94,  "Reaghan"),
					new TableRow(95, 96,  "Taliesin"),
					new TableRow(97, 98,  "Tiernay"),
					new TableRow(99, 100, "Turi"),
					});

					public static readonly Table human_chinese_female_names = new Table("Female Chinese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
					{
					new TableRow(1, 2,    "Ai"),
					new TableRow(3, 4,    "Anming"),
					new TableRow(5, 6,    "Baozhai"),
					new TableRow(7, 8,    "Bei"),
					new TableRow(9, 10,   "Caixia"),
					new TableRow(11, 12,  "Changchang"),
					new TableRow(13, 14,  "Chen"),
					new TableRow(15, 16,  "Chou"),
					new TableRow(17, 18,  "Chunhua"),
					new TableRow(19, 20,  "Daianna"),
					new TableRow(21, 22,  "Daiyu"),
					new TableRow(23, 24,  "Die"),
					new TableRow(25, 26,  "Ehuang"),
					new TableRow(27, 28,  "Fenfang"),
					new TableRow(29, 30,  "Ge"),
					new TableRow(31, 32,  "Hong"),
					new TableRow(33, 34,  "Huan"),
					new TableRow(35, 36,  "Huifang"),
					new TableRow(37, 38,  "Jia"),
					new TableRow(39, 40,  "Jiao"),
					new TableRow(41, 42,  "Jiaying"),
					new TableRow(43, 44,  "Jingfei"),
					new TableRow(45, 46,  "Jinjing"),
					new TableRow(47, 48,  "Lan"),
					new TableRow(49, 50,  "Li"),
					new TableRow(51, 52,  "Lihua"),
					new TableRow(53, 54,  "Lin"),
					new TableRow(55, 56,  "Ling"),
					new TableRow(57, 58,  "Liu"),
					new TableRow(59, 60,  "Meili"),
					new TableRow(61, 62,  "Ning"),
					new TableRow(63, 64,  "Qi"),
					new TableRow(65, 66,  "Qiao"),
					new TableRow(67, 68,  "Rong"),
					new TableRow(69, 70,  "Shu"),
					new TableRow(71, 72,  "Shuang"),
					new TableRow(73, 74,  "Song"),
					new TableRow(75, 76,  "Ting"),
					new TableRow(77, 78,  "Wen"),
					new TableRow(79, 80,  "Xia"),
					new TableRow(81, 82,  "Xiaodan"),
					new TableRow(83, 84,  "Xiaoli"),
					new TableRow(85, 86,  "Xingjuan"),
					new TableRow(87, 88,  "Xue"),
					new TableRow(89, 90,  "Ya"),
					new TableRow(91, 92,  "Yan"),
					new TableRow(93, 94,  "Ying"),
					new TableRow(95, 96,  "Yuan"),
					new TableRow(97, 98,  "Yue"),
					new TableRow(99, 100, "Yun"),
					});

					public static readonly Table human_chinese_male_names = new Table("Male Chinese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 182, new TableRow[]
					{
					new TableRow(1, 2,    "Bingwen"),
					new TableRow(3, 4,    "Bo"),
					new TableRow(5, 6,    "Bolin"),
					new TableRow(7, 8,    "Chang"),
					new TableRow(9, 10,   "Chao"),
					new TableRow(11, 12,  "Chen"),
					new TableRow(13, 14,  "Cheng"),
					new TableRow(15, 16,  "Da"),
					new TableRow(17, 18,  "Dingxiang"),
					new TableRow(19, 20,  "Fang"),
					new TableRow(21, 22,  "Feng"),
					new TableRow(23, 24,  "Fu"),
					new TableRow(25, 26,  "Gang"),
					new TableRow(27, 28,  "Guang"),
					new TableRow(29, 30,  "Hai"),
					new TableRow(31, 32,  "Heng"),
					new TableRow(33, 34,  "Hong"),
					new TableRow(35, 36,  "Huan"),
					new TableRow(37, 38,  "Huang"),
					new TableRow(39, 40,  "Huiliang"),
					new TableRow(41, 42,  "Huizhong"),
					new TableRow(43, 44,  "Jian"),
					new TableRow(45, 46,  "Jiayi"),
					new TableRow(47, 48,  "Junjie"),
					new TableRow(49, 50,  "Kang"),
					new TableRow(51, 52,  "Lei"),
					new TableRow(53, 54,  "Liang"),
					new TableRow(55, 56,  "Ling"),
					new TableRow(57, 58,  "Liwei"),
					new TableRow(59, 60,  "Meilin"),
					new TableRow(61, 62,  "Niu"),
					new TableRow(63, 64,  "Peizhi"),
					new TableRow(65, 66,  "Peng"),
					new TableRow(67, 68,  "Ping"),
					new TableRow(69, 70,  "Qiang"),
					new TableRow(71, 72,  "Qiu"),
					new TableRow(73, 74,  "Quan"),
					new TableRow(75, 76,  "Renshu"),
					new TableRow(77, 78,  "Rong"),
					new TableRow(79, 80,  "Ru"),
					new TableRow(81, 82,  "Shan"),
					new TableRow(83, 84,  "Shen"),
					new TableRow(85, 86,  "Tengfei"),
					new TableRow(87, 88,  "Wei"),
					new TableRow(89, 90,  "Xiaobo"),
					new TableRow(91, 92,  "Xiaoli"),
					new TableRow(93, 94,  "Xin"),
					new TableRow(95, 96,  "Yang"),
					new TableRow(97, 98,  "Ying"),
					new TableRow(99, 100, "Zhong"),
					});

					public static readonly Table human_egyptian_female_names = new Table("Female Egyptian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 183, new TableRow[]
					{
					new TableRow(1, 2,    "Alat"),
					new TableRow(3, 4,    "Ahset"),
					new TableRow(5, 6,    "Amunet"),
					new TableRow(7, 8,    "Aneksi"),
					new TableRow(9, 10,   "Atet"),
					new TableRow(11, 12,  "Baketamon"),
					new TableRow(13, 14,  "Betrest"),
					new TableRow(15, 16,  "Bunefer"),
					new TableRow(17, 18,  "Dedyet"),
					new TableRow(19, 20,  "Hatshepsut"),
					new TableRow(21, 22,  "Hentie"),
					new TableRow(23, 24,  "Herit"),
					new TableRow(25, 26,  "Hetepheres"),
					new TableRow(27, 28,  "Intakaes"),
					new TableRow(29, 30,  "Ipwet"),
					new TableRow(31, 32,  "Itet"),
					new TableRow(33, 34,  "Joba"),
					new TableRow(35, 36,  "Kasmut"),
					new TableRow(37, 38,  "Kemanub"),
					new TableRow(39, 40,  "Khemut"),
					new TableRow(41, 42,  "Kiya"),
					new TableRow(43, 44,  "Maia"),
					new TableRow(45, 46,  "Menhet"),
					new TableRow(47, 48,  "Merit"),
					new TableRow(49, 50,  "Meritamen"),
					new TableRow(51, 52,  "Merneith"),
					new TableRow(53, 54,  "Merseger"),
					new TableRow(55, 56,  "Muyet"),
					new TableRow(57, 58,  "Nebet"),
					new TableRow(59, 60,  "Nebetah"),
					new TableRow(61, 62,  "Nedjemmut"),
					new TableRow(63, 64,  "Nefertiti"),
					new TableRow(65, 66,  "Neferu"),
					new TableRow(67, 68,  "Neithotep"),
					new TableRow(69, 70,  "Nit"),
					new TableRow(71, 72,  "Nofret"),
					new TableRow(73, 74,  "Nubemiunu"),
					new TableRow(75, 76,  "Peseshet"),
					new TableRow(77, 78,  "Pypuy"),
					new TableRow(79, 80,  "Qalhata"),
					new TableRow(81, 82,  "Rai"),
					new TableRow(83, 84,  "Redji"),
					new TableRow(85, 86,  "Sadeh"),
					new TableRow(87, 88,  "Sadek"),
					new TableRow(89, 90,  "Sitamun"),
					new TableRow(91, 92,  "Sitre"),
					new TableRow(93, 94,  "Takhat"),
					new TableRow(95, 96,  "Tarset"),
					new TableRow(97, 98,  "Taweret"),
					new TableRow(99, 100, "Werenro"),
					});

					public static readonly Table human_egyptian_male_names = new Table("Male Egpytian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 183, new TableRow[]
					{
					new TableRow(1, 2,    "Ahmose"),
					new TableRow(3, 4,    "Akhom"),
					new TableRow(5, 6,    "Amasis"),
					new TableRow(7, 8,    "Amenemhet"),
					new TableRow(9, 10,   "Anen"),
					new TableRow(11, 12,  "Banefre"),
					new TableRow(13, 14,  "Bek"),
					new TableRow(15, 16,  "Djedefre"),
					new TableRow(17, 18,  "Djoser"),
					new TableRow(19, 20,  "Hekaib"),
					new TableRow(21, 22,  "Henenu"),
					new TableRow(23, 24,  "Horemheb"),
					new TableRow(25, 26,  "Horwedja"),
					new TableRow(27, 28,  "Huya"),
					new TableRow(29, 30,  "Ibebi"),
					new TableRow(31, 32,  "Idu"),
					new TableRow(33, 34,  "Imhotep"),
					new TableRow(35, 36,  "Ineni"),
					new TableRow(37, 38,  "Ipuki"),
					new TableRow(39, 40,  "Irsu"),
					new TableRow(41, 42,  "Kagemni"),
					new TableRow(43, 44,  "Kawab"),
					new TableRow(45, 46,  "Kenamon"),
					new TableRow(47, 48,  "Kewap"),
					new TableRow(49, 50,  "Khaemwaset"),
					new TableRow(51, 52,  "Khafra"),
					new TableRow(53, 54,  "Khusebeck"),
					new TableRow(55, 56,  "Masaharta"),
					new TableRow(57, 58,  "Meketre"),
					new TableRow(59, 60,  "Menkhaf"),
					new TableRow(61, 62,  "Merenre"),
					new TableRow(63, 64,  "Metjen"),
					new TableRow(65, 66,  "Nebamun"),
					new TableRow(67, 68,  "Nebetka"),
					new TableRow(69, 70,  "Nehi"),
					new TableRow(71, 72,  "Nekure"),
					new TableRow(73, 74,  "Nessumontu"),
					new TableRow(75, 76,  "Pakhom"),
					new TableRow(77, 78,  "Pawah"),
					new TableRow(79, 80,  "Pawero"),
					new TableRow(81, 82,  "Ramose"),
					new TableRow(83, 84,  "Rudjek"),
					new TableRow(85, 86,  "Sabaf"),
					new TableRow(87, 88,  "Sebek-khu"),
					new TableRow(89, 90,  "Sebni"),
					new TableRow(91, 92,  "Senusret"),
					new TableRow(93, 94,  "Shabaka"),
					new TableRow(95, 96,  "Somintu"),
					new TableRow(97, 98,  "Thaneni"),
					new TableRow(99, 100, "Thethi"),
					});

					public static readonly Table human_english_female_names = new Table("Female English Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 184, new TableRow[]
					{
					new TableRow(1, 2,    "Adelaide"),
					new TableRow(3, 4,    "Agatha"),
					new TableRow(5, 6,    "Agnes"),
					new TableRow(7, 8,    "Alice"),
					new TableRow(9, 10,   "Aline"),
					new TableRow(11, 12,  "Anne"),
					new TableRow(13, 14,  "Avelina"),
					new TableRow(15, 16,  "Avice"),
					new TableRow(17, 18,  "Beatrice"),
					new TableRow(19, 20,  "Cecily"),
					new TableRow(21, 22,  "Egelina"),
					new TableRow(23, 24,  "Eleanor"),
					new TableRow(25, 26,  "Elizabeth"),
					new TableRow(27, 28,  "Ella"),
					new TableRow(29, 30,  "Eloise"),
					new TableRow(31, 32,  "Elysande"),
					new TableRow(33, 34,  "Emeny"),
					new TableRow(35, 36,  "Emma"),
					new TableRow(37, 38,  "Emmeline"),
					new TableRow(39, 40,  "Ermina"),
					new TableRow(41, 42,  "Eva"),
					new TableRow(43, 44,  "Galiena"),
					new TableRow(45, 46,  "Geva"),
					new TableRow(47, 48,  "Giselle"),
					new TableRow(49, 50,  "Griselda"),
					new TableRow(51, 52,  "Hadwisa"),
					new TableRow(53, 54,  "Helen"),
					new TableRow(55, 56,  "Herleva"),
					new TableRow(57, 58,  "Hugolina"),
					new TableRow(59, 60,  "Ida"),
					new TableRow(61, 62,  "Isabella"),
					new TableRow(63, 64,  "Jacoba"),
					new TableRow(65, 66,  "Jane"),
					new TableRow(67, 68,  "Joan"),
					new TableRow(69, 70,  "Juliana"),
					new TableRow(71, 72,  "Katherine"),
					new TableRow(73, 74,  "Margery"),
					new TableRow(75, 76,  "Mary"),
					new TableRow(77, 78,  "Matilda"),
					new TableRow(79, 80,  "Maynild"),
					new TableRow(81, 82,  "Millicent"),
					new TableRow(83, 84,  "Oriel"),
					new TableRow(85, 86,  "Rohesia"),
					new TableRow(87, 88,  "Rosalind"),
					new TableRow(89, 90,  "Rosamund"),
					new TableRow(91, 92,  "Sarah"),
					new TableRow(93, 94,  "Susannah"),
					new TableRow(95, 96,  "Sybil"),
					new TableRow(97, 98,  "Williamina"),
					new TableRow(99, 100, "Yvonne"),
					});

					public static readonly Table human_english_male_names = new Table("Male English Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 184, new TableRow[]
					{
					new TableRow(1, 2,    "Adam"),
					new TableRow(3, 4,    "Adelard"),
					new TableRow(5, 6,    "Aldous"),
					new TableRow(7, 8,    "Anselm"),
					new TableRow(9, 10,   "Arnold"),
					new TableRow(11, 12,  "Bernard"),
					new TableRow(13, 14,  "Bertram"),
					new TableRow(15, 16,  "Charles"),
					new TableRow(17, 18,  "Clerebold"),
					new TableRow(19, 20,  "Conrad"),
					new TableRow(21, 22,  "Diggory"),
					new TableRow(23, 24,  "Drogo"),
					new TableRow(25, 26,  "Everard"),
					new TableRow(27, 28,  "Frederick"),
					new TableRow(29, 30,  "Geoffrey"),
					new TableRow(31, 32,  "Gerald"),
					new TableRow(33, 34,  "Gilbert"),
					new TableRow(35, 36,  "Godfrey"),
					new TableRow(37, 38,  "Gunter"),
					new TableRow(39, 40,  "Guy"),
					new TableRow(41, 42,  "Henry"),
					new TableRow(43, 44,  "Heward"),
					new TableRow(45, 46,  "Hubert"),
					new TableRow(47, 48,  "Hugh"),
					new TableRow(49, 50,  "Jocelyn"),
					new TableRow(51, 52,  "John"),
					new TableRow(53, 54,  "Lance"),
					new TableRow(55, 56,  "Manfred"),
					new TableRow(57, 58,  "Miles"),
					new TableRow(59, 60,  "Nicholas"),
					new TableRow(61, 62,  "Norman"),
					new TableRow(63, 64,  "Odo"),
					new TableRow(65, 66,  "Percival"),
					new TableRow(67, 68,  "Peter"),
					new TableRow(69, 70,  "Ralf"),
					new TableRow(71, 72,  "Randal"),
					new TableRow(73, 74,  "Raymond"),
					new TableRow(75, 76,  "Reynard"),
					new TableRow(77, 78,  "Richard"),
					new TableRow(79, 80,  "Robert"),
					new TableRow(81, 82,  "Roger"),
					new TableRow(83, 84,  "Roland"),
					new TableRow(85, 86,  "Rolf"),
					new TableRow(87, 88,  "Simon"),
					new TableRow(89, 90,  "Theobald"),
					new TableRow(91, 92,  "Theodoric"),
					new TableRow(93, 94,  "Thomas"),
					new TableRow(95, 96,  "Timm"),
					new TableRow(97, 98,  "William"),
					new TableRow(99, 100, "Wymar"),
					});

					public static readonly Table human_french_female_names = new Table("Female French Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
					{
					new TableRow(1, 2,    "Aalis"),
					new TableRow(3, 4,    "Agatha"),
					new TableRow(5, 6,    "Agnez"),
					new TableRow(7, 8,    "Alberea"),
					new TableRow(9, 10,   "Alips"),
					new TableRow(11, 12,  "Amee"),
					new TableRow(13, 14,  "Amelot"),
					new TableRow(15, 16,  "Anne"),
					new TableRow(17, 18,  "Avelina"),
					new TableRow(19, 20,  "Blancha"),
					new TableRow(21, 22,  "Cateline"),
					new TableRow(23, 24,  "Cecilia"),
					new TableRow(25, 26,  "Claricia"),
					new TableRow(27, 28,  "Collette"),
					new TableRow(29, 30,  "Denisete"),
					new TableRow(31, 32,  "Dorian"),
					new TableRow(33, 34,  "Edelina"),
					new TableRow(35, 36,  "Emelina"),
					new TableRow(37, 38,  "Emmelot"),
					new TableRow(39, 40,  "Ermentrudis"),
					new TableRow(41, 42,  "Gibelina"),
					new TableRow(43, 44,  "Gila"),
					new TableRow(45, 46,  "Gillette"),
					new TableRow(47, 48,  "Guiburgis"),
					new TableRow(49, 50,  "Guillemette"),
					new TableRow(51, 52,  "Guoite"),
					new TableRow(53, 54,  "Hecelina"),
					new TableRow(55, 56,  "Heloysis"),
					new TableRow(57, 58,  "Helyoudis"),
					new TableRow(59, 60,  "Hodeardis"),
					new TableRow(61, 62,  "Isabellis"),
					new TableRow(63, 64,  "Jaquette"),
					new TableRow(65, 66,  "Jehan"),
					new TableRow(67, 68,  "Johanna"),
					new TableRow(69, 70,  "Juliote"),
					new TableRow(71, 72,  "Katerine"),
					new TableRow(73, 74,  "Luciana"),
					new TableRow(75, 76,  "Margot"),
					new TableRow(77, 78,  "Marguerite"),
					new TableRow(79, 80,  "Maria"),
					new TableRow(81, 82,  "Marie"),
					new TableRow(83, 84,  "Melisende"),
					new TableRow(85, 86,  "Odelina"),
					new TableRow(87, 88,  "Perrette"),
					new TableRow(89, 90,  "Petronilla"),
					new TableRow(91, 92,  "Sedilia"),
					new TableRow(93, 94,  "Stephana"),
					new TableRow(95, 96,  "Sybilla"),
					new TableRow(97, 98,  "Ysabeau"),
					new TableRow(99, 100, "Ysabel"),
					});

					public static readonly Table human_french_male_names = new Table("Male French Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
					{
					new TableRow(1, 2,    "Ambryos"),
					new TableRow(3, 4,    "Ame"),
					new TableRow(5, 6,    "Andri"),
					new TableRow(7, 8,    "Andriet"),
					new TableRow(9, 10,   "Anthoine"),
					new TableRow(11, 12,  "Bernard"),
					new TableRow(13, 14,  "Charles"),
					new TableRow(15, 16,  "Charlot"),
					new TableRow(17, 18,  "Colin"),
					new TableRow(19, 20,  "Denis"),
					new TableRow(21, 22,  "Durant"),
					new TableRow(23, 24,  "Edouart"),
					new TableRow(25, 26,  "Eremon"),
					new TableRow(27, 28,  "Ernault"),
					new TableRow(29, 30,  "Ethor"),
					new TableRow(31, 32,  "Felix"),
					new TableRow(33, 34,  "Floquart"),
					new TableRow(35, 36,  "Galleren"),
					new TableRow(37, 38,  "Gaultier"),
					new TableRow(39, 40,  "Gilles"),
					new TableRow(41, 42,  "Guy"),
					new TableRow(43, 44,  "Henry"),
					new TableRow(45, 46,  "Hugo"),
					new TableRow(47, 48,  "Imbert"),
					new TableRow(49, 50,  "Jacques"),
					new TableRow(51, 52,  "Jacquot"),
					new TableRow(53, 54,  "Jean"),
					new TableRow(55, 56,  "Jehannin"),
					new TableRow(57, 58,  "Louis"),
					new TableRow(59, 60,  "Louys"),
					new TableRow(61, 62,  "Loys"),
					new TableRow(63, 64,  "Martin"),
					new TableRow(65, 66,  "Michel"),
					new TableRow(67, 68,  "Mille"),
					new TableRow(69, 70,  "Morelet"),
					new TableRow(71, 72,  "Nicolas"),
					new TableRow(73, 74,  "Nicolle"),
					new TableRow(75, 76,  "Oudart"),
					new TableRow(77, 78,  "Perrin"),
					new TableRow(79, 80,  "Phillippe"),
					new TableRow(81, 82,  "Pierre"),
					new TableRow(83, 84,  "Regnault"),
					new TableRow(85, 86,  "Richart"),
					new TableRow(87, 88,  "Robert"),
					new TableRow(89, 90,  "Robinet"),
					new TableRow(91, 92,  "Sauvage"),
					new TableRow(93, 94,  "Simon"),
					new TableRow(95, 96,  "Talbot"),
					new TableRow(97, 98,  "Tanguy"),
					new TableRow(99, 100, "Vincent"),
					});

					public static readonly Table human_german_female_names = new Table("Female German Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
					{
					new TableRow(1, 2,    "Adelhayt"),
					new TableRow(3, 4,    "Affra"),
					new TableRow(5, 6,    "Agatha"),
					new TableRow(7, 8,    "Allet"),
					new TableRow(9, 10,   "Angnes"),
					new TableRow(11, 12,  "Anna"),
					new TableRow(13, 14,  "Apell"),
					new TableRow(15, 16,  "Applonia"),
					new TableRow(17, 18,  "Barbara"),
					new TableRow(19, 20,  "Brida"),
					new TableRow(21, 22,  "Brigita"),
					new TableRow(23, 24,  "Cecilia"),
					new TableRow(25, 26,  "Clara"),
					new TableRow(27, 28,  "Cristina"),
					new TableRow(29, 30,  "Dorothea"),
					new TableRow(31, 32,  "Duretta"),
					new TableRow(33, 34,  "Ella"),
					new TableRow(35, 36,  "Eis"),
					new TableRow(37, 38,  "Elsbeth"),
					new TableRow(39, 40,  "Engel"),
					new TableRow(41, 42,  "Enlein"),
					new TableRow(43, 44,  "Enndlin"),
					new TableRow(45, 46,  "Eva"),
					new TableRow(47, 48,  "Fela"),
					new TableRow(49, 50,  "Fronicka"),
					new TableRow(51, 52,  "Genefe"),
					new TableRow(53, 54,  "Geras"),
					new TableRow(55, 56,  "Cerhauss"),
					new TableRow(57, 58,  "Gertrudt"),
					new TableRow(59, 60,  "Guttel"),
					new TableRow(61, 62,  "Helena"),
					new TableRow(63, 64,  "lrmel"),
					new TableRow(65, 66,  "Jonata"),
					new TableRow(67, 68,  "Katerina"),
					new TableRow(69, 70,  "Kuen"),
					new TableRow(71, 72,  "Kungund"),
					new TableRow(73, 74,  "Lucia"),
					new TableRow(75, 76,  "Madalena"),
					new TableRow(77, 78,  "Magdalen"),
					new TableRow(79, 80,  "Margret"),
					new TableRow(81, 82,  "Marlein"),
					new TableRow(83, 84,  "Martha"),
					new TableRow(85, 86,  "Otilia"),
					new TableRow(87, 88,  "Ottilg"),
					new TableRow(89, 90,  "Peternella"),
					new TableRow(91, 92,  "Reusin"),
					new TableRow(93, 94,  "Sibilla"),
					new TableRow(95, 96,  "Ursel"),
					new TableRow(97, 98,  "Vrsula"),
					new TableRow(99, 100, "Walpurg"),
					});

					public static readonly Table human_german_male_names = new Table("Male German Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 185, new TableRow[]
					{
					new TableRow(1, 2,    "Albrecht"),
					new TableRow(3, 4,    "Allexander"),
					new TableRow(5, 6,    "Baltasar"),
					new TableRow(7, 8,    "Benedick"),
					new TableRow(9, 10,   "Berhart"),
					new TableRow(11, 12,  "Caspar"),
					new TableRow(13, 14,  "Clas"),
					new TableRow(15, 16,  "Cristin"),
					new TableRow(17, 18,  "Cristofi"),
					new TableRow(19, 20,  "Dieterich"),
					new TableRow(21, 22,  "Engelhart"),
					new TableRow(23, 24,  "Erhart"),
					new TableRow(25, 26,  "Felix"),
					new TableRow(27, 28,  "Frantz"),
					new TableRow(29, 30,  "Fritz"),
					new TableRow(31, 32,  "Gerhart"),
					new TableRow(33, 34,  "Gotleib"),
					new TableRow(35, 36,  "Hans"),
					new TableRow(37, 38,  "Hartmann"),
					new TableRow(39, 40,  "Heintz"),
					new TableRow(41, 42,  "Herman"),
					new TableRow(43, 44,  "Jacob"),
					new TableRow(45, 46,  "Jeremias"),
					new TableRow(47, 48,  "Jorg"),
					new TableRow(49, 50,  "Kafll"),
					new TableRow(51, 52,  "Kilian"),
					new TableRow(53, 54,  "Linhart"),
					new TableRow(55, 56,  "Lorentz"),
					new TableRow(57, 58,  "Ludwig"),
					new TableRow(59, 60,  "Marx"),
					new TableRow(61, 62,  "Melchor"),
					new TableRow(63, 64,  "Mertin"),
					new TableRow(65, 66,  "Michel"),
					new TableRow(67, 68,  "Moritz"),
					new TableRow(69, 70,  "Osswald"),
					new TableRow(71, 72,  "Ott"),
					new TableRow(73, 74,  "Peter"),
					new TableRow(75, 76,  "Rudolicf"),
					new TableRow(77, 78,  "Ruprecht"),
					new TableRow(79, 80,  "Sewastian"),
					new TableRow(81, 82,  "Sigmund"),
					new TableRow(83, 84,  "Steftan"),
					new TableRow(85, 86,  "Symon"),
					new TableRow(87, 88,  "Thoman"),
					new TableRow(89, 90,  "Ulrich"),
					new TableRow(91, 92,  "Vallentin"),
					new TableRow(93, 94,  "Wendel"),
					new TableRow(95, 96,  "Wilhelm"),
					new TableRow(97, 98,  "Wolff"),
					new TableRow(99, 100, "Wolfgang"),
					});

					public static readonly Table human_greek_female_names = new Table("Female Greek Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
					{
					new TableRow(1, 2,    "Acantha"),
					new TableRow(3, 4,    "Aella"),
					new TableRow(5, 6,    "Alektos"),
					new TableRow(7, 8,    "Alkippe"),
					new TableRow(9, 10,   "Andromeda"),
					new TableRow(11, 12,  "Antigone"),
					new TableRow(13, 14,  "Ariadne"),
					new TableRow(15, 16,  "Astraea"),
					new TableRow(17, 18,  "Chloros"),
					new TableRow(19, 20,  "Chryseos"),
					new TableRow(21, 22,  "Daphne"),
					new TableRow(23, 24,  "Despoina"),
					new TableRow(25, 26,  "Dione"),
					new TableRow(27, 28,  "Eileithyia"),
					new TableRow(29, 30,  "Elektra"),
					new TableRow(31, 32,  "Euadne"),
					new TableRow(33, 34,  "Eudora"),
					new TableRow(35, 36,  "Eunornia"),
					new TableRow(37, 38,  "Hekabe"),
					new TableRow(39, 40,  "Helene"),
					new TableRow(41, 42,  "Hermoione"),
					new TableRow(43, 44,  "Hippolyte"),
					new TableRow(45, 46,  "lanthe"),
					new TableRow(47, 48,  "lokaste"),
					new TableRow(49, 50,  "Iole"),
					new TableRow(51, 52,  "Iphigenia"),
					new TableRow(53, 54,  "Ismene"),
					new TableRow(55, 56,  "Kalliope"),
					new TableRow(57, 58,  "Kallisto"),
					new TableRow(59, 60,  "Kalypso"),
					new TableRow(61, 62,  "Karme"),
					new TableRow(63, 64,  "Kassandra"),
					new TableRow(65, 66,  "Kassiopeia"),
					new TableRow(67, 68,  "Kirke"),
					new TableRow(69, 70,  "Kleio"),
					new TableRow(71, 72,  "Klotho"),
					new TableRow(73, 74,  "Klytie"),
					new TableRow(75, 76,  "Kynthia"),
					new TableRow(77, 78,  "Leto"),
					new TableRow(79, 80,  "Megaera"),
					new TableRow(81, 82,  "Melaina"),
					new TableRow(83, 84,  "Melpomene"),
					new TableRow(85, 86,  "Nausikaa"),
					new TableRow(87, 88,  "Nemesis"),
					new TableRow(89, 90,  "Niobe"),
					new TableRow(91, 92,  "Ourania"),
					new TableRow(93, 94,  "Phaenna"),
					new TableRow(95, 96,  "Polymnia"),
					new TableRow(97, 98,  "Semele"),
					new TableRow(99, 100, "Theia"),
					});

					public static readonly Table human_greek_male_names = new Table("Male Greek Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
					{
					new TableRow(1, 2,    "Adonis"),
					new TableRow(3, 4,    "Adrastos"),
					new TableRow(5, 6,    "Aeson"),
					new TableRow(7, 8,    "Alas"),
					new TableRow(9, 10,   "Aineias"),
					new TableRow(11, 12,  "Aiolos"),
					new TableRow(13, 14,  "Alekto"),
					new TableRow(15, 16,  "Alkeides"),
					new TableRow(17, 18,  "Argos"),
					new TableRow(19, 20,  "Brontes"),
					new TableRow(21, 22,  "Damazo"),
					new TableRow(23, 24,  "Dardanos"),
					new TableRow(25, 26,  "Deimos"),
					new TableRow(27, 28,  "Diomedes"),
					new TableRow(29, 30,  "Endymion"),
					new TableRow(31, 32,  "Epimetheus"),
					new TableRow(33, 34,  "Erebos"),
					new TableRow(35, 36,  "Euandros"),
					new TableRow(37, 38,  "Canymedes"),
					new TableRow(39, 40,  "Glaukos"),
					new TableRow(41, 42,  "Hektor"),
					new TableRow(43, 44,  "Heros"),
					new TableRow(45, 46,  "Hippolytos"),
					new TableRow(47, 48,  "Iacchus"),
					new TableRow(49, 50,  "Iason"),
					new TableRow(51, 52,  "Kadmos"),
					new TableRow(53, 54,  "Kastor"),
					new TableRow(55, 56,  "Kephalos"),
					new TableRow(57, 58,  "Kepheus"),
					new TableRow(59, 60,  "Koios"),
					new TableRow(61, 62,  "Kreios"),
					new TableRow(63, 64,  "Laios"),
					new TableRow(65, 66,  "Leandros"),
					new TableRow(67, 68,  "Linos"),
					new TableRow(69, 70,  "Lykos"),
					new TableRow(71, 72,  "Melanthios"),
					new TableRow(73, 74,  "Menelaus"),
					new TableRow(75, 76,  "Mentor"),
					new TableRow(77, 78,  "Neoptolemus"),
					new TableRow(79, 80,  "Okeanos"),
					new TableRow(81, 82,  "Orestes"),
					new TableRow(83, 84,  "Pallas"),
					new TableRow(85, 86,  "Patroklos"),
					new TableRow(87, 88,  "Philandros"),
					new TableRow(89, 90,  "Phoibos"),
					new TableRow(91, 92,  "Phrixus"),
					new TableRow(93, 94,  "Priamos"),
					new TableRow(95, 96,  "Pyrrhos"),
					new TableRow(97, 98,  "Xanthos"),
					new TableRow(99, 100, "Zephyros"),
					});

					public static readonly Table human_indian_female_names = new Table("Female Indian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
					{
					new TableRow(1, 2,    "Abha"),
					new TableRow(3, 4,    "Aishwarya"),
					new TableRow(5, 6,    "Amala"),
					new TableRow(7, 8,    "Ananda"),
					new TableRow(9, 10,   "Ankita"),
					new TableRow(11, 12,  "Archana"),
					new TableRow(13, 14,  "Avani"),
					new TableRow(15, 16,  "Chandana"),
					new TableRow(17, 18,  "Chandrakanta"),
					new TableRow(19, 20,  "Chetan"),
					new TableRow(21, 22,  "Darshana"),
					new TableRow(23, 24,  "Devi"),
					new TableRow(25, 26,  "Dipti"),
					new TableRow(27, 28,  "Esha"),
					new TableRow(29, 30,  "Gauro"),
					new TableRow(31, 32,  "Gita"),
					new TableRow(33, 34,  "Indira"),
					new TableRow(35, 36,  "Indu"),
					new TableRow(37, 38,  "Jaya"),
					new TableRow(39, 40,  "Kala"),
					new TableRow(41, 42,  "Kalpana"),
					new TableRow(43, 44,  "Kamala"),
					new TableRow(45, 46,  "Kanta"),
					new TableRow(47, 48,  "Kashi"),
					new TableRow(49, 50,  "Kishori"),
					new TableRow(51, 52,  "Lalita"),
					new TableRow(53, 54,  "Lina"),
					new TableRow(55, 56,  "Madhur"),
					new TableRow(57, 58,  "Manju"),
					new TableRow(59, 60,  "Meera"),
					new TableRow(61, 62,  "Mohana"),
					new TableRow(63, 64,  "Mukta"),
					new TableRow(65, 66,  "Nisha"),
					new TableRow(67, 68,  "Nitya"),
					new TableRow(69, 70,  "Padma"),
					new TableRow(71, 72,  "Pratima"),
					new TableRow(73, 74,  "Priya"),
					new TableRow(75, 76,  "Rani"),
					new TableRow(77, 78,  "Sarala"),
					new TableRow(79, 80,  "Shakti"),
					new TableRow(81, 82,  "Shanta"),
					new TableRow(83, 84,  "Shobha"),
					new TableRow(85, 86,  "Sima"),
					new TableRow(87, 88,  "Sonal"),
					new TableRow(89, 90,  "Sumana"),
					new TableRow(91, 92,  "Sunita"),
					new TableRow(93, 94,  "Tara"),
					new TableRow(95, 96,  "Valli"),
					new TableRow(97, 98,  "Vijaya"),
					new TableRow(99, 100, "Virnala"),
					});

					public static readonly Table human_indian_male_names = new Table("Male Indian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 186, new TableRow[]
					{
					new TableRow(1, 2,    "Abhay"),
					new TableRow(3, 4,    "Ahsan"),
					new TableRow(5, 6,    "Ajay"),
					new TableRow(7, 8,    "Ajit"),
					new TableRow(9, 10,   "Akhil"),
					new TableRow(11, 12,  "Amar"),
					new TableRow(13, 14,  "Amit"),
					new TableRow(15, 16,  "Ananta"),
					new TableRow(17, 18,  "Aseem"),
					new TableRow(19, 20,  "Ashok"),
					new TableRow(21, 22,  "Bahadur"),
					new TableRow(23, 24,  "Basu"),
					new TableRow(25, 26,  "Chand"),
					new TableRow(27, 28,  "Chandra"),
					new TableRow(29, 30,  "Damodar"),
					new TableRow(31, 32,  "Darhsan"),
					new TableRow(33, 34,  "Devdan"),
					new TableRow(35, 36,  "Dinesh"),
					new TableRow(37, 38,  "Dipak"),
					new TableRow(39, 40,  "Gopal"),
					new TableRow(41, 42,  "Govind"),
					new TableRow(43, 44,  "Harendra"),
					new TableRow(45, 46,  "Harsha"),
					new TableRow(47, 48,  "Ila"),
					new TableRow(49, 50,  "lsha"),
					new TableRow(51, 52,  "Johar"),
					new TableRow(53, 54,  "Kalyan"),
					new TableRow(55, 56,  "Kiran"),
					new TableRow(57, 58,  "Kumar"),
					new TableRow(59, 60,  "Lakshmana"),
					new TableRow(61, 62,  "Mahavir"),
					new TableRow(63, 64,  "Narayan"),
					new TableRow(65, 66,  "Naveen"),
					new TableRow(67, 68,  "Nirav"),
					new TableRow(69, 70,  "Prabhakar"),
					new TableRow(71, 72,  "Prasanna"),
					new TableRow(73, 74,  "Raghu"),
					new TableRow(75, 76,  "Rajanikant"),
					new TableRow(77, 78,  "Rakesh"),
					new TableRow(79, 80,  "Ranjeet"),
					new TableRow(81, 82,  "Rishi"),
					new TableRow(83, 84,  "Sanjay"),
					new TableRow(85, 86,  "Sekar"),
					new TableRow(87, 88,  "Shandar"),
					new TableRow(89, 90,  "Sumantra"),
					new TableRow(91, 92,  "Vijay"),
					new TableRow(93, 94,  "Vikram"),
					new TableRow(95, 96,  "Vimal"),
					new TableRow(97, 98,  "Vishal"),
					new TableRow(99, 100, "Yash"),
					});

					public static readonly Table human_japanese_female_names = new Table("Female Japanese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 187, new TableRow[]
					{
					new TableRow(1, 2,    "Aika"),
					new TableRow(3, 4,    "Akemi"),
					new TableRow(5, 6,    "Akiko"),
					new TableRow(7, 8,    "Amaya"),
					new TableRow(9, 10,   "Asami"),
					new TableRow(11, 12,  "Ayumi"),
					new TableRow(13, 14,  "Bunko"),
					new TableRow(15, 16,  "Chieko"),
					new TableRow(17, 18,  "Chika"),
					new TableRow(19, 20,  "Chiyo"),
					new TableRow(21, 22,  "Cho"),
					new TableRow(23, 24,  "Eiko"),
					new TableRow(25, 26,  "Emiko"),
					new TableRow(27, 28,  "Eri"),
					new TableRow(29, 30,  "Etsuko"),
					new TableRow(31, 32,  "Gina"),
					new TableRow(33, 34,  "Hana"),
					new TableRow(35, 36,  "Haruki"),
					new TableRow(37, 38,  "Hideko"),
					new TableRow(39, 40,  "Ffikafi"),
					new TableRow(41, 42,  "Hiroko"),
					new TableRow(43, 44,  "Hisoka"),
					new TableRow(45, 46,  "Hishi"),
					new TableRow(47, 48,  "Hotaru"),
					new TableRow(49, 50,  "Izumi"),
					new TableRow(51, 52,  "Kameyo"),
					new TableRow(53, 54,  "Kasumi"),
					new TableRow(55, 56,  "Ifinfiko"),
					new TableRow(57, 58,  "Kotone"),
					new TableRow(59, 60,  "Kyoko"),
					new TableRow(61, 62,  "Maiko"),
					new TableRow(63, 64,  "Masako"),
					new TableRow(65, 66,  "Mi"),
					new TableRow(67, 68,  "Minori"),
					new TableRow(69, 70,  "Mizuki"),
					new TableRow(71, 72,  "Naoki"),
					new TableRow(73, 74,  "Natsuko"),
					new TableRow(75, 76,  "Noriko"),
					new TableRow(77, 78,  "Rei"),
					new TableRow(79, 80,  "Ren"),
					new TableRow(81, 82,  "Saki"),
					new TableRow(83, 84,  "Shigeko"),
					new TableRow(85, 86,  "Shinju"),
					new TableRow(87, 88,  "Sumiko"),
					new TableRow(89, 90,  "Toshiko"),
					new TableRow(91, 92,  "Tsukiko"),
					new TableRow(93, 94,  "Ume"),
					new TableRow(95, 96,  "Usagi"),
					new TableRow(97, 98,  "Yasuko"),
					new TableRow(99, 100, "Yuflko"),
					});

					public static readonly Table human_japanese_male_names = new Table("Male Japanese Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 187, new TableRow[]
					{
					new TableRow(1, 2,    "Akio"),
					new TableRow(3, 4,    "Atsushi"),
					new TableRow(5, 6,    "Daichi"),
					new TableRow(7, 8,    "Daiki"),
					new TableRow(9, 10,   "Daisuke"),
					new TableRow(11, 12,  "Eiji"),
					new TableRow(13, 14,  "Fumio"),
					new TableRow(15, 16,  "Hajime"),
					new TableRow(17, 18,  "Haru"),
					new TableRow(19, 20,  "Hideaki"),
					new TableRow(21, 22,  "Hideo"),
					new TableRow(23, 24,  "Hikaru"),
					new TableRow(25, 26,  "Hiro"),
					new TableRow(27, 28,  "Hiroki"),
					new TableRow(29, 30,  "Hisao"),
					new TableRow(31, 32,  "Hitoshi"),
					new TableRow(33, 34,  "Isamu"),
					new TableRow(35, 36,  "Isao"),
					new TableRow(37, 38,  "Jun"),
					new TableRow(39, 40,  "Katashi"),
					new TableRow(41, 42,  "Katsu"),
					new TableRow(43, 44,  "Kei"),
					new TableRow(45, 46,  "Ken"),
					new TableRow(47, 48,  "Kenshin"),
					new TableRow(49, 50,  "Kenta"),
					new TableRow(51, 52,  "Kioshi"),
					new TableRow(53, 54,  "Makoto"),
					new TableRow(55, 56,  "Mamoru"),
					new TableRow(57, 58,  "Masato"),
					new TableRow(59, 60,  "Masumi"),
					new TableRow(61, 62,  "Noboru"),
					new TableRow(63, 64,  "Norio"),
					new TableRow(65, 66,  "Osamu"),
					new TableRow(67, 68,  "Ryota"),
					new TableRow(69, 70,  "Sadao"),
					new TableRow(71, 72,  "Satoshi"),
					new TableRow(73, 74,  "Shigeo"),
					new TableRow(75, 76,  "Shin"),
					new TableRow(77, 78,  "Sora"),
					new TableRow(79, 80,  "Tadao"),
					new TableRow(81, 82,  "Takehiko"),
					new TableRow(83, 84,  "Takeo"),
					new TableRow(85, 86,  "Takeshi"),
					new TableRow(87, 88,  "Takumi"),
					new TableRow(89, 90,  "Tamotsu"),
					new TableRow(91, 92,  "Tatsuo"),
					new TableRow(93, 94,  "Toru"),
					new TableRow(95, 96,  "Toshio"),
					new TableRow(97, 98,  "Yasuo"),
					new TableRow(99, 100, "Yukio"),
					});

					public static readonly Table human_mesoamerican_female_names = new Table("Female Mesoamerican Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 188, new TableRow[]
					{
					new TableRow(1, 2,    "Ahuiliztli"),
					new TableRow(3, 4,    "Atl"),
					new TableRow(5, 6,    "Centehau"),
					new TableRow(7, 8,    "Chalchiuitl"),
					new TableRow(9, 10,   "Chipahua"),
					new TableRow(11, 12,  "Cihuaton"),
					new TableRow(13, 14,  "Citlali"),
					new TableRow(15, 16,  "Citlalmina"),
					new TableRow(17, 18,  "Coszcatl"),
					new TableRow(19, 20,  "Cozamalotl"),
					new TableRow(21, 22,  "Cuicatl"),
					new TableRow(23, 24,  "Eleuia"),
					new TableRow(25, 26,  "Eloxochitl"),
					new TableRow(27, 28,  "Eztli"),
					new TableRow(29, 30,  "Ichtaca"),
					new TableRow(31, 32,  "Icnoyotl"),
					new TableRow(33, 34,  "Ihuicatl"),
					new TableRow(35, 36,  "Ilhuitl"),
					new TableRow(37, 38,  "Itotia"),
					new TableRow(39, 40,  "Iuitl"),
					new TableRow(41, 42,  "Ixcatzin"),
					new TableRow(43, 44,  "Izel"),
					new TableRow(45, 46,  "Malinalxochitl"),
					new TableRow(47, 48,  "Mecatl"),
					new TableRow(49, 50,  "Meztli"),
					new TableRow(51, 52,  "Miyaoaxochitl"),
					new TableRow(53, 54,  "Mizquixaual"),
					new TableRow(55, 56,  "Moyolehuani"),
					new TableRow(57, 58,  "Nahuatl"),
					new TableRow(59, 60,  "Necahual"),
					new TableRow(61, 62,  "Nenetl"),
					new TableRow(63, 64,  "Nochtli"),
					new TableRow(65, 66,  "Noxochicoztli"),
					new TableRow(67, 68,  "Ohtli"),
					new TableRow(69, 70,  "Papan"),
					new TableRow(71, 72,  "Patli"),
					new TableRow(73, 74,  "Quetzalxochitl"),
					new TableRow(75, 76,  "Sacnite"),
					new TableRow(77, 78,  "Teicui"),
					new TableRow(79, 80,  "Tepin"),
					new TableRow(81, 82,  "Teuicui"),
					new TableRow(83, 84,  "Teyacapan"),
					new TableRow(85, 86,  "Tlaco"),
					new TableRow(87, 88,  "Tlacoehua"),
					new TableRow(89, 90,  "Tlacotl"),
					new TableRow(91, 92,  "Tlalli"),
					new TableRow(93, 94,  "Tlanextli"),
					new TableRow(95, 96,  "Xihuitl"),
					new TableRow(97, 98,  "Xiuhcoatl"),
					new TableRow(99, 100, "Xiuhtonal"),
					});

					public static readonly Table human_mesoamerican_male_names = new Table("Male Mesoamerican Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 188, new TableRow[]
					{
					new TableRow(1, 2,    "Achcauhtli"),
					new TableRow(3, 4,    "Amoxtli"),
					new TableRow(5, 6,    "Chicahua"),
					new TableRow(7, 8,    "Chimalli"),
					new TableRow(9, 10,   "Cipactli"),
					new TableRow(11, 12,  "Coaxoch"),
					new TableRow(13, 14,  "Coyotl"),
					new TableRow(15, 16,  "Cualli"),
					new TableRow(17, 18,  "Cuahtemoc"),
					new TableRow(19, 20,  "Cuetlachtilo"),
					new TableRow(21, 22,  "Cuetzpalli"),
					new TableRow(23, 24,  "Cuixtli"),
					new TableRow(25, 26,  "Ehecatl"),
					new TableRow(27, 28,  "Etalpalli"),
					new TableRow(29, 30,  "Huemac"),
					new TableRow(31, 32,  "Huitzilihuitl"),
					new TableRow(33, 34,  "Iccauhtli"),
					new TableRow(35, 36,  "Ilhicamina"),
					new TableRow(37, 38,  "Itztli"),
					new TableRow(39, 40,  "Ixtli"),
					new TableRow(41, 42,  "Mahuizoh"),
					new TableRow(43, 44,  "Manauia"),
					new TableRow(45, 46,  "Matlal"),
					new TableRow(47, 48,  "Matlalihuitl"),
					new TableRow(49, 50,  "Mazatl"),
					new TableRow(51, 52,  "Mictlantecuhtli"),
					new TableRow(53, 54,  "Milintica"),
					new TableRow(55, 56,  "Momoztli"),
					new TableRow(57, 58,  "Namacuix"),
					new TableRow(59, 60,  "Necalli"),
					new TableRow(61, 62,  "Necuametl"),
					new TableRow(63, 64,  "Nezahualcoyotl"),
					new TableRow(65, 66,  "Nexahualpilli"),
					new TableRow(67, 68,  "Nochehuatl"),
					new TableRow(69, 70,  "Nopaltzin"),
					new TableRow(71, 72,  "Ollin"),
					new TableRow(73, 74,  "Quauhtli"),
					new TableRow(75, 76,  "Tenoch"),
					new TableRow(77, 78,  "Teoxihuitl"),
					new TableRow(79, 80,  "Tepiltzin"),
					new TableRow(81, 82,  "Tezcacoatl"),
					new TableRow(83, 84,  "Tlacaelel"),
					new TableRow(85, 86,  "Tlacelel"),
					new TableRow(87, 88,  "Tlaloc"),
					new TableRow(89, 90,  "Tlanextic"),
					new TableRow(91, 92,  "Tlazohtlaloni"),
					new TableRow(93, 94,  "Tlazopillo"),
					new TableRow(95, 96,  "Uetzcayotl"),
					new TableRow(97, 98,  "Xipilli"),
					new TableRow(99, 100, "Yaotl"),
					});

					public static readonly Table human_niger_congo_female_names = new Table("Female Niger-Congo Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
					{
					new TableRow(1, 2,    "Abebi"),
					new TableRow(3, 4,    "Abena"),
					new TableRow(5, 6,    "Abimbola"),
					new TableRow(7, 8,    "Akoko"),
					new TableRow(9, 10,   "Akachi"),
					new TableRow(11, 12,  "Alaba"),
					new TableRow(13, 14,  "Anuli"),
					new TableRow(15, 16,  "Ayo"),
					new TableRow(17, 18,  "Bolanle"),
					new TableRow(19, 20,  "Bosede"),
					new TableRow(21, 22,  "Chiamaka"),
					new TableRow(23, 24,  "Chidi"),
					new TableRow(25, 26,  "Chidimma"),
					new TableRow(27, 28,  "Chinyere"),
					new TableRow(29, 30,  "Chioma"),
					new TableRow(31, 32,  "Dada"),
					new TableRow(33, 34,  "Ebele"),
					new TableRow(35, 36,  "Efemena"),
					new TableRow(37, 38,  "Efiro"),
					new TableRow(39, 40,  "Ekundayo"),
					new TableRow(41, 42,  "Enitan"),
					new TableRow(43, 44,  "Funanya"),
					new TableRow(45, 46,  "Ifunanya"),
					new TableRow(47, 48,  "lge"),
					new TableRow(49, 50,  "Ime"),
					new TableRow(51, 52,  "Kunto"),
					new TableRow(53, 54,  "Lesedi"),
					new TableRow(55, 56,  "Lumusi"),
					new TableRow(57, 58,  "Mojisola"),
					new TableRow(59, 60,  "Monifa"),
					new TableRow(61, 62,  "Nakato"),
					new TableRow(63, 64,  "Ndidi"),
					new TableRow(65, 66,  "Ngozi"),
					new TableRow(67, 68,  "Nkiruka"),
					new TableRow(69, 70,  "Nneka"),
					new TableRow(71, 72,  "Ogechi"),
					new TableRow(73, 74,  "Olamide"),
					new TableRow(75, 76,  "Oluchi"),
					new TableRow(77, 78,  "Omolara"),
					new TableRow(79, 80,  "Onyeka"),
					new TableRow(81, 82,  "Simisola"),
					new TableRow(83, 84,  "Temitope"),
					new TableRow(85, 86,  "Thema"),
					new TableRow(87, 88,  "Titlayo"),
					new TableRow(89, 90,  "Udo"),
					new TableRow(91, 92,  "Uduak"),
					new TableRow(93, 94,  "Ufuoma"),
					new TableRow(95, 96,  "Yaa"),
					new TableRow(97, 98,  "Yejide"),
					new TableRow(99, 100, "Yewande"),
					});

					public static readonly Table human_niger_congo_male_names = new Table("Male Niger-Congo Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
					{
					new TableRow(1, 2,    "Abe-be"),
					new TableRow(3, 4,    "Abel"),
					new TableRow(5, 6,    "Abidemi"),
					new TableRow(7, 8,    "Abrafo"),
					new TableRow(9, 10,   "Adisa"),
					new TableRow(11, 12,  "Amadi"),
					new TableRow(13, 14,  "Amara"),
					new TableRow(15, 16,  "Anyim"),
					new TableRow(17, 18,  "Azubuike"),
					new TableRow(19, 20,  "Bapoto"),
					new TableRow(21, 22,  "Baraka"),
					new TableRow(23, 24,  "Bohlale"),
					new TableRow(25, 26,  "Bongani"),
					new TableRow(27, 28,  "Bujune"),
					new TableRow(29, 30,  "Buziba"),
					new TableRow(31, 32,  "Chakide"),
					new TableRow(33, 34,  "Chibuzo"),
					new TableRow(35, 36,  "Chika"),
					new TableRow(37, 38,  "Chimola"),
					new TableRow(39, 40,  "Chiratidzo"),
					new TableRow(41, 42,  "Dabulamanzi"),
					new TableRow(43, 44,  "Dumisa"),
					new TableRow(45, 46,  "Dwanh"),
					new TableRow(47, 48,  "Erneka"),
					new TableRow(49, 50,  "Folami"),
					new TableRow(51, 52,  "Gatura"),
					new TableRow(53, 54,  "Gebhuza"),
					new TableRow(55, 56,  "Gero"),
					new TableRow(57, 58,  "lsoba"),
					new TableRow(59, 60,  "Kagiso"),
					new TableRow(61, 62,  "Kamau"),
					new TableRow(63, 64,  "Katlego"),
					new TableRow(65, 66,  "Masego"),
					new TableRow(67, 68,  "Matata"),
					new TableRow(69, 70,  "Nthanda"),
					new TableRow(71, 72,  "Ogechi"),
					new TableRow(73, 74,  "Olwenyo"),
					new TableRow(75, 76,  "Osumare"),
					new TableRow(77, 78,  "Paki"),
					new TableRow(79, 80,  "Qinisela"),
					new TableRow(81, 82,  "Quanda"),
					new TableRow(83, 84,  "Samanya"),
					new TableRow(85, 86,  "Shanika"),
					new TableRow(87, 88,  "Sibonakaliso"),
					new TableRow(89, 90,  "Tapiwa"),
					new TableRow(91, 92,  "Thabo"),
					new TableRow(93, 94,  "Themba"),
					new TableRow(95, 96,  "Uzoma"),
					new TableRow(97, 98,  "Zuberi"),
					new TableRow(99, 100, "Zuri"),
					});

					public static readonly Table human_norse_female_names = new Table("Female Norse Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
					{
					new TableRow(1, 2,    "Alfhild"),
					new TableRow(3, 4,    "Arnbjorg"),
					new TableRow(5, 6,    "Ase"),
					new TableRow(7, 8,    "Aslog"),
					new TableRow(9, 10,   "Astrid"),
					new TableRow(11, 12,  "Auda"),
					new TableRow(13, 14,  "Audhid"),
					new TableRow(15, 16,  "Bergljot"),
					new TableRow(17, 18,  "Birghild"),
					new TableRow(19, 20,  "Bodil"),
					new TableRow(21, 22,  "Brenna"),
					new TableRow(23, 24,  "Brynhild"),
					new TableRow(25, 26,  "Dagmar"),
					new TableRow(27, 28,  "Eerika"),
					new TableRow(29, 30,  "Eria"),
					new TableRow(31, 32,  "Gudrun"),
					new TableRow(33, 34,  "Gunborg"),
					new TableRow(35, 36,  "Gunhild"),
					new TableRow(37, 38,  "Gunvor"),
					new TableRow(39, 40,  "Helga"),
					new TableRow(41, 42,  "Hertha"),
					new TableRow(43, 44,  "Hilde"),
					new TableRow(45, 46,  "Hillevi"),
					new TableRow(47, 48,  "Ingrid"),
					new TableRow(49, 50,  "Jona"),
					new TableRow(51, 52,  "Jorunn"),
					new TableRow(53, 54,  "Kari"),
					new TableRow(55, 56,  "Kenna"),
					new TableRow(57, 58,  "Magnhild"),
					new TableRow(59, 60,  "Nanna"),
					new TableRow(61, 62,  "Olga"),
					new TableRow(63, 64,  "Ragna"),
					new TableRow(65, 66,  "Ragnhild"),
					new TableRow(67, 68,  "Ranveig"),
					new TableRow(69, 70,  "Runa"),
					new TableRow(71, 72,  "Saga"),
					new TableRow(73, 74,  "Sigfrid"),
					new TableRow(75, 76,  "Signe"),
					new TableRow(77, 78,  "Sigrid"),
					new TableRow(79, 80,  "Sigrunn"),
					new TableRow(81, 82,  "Solveg"),
					new TableRow(83, 84,  "Svanhild"),
					new TableRow(85, 86,  "Thora"),
					new TableRow(87, 88,  "Torborg"),
					new TableRow(89, 90,  "Torunn"),
					new TableRow(91, 92,  "Tove"),
					new TableRow(93, 94,  "Unn"),
					new TableRow(95, 96,  "Vigdi"),
					new TableRow(97, 98,  "Ylva"),
					new TableRow(99, 100, "Yngvild"),
					});

					public static readonly Table human_norse_male_names = new Table("Male Norse Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 189, new TableRow[]
					{
					new TableRow(1, 2,    "Agni"),
					new TableRow(3, 4,    "Alaric"),
					new TableRow(5, 6,    "Anvindr"),
					new TableRow(7, 8,    "Arvid"),
					new TableRow(9, 10,   "Asger"),
					new TableRow(11, 12,  "Asmund"),
					new TableRow(13, 14,  "Bjarte"),
					new TableRow(15, 16,  "Bjorg"),
					new TableRow(17, 18,  "Bjorn"),
					new TableRow(19, 20,  "Brandr"),
					new TableRow(21, 22,  "Brandt"),
					new TableRow(23, 24,  "Brynjar"),
					new TableRow(25, 26,  "Calder"),
					new TableRow(27, 28,  "Colborn"),
					new TableRow(29, 30,  "Cuyler"),
					new TableRow(31, 32,  "Egi"),
					new TableRow(33, 34,  "Einar"),
					new TableRow(35, 36,  "Eric"),
					new TableRow(37, 38,  "Erland"),
					new TableRow(39, 40,  "Fiske"),
					new TableRow(41, 42,  "Folkvar"),
					new TableRow(43, 44,  "Fritjof"),
					new TableRow(45, 46,  "Frode"),
					new TableRow(47, 48,  "Geir"),
					new TableRow(49, 50,  "Halvar"),
					new TableRow(51, 52,  "Hemming"),
					new TableRow(53, 54,  "Hjalmar"),
					new TableRow(55, 56,  "Hjortr"),
					new TableRow(57, 58,  "Ingimarr"),
					new TableRow(59, 60,  "Ivar"),
					new TableRow(61, 62,  "Knud"),
					new TableRow(63, 64,  "Leif"),
					new TableRow(65, 66,  "Liufr"),
					new TableRow(67, 68,  "Manning"),
					new TableRow(69, 70,  "Oddr"),
					new TableRow(71, 72,  "Olin"),
					new TableRow(73, 74,  "Ormr"),
					new TableRow(75, 76,  "Ove"),
					new TableRow(77, 78,  "Rannulfr"),
					new TableRow(79, 80,  "Sigurd"),
					new TableRow(81, 82,  "Skari"),
					new TableRow(83, 84,  "Snorri"),
					new TableRow(85, 86,  "Sten"),
					new TableRow(87, 88,  "Stigandr"),
					new TableRow(89, 90,  "Stigr"),
					new TableRow(91, 92,  "Sven"),
					new TableRow(93, 94,  "Trygve"),
					new TableRow(95, 96,  "Ulf"),
					new TableRow(97, 98,  "Vali"),
					new TableRow(99, 100, "Vidar"),
					});

					public static readonly Table human_polynesian_female_names = new Table("Female Polynesian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
					{
					new TableRow(1, 2,    "Ahulani"),
					new TableRow(3, 4,    "Airini"),
					new TableRow(5, 6,    "Alani"),
					new TableRow(7, 8,    "Aluala"),
					new TableRow(9, 10,   "Anahera"),
					new TableRow(11, 12,  "Anuhea"),
					new TableRow(13, 14,  "Aolani"),
					new TableRow(15, 16,  "Elenoa"),
					new TableRow(17, 18,  "Emele"),
					new TableRow(19, 20,  "Fetia"),
					new TableRow(21, 22,  "Fiva"),
					new TableRow(23, 24,  "Halona"),
					new TableRow(25, 26,  "Hi'ilei"),
					new TableRow(27, 28,  "Hina"),
					new TableRow(29, 30,  "Hinatea"),
					new TableRow(31, 32,  "Huali"),
					new TableRow(33, 34,  "Inia"),
					new TableRow(35, 36,  "Inina"),
					new TableRow(37, 38,  "Iolani"),
					new TableRow(39, 40,  "Isa"),
					new TableRow(41, 42,  "Ka'ana'ana"),
					new TableRow(43, 44,  "Ka'ena"),
					new TableRow(45, 46,  "Kaamia"),
					new TableRow(47, 48,  "Kahula"),
					new TableRow(49, 50,  "Kailani"),
					new TableRow(51, 52,  "Kamaile"),
					new TableRow(53, 54,  "Kamakani"),
					new TableRow(55, 56,  "Kamea"),
					new TableRow(57, 58,  "Latai"),
					new TableRow(59, 60,  "Liona"),
					new TableRow(61, 62,  "Lokelani"),
					new TableRow(63, 64,  "Marva"),
					new TableRow(65, 66,  "Mehana"),
					new TableRow(67, 68,  "Millawa"),
					new TableRow(69, 70,  "Moana"),
					new TableRow(71, 72,  "Ngana"),
					new TableRow(73, 74,  "Nohea"),
					new TableRow(75, 76,  "Pelika"),
					new TableRow(77, 78,  "Sanoe"),
					new TableRow(79, 80,  "Satina"),
					new TableRow(81, 82,  "Tahia"),
					new TableRow(83, 84,  "Tasi"),
					new TableRow(85, 86,  "Tiaho"),
					new TableRow(87, 88,  "Tihani"),
					new TableRow(89, 90,  "Toroa"),
					new TableRow(91, 92,  "Ulanni"),
					new TableRow(93, 94,  "Uluwehi"),
					new TableRow(95, 96,  "Vaina"),
					new TableRow(97, 98,  "Waiola"),
					new TableRow(99, 100, "Waitara"),
					});

					public static readonly Table human_polynesian_male_names = new Table("Male Polynesian Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
					{
					new TableRow(1, 2,    "Afa"),
					new TableRow(3, 4,    "Ahohako"),
					new TableRow(5, 6,    "Aisake"),
					new TableRow(7, 8,    "Aleki"),
					new TableRow(9, 10,   "Anewa"),
					new TableRow(11, 12,  "Anitelu"),
					new TableRow(13, 14,  "Aputi"),
					new TableRow(15, 16,  "Ariki"),
					new TableRow(17, 18,  "Butat"),
					new TableRow(19, 20,  "Enele"),
					new TableRow(21, 22,  "Fef"),
					new TableRow(23, 24,  "Fuifui"),
					new TableRow(25, 26,  "Ha'aheo"),
					new TableRow(27, 28,  "Hanohano"),
					new TableRow(29, 30,  "Haunui"),
					new TableRow(31, 32,  "Hekili"),
					new TableRow(33, 34,  "Hiapo"),
					new TableRow(35, 36,  "Hikawera"),
					new TableRow(37, 38,  "Hanano"),
					new TableRow(39, 40,  "Ho’onani"),
					new TableRow(41, 42,  "Hoku"),
					new TableRow(43, 44,  "Hu'eu"),
					new TableRow(45, 46,  "Ina"),
					new TableRow(47, 48,  "Itu"),
					new TableRow(49, 50,  "Ka'aukai"),
					new TableRow(51, 52,  "Ka'eo"),
					new TableRow(53, 54,  "Kaelani"),
					new TableRow(55, 56,  "Kahale"),
					new TableRow(57, 58,  "Kaiea"),
					new TableRow(59, 60,  "Kaikoa"),
					new TableRow(61, 62,  "Kana'l"),
					new TableRow(63, 64,  "Koamalu"),
					new TableRow(65, 66,  "Ka"),
					new TableRow(67, 68,  "Laki"),
					new TableRow(69, 70,  "Makai"),
					new TableRow(71, 72,  "Manu"),
					new TableRow(73, 74,  "Manuka"),
					new TableRow(75, 76,  "Nui"),
					new TableRow(77, 78,  "Pono"),
					new TableRow(79, 80,  "Popoki"),
					new TableRow(81, 82,  "Ruru"),
					new TableRow(83, 84,  "Tahu"),
					new TableRow(85, 86,  "Taurau"),
					new TableRow(87, 88,  "Tuala"),
					new TableRow(89, 90,  "Turoa"),
					new TableRow(91, 92,  "Tusitala"),
					new TableRow(93, 94,  "Uaine"),
					new TableRow(95, 96,  "Waata"),
					new TableRow(97, 98,  "Waipuna"),
					new TableRow(99, 100, "Zamar"),
					});

					public static readonly Table human_roman_female_names = new Table("Female Roman Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
					{
					new TableRow(1, 2,    "Aelia"),
					new TableRow(3, 4,    "Aemilia"),
					new TableRow(5, 6,    "Agrippina"),
					new TableRow(7, 8,    "Alba"),
					new TableRow(9, 10,   "Antonia"),
					new TableRow(11, 12,  "Aquila"),
					new TableRow(13, 14,  "Augusta"),
					new TableRow(15, 16,  "Aurelia"),
					new TableRow(17, 18,  "Balbina"),
					new TableRow(19, 20,  "Blandina"),
					new TableRow(21, 22,  "Caelia"),
					new TableRow(23, 24,  "Camilla"),
					new TableRow(25, 26,  "Casia"),
					new TableRow(27, 28,  "Claudia"),
					new TableRow(29, 30,  "Cloelia"),
					new TableRow(31, 32,  "Domitia"),
					new TableRow(33, 34,  "Drusa"),
					new TableRow(35, 36,  "Fabia"),
					new TableRow(37, 38,  "Fabricia"),
					new TableRow(39, 40,  "Fausta"),
					new TableRow(41, 42,  "Flavia"),
					new TableRow(43, 44,  "Floriana"),
					new TableRow(45, 46,  "Fulvia"),
					new TableRow(47, 48,  "Germana"),
					new TableRow(49, 50,  "Glaucia"),
					new TableRow(51, 52,  "Gratiana"),
					new TableRow(53, 54,  "Hadriana"),
					new TableRow(55, 56,  "Hermina"),
					new TableRow(57, 58,  "Horatia"),
					new TableRow(59, 60,  "Hortensia"),
					new TableRow(61, 62,  "Iovita"),
					new TableRow(63, 64,  "Lulia"),
					new TableRow(65, 66,  "Laelia"),
					new TableRow(67, 68,  "Laurentia"),
					new TableRow(69, 70,  "Livia"),
					new TableRow(71, 72,  "Longina"),
					new TableRow(73, 74,  "Lucilla"),
					new TableRow(75, 76,  "Lucretia"),
					new TableRow(77, 78,  "Marcella"),
					new TableRow(79, 80,  "Marcia"),
					new TableRow(81, 82,  "Maxima"),
					new TableRow(83, 84,  "Nona"),
					new TableRow(85, 86,  "Octavia"),
					new TableRow(87, 88,  "Paulina"),
					new TableRow(89, 90,  "Petronia"),
					new TableRow(91, 92,  "Porcia"),
					new TableRow(93, 94,  "Tacita"),
					new TableRow(95, 96,  "Tullia"),
					new TableRow(97, 98,  "Verginia"),
					new TableRow(99, 100, "Vita"),
					});

					public static readonly Table human_roman_male_names = new Table("Male Roman Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 190, new TableRow[]
					{
					new TableRow(1, 2,    "Aelius"),
					new TableRow(3, 4,    "Aetius"),
					new TableRow(5, 6,    "Agrippa"),
					new TableRow(7, 8,    "Albanus"),
					new TableRow(9, 10,   "Albus"),
					new TableRow(11, 12,  "Antonius"),
					new TableRow(13, 14,  "Appius"),
					new TableRow(15, 16,  "Aquilinus"),
					new TableRow(17, 18,  "Atilus"),
					new TableRow(19, 20,  "Augustus"),
					new TableRow(21, 22,  "Aurelius"),
					new TableRow(23, 24,  "Avitus"),
					new TableRow(25, 26,  "Balbus"),
					new TableRow(27, 28,  "Blandus"),
					new TableRow(29, 30,  "Blasius"),
					new TableRow(31, 32,  "Brutus"),
					new TableRow(33, 34,  "Caelius"),
					new TableRow(35, 36,  "Caius"),
					new TableRow(37, 38,  "Casian"),
					new TableRow(39, 40,  "Cassius"),
					new TableRow(41, 42,  "Cato"),
					new TableRow(43, 44,  "Celsus"),
					new TableRow(45, 46,  "Claudius"),
					new TableRow(47, 48,  "Cloelius"),
					new TableRow(49, 50,  "Cnaeus"),
					new TableRow(51, 52,  "Crispus"),
					new TableRow(53, 54,  "Cyprianus"),
					new TableRow(55, 56,  "Diocletianus"),
					new TableRow(57, 58,  "Egnatius"),
					new TableRow(59, 60,  "Ennius"),
					new TableRow(61, 62,  "Fabricius"),
					new TableRow(63, 64,  "Faustus"),
					new TableRow(65, 66,  "Gaius"),
					new TableRow(67, 68,  "Germanus"),
					new TableRow(69, 70,  "Gnaeus"),
					new TableRow(71, 72,  "Horatius"),
					new TableRow(73, 74,  "Iovianus"),
					new TableRow(75, 76,  "Iulius"),
					new TableRow(77, 78,  "Lucilius"),
					new TableRow(79, 80,  "Manius"),
					new TableRow(81, 82,  "Marcus"),
					new TableRow(83, 84,  "Marius"),
					new TableRow(85, 86,  "Maximus"),
					new TableRow(87, 88,  "Octavius"),
					new TableRow(89, 90,  "Paulus"),
					new TableRow(91, 92,  "Quintilian"),
					new TableRow(93, 94,  "Regulus"),
					new TableRow(95, 96,  "Servius"),
					new TableRow(97, 98,  "Tacitus"),
					new TableRow(99, 100, "Varius"),
					});

					public static readonly Table human_slavic_female_names = new Table("Female Slavic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 191, new TableRow[]
					{
					new TableRow(1, 2,    "Agripina"),
					new TableRow(3, 4,    "Anastasiya"),
					new TableRow(5, 6,    "Bogdana"),
					new TableRow(7, 8,    "Boleslava"),
					new TableRow(9, 10,   "Bozhena"),
					new TableRow(11, 12,  "Danica"),
					new TableRow(13, 14,  "Darya"),
					new TableRow(15, 16,  "Desislava"),
					new TableRow(17, 18,  "Dragoslava"),
					new TableRow(19, 20,  "Dunja"),
					new TableRow(21, 22,  "Efrosinia"),
					new TableRow(23, 24,  "Ekaterina"),
					new TableRow(25, 26,  "Elena"),
					new TableRow(27, 28,  "Faina"),
					new TableRow(29, 30,  "Galina"),
					new TableRow(31, 32,  "Irina"),
					new TableRow(33, 34,  "Iskra"),
					new TableRow(35, 36,  "Jasna"),
					new TableRow(37, 38,  "Katarina"),
					new TableRow(39, 40,  "Katya"),
					new TableRow(41, 42,  "Kresimira"),
					new TableRow(43, 44,  "Lyudmila"),
					new TableRow(45, 46,  "Magda"),
					new TableRow(47, 48,  "Mariya"),
					new TableRow(49, 50,  "Militsa"),
					new TableRow(51, 52,  "Miloslava"),
					new TableRow(53, 54,  "Mira"),
					new TableRow(55, 56,  "Miroslava"),
					new TableRow(57, 58,  "Mokosh"),
					new TableRow(59, 60,  "Morana"),
					new TableRow(61, 62,  "Natasha"),
					new TableRow(63, 64,  "Nika"),
					new TableRow(65, 66,  "Olga"),
					new TableRow(67, 68,  "Rada"),
					new TableRow(69, 70,  "Radoslava"),
					new TableRow(71, 72,  "Raisa"),
					new TableRow(73, 74,  "Slavitsa"),
					new TableRow(75, 76,  "Sofiya"),
					new TableRow(77, 78,  "Stanislava"),
					new TableRow(79, 80,  "Svetlana"),
					new TableRow(81, 82,  "Tatyana"),
					new TableRow(83, 84,  "Tomislava"),
					new TableRow(85, 86,  "Veronika"),
					new TableRow(87, 88,  "Vesna"),
					new TableRow(89, 90,  "Vladimira"),
					new TableRow(91, 92,  "Yaroslava"),
					new TableRow(93, 94,  "Yelena"),
					new TableRow(95, 96,  "Zaria"),
					new TableRow(97, 98,  "Zarya"),
					new TableRow(99, 100, "Zoria"),
					});

					public static readonly Table human_slavic_male_names = new Table("Male Slavic Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 191, new TableRow[]
					{
					new TableRow(1, 2,    "Aleksandru"),
					new TableRow(3, 4,    "Berislav"),
					new TableRow(5, 6,    "Blazh"),
					new TableRow(7, 8,    "Bogumir"),
					new TableRow(9, 10,   "Boguslav"),
					new TableRow(11, 12,  "Borislav"),
					new TableRow(13, 14,  "Bozhidar"),
					new TableRow(15, 16,  "Bratomil"),
					new TableRow(17, 18,  "Bratoslav"),
					new TableRow(19, 20,  "Bronislav"),
					new TableRow(21, 22,  "Chedomir"),
					new TableRow(23, 24,  "Chestibor"),
					new TableRow(25, 26,  "Chestirad"),
					new TableRow(27, 28,  "Chestislav"),
					new TableRow(29, 30,  "Desilav"),
					new TableRow(31, 32,  "Dmitrei"),
					new TableRow(33, 34,  "Dobromil"),
					new TableRow(35, 36,  "Dobroslav"),
					new TableRow(37, 38,  "Dragomir"),
					new TableRow(39, 40,  "Dragutin"),
					new TableRow(41, 42,  "Drazhan"),
					new TableRow(43, 44,  "Gostislav"),
					new TableRow(45, 46,  "Kazimir"),
					new TableRow(47, 48,  "Kyrilu"),
					new TableRow(49, 50,  "Lyubomir"),
					new TableRow(51, 52,  "Mechislav"),
					new TableRow(53, 54,  "Milivoj"),
					new TableRow(55, 56,  "Milosh"),
					new TableRow(57, 58,  "Mstislav"),
					new TableRow(59, 60,  "Nikola"),
					new TableRow(61, 62,  "Ninoslav"),
					new TableRow(63, 64,  "Premislav"),
					new TableRow(65, 66,  "Radomir"),
					new TableRow(67, 68,  "Radovan"),
					new TableRow(69, 70,  "Ratimir"),
					new TableRow(71, 72,  "Rostislav"),
					new TableRow(73, 74,  "Slavomir"),
					new TableRow(75, 76,  "Stanislav"),
					new TableRow(77, 78,  "Svetoslav"),
					new TableRow(79, 80,  "Tomislav"),
					new TableRow(81, 82,  "Vasili"),
					new TableRow(83, 84,  "Velimir"),
					new TableRow(85, 86,  "Vladimir"),
					new TableRow(87, 88,  "Vladislav"),
					new TableRow(89, 90,  "Vlastimir"),
					new TableRow(91, 92,  "Volodimeru"),
					new TableRow(93, 94,  "Vratislav"),
					new TableRow(95, 96,  "Yarognev"),
					new TableRow(97, 98,  "Yaromir"),
					new TableRow(99, 100, "Zbignev"),
					});

					public static readonly Table human_spanish_female_names = new Table("Female Spanish Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 192, new TableRow[]
					{
					new TableRow(1, 2,    "Abella"),
					new TableRow(3, 4,    "Adalina"),
					new TableRow(5, 6,    "Adora"),
					new TableRow(7, 8,    "Adriana"),
					new TableRow(9, 10,   "Ana"),
					new TableRow(11, 12,  "Antonia"),
					new TableRow(13, 14,  "Basilia"),
					new TableRow(15, 16,  "Beatriz"),
					new TableRow(17, 18,  "Bonita"),
					new TableRow(19, 20,  "Camila"),
					new TableRow(21, 22,  "Cande"),
					new TableRow(23, 24,  "Carmen"),
					new TableRow(25, 26,  "Catlina"),
					new TableRow(27, 28,  "Dolores"),
					new TableRow(29, 30,  "Dominga"),
					new TableRow(31, 32,  "Dorotea"),
					new TableRow(33, 34,  "Elena"),
					new TableRow(35, 36,  "Elicia"),
					new TableRow(37, 38,  "Esmerelda"),
					new TableRow(39, 40,  "Felipina"),
					new TableRow(41, 42,  "Francisca"),
					new TableRow(43, 44,  "Gabriela"),
					new TableRow(45, 46,  "Imelda"),
					new TableRow(47, 48,  "Ines"),
					new TableRow(49, 50,  "Isabel"),
					new TableRow(51, 52,  "Juana"),
					new TableRow(53, 54,  "Leocadia"),
					new TableRow(55, 56,  "Leonor"),
					new TableRow(57, 58,  "Leta"),
					new TableRow(59, 60,  "Lucinda"),
					new TableRow(61, 62,  "Maresol"),
					new TableRow(63, 64,  "Maria"),
					new TableRow(65, 66,  "Maricela"),
					new TableRow(67, 68,  "Matilde"),
					new TableRow(69, 70,  "Melania"),
					new TableRow(71, 72,  "Monica"),
					new TableRow(73, 74,  "Neva"),
					new TableRow(75, 76,  "Nilda"),
					new TableRow(77, 78,  "Petrona"),
					new TableRow(79, 80,  "Rafaela"),
					new TableRow(81, 82,  "Ramira"),
					new TableRow(83, 84,  "Rosario"),
					new TableRow(85, 86,  "Sofia"),
					new TableRow(87, 88,  "Suelo"),
					new TableRow(89, 90,  "Teresa"),
					new TableRow(91, 92,  "Tomasa"),
					new TableRow(93, 94,  "Valentia"),
					new TableRow(95, 96,  "Veronica"),
					new TableRow(97, 98,  "Ynes"),
					new TableRow(99, 100, "Ysabel"),
					});

					public static readonly Table human_spanish_male_names = new Table("Male Spanish Names", "Name", Data.Rolls_String.d100, "", Data.Titles.XGE, 192, new TableRow[]
					{
					new TableRow(1, 2,    "Alexandre"),
					new TableRow(3, 4,    "Alfonso"),
					new TableRow(5, 6,    "Alonso"),
					new TableRow(7, 8,    "Anthon"),
					new TableRow(9, 10,   "Arcos"),
					new TableRow(11, 12,  "Arnaut"),
					new TableRow(13, 14,  "Arturo"),
					new TableRow(15, 16,  "Bartoleme"),
					new TableRow(17, 18,  "Benito"),
					new TableRow(19, 20,  "Bernat"),
					new TableRow(21, 22,  "Blasco"),
					new TableRow(23, 24,  "Carlos"),
					new TableRow(25, 26,  "Damian"),
					new TableRow(27, 28,  "Diego"),
					new TableRow(29, 30,  "Domingo"),
					new TableRow(31, 32,  "Enrique"),
					new TableRow(33, 34,  "Escobar"),
					new TableRow(35, 36,  "Ettor"),
					new TableRow(37, 38,  "Fernando"),
					new TableRow(39, 40,  "Francisco"),
					new TableRow(41, 42,  "Gabriel"),
					new TableRow(43, 44,  "Garcia"),
					new TableRow(45, 46,  "Gaspar"),
					new TableRow(47, 48,  "Gil"),
					new TableRow(49, 50,  "Gomes"),
					new TableRow(51, 52,  "Goncalo"),
					new TableRow(53, 54,  "Gostantin"),
					new TableRow(55, 56,  "Jayme"),
					new TableRow(57, 58,  "Joan"),
					new TableRow(59, 60,  "Jorge"),
					new TableRow(61, 62,  "Jose"),
					new TableRow(63, 64,  "Juan"),
					new TableRow(65, 66,  "Machin"),
					new TableRow(67, 68,  "Martin"),
					new TableRow(69, 70,  "Mateu"),
					new TableRow(71, 72,  "Miguel"),
					new TableRow(73, 74,  "Nicolas"),
					new TableRow(75, 76,  "Pascual"),
					new TableRow(77, 78,  "Pedro"),
					new TableRow(79, 80,  "Porico"),
					new TableRow(81, 82,  "Ramiro"),
					new TableRow(83, 84,  "Ramon"),
					new TableRow(85, 86,  "Rodrigo"),
					new TableRow(87, 88,  "Sabastian"),
					new TableRow(89, 90,  "Salvador"),
					new TableRow(91, 92,  "Simon"),
					new TableRow(93, 94,  "Tomas"),
					new TableRow(95, 96,  "Tristan"),
					new TableRow(97, 98,  "Valeriano"),
					new TableRow(99, 100, "Ynigo"),
					});
				}
			}
		}
		
	}
}