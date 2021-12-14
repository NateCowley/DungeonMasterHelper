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
					new TableRow(1,     TableRow.NOVALUE,       "Employer. An established member of local society acts as the interface between you and the patron and provides the cover of legitimate emlpoyment. They could be a bartender, shopkeeper, local official, or noble."),
					new TableRow(2,     TableRow.NOVALUE,       "Back-Room Dealers. An exclusive area in an otherwise-ordinary establishment requires a password or token to gain entry. There you meet and communicate with shadowy agents of your patron."),
					new TableRow(3,     TableRow.NOVALUE,       "Magical Message Drop. Magically recorded messages from your contact or your patron appear in odd places. You know to check a predetermined location, such as a crack in an ancient monolith or a specific grave, for instructions."),
					new TableRow(4,     TableRow.NOVALUE,       "Visions. Your patron doesn't use intermediaries, instead speaking to you in dreams, omens, or visions. The being appears in your mind as you sleep, taking control of your dreams to deliver instructions that become difficult to ignore."),
					new TableRow(5,     TableRow.NOVALUE,       "Ephemeral Echo. Your contact never physically reveals itself to you. Perhaps it is the ghost of a dead person, an entity that appears outside the flow of time, or a projected illusion of a being that never leaves your patron's hidden sanctum."),
					new TableRow(6,     TableRow.NOVALUE,       "The Mouthpiece. The ancient being's voice whispers through the lips of an ordinary person. Your patron might possess the body of a stranger or a party member to converse with you."),
				});

				public static readonly Table ancient_being_quests = new Table("Ancient Being Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 88, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Rescue. A wayward agent went missing while gathering information or materials. You must discover their fat and recover them and their findings."),
					new TableRow(2,     TableRow.NOVALUE,       "Sabotage. You must destroy an aspect of a rival's organization, either assassinating a key minion or destroying a critical object."),
					new TableRow(3,     TableRow.NOVALUE,       "Artifice. Your specialized skills are instrumental to assembling components for a powerful magic ritual or object."),
					new TableRow(4,     TableRow.NOVALUE,       "Treachery. A high-profile minion of another powerful figure is in a position to betray their master, to the benefit of your patron. You must convince them to defect to your organization or extract them from now-hostile territory."),
					new TableRow(5,     TableRow.NOVALUE,       "Culling. A respected agent of your patron (possibly an ally or a mentor for your group) has been compromised. Perhaps they are defecting to a rival, attempting to seize the ancient being's power. Whatever the case, you must catch them to end their threat."),
					new TableRow(6,     TableRow.NOVALUE,       "Astral Heist. A powerful rival of your patron stores their secrets in a mind vault on the Astral Plane. That means they can't be tricked or coerced into revealing anything, nor can their thoughts be read. You must find the vault and travel through the rival's deadly memories to find the knowledge your patron desires."),
				});

				public static readonly Table aristocrat_types = new Table("Aristocrat Types", "Aristocrats", Data.Rolls_String.d6, "", Data.Titles.TCE, 89, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Local Lord. Convinced that power and prestige lie just around the corner, this minor lordling grasps for every opportunity to climb the ranks."),
					new TableRow(2,     TableRow.NOVALUE,       "Merchant Mastermind. Reputation, wealth, and power are one and the same for the head of a family with world-spanning business holdings."),
					new TableRow(3,     TableRow.NOVALUE,       "Nomadic Princeling. Nothing is more appealing to this princeling than treasure. Their sprawling merchant caravan trails behind their palanquin as far as the eye can see."),
					new TableRow(4,     TableRow.NOVALUE,       "Double Dealer. The leader of a noble family has turned against their nation, secretly opposing their liege for personal gain or ethical reasons."),
					new TableRow(5,     TableRow.NOVALUE,       "Ambitious Entrepreneur. The sole heir of a vast fortune, this entrepreneur seeks allies to expand their wealth in a new business on the international, global, or planar stage."),
					new TableRow(6,     TableRow.NOVALUE,       "Future Ruler. This young noble is destined to rule, but currently their whims are fickle and dangerous."),
				});

				public static readonly Table aristocrat_contact = new Table("Aristocrat Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 90, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Common Contact. A servant with ambitions toward a title works as a go-between for your patron."),
					new TableRow(2,     TableRow.NOVALUE,       "Professional. A level-headed advisor or manager of your patron's business directs you in keeping their reckless employer safe."),
					new TableRow(3,     TableRow.NOVALUE,       "Family Peacemaker. A naive aristocrat appointed by your patron wants your assistance in keeping the peace between fractious family members, which isn't your patron's priority."),
					new TableRow(4,     TableRow.NOVALUE,       "Intimate Connection. A common-born confidant or lover of your patron guides you in creating circumstances to bolster the noble family's best interests."),
					new TableRow(5,     TableRow.NOVALUE,       "Outside Insider. An outcast noble favored by your patron works with you to uphold their family's interests despite their exile."),
					new TableRow(6,     TableRow.NOVALUE,       "Outsider Inside. A mysterious entity manipulates a noble family's fortunes. Through your patron, it employs you to help guide its chosen family along a centuries-long course."),
				});

				public static readonly Table aristocrat_quests = new Table("Aristocrat Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 90, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Noble Union. You work within multiple noble factions to unite rival families."),
					new TableRow(2,     TableRow.NOVALUE,       "Business Breakthrough. You track down and obtain a wonder your patron believes is the key to their financial fortunes."),
					new TableRow(3,     TableRow.NOVALUE,       "Sabotage Rival. You break into the business or estate of an enemy noble family and undermine their political or professional ventures."),
					new TableRow(4,     TableRow.NOVALUE,       "Lost Lineage. You seek evidence of a lost branch of a noble family or proof that individuals don't possess a noble pedigree."),
					new TableRow(5,     TableRow.NOVALUE,       "Origin of Nobility. You reveal the secret reason why certain individuals were elevated to noble status and how they will soon fulfill their purpose."),
					new TableRow(6,     TableRow.NOVALUE,       "The New Nobility. You recreate the remarkable event that granted today's noble families their special standing, enabling the rise of new nobles."),
				});

				public static readonly Table syndicate_types = new Table("Syndicate Types", "Syndicate", Data.Rolls_String.d6, "", Data.Titles.TCE, 91, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Thieves' Guild. A disparate convocation of thieves, spies, smugglers, and other scoundrels controls criminal activity in a region of a city."),
					new TableRow(2,     TableRow.NOVALUE,       "Assassin Society. The network's livelihood is death. Members of the society hone their skills as cutthroats, poisoners, body-disposal specialists, and any other profession focused on ending lives. The society is motivated by profit or labors in service to a greater cause."),
					new TableRow(3,     TableRow.NOVALUE,       "Magical Arms Dealer. The syndicate has cornered the market on deadly magical devices. They offer their services and wares for a price and acquire staggering magical might for those who meet their demands."),
					new TableRow(4,     TableRow.NOVALUE,       "Pirate Fleet. This alliance of pirate captains is unified under a ruling captain or admiral and adheres to a strict code of honor. They converge only in response to an outside threat."),
					new TableRow(5,     TableRow.NOVALUE,       "Body Snatchers. The syndicate consists predominantly, if not entirely, of creatures that possess or impersonate other people. They seek to replace influential individuals throughout society with members of their ranks."),
					new TableRow(6,     TableRow.NOVALUE,       "Thought Thieves. These psychic criminals infiltrate their target's minds to steal secrets and disguise their existence."),
				});

				public static readonly Table syndicate_contact = new Table("Syndicate Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 92, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Personal Mentor. This longtime member of the syndicate took you under their wing when you were young and became a parental figure."),
					new TableRow(2,     TableRow.NOVALUE,       "Clever Urchin. An innocuous person, perhaps a beggar or menial laborer, knows all the right people and shares their connections with you."),
					new TableRow(3,     TableRow.NOVALUE,       "Former Law Enforcement. Your contact used to be (or maybe still is) a member of local law enforcement. They have sharp insight into the law's workings in your area and a healthy dose of paranoia for that reason."),
					new TableRow(4,     TableRow.NOVALUE,       "Bon Vivant. The boss of a local den of vice -- whether gambling, narcotics, or other pleasures -- aids you when they're not distracted by their own debauchery."),
					new TableRow(5,     TableRow.NOVALUE,       "Traitor. You know your contact in the syndicate has betrayed it, but they have enough clout and leverage that you don't dare cross them -- yet."),
					new TableRow(6,     TableRow.NOVALUE,       "Criminal Royalty. Unkown to most, your contact is a member of local nobility or royalty. Why they maintain relations with the syndicate is a troubling mystery."),
				});

				public static readonly Table criminal_syndicate_quests = new Table("Criminal Syndicate Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 93, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Acquisition and Retrieval. You acquire assets for the syndicate. You steal import documents or clear out locations for use as hideouts."),
					new TableRow(2,     TableRow.NOVALUE,       "Heists. You plan and execute elaborate robberies that require the combined skills of your team."),
					new TableRow(3,     TableRow.NOVALUE,       "Gang Warfare. You ensure that no other crime syndicate gains a significant foothold in your territory."),
					new TableRow(4,     TableRow.NOVALUE,       "Enforcement. You keep the corrupt, headstrong, and avaricious members of your syndicate in line with the goals and rules of the organization."),
					new TableRow(5,     TableRow.NOVALUE,       "Assassination. You dispatch prominent people -- the sort who have numerous bodyguards and elaborate security systems to circumvent."),
					new TableRow(6,     TableRow.NOVALUE,       "Topple the Powerful. Your syndicate is criminal and your methods illegal, but your goals are righteous. You help people who are powerless against exploitation by the powerful."),
				});

				public static readonly Table guild_types = new Table("Guild Types", "Guild", Data.Rolls_String.d6, "", Data.Titles.TCE, 93, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Crafters' Guild. This conglomerate of artisans pools its resources and influence to ensure a steady exchange of gold for its crafts."),
					new TableRow(2,     TableRow.NOVALUE,       "Merchant Consortium. These entrepreneurs don't create the wares they peddle, instead specializing in linking products to prospective owners. If they don't have it, they find it."),
					new TableRow(3,     TableRow.NOVALUE,       "Miracle Makers' Association. The magically inclined crafters of this guild specialize in imbuing physical goods with magical effects. Rumor has it they can strip the magic from existing enchanted items and might be willing to buy or trade adventurers' spoils."),
					new TableRow(4,     TableRow.NOVALUE,       "Moneychangers. These merchants deal in all forms of currency, acting as bankers, loan agents, and crucial contacts for adventurers and other individuals who deal with large sums of wealth. They exchange coin for gemstones as readily as they find buyers for historical relics and recovered art."),
					new TableRow(5,     TableRow.NOVALUE,       "Philosophical Faction. These like-minded individuals follow specific teachings, spreading word of their expertise through their services and training."),
					new TableRow(6,     TableRow.NOVALUE,       "Identity Traders. These enigmatic dealers buy and sell documents, memories, and the trappings of thoroughly lived lives, selling them to those in need of the ultimate fresh start."),
				});

				public static readonly Table guild_contact = new Table("Guild Contact", "Contact", Data.Rolls_String.d6, "", Data.Titles.TCE, 95, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "The Perfectionist. Your contact is a skilled but obsessive creator consumed with the quest to create something perfect that will define their life's work and secure their legacy. They lose sight of right and wrong in pursuit of the finest materials and exciting opportunities."),
					new TableRow(2,     TableRow.NOVALUE,       "Attentive Overseer. A guild representative takes personal interest in your group's tasks. They follow your exploits and know of your adventures before you return to report. Despite the unsettling depth of their knowledge, they seem genuinely eager to shepherd your work."),
					new TableRow(3,     TableRow.NOVALUE,       "Hidden Benefactor. Whoever yoru contact is, they don't communicate directly. They send messages via couriers or letters. No one in the guild knows who the contact is, or if they do, they aren't telling you. Regardless, the contact's information is good, and they pay on time."),
					new TableRow(4,     TableRow.NOVALUE,       "Discerning Mentor. No matter how well you perform, or how perfect your creations, nothing is ever good enough for this contact. They point out every flaw and missed opportunity. Are they bitter, lashing out at anyone around them, or do they recognize your potential and try to push you to greatness?"),
					new TableRow(5,     TableRow.NOVALUE,       "Golem Guide. Your guild contact is the sould of a long-dead artisan preserved in a construct body. This golem is wise and knowledgeable, but it has difficulty grasping the passage of time and the state of the world compared to its original era."),
					new TableRow(6,     TableRow.NOVALUE,       "Fallen Muse. Your contact is a fallen celestial. Whether they regret their transgressions or hunger for vengeance, they provide divine insipration and guidance to you and to the guild. Somehow your group and the guild inspire their hope for ascension."),
				});

				public static readonly Table guild_quests = new Table("Guild Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 95, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Deliver Goods. You need to deliver an order to an important customer or partner of the guild. The deliveery must arrive by a critical deadline -- regardless of who or what tries to stop you."),
					new TableRow(2,     TableRow.NOVALUE,       "Acquire Materials. Your guild requires materials that are rare and difficult to procure, either for a guild project or for a paying client. Your group must gather the missing components from a dangerous location or a recalcitrant owner while outpacing a rival to the prize."),
					new TableRow(3,     TableRow.NOVALUE,       "Eliminate a Rival. A competitor has humiliated the guild one too many times, and it's time for that to stop. Your group is charged with assuring the rival never darkens the guild's reputation again. Can you trick them into permanent disgrace, or must you resort to more direct methods?"),
					new TableRow(4,     TableRow.NOVALUE,       "The Masterpiece. An exquisite work of art for an influential client, either created by your guild or acquired through agents, has gone missing. You must track down its whereabouts and secure it before time runs out and the guild suffers a penalty."),
					new TableRow(5,     TableRow.NOVALUE,       "The Collector. Your guild is tasked to create or acquire something wondrous for a wealthy but secretive client's collection. Guild members who previously failed to fulfill this assignment ended up missing. The collector promises to return your comrades if you provide what the collector seeks, but if you fail, you'll become part of the collection."),
					new TableRow(6,     TableRow.NOVALUE,       "The Bill Comes Due. Your guild master achieved their vaunted position by means of an otherworldly bargain. That price has come due, and they are desperate to avoid paying. You must defeat whatever's coming to collect the master's debt or find another acceptable payment."),
				});

				public static readonly Table military_force_types = new Table("Military Force Types", "Military Organization", Data.Rolls_String.d6, "", Data.Titles.TCE, 96, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Standing Army. A standing army serves as the highly sidciplined nad structured guardian of a province or an entire nation. Strict tiers of command ensure coordination between branches of the force."),
					new TableRow(2,     TableRow.NOVALUE,       "Mercenary Company. Hard-bitten veterans of numerous conflicts, mercenaries serve an employer for coin rather than out of loyalty."),
					new TableRow(3,     TableRow.NOVALUE,       "Expeditionary Force. This military force is far from home, fighting behind enemy lines or striking into wild, unsettled lands. The force must be fast, self-sufficient, and either diplomatic or decisive to assure their survival."),
					new TableRow(4,     TableRow.NOVALUE,       "Horde. The horde is almost a force of nature, and what it lacks in discipline it makes up in ferocity. It doesn't have a rigid command structure, instead functioning like a pyramid of smaller armies. Horde commanders owe fealty to stronger leaders above them, all the way up to the warlord."),
					new TableRow(5,     TableRow.NOVALUE,       "Planar Conscripts. This military force battles for cosmic stakes on far-flung planes of the multiverse or fights against extraplanar invasion on the Material Plane. Warriors include conscripts pressed into service in the Blood War, fodder in the thrall of ruthless yugoloth mercenaries, or memebrs of a glorious celestial host defending against fiendish incursion."),
					new TableRow(6,     TableRow.NOVALUE,       "Sky Warriors. This military force consists of winged creatures, employs magical flight, or sails airships as a sky navy. Traditional defenses are ineffective against attacks from the air, positioning the sky warriors as a fearsome nation or expensive and coveted mercenaries."),
				});

				public static readonly Table military_force_contact = new Table("Commanding Officer", "Officer", Data.Rolls_String.d6, "", Data.Titles.TCE, 97, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Tested Veteran. Your commander is a battle-scarred officer who experienced horrors in combat. They rely on something to dull the pain of their memories or wounds, from a favorite writer's prose to a distracting vice."),
					new TableRow(2,     TableRow.NOVALUE,       "Taskmaster. This a ngry officer yells every order, reprimands you for the smallest mistake, and fully expects you to fail at every mission you undertake. This might be tough love or simple brutishness."),
					new TableRow(3,     TableRow.NOVALUE,       "Protective Officer. A kindly officer is hesitant to send you into danger and constantly reminds you to be careful."),
					new TableRow(4,     TableRow.NOVALUE,       "Bitter Soldier. Your commander carries deep grudges against your force's enemies. They leap at any chance to do those foes harm, even if it puts your group in terrible risk."),
					new TableRow(5,     TableRow.NOVALUE,       "Hopeful Commander. This optimistic officer knows that a new era of peace is just over the horizon. You just need to complete these last few missions, then it should all finally be over."),
					new TableRow(6,     TableRow.NOVALUE,       "Devout Leader. Your commander is a person of deep faith. They believe that your success or failure lies entirely in divine hands and you are the instruments of that will."),
				});

				public static readonly Table military_quests = new Table("Military Quests", "Quest", Data.Rolls_String.d6, "", Data.Titles.TCE, 98, new TableRow[]
				{
					new TableRow(1,     TableRow.NOVALUE,       "Strike Force. You undertake a quick, strategic, and devastating attack against an enemy force."),
					new TableRow(2,     TableRow.NOVALUE,       "Defensive Operations. You must preserve the safety of an important location such as a civilian population center, a supply depot, or strategically critical bridge or seaport."),
					new TableRow(3,     TableRow.NOVALUE,       "Special Forces. You are assigned to a covert operation behind enemy lines. This is similar to the work of a spy or an assassin but with a broader scope. You engage in equipment sabotage or execute targeted strikes against high-value targets."),
					new TableRow(4,     TableRow.NOVALUE,       "Reconnaissance. You gather information on enemy troop numbers, placements, movement, or supply caches and routes."),
					new TableRow(5,     TableRow.NOVALUE,       "Seek and Destroy. You are res ponsible for hunting down specific high-value and dangerous targets, which include deserters, suspected enemy special forces, or magical war machines run amok."),
					new TableRow(6,     TableRow.NOVALUE,       "Siege. You are assigned to initiate a siege on an enemy stronghold or help break a siege in progress on an allied fortress."),
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
