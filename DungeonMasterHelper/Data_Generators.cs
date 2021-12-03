using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DungeonMasterHelper
{
	public static partial class RandomGenerators
	{
		public static string alchemyIngredient()
		{
			string[] nm1 = { "Abyss", "Aching", "Aged", "Agony", "Alpha", "Anarchy", "Angel", "Angel's", "Angelic", "Anxious", "Aquatic", "Arching", "Arctic", "Aromatic", "Ash", "Assassin", "Autumn", "Baleful", "Banshee", "Barbed", "Basilisk", "Belch", "Belching", "Berserker", "Bitter", "Black", "Bleak", "Bleeding", "Blight", "Blind", "Blinded", "Blister", "Blistering", "Bloat", "Bloating", "Blood", "Blue", "Bold", "Bone", "Boomerang", "Bouncing", "Brain", "Bright", "Bronze", "Brown", "Bruise", "Burning", "Candied", "Candy", "Caramelized", "Cave", "Cavern", "Chaos", "Cherub", "Child's", "Chilling", "Chimera", "Cinder", "Cipher", "Cliff", "Cold", "Congealed", "Corrupt", "Corrupted", "Corrupting", "Coughing", "Crawling", "Creeping", "Crimson", "Crying", "Crystal", "Crystallized", "Cursed", "Cyst", "Daemon", "Dancing", "Dark", "Dawn", "Daydream", "Deadly", "Death's", "Delicious", "Demon", "Demon's", "Demonic", "Devil", "Devil's", "Dim", "Dire", "Divine", "Doom", "Dragon", "Drake", "Dream", "Dried", "Drifting", "Drowsy", "Dull", "Dusk", "Dwarf", "Dying", "Eagle", "Earth", "Ebon", "Eerie", "Electrified", "Elephant", "Ember", "Emerald", "Entropy", "Eternal", "Ethereal", "Execution", "Fade", "Fading", "Fake", "Fanged", "Fatal", "Fatigue", "Fear", "Fearful", "Fermented", "Fever", "Fey", "Fiendish", "Fiery", "Final", "Fire", "Fjord", "Flame", "Flux", "Flying", "Forbidden", "Forest", "Forlorn", "Fragrant", "Frost", "Frozen", "Funeral", "Funky", "Fury", "Futile", "Gall", "Ghost", "Giant", "Glacier", "Gloom", "Glowing", "Goblin", "Golden", "Grand", "Grave", "Gray", "Green", "Grim", "Ground", "Grumpy", "Hag's", "Hammer", "Happy", "Harmless", "Hate", "Hazel", "Heart", "Hellish", "Hemorrhage", "Hibernation", "Hidden", "Hollow", "Hopeless", "Horned", "Hot", "Hovering", "Humble", "Humming", "Hyper", "Ice", "Immortal", "Imperial", "Impossible", "Incurable", "Infecting", "Infernal", "Invisible", "Ire", "Island", "Itching", "Ivory", "Jade", "Jealous", "Jester", "Joyful", "Killing", "King's", "Knot", "Lake", "Last", "Leeching", "Lethal", "Life's", "Lion", "Liquidized", "Livid", "Lost", "Love", "Lover's", "Luminous", "Lunar", "Mage", "Mage's", "Majestic", "Malefic", "Mammoth", "Manic", "Marsh", "Medusa", "Mellow", "Mercy", "Mercy's", "Meta", "Mimic", "Mock", "Mocking", "Monk's", "Monster", "Moon", "Mortal", "Moss", "Mound", "Mountain", "Mud", "Nasty", "Naughty", "Necron", "Necrotic", "Nervous", "Nether", "Nettle", "Neutral", "Night", "Nightmare", "Nimble", "Noxious", "Numbing", "Obsidian", "Ocean", "Ogre", "Onyx", "Orange", "Ordinary", "Pandemonium", "Passion", "Peace", "Pearl", "Perfumed", "Pest", "Petrified", "Phantom", "Pink", "Piranha", "Pixy", "Plague", "Pleasant", "Poison", "Poisonous", "Prancing", "Putrid", "Pygmy", "Queen's", "Quiet", "Quivering", "Radiant", "Rage", "Rain", "Rapid", "Rare", "Rash", "Raven", "Reaper", "Red", "Regal", "Restoration", "River", "Roasted", "Rotten", "Rotting", "Royal", "Ruby", "Sad", "Salty", "Sanguine", "Sapphire", "Savage", "Scented", "Scourged", "Screaming", "Sea", "Sentient", "Serpent", "Shade", "Shadow", "Sharp", "Shield", "Shimmer", "Shocking", "Shrew", "Shrine", "Shriveling", "Shrouded", "Shy", "Silent", "Silk", "Silver", "Sinister", "Skeletal", "Skulking", "Skull", "Slag", "Sleeping", "Sleepy", "Smelly", "Smile", "Smiling", "Smooth", "Sneeze", "Sneezing", "Snowy", "Solar", "Sore", "Sorrow", "Soulless", "Sour", "Spark", "Specter", "Spewing", "Spicy", "Spider", "Spiky", "Spirit", "Spitfire", "Spring", "Sprite's", "Star", "Stiff", "Stink", "Stinking", "Stinky", "Storm", "Strangler", "Strangling", "Sugar", "Summer", "Summer's", "Sun", "Sunny", "Swamp", "Sweet", "Swelling", "Symbiotic", "Tainted", "Tall", "Tangle", "Tangled", "Taunting", "Terminal", "Thorn", "Thunder", "Tickle", "Tiger", "Tomb", "Torment", "Torture", "Toxic", "Trembling", "Tundra", "Twilight", "Twisted", "Unseen", "Urban", "Veiled", "Venom", "Venomous", "Vicious", "Vile", "Violet", "Viper", "Vision", "Vivid", "Void", "Volcano", "Vortex", "Walking", "Warm", "Water", "Weeping", "Whisper", "White", "Whomping", "Wicked", "Wild", "Winter", "Winter's", "Wisdom", "Witch's", "Wither", "Woeful", "Wolf", "Worm", "Wraith", "Yellow" };
			string[] nm2 = { "Aconite", "Ambrosia", "Angelica", "Anise", "Aniseed", "Annie", "Avens", "Azolla", "Bamboo", "Bane", "Barberry", "Bark", "Basil", "Bay Leaf", "Bean", "Bearberry", "Belladonna", "Berry", "Betty", "Bindweed", "Bite", "Bittercress", "Bittersweet", "Bitterweed", "Blade", "Blight", "Bloom", "Blossom", "Bone", "Borage", "Bower", "Boxwood", "Brass", "Brick", "Brier", "Brittlebush", "Broadleaf", "Bronze", "Bush", "Buttons", "Buxus", "Cabbage", "Cane", "Cap", "Caraway", "Cardamom", "Caress", "Cassia", "Catnip", "Celery", "Chervil", "Chicory", "Chives", "Cilantro", "Cinnamon", "Clary", "Clay", "Cloth", "Clove", "Clover", "Clutch", "Cobalt", "Collard", "Colwort", "Compound", "Coneflower", "Copper", "Coriander", "Cornel", "Cotton", "Creeper", "Cress", "Cudweed", "Cumin", "Curry Leaf", "Daisy", "Deadnettle", "Denim", "Dewberry", "Dill", "Dill Seed", "Dindle", "Dogbane", "Duscle", "Dust", "Embrace", "Fairymoss", "Felonwood", "Felonwort", "Fennel", "Fenugreek", "Fern", "Feverfew", "Fiber", "Fieldcress", "Fig", "Flax", "Fleece", "Flower", "Fluxroot", "Fumewort", "Fungus", "Fur", "Galangal", "Gallberry", "Garget", "Garlic", "Gas", "Geranium", "Gilliflower", "Ginger", "Glass", "Gold", "Goldenglow", "Grains", "Grapevine", "Grasp", "Grass", "Groundberry", "Growth", "Grudge", "Gutweed", "Hair", "Haldi", "Harlequin", "Hedge", "Hellebore", "Hemp", "Herb", "Hibiscus", "Hide", "Hogweed", "Holly", "Hops", "Horse Nettle", "Houseleek", "Huckleberry", "Hyssop", "Ink Plant", "Inkberry", "Itch", "Itchweed", "Ivy", "Jack-in-the-Bush", "Joy", "Juniper", "Kiss", "Knit", "Lace", "Laceflower", "Laurel", "Lavender", "Lead", "Leaf", "Leather", "Leaves", "Licorice", "Lilac", "Lily", "Linen", "Lock", "Log", "Lotus", "Lovage", "Mace", "Malice", "Mallow", "Marble", "Marjoram", "Metal", "Milfoil", "Milkweed", "Mint", "Mist", "Morel", "Moss", "Mulberry", "Mustard", "Mutagen", "Needle", "Nettle", "Nickel", "Nigella", "Nightshade", "Nutmeg", "Nylon", "Oregano", "Paper", "Paprika", "Parsley", "Parsnip", "Pea", "Pepper", "Peppermint", "Petal", "Pine", "Plant", "Poinsetta", "Poison", "Poisonberry", "Poisonflower", "Poke", "Pokeroot", "Pokeweed", "Polkweed", "Poppy", "Powder", "Pudina", "Quassia", "Ragweed", "Rancor", "Rantipole", "Raspberry", "Resin", "Ribwort", "Roadweed", "Rock Fern", "Root", "Rose", "Rosemary", "Rue", "Rye", "Safflower", "Saffron", "Sage", "Salt", "Sand", "Sanguinary", "Sassafras", "Satin", "Savory", "Scale", "Scratch", "Seed", "Shadblow", "Shadbush", "Shiso", "Silk", "Silkweed", "Silver", "Skin", "Skunkweed", "Smile", "Smoke", "Snakeberry", "Snowdrop", "Soil", "Sorrel", "Spearmint", "Spice", "Spine", "Spite", "Spoolwood", "Spore", "Spray", "Stalk", "Stammerwort", "Steel", "Stickweed", "Stone", "Suede", "Sugarcane", "Sugarplum", "Sumac", "Sunflower", "Swallow-wort", "Swinies", "Taint", "Tansy", "Tarragon", "Tassel", "Taste", "Tea", "Tea Leaf", "Tears", "Thimbleberry", "Thimbleweed", "Thistle", "Thorn", "Thousand-leaf", "Thyme", "Tin", "Titanium", "Tongue", "Toothwort", "Torment", "Touch", "Touch-me-not", "Toxin", "Tulip", "Tulsi", "Turmeric", "Tweed", "Twill", "Vanilla", "Velour", "Velvet", "Venom", "Vine", "Violet", "Water", "Waybread", "Weave", "Weed", "Wheat", "Wild Rose", "Windroot", "Wineberry", "Winterberry", "Wintercress", "Wood", "Woodbine", "Wool", "Wormwood", "Woundwort", "Zinc" };
			string[] nm3 = { "Angel", "Basilisk", "Behemoth", "Bugbear", "Bunyip", "Centaur", "Chimera", "Cockatrice", "Cyclops", "Daemon", "Demon", "Devil's", "Dragon", "Drake", "Dryad", "Faun's", "Ghost", "Giant's", "Goldhorn's", "Gorgon", "Griffin", "Harpy", "Hellhound", "Hippocamp's", "Hippogriff", "Hydra", "Jackalope's", "Kobold", "Lamia", "Leviathan", "Manticore", "Mermaid", "Merman", "Minotaur", "Phantom's", "Phoenix", "Qilin", "Reaper", "Roc", "Satyr", "Selkie", "Serpent", "Siren", "Sphinx's", "Strix's", "Tengu", "Undine", "Unicorn", "Urchin", "Vampire", "Werewolf", "Witch's", "Wolpertinger", "Wyvern", "Yeti" };
			string[] nm4 = { "Ashes", "Barbs", "Blood", "Bone", "Bone Meal", "Brain", "Claw", "Dust", "Ear", "Essence", "Extract", "Eye", "Fang", "Fat", "Flesh", "Gland", "Hair", "Heart", "Heart-Blood", "Honey", "Hook", "Horn", "Husk", "Ichor", "Infusion", "Innards", "Liver", "Lock", "Nail", "Oil", "Saliva", "Scale", "Shell", "Soul", "Spit", "Stalk", "Strand", "Sweat", "Talon", "Tear", "Tears", "Tongue", "Tooth", "Vein", "Venom" };
			string[] nm5 = { "Angel Feather", "Arachne's Venom", "Arachne's Web", "Banshee Essence", "Basilisk Head", "Basilisk Scale", "Bone Dust", "Centaur Hoof", "Centaur Mane", "Cerberus' Collar", "Cerberus' Tooth", "Chimera Horn", "Chimera Mane", "Chimera Tail", "Chimera Venom", "Chimera Whisker", "Cockatrice Egg", "Cockatrice Feather", "Cockatrice Head", "Cockatrice Scale", "Cyclops Eye", "Demon Blood", "Demon Essence", "Demon Horn", "Demon Skin", "Demonic Fire", "Dragon Blood", "Dragon Claw", "Dragon Egg", "Dragon Fire", "Dragon Scale", "Dryad Bark", "Elemental Essence", "Ent Bark", "Ent Root", "Fairy Dust", "Fairy Wing", "Faun Fur", "Flame Sac", "Gargoyle Dust", "Ghost Essence", "Giant Eagle Egg", "Giant Eagle Feather", "Golem Dust", "Gorgon Head", "Griffin Claw", "Griffin Fur", "Harpy Feather", "Harpy Talon", "Hellhound Fur", "Hellhound Tooth", "Hippocampus Scale", "Hippogriff Beak", "Hippogriff Claw", "Hippogriff Feather", "Hippogriff Fur", "Hydra Blood", "Hydra Scale", "Jackalope Antler", "Kelpie Hair", "Kraken Slime", "Kraken Tooth", "Lamia Hair", "Lamia Scale", "Leviathan Scale", "Mandrake Root", "Mermaid Scale", "Merman Scale", "Minotaur Hair", "Minotaur Horn", "Naga Scale", "Newt Eye", "Ogre Snot", "Pegasus Hair", "Pegasus Hoof", "Pegasus Mane", "Phoenix Ash", "Phoenix Feather", "Pixie Dust", "Roc Egg", "Roc Feather", "Satyr Fur", "Satyr Horn", "Serpent Feather", "Spriggan Bark", "Troll Snot", "Troll Sweat", "Unicorn Hair", "Unicorn Horn", "Vampire Dust", "Vampire Fang", "Vermilion Feather", "Werewolf Blood", "Werewolf Fur", "White Stag Antler", "White Stag Fur", "Wisp Essence", "Wolpertinger Antler", "Wolpertinger Fang", "Wolpertinger Feather", "Wolpertinger Fur", "Wyvern Blood", "Wyvern Claw", "Wyvern Scale", "Yeti Fur" };

			int rnd = 0;
			int rnd2 = 0;

			Random r = new Random();

			string names = "";

			int i = r.Next(10);

			if (i < 4)
			{
				while (names.Contains(nm3[rnd = r.Next(nm3.Length)])) { }
				while (names.Contains(nm4[rnd2 = r.Next(nm4.Length)])) { }

				names = nm3[rnd] + " " + nm4[rnd2];
			}
			else if (i < 6)
			{
				while (names.Contains(nm5[rnd = r.Next(nm5.Length)])) { }

				names = nm5[rnd];
			}
			else
			{
				while (names.Contains(nm1[rnd = r.Next(nm1.Length)])) { }
				while (names.Contains(nm2[rnd2 = r.Next(nm2.Length)])) { }

				names = nm1[rnd] + " " + nm2[rnd2];
			}

			return names;
		}

		public static string armorDescription()
		{
			string[] nm1 = { "rounded helm", "squared helm", "flat top helm", "pointed helm" };
			string[] nm2 = { "a face guard shaped in the face of a bear", "a face guard shaped in the face of a boar", "a face guard shaped in the face of a demon", "a face guard shaped in the face of a dragon", "a face guard shaped in the face of a god", "a face guard shaped in the face of a hawk", "a face guard shaped in the face of a lion", "a face guard shaped in the face of a screaming warrior", "a face guard shaped in the face of a snake", "a face guard shaped in the face of a tiger", "a face guard shaped in the face of a wolf", "a face guard shaped in the face of an angel", "a face guard shaped in the face of an owl", "a face guard shaped in the face of hound", "a face guard shaped like a skull", "a pointed opening for the eyes, which curves downwards into a narrow opening up to the mouth", "a pointed opening leaving just the eyes exposed", "a pointed, t-shaped opening leaving the eyes and mouth exposed, a pointed nose guard protects the nose", "a pointed, t-shaped opening leaving the eyes, nose and mouth exposed", "a pointed, v-shaped opening leaving the eyes and mouth exposed, a pointed nose guard protects the nose", "a pointed, v-shaped opening leaving the eyes, nose and mouth exposed", "a rounded opening for the eyes, which curves downwards into a narrow opening up to the mouth", "a rounded opening leaving just the eyes exposed", "a rounded, t-shaped opening leaving the eyes and mouth exposed, a rounded nose guard protects the nose", "a rounded, t-shaped opening leaving the eyes, nose and mouth exposed", "a rounded, v-shaped opening leaving the eyes and mouth exposed, a rounded nose guard protects the nose", "a rounded, v-shaped opening leaving the eyes, nose and mouth exposed", "a squared opening for the eyes, which curves downwards into a narrow opening up to the mouth", "a squared opening leaving just the eyes exposed", "a squared, t-shaped opening leaving the eyes and mouth exposed, a squared nose guard protects the nose", "a squared, t-shaped opening leaving the eyes, nose and mouth exposed", "a squared, v-shaped opening leaving the eyes and mouth exposed, a squared nose guard protects the nose", "a squared, v-shaped opening leaving the eyes, nose and mouth exposed", "an open face, covering just up to the cheeks", "an open face, covering just up to the ears", "an open face, covering just up to the eyes", "half a face guard shaped like the eyes of a boar", "half a face guard shaped like the eyes of a demon", "half a face guard shaped like the eyes of a dragon", "half a face guard shaped like the eyes of a snake", "half a face guard shaped like the eyes of a tiger", "half a face guard shaped like the eyes of an angel", "half a face guard shaped like the eyes of an owl", "half a face guard shaped like the top of a skull", "half a pointed face guard with two pointed openings for the eyes", "half a rounded face guard with two rounded openings for the eyes", "half a squared face guard with two squared openings for the eyes", "only a nose guard as protection for the face", "two oval holes leaving the eyes minimally exposed", "two pointed holes leaving the eyes minimally exposed", "two rounded holes leaving the eyes minimally exposed", "two small metal plates at each side of the eyes to protect the face", "two squared holes leaving the eyes minimally exposed" };
			string[] nm3 = { "its side are two curled animal horns", "its side are two small antlers", "its side are two large antlers", "its side are two horns which curve upwards", "its side are two horns which curve downwards", "its side are two horns which curve backwards", "its side are two horns which curve forwards", "its side are two huge horns which curve upwards", "its side are two huge horns which curve downwards", "its side are two huge horns which curve backwards", "its side are two huge horns which curve forwards", "its side are two curled animal horns, one of which is partially broken", "its side are two small antlers, one of which is partially broken", "its side are two large antlers, one of which is partially broken", "its side are two horns which curve upwards, one of which is partially broken", "its side are two horns which curve downwards, one of which is partially broken", "its side are two horns which curve backwards, one of which is partially broken", "its side are two horns which curve forwards, one of which is partially broken", "its side are two small, pointy horns", "its side are two straight horns", "its side are two tall angel wing shaped ornaments", "its side are two wide angel wing shaped ornaments", "its side are two tall demon wing shaped ornaments", "its side are two wide demon wing shaped ornaments", "its side are two tall wing shaped ornaments", "its side are two wide wing shaped ornaments", "its side are two tall dragon wing shaped ornaments", "its side are two wide dragon wing shaped ornaments", "its side are two tall bird wing shaped ornaments", "its side are two wide bird wing shaped ornaments", "its side are leaf shaped ornaments", "its side are two wide bat wing shaped ornaments", "its side are two tall bat wing shaped ornaments", "the forehead area is a bird beak shaped ornament", "the forehead area is a dragon face shaped ornament", "the forehead area are snake fang shaped ornaments", "the forehead area is a lion mouth shaped ornament", "the forehead area is a bear face shaped ornament", "the forehead area is an angel wing shaped ornament", "the forehead area is a demon wing shaped ornament", "the forehead area is a skull shaped ornament", "the forehead area is a long horn", "the forehead area is a broken animal horn", "the forehead area are two tall spikes", "the forehead area is a row of small spikes", "the forehead area and running towards the back is a snake shaped ornament", "the forehead area and running towards the back is a dragon shaped ornament", "the forehead area is a bat shaped ornament", "the forehead area are two tall, wing-like ornaments", "the forehead area are two wide, wing-like ornaments", "the forehead area is a tall, wing-like ornament piece", "the forehead area is a wide, wing-like ornament piece", "the forehead area are two small antlers", "the forehead area are two large antlers", "the forehead area are two curved animal horns", "the forehead area are two outward curving, wing-like ornaments", "the forehead area and the backside are two tall, wing-like ornament pieces", "the forehead area are three tall spikes", "the forehead area and the backside are two wide, wing-like ornament pieces", "the forehead area is a crown-shaped ornament piece", "the forehead area is a shield-shaped ornament piece", "the forehead area two small crossed bones as an ornament piece", "the forehead area two small crossed swords as an ornament piece", "the forehead area two small crossed daggers as an ornament piece", "the forehead area is a lightning shaped ornament piece", "the forehead area is a claw-shaped ornament piece", "the top are small spikes, scattered all over", "the top are large, tall spikes in a circle, like some sort of evil crown", "the top is a metal, mohawk-like ornament, ending in a sharp pointed edge", "the top is a metal, mohawk-like ornament with a row of feathers inserted into it", "the top is a metal, mohawk-like ornament with long, colored hair attached to it", "the top is a metal ring used to attach long, colored hairs which flow towards the back", "the top is a metal ring used to attach short, colored hairs which flow towards the back", "the top is a long, wing-shaped ornament curving across the helm, towards the backside", "the top is a long, wing-shaped ornament, standing up straight similar to a mohawk", "the top are small, rounded spikes scattered all over", "the top is a bear head shaped ornament piece", "the top is a dragon head shaped ornament piece", "the top is a bird head shaped ornament piece", "the top is a wolf head shaped ornament piece", "the top is a tiger head shaped ornament piece", "the top is a serpent head shaped ornament piece", "the top are several curved pieces of metal shaped like a mohawk", "the top is a dragon claw shaped ornament piece, covering the helmet and curved towards the back", "the top are small pieces of metal lined up like a mohawk", "the top are feather-shaped pieces of metal, covering the entire top of the helm", "the top are leaf-shaped pieces of metal, covering the entire top of the helm", "the top is a row of long, horn-like metal ornaments, lined up like a mohawk", "the top is a row of long, horn-like metal ornaments, curving towards the back of the helm", "the top are two horn-like metal ornaments, pointed backwards in a sharp angle", "the top is a row of horns which gradually increase in size, they're lined up like a mohawk", "the top are many small spikes in circle, similar to a crown", "the top is a long, curved metal blade which curves forward and ends in a sharp point", "the top is a curved, v-shaped blade, the middle is attached to the center of the helm", "the top is a sharp metal spike pointing directly upwards", "the top is a small metal ring which holds 3 colored feathers, the feathers curve towards the back", "the top are several tentacle shaped metal ornaments", "the top is covered in long, colored hairs which cover the entire helm except for the face", "the top is a sun-shaped metal ornament piece", "the top is a star-shaped metal ornament piece" };
			string[] nm4 = { "fairly rounded", "rounded", "fairly oval", "oval", "fairly pointy", "pointy", "squared", "fairly squared" };
			string[] nm5 = { "long", "narrow", "quite narrow", "quite short", "short", "tall", "very long", "very wide", "wide" };
			string[] nm6 = { "enormous", "fairly small in size", "huge", "large in size", "moderate in size", "quite large", "small in size" };
			string[] nm7 = { "a bear's head on each side", "a coiled up snake on each side, the heads are pointing forwards", "a coiled up snake on each side, the heads are pointing outwards", "a dragonskull on one side", "a hawk's head shaped metal ornament", "a huge bearclaw on each side", "a huge hammer head on each side", "a large antler on each side, pointing backwards", "a large antler on each side, pointing sidewards", "a large skull shaped metal ornament piece", "a lion's head on each side", "a lion's head shaped metal ornament piece on each side", "a long metal plate, curving outwards and downwards at first, but narrowing and curving upwards towards the end", "a long, curved metal ornament piece on each side, starting at the neck and reaching forehead height", "a masterfully crafted metal face on each side, both faces are blindfolded", "a masterfully crafted metal face on each side, one side has a crying emotion while the other is smiling", "a masterfully crafted, small-scale version of a dragon spine on each side", "a metal angel wing on each side", "a metal bat's wing on each side, curved towards the sides", "a metal bird-of-prey claw-shaped metal ornament piece on each side", "a metal blade, starting at the front, curving towards the back and ending in a sharp point", "a metal bull head on each side, both with a ring through its nose", "a metal demon wing on each side", "a metal dragonwing on each side, curved to the sides", "a metal dragonwing on each side, curved towards the back", "a row of metal feathers, all pointing upwards. The row reaches from side to side", "a row of upwards facing daggers", "a scythe-like blade on each side, the blade starts near the neck and curves outwards", "a serpent's head shaped metal ornament piece on each side", "a small antler on each side, pointing backwards", "a small antler on each side, pointing sidewards", "a small pointed tip, which is curved towards the back", "a small shield on each side, facing downwards", "a small shield on each side, facing outwards", "a star-shaped, thick, metal ornament piece", "a straight line of spikes, reaching from side to side", "a straight line of spikes, starting at the front and ending at the back", "a sun-shaped, thick, metal ornament piece", "a tiger's head on each side", "a wide piece of thick, colored cloth, draped over each shoulderplate and hanging over the edges", "a wolf's head on each side", "an axe head on each side, pointing upwards and from side to side", "an enormous dragonclaw on each side", "an owl's head shaped metal ornament piece on each side", "gear-like metal ornament pieces, placed in several rows reaching from side to side", "hundreds of small metal fragments, mimicking the scales of fish", "hundreds of small metal fragments, mimicking the scales of reptiles", "intricate gilded design patterns", "layered pieces of curved metal, forming the rough shape of wings", "layered pieces of curved metal, starting at the inner sides and curving outwards", "layered, spiky pieces of metal and ending in two sharp spikes facing outwards and downwards", "layers upon layers of long, colored feathers", "many metal spikes scattered around on each shoulderplate", "masterfully crafted metal hands on each side", "masterfully crafted layers of metal in the shape of dragon scales", "metal chains covering nearly every part of the shoulderplates", "metal chains, hanging from the edges of the shoulderplates", "metal daggers lined up in two lines, one on the front and one on the back", "metal feathers covering both shoulderplates entirely", "pieces of crystal-shaped metal, creating the illusion of shards of ice or rock", "rows and rows of teeth, enemy teeth to be exact", "rows of colored crystals and gems", "rows upon rows of animal claws, all of them curved towards the backside", "rows upon rows of animal teeth, all of them from predators", "several layers of skulls, possibly of slain enemies", "several rows of small, sharp spikes. Each row reaches from back to front", "several rows of small, sharp spikes. Each row reaches from side to side", "several snakes on each side, they're one entangled mess of snake bodies and snake heads", "three large metal spikes on each side, lined up from back to front", "three large, dragonclaw-like spikes on each side, curved towards the back", "three small horns on each side, curved towards the back", "three small horns on each side, curved towards the sides", "three stacked turtle shells on each side, each smaller than the one below it", "three sword handles on each side, they're all pointing downwards as if a sword has been pierced through the shoulderguards", "two curved animal horns on each side, placed on the front and backside", "two large horns on each side, curved towards the back", "two large horns on each side, curved towards the sides", "two rows of bones on each side, one row is at the front and the other on the backside", "two rows of teeth-like spikes, one row faces upwards and the other downwards, creating a jaw-like appearance", "two smaller blades on each side, curved towards the backside" };
			string[] nm8 = { "rounded, half covering", "pointed, half covering", "squared, half covering", "rounded, layered metal", "chainmail", "pointed, layered metal", "squared, layered metal", "rounded, fully covering", "pointed, fully covering", "squared, fully covering" };
			string[] nm9 = { "nicely", "loosely", "perfectly", "well", "quite well" };
			string[] nm10 = { "a bear claw attached on the outer sides", "a curved animal bone attached to each outer side, the bone curves upwards towards the shoulder", "a dagger attached on the outer sides", "a dragon tooth attached on the outer sides", "a large metal feather on each outer side", "a large sharkfin-like spike attached to each outer side", "a layer of chainmail covering the outer sides", "a masterfully crafted upper bear jaw attached on the outer sides", "a masterfully crafted upper bird beak attached on each outer side", "a masterfully crafted upper dragon jaw attached on the outer sides", "a masterfully crafted upper skeleton jaw attached on the outer sides", "a metal snake curling around them", "a row of hook-like barbs attached to each outer side", "a row of long, curved spikes on the outer sides", "a skull shaped metal ornament piece on each outer side", "a small antler attached on each outer side, pointing upwards and following the arm", "a tentacle-like metal ornament attached to each side and wrapping around each vambrace", "an axe head attached on each outer side, sharp enough to be used as a weapon", "an intricately crafted sigil attached to each outer side", "curved, pointed edge at the elbow point", "intricate gilded design patterns covering everything", "layers of colored feathers on the outer sides", "many small, metal spikes covering the vambraces all over", "metal flower ornament pieces covering the outer sides", "metal leaves covering the outer sides", "rows upon rows of small metal pieces, mimicking dragon scales", "rows upon rows of small metal pieces, mimicking fish scales", "rows upon rows of small metal pieces, mimicking reptile scales", "several small metal chains hanging on the outer sides", "several arrow heads attached in a row on the outer sides, as if arrows have pierced the arms", "several claw-like barbs in a row on the outer sides", "several curved spikes attached near the bottom, shaped like a claw", "several huge, sharp spikes on the outer sides", "several layered metal sheets on the outer sides", "several layers of curved metal attached to the outer sides, they form a wing-like pattern", "several masterfully crafted metal sheets, shaped like dragon scales on the outer sides", "several metal rings attached to the outer sides", "several rows of barb-like spikes on the outer sides", "sharp pointed tip at the elbow point", "two blades attached on each outer side, all sharpened and ready to be used as a weapon" };
			string[] nm11 = { "a couple of layers of metal, mimicking dragon scales", "several separate pieces which are layered on top of each other", "several layers of metal sheets, which perfectly sit just under the shoulderplates", "one large piece of metal, which sits perfectly just under the shoulderplates", "one large piece of metal, but crafted to mimic the appearance of muscles", "one large piece of metal", "various layers of pointed metal sheets", "various layers of rounded metal sheets", "various layers of squared metal sheets", "many layers of pointed metal sheets", "many layers of rounded metal sheets", "many layers of squared metal sheets", "many layers of smaller metal pieces, mimicking the scales of a reptile", "many layers of smaller metal pieces, mimicking the scales of a fish", "many layers of smaller metal pieces, mimicking the scales of a dragon" };
			string[] nm12 = { "everything from the neck down and ending at the groin", "almost everything from the neck down, it narrows near the groin and leaves part of the sides exposed", "the entire front and back side, but the attachment straps leave the sides under the arms exposed", "everything from the neck down and ending at the groin, but the shoulder area is fairly exposed to allow for more movement space", "only the front, the back is where the attachment straps are and they offer no real protection", "almost everything from the neck down and ending at the groin, but the sides are only covered near the bottom", "everything from the neck down and ending at the groin, but there's a fairly wide neck line which is somewhat exposed" };
			string[] nm13 = { "a chainmail skirt reaching down to the knee", "a chainmail skirt reaching just below the groin", "a skirt of several layered metal sheets reaching down to the knee", "a skirt of many layers of metal sheets reaching down to the knee", "a skirt of several layered metal sheets reaching just below the groin", "a skirt of many layers of metal sheets reaching just below the groin", "rounded, half covering cuisses", "pointed, half covering cuisses", "squared, half covering cuisses", "rounded, layered metal cuisses", "pointed, layered metal cuisses", "squared, layered metal cuisses", "rounded, fully covering cuisses", "pointed, fully covering cuisses", "squared, fully covering cuisses" };
			string[] nm14 = { "a curved animal bone attached to each outer side, the bone curves upwards towards the pelvis", "a dagger attached on the outer sides", "a dragon tooth attached on the outer sides", "a large metal feather on each outer side", "a large sharkfin-like spike attached to each outer side", "a layer of chainmail covering the outer sides", "a metal snake curling around them", "a row of hook-like barbs attached to each outer side", "a row of long, curved spikes on the outer sides", "a skull shaped metal ornament piece on each outer side", "a tentacle-like metal ornament attached to each side and wrapping around the greaves", "an small axe head attached on each outer side", "an intricately crafted sigil attached to each outer side", "curved, pointed edge at the knee point", "intricate gilded design patterns covering everything", "layers of colored feathers on the outer sides", "many small, metal spikes covering the greaves all over", "metal flower ornament pieces covering the outer sides", "metal leaves covering the outer sides", "rows upon rows of small metal piece, mimicking dragon scales", "rows upon rows of small metal piece, mimicking fish scales", "rows upon rows of small metal piece, mimicking reptile scales", "several arrow heads attached in a row on the outer sides, as if arrows have pierced the legs", "several claw-like barbs in a row on the outer sides", "several curved spikes attached near the bottom, shaped like a claw", "several large, sharp spikes on the outer sides", "several layered metal sheets on the outer sides", "several layers of curved metal attached to the outer sides, they form a wing-like pattern", "several masterfully crafted metal sheets, shaped like dragon scales on the outer sides", "several metal rings attached to the outer sides", "several rows of barb-like spikes on the outer sides", "sharp pointed tip at the knee point" };
			Random r = new Random();
			int rnd1 = r.Next(nm1.Length);
			int rnd2 = r.Next(nm2.Length);
			int rnd3 = r.Next(nm3.Length);
			int rnd4 = r.Next(nm4.Length);
			int rnd5 = r.Next(nm5.Length);
			int rnd6 = r.Next(nm6.Length);
			int rnd7 = r.Next(nm7.Length);
			int rnd8 = r.Next(nm8.Length);
			int rnd9 = r.Next(nm9.Length);
			int rnd10 = r.Next(nm10.Length);
			int rnd11 = r.Next(nm11.Length);
			int rnd12 = r.Next(nm12.Length);
			int rnd13 = r.Next(nm13.Length);
			int rnd14 = r.Next(nm14.Length);
			string name = "This set of armor has a " + nm1[rnd1] + " with " + nm2[rnd2] + ". Attached to " + nm3[rnd3] + ".";
			string name2 = "The shoulders are " + nm4[rnd4] + ", " + nm5[rnd5] + " and " + nm6[rnd6] + ". They're decorated with " + nm7[rnd7] + ".";
			string name3 = "The upper arms are protected by " + nm8[rnd8] + " rerebraces which sit " + nm9[rnd9] + " under the shoulderplates. The lower arms are covered by vambraces which have " + nm10[rnd10] + ".";
			string name4 = "The breastplate is made from " + nm11[rnd11] + ". It covers " + nm12[rnd12] + "."; var name5 = "The upper legs are covered by " + nm13[rnd13] + ". The lower legs are protected by greaves which have " + nm14[rnd14] + ".";

			return name + " " + name2 + " " + name3 + " " + name4;
		}

		public static string backstory()
		{
			Random r = new Random();
			int tp = r.Next(2) + 1;
			string[] nm1 = { "He", "he", "his", "him", "man" };
			string[] nm2 = { "adventurous", "affectionate", "analytical", "athletic", "brave", "calm", "capable", "charismatic", "charming", "cheerful", "creative", "curious", "daring", "dedicated", "dependable", "determined", "driven", "dutiful", "eager", "elegant", "energetic", "faithful", "funny", "generous", "gentle", "happy", "helpful", "honest", "hospitable", "humble", "humorous", "innocent", "intelligent", "intrepid", "jovial", "just", "light-hearted", "loyal", "modest", "mysterious", "polite", "popular", "proud", "quick", "reliable", "responsible", "savvy", "sensitive", "sincere", "sweet", "talkative", "thoughtful", "whimsical", "wise", "witty" };
			string[] nm3 = { "anxious", "arrogant", "bewildered", "bossy", "conceited", "confused", "facetious", "foolish", "greedy", "grouchy", "harsh", "ignorant", "immature", "impatient", "impulsive", "jealous", "lonely", "mean", "naive", "nervous", "opinionated", "pompous", "rash", "restless", "rude", "selfish", "snobbish", "stubborn", "timid", "uncontrolled" };
			string[] nm4 = { "This is to be expected from somebody", "But what'd you expect from somebody", "This isn't surprising considering for someone", "Which isn't out of the ordinary for someone", "But this is all just a facade, a mechanism to deal", "But there's more than this to somebody", "But there's more than meets the eye, not surprising for somebody" };
			string[] nm5 = { "n average", " wealthy", " royal", "n ordinary", " fairly rich", " high class", " middle class", " loving", " large", " small", " decent", " successful" };
			string[] nm6 = { "n average", " normal", " large", " wealthy", " major", "n important", " merchant", " developing", " developed" };
			string[] nm7 = { "town", "city", "village", "port", "community", "capital" };
			string[] nm8 = { "without worry", "out of trouble", "free of worries", "free of trouble", "in peace", "comfortably", "happily" };
			int nm9 = (int)(r.NextDouble() * 10) + 10;
			string[] nm10 = { "things changed", "things began to change", "life changed", "life began to change" };
			string[] nm11 = { "gained responsibilities", "gained new responsibilities", "became more important", "became more important to society", "got an important job", "started to travel a lot", "started to travel the world", "started to experience the world", "started working for the family company", "studied a lot", "went to college", "explored the country", "moved out", "moved in with a friend", "did volunteering work", "did a lot of small jobs", "moved to another country", "became a travelling adventurer", "went on an adventure", "improved upon existing powers", "got a new pet", "got a new companion" };
			string[] nm12 = { "among the most popular people", "becoming quite desirable", "very successful", "growing up fast", "meeting a lot of influential people", "making many new friends", "learning a lot of new skills", "gaining a little fame", "making some great new friends", "about to meet 'Mr(s). Right'", "learning a new language", "becoming more cultured", "slowly improving upon existing skills", "learning how to cook in new styles", "strengthening the relationships with friends", "strengthening the relationship with both parents", "competing in large tournaments" };
			string[] nm12b = { "managed to bloom", "succeeded", "managed to thrive", "boomed", "went beyond expectations", "reached for the stars", "lives the dream", "blossomed", "reached the top", "made a fortune", "fulfilled dreams", "thrived", "enjoys life", "loves life", "struggles to make it", "is going on a journey", "is part of an adventure", "is trying to reach the top", "is unstoppable", "is on top of the world", "is exploring new areas", "is discovering hidden secrets", "is discovering hidden treasures", "is venturing out", "is trying to help others" };
			string[] nm13 = { "With the support of great friends", "With the support of great parents", "With plenty of money and connections", "Alongside great friends", "With amazing, new friends", "With a great deal of determination", "With determination and some luck", "Alongside trusted friends", "With a great companion", "Through hard work", "Through plenty of trial and error", "By never giving up", "After an astonishing adventure", "With the help of great friends", "Having overcome plenty of obstacles" };
			string[] nm14 = { "strange", "weird", "crazy", "ever changing", "fast", "fast changing", "amazing", "fantasy", "fantastic", "wacky", "absurd", "strange", "mad", "wild", "remarkable", "wonderful", "outlandish", "astonishing", "extraordinary", "mystifying" };
			string[] nm15 = { "bravery", "brilliance", "capability", "charm", "compassion", "curiosity", "determination", "diligence", "eagerness", "sense of humor", "wits", "cunning", "perseverance", "persistence", "skills", "powers", "talents", "wisdom", "intrepidness", "honesty" };
			string[] nm16 = { "reaching great success", "finding a way to the top", "fulfilling all dreams", "accomplish all goals", "improving the world", "going beyond expectations", "climbing to the top", "staying ahead of the game", "reaching full potential", "doing anything" };
			string[] nm17 = { "a force to be reckoned with", "a true inspiration for many", "a true friend for life", "an ally you'd want by your side", "somebody we can expect great things of", "somebody who could change the world", "a great leader, perhaps even of the nation", "an unstoppable force", "a friend you'd want by your side", "a person of (great) importance" };
			string[] nm18 = { "Despite all this success,", "However,", "But there may be more to it than this;", "But for now that's speculation;", "But only time will tell;", "But who really knows what will happen;", "But anything could happen;", "But things could change quickly;" };
			string[] nm19 = { "searching for a higher purpose", "still studying", "enjoying the simpler life", "having fun with friends", "travelling the world", "exploring everything", "still growing up and learning new things", "still finding the right place in the world", "still looking for a true calling", "still trying to perfect skills", "improving upon skills and talents", "learning how to reach full potential", "enjoying the world and its beauty", "looking for a place to truly call home", "still learning, exploring and discovering" };
			string[] nm20 = { "to explore", "than meets the eye", "than we know", "secrets than answers", "than what we get to know", "to experience", "to discover", "to see, taste and experience", "than people let on", "incredible sights to behold", "watchful eyes than expected", "caution than needed", "to learn", "to enjoy", "people to meet" };
			string[] nm21 = { "great friends", "great companions", "great parents", "amazing friends", "plenty of resources", "a great family", "awesome friends", "great people around", "wise teachers and great friends", "a close group of friends" };
			string[] names = new string[4];

			double gnd = r.NextDouble();

			if (gnd < 0.5)
			{
				nm1 = new string[] { "She", "she", "her", "her", "woman" };
			}
			if (tp == 2)
			{
				nm2 = new string[] { "adventurous", "ambitious", "angry", "arrogant", "brave", "calm", "capable", "cautious", "clever", "coarse", "conceited", "confident", "crafty", "cross", "daring", "dauntless", "determined", "eager", "efficient", "facetious", "fierce", "frank", "gloomy", "greedy", "hardy", "harsh", "impartial", "impatient", "impolite", "impulsive", "independent", "intelligent", "keen", "loyal", "malicious", "mysterious", "observant", "pensive", "petulant", "precise", "punctilious", "quick", "quiet", "sarcastic", "scornful", "self-reliant", "sincere", "skillful", "sly", "stingy", "strict", "stubborn", "sullen", "tactful", "versatile", "vulgar", "witty" };
				nm3 = new string[] { "disturbing", "dreadful", "gruesome", "horrifying", "shocking", "terrible", "tormented", "troubled", "ugly", "unsettling" };
				nm5 = new string[] { " broken", " decent", " fairly rich", " great", " high class", " large", " loving", " lower class", " middle class", " needy", " poor", " small", " successful", " wealthy", "n average", "n ordinary" };
				nm6 = new string[] { "n average", " normal", " large", " wealthy", " major", "n important", " merchant", " developing", " developed", " poor", " broken" };
				nm9 = r.Next(13) + 4;
				nm10 = new string[] { "things changed", "life changed", "everything changed", "life changed drastically", "life took a turn for the worst", "things took a turn for the worst" };
				if (gnd < 0.5)
				{
					nm11 = new string[] { "lost her parents in", "lost her mother in", "lost her father in", "lost her parents when they left after", "lost her best friend in", "lost her home when it was destroyed after", "lost her money after", "lost her family was they were split up after", "lost her brother in", "lost her sister in", "lost her sisters in", "lost her brothers in", "lost her siblings in", "lost her family in", "killed somebody by accident during", "killed somebody during", "maimed somebody during", "accidently maimed somebody during", "destroyed someone's life during", "destroyed someone's life by accident during" };
				}
				else
				{
					nm11 = new string[] { "lost his parents in", "lost his mother in", "lost his father in", "lost his parents when they left after", "lost his best friend in", "lost his home when it was destroyed after", "lost his money after", "lost his family was they were split up after", "lost his brother in", "lost his sister in", "lost his sisters in", "lost his brothers in", "lost his siblings in", "lost his family in", "killed somebody by accident during", "killed somebody during", "maimed somebody during", "accidently maimed somebody during", "destroyed someone's life during", "destroyed someone's life by accident during" };
				}
				nm12 = new string[] { "a freak fire", "a robbery gone wrong", "a terrible disaster", "a natural disaster", "a suspicious accident", "a fight which got out of control", "an invasion", "a brutal war", "a drought", "an act of terrorism", "a volcanic eruption", "a hurricane", "an earthquake", "a horrible flood", "a long lasting heatwave", "an epidemic", "a food shortage", "a power outage", "a government takeover", "a rebellion", "a revolution" };
				nm12b = new string[] { "abandoned by all", "forsaken by all", "arrested", "forgotten by everybody", "neglected by everybody", "shunned", "rejected by all", "becoming an outcast", "caught up with the wrong people", "initiated in a gang", "now part of a sinister clan", "headed for a life of crime", "headed for a life of misery", "now alone and forgotten", "now alone, miserable and abandoned" };
				nm13 = new string[] { "With a new found friend", "All alone", "Without any help", "With a childhood friend", "With the help of a stranger", "Alone, lost and forgotten", "With the help of a small group of strangers", "With a couple of friends", "With a new found love", "With the help of a suspicious stranger", "With the help of a suspicious friend", "While persued by the authority", "While persued by a criminal gang", "While persued by strangers", "While obstructed by many", "Against all odds", "Alongside a brother", "Alongside a sister", "Alongside a cousin", "Together with a companion", "Together with a pet", "With a loyal stranger", "With a loyal friend", "Reunited with a friend", "Reunited with a lost pet" };
				nm14 = new string[] { "wicked", "crazy", "bizarre", "cruel", "outlandish", "odd", "harsh", "criminal", "insane", "mad", "bitter", "rough", "bleak", "brutal", "relentless", "unkind", "pitiless", "vicious", "villainous", "corrupt" };
				nm15 = new string[] { "bravery", "fighting skills", "capability", "charm", "vigor", "courage", "determination", "diligence", "eagerness", "inginuity", "wits", "cunning", "perseverance", "persistance", "skills", "powers", "talents", "wisdom", "intrepidness", "strength" };
				nm16 = new string[] { "battle the elements", "overcome all odds", "survive everything", "go beyond expectations", "face all obstacles", "conquer all fears and doubts", "crush all that's in the way", "overpower anybody who's a hinderance", "keep ahead of the curve", "remain out of reach of danger", "train to perfection", "escape hell", "reach full potential", "start a new life", "find a new home" };
				nm17 = nm16;
				nm18 = new string[] { "Still plagued by the past", "While haunted by memories of the past", "Powerless to change the past", "With new found pride and some happiness", "Still affected by the past", "Having finally found some peace of mind", "Having finally found some stability", "After finally turning life around", "With a new chance at life", "With the lessons of the past", "While still constantly on the move", "With the skills learned in the past", "Having found a significant other", "Settled down and with some peace and quiet", "While constantly travelling the world" };
				nm19 = new string[] { "on helping people", "as a mercenary for the king", "a small job with low pay", "on making it in a large tournament", "on meeting new, kind people", "buying a house", "fitting in with society", "as a travelling trader", "as a travelling gun for hire", "as a travelling help for hire", "on travelling and surviving of nature", "perfecting skills and talents", "tracking the people of the past", "as help for hire", "as a sailor" };
				nm20 = new string[] { "find some form of redemption", "shed the memories of the past", "be released of the haunting memories", "find a place to call home", "live a normal life", "find safety and happiness", "find joy and happiness in life", "leave the past behind", "find inner peace", "find answers to the events of the past", "learn more about the past", "find vengeance for the actions in the past", "forget about the past", "start life over on a good note", "support a new, honest life" };
				nm21 = new string[] { "peace of mind", "friends", "happiness", "joy and love for life", "stability and security", "tranquility", "joys and comforts of life", "pleasureful life", "significant other", "purpose to life" };
			}

			int rnd2a = r.Next(nm2.Length);
			int rnd2b = r.Next(nm2.Length);

			while (rnd2a == rnd2b)
			{
				rnd2b = r.Next(nm2.Length);
			}

			int rnd2c = r.Next(nm2.Length);

			while (rnd2c == rnd2b || rnd2c == rnd2a)
			{
				rnd2c = r.Next(nm2.Length);
			}

			int rnd3 = r.Next(nm3.Length);
			int rnd4 = r.Next(nm4.Length);
			int rnd5 = r.Next(nm5.Length);
			int rnd6 = r.Next(nm6.Length);
			int rnd7 = r.Next(nm7.Length);
			int rnd8 = r.Next(nm8.Length);
			int rnd10 = r.Next(nm10.Length);
			int rnd11 = r.Next(nm11.Length);
			int rnd12 = r.Next(nm12.Length);
			int rnd12b = r.Next(nm12b.Length);
			int rnd13 = r.Next(nm13.Length);
			int rnd14 = r.Next(nm14.Length);
			int rnd15a = r.Next(nm15.Length);
			int rnd15b = r.Next(nm15.Length);

			while (rnd15a == rnd15b)
			{
				rnd15b = r.Next(nm15.Length);
			}

			int rnd16 = r.Next(nm16.Length);
			int rnd17 = r.Next(nm17.Length);

			while (rnd16 == rnd17)
			{
				rnd17 = r.Next(nm17.Length);
			}

			int rnd18 = r.Next(nm18.Length);
			int rnd19 = r.Next(nm19.Length);
			int rnd20 = r.Next(nm20.Length);
			int rnd21 = r.Next(nm21.Length);

			if (tp == 2)
			{
				names[0] = nm1[0] + "'s " + nm2[rnd2a] + ", " + nm2[rnd2b] + " and " + nm2[rnd2c] + ". " + nm4[rnd4] + " with " + nm1[2] + " " + nm3[rnd3] + " past.";
				names[1] = nm1[0] + " was born and grew up in a" + nm5[rnd5] + " family in a" + nm6[rnd6] + " " + nm7[rnd7] + ", " + nm1[1] + " lived " + nm8[rnd8] + " until " + nm1[1] + " was about " + nm9 + " years old, but at that point " + nm10[rnd10] + ".";
				names[2] = nm1[0] + " " + nm11[rnd11] + " " + nm12[rnd12] + " and was " + nm12b[rnd12b] + ". " + nm13[rnd13] + " " + nm1[1] + " had to survive in a " + nm14[rnd14] + " world. But with " + nm1[2] + " " + nm15[rnd15a] + " and " + nm15[rnd15b] + ", " + nm1[1] + " managed to " + nm16[rnd16] + " and " + nm17[rnd17] + ". This has turned " + nm1[3] + " into the " + nm1[4] + " " + nm1[1] + " is today.";
				names[3] = nm18[rnd18] + ", " + nm1[1] + " now works " + nm19[rnd19] + ". By doing so, " + nm1[1] + " hopes to " + nm20[rnd20] + " and finally find " + nm21[rnd21] + " " + nm1[1] + " has never had.";
			}
			else
			{
				names[0] = nm1[0] + "'s " + nm2[rnd2a] + ", " + nm2[rnd2b] + ", " + nm2[rnd2c] + " and perhaps a little too " + nm3[rnd3] + ". " + nm4[rnd4] + " with " + nm1[2] + " position.";
				names[1] = nm1[0] + " was born in a" + nm5[rnd5] + " family in a" + nm6[rnd6] + " " + nm7[rnd7] + ". " + nm1[0] + " lived " + nm8[rnd8] + " until " + nm1[1] + " was about " + nm9 + " years old, but at that point " + nm10[rnd10] + ".";
				names[2] = nm1[0] + " " + nm11[rnd11] + " and was " + nm12[rnd12] + ".  " + nm13[rnd13] + ", " + nm1[1] + " " + nm12b[rnd12b] + " in a " + nm14[rnd14] + " world. But with " + nm1[2] + " " + nm15[rnd15a] + " and " + nm15[rnd15b] + ", there's nothing to stop " + nm1[3] + " from " + nm16[rnd16] + ". " + nm1[0] + " could quickly become " + nm17[rnd17] + ".";
				names[3] = nm18[rnd18] + " " + nm1[1] + " is currently " + nm19[rnd19] + ". " + nm1[0] + " feels like there's more " + nm20[rnd20] + " in this world. Luckily " + nm1[1] + " has " + nm21[rnd21] + " to support " + nm1[3] + ".";
			}

			return names[0] + names[1] + names[2] + names[3];
		}

		public static string characterDescriptionMale()
		{
			string[] names1 = { "Black", "Gray", "White", "Blonde", "Brown", "Red", "Ginger", "Chestnut", "Silver" };
			string[] names2 = { "short hair", "short spiky hair", "short bristly hair", "well groomed hair", "crinkly hair", "sleek hair", "flowing hair", "shaggy hair", "well groomed hair", "long hair", "curly hair", "straight hair", "wavy hair", "frizzy hair", "coily hair", "long hair", "curly hair", "straight hair", "wavy hair", "frizzy hair", "coily hair", "dreadlocks", "shoulder-Length hair" };
			string[] names3 = { "hangs over", "slightly reveals", "tight in a ponytail reveals", "gently hangs over", "slightly covers", "almost fully covers", "clumsily hangs over", "awkwardly hangs over", "neatly coiffured to reveal", "is pulled back to reveal" };
			string[] names4 = { "thin", "chiseled", "craggy", "fine", "fresh", "full", "furrowed", "handsome", "sculpted", "weak", "strong", "long", "round", "bony", "lean", "skinny", "fat" };
			string[] names5 = { "time-worn", "cheerful", "friendly", "charming", "radiant", "warm", "anguished", "menacing", "lively", "tense", "wild", "gloomy", "frowning", "worried", "sad", "lived-in" };
			string[] names6 = { "Beady", "Big, round", "Bloodshot", "Bright", "Bulging", "Clear", "Dancing", "Darting", "Dead", "Expressive", "Gentle", "Glinting", "Glistening", "Glittering", "Heavy", "Hollow", "Hooded", "Lidded", "Narrow", "Piercing", "Round", "Shining", "Shuttered", "Small", "Smart", "Sparkling", "Squinting", "Wide", "Woeful" };
			string[] names7 = { "blue", "brown", "hazel", "black", "green", "amber", "gray" };
			string[] names8 = { "deep", "narrowly", "buried", "far", "rooted", "well", "low", "high", "sunken", "lightly", "thightly", "graciously", "concealed", "delicately", "elegantly", "handsomely", "a-symmetrically", "gracefully", "seductively", "appealingly", "charmingly", "dreadfully", "wickedly" };
			string[] names9 = { "wearily", "delightfully", "cheerfully", "gratefully", "heartily", "warmly", "eagerly", "delightedly", "merrily", "lovingly", "enthusiastically", "readily", "hungrily", "intently", "energetically", "impatiently", "longingly", "vigorously", "rapidly", "admiringly", "affectionately", "fondly", "thoughtfully", "devotedly", "yearningly", "loyally", "cautiously", "slowly", "carefully", "guardedly", "discreetly", "anxiously", "attentively", "meticulously", "honorably", "vigilantly", "watchfully", "delicately", "faithfully" };
			string[] names10 = { "village", "city", "lands", "people", "town", "families", "ships", "armies", "homes", "castle", "palace", "natives", "wildlife", "farms", "country", "haven", "mountains", "rivers", "river", "sea", "woods", "wastelands", "clan", "folk", "tribe", "ancestors", "children", "deserts", "mines", "spirits", "stronghold" };
			string[] names11 = { "protected", "sworn to protect", "come to love", "loved", "fought for", "bled for", "nearly died for", "looked after", "cared for", "defended", "safeguarded", "kept safe", "watched over", "stood guard for", "come to appreciate", "grown affactionate of", "become enchancted by", "worshipped", "befriended", "grieved with", "shown mercy on", "sought solace in", "felt at home at", "rarely felt at home at", "barely related to", "disassociated with", "felt disconnected from", "have been seperated from", "been seperated from", "been isolated from" };
			string[] names12 = { "A scar", "Scars", "A sword left a mark", "A gunshot left a mark", "Fallen debry left a mark", "Fire has left a mark", "A birthmark", "An old tattoo", "A tattoo", "Tribal marks", "Several moles", "Freckles", "Smooth skin", "Soft skin", "Fair skin", "A beard", "A large beard", "Dark stubble", "A moustache", "A goatee", "A moustache and goatee" };
			string[] names13 = { "stretching from just under the right eye", "stretching from just under the left eye", "stretching from just under the right eyebrow", "stretching from just under the left eyebrow", "stretching from just under the right eye", "stretching from the top of the right cheek", "stretching from the top of the left cheek", "stretching from the bottom of the right cheek", "stretching from the bottom of the left cheek", "stretching from the bottom of the right cheekbone", "stretching from the bottom of the left cheekbone", "stretching from the right side of the forehead", "stretching from the left side of the forehead", "reaching from just under the right eye", "reaching from just under the left eye", "reaching from just under the right eyebrow", "reaching from just under the left eyebrow", "reaching from just under the right eye", "reaching from the top of the right cheek", "reaching from the top of the left cheek", "reaching from the bottom of the right cheek", "reaching from the bottom of the left cheek", "reaching from the bottom of the right cheekbone", "reaching from the bottom of the left cheekbone", "reaching from the right side of the forehead", "reaching from the left side of the forehead" };
			string[] names14 = { ", running across the nose", ", running towards the other eye", ", first running towards thin lips", ", first running towards his fairly big lips", ", running towards the right side of his lips", ", running towards the left side of his lips", ", running towards the tip of the nose", ", running towards his left nostril", ", running towards his right nostril", ", running towards his upper lip" };
			string[] names15 = { "and ending on his left cheek", "and ending on his left cheekbone", "and ending on his right cheek", "and ending on his right cheekbone", "and ending on his upper lip", "and ending on his chin", "and ending on his forehead", "and ending on his right nostril", "and ending on his left nostril", "and ending under his left eye", "and ending under his right eye", "and ending above his right eye", "and ending above his left eye" };
			string[] names16 = { "a pleasant memory", "an aching memory", "a burning memory", "a stinging memory", "a tormenting memory", "an aching burden", "a stinging burden", "a tormenting burden", "a painful burden", "a lasting punishment", "a lasting burden", "an amusing memory", "a delightful memory", "a gracious memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "an agonizing memory", "a grievous memory", "a beautiful memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
			string[] names17 = { "a former life", "a great reputation", "a new life", "a reclaimed home", "an unusual alliance", "battles long forgotten", "battles past", "companionship", "deceased love", "deceased loved ones", "defended homes", "defended honor", "defended lands", "departed love", "departed loved ones", "famed glory", "forbidden adventures", "forbidden love", "former lives", "former love", "fortunate adventures", "heroic liberations", "hidden talents", "his adventurous love life", "his ex-love", "his former lover", "his fortunate destiny", "his fortunate past", "his fortunate survival", "his fortunate upbringing", "his love", "his luck in battles", "his luck in love", "his luck", "his reckless luck", "his unfortunate past", "his unfortunate upbringing", "innocence long lost", "lands long forgotten", "liberated love", "lost comrades", "lost friends", "lost honor", "lost love", "reclaimed honor", "reclaimed lands", "redeemed honor", "redeemed love", "redemption", "restored honor", "return to home", "true friendship", "unexpected friendship", "unfortunate adventures" };
			string[] names18 = { "Adam", "Adan", "Addison", "Brock", "Brodie", "Brody", "Brooks", "Bruce", "Bruno", "Bryan", "Bryant", "Bryce", "Brycen", "Bryson", "Byron", "Cade", "Caden", "Cael", "Caiden", "Cale", "Gunnar", "Irving", "Isaac", "Jamal", "Jamar", "Kade", "Maverick", "Max", "Orion", "Orlando" };
			string[] names19 = { "Adwell", "Afton", "Barnett", "Barney", "Barnfield", "Chilson", "Chilton", "Cawthorn", "Davenport", "Davey", "Dallin", "Eustice", "Eustis", "Evatt", "Falcon", "Faley", "Falkner", "Geary", "Gedman", "Gedney", "Hanshaw", "Hansley", "Hanson", "Lamkin", "Lamkins", "Lamm", "Lockridge", "Locks", "Lockwood", "Masser", "Massey", "Massingale", "Rosemond", "Shepherd", "Shepley", "Wakeley", "Wakelin" };
			string[] names20 = { "hero", "friend", "leader", "pioneer", "romancer", "fortune-hunter", "explorer", "daredevil", "globetrotter", "mercenary", "dreamer", "visionary", "idealist", "genius", "champion", "master", "prodigy", "spectacle", "guardian", "angel", "paladin", "warrior", "hunter", "warden", "defender", "sentinel", "victor", "winner", "challenger", "ally", "protector", "vanquisher", "vindicator", "romanticist", "stargazer", "nobleman", "utopian", "adventurer", "opportunist", "pioneer" };
			string[] names21 = { "humans", "humans", "humans", "humans", "elves", "night elves", "blood elves", "high elves", "wood elves", "dark elves", "gnomes", "trolls", "orcs", "goblins", "dwarves", "giants", "halflings", "vampires", "werewolves" };
			string[] names22 = { "tall among", "short among", "towering among", "towering above", "tall above", "big among", "high among", "small among", "average among", "ordinary among", "common among", "oddly among", "awkwardly among", "gracefully among", "graciously among", "elegantly among", "easily among", "tiny among", "seductively among", "alluringly among" };
			string[] names23 = { "thin", "big", "fragile", "delicate", "lean", "narrow", "skinny", "slim", "light", "subtle", "scraggy", "bulky", "heavy", "hefty", "athletic", "brawny", "sturdy", "strong", "muscled", "tough" };
			string[] names24 = { "alluring", "ambiguous", "appealing", "bewildering", "bizarre", "captivating", "charming", "curious", "different", "enigmatic", "enthralling", "enticing", "extraordinary", "fascinating", "incomprehensible", "inexplicable", "intriguing", "irregular", "misleading", "mystifying", "obscure", "odd", "puzzling", "seductive", "wonderful" };
			string[] names25 = { "a feeling of anguish", "a feeling of arogance", "a feeling of coldness", "a feeling of comfort", "a feeling of delight", "a feeling of guilt", "a feeling of hospitality", "a feeling of indifference", "a feeling of joy", "a feeling of regret", "a feeling of remorse", "a feeling of sadness", "a feeling of shame", "his attitude", "his bravery", "his clumsiness", "his company", "his composure", "his decency", "his disposition", "his fortunate past", "his friendly demeanor", "his gentleness", "his good looks", "his good will", "his goodwill", "his hatred", "his humility", "his kindness", "his odd companions", "his odd friends", "his painful past", "his patience", "his perseverance", "his persistence", "his personality", "his presence", "his reputation", "his sense of comradery", "his sense of honor", "his sense of humor", "his sense of justice", "his sensitivity", "his suffering", "his sympathy", "his tenderness", "his unfortunate past", "his unusual alliances", "his unusual looks", "his warmth" };
			string[] names26 = { "a feeling of anguish", "a feeling of arogance", "a feeling of coldness", "a feeling of comfort", "a feeling of delight", "a feeling of guilt", "a feeling of hospitality", "a feeling of indifference", "a feeling of joy", "a feeling of regret", "a feeling of remorse", "a feeling of sadness", "a feeling of shame", "his attitude", "his bravery", "his clumsiness", "his company", "his composure", "his decency", "his disposition", "his fortunate past", "his friendly demeanor", "his gentleness", "his good looks", "his good will", "his goodwill", "his hatred", "his humility", "his kindness", "his odd companions", "his odd friends", "his painful past", "his patience", "his perseverance", "his persistence", "his personality", "his presence", "his reputation", "his sense of comradery", "his sense of honor", "his sense of humor", "his sense of justice", "his sensitivity", "his suffering", "his sympathy", "his tenderness", "his unfortunate past", "his unusual alliances", "his unusual looks", "his warmth" };
			string[] names27 = { "keep their distance", "flock towards him", "worship him", "befriend him", "assist him", "follow him", "welcome him", "welcome him with open arms", "invite him into their homes", "hit it off with him", "ask him for favors", "shower him with gifts", "subtly ignore him", "pretend to be his friend", "pretend to be his best friend", "lie about knowing him to brag", "brag about knowing him", "take pride in knowing him", "take pride in knowing him as a friend", "wish to get to know him better", "become his friend", "socialize with him", "try to get him to marry their off-spring", "buy him a drink", "salute him in the streets", "stay on his good side", "thank him for his service", "ask him to tell stories", "ask him about his adventures", "ask him about his latest victory", "share local gossip with him", "be curious about him", "treat him like family" };
			string[] names28 = { "trying to subtlely stare", "secretly admiring him", "trying to hide from him", "trying to avoid him", "trying to please him", "secretly dispising him", "jealousy consumes them", "wishing they were more like him", "thinking of ways to become his friend", "wanting to fight along his side in battle", "hoping to one day follow in his footsteps", "secretly training to become more like him", "trying to subtly look more like him", "befriending his friends to get closer to him", "learning as much about him as possible", "commending him for his deeds", "hoping he will one day be their leader", "hoping their sons will grow up to be like him", "helping him out in any way they can", "awkwardly avoid talking about his past", "spreading rumors about him behind his back", "spreading stories about him", "making up bigger stories about him", "training with him whenever he's available", "treating him to a good meal when he's around" };

			Random r = new Random();

			int random21 = r.Next(names21.Length);

			if (random21 > 3 && random21 < 9)
			{
				names1 = new string[] { "Purple", "Blue", "Green", "Red", "White", "Blonde", "Brown", "Light blue", "Light green", "Pink", "Silver", "Golden" };
				names2 = new string[] { "perfectly groomed hair", "well groomed hair", "sleek hair", "long hair", "curly hair", "straight hair", "flowing hair", "wavy hair", "shoulder-Length hair" };
				names4 = new string[] { "thin", "chiseled", "craggy", "fine", "fresh", "full", "furrowed", "handsome", "sculpted", "strong", "long", "round", "bony", "lean" };
				names7 = new string[] { "blue", "brown", "hazel", "green", "amber", "gray", "sapphire", "aquamarine", "pink", "red", "golden", "violet", "silver" };
				names10 = new string[] { "village", "lands", "people", "town", "families", "ships", "armies", "homes", "castle", "palace", "natives", "wildlife", "farms", "country", "haven", "mountains", "rivers", "river", "sea", "woods", "woodlands", "ancestors", "children", "spirits" };
				names18 = new string[] { "Wyninn", "Ninleyn", "Tinlef", "Elluin", "Elduin", "Elmon", "Almar", "Alas", "Alwin", "Almer", "Alre", "Alred", "Alen", "Alluin", "Alduin", "Almon", "Hagwin", "Hagmere" };
				names19 = new string[] { "Moonwalker", "Dawnwing", "Dawnfury", "Moonfall", "Nightgaze", "Dawnthorn", "Stagrunner", "Wildoak", "Lunadancer", "Dawnwhisper" };
			}
			else if (random21 == 10)
			{
				names1 = new string[] { "Purple", "Blue", "Green", "Red", "White", "Brown", "Light blue", "Light green", "Orange", "Silver", "Golden", "Yellow", "Black", "Blue", "Brown", "Hazel", "Black", "Green", "Amber", "Gray" };
				names2 = new string[] { "short hair", "short hair", "short hair", "long hair", "curly hair", "straight hair", "sleek hair", "frizzy hair", "shaggy hair", "shoulder-Length hair" };
				names4 = new string[] { "thin", "fine", "fresh", "full", "handsome", "round", "bony", "lean", "skinny", "fat" };
				names18 = new string[] { "Glinoflonk", "Bonlebick", "Bimbik", "Gnobflink", "Binflonk", "Nittlewizz", "Gimkink", "Merbibus", "Totonk", "Dinnus" };
				names19 = new string[] { "Steambonk", "Berryspark", "Spannerwhistle", "Steamspanner", "Tosslefuse", "Draxlespanner", "Finewizzle", "Puddleblast", "Stormgauge", "Shinesprocket" };
			}
			else if (random21 >= 11 || random21 < 14)
			{
				names2 = new string[] { "short hair", "short hair", "short hair", "long hair", "curly hair", "straight hair", "coily hair", "shaggy hair", "greasy hair", "oily hair", "frizzy hair", "shoulder-Length hair", "dreadlocks" };
				names4 = new string[] { "thin", "chiseled", "craggy", "fine", "fresh", "full", "furrowed", "strong", "long", "round", "bony", "lean", "skinny" };
				names10 = new string[] { "village", "city", "lands", "people", "town", "families", "ships", "armies", "homes", "stronghold", "natives", "wildlife", "farms", "country", "haven", "mountains", "rivers", "river", "sea", "clan", "folk", "tribe", "tribes", "ancestors", "children", "deserts", "mines", "spirits" };
				if (random21 == 11)
				{
					names18 = new string[] { "Ekon", "Erasto", "Haijen", "Hamedi", "Hokima", "Jaafan", "Jabir", "Jalai", "Javyn", "Jijel", "Juma", "Jumoke", "Kaijin", "Kazko", "Maalik", "Makas", "Malak", "Nyabingi", "Rahjin", "Rakash", "Rashi", "Razi" };
					names19 = new string[] { "Xueshi", "Vintish", "Zalaahoku", "Valkeiki", "Hakjel", "Hanalaji", "Zebnanji", "Tesh'Rimon", "Junbir", "Zenunjo" };
				}
				else if (random21 == 12)
				{
					names18 = new string[] { "Gnarg", "Gnarlug", "Gnorl", "Gnorth", "Gnoth", "Gnurl", "Golag", "Golub", "Gomatug", "Gomoku", "Gorgu", "Gorlag", "Grikug", "Grug", "Grukag", "Grukk", "Grung", "Gruul" };
					names19 = new string[] { "Wolfbasher", "Burningfury", "Firesong", "Goreseeker", "Hellsplitter", "Deatheye", "Burninghorn", "Gorebasher", "Wolfhammer", "Boneslayer" };
				}
				else if (random21 == 13)
				{
					names18 = new string[] { "Karax", "Baxeek", "Soxart", "Rezikmez", "Fizink", "Wimax", "Jexmelyx", "Grexmex", "Tinkbelex", "Greekeels" };
					names19 = new string[] { "Greaseblast", "Haggletooth", "Deadnozzle", "Fizfingers", "Gearnozzle", "Shadowgleam", "Copperbuttons", "Deadsprocket", "Greasebottom", "Toptwister" };
				}
			}
			else if (random21 >= 14 || random21 <= 16)
			{
				names2 = new string[] { "short hair", "short hair", "short hair", "long hair", "curly hair", "coily hair", "greasy hair", "shaggy hair", "oily hair", "frizzy hair", "shoulder-Length hair" };
				names4 = new string[] { "craggy", "fine", "fresh", "full", "furrowed", "strong", "long", "round", "fat" };
				if (random21 == 14)
				{
					names18 = new string[] { "Bengahdar", "Banbrek", "Drumdus", "Dulgarn", "Galirg", "Kharnur", "Iromuador", "Ragorhdrom", "Urmbrek", "Theledon" };
					names19 = new string[] { "Longmantle", "Highbeard", "Frostpike", "Boulderstone", "Bouldergem", "Frostshaper", "Bouldershout", "Blackaxe", "Goldstone", "Battlefist" };
				}
			}

			int random1 = r.Next(names1.Length);
			int random2 = r.Next(names2.Length);
			int random3 = r.Next(names3.Length);
			int random4 = r.Next(names4.Length);
			int random5 = r.Next(names5.Length);
			int random6 = r.Next(names6.Length);
			int random7 = r.Next(names7.Length);
			int random8 = r.Next(names8.Length);
			int random9 = r.Next(names9.Length);
			int random10 = r.Next(names10.Length);
			int random11 = r.Next(names11.Length);
			int random12 = r.Next(names12.Length);

			if (random12 > 6 && random12 < 9)
			{
				names13 = new string[] { "resembling a shield", "resembling a sword", "resembling a skull", "resembling a flag", "resembling a tear", "of a small dragon", "of a small cross", "of a small star", "of a small eagle", "of a small swallow", "of a small lion", "of a small wolf", "of a small bear", "of a bear paw", "of a lion paw", "of an eagle claw", "of a talon", "of a dagger", "of a wolf paw", "of a shield", "of a sword", "of a skull", "of a flag", "of a tear", "resembling a small dragon", "resembling a small cross", "resembling a small star", "resembling a small eagle", "resembling a small swallow", "resembling a small lion", "resembling a small wolf", "resembling a small bear", "resembling a bear paw", "resembling a lion paw", "resembling an eagle claw", "resembling a talon", "resembling a dagger", "resembling a wolf paw" };
				names14 = new string[] { "is almost hidden", "is displayed", "is subtly placed", "is prominently featured", "is proudly worn" };
				names15 = new string[] { "on the right side of his neck", "on the left side of his neck", "just below his right eye", "just below his left eye", "on the side of his right cheekbone", "on the side of his left cheekbone", "on the side of the left eye", "on the side of his right eye", "just above the side of his left eye", "just above the side of his right eye", "just above the right side of his right eyebrow", "just above the left side of his left eyebrow" };
			}
			else if (random12 == 9)
			{
				names13 = new string[] { "in the form of 2 stripes running from above the eyes to the bottom of the cheeks", "in the form of 2 stripes on each side of the face, running from just above the eyes to the bottom of the cheeks", "in the form of 1 stripe under his right eye", "in the form of 1 stripe under his left eye", "in the form of 2 stripes under his right eye", "in the form of 2 stripes under his left eye", "in the form of 1 stripe under each eye", "in the form of 1 stripe under each eye", "in the form of 2 stripes under each eye", "in the form of 2 stripes under each eye", "in the form of a stripe above and below his right eye", "in the form of a stripe above and below his left eye", "in the form of a stripe above and below both his eyes", "in the form of 1 stripe above and 2 stripes below his right eye", "in the form of 1 stripe above and 2 stripes below his left eye", "in the form of 1 stripe above and 2 stripes below both his eyes", "in the form of a diagonal line across his right eye", "in the form of a diagonal line across his left eye", "resembling a lightning bolt under his right eye", "resembling a lightning bolt under his left eye", "resembling a horizontal lightning bolt under his right eye", "resembling a horizontal lightning bolt under his left eye", "resembling two large lightning bolts on each side of his face" };
				names14 = new string[] { "marks his heritage", "marks his ancestry", "marks his skills in combat", "marks his rank", "marks his upbringing", "marks his legacy", "marks his birthright", "marks his heirship", "marks his descent", "marks his lineage", "marks his blood relation", };
				names15 = new string[] { "but, more importantly" };
			}
			else if (random12 == 10)
			{
				names13 = new string[] { "are spread" };
				names14 = new string[] { "charmingly", "gracefully", "beautifully", "elegantly", "seductively", "alluringly", "delightfully", "delicately", "graciously", "neatly", "oddly", "awkwardly", "grotesquely", "gracelessly", "unusually", "peculiarly" };
				names15 = new string[] { "on his left cheek and", "on his right cheek and", "across his whole face and", "across his forehead and", "around his nose and", "on his neck and" };
				names16 = new string[] { "a pleasant memory", "an aching memory", "a burning memory", "a stinging memory", "a tormenting memory", "a lasting burden", "an amusing memory", "a delightful memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "an agonizing memory", "a grievous memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
				names17 = new string[] { "his past", "his upbringing", "his fortunate upbringing", "his former lovers", "his fortunate looks", "his fortunate survival", "his luck", "his luck in battles", "his luck in love", "his fortunate destiny", "his adventurous love life", "his reckless luck", "his fortunate adventures", "his unfortunate upbringing", "his unfortunate looks", "his lack of luck in love", "his unadventurous love life", "his unfortunate adventures" };
			}
			else if (random12 == 11)
			{
				names13 = new string[] { "are spread" };
				names14 = new string[] { "charmingly", "gracefully", "beautifully", "elegantly", "gorgeously", "handsomely", "seductively", "alluringly", "delightfully", "delicately", "graciously", "neatly" };
				names15 = new string[] { "around his cheeks and", "across his whole face and", "across his cheeks and", "across his cheeks and forehead and", "around his nose and cheekbones and" };
				names16 = new string[] { "a pleasant memory", "an amusing memory", "a delightful memory", "a gracious memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "a beautiful memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
				names17 = new string[] { "his past", "his upbringing", "his fortunate upbringing", "his former lovers", "his fortunate looks", "his fortunate survival", "his luck", "his luck in battles", "his luck in love", "his fortunate destiny", "his adventurous love life", "his reckless luck", "his fortunate adventures" };
			}
			else if (random12 > 11)
			{
				names13 = new string[] { "charmingly", "gracefully", "beautifully", "elegantly", "gorgeously", "handsomely", "seductively", "alluringly", "delightfully", "graciously" };
				names14 = new string[] { "compliments his" };
				names15 = new string[] { "eyes and", "cheekbones and", "cheeks and", "mouth and", "hair and", "nose and", "nose and mouth and", "eyes and mouth and", "eyes and cheekbones and", "eyes and hair and", "hair and cheekbones and" };
				names16 = new string[] { "a pleasant memory", "an amusing memory", "a delightful memory", "a gracious memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "a beautiful memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
				names17 = new string[] { "his past", "his upbringing", "his fortunate upbringing", "his former lovers", "his fortunate looks", "his fortunate survival", "his luck", "his luck in battles", "his luck in love", "his fortunate destiny", "his adventurous love life", "his reckless luck", "his fortunate adventures" };
			}

			int random13 = r.Next(names13.Length);
			int random14 = r.Next(names14.Length);
			int random15 = r.Next(names15.Length);
			int random16 = r.Next(names16.Length);
			int random17 = r.Next(names17.Length);
			int random18 = r.Next(names18.Length);
			int random19 = r.Next(names19.Length);
			int random20 = r.Next(names20.Length);
			int random22 = r.Next(names22.Length);
			int random23 = r.Next(names23.Length);
			int random24 = r.Next(names24.Length);
			int random25 = r.Next(names25.Length);
			int random26 = r.Next(names26.Length);

			while (random26 == random25)
			{
				random26 = r.Next(names26.Length);
			}
			int random27 = r.Next(names27.Length);
			int random28 = r.Next(names28.Length);
			string name = names1[random1] + ", " + names2[random2] + " " + names3[random3] + " a " + names4[random4] + ", " + names5[random5] + " face. " + names6[random6] + " " + names7[random7] + " eyes, set " + names8[random8] + " within their sockets, watch " + names9[random9] + " over the " + names10[random10] + " they've " + names11[random11] + " for so long.";
			string name2 = names12[random12] + " " + names13[random13] + " " + names14[random14] + " " + names15[random15] + " leaves " + names16[random16] + " of " + names17[random17] + ".";
			string name3 = "This is the face of " + names18[random18] + " " + names19[random19] + ", a true " + names20[random20] + " among " + names21[random21] + ". He stands " + names22[random22] + " others, despite his " + names23[random23] + " frame.";
			string name4 = "There's something " + names24[random24] + " about him, perhaps it's " + names25[random25] + " or perhaps it's simply " + names26[random26] + ". But nonetheless, people tend to " + names27[random27] + ", while " + names28[random28] + ".";

			return name + " " + name2 + " " + name3 + " " + name4;
		}

		public static string characterDescriptionFemale()
		{
			string[] names1 = new string[] { "Black", "Gray", "White", "Blonde", "Brown", "Red", "Ginger", "Chestnut", "Silver" };
			string[] names2 = new string[] { "short hair", "short curly hair", "short layered hair", "well groomed hair", "crinkly hair", "sleek hair", "flowing hair", "shaggy hair", "well groomed hair", "long hair", "curly hair", "straight hair", "wavy hair", "frizzy hair", "coily hair", "short hair", "long hair", "curly hair", "straight hair", "wavy hair", "frizzy hair", "coily hair", "dreadlocks", "hip-Length hair", "shoulder-Length hair" };
			string[] names3 = new string[] { "hangs over", "slightly reveals", "braided to reveal", "double braided to reveal", "tight in a bun reveals", "tight in a ponytail reveals", "gently hangs over", "slightly covers", "almost fully covers", "clumsily hangs over", "awkwardly hangs over", "neatly coiffured to reveal", "is pulled back to reveal" };
			string[] names4 = new string[] { "thin", "chiseled", "craggy", "fine", "fresh", "full", "furrowed", "handsome", "sculpted", "weak", "strong", "long", "round", "bony", "lean", "skinny", "fat" };
			string[] names5 = new string[] { "time-worn", "cheerful", "friendly", "charming", "radiant", "warm", "anguished", "menacing", "lively", "tense", "wild", "gloomy", "frowning", "worried", "sad", "lived-in" };
			string[] names6 = new string[] { "Beady", "Big, round", "Bloodshot", "Bright", "Bulging", "Clear", "Dancing", "Darting", "Dead", "Expressive", "Gentle", "Glinting", "Glistening", "Glittering", "Heavy", "Hollow", "Hooded", "Lidded", "Narrow", "Piercing", "Round", "Shining", "Shuttered", "Small", "Smart", "Sparkling", "Squinting", "Wide", "Woeful" };
			string[] names7 = new string[] { "blue", "brown", "hazel", "black", "green", "amber", "gray" };
			string[] names8 = new string[] { "deep", "narrowly", "buried", "far", "rooted", "well", "low", "high", "sunken", "lightly", "thightly", "graciously", "concealed", "delicately", "elegantly", "handsomely", "a-symmetrically", "gracefully", "seductively", "appealingly", "charmingly", "dreadfully", "wickedly" };
			string[] names9 = new string[] { "wearily", "delightfully", "cheerfully", "gratefully", "heartily", "warmly", "eagerly", "delightedly", "merrily", "lovingly", "enthusiastically", "readily", "hungrily", "intently", "energetically", "impatiently", "longingly", "vigorously", "rapidly", "admiringly", "affectionately", "fondly", "thoughtfully", "devotedly", "yearningly", "loyally", "cautiously", "slowly", "carefully", "guardedly", "discreetly", "anxiously", "attentively", "meticulously", "honorably", "vigilantly", "watchfully", "delicately", "faithfully" };
			string[] names10 = new string[] { "village", "city", "lands", "people", "town", "families", "ships", "armies", "homes", "castle", "palace", "natives", "wildlife", "farms", "country", "haven", "mountains", "rivers", "river", "sea", "woods", "wastelands", "clan", "folk", "tribe", "ancestors", "children", "deserts", "mines", "spirits", "stronghold" };
			string[] names11 = new string[] { "protected", "sworn to protect", "come to love", "loved", "fought for", "bled for", "nearly died for", "looked after", "cared for", "defended", "safeguarded", "kept safe", "watched over", "stood guard for", "come to appreciate", "grown affactionate of", "become enchancted by", "worshipped", "befriended", "grieved with", "shown mercy on", "sought solace in", "felt at home at", "rarely felt at home at", "barely related to", "disassociated with", "felt disconnected from", "have been seperated from", "been seperated from", "been isolated from" };
			string[] names12 = new string[] { "A scar", "Scars", "A sword left a mark", "A gunshot left a mark", "Fallen debry left a mark", "Fire has left a mark", "A birthmark", "An old tattoo", "A tattoo", "Tribal marks", "Several moles", "Freckles", "Smooth skin", "Soft skin", "Fair skin" };
			string[] names13 = new string[] { "stretching from just under the right eye", "stretching from just under the left eye", "stretching from just under the right eyebrow", "stretching from just under the left eyebrow", "stretching from just under the right eye", "stretching from the top of the right cheek", "stretching from the top of the left cheek", "stretching from the bottom of the right cheek", "stretching from the bottom of the left cheek", "stretching from the bottom of the right cheekbone", "stretching from the bottom of the left cheekbone", "stretching from the right side of the forehead", "stretching from the left side of the forehead", "reaching from just under the right eye", "reaching from just under the left eye", "reaching from just under the right eyebrow", "reaching from just under the left eyebrow", "reaching from just under the right eye", "reaching from the top of the right cheek", "reaching from the top of the left cheek", "reaching from the bottom of the right cheek", "reaching from the bottom of the left cheek", "reaching from the bottom of the right cheekbone", "reaching from the bottom of the left cheekbone", "reaching from the right side of the forehead", "reaching from the left side of the forehead" };
			string[] names14 = new string[] { ", running across the nose", ", running towards the other eye", ", first running towards thin lips", ", first running towards her fairly big lips", ", running towards the right side of her lips", ", running towards the left side of her lips", ", running towards the tip of the nose", ", running towards her left nostril", ", running towards her right nostril", ", running towards her upper lip" };
			string[] names15 = new string[] { "and ending on her left cheek", "and ending on her left cheekbone", "and ending on her right cheek", "and ending on her right cheekbone", "and ending on her upper lip", "and ending on her chin", "and ending on her forehead", "and ending on her right nostril", "and ending on her left nostril", "and ending under her left eye", "and ending under her right eye", "and ending above her right eye", "and ending above her left eye" };
			string[] names16 = new string[] { "a pleasant memory", "an aching memory", "a burning memory", "a stinging memory", "a tormenting memory", "an aching burden", "a stinging burden", "a tormenting burden", "a painful burden", "a lasting punishment", "a lasting burden", "an amusing memory", "a delightful memory", "a gracious memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "an agonizing memory", "a grievous memory", "a beautiful memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
			string[] names17 = new string[] { "a former life", "a great reputation", "a new life", "a reclaimed home", "an unusual alliance", "battles long forgotten", "battles past", "companionship", "deceased love", "deceased loved ones", "defended homes", "defended honor", "defended lands", "departed love", "departed loved ones", "famed glory", "forbidden adventures", "forbidden love", "former lives", "former love", "fortunate adventures", "heroic liberations", "hidden talents", "her adventurous love life", "her ex-love", "her former lover", "her fortunate destiny", "her fortunate past", "her fortunate survival", "her fortunate upbringing", "her love", "her luck in battles", "her luck in love", "her luck", "her reckless luck", "her unfortunate past", "her unfortunate upbringing", "innocence long lost", "lands long forgotten", "liberated love", "lost comrades", "lost friends", "lost honor", "lost love", "reclaimed honor", "reclaimed lands", "redeemed honor", "redeemed love", "redemption", "restored honor", "return to home", "true friendship", "unexpected friendship", "unfortunate adventures" };
			string[] names18 = new string[] { "Allyson", "Allyssa", "Camille", "Camryn", "Daphne", "Elyse", "Elyssa", "Emily", "Faith", "Jayde", "Julie", "Juliet", "Kylee", "Melinda", "Melissa", "Sarina", "Sasha" };
			string[] names19 = new string[] { "Adwell", "Afton", "Barnett", "Barney", "Barnfield", "Chilson", "Chilton", "Cawthorn", "Davenport", "Davey", "Dallin", "Eustice", "Eustis", "Evatt", "Falcon", "Faley", "Falkner", "Geary", "Gedman", "Gedney", "Hanshaw", "Hansley", "Hanson", "Lamkin", "Lamkins", "Lamm", "Lockridge", "Locks", "Lockwood", "Masser", "Massey", "Massingale", "Rosemond", "Shepherd", "Shepley", "Wakeley", "Wakelin" };
			string[] names20 = new string[] { "hero", "friend", "leader", "pioneer", "romancer", "fortune-hunter", "explorer", "daredevil", "globetrotter", "mercenary", "dreamer", "visionary", "idealist", "genius", "champion", "master", "prodigy", "spectacle", "guardian", "angel", "paladin", "warrior", "hunter", "warden", "defender", "sentinel", "victor", "winner", "challenger", "ally", "protector", "vanquisher", "vindicator", "romanticist", "stargazer", "noblewoman", "utopian", "adventurer", "opportunist", "pioneer" };
			string[] names21 = new string[] { "humans", "humans", "humans", "humans", "elves", "night elves", "blood elves", "high elves", "wood elves", "dark elves", "gnomes", "trolls", "orcs", "goblins", "dwarves", "giants", "halflings", "vampires", "werewolves" };
			string[] names22 = new string[] { "tall among", "short among", "towering among", "towering above", "tall above", "big among", "high among", "small among", "average among", "ordinary among", "common among", "oddly among", "awkwardly among", "gracefully among", "graciously among", "elegantly among", "easily among", "tiny among", "seductively among", "alluringly among" };
			string[] names23 = new string[] { "thin", "big", "fragile", "delicate", "lean", "narrow", "skinny", "slim", "light", "subtle", "scraggy", "bulky", "heavy", "hefty", "athletic", "brawny", "sturdy", "strong", "muscled", "tough" };
			string[] names24 = new string[] { "alluring", "ambiguous", "appealing", "bewildering", "bizarre", "captivating", "charming", "curious", "different", "enigmatic", "enthralling", "enticing", "extraordinary", "fascinating", "incomprehensible", "inexplicable", "intriguing", "irregular", "misleading", "mystifying", "obscure", "odd", "puzzling", "seductive", "wonderful" };
			string[] names25 = new string[] { "a feeling of anguish", "a feeling of arogance", "a feeling of coldness", "a feeling of comfort", "a feeling of delight", "a feeling of guilt", "a feeling of hospitality", "a feeling of indifference", "a feeling of joy", "a feeling of regret", "a feeling of remorse", "a feeling of sadness", "a feeling of shame", "her attitude", "her bravery", "her clumsiness", "her company", "her composure", "her decency", "her disposition", "her fortunate past", "her friendly demeanor", "her gentleness", "her good looks", "her good will", "her goodwill", "her hatred", "her humility", "her kindness", "her odd companions", "her odd friends", "her painful past", "her patience", "her perseverance", "her persistence", "her personality", "her presence", "her reputation", "her sense of comradery", "her sense of honor", "her sense of humor", "her sense of justice", "her sensitivity", "her suffering", "her sympathy", "her tenderness", "her unfortunate past", "her unusual alliances", "her unusual looks", "her warmth" };
			string[] names26 = new string[] { "a feeling of anguish", "a feeling of arogance", "a feeling of coldness", "a feeling of comfort", "a feeling of delight", "a feeling of guilt", "a feeling of hospitality", "a feeling of indifference", "a feeling of joy", "a feeling of regret", "a feeling of remorse", "a feeling of sadness", "a feeling of shame", "her attitude", "her bravery", "her clumsiness", "her company", "her composure", "her decency", "her disposition", "her fortunate past", "her friendly demeanor", "her gentleness", "her good looks", "her good will", "her goodwill", "her hatred", "her humility", "her kindness", "her odd companions", "her odd friends", "her painful past", "her patience", "her perseverance", "her persistence", "her personality", "her presence", "her reputation", "her sense of comradery", "her sense of honor", "her sense of humor", "her sense of justice", "her sensitivity", "her suffering", "her sympathy", "her tenderness", "her unfortunate past", "her unusual alliances", "her unusual looks", "her warmth" };
			string[] names27 = new string[] { "keep their distance", "flock towards her", "worship her", "befriend her", "assist her", "follow her", "welcome her", "welcome her with open arms", "invite her into their homes", "hit it off with her", "ask her for favors", "shower her with gifts", "subtly ignore her", "pretend to be her friend", "pretend to be her best friend", "lie about knowing her to brag", "brag about knowing her", "take pride in knowing her", "take pride in knowing her as a friend", "wish to get to know her better", "become her friend", "socialize with her", "try to get her to marry their off-spring", "buy her a drink", "salute her in the streets", "stay on her good side", "thank her for her service", "ask her to tell stories", "ask her about her adventures", "ask her about her latest victory", "share local gossip with her", "be curious about her", "treat her like family", "hopelessly try to seduce her" };
			string[] names28 = new string[] { "trying to subtlely stare", "secretly admiring her", "trying to hide from her", "trying to avoid her", "trying to please her", "secretly dispising her", "jealousy consumes them", "wishing they were more like her", "thinking of ways to become her friend", "wanting to fight along her side in battle", "hoping to one day follow in her footsteps", "secretly training to become more like her", "trying to subtly look more like her", "befriending her friends to get closer to her", "learning as much about her as possible", "commending her for her deeds", "hoping she will one day be their leader", "hoping their sons will grow up to be like her", "helping her out in any way they can", "awkwardly avoid talking about her past", "spreading rumors about her behind her back", "spreading stories about her", "making up bigger stories about her", "training with her whenever she's available", "treating her to a good meal when she's around" };

			Random r = new Random();

			int random21 = r.Next(names21.Length);

			if (random21 > 3 && random21 < 10)
			{
				names1 = new string[] { "Purple", "Blue", "Green", "Red", "White", "Blonde", "Brown", "Light blue", "Light green", "Pink", "Silver", "Golden" };
				names2 = new string[] { "perfectly groomed hair", "well groomed hair", "long wavy hair", "long layed hair", "layered hair", "sleek hair", "long hair", "curly hair", "straight hair", "flowing hair", "wavy hair", "shoulder-Length hair" };
				names4 = new string[] { "thin", "chiseled", "craggy", "fine", "fresh", "full", "furrowed", "handsome", "sculpted", "strong", "long", "round", "bony", "lean" };
				names7 = new string[] { "blue", "brown", "hazel", "green", "amber", "gray", "sapphire", "aquamarine", "pink", "red", "golden", "violet", "silver" };
				names10 = new string[] { "village", "lands", "people", "town", "families", "ships", "armies", "homes", "castle", "palace", "natives", "wildlife", "farms", "country", "haven", "mountains", "rivers", "river", "sea", "woods", "woodlands", "ancestors", "children", "spirits" };
				names18 = new string[] { "Ylsysea", "Nilerea", "Lelselea", "Lelarea", "Nafareath", "Felerai", "Sillaesa", "Leadrieth", "Yneasia", "Iyohara" };
				names19 = new string[] { "Moonwalker", "Dawnwing", "Dawnfury", "Moonfall", "Nightgaze", "Dawnthorn", "Stagrunner", "Wildoak", "Lunadancer", "Dawnwhisper" };
			}
			else if (random21 == 10)
			{
				names1 = new string[] { "Purple", "Blue", "Green", "Red", "White", "Brown", "Light blue", "Light green", "Orange", "Silver", "Golden", "Yellow", "Black", "Blue", "Brown", "Hazel", "Black", "Green", "Amber", "Gray" };
				names2 = new string[] { "short hair", "short hair", "short hair", "long hair", "curly hair", "straight hair", "sleek hair", "frizzy hair", "shaggy hair", "shoulder-Length hair" };
				names4 = new string[] { "thin", "fine", "fresh", "full", "handsome", "round", "bony", "lean", "skinny", "fat" };
				names18 = new string[] { "Glinkeefonk", "Binfink", "Tolikink", "Katbrick", "Tiltinkle", "Tinkeeflonk", "Bonfinkle", "Tyntinkle", "Mittlefink", "Talmink" };
				names19 = new string[] { "Steambonk", "Berryspark", "Spannerwhistle", "Steamspanner", "Tosslefuse", "Draxlespanner", "Finewizzle", "Puddleblast", "Stormgauge", "Shinesprocket" };
			}
			else if (random21 >= 11 || random21 < 14)
			{
				names2 = new string[] { "short hair", "short hair", "short hair", "long hair", "curly hair", "straight hair", "coily hair", "shaggy hair", "greasy hair", "oily hair", "frizzy hair", "shoulder-Length hair", "dreadlocks" };
				names4 = new string[] { "thin", "chiseled", "craggy", "fine", "fresh", "full", "furrowed", "strong", "long", "round", "bony", "lean", "skinny" };
				names10 = new string[] { "village", "city", "lands", "people", "town", "families", "ships", "armies", "homes", "stronghold", "natives", "wildlife", "farms", "country", "haven", "mountains", "rivers", "river", "sea", "clan", "folk", "tribe", "tribes", "ancestors", "children", "deserts", "mines", "spirits" };
				if (random21 == 11)
				{
					names18 = new string[] { "Gir'Enji", "Yahuja", "Feyini", "Ziruja", "Zeyra", "Zuladur", "Zujula", "Sonayo", "Vulino", "Yaonji" };
					names19 = new string[] { "Xueshi", "Vintish", "Zalaahoku", "Valkeiki", "Hakjel", "Hanalaji", "Zebnanji", "Tesh'Rimon", "Junbir", "Zenunjo" };
				}
				else if (random21 == 12)
				{
					names18 = new string[] { "Umoda", "Zonkaja", "Goredo", "Umakuma", "Groanu", "Zunala", "Gredula", "Sheeda", "Greras", "Elgudo" };
					names19 = new string[] { "Wolfbasher", "Burningfury", "Firesong", "Goreseeker", "Hellsplitter", "Deatheye", "Burninghorn", "Gorebasher", "Wolfhammer", "Boneslayer" };
				}
				else if (random21 == 13)
				{
					names18 = new string[] { "Amizenee", "Nexlee", "Pybilope", "Nalleex", "Glelee", "Glyxi", "Linxie", "Minzi", "Glebizee", "Fluxinky" };
					names19 = new string[] { "Greaseblast", "Haggletooth", "Deadnozzle", "Fizfingers", "Gearnozzle", "Shadowgleam", "Copperbuttons", "Deadsprocket", "Greasebottom", "Toptwister" };
				}
			}
			else if (random21 >= 14 || random21 <= 16)
			{
				names2 = new string[] { "short hair", "short hair", "short hair", "long hair", "curly hair", "coily hair", "greasy hair", "shaggy hair", "oily hair", "frizzy hair", "shoulder-Length hair" };
				names4 = new string[] { "craggy", "fine", "fresh", "full", "furrowed", "strong", "long", "round", "fat" };
				if (random21 == 14)
				{
					names18 = new string[] { "Belianyss", "Daerahniss", "Dearirwyn", "Brenunwyn", "Gwenirnys", "Bretianura", "Einormyl", "Breteodiel", "Bellores", "Brylilen" };
					names19 = new string[] { "Longmantle", "Highbeard", "Frostpike", "Boulderstone", "Bouldergem", "Frostshaper", "Bouldershout", "Blackaxe", "Goldstone", "Battlefist" };
				}
			}

			int random1 = r.Next(names1.Length);
			int random2 = r.Next(names2.Length);
			int random3 = r.Next(names3.Length);
			int random4 = r.Next(names4.Length);
			int random5 = r.Next(names5.Length);
			int random6 = r.Next(names6.Length);
			int random7 = r.Next(names7.Length);
			int random8 = r.Next(names8.Length);
			int random9 = r.Next(names9.Length);
			int random10 = r.Next(names10.Length);
			int random11 = r.Next(names11.Length);
			int random12 = r.Next(names12.Length);
			if (random12 > 6 && random12 < 9)
			{
				names13 = new string[] { "resembling a rose", "resembling a petal", "of a heart", "resembling a shield", "resembling a sword", "resembling a skull", "resembling a flag", "resembling a tear", "of a small dragon", "of a small cross", "of a small star", "of a small eagle", "of a small swallow", "of a small lion", "of a small wolf", "of a small bear", "of a bear paw", "of a lion paw", "of an eagle claw", "of a talon", "of a dagger", "of a wolf paw", "of a shield", "of a sword", "of a skull", "of a flag", "of a tear", "resembling a small dragon", "resembling a small cross", "resembling a small star", "resembling a small eagle", "resembling a small swallow", "resembling a small lion", "resembling a small wolf", "resembling a small bear", "resembling a bear paw", "resembling a lion paw", "resembling an eagle claw", "resembling a talon", "resembling a dagger", "resembling a wolf paw" };
				names14 = new string[] { "is almost hidden", "is displayed", "is subtly placed", "is prominently featured", "is proudly worn" };
				names15 = new string[] { "on the right side of her neck", "on the left side of her neck", "just below her right eye", "just below her left eye", "on the side of her right cheekbone", "on the side of her left cheekbone", "on the side of the left eye", "on the side of her right eye", "just above the side of her left eye", "just above the side of her right eye", "just above the right side of her right eyebrow", "just above the left side of her left eyebrow" };
			}
			else if (random12 == 9)
			{
				names13 = new string[] { "in the form of 2 stripes running from above the eyes to the bottom of the cheeks", "in the form of 2 stripes on each side of the face, running from just above the eyes to the bottom of the cheeks", "in the form of 1 stripe under her right eye", "in the form of 1 stripe under her left eye", "in the form of 2 stripes under her right eye", "in the form of 2 stripes under her left eye", "in the form of 1 stripe under each eye", "in the form of 1 stripe under each eye", "in the form of 2 stripes under each eye", "in the form of 2 stripes under each eye", "in the form of a stripe above and below her right eye", "in the form of a stripe above and below her left eye", "in the form of a stripe above and below both her eyes", "in the form of 1 stripe above and 2 stripes below her right eye", "in the form of 1 stripe above and 2 stripes below her left eye", "in the form of 1 stripe above and 2 stripes below both her eyes", "in the form of a diagonal line across her right eye", "in the form of a diagonal line across her left eye", "resembling a lightning bolt under her right eye", "resembling a lightning bolt under her left eye", "resembling a horizontal lightning bolt under her right eye", "resembling a horizontal lightning bolt under her left eye", "resembling two large lightning bolts on each side of her face" };
				names14 = new string[] { "marks her heritage", "marks her ancestry", "marks her skills in combat", "marks her rank", "marks her upbringing", "marks her legacy", "marks her birthright", "marks her heirship", "marks her descent", "marks her lineage", "marks her blood relation", };
				names15 = new string[] { "but, more importantly" };
			}
			else if (random12 == 10)
			{
				names13 = new string[] { "are spread" };
				names14 = new string[] { "charmingly", "gracefully", "beautifully", "elegantly", "seductively", "alluringly", "delightfully", "delicately", "graciously", "neatly", "oddly", "awkwardly", "grotesquely", "gracelessly", "unusually", "peculiarly" };
				names15 = new string[] { "on her left cheek and", "on her right cheek and", "across her whole face and", "across her forehead and", "around her nose and", "on her neck and" };
				names16 = new string[] { "a pleasant memory", "an aching memory", "a burning memory", "a stinging memory", "a tormenting memory", "a lasting burden", "an amusing memory", "a delightful memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "an agonizing memory", "a grievous memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
				names17 = new string[] { "her past", "her upbringing", "her fortunate upbringing", "her former lovers", "her fortunate looks", "her fortunate survival", "her luck", "her luck in battles", "her luck in love", "her fortunate destiny", "her adventurous love life", "her reckless luck", "her fortunate adventures", "her unfortunate upbringing", "her unfortunate looks", "her lack of luck in love", "her unadventurous love life", "her unfortunate adventures" };
			}
			else if (random12 == 11)
			{
				names13 = new string[] { "are spread" };
				names14 = new string[] { "charmingly", "gracefully", "beautifully", "elegantly", "gorgeously", "handsomely", "seductively", "alluringly", "delightfully", "delicately", "graciously", "neatly" };
				names15 = new string[] { "around her cheeks and", "across her whole face and", "across her cheeks and", "across her cheeks and forehead and", "around her nose and cheekbones and" };
				names16 = new string[] { "a pleasant memory", "an amusing memory", "a delightful memory", "a gracious memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "a beautiful memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
				names17 = new string[] { "her past", "her upbringing", "her fortunate upbringing", "her former lovers", "her fortunate looks", "her fortunate survival", "her luck", "her luck in battles", "her luck in love", "her fortunate destiny", "her adventurous love life", "her reckless luck", "her fortunate adventures" };
			}
			else if (random12 > 11)
			{
				names13 = new string[] { "charmingly", "gracefully", "beautifully", "elegantly", "gorgeously", "handsomely", "seductively", "alluringly", "delightfully", "graciously" };
				names14 = new string[] { "compliments her" };
				names15 = new string[] { "eyes and", "cheekbones and", "cheeks and", "mouth and", "hair and", "nose and", "nose and mouth and", "eyes and mouth and", "eyes and cheekbones and", "eyes and hair and", "hair and cheekbones and" };
				names16 = new string[] { "a pleasant memory", "an amusing memory", "a delightful memory", "a gracious memory", "a pleasurable memory", "a bittersweet memory", "a heartbreaking memory", "a beautiful memory", "a satisfying memory", "a fascinating memory", "a captivating memory", "an intriguing memory", "a compelling memory" };
				names17 = new string[] { "her past", "her upbringing", "her fortunate upbringing", "her former lovers", "her fortunate looks", "her fortunate survival", "her luck", "her luck in battles", "her luck in love", "her fortunate destiny", "her adventurous love life", "her reckless luck", "her fortunate adventures" };
			}

			int random13 = r.Next(names13.Length);
			int random14 = r.Next(names14.Length);
			int random15 = r.Next(names15.Length);
			int random16 = r.Next(names16.Length);
			int random17 = r.Next(names17.Length);
			int random18 = r.Next(names18.Length);
			int random19 = r.Next(names19.Length);
			int random20 = r.Next(names20.Length);
			int random22 = r.Next(names22.Length);
			int random23 = r.Next(names23.Length);
			int random24 = r.Next(names24.Length);
			int random25 = r.Next(names25.Length);
			int random26 = r.Next(names26.Length);

			while (random26 == random25)
			{
				random26 = r.Next(names26.Length);
			}

			int random27 = r.Next(names27.Length);
			int random28 = r.Next(names28.Length);
			string name = names1[random1] + ", " + names2[random2] + " " + names3[random3] + " a " + names4[random4] + ", " + names5[random5] + " face. " + names6[random6] + " " + names7[random7] + " eyes, set " + names8[random8] + " within their sockets, watch " + names9[random9] + " over the " + names10[random10] + " they've " + names11[random11] + " for so long.";
			string name2 = names12[random12] + " " + names13[random13] + " " + names14[random14] + " " + names15[random15] + " and leaves " + names16[random16] + " of " + names17[random17] + ".";
			string name3 = "The is the face of " + names18[random18] + " " + names19[random19] + ", a true " + names20[random20] + " among " + names21[random21] + ". She stands " + names22[random22] + " others, despite her " + names23[random23] + " frame.";
			string name4 = "There's something " + names24[random24] + " about her, perhaps it's " + names25[random25] + " or perhaps it's simply " + names26[random26] + ". But nonetheless, people tend to " + names27[random27] + ", while " + names28[random28] + ".";

			return name + " " + name2 + " " + name3 + " " + name4;
		}

		public static string craftStore()
		{
			string[] nm1 = { "A Change of Art", "A Cool Thread", "A Flair Deal", "A Stitch in Time", "A Wood Deal", "Air of Flair", "All's Flair", "And Sew Forth", "And Sew On", "Any Stitch Way", "Apothecrafty", "Art Beats", "Art Cookie", "Art From Scratch", "Art Tea", "Art Ways", "Art a la Carte", "Art and Parcel", "Art of Gold", "Art of the Furniture", "Artsy Fartsy", "Be Sew Bold", "Bear With Flair", "Beautique", "Beauty Embroidified", "By Design", "Care With Flair", "Care to Flair", "Celecreation", "Couture Gifts", "Craft Crazy", "Craft Fever", "Craft Machine", "Craftastical", "Crafter Hours", "Crafter-Noon Delights", "Crafterina", "Crafterpeneur", "Crafting Creativity", "Craftopia", "Crafts Foundry", "Craftworks", "Crafty Pleasures", "Create Mate", "Create Parade", "Created Comforts", "Creative Beat", "Creative Crafts", "Creative Creature", "Creative Motions", "Creative Scene", "Creative Splash", "Critter Crafts", "Critter Knitter", "Curio Crafts", "Cute as a Button", "Daily Thread", "Dangly Knits", "Definitely Knot", "Destined to Design", "Doodlecrafts", "Draft to Craft", "Dreamcrafts", "Etched On My Art", "Every Knit As Good", "Fab Fabrics", "Fabric Antics", "Fabric Magic", "First Create", "Flair Play", "Flair is Fair", "Flair to Share", "Flair to Spare", "Flights of Fancy", "Flying Art", "For Art's Sake", "For Keep's Sake", "For the Most Art", "From the Art", "Full Seam Ahead", "Giftsakes", "Go With the Sew", "Handy Craft", "Handy Handmades", "Handy Hands", "Happily Ever Crafter", "Happy Designs", "Heart in Art", "Heart to Home", "Heavenly Handmade", "Hot Threads", "I Got Crafts", "I Sew It", "In Good Hands", "In Stitches", "In These Arts", "In a Stitch", "Itching for Stitching", "Knit Fit", "Knit Knot", "Knit Picks", "Knit Wit", "Knit by Knit", "Knit for the Gods", "Knitter Critter", "Knot Always", "Knot Done", "Knot Impossible", "Knot Lost", "Knot a Bit", "Knotty Knitters", "Make, Believe", "Many Hands", "My Flair Lady", "Near to My Art", "Needle in a Haystack", "Nightcrafts", "No Haste, No Waste", "Of the Arts", "One Little Knit", "Out of the Box", "Piece of My Art", "Pieces of Art", "Pocket Crafts", "Pulse Art", "Right From the Art", "Robin Wood", "Seam Come True", "Seam On", "Seam With Pride", "Seam World", "Seam's Right", "Sew Crafty", "Sew Flow", "Sew It Goes", "Sew It Happens", "Sew Loveley", "Sew Pretty", "Sew Sinful", "Sew Solutions", "Sew and Saw", "Sew and Sell", "Sew and Sew", "Sew of Hands", "Sew the Story Goes", "Sewley", "Sinful Soaps", "Smart Art", "Snip Snap", "So Far, Sew Good", "Spun Fun", "State of Create", "Stensability", "Stitch Away", "Stitch Itch", "Stitch-Perfect", "Sum of my Arts", "Sweet Craftations", "Sweet Scents", "Sweet Seams", "Textile Aisle", "Textile Smile", "Textile Style", "Textilophile", "That's Sew Creative", "The Art Bard", "The Art Box", "The Art Cart", "The Big Ball of Yarn", "The Craft Circus", "The Craft Crustacean", "The Craft Draft", "The Craft Room", "The Craft Zone", "The Flair Bear", "The Flair Lair", "The Flairy", "The More You Bow", "The Needle 'n Thread", "The Seam Dream", "The Seam Theme", "The Sew Show", "The Sewing Room", "The Stitch Kettle", "The Stitch Witch", "The Thread 'n Needle", "The Unique Boutique", "Thread and Buttons", "Thread of Roses", "Threaded Needle", "Tins and Needles", "To Be Flair", "True Knit", "Whimsical Woods", "Whole Knit and Caboodle", "Wildest Seams", "Wood That I Could", "Would Craft", "You Craft What You Sew", "You Imbued" };
			Random r = new Random();

			return nm1[r.Next(nm1.Length)];
		}

		public static class Names
		{
			public static string birdfolk()
			{
				string[] nm1 = { "", "", "", "c", "cr", "g", "gr", "k", "kr", "q", "qr", "r", "sk", "skr", "sq", "sqr", "sc", "z", "zr" };
				string[] nm2 = { "a", "i", "e", "o", "u", "a", "i", "i", "a", "e", "e", "a", "i", "e", "o", "u", "a", "i", "i", "a", "e", "e", "ai", "ee", "ia", "ie", "oo", "ua" };
				string[] nm3 = { "ai", "ee", "ia", "ie", "oo", "ua" };
				string[] nm4 = { "b", "c", "cc", "k", "n", "nn", "r", "rr", "s", "ss", "shr", "t", "y", "w" };
				string[] nm5 = { "", "", "k", "q", "t", "th", "w", "ww", "wk" };
				string[] nm6 = { "", "", "", "", "", "c", "cr", "g", "gh", "gr", "k", "kh", "q", "qh", "r", "rh", "sq", "sc", "z", "zr", "zh" };
				string[] nm7 = { "a", "i", "e", "o", "u", "a", "i", "i", "a", "e", "e", "a", "i", "e", "o", "u", "a", "i", "i", "a", "e", "e", "ee", "ea", "ei", "ia", "ie", "oo" };
				string[] nm8 = { "ee", "ea", "ei", "ia", "ie", "oo" };
				string[] nm9 = { "b", "bb", "c", "l", "ll", "n", "nn", "r", "rr", "s", "ss", "sh", "t", "y", "w" };
				string[] nm10 = { "", "", "", "", "", "h", "k", "n", "t", "th", "w", "ww" };
				string[] nm11 = { "", "", "", "", "", "c", "cr", "g", "gh", "gr", "k", "kr", "kh", "q", "qr", "qh", "sk", "r", "rh", "skr", "sq", "sqr", "sc", "z", "zr", "zh" };
				string[] nm12 = { "a", "i", "e", "o", "u", "a", "i", "i", "a", "e", "e", "a", "i", "e", "o", "u", "a", "i", "i", "a", "e", "e", "ai", "ee", "ea", "ei", "ia", "ie", "oo", "ua" };
				string[] nm13 = { "ai", "ee", "ea", "ei", "ia", "ie", "oo", "ua" };
				string[] nm14 = { "b", "bb", "c", "cc", "k", "l", "ll", "n", "nn", "r", "rr", "s", "ss", "sh", "shr", "t", "y", "w" };
				string[] nm15 = { "", "", "", "", "", "h", "k", "n", "t", "th", "w", "ww", "wk" };
				string br = "";

				Random r = new Random();

				int tp = r.Next(3) + 1;

				int rnd = 0;
				int rnd2 = 0;
				int rnd3 = 0;
				int rnd4 = 0;
				int rnd5 = 0;
				int rnd6 = 0;
				int rnd7 = 0;

				string names = "";

				for (int i = 0; i < 10; i++)
				{
					if (tp == 1)
					{
						rnd = r.Next(nm6.Length);
						rnd2 = r.Next(nm8.Length);
						rnd3 = r.Next(nm10.Length);
						if (i < 3)
						{
							while (rnd < 5)
							{
								rnd = r.Next(nm6.Length);
							}

							while (rnd3 < 5)
							{
								rnd3 = r.Next(nm10.Length);
							}
							names = nm6[rnd] + nm8[rnd2] + nm10[rnd3];
						}
						else
						{
							rnd2 = r.Next(nm7.Length);
							rnd5 = r.Next(nm7.Length);
							rnd4 = r.Next(nm9.Length);
							if (i < 8)
							{
								names = nm6[rnd] + nm7[rnd2] + nm9[rnd4] + nm7[rnd5] + nm10[rnd3];
							}
							else
							{
								rnd7 = r.Next(nm7.Length);
								rnd6 = r.Next(nm9.Length);
								while (nm9[rnd4] == nm9[rnd6])
								{
									rnd6 = r.Next(nm9.Length);
								}
								names = nm6[rnd] + nm7[rnd2] + nm9[rnd4] + nm7[rnd5] + nm9[rnd6] + nm7[rnd7] + nm10[rnd3];
							}
						}
					}
					else if (tp == 2)
					{
						rnd = r.Next(nm11.Length);
						rnd2 = r.Next(nm13.Length);
						rnd3 = r.Next(nm15.Length);
						if (i < 3)
						{
							while (rnd < 5)
							{
								rnd = r.Next(nm11.Length);
							}
							while (rnd3 < 5)
							{
								rnd3 = r.Next(nm15.Length);
							}
							names = nm11[rnd] + nm13[rnd2] + nm15[rnd3];
						}
						else
						{
							rnd2 = r.Next(nm12.Length);
							rnd5 = r.Next(nm12.Length);
							rnd4 = r.Next(nm14.Length);
							if (i < 8)
							{
								names = nm11[rnd] + nm12[rnd2] + nm14[rnd4] + nm12[rnd5] + nm15[rnd3];
							}
							else
							{
								rnd7 = r.Next(nm12.Length);
								rnd6 = r.Next(nm14.Length);
								while (nm14[rnd4] == nm14[rnd6])
								{
									rnd6 = r.Next(nm14.Length);
								}
								names = nm11[rnd] + nm12[rnd2] + nm14[rnd4] + nm12[rnd5] + nm14[rnd6] + nm12[rnd7] + nm15[rnd3];
							}
						}
					}
					else
					{
						rnd = r.Next(nm1.Length);
						rnd2 = r.Next(nm3.Length);
						rnd3 = r.Next(nm5.Length);
						if (i < 3)
						{
							while (rnd < 5)
							{
								rnd = r.Next(nm1.Length);
							}
							while (rnd3 < 5)
							{
								rnd3 = r.Next(nm5.Length);
							}
							names = nm1[rnd] + nm3[rnd2] + nm5[rnd3];
						}
						else
						{
							rnd2 = r.Next(nm2.Length);
							rnd5 = r.Next(nm2.Length);
							rnd4 = r.Next(nm4.Length);
							if (i < 8)
							{
								names = nm1[rnd] + nm2[rnd2] + nm4[rnd4] + nm2[rnd5] + nm5[rnd3];
							}
							else
							{
								rnd7 = r.Next(nm2.Length);
								rnd6 = r.Next(nm4.Length);
								while (nm4[rnd4] == nm4[rnd6])
								{
									rnd6 = r.Next(nm4.Length);
								}
								names = nm1[rnd] + nm2[rnd2] + nm4[rnd4] + nm2[rnd5] + nm4[rnd6] + nm2[rnd7] + nm5[rnd3];
							}
						}
					}
				}

				return Data.upperFirstLetter(names);
			}

			public static string blacksmith()
			{
				string[] nm1 = { "A Steel", "Adore Ore", "Anvil Crafts", "Anvil Mastery", "Anvil Works", "Anything Metal", "Arms of Steel", "Ball of Fire", "Balls of Fire", "Baptisms of Fire", "Bars of Steel", "Beat the Heat", "Beats of Fire", "Belly Fires", "Between Hammer and Anvil", "Blackstone Forge", "Blazing Blacksmiths", "Blazing Glory", "Blazing Trails", "Bloodbath & Beyond", "Blue Blazes", "Blue Steel", "Breathing Fire", "By Hammer and Hand", "By Hammer and Tongs", "Clamor Glamor", "Clamorize", "Clink 'n Clank", "Clobbering Time", "Curious Forge", "Dame of Flame", "Fame of Flame", "Fire & Brimstone", "Fire It Up", "Flame of Fame", "Flux Crux", "Flux Deluxe", "Forge and Fabricate", "Forge away", "Forging Ahead", "Forging Matters", "George's Forge", "Gorge 'n Forge", "Hammer 'n Anvil", "Hammer Clamor", "Hammer Down", "Hammer Glamor", "Hammer Home", "Hammer It Hot", "Hammer Out", "Hammer Time", "Hammer and Metal", "Hammer and Tongs", "Hammer in Hand", "He Who Smelt It", "Heat Up", "Heat of the Moment", "Heavy Metal Works", "Heavy Metals", "Hot Hammer", "Hot Hot Hot", "Hot Iron", "Hot Rod", "Hot Spot", "Hot Stuff", "Hot diggety dog!", "Hot diggety!", "Hot-Shot", "In Flux", "Ingot This", "Iron Designs", "Iron Man", "Iron Woman", "Iron in the Fire", "Ironclad", "Just Enough Irons", "Like Moths", "Making It Hot", "Matter of Metal", "Metal Accent", "Metal Arts", "Metal Expertise", "Metal Fabrications", "Metal Mania", "Metal Maniac", "Metal Mastery", "Metal Pandemonium", "Metal Trades", "Metal Works", "Metallurgy", "Metalworks", "Metalworks of Art", "Mind Over Matter", "Mind Over Metal", "Mineral Minded", "Mineral Works", "Mr Smith", "Mrs Smith", "Nerves of Steel", "Nice Ring To It", "Ore Decor", "Ore Else", "Ore Galore", "Ore Really", "Ore Restore", "Ore Store", "Parent Rock", "Phoenix Fire", "Pound World", "Real Steel", "Ring to It", "Rings True", "Smelt Art", "Smelt My Hearth", "Smelt in my Arms", "Smelting Pot", "Smelts of Heaven", "Smelts of Roses", "Smite Thee", "Smith Thee", "Smithen", "Smitten", "Sparks and Flames", "Squeal of Steel", "Steel Appeal", "Steel Arms", "Steel Base", "Steel Fabrications", "Steel Ideal", "Steel Show", "Steel Thunder", "Steel Wings", "Stop! Hammer Time", "Striking Hot", "Sword in the Forge", "Sword in the Stone", "The Ancient Anvil", "The Blacksmith's Forge", "The Clamor Shop", "The Clank Tank", "The Clinker Shop", "The Cobalt Forge", "The Eternal Flame", "The Fire Spire", "The Fire Squire", "The Flame Game", "The Gorge Forge", "The Heat is On", "The Hot Forge", "The Hot Ticket", "The Inferno Forge", "The Iron's Hot", "The Metal Petal", "The Phoenix Forge", "The Right Clank", "The Smelt Belt", "The Smelt Celt", "The Smith Myth", "The Smithy", "The Storm Forge", "The Tilted Anvil", "The Unbreakable Anvil", "There Be Smoke", "True as Steel", "Under Construction", "While the Iron's Hot", "Young Flames" };
				string br = "";

				Random r = new Random();

				return nm1[r.Next(nm1.Length)];
			}

			public static string bountyHunter()
			{
				string[] nm1 = { "Angel", "Ape", "Arrow", "Ash", "Asp", "Azrael", "Ballista", "Bane", "Barb", "Bassilisk", "Bear", "Beast", "Bilge", "Bingo", "Blackjack", "Blade", "Blaze", "Blight", "Blink", "Blitz", "Bolt", "Boomer", "Boon", "Brass", "Brute", "Buffet", "Bull", "Bulldozer", "Bullet", "Bulwark", "Buzz", "Canine", "Chase", "Cipher", "Cloak", "Cloud", "Cobra", "Coil", "Comet", "Crater", "Crisis", "Crook", "Crow", "Cruise", "Crux", "Daemon", "Dagger", "Dash", "Deadlock", "Death", "Diablo", "Discount", "Dog", "Domino", "Doom", "Dragon", "Drake", "Dusk", "Edge", "Face", "Falcon", "Fang", "Fence", "Fetch", "Fiend", "Filch", "Flame", "Flash", "Flint", "Fluke", "Fox", "Gargoyle", "Ghost", "Glitch", "Gloom", "Goliath", "Gorge", "Grave", "Gray", "Grim", "Grimace", "Guarde", "Gunner", "Gut", "Harm", "Hatchet", "Haunt", "Hawk", "Haze", "Hero", "Hex", "Hollow", "Hook", "Hound", "Hunter", "Hush", "Image", "Jag", "Jet", "Jingo", "Knave", "Lance", "Light", "Locus", "Lore", "Lupus", "Lurch", "Lynch", "Mace", "Mane", "Manes", "Mark", "Mask", "Memento", "Midnight", "Mime", "Mite", "Mockingbird", "Mongrel", "Mug", "Musket", "Mute", "Myth", "Necro", "Nemo", "Night", "Nightshade", "Nil", "Nix", "Onyx", "Orbit", "Padlock", "Paradox", "Paragon", "Phantom", "Pierce", "Pinch", "Pivot", "Predator", "Pyro", "Quill", "Quiver", "Ranger", "Rascal", "Ratchet", "Rattle", "Reaper", "Retch", "Robin", "Rocket", "Rogue", "Ronin", "Rush", "Rust", "Rustle", "Saber", "Savage", "Scab", "Scar", "Scarf", "Scotch", "Scratch", "Scythe", "Scyther", "Seal", "Sentinel", "Seraph", "Shade", "Shadow", "Shank", "Shepherd", "Shin", "Shiver", "Shotgun", "Shroud", "Silver", "Sin", "Slash", "Sly", "Smith", "Smudge", "Snake", "Snow", "Soul", "Spark", "Spectre", "Spike", "Splinter", "Spot", "Storm", "Stranger", "Swagger", "Taint", "Talon", "Thorne", "Tide", "Titan", "Tomb", "Tooth", "Totem", "Tracer", "Trump", "Tusk", "Twitch", "Tyran", "Umbra", "Vain", "Veil", "Venin", "Venom", "Veto", "Viper", "Virtue", "Visage", "Vise", "Void", "Wane", "Whisper", "Wither", "Wolf", "Wraith", "Wright", "X", "Zero" };
				string[] nm2 = { "Aegis", "Allure", "Angel", "Arrow", "Ash", "Azraelle", "Azure", "Ballista", "Banshee", "Barb", "Beauty", "Blaze", "Blesse", "Blight", "Blink", "Blitz", "Brass", "Bridesmaid", "Brook", "Cat", "Celeste", "Charm", "Cicatrix", "Cloud", "Clover", "Comet", "Cover", "Coyote", "Crisis", "Critter", "Crux", "Curse", "Dagger", "Dash", "Dawn", "Dawne", "Death", "Deity", "Demise", "Desire", "Destiny", "Diamond", "Dilemma", "Ditch", "Dove", "Ebony", "Echo", "Eclipse", "Enigma", "Envy", "Essence", "Fable", "Fae", "Faith", "Fang", "Faze", "Feather", "Feline", "Ferine", "Fetch", "Figment", "Flair", "Flame", "Flow", "Flower", "Flux", "Fortune", "Foxy", "Freak", "Gem", "Ghost", "Gin", "Glitch", "Gloome", "Grim", "Grimace", "Haze", "Hex", "Hope", "Huntress", "Hush", "Image", "Ivory", "Jewel", "Jinx", "Karma", "Kelpie", "Kindle", "Kiss", "Lash", "Light", "Locus", "Lore", "Lotus", "Lullaby", "Lumen", "Luna", "Lynch", "Mace", "Maiden", "Maim", "Maime", "Mime", "Mince", "Mini", "Mirage", "Mischief", "Misery", "Mist", "Mockingbird", "Moon", "Morose", "Mouse", "Myth", "Nada", "Nebula", "Nemo", "Nettle", "Night", "Nighte", "Nightshade", "Nil", "Nix", "Numen", "Oracle", "Paradox", "Peach", "Pearl", "Penumbra", "Phantasma", "Pickle", "Primrose", "Pyro", "Queen", "Quest", "Queste", "Quill", "Rags", "Raine", "Rattle", "Raven", "Riddle", "Robin", "Rogue", "Rumor", "Rush", "Sabre", "Sage", "Scarf", "Scotch", "Scratch", "Serenity", "Shade", "Shadow", "Shepherd", "Silence", "Silver", "Sin", "Slice", "Smile", "Snare", "Snowflake", "Spark", "Sparkle", "Sparrow", "Sphinx", "Spice", "Sprite", "Squint", "Starlight", "Stiletto", "Storm", "Stranger", "Tainte", "Tare", "Thistle", "Tide", "Tigress", "Trace", "Tragedy", "Trauma", "Trickster", "Trixy", "Twilight", "Twinkle", "Twitch", "Umbra", "Veil", "Vex", "Virtue", "Vision", "Web", "Wendigo", "Whisper", "Wish", "Witch", "Woe", "X", "Zero", "Zot" };
				string[] nm3 = { "Aegis", "Angel", "Arrow", "Ash", "Asp", "Azrael", "Ballista", "Barb", "Bingo", "Blade", "Blaze", "Blight", "Blink", "Blitz", "Brass", "Bullet", "Buzz", "Canine", "Chase", "Cloak", "Cloud", "Coil", "Comet", "Cover", "Coyote", "Crisis", "Critter", "Crow", "Crux", "Curse", "Dagger", "Dash", "Dawn", "Death", "Discount", "Ditch", "Domino", "Dragon", "Dusk", "Echo", "Edge", "Fable", "Falcon", "Fang", "Faze", "Fetch", "Figment", "Flame", "Flash", "Flow", "Fluke", "Flux", "Fortune", "Fox", "Ghost", "Gin", "Glitch", "Gloom", "Grim", "Grimace", "Hatchet", "Haze", "Hero", "Hex", "Hush", "Image", "Jingo", "Karma", "Kindle", "Lash", "Light", "Locus", "Lore", "Lynch", "Mace", "Maim", "Memento", "Midnight", "Mime", "Mince", "Mini", "Mirage", "Mist", "Mite", "Mockingbird", "Mongrel", "Moon", "Morose", "Mouse", "Mute", "Myth", "Nemo", "Nettle", "Night", "Nightshade", "Nil", "Nix", "Numen", "Onyx", "Orbit", "Padlock", "Paradox", "Paragon", "Penumbra", "Phantom", "Pickle", "Pinch", "Pyro", "Quest", "Quill", "Quiver", "Rags", "Raine", "Ranger", "Rascal", "Ratchet", "Rattle", "Raven", "Reaper", "Riddle", "Robin", "Rocket", "Rogue", "Ronin", "Rush", "Rust", "Rustle", "Saber", "Sabre", "Savage", "Scar", "Scarf", "Scotch", "Scratch", "Scythe", "Seal", "Seraph", "Shade", "Shadow", "Shank", "Shepherd", "Shiver", "Shroud", "Silence", "Silver", "Sin", "Slash", "Slice", "Sly", "Smile", "Smudge", "Snake", "Snare", "Snow", "Spark", "Sparrow", "Spice", "Squint", "Storm", "Stranger", "Taint", "Talon", "Thistle", "Thorne", "Tide", "Totem", "Trace", "Tracer", "Trauma", "Trumps", "Twilight", "Twitch", "Tyran", "Umbra", "Vain", "Veil", "Venin", "Venom", "Veto", "Vex", "Viper", "Virtue", "Visage", "Vise", "Vision", "Whisper", "Wish", "Wither", "Woe", "Wolf", "X", "Zero", "Zot" };

				Random r = new Random();
				int tp = r.Next();

				switch (tp)
				{
					case 1:
						return nm2[r.Next(nm2.Length)];
						break;
					case 2:
						return nm3[r.Next(nm3.Length)];
						break;
					default:
						return nm1[r.Next(nm1.Length)];
						break;
				}
			}

			public static string bow()
			{
				string[] nm1 = { "Hornet's Sting", "Blackened Sky", "Darkened Sky", "Steel Hail", "Archangel", "Archdemon", "Arcus", "Armadillo", "Armageddon", "Arrowsong", "Arrowspike", "Avalance", "Back Pain", "Backsnipe", "Ballista", "Barrage", "Beesting", "Betrayal", "Betrayal's Sting", "Bolt", "Bolt Action", "Bon Voyage", "Bristleblitz", "Bullseye", "Calamity", "Chimera", "Clutch", "Comet", "Courier", "Crier", "Curvey", "Cyclone", "Dash", "Dead Air", "Death's Kiss", "Death's Sigh", "Death's Whisper", "Decimate", "Deliverance", "Deluge", "Destiny's Song", "Devil's Kiss", "Devil's Recurve", "Devil's Sting", "Devil's Whisper", "Doomcaster", "Drawback", "Drawling", "Drawstring", "Dream Catcher", "Eagle", "Eagle Strike", "Emily's Curve", "Euthanasia", "Eye of Eternity", "Eye of Fidelity", "Eye of Precision", "Eye of Truth", "Falling Star", "Featherdraw", "Final Breath", "Final Voyage", "Final Whisper", "Final Whistle", "Firestarter", "Fling", "Flux", "Fury", "Gargoyle", "Graviton", "Hailstorm", "Hamstring", "Hamstrung", "Harbinger", "Hatred's Sting", "Hawkeye", "Heartbeat", "Heartpiercer", "Heartstriker", "Heartstring", "Hedgehog", "Hell's Whistle", "High-Strung", "Hooty Tooty Aim and Shooty", "Hope's End", "Hornet", "Huntress", "Hurricane", "Hush", "Imminent Doom", "Impending Doom", "Irk", "Jugular", "Kiss of Death", "Lash", "Last Kiss", "Last Vision", "Last Whisper", "Lightning", "Lightning Strike", "Long Shot", "Messenger", "Meteor", "Meteor Strike", "Midge", "Mirage", "Misery's End", "Molten Fury", "Mosquito", "Needle Shooter", "Needle Threader", "Netherstrand", "Penetrator", "Perfidy", "Phantom", "Phantom Strike", "Phoenix", "Pierce", "Pinch", "Pique", "Pluck", "Porcupine", "Precise", "Precision", "Prickle", "Prophet", "Puncture", "Quickstrike", "Quillshooter", "Quintain", "Rain Maker", "Razorsong", "Razorwind", "Recurve", "Rigormortis", "Salvation", "Scorpio", "Scorpion", "Scorpion Sting", "Shadow Strike", "Shadow's Bane", "Shadow's Strike", "Shatter Storm", "Shooting Star", "Shriek", "Silent Messenger", "Silentsong", "Siren's Call", "Siren's Cry", "Siren's Song", "Sky Piercer", "Skyfire", "Snatch", "Snipe", "Snitch", "Soulstring", "Special Delivery", "Spitfire", "Splinter", "Splintermark", "Squawk", "Squirm", "Star's Fury", "Starshot", "Starstruck", "Sting", "Stormsong", "Striker's Mark", "Stryker", "Sudden Death", "Surprise", "Swiftwind", "Swoosh", "Talonstrike", "Tempest", "The Ambassador", "The Messenger", "Thunder", "Thunderstrike", "Tiebreaker", "Tranquility", "Trophy Chord", "Trophy Gatherer", "Trophy Mark", "Truestrike", "Tweak", "Twisted", "Twister", "Twitch", "Typhoon", "Valkyrie", "Vehement Chord", "Venomstrike", "Viper", "Vixen", "Vulture", "Warsong", "Wasp", "Wasp's Sting", "Whelm", "Whisper", "Whisperwind", "Windbreaker", "Windforce", "Windlass", "Windrunner", "Windstalker", "Windtalker", "WithDraw" };
				string[] nm2 = { "Advanced", "Amber Infused", "Ancient", "Anguish'", "Annihilation", "Antique", "Arcane", "Arched", "Archer's", "Assassination", "Atuned", "Bandit's", "Baneful", "Banished", "Barbarian", "Barbaric", "Battleworn", "Blazefury", "Blessed", "Blood Infused", "Bloodcursed", "Bloodied", "Bloodlord's", "Bloodsurge", "Bloodvenom", "Bone Crushing", "Bowman's", "Brutal", "Brutality", "Burnished", "Cataclysm", "Cataclysmic", "Charmed", "Corrupted", "Crazed", "Crying", "Cursed", "Curved", "Dancing", "Defiled", "Deluded", "Demonic", "Deserted", "Desire's", "Desolation", "Destiny's", "Dire", "Doom", "Doom's", "Dragon's", "Dragonbreath", "Dreadful", "Ebon", "Eerie", "Enchanted", "Engraved", "Eternal", "Ethereal", "Executing", "Exiled", "Expert's", "Extinction", "Faith's", "Faithful", "Fancy", "Fearful", "Feather-Wrapped", "Featherdraw", "Feral", "Fierce", "Fiery", "Fine", "Firestorm", "Flimsy", "Forsaken", "Fortune's", "Fragile", "Frail", "Frenzied", "Frost", "Frozen", "Furious", "Fusion", "Ghastly", "Ghostly", "Gladiator", "Gladiator's", "Grieving", "Guard's", "Guardian's", "Hateful", "Haunted", "Heavy", "Hollow", "Holy", "Honed", "Honor's", "Hope's", "Hopeless", "Howling", "Hungering", "Improved", "Incarnated", "Infused", "Inherited", "Isolated", "Jade Infused", "Judgement", "Liar's", "Lich", "Lightning", "Lonely", "Loyal", "Lustful", "Lusting", "Mage's", "Malevolent", "Malicious", "Malignant", "Massive", "Master Hunter's", "Mended", "Mercenary", "Military", "Misfortune's", "Mourning", "Nightmare", "Nightstalker", "Ominous", "Peacekeeper", "Phantom", "Possessed", "Pride's", "Prideful", "Primitive", "Promised", "Protector's", "Proud", "Ranger's", "Recruit's", "Reincarnated", "Relentless", "Remorseful", "Renewed", "Renovated", "Replica", "Restored", "Retribution", "Ritual", "Roaring", "Savage", "Oathkeeper's", "Shadow", "Shadowleaf", "Shrieking", "Silent", "Singed", "Singing", "Sinister", "Skullforge", "Skyfall", "Smooth", "Solitude's", "Sorrow's", "Soul", "Soul Infused", "Soulcursed", "Soulless", "Spectral", "Spiteful", "Storm", "Storm's", "Stormfury", "Stormguard", "Stout", "Striker's", "Sturdy", "Terror", "Thirsting", "Thirsty", "Thunder", "Thunderfury", "Thunderguard", "Thundersoul", "Timeworn", "Tormented", "Tracking", "Trainee's", "Trapper's", "Treachery's", "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vengeance", "Vengeful", "Venom", "Vicious", "Vindication", "Vindictive", "Void", "Volcanic", "Vowed", "War-Forged", "Warlord's", "Warp", "Warped", "Warsong", "Well Crafted", "Whistling", "Wicked", "Wind's", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Yielding", "Zealous" };
				string[] nm3 = { "Ashwood", "Bone", "Bronzed", "Driftwood", "Ebon", "Hardwood", "Iron", "Ironbark", "Maple", "Oak", "Redwood", "Skeletal", "Steel", "Titanium", "Warpwood", "Willow", "Yew" };
				string[] nm4 = { "Longbow", "Shortbow", "Crossbow", "Speargun", "Launcher", "Repeater", "Shooter", "Crossfire", "Bolter", "Heavy Crossbow", "Arbalest", "Piercer", "Striker", "Warbow", "Chord", "Recurve", "Bow", "Compound Bow", "Hunting Bow", "Warp-Bow", "Flatbow", "Reflex Bow", "Composite Bow", "Compound Crossbow", "Straight Bow", "Self Bow" };
				string[] nm5 = { "Annihilation", "Arbalest", "Arch", "Betrayer", "Bite", "Bolter", "Bond", "Boon", "Bow", "Breaker", "Bringer", "Call", "Champion", "Chord", "Composite Bow", "Compound Bow", "Crescent", "Crook", "Crossbow", "Crossfire", "Cry", "Cunning", "Curve", "Dawn", "Defiler", "Destroyer", "Eclipse", "Ellipse", "Ender", "Etcher", "Executioner", "Eye", "Favor", "Ferocity", "Flatbow", "Foe", "Gift", "Glory", "Guardian", "Heavy Crossbow", "Heirloom", "Hope", "Hunting Bow", "Incarnation", "Kiss", "Last Hope", "Last Stand", "Launcher", "Legacy", "Longbow", "Memory", "Might", "Oath", "Pact", "Piercer", "Pique", "Pledge", "Poke", "Prick", "Promise", "Protector", "Ravager", "Reach", "Recurve", "Reflex Bow", "Repeater", "Savagery", "Secret", "Self Bow", "Shooter", "Shortbow", "Skewer", "Soul", "Speargun", "Spike", "Spine", "Straight Bow", "Striker", "String", "Terror", "Token", "Tribute", "Vengeance", "Voice", "Warbow", "Warp-Bow", "Whisper", "Wit" };
				string[] nm6 = { "of Agony", "of Ancient Power", "of Anguish", "of Ashes", "of Assassins", "of Black Magic", "of Blessed Fortune", "of Blessings", "of Blight", "of Blood", "of Bloodlust", "of Broken Bones", "of Broken Dreams", "of Broken Families", "of Burdens", "of Chaos", "of Closing Eyes", "of Conquered Worlds", "of Corruption", "of Cruelty", "of Cunning", "of Dark Magic", "of Dark Souls", "of Darkness", "of Decay", "of Deception", "of Degradation", "of Delusions", "of Denial", "of Desecration", "of Diligence", "of Dismay", "of Dragonsouls", "of Due Diligence", "of Echoes", "of Ended Dreams", "of Ending Hope", "of Ending Misery", "of Eternal Bloodlust", "of Eternal Damnation", "of Eternal Glory", "of Eternal Justice", "of Eternal Rest", "of Eternal Sorrow", "of Eternal Struggles", "of Eternity", "of Executions", "of Faded Memories", "of Fallen Souls", "of Fools", "of Frost", "of Frozen Hells", "of Fury", "of Giants", "of Giantslaying", "of Grace", "of Grieving Widows", "of Hate", "of Hatred", "of Hell's Games", "of Hellish Torment", "of Heroes", "of Holy Might", "of Honor", "of Hope", "of Horrid Dreams", "of Horrors", "of Illuminated Dreams", "of Illumination", "of Immortality", "of Inception", "of Infinite Trials", "of Insanity", "of Invocation", "of Justice", "of Light's Hope", "of Lost Comrades", "of Lost Hope", "of Lost Voices", "of Lost Worlds", "of Magic", "of Mercy", "of Misery", "of Mountains", "of Mourning", "of Mystery", "of Necromancy", "of Nightmares", "of Oblivion", "of Perdition", "of Phantoms", "of Power", "of Pride", "of Pride's Fall", "of Putrefaction", "of Reckoning", "of Redemption", "of Regret", "of Riddles", "of Secrecy", "of Secrets", "of Shadow Strikes", "of Shadows", "of Shifting Sands", "of Shifting Worlds", "of Silence", "of Slaughter", "of Souls", "of Stealth", "of Storms", "of Subtlety", "of Suffering", "of Suffering's End", "of Summoning", "of Terror", "of Thunder", "of Time-Lost Memories", "of Timeless Battles", "of Titans", "of Torment", "of Traitors", "of Trembling Hands", "of Trials", "of Truth", "of Twilight's End", "of Twisted Visions", "of Unholy Blight", "of Unholy Might", "of Vengeance", "of Visions", "of Wasted Time", "of Widows", "of Wizardry", "of Woe", "of Wraiths", "of Zeal", "of the Ancients", "of the Banished", "of the Basilisk", "of the Beast", "of the Blessed", "of the Breaking Storm", "of the Brotherhood", "of the Burning Sun", "of the Caged Mind", "of the Cataclysm", "of the Champion", "of the Claw", "of the Corrupted", "of the Covenant", "of the Crown", "of the Damned", "of the Daywalker", "of the Dead", "of the Depth", "of the Dreadlord", "of the Earth", "of the East", "of the Emperor", "of the Empty Void", "of the End", "of the Enigma", "of the Fallen", "of the Falling Sky", "of the Flame", "of the Forest", "of the Forgotten", "of the Forsaken", "of the Gladiator", "of the Harvest", "of the Immortal", "of the Incoming Storm", "of the Insane", "of the King", "of the Lasting Night", "of the Leviathan", "of the Light", "of the Lion", "of the Lionheart", "of the Lone Victor", "of the Lone Wolf", "of the Lost", "of the Moon", "of the Moonwalker", "of the Night Sky", "of the Night", "of the Nightstalker", "of the North", "of the Occult", "of the Oracle", "of the Phoenix", "of the Plague", "of the Prince", "of the Protector", "of the Queen", "of the Serpent", "of the Setting Sun", "of the Shadows", "of the Sky", "of the South", "of the Stars", "of the Storm", "of the Summoner", "of the Sun", "of the Sunwalker", "of the Talon", "of the Undying", "of the Victor", "of the Void", "of the West", "of the Whispers", "of the Wicked", "of the Wind", "of the Wolf", "of the World", "of the Wretched" };
				string[] nm7 = { "Archangel", "Archdemon", "Arcus", "Armadillo", "Armageddon", "Arrowsong", "Arrowspike", "Avalance", "Back Pain", "Backsnipe", "Ballista", "Barrage", "Beesting", "Betrayal", "Betrayal's Sting", "Bolt", "Bon Voyage", "Bristleblitz", "Bullseye", "Calamity", "Chimera", "Clutch", "Comet", "Courier", "Crier", "Curvey", "Cyclone", "Dash", "Dead Air", "Death's Kiss", "Death's Sigh", "Death's Whisper", "Decimate", "Deliverance", "Deluge", "Destiny's Song", "Devil's Kiss", "Devil's Recurve", "Devil's Sting", "Devil's Whisper", "Doomcaster", "Drawback", "Drawling", "Drawstring", "Dream Catcher", "Eagle", "Eagle Strike", "Emily's Curve", "Euthanasia", "Falling Star", "Featherdraw", "Firestarter", "Fling", "Flux", "Fury", "Gargoyle", "Graviton", "Hailstorm", "Hamstring", "Hamstrung", "Harbinger", "Hatred's Sting", "Hawkeye", "Heartbeat", "Heartpiercer", "Heartstriker", "Heartstring", "Hedgehog", "Hell's Whistle", "High-Strung", "Hope's End", "Hornet", "Huntress", "Hurricane", "Hush", "Irk", "Jugular", "Kiss of Death", "Lash", "Lightning", "Long Shot", "Messenger", "Meteor", "Midge", "Mirage", "Misery's End", "Molten Fury", "Mosquito", "Netherstrand", "Penetrator", "Perfidy", "Phantom", "Phantom Strike", "Phoenix", "Pierce", "Pinch", "Pique", "Pluck", "Porcupine", "Precise", "Precision", "Prickle", "Prophet", "Puncture", "Quickstrike", "Quintain", "Rain Maker", "Razorsong", "Razorwind", "Recurve", "Rigormortis", "Salvation", "Scorpio", "Scorpion", "Shadow Strike", "Shooting Star", "Shriek", "Silent Messenger", "Silentsong", "Siren's Call", "Siren's Cry", "Siren's Song", "Sky Piercer", "Skyfire", "Snatch", "Snipe", "Snitch", "Soulstring", "Spitfire", "Splinter", "Splintermark", "Squawk", "Squirm", "Star's Fury", "Starshot", "Starstruck", "Sting", "Stormsong", "Stryker", "Surprise", "Swiftwind", "Swoosh", "Talonstrike", "Tempest", "The Ambassador", "The Messenger", "Thunder", "Thunderstrike", "Tiebreaker", "Tranquility", "Truestrike", "Tweak", "Twisted", "Twister", "Twitch", "Typhoon", "Valkyrie", "Venomstrike", "Viper", "Vixen", "Vulture", "Warsong", "Wasp", "Whelm", "Whisper", "Whisperwind", "Windbreaker", "Windforce", "Windlass", "Windrunner", "Windstalker", "Windtalker", "WithDraw" };

				Random r = new Random();

				int i = r.Next(10);

				if (i < 3)
				{
					return nm1[r.Next(nm1.Length)];
				}
				else if (i < 5)
				{
					return nm3[r.Next(nm3.Length)]+ " " + nm4[r.Next(nm4.Length)];
				}
				else if (i < 7)
				{
					return nm2[r.Next(nm2.Length)]+ " " + nm3[r.Next(nm3.Length)]+ " " + nm4[r.Next(nm4.Length)];
				}
				else
				{
					return nm7[r.Next(nm7.Length)]+ ", " + nm5[r.Next(nm5.Length)]+ " " + nm6[r.Next(nm6.Length)];
				}
			}

			public static string bridge()
			{
				string[] nm1 = { "Abandoned", "Admired", "Adored", "Aged", "Anchored", "Ancient", "Angelic", "Antique", "Austere", "Autumn", "Bare", "Barren", "Big", "Black", "Bland", "Blank", "Bleak", "Blond", "Blue", "Bold", "Bouncy", "Brave", "Bright", "Broken", "Bronze", "Brown", "Burly", "Calm", "Capital", "Chief", "Classic", "Clear", "Coarse", "Cold", "Colossal", "Common", "Complex", "Composed", "Conquest", "Courage", "Crimson", "Crystal", "Dark", "Dearest", "Deep", "Deepest", "Defiant", "Deserted", "Diamond", "Diligent", "Double", "Dry", "East", "Elegant", "Emerald", "Empty", "Enchanted", "Enlightened", "Exalted", "Fair", "Free", "Freedom", "Gentle", "Giant", "Glistening", "Golden", "Graceful", "Grand", "Grim", "Grizzly", "Harmony", "Heavenly", "Heavy", "Hollow", "Humble", "Idle", "Infinite", "Infinity", "Innocence", "International", "Iron", "Jade", "Jagged", "Last", "Liberty", "Light", "Little", "Lone", "Lonely", "Long", "Lost", "Majestic", "Major", "Mammoth", "Massive", "Mellow", "Merry", "Millennium", "Misty", "Mithril", "Muddy", "Murky", "Mysterious", "Mystery", "Narrow", "New", "North", "Old", "Open", "Ornate", "Oval", "Pale", "Parallel", "Peace", "Peaceful", "Plain", "Pleasant", "Precious", "Pride", "Prime", "Pristine", "Proud", "Pure", "Quiet", "Regal", "Remote", "Round", "Royal", "Ruby", "Rusty", "Sandy", "Sapphire", "Serene", "Serenity", "Serpent", "Shallow", "Sharp", "Shimmering", "Short", "Silent", "Silver", "Simple", "Single", "Sleepy", "Slim", "Small", "Smooth", "Somber", "South", "Spring", "Steel", "Stormy", "Straight", "Summer", "Tall", "Thin", "Tranquility", "Trinity", "Twin", "Velvet", "Victory", "Warped", "West", "Wide", "Wild", "Winding", "Windy", "Winter" };
				string[] nm2 = { "Abyss", "Arch", "Avenue", "Bank", "Banks", "Bay", "Beach", "Bluff", "Border", "Branch", "Brim", "Brink", "Brook", "Canal", "Canyon", "Cay", "Chasm", "Cliff", "Coast", "Creek", "Edge", "Estuary", "Falls", "Flow", "Gate", "Gates", "Gateway", "Glacier", "Gorge", "Gulch", "Harbor", "Haven", "Inlet", "Island", "Isle", "Jubilee", "Lake", "Lane", "Ledge", "Memorial", "Pass", "Passage", "Path", "Point", "Port", "Portal", "Ravine", "River", "Road", "Route", "Sails", "Shore", "Spring", "Star", "Stream", "Street", "Summit", "Terrace", "Trail", "Tributary", "Vale", "Valley", "Water", "Way", "Wharf" };
				string[] nm3 = { "Bridge", "Bridge", "Bridge", "Bridge", "Overpass", "Viaduct", "Aqueduct", "Suspension Bridge", "Footbridge", "Crossing", "Bridge", "Bridge", "Bridge", "Bridge", "Bridge", "Bridge", "Bridge", "Bridge" };
				string[] nm4 = { "la Passerelle", "le Pont", "le Pont", "le Pont", "le Pont", "le Pont", "le Pont", "le Viaduc", "l'Aqueduc" };
				string[] nm5a = { "Éclairé", "Élégant", "Éloigné", "Émeraude", "Énorme", "Épais", "Étroit", "Abandonné", "Admiré", "Adoré", "Agréable", "Ancien", "Ancré", "Angélique", "Antique", "Aride", "Audacieux", "Austère", "Blanc", "Bleu", "Blond", "Boueux", "Brave", "Brillant", "Brumeux", "Brun", "Céleste", "Calme", "Capital", "Cassé", "Chatoyant", "Clair", "Colossal", "Complexe", "Composé", "Costaud", "Courageux", "Court", "Cramoisi", "Creux", "Déchiqueté", "Délaissé", "Déserté", "Dentelé", "Diligent", "Double", "Enchanté", "Essentiel", "Exalté", "Fade", "Foncé", "Fracturé", "Froid", "Géant", "Gracieux", "Grandiose", "Inactif", "Incarnat", "Infini", "International", "Isolé", "Jumeau", "Large", "Libre", "Lisse", "Lointain", "Lourd", "Majestueux", "Marron", "Mince", "Morne", "Mystérieux", "Nu", "Nuageux", "Obscur", "Orageux", "Ordinaire", "Orné", "Ouvert", "Ovale", "Pâle", "Pacifique", "Paisible", "Paradisiaque", "Parallèle", "Peu Profond", "Plongé", "Précieux", "Profond", "Pur", "Rouillé", "Royal", "Rude", "Sablonneux", "Sauvage", "Scintillant", "Sec", "Serein", "Silencieux", "Sinistre", "Solitaire", "Sombre", "Somnolent", "Stérile", "Tranchant", "Tranquille", "Transparent", "Velouté", "Venteux", "Vide", "Vieilli", "Vierge", "Voilé", "d'Été", "d'Acier", "d'Argent", "d'Automne", "d'Harmonie", "d'Hiver", "d'Infini", "d'Innocence", "d'Or", "de Bronze", "de Conquête", "de Courage", "de Défi", "de Diamant", "de Fer", "de Fierté", "de Géants", "de Jade", "de Liberté", "de Lumière", "de Mithril", "de Mystère", "de Paix", "de Printemps", "de Rubis", "de Sérénité", "de Saphir", "de Triomphe", "de Vaillance", "de Victoire", "de l'Est", "de l'Ouest", "de la Trinité", "du Millénaire", "du Nord", "du Serpent", "du Sud", "en Cristal" };
				string[] nm5b = { "Éclairée", "Élégante", "Éloignée", "Émeraude", "Énorme", "Épaise", "Étroite", "Abandonnée", "Admirée", "Adorée", "Agréable", "Ancienne", "Ancrée", "Angélique", "Antique", "Aride", "Audacieuse", "Austère", "Blanche", "Bleue", "Blonde", "Boueuse", "Brave", "Brillante", "Brumeuse", "Brune", "Céleste", "Calme", "Capitale", "Cassée", "Chatoyante", "Claire", "Colossale", "Complexe", "Composée", "Costaud", "Courageuse", "Courte", "Cramoisie", "Creuse", "Déchiquetée", "Délaissée", "Désertée", "Dentelée", "Diligente", "Double", "Enchantée", "Essentielle", "Exaltée", "Fade", "Foncée", "Fracturée", "Froide", "Géante", "Gracieuse", "Grandiose", "Inactive", "Incarnate", "Infinie", "Internationale", "Isolée", "Jumelle", "Large", "Libre", "Lisse", "Lointaine", "Lourde", "Majestueuse", "Marron", "Mince", "Morne", "Mystérieuse", "Nue", "Nuageuse", "Obscure", "Orageuse", "Ordinaire", "Ornée", "Ouverte", "Ovale", "Pâle", "Pacifique", "Paisible", "Paradisiaque", "Parallèle", "Peu Profonde", "Plongée", "Précieuse", "Profonde", "Pure", "Rouillée", "Royale", "Rude", "Sablonneuse", "Sauvage", "Scintillante", "Sèche", "Sereine", "Silencieuse", "Sinistre", "Solitaire", "Sombre", "Somnolente", "Stérile", "Tranchante", "Tranquille", "Transparente", "Veloutée", "Venteuse", "Vide", "Vieillie", "Vierge", "Voilée" };
				string[] nm6 = { "de l'Étoile", "de l'Île", "de l'Arche", "de la Baie", "de la Banque", "de la Côte", "de la Cascade", "de la Cime", "de l'Eau", "de la Falaise", "de la Frontière", "de la Gorge", "de la Mer", "de la Passe", "de la Piste", "de la Plage", "de la Pointe", "de la Porte", "de la Rive", "de la Rivière", "de la Route", "de la Rue", "de la Source", "de la Terrasse", "de la Vallée", "de la Voie", "de l'Abîme", "de l'Abysse", "de l'Affluent", "du Bord", "du Canal", "du Canyon", "du Chemin", "du Courant", "de l'Estuaire", "du Fleuve", "du Flot", "du Glacier", "du Gouffre", "du Havre", "du Jardin", "du Jubilé", "du Lac", "du Mémorial", "du Passage", "du Point", "du Port", "du Portail", "du Quai", "du Ravin", "du Rivage", "du Ruisseau", "du Sentier", "du Sommet" };

				string[] nm13 = { "Ab", "Al", "Ala", "Alber", "Aller", "Am", "Ames", "An", "Anti", "Apple", "Ar", "Arbor", "Arling", "Arn", "As", "Ash", "Atha", "Ati", "Attle", "Autumn", "Avon", "Bain", "Bal", "Ban", "Bar", "Bark", "Barn", "Barr", "Barring", "Bas", "Battle", "Bax", "Bay", "Beacon", "Beau", "Beaver", "Bed", "Bedding", "Bell", "Belle", "Ben", "Bent", "Ber", "Beres", "Berk", "Berthier", "Bever", "Bex", "Bien", "Big", "Bir", "Birming", "Black", "Blain", "Bloom", "Blooms", "Blythe", "Bois", "Bol", "Bona", "Booth", "Bord", "Bos", "Boucher", "Box", "Brace", "Brad", "Breden", "Brent", "Bri", "Bridge", "Brigh", "Bright", "Brim", "Bris", "Bro", "Broad", "Brom", "Brook", "Bros", "Brown", "Bruder", "Buch", "Bucking", "Bur", "Burs", "Bux", "Cal", "Cale", "Cam", "Camp", "Can", "Cano", "Canter", "Car", "Cara", "Carbo", "Card", "Carig", "Carl", "Carle", "Carn", "Cart", "Cas", "Cau", "Causa", "Cha", "Cham", "Chan", "Chat", "Chats", "Chel", "Chelms", "Ches", "Chester", "Chi", "Chibou", "Chil", "Church", "Clare", "Claren", "Cler", "Clif", "Cliff", "Clin", "Co", "Coal", "Coati", "Coch", "Col", "Cole", "Coli", "Com", "Con", "Cor", "Corn", "Coro", "Cottle", "Coven", "Cowan", "Cres", "Cross", "Croy", "Cud", "Cumber", "Dal", "Dan", "Dar", "Dart", "Davel", "Day", "De", "Dead", "Ded", "Del", "Delis", "Delor", "Der", "Dig", "Dis", "Do", "Dol", "Donna", "Dor", "Dray", "Drum", "Dun", "Dupar", "Dur", "East", "Eato", "Eck", "Effing", "El", "Elling", "Ellis", "Elm", "Em", "Emer", "Ems", "En", "Engle", "Ep", "Es", "Ester", "Ever", "Ex", "Fair", "Fal", "Fall", "Farm", "Farming", "Farn", "Fer", "Flat", "Flem", "For", "Ford", "Framing", "Fran", "Free", "Gal", "Gallan", "Gam", "Gan", "Gana", "Gar", "Gati", "Gaul", "Gib", "Gil", "Glad", "Glas", "Glen", "Glou", "Glover", "Go", "Gode", "Gol", "Grace", "Graf", "Gran", "Grand", "Grave", "Gravel", "Graven", "Green", "Gren", "Gret", "Grim", "Gro", "Guil", "Had", "Hal", "Hali", "Ham", "Hamp", "Han", "Har", "Harp", "Hart", "Has", "Hast", "Hat", "Haver", "Heb", "Hep", "Here", "Hermi", "Haf", "Hil", "Hill", "Hills", "Hin", "Hing", "Holy", "Hors", "Hud", "Hul", "Hum", "Hunt", "Hunting", "Inger", "Innis", "Iro", "Irri", "Isling", "Itu", "Jol", "Kam", "Kapus", "Kear", "Keel", "Kensing", "Kerro", "Killing", "Kinder", "Kings", "Kini", "Kip", "Kir", "Kirk", "La", "Lam", "Lama", "Lan", "Lang", "Lani", "Lash", "Latch", "Laval", "Le", "Lea", "Leaming", "Lee", "Lei", "Lem", "Leo", "Liming", "Lin", "Litch", "Liver", "Locke", "Lon", "Lour", "Lum", "Lunen", "Luse", "Maca", "Mag", "Maho", "Maid", "Mal", "Malar", "Man", "Mani", "Mans", "Mar", "Mara", "Marl", "Mata", "May", "Meli", "Men", "Mens", "Meri", "Mid", "Mida", "Middle", "Middles", "Mil", "Mill", "Miller", "Mini", "Minne", "Monk", "Mont", "Moo", "Morin", "Mul", "Mun", "Mus", "Nai", "Nan", "Nee", "Neu", "New", "Newing", "Nia", "Nico", "Nipa", "Niver", "Noko", "Nor", "North", "Not", "Notting", "Oak", "Oge", "Oko", "Ono", "Oro", "Oso", "Otter", "Out", "Ox", "Pac", "Par", "Para", "Parr", "Pas", "Pel", "Pen", "Pene", "Peta", "Petro", "Pic", "Pil", "Pin", "Pla", "Plai", "Plain", "Ply", "Plym", "Pohe", "Pon", "Pono", "Port", "Ports", "Pres", "Pro", "Put", "Ra", "Rad", "Ray", "Read", "Reid", "Repen", "Rich", "Ridge", "Rim", "Rimou", "Ring", "River", "Ro", "Rob", "Roch", "Rock", "Rocking", "Rom", "Ros", "Rose", "Ross", "Rothe", "Row", "Rox", "Rug", "Rut", "Sag", "Sal", "Salis", "San", "Sand", "Sau", "Sava", "Scar", "Scars", "Sedge", "Senne", "Shau", "Shaw", "She", "Shef", "Shel", "Shell", "Sher", "Ship", "Shrew", "Shrews", "Sin", "Smi", "Smith", "Smiths", "Somer", "South", "Spring", "Staf", "Stam", "Stan", "Stel", "Stet", "Stock", "Stoke", "Stone", "Stough", "Straf", "Strat", "Sud", "Suf", "Summer", "Sun", "Sunder", "Sur", "Sus", "Sut", "Tam", "Taun", "Tecum", "Temis", "Temple", "Ter", "Terre", "Terren", "Thes", "Thessa", "Thet", "Thur", "Till", "Tis", "Tiver", "Tol", "Tor", "Torring", "Tray", "Tre", "Tren", "Tri", "Tro", "Tun", "Tur", "Twil", "Val", "Varen", "Vaux", "Vegre", "Ven", "Vent", "Ver", "Vir", "Von", "Vot", "Wa", "Wade", "Waka", "Wake", "Wal", "Wall", "Walling", "Wals", "Wape", "War", "Ware", "Wasa", "Water", "Way", "Welling", "Wes", "West", "Wey", "Whit", "White", "Wick", "Wil", "Willing", "Win", "Wind", "Winder", "Winter", "Wit", "Wolf", "Wood", "Wor", "Wrent", "Wyn", "Yar", "York" };
				string[] nm14 = { "balt", "bel", "berg", "berry", "biens", "bo", "boia", "bonear", "borg", "boro", "borough", "bour", "bourg", "briand", "bridge", "bron", "brook", "burg", "burn", "burns", "bury", "by", "cam", "cana", "carres", "caster", "castle", "cester", "chester", "chill", "cier", "cola", "coln", "cona", "cook", "cord", "couche", "cour", "croft", "dale", "dare", "de", "deen", "den", "der", "des", "diac", "ding", "don", "dosa", "dover", "down", "dows", "duff", "durn", "dwell", "fail", "fair", "fait", "fell", "field", "fil", "folk", "ford", "forte", "gamau", "gami", "gan", "gar", "gate", "geo", "gonie", "gough", "grave", "guay", "gue", "gueuil", "gus", "ham", "hampton", "hazy", "head", "heim", "heller", "her", "hill", "holm", "hurst", "isle", "jour", "kasing", "lam", "lams", "lan", "land", "lants", "leche", "lem", "let", "ley", "liers", "lin", "line", "linet", "ling", "lis", "lisle", "lita", "lodge", "low", "ly", "mack", "magne", "man", "mar", "mark", "meda", "meny", "mer", "mere", "meuse", "ming", "minster", "miota", "mis", "mond", "mont", "more", "mouth", "na", "nach", "nan", "near", "neau", "net", "ney", "nia", "nigan", "ning", "nola", "noque", "nora", "par", "pawa", "pids", "pon", "pond", "pool", "port", "quet", "raine", "ram", "rane", "rath", "ree", "rey", "rial", "rich", "riden", "rior", "ris", "rock", "ronto", "rood", "rose", "roy", "ry", "sack", "sano", "sard", "say", "sby", "sea", "send", "set", "sevain", "shall", "shaw", "shire", "side", "soll", "somin", "son", "sonee", "sons", "sor", "stable", "stall", "stead", "ster", "stino", "ston", "stone", "swell", "tague", "tane", "tara", "tawa", "ter", "terel", "terre", "tham", "thon", "to", "tois", "ton", "tona", "tonas", "tos", "tou", "town", "trie", "try", "val", "ver", "vern", "view", "ville", "vista", "vons", "waki", "wall", "ware", "water", "way", "we", "well", "wich", "wick", "win", "wood", "worth" };
				string[] nm25 = { "Épi", "Auri", "Avi", "Angou", "Hague", "Houi", "Anti", "Anto", "Or", "Alen", "Argen", "Auber", "Bel", "Besan", "Bor", "Bour", "Cam", "Char", "Cler", "Col", "Cour", "Mar", "Mont", "Nan", "Nar", "Sar", "Valen", "Vier", "Villeur", "Vin", "Ba", "Bé", "Beau", "Berge", "Bou", "Ca", "Carca", "Cha", "Champi", "Cho", "Cla", "Colo", "Di", "Dra", "Dragui", "Fré", "Genne", "Go", "Gre", "Leva", "Li", "Mai", "Mari", "Marti", "Mau", "Montau", "Péri", "Pa", "Perpi", "Plai", "Poi", "Pu", "Roa", "Rou", "Sau", "Soi", "Ta", "Tou", "Va", "Vitro" };
				string[] nm26 = { "gnan", "gnane", "gneux", "llac", "lles", "lliers", "llon", "lly", "nne", "nnet", "nnois", "ppe", "ppes", "rgues", "ssion", "ssis", "ssonne", "ssons", "ssy", "thune", "çon", "béliard", "bagne", "beuge", "bonne", "ciennes", "court", "fort", "gny", "gues", "gueux", "lès", "lême", "let", "limar", "logne", "lon", "luçon", "luire", "lun", "mans", "mart", "masse", "miers", "momble", "mont", "mur", "nau", "nesse", "nin", "noît", "rac", "rault", "ris", "roux", "sart", "seau", "sier", "sir", "teaux", "toise", "tou", "veil", "vers", "ves", "ville", "vin", "yonne", "zieu", "zon" };
				string[] nm30 = { };
				string br = "";

				Random r = new Random();
				int tp = r.Next(10);
				int i = r.Next(10);

				if (tp == 1)
				{
					int rnd = r.Next(nm4.Length);
					int rnd3 = r.Next(nm5a.Length);
					if (i < 4)
					{
						if (rnd == 0 && rnd3 < 113)
						{
							return nm4[rnd] + " " + nm5b[rnd3];
						}
						else
						{
							return nm4[rnd] + " " + nm5a[rnd3];
						}
					}
					else if (i < 6)
					{
						int rnd2 = r.Next(nm6.Length);
						if (rnd2 < 26 && rnd3 < 113)
						{
							return nm4[rnd] + " " + nm6[rnd2] + " " + nm5b[rnd3];
						}
						else
						{

						}
						return nm4[rnd] + " " + nm6[rnd2] + " " + nm5a[rnd3];
					}
					else
					{
						int rnd2 = r.Next(nm25.Length);
						int rnd5 = r.Next(nm26.Length);
						if (rnd2 > 7 && rnd2 < 28)
						{
							while (rnd5 < 20)
							{
								rnd5 = r.Next(nm26.Length);
							}
						}
						if (rnd2 < 12)
						{
							nm30 = new string[] { "d'", "de l'" };
						}
						else
						{
							string plur = nm26[rnd5].Substring(nm26[rnd5].Length - 1, 1);
							int nTp = r.Next(10);
							if (nTp < 6 && plur == "s")
							{
								nm30 = new string[] { "des " };
							}
							else
							{
								nm30 = new string[] { "de ", "du ", "de la " };
							}
						}
						int rnd4 = r.Next(nm30.Length);
						return nm4[rnd] + " " + nm30[rnd4] + nm25[rnd2] + nm26[rnd5];
					}
				}
				else
				{
					int rnd = r.Next(nm1.Length);
					int rnd3 = r.Next(nm3.Length);
					if (i < 4)
					{
						return "The " + nm1[rnd] + " " + nm3[rnd3];
					}
					else if (i < 6)
					{
						int rnd2 = r.Next(nm2.Length);
						return nm1[rnd] + " " + nm2[rnd2] + " " + nm3[rnd3];
					}
					else
					{
						int rnd2 = r.Next(nm13.Length);
						int rnd4 = r.Next(nm14.Length);
						return nm13[rnd2] + nm14[rnd4] + " " + nm3[rnd3];
					}
				}
			}

			public static string business()
			{
				string[] names1 = { "Accent", "Ace", "Alligator", "Alp", "Alpha", "Alpine", "Amazon", "Angel", "Answer", "Ant", "Antler", "Apache", "Apex", "Apple", "Apricot", "Arcane", "Ask", "Aura", "Banshee", "Bear Paw", "Beedle", "Berry", "Beta", "Blizzard", "Blossom", "Blue", "Bluff", "Boar", "Bridge", "Brisk", "Buck", "Bull", "Bumblebee", "Butterfly", "Buzzy Bee", "Canine", "Cannon", "Cave", "Cavern", "Ceasar", "Champion", "Chief", "Cliff", "Cloud", "Clover", "Core", "Crow", "Cruise", "Crux", "Cryptic", "Crystal", "Cube", "Cyclone", "Cyclops", "Daydream", "Deluge", "Desert", "Diamond", "Dinosaur", "Dragon", "Dream", "Drift", "Dwarf", "Dynamic", "Eclipse", "Ecstatic", "Electra", "Electron", "Elite", "Elvish", "Energy", "Enigma", "Equinox", "Essence", "Explorer", "Fairy", "Feline", "Fire", "Fjord", "Flower", "Fluke", "Flux", "Forest", "Fortune", "Freak", "Frostfire", "Gale", "Gem", "Ghost", "Glacier", "Global", "Globe", "Gnome", "Goblin", "Gold", "Golden Road", "Gorilla", "Granite", "Grasshopper", "Great White", "Green", "Griffin", "Grizzly", "Grotto", "Hammer", "Happy", "Hatch", "Heart", "Herb", "Hercules", "Hero", "High Tide", "Hog", "Honey", "Honeydew", "Hook", "Hound", "Hummingbird", "Hurricane", "Ice", "Iceberg", "Icecap", "Imagination", "Imagine", "Iron", "Jet", "Jewel", "Joy", "Jungle", "Jupiter", "Karma", "Labyrinth", "Lagoon", "Lemon", "Leopard", "Life", "Lion", "Lioness", "Loki", "Low Tide", "Lucent", "Lucky", "Maple", "Marble", "Mars", "Marsh", "Maze", "Melon", "Mercury", "Mermaid", "Micro", "Midnight", "Monarch", "Moon", "Moondust", "Moonlight", "Moonlit", "Moth", "Motion", "Mount", "Mountain", "Mystic", "Nemo", "Neptune", "Nero", "Night", "Nimble", "North Star", "Nymph", "Oak", "Ocean", "Odin", "Ogre", "Omega", "Oracle", "Orange", "Orc", "Owl", "Oyster", "Padlock", "Parable", "Paragon", "Peach", "Pearl", "Petal", "Phantasm", "Phantom", "Phenomenon", "Phoenix", "Pink", "Pinnacle", "Pixel", "Pixy", "Pluto", "Pride", "Primal", "Prime", "Prodigy", "Prophecy", "Proton", "Pumpkin", "Purple", "Pyramid", "Quad", "Question", "Rabbit", "Radiant", "Raptor", "Raven", "Red", "Revelation", "Rhino", "Riddle", "Ridge", "River", "Robin", "Root", "Rose", "Rush", "Sail", "Sapling", "Saturn", "Saw", "Seaway", "Seed", "Shade", "Shadow", "Sharkfin", "Shrub", "Sign", "Signal", "Silver", "Silver Lining", "Slick", "Smart", "Smile", "Solstice", "Soul", "Specter", "Sphere", "Sphinx", "Spider", "Spike", "Spirit", "Sprite", "Squid", "Star", "Stardust", "Starlight", "Storm", "Summit", "Sun", "Sunlight", "Sunshine", "Surge", "Surprise", "Tempest", "Thor", "Thunder", "Tide", "Tiger", "Tigress", "Timber", "Titanium", "Topiary", "Tortoise", "Trek", "Triumph", "Tucan", "Tulip", "Tundra", "Turtle", "Twilight", "Twister", "Typhoon", "Valkyrie", "Venus", "Vertex", "Vine", "Vision", "Void", "Vortex", "Voyage", "Wave", "Web", "Whirlpool", "Whirlwind", "White Wolf", "Whiteout", "Whiz", "Willow", "Witch", "Wizard", "Wolf", "Wonder", "Wood", "World", "Yellow", "Yew", "Zeus" };
				string[] names2 = { "", "", "Acoustics", "Arts", "Aviation", "Brews", "Co.", "Coms", "Corp", "Corporation", "Electronics", "Enterprises", "Entertainment", "Foods", "Industries", "Intelligence", "Lighting", "Limited", "Media", "Microsystems", "Motors", "Navigations", "Networks", "Productions", "Records", "Security", "Softwares", "Solutions", "Sports", "Systems", "Technologies" };
				string[] names3 = { "Accenco", "Aces", "Allico", "Alphacom", "Alpire", "Alpite", "Amazystems", "Angelico", "Ansoft", "Antarts", "Antelligence", "Apachicorp", "Apexi", "Appiation", "Aprico", "Arcanetworks", "Asco", "Aurarts", "Bansheelectronis", "Bearings", "Beedlectrics", "Berrycords", "Betarts", "Blizzart", "Blossomotors", "Bluetronics", "Bluffoods", "Boarco", "Bridgelectrics", "Brisco", "Buckoustics", "Bullimited", "Bumblebeelectrics", "Butterflyght", "Buzzylectrics", "Canics", "Cannonics", "Cavernetworks", "Cavologies", "Ceasarts", "Champroductions", "Chiefoods", "Cliffoods", "Cloudustries", "Cloverprises", "Corecords", "Crowares", "Cruisertainment", "Cruxolutions", "Crypticorps", "Crystalightning", "Cubrews", "Cyclolutions", "Cycloration", "Daydreamotors", "Delugation", "Deserprises", "Diamontronics", "Dinosecurity", "Dragonetworks", "Dreamedia", "Driftonics", "Dwarfoods", "Dynamico", "Ecliprises", "Ecstaticorps", "Elecoms", "Electrorks", "Elitelligence", "Elviations", "Energence", "Enigmotors", "Equinetworks", "Essensecurity", "Explority", "Fairiprises", "Felinetworks", "Firetronics", "Fjordustries", "Flowertainment", "Flukords", "Fluxystems", "Forestics", "Fortunetworks", "Freacrosystems", "Frostfiretronics", "Galerprises", "Gemedia", "Ghostronics", "Glaciarts", "Globaviations", "Globeworks", "Gnomelectrics", "Goblintelligence", "Golbrews", "Goldustries", "Gorillacoustics", "Granitelligence", "Grasshoproductions", "Greatechnologies", "Greenetworks", "Griffindustries", "Grizzlimited", "Grottolutions", "Hammertronics", "Happindustries", "Hatchworks", "Heartelligence", "Herbrews", "Herculentertainment", "Herolutions", "High Tidustries", "Hogurity", "Honeydustries", "Honeytelligence", "Hookurity", "Houndnavigations", "Hummingbirdustries", "Hurricanetworks", "Icebergarts", "Icecaproductions", "Icecorps", "Imaginavigations", "Imaginetworks", "Ironavigation", "Jetechnologies", "Jewelectrics", "Joytechs", "Junglectics", "Jupitelligence", "Karmarts", "Labyrintelligence", "Lagoonavigations", "Lemonetworks", "Leopardworks", "Lifoods", "Lionessolutions", "Lionetworks", "Lokilutions", "Low Tidustries", "Lucentertainment", "Luckytronics", "Mapletainment", "Marblightning", "Marsecuriy", "Marsoftwares", "Mazecurity", "Melonetworks", "Mercurtainment", "Mermedia", "Microlutions", "Midnightelligence", "Monarctronics", "Moondustries", "Moonlightings", "Moonlimited", "Moonnetworks", "Mothechnologies", "Motionavigations", "Mountainetworks", "Mountelligence", "Mysticorps", "Nemotors", "Neptunetworks", "Neroductions", "Nightelligence", "Nimbletainment", "North Starporation", "Nymphoods", "Oakoms", "Oceanavigations", "Odinetworks", "Ogreprises", "Omegacoustics", "Oracleutions", "Orangations", "Orco", "Owlimited", "Oystertainment", "Padlockurity", "Parableutions", "Paragonetworks", "Peachco", "Pearlightning", "Petalimited", "Phantasmedia", "Phantomedia", "Phenomenologies", "Phoenixolutions", "Pinkorps", "Pinnaclelectrics", "Pixelimited", "Pixystems", "Plutronics", "Priductions", "Primacoustics", "Primedia", "Prodintelligence", "Prophecycurity", "Protonetworks", "Pumpkinavigation", "Purplelimited", "Pyramidustries", "Quaductions", "Questindustries", "Rabbitechnologies", "Radiantelligence", "Raptolutions", "Ravenetworks", "Redustries", "Revelationetworks", "Rhinotainment", "Riddlectronics", "Ridgeco", "Riverecords", "Robinetworks", "Rootechnologies", "Rosecurity", "Rushcorp", "Sailightning", "Saplimited", "Saturnetworks", "Sawwares", "Seawares", "Seedtronics", "Shadearts", "Shadoworks", "Sharkfinetworks", "Shrubrews", "Signalimited", "Signetworks", "Silver Linetworks", "Silverecords", "Slickorps", "Smartechnologies", "Smilectronics", "Solsticetems", "Soulightning", "Spectertainment", "Spherecords", "Sphinxecurity", "Spicurity", "Spideradio", "Spiritechnologies", "Spritechnologies", "Squidustries", "Stardustechnologies", "Starecords", "Starlightning", "Stormedia", "Summitechnologies", "Sunavigations", "Sunlightning", "Sunshinetworks", "Surgesystems", "Surprisystems", "Tempestechnologies", "Thorecords", "Thunderecords", "Tidustries", "Tigertainment", "Tigressystems", "Timberecords", "Titaniumotors", "Topiarytelligence", "Tortoisecurity", "Trekords", "Triumphoods", "Tucanterprises", "Tuliproductions", "Tundracoustics", "Turtletainment", "Twilightechnologies", "Twisterecords", "Typhoonavigations", "Valkyrecords", "Venusystems", "Vertexoftwards", "Vinedustries", "Visionetworks", "Voidustries", "Vortexecurity", "Voyagetronics", "Wavigations", "Webrews", "Whirlpoolutions", "Whirlwindustries", "White Wolfoods", "Whiteoutwares", "Whizystems", "Willowares", "Witchystems", "Wizardustries", "Wolfoods", "Wonderprises", "Wooductions", "Worldwares", "Yelloworks", "Yeworks", "Zeusolutions" };
				string[] names4 = { "Accent", "Ace", "Alligator", "Alpha", "Alpine", "Amazon", "Angel", "Apache", "Apex", "Arcane", "Aura", "Banshee", "Beedle", "Berry", "Beta", "Blossom", "Blue", "Boar", "Bridge", "Bull", "Bee", "Cannon", "Cave", "Cavern", "Chief", "Cliff", "Cloud", "Core", "Crow", "Crystal", "Cube", "Desert", "Diamond", "Dino", "Dragon", "Dream", "Drift", "Dwarf", "Dynamic", "Fairy", "Fire", "Flower", "Forest", "Freak", "Gem", "Ghost", "Global", "Globe", "Gnome", "Gold", "Gorilla", "Granite", "Green", "Griffin", "Grizzly", "Grotto", "Hammer", "Happy", "Hatch", "Heart", "Herb", "Hero", "Hog", "Honey", "Hook", "Hound", "Humming", "Ice", "Iron", "Jet", "Joy", "Karma", "Lagoon", "Lemon", "Leopard", "Life", "Lion", "Lioness", "Lucent", "Lucky", "Maple", "Marble", "Mars", "Marsh", "Maze", "Mermaid", "Micro", "Moon", "Motion", "Mountain", "Nemo", "Night", "Nimble", "Nymph", "Oak", "Ocean", "Omega", "Owl", "Oyster", "Peach", "Pearl", "Petal", "Phantomn", "Phoenix", "Pink", "Pinnacle", "Pixel", "Pixy", "Prime", "Purple", "Quad", "Raven", "Red", "Rhino", "Riddle", "Ridge", "River", "Robin", "Root", "Rose", "Sail", "Shade", "Shadow", "Sign", "Signal", "Silver", "Smart", "Smile", "Soul", "Sphere", "Spider", "Spike", "Spirit", "Sprite", "Squid", "Star", "Storm", "Sun", "Thunder", "Tiger", "Timber", "Tulip", "Twilight", "Typhoon", "Vine", "Void", "Vortex", "Wave", "Web", "Wizard", "Wolf", "Wonder", "Wood", "World", "Yellow", "Yew", "Zeus" };
				string[] names5 = { "aid", "air", "bank", "bar", "beat", "bit", "bite", "books", "bridge", "cast", "cloud", "coms", "dale", "dew", "dream", "ex", "fly", "force", "fruit", "gate", "gold", "head", "hive", "house", "hut", "king", "land", "life", "light", "man", "mart", "master", "media", "mobile", "nite", "paw", "phone", "point", "poly", "rover", "scape", "search", "shack", "shade", "shadow", "shine", "show", "space", "star", "stone", "stones", "sun", "sys", "tales", "techs", "time", "tronics", "tube", "walk", "ware", "wares", "water", "way", "ways", "well", "wheels", "wood", "works", "world", "worth" };

				Random r = new Random();

				int i = r.Next(10);
				int rnd0 = 0;
				int rnd1 = 0;

				if (i < 3)
				{
					rnd0 = r.Next(names1.Length);
					rnd1 = r.Next(names2.Length);
					return names1[rnd0] + " " + names2[rnd1];
				}
				else if (i < 7)
				{
					rnd0 = r.Next(names3.Length);
					return names3[rnd0];
				}
				else
				{
					rnd0 = r.Next(names4.Length);
					rnd1 = r.Next(names5.Length);
					return names4[rnd0] + names5[rnd1];
				}
			}

			public static string camp()
			{
				string[] names1 = { "Aegis", "Ambition", "Amnesty", "Armor", "Bastion", "Blessing", "Chance", "Charity", "Chastity", "Cherish", "Citadel", "Clemency", "Comfort", "Companion", "Companionship", "Company", "Compassion", "Conquest", "Control", "Courage", "Covenant", "Custody", "Daydream", "Delight", "Desire", "Dignity", "Divinity", "Dominion", "Dream", "Duty", "Ecstasy", "Eden", "Elation", "Elysium", "Euphoria", "Faith", "Fantasy", "Favor", "Felicity", "Fellowship", "Fortitude", "Fortune", "Foster", "Freedom", "Glee", "Glory", "Goodwill", "Guidance", "Happiness", "Harmony", "Heart", "Honesty", "Honor", "Hope", "Immunity", "Joy", "Jubilee", "Karma", "Kudos", "Liberty", "Love", "Luck", "Majesty", "Mercy", "Mirth", "Nourish", "Nurture", "Paradise", "Parry", "Passion", "Piety", "Prestige", "Pride", "Privilege", "Promise", "Purity", "Redemption", "Reliance", "Remedy", "Resistance", "Respect", "Return", "Revolution", "Safeguard", "Salvation", "Sanctuary", "Solitude", "Supremacy", "Sweetness", "Sympathy", "Synthesis", "Tribute", "Triumph", "Trust", "Truth", "Unity", "Utopia", "Victory", "Vindicate", "Virtue", "Wish", "Wonder", "Zeal", "Zion" };
				string[] names2 = { "Abolition", "Abyss", "Agony", "Anarchy", "Animus", "Annihilation", "Apathy", "Assassin", "Aversion", "Bane", "Betrayal", "Blaze", "Blockade", "Calamity", "Carnage", "Chaos", "Condemned", "Cruelty", "Decimation", "Defeat", "Delirium", "Demolition", "Denial", "Desertion", "Desolation", "Despair", "Destruction", "Detention", "Disarray", "Disbelief", "Disgrace", "Dishonor", "Disruption", "Disunion", "Dominance", "Doom", "Doubt", "Downfall", "Elimination", "Entropy", "Eternity", "Extermination", "Extinction", "Fear", "Ferocity", "Fluke", "Forfeit", "Forsake", "Frenzy", "Fury", "Hallow", "Hate", "Hatred", "Havoc", "Hazard", "Hostility", "Hysteria", "Impotence", "Inferno", "Injury", "Isolation", "Limbo", "Malevolence", "Malice", "Mania", "Massacre", "Mayhem", "Melancholy", "Misfortune", "Murder", "Nether", "Nightmare", "Obstruction", "Overlook", "Peril", "Pity", "Poverty", "Prohibition", "Rage", "Rampage", "Ravage", "Relinquish", "Restraint", "Riot", "Sanctity", "Shatter", "Silence", "Slaughter", "Slayer", "Sorrow", "Spite", "Stigma", "Storm", "Struggle", "Submission", "Surrender", "Torment", "Treachery", "Turmoil", "Umbrage", "Uproar", "Venom", "Violence", "Void", "Wasteland", "Wilderness", "Woe", "Worship", "Wrath", "Wreckage" };
				string[] names3 = { "Alpha", "Alpine", "Altar", "Angel", "Angel Wings", "Anomaly", "Aqua", "Aquamarine", "Arachnid", "Arrowtip", "Astro", "Aurora", "Avalanche", "Azure", "Bandana", "Bear Paw", "Black Crow", "Blue Banner", "Boulderfist", "Braveheart", "Brown Bear", "Bullet", "Bullettooth", "Bumblebee", "Butterfly", "Cannonball", "Castaway", "Comet", "Coyote", "Crescent Moon", "Crimson", "Crossbow", "Daemon", "Darkwind", "Dawn", "Daybreak", "Daylight", "Demon", "Diamond", "Dragonfire", "Dragonfly", "Dragontooth", "Dusk", "Eagle Eye", "Ebony", "Echo", "Eclipse", "Effigy", "Emerald", "Energy", "Enigma", "Eventide", "Fable", "Falcon", "Fallen Oak", "Firefly", "Frozen Lake", "Full Moon", "Gadget", "Gemini", "Gizmo", "Glacier", "Grasshopper", "Heartbreak", "Heartfire", "High Tide", "Highlands", "Howling Wolf", "Hummingbird", "Hurricane", "Ivory", "Jadefire", "Jasmine", "Jester", "Kite Shield", "Light Beacon", "Lightning", "Lightning Strike", "Lion Roar", "Lockdown", "Lockheart", "Lone Wolf", "Maggot", "Major", "Malachite", "Maple Leaf", "Maverick", "Merlin", "Midnight", "Minor", "Mirage", "Mirror Image", "Monsoon", "Moonstone", "Morningstar", "Mountain Peak", "Nemo", "New Moon", "Night Beacon", "Night Owl", "Nightfall", "Nighttide", "Omega", "Open Door", "Overlook", "Pedestal", "Phantasm", "Phoenix", "Quicksilver", "Rabbit's Foot", "Radiance", "Raindrop", "Red Banner", "Saffron", "Sapphire", "Satellite", "Scarlet", "Serpent", "Shark Fin", "Shooting Star", "Silver Lining", "Silver Shadow", "Snowflake", "Solar Beam", "Solar Flare", "Solstice", "Stardust", "Starfall", "Starlight", "Stormgaze", "Straight Arrow", "Sundance", "Sundown", "Sunset", "Sunshine", "Thunderclap", "Thunderstorm", "Tiger Claw", "Tiger Lilly", "Torchbearer", "Tortoise", "Turtle Shell", "Twilight", "Viper", "Waterfall", "Whisper", "Wild Card", "Wild Horse", "Willow", "Woodpecker" };

				Random r = new Random();
				int i = r.Next(10);
				int rnd = 0;

				if (i < 3)
				{
					rnd = r.Next(names1.Length);
					return "Camp " + names1[rnd];
				}
				else if (i < 6)
				{
					rnd = r.Next(names2.Length);
					return "Camp " + names2[rnd];
				}
				else
				{
					rnd = r.Next(names3.Length);
					return "Camp " + names3[rnd];
				}
			}

			public static string cave()
			{
				string[] nm1 = { "Abysmal", "Adamantine", "Ancient", "Angry", "Arching", "Arctic", "Arid", "Bare", "Beholding", "Bellowing", "Black", "Bleak", "Blue", "Boiling", "Bottomless", "Boundless", "Brilliant", "Bronze", "Burned", "Burning", "Calm", "Calmest", "Charmed", "Cheerless", "Climbing", "Cobalt", "Cold", "Collapsing", "Colorless", "Colossal", "Coral", "Crystal", "Cunning", "Cursed", "Dancing", "Dangerous", "Dark", "Darkest", "Dead", "Decayed", "Decaying", "Deep", "Deepest", "Dense", "Depraved", "Deserted", "Desolate", "Desolated", "Diamond", "Distant", "Dread", "Dreaded", "Dreadful", "Dreary", "Dry", "Eastern", "Emerald", "Empty", "Enchanted", "Enormous", "Eroded", "Ethereal", "Ever Reaching", "Everlasting", "Fabled", "Faraway", "Farthest", "Feared", "Fearsome", "Fiery", "Flaring", "Flat", "Flowing", "Foaming", "Forbidden", "Forbidding", "Fractured", "Frightening", "Frozen", "Gargantuan", "Giant", "Gigantic", "Glassy", "Gleaming", "Glistening", "Gloomy", "Glowing", "Gold", "Golden", "Grave", "Gray", "Green", "Grim", "Harmonious", "Haunted", "Heaving", "Hellish", "Hollow", "Homeless", "Hopeless", "Hot", "Huge", "Humongous", "Hungry", "Immense", "Infernal", "Infinite", "Invisible", "Iron", "Isolated", "Jade", "Jagged", "Killing", "Laughing", "Lifeless", "Light", "Lightest", "Living", "Lonely", "Lucent", "Majestic", "Malevolent", "Malicious", "Mammoth", "Mesmerizing", "Mighty", "Mirrored", "Misty", "Moaning", "Molten", "Monotonous", "Monstrous", "Motionless", "Mysterious", "Narrow", "Neverending", "New", "Northern", "Open", "Orient", "Overhanging", "Parched", "Peaceful", "Perfumed", "Plain", "Pleasant", "Prickly", "Primeval", "Quiet", "Raging", "Red", "Relentless", "Remote", "Restless", "Rocking", "Rocky", "Rough", "Rugged", "Sad", "Sandy", "Sanguine", "Savage", "Scarlet", "Scorching", "Serene", "Severed", "Shadow", "Shadowed", "Shadowy", "Shimmering", "Silent", "Silver", "Sleeping", "Slumbering", "Slumberous", "Sly", "Soundless", "Southern", "Spacious", "Sparkling", "Sterile", "Stern", "Straightened", "Sunny", "Symmetrical", "Teal", "Terraced", "Terrestrial", "Throbbing", "Thundering", "Tinted", "Titanic", "Tranquil", "Treacherous", "Troubled", "Turbulent", "Turquoise", "Twisting", "Ugly", "Uncanny", "Unfathomed", "Uninviting", "Unknown", "Unresting", "Unruffled", "Unscaled", "Unstable", "Unwelcoming", "Vast", "Violent", "Voiceless", "Volcanic", "Walled", "Wasted", "Wasteful", "Wasting", "Welcoming", "Western", "Whelming", "Whispering", "White", "Wild", "Windless", "Windy", "Withered", "Wondering", "Wrinkled", "Yearning", "Yelling", "Yellow" };
				string[] nm2 = { "Cave", "Cavern", "Grotto", "Den", "Cavity", "Hollow", "Hollows", "Caves", "Caverns", "Hole", "Hideout", "Shelter", "Overhang", "Sanctuary", "Subterrane", "Chasm", "Abyss", "Chasms" };
				string[] nm3 = { "Ab", "Al", "Ala", "Alber", "Aller", "Am", "Ames", "An", "Anti", "Apple", "Ar", "Arbor", "Arling", "Arn", "As", "Ash", "Atha", "Ati", "Attle", "Autumn", "Avon", "Bain", "Bal", "Ban", "Bar", "Bark", "Barn", "Barr", "Barring", "Bas", "Battle", "Bax", "Bay", "Beacon", "Beau", "Beaver", "Bed", "Bedding", "Bell", "Belle", "Ben", "Bent", "Ber", "Beres", "Berk", "Berthier", "Bever", "Bex", "Bien", "Big", "Bir", "Birming", "Black", "Blain", "Bloom", "Blooms", "Blythe", "Bois", "Bol", "Bona", "Booth", "Bord", "Bos", "Boucher", "Box", "Brace", "Brad", "Breden", "Brent", "Bri", "Bridge", "Brigh", "Bright", "Brim", "Bris", "Bro", "Broad", "Brom", "Brook", "Bros", "Brown", "Bruder", "Buch", "Bucking", "Bur", "Burs", "Bux", "Cal", "Cale", "Cam", "Camp", "Can", "Cano", "Canter", "Car", "Cara", "Carbo", "Card", "Carig", "Carl", "Carle", "Carn", "Cart", "Cas", "Cau", "Causa", "Cha", "Cham", "Chan", "Chat", "Chats", "Chel", "Chelms", "Ches", "Chester", "Chi", "Chibou", "Chil", "Church", "Clare", "Claren", "Cler", "Clif", "Cliff", "Clin", "Co", "Coal", "Coati", "Coch", "Col", "Cole", "Coli", "Com", "Con", "Cor", "Corn", "Coro", "Cottle", "Coven", "Cowan", "Cres", "Cross", "Croy", "Cud", "Cumber", "Dal", "Dan", "Dar", "Dart", "Davel", "Day", "De", "Dead", "Ded", "Del", "Delis", "Delor", "Der", "Dig", "Dis", "Do", "Dol", "Donna", "Dor", "Dray", "Drum", "Dun", "Dupar", "Dur", "East", "Eato", "Eck", "Effing", "El", "Elling", "Ellis", "Elm", "Em", "Emer", "Ems", "En", "Engle", "Ep", "Es", "Ester", "Ever", "Ex", "Fair", "Fal", "Fall", "Farm", "Farming", "Farn", "Fer", "Flat", "Flem", "For", "Ford", "Framing", "Fran", "Free", "Gal", "Gallan", "Gam", "Gan", "Gana", "Gar", "Gati", "Gaul", "Gib", "Gil", "Glad", "Glas", "Glen", "Glou", "Glover", "Go", "Gode", "Gol", "Grace", "Graf", "Gran", "Grand", "Grave", "Gravel", "Graven", "Green", "Gren", "Gret", "Grim", "Gro", "Guil", "Had", "Hal", "Hali", "Ham", "Hamp", "Han", "Har", "Harp", "Hart", "Has", "Hast", "Hat", "Haver", "Heb", "Hep", "Here", "Hermi", "Hf", "Hil", "Hill", "Hills", "Hin", "Hing", "Holy", "Hors", "Hud", "Hul", "Hum", "Hunt", "Hunting", "Inger", "Innis", "Iro", "Irri", "Isling", "Itu", "Jol", "Kam", "Kapus", "Kear", "Keel", "Kensing", "Kerro", "Killing", "Kinder", "Kings", "Kini", "Kip", "Kir", "Kirk", "La", "Lam", "Lama", "Lan", "Lang", "Lani", "Lash", "Latch", "Laval", "Le", "Lea", "Leaming", "Lee", "Lei", "Lem", "Leo", "Liming", "Lin", "Litch", "Liver", "Locke", "Lon", "Lour", "Lum", "Lunen", "Luse", "Maca", "Mag", "Maho", "Maid", "Mal", "Malar", "Man", "Mani", "Mans", "Mar", "Mara", "Marl", "Mata", "May", "Meli", "Men", "Mens", "Meri", "Mid", "Mida", "Middle", "Middles", "Mil", "Mill", "Miller", "Mini", "Minne", "Monk", "Mont", "Moo", "Morin", "Mul", "Mun", "Mus", "Nai", "Nan", "Nee", "Neu", "New", "Newing", "Nia", "Nico", "Nipa", "Niver", "Noko", "Nor", "North", "Not", "Notting", "Oak", "Oge", "Oko", "Ono", "Oro", "Oso", "Otter", "Out", "Ox", "Pac", "Par", "Para", "Parr", "Pas", "Pel", "Pen", "Pene", "Peta", "Petro", "Pic", "Pil", "Pin", "Pla", "Plai", "Plain", "Ply", "Plym", "Pohe", "Pon", "Pono", "Port", "Ports", "Pres", "Pro", "Put", "Ra", "Rad", "Ray", "Read", "Reid", "Repen", "Rich", "Ridge", "Rim", "Rimou", "Ring", "River", "Ro", "Rob", "Roch", "Rock", "Rocking", "Rom", "Ros", "Rose", "Ross", "Rothe", "Row", "Rox", "Rug", "Rut", "Sag", "Sal", "Salis", "San", "Sand", "Sau", "Sava", "Scar", "Scars", "Sedge", "Senne", "Shau", "Shaw", "She", "Shef", "Shel", "Shell", "Sher", "Ship", "Shrew", "Shrews", "Sin", "Smi", "Smith", "Smiths", "Somer", "South", "Spring", "Staf", "Stam", "Stan", "Stel", "Stet", "Stock", "Stoke", "Stone", "Stough", "Straf", "Strat", "Sud", "Suf", "Summer", "Sun", "Sunder", "Sur", "Sus", "Sut", "Tam", "Taun", "Tecum", "Temis", "Temple", "Ter", "Terre", "Terren", "Thes", "Thessa", "Thet", "Thur", "Till", "Tis", "Tiver", "Tol", "Tor", "Torring", "Tray", "Tre", "Tren", "Tri", "Tro", "Tun", "Tur", "Twil", "Val", "Varen", "Vaux", "Vegre", "Ven", "Vent", "Ver", "Vir", "Von", "Vot", "Wa", "Wade", "Waka", "Wake", "Wal", "Wall", "Walling", "Wals", "Wape", "War", "Ware", "Wasa", "Water", "Way", "Welling", "Wes", "West", "Wey", "Whit", "White", "Wick", "Wil", "Willing", "Win", "Wind", "Winder", "Winter", "Wit", "Wolf", "Wood", "Wor", "Wrent", "Wyn", "Yar", "York" };
				string[] nm4 = { "balt", "bel", "berg", "berry", "biens", "bo", "boia", "bonear", "borg", "boro", "borough", "bour", "bourg", "briand", "bridge", "bron", "brook", "burg", "burn", "burns", "bury", "by", "cam", "cana", "carres", "caster", "castle", "cester", "chester", "chill", "cier", "cola", "coln", "cona", "cook", "cord", "couche", "cour", "croft", "dale", "dare", "de", "deen", "den", "der", "des", "diac", "ding", "don", "dosa", "dover", "down", "dows", "duff", "durn", "dwell", "fail", "fair", "fait", "fell", "field", "fil", "folk", "ford", "forte", "gamau", "gami", "gan", "gar", "gate", "geo", "gonie", "gough", "grave", "guay", "gue", "gueuil", "gus", "ham", "hampton", "hazy", "head", "heim", "heller", "her", "hill", "holm", "hurst", "isle", "jour", "kasing", "lam", "lams", "lan", "land", "lants", "leche", "lem", "let", "ley", "liers", "lin", "line", "linet", "ling", "lis", "lisle", "lita", "lodge", "low", "ly", "mack", "magne", "man", "mar", "mark", "meda", "meny", "mer", "mere", "meuse", "ming", "minster", "miota", "mis", "mond", "mont", "more", "mouth", "na", "nach", "nan", "near", "neau", "net", "ney", "nia", "nigan", "ning", "nola", "noque", "nora", "par", "pawa", "pids", "pon", "pond", "pool", "port", "quet", "raine", "ram", "rane", "rath", "ree", "rey", "rial", "rich", "riden", "rior", "ris", "rock", "ronto", "rood", "rose", "roy", "ry", "sack", "sano", "sard", "say", "sby", "sea", "send", "set", "sevain", "shall", "shaw", "shire", "side", "soll", "somin", "son", "sonee", "sons", "sor", "stable", "stall", "stead", "ster", "stino", "ston", "stone", "swell", "tague", "tane", "tara", "tawa", "ter", "terel", "terre", "tham", "thon", "to", "tois", "ton", "tona", "tonas", "tos", "tou", "town", "trie", "try", "val", "ver", "vern", "view", "ville", "vista", "vons", "waki", "wall", "ware", "water", "way", "we", "well", "wich", "wick", "win", "wood", "worth" };

				string[] nm5 = { "la Caverne", "la Caverne", "la Caverne", "la Caverne", "la Cavité", "la Grotte", "la Grotte", "la Grotte", "la Grotte", "les Cavernes", "les Cavernes", "les Cavernes", "les Cavités", "les Grottes", "les Grottes", "les Grottes", "l'Abri", "l'Abîme", "le Creux", "le Gouffre", "le Sanctuaire", "le Sous-Terrain", "le Trou", "les Trous", "les Abris", "les Abîmes", "les Creux", "les Gouffres", "les Sanctuaires", "les Sous-Terrains" };
				string[] nm6a = { "Écarlate", "Éloigné", "Émeraude", "Épouvantable", "Érodé", "Éthéré", "Étincelant", "Étrange", "Étroit", "Abandonné", "Accidenté", "Affamé", "Agité", "Agitant", "Agréable", "Ancien", "Aphone", "Arctique", "Ardent", "Argenté", "Aride", "Atroce", "Atrophié", "Avide", "Barbare", "Blanc", "Bleu", "Bouillant", "Brûlé", "Brûlant", "Brillant", "Bronze", "Brumeux", "Calme", "Carié", "Charmé", "Charmant", "Chatoyant", "Chaud", "Chuchotant", "Clair", "Compact", "Contemplatif", "Coulant", "Coupé", "Craignait", "Creux", "Déchiqueté", "Déclinant", "Délaissé", "Dépravé", "Déserté", "Désolé", "Dangereux", "Dansant", "Dense", "Desséché", "Diabolique", "Doré", "Effondré", "Effroyable", "Encaissé", "Enchanté", "Endormi", "Enflammé", "Enorme", "Fâché", "Flétri", "Fortifié", "Fracturé", "Froid", "Fumé", "Furieux", "Géant", "Gémissant", "Gargantuesque", "Gigantesque", "Glacé", "Grave", "Grimpant", "Gris", "Hanté", "Harmonieux", "Hurlant", "Hypnotisant", "Illimité", "Immense", "Immobile", "Implacable", "Impossible", "Incolore", "Inconnu", "Infini", "Insondé", "Insondable", "Instable", "Interdit", "Invisible", "Isolé", "Jaune", "Légendaire", "Laid", "Lointain", "Lugubre", "Luisant", "Lumineux", "Mélancolique", "Mélodieux", "Macabre", "Majestueux", "Malveillant", "Maudit", "Montrueux", "Morne", "Mort", "Moussant", "Mystérieux", "Noir", "Obscur", "Ombragé", "Ombreux", "Ondulant", "Orageux", "Ouvert", "Pâle", "Pétilant", "Paisible", "Parfumé", "Perfide", "Plat", "Pourri", "Précaire", "Primitif", "Profond", "Puissant", "Ravagé", "Redouté", "Redoutable", "Reflété", "Retentissant", "Riant", "Ridé", "Risqué", "Rocheux", "Ronflant", "Rouge", "Rugueux", "Rusé", "Sablonneux", "Sacré", "Sanguine", "Sarcelle", "Satané", "Sauvage", "Scintillant", "Sec", "Serein", "Silencieux", "Sinistre", "Sinueux", "Solitaire", "Sombre", "Somnolent", "Songeur", "Sournois", "Spacieux", "Stérile", "Surplombant", "Symétrique", "Teinté", "Terrestre", "Titanesque", "Torride", "Tranquille", "Triste", "Troublé", "Turbulent", "Turquoise", "Ventueux", "Vert", "Vicieux", "Vide", "Vif", "Violent", "Vitreux", "Vivant", "Volcanique", "d'Émeraude", "d'Adamantite", "d'Argent", "d'Enfer", "d'Ombre", "d'Or", "de Cobalt", "de Corail", "de Cristal", "de Diamant", "de Fer", "de Jade", "de Lumière", "de Sable", "de Tuerie", "de l'Est", "de l'Ouest", "de la Terreur", "des Mammouths", "des Tombes", "du Nord", "du Sud", "en Arrière", "en Terrasse", "Phénoménal", "Oriental", "Occidental", "Infernal", "Glacial", "Sans Fin", "Sans Fond", "Sans Limite", "Colossal", "Brutal", "Boréal", "Austral" };
				string[] nm6b = { "Écarlate", "Éloignée", "Émeraude", "Épouvantable", "Érodée", "Éthérée", "Étincelante", "Étrange", "Étroite", "Abandonnée", "Accidentée", "Affamée", "Agitée", "Agitante", "Agréable", "Ancienne", "Aphone", "Arctique", "Ardente", "Argentée", "Aride", "Atroce", "Atrophiée", "Avide", "Barbare", "Blanche", "Bleue", "Bouillante", "Brûlée", "Brûlante", "Brillante", "Bronze", "Brumeuse", "Calme", "Cariée", "Charmée", "Charmante", "Chatoyante", "Chaude", "Chuchotante", "Claire", "Compacte", "Contemplative", "Coulante", "Coupée", "Craignaite", "Creuse", "Déchiquetée", "Déclinante", "Délaissée", "Dépravée", "Désertée", "Désolée", "Dangereuse", "Dansante", "Dense", "Desséchée", "Diabolique", "Dorée", "Effondrée", "Effroyable", "Encaissée", "Enchantée", "Endormie", "Enflammée", "Enorme", "Fâchée", "Flétrie", "Fortifiée", "Fracturée", "Froide", "Fumée", "Furieuse", "Géante", "Gémissante", "Gargantuesque", "Gigantesque", "Glacée", "Grave", "Grimpante", "Grise", "Hantée", "Harmonieuse", "Hurlante", "Hypnotisante", "Illimitée", "Immense", "Immobile", "Implacable", "Impossible", "Incolore", "Inconnue", "Infinie", "Insondée", "Insondable", "Instable", "Interdite", "Invisible", "Isolée", "Jaune", "Légendaire", "Laide", "Lointaine", "Lugubre", "Luisante", "Lumineuse", "Mélancolique", "Mélodieuse", "Macabre", "Majestueuse", "Malveillante", "Maudite", "Montrueuse", "Morne", "Morte", "Moussante", "Mystérieuse", "Noire", "Obscure", "Ombragée", "Ombreuse", "Ondulante", "Orageuse", "Ouverte", "Pâle", "Pétilante", "Paisible", "Parfumée", "Perfide", "Plat", "Pourrie", "Précaire", "Primitive", "Profonde", "Puissante", "Ravagée", "Redoutée", "Redoutable", "Reflétée", "Retentissante", "Riant", "Ridée", "Risquée", "Rocheuse", "Ronflante", "Rouge", "Rugueuse", "Rusée", "Sablonneuse", "Sacrée", "Sanguine", "Sarcelle", "Satanée", "Sauvage", "Scintillante", "Sèche", "Sereine", "Silencieuse", "Sinistre", "Sinueuse", "Solitaire", "Sombre", "Somnolente", "Songeuse", "Sournoise", "Spacieuse", "Stérile", "Surplombante", "Symétrique", "Teintée", "Terrestre", "Titanesque", "Torride", "Tranquille", "Triste", "Troublée", "Turbulente", "Turquoise", "Ventueuse", "Verte", "Vicieuse", "Vide", "Vive", "Violente", "Vitreuse", "Vivante", "Volcanique", "Sans Fin", "Sans Fond", "Sans Limite", "d'Émeraude", "d'Adamantite", "d'Argent", "d'Enfer", "d'Ombre", "d'Or", "de Cobalt", "de Corail", "de Cristal", "de Diamant", "de Fer", "de Jade", "de Lumière", "de Sable", "de Tuerie", "de l'Est", "de l'Ouest", "de la Terreur", "des Mammouths", "des Tombes", "du Nord", "du Sud", "en Arrière", "en Terrasse", "Phénoménal", "Oriental", "Occidental", "Infernal", "Glacial", "Colossal", "Brutal", "Boréal", "Austral" };
				string[] nm25 = { "Épi", "Auri", "Avi", "Angou", "Hague", "Houi", "Anti", "Anto", "Or", "Alen", "Argen", "Auber", "Bel", "Besan", "Bor", "Bour", "Cam", "Char", "Cler", "Col", "Cour", "Mar", "Mont", "Nan", "Nar", "Sar", "Valen", "Vier", "Villeur", "Vin", "Ba", "Bé", "Beau", "Berge", "Bou", "Ca", "Carca", "Cha", "Champi", "Cho", "Cla", "Colo", "Di", "Dra", "Dragui", "Fré", "Genne", "Go", "Gre", "Leva", "Li", "Mai", "Mari", "Marti", "Mau", "Montau", "Péri", "Pa", "Perpi", "Plai", "Poi", "Pu", "Roa", "Rou", "Sau", "Soi", "Ta", "Tou", "Va", "Vitro" };
				string[] nm26 = { "gnan", "gnane", "gneux", "llac", "lles", "lliers", "llon", "lly", "nne", "nnet", "nnois", "ppe", "ppes", "rgues", "ssion", "ssis", "ssonne", "ssons", "ssy", "thune", "çon", "béliard", "bagne", "beuge", "bonne", "ciennes", "court", "fort", "gny", "gues", "gueux", "lès", "lême", "let", "limar", "logne", "lon", "luçon", "luire", "lun", "mans", "mart", "masse", "miers", "momble", "mont", "mur", "nau", "nesse", "nin", "noît", "rac", "rault", "ris", "roux", "sart", "seau", "sier", "sir", "teaux", "toise", "tou", "veil", "vers", "ves", "ville", "vin", "yonne", "zieu", "zon" };
				string[] nm30 = new string[] { };

				Random r = new Random();
				int tp = r.Next(2);
				int rnd = 0;
				int rnd2 = 0;
				int rnd3 = 0;
				int rnd4 = 0;
				int nTp = 0;
				int i = 0;
				string plur = "";

				if (tp == 1)
				{
					rnd = r.Next(nm5.Length);
					if (i < 4)
					{
						rnd2 = r.Next(nm6a.Length);
						if (rnd < 16)
						{
							if (rnd2 < 187 && rnd > 8)
							{
								plur = nm6a[rnd2].Substring(nm6a[rnd2].Length - 1, 1);
								if (plur == "s" || plur == "x")
								{
									return nm5[rnd] + " " + nm6b[rnd2];
								}
								else
								{
									return nm5[rnd] + " " + nm6b[rnd2] + "s";
								}
							}
							else
							{
								return nm5[rnd] + " " + nm6b[rnd2];
							}
						}
						else
						{
							if (rnd2 < 187 && rnd > 23)
							{
								plur = nm6b[rnd2].Substring(nm6b[rnd2].Length - 1, 1);
								if (plur == "s" || plur == "x")
								{
									return nm5[rnd] + " " + nm6a[rnd2];
								}
								else
								{
									return nm5[rnd] + " " + nm6a[rnd2] + "s";
								}
							}
							else
							{
								return nm5[rnd] + " " + nm6a[rnd2];
							}
						}
					}
					else
					{
						rnd2 = r.Next(nm25.Length);
						rnd3 = r.Next(nm26.Length);
						if (rnd2 > 7 && rnd2 < 28)
						{
							while (rnd3 < 20)
							{
								rnd3 = r.Next(nm26.Length);
							}
						}
						if (rnd2 < 12)
						{
							nm30 = new string[] { "d'", "de l'" };
						}
						else
						{
							plur = nm26[rnd3].Substring(nm26[rnd3].Length - 1, 1);
							nTp = r.Next(10);
							if (nTp < 6 && plur == "s")
							{
								nm30 = new string[] { "des " };
							}
							else
							{
								nm30 = new string[] { "de ", "du ", "de la " };
							}
						}
						rnd4 = r.Next(nm30.Length);
						return nm5[rnd] + " " + nm30[rnd4] + nm25[rnd2] + nm26[rnd3];
					}
				}
				else
				{
					rnd2 = r.Next(nm2.Length);
					i = r.Next(10);
					if (i < 4)
					{
						rnd = r.Next(nm1.Length);
						return "The " + nm1[rnd] + " " + nm2[rnd2];
					}
					else
					{
						rnd = r.Next(nm3.Length);
						rnd3 = r.Next(nm4.Length);
						return nm3[rnd] + nm4[rnd3] + " " + nm2[rnd2];
					}
				}
			}


		}
	}
}