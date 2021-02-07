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
		#region Constants

		public static class Titles
		{
			/// <summary>
			/// Player's Handbook
			/// </summary>
			public static readonly string PHB = "Player's Handbook";
			/// <summary>
			/// Xanathar's Guide to Everything
			/// </summary>
			public static readonly string XGE = "Xanathar's Guide to Everything";
			/// <summary>
			/// Mordenkainen's Tome of Foes
			/// </summary>
			public static readonly string MTF = "Mordenkainen's Tome of Foes";
			/// <summary>
			/// Dungeon Master's Guide
			/// </summary>
			public static readonly string DMG = "Dungeon Master's Guide";
			/// <summary>
			/// Monster Manual
			/// </summary>
			public static readonly string MM = "Monster Manual";
			/// <summary>
			/// Volo's Guide to Monsters
			/// </summary>
			public static readonly string VGM = "Volo's Guide to Monsters";
			/// <summary>
			/// Tasha's Cauldron of Everything
			/// </summary>
			public static readonly string TCE = "Tasha's Cauldron of Everything";
		}

		public static class Rolls_String
		{
			public static readonly string d2 = "d2";
			public static readonly string d3 = "d3";
			public static readonly string d4 = "d4";
			public static readonly string d6 = "d6";
			public static readonly string d8 = "d8";
			public static readonly string d10 = "d10";
			public static readonly string d12 = "d12";
			public static readonly string d20 = "d20";
			public static readonly string d100 = "d100";

			public static readonly string d12_plus_d8 = "d12 + d8";
			public static readonly string d6x2 = "2d6";
			public static readonly string d6x3 = "3d6";
			public static readonly string d4x3 = "3d4";
		}

		public static class Rolls_Number
		{
			public static readonly int d2 = 2;
			public static readonly int d3 = 3;
			public static readonly int d4 = 4;
			public static readonly int d6 = 6;
			public static readonly int d8 = 8;
			public static readonly int d10 = 10;
			public static readonly int d12 = 12;
			public static readonly int d20 = 20;
			public static readonly int d100 = 100;
		}

		#endregion

		#region Global

		#region Races

		public static readonly Table damage_types = new Table("Damage Types", "Damage Type", "", "", "None", 0, new TableRow[]{
			new TableRow(1, TableRow.NOVALUE, "Acid"),
			new TableRow(2, TableRow.NOVALUE, "Bludgeoning"),
			new TableRow(3, TableRow.NOVALUE, "Cold"),
			new TableRow(4, TableRow.NOVALUE, "Fire"),
			new TableRow(5, TableRow.NOVALUE, "Force"),
			new TableRow(6, TableRow.NOVALUE, "Lightning"),
			new TableRow(7, TableRow.NOVALUE, "Necrotic"),
			new TableRow(8, TableRow.NOVALUE, "Piercing"),
			new TableRow(9, TableRow.NOVALUE, "Poison"),
			new TableRow(10, TableRow.NOVALUE, "Psychic"),
			new TableRow(11, TableRow.NOVALUE, "Radiant"),
			new TableRow(12, TableRow.NOVALUE, "Slashing"),
			new TableRow(13, TableRow.NOVALUE, "Thunder"),
		});

		public static readonly Table races_source_books_only = new Table("All Official Races", "Race", "", "", "All official source books", 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Dwarf"),
			new TableRow(2, TableRow.NOVALUE, "Elf"),
			new TableRow(3, TableRow.NOVALUE, "Halfling"),
			new TableRow(4, TableRow.NOVALUE, "Human"),
			new TableRow(5, TableRow.NOVALUE, "Dragonborn"),
			new TableRow(6, TableRow.NOVALUE, "Gnome"),
			new TableRow(7, TableRow.NOVALUE, "Half-Elf"),
			new TableRow(8, TableRow.NOVALUE, "Half-Orc"),
			new TableRow(9, TableRow.NOVALUE, "Tiefling"),
			new TableRow(10, TableRow.NOVALUE, "Aasimar"),
			new TableRow(11, TableRow.NOVALUE, "Firbolg"),
			new TableRow(12, TableRow.NOVALUE, "Goliath"),
			new TableRow(13, TableRow.NOVALUE, "Kenku"),
			new TableRow(14, TableRow.NOVALUE, "Lizardfolk"),
			new TableRow(15, TableRow.NOVALUE, "Tabaxi"),
			new TableRow(16, TableRow.NOVALUE, "Triton"),
			new TableRow(17, TableRow.NOVALUE, "Bugbear"),
			new TableRow(18, TableRow.NOVALUE, "Goblin"),
			new TableRow(19, TableRow.NOVALUE, "Hobgoblin"),
			new TableRow(20, TableRow.NOVALUE, "Kobold"),
			new TableRow(21, TableRow.NOVALUE, "Orc"),
			new TableRow(22, TableRow.NOVALUE, "Yuan-Ti Pureblood"),
			new TableRow(23, TableRow.NOVALUE, "Gith"),
		});

		public static readonly Table races_generic_phb = new Table("Player's Handbook Races", "", "", "Race", Data.Titles.PHB, 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Dwarf"),
			new TableRow(2, TableRow.NOVALUE, "Elf"),
			new TableRow(3, TableRow.NOVALUE, "Halfling"),
			new TableRow(4, TableRow.NOVALUE, "Human"),
			new TableRow(5, TableRow.NOVALUE, "Dragonborn"),
			new TableRow(6, TableRow.NOVALUE, "Gnome"),
			new TableRow(7, TableRow.NOVALUE, "Half-Elf"),
			new TableRow(8, TableRow.NOVALUE, "Half-Orc"),
			new TableRow(9, TableRow.NOVALUE, "Tiefling"),
		});

		public static readonly Table races_generic_vgm = new Table("Volo's Guide to Monsters Races", "", "", "Race", Data.Titles.VGM, 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Aasimar"),
			new TableRow(2, TableRow.NOVALUE, "Firbolg"),
			new TableRow(3, TableRow.NOVALUE, "Goliath"),
			new TableRow(4, TableRow.NOVALUE, "Kenku"),
			new TableRow(5, TableRow.NOVALUE, "Lizardfolk"),
			new TableRow(6, TableRow.NOVALUE, "Tabaxi"),
			new TableRow(7, TableRow.NOVALUE, "Triton"),
			new TableRow(8, TableRow.NOVALUE, "Bugbear"),
			new TableRow(9, TableRow.NOVALUE, "Goblin"),
			new TableRow(10, TableRow.NOVALUE, "Hobgoblin"),
			new TableRow(11, TableRow.NOVALUE, "Kobold"),
			new TableRow(12, TableRow.NOVALUE, "Orc"),
			new TableRow(13, TableRow.NOVALUE, "Yuan-Ti Pureblood"),
		});

		public static readonly Table races_generic_mtf = new Table("Mordenkainen's Tome of Foes Races", "", "", "Race", Data.Titles.MTF, 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Gith"),
		});

		public static readonly Table subraces_source_books_only = new Table("All Official Subraces", "Subrace", "", "", "All official source books", 0, new TableRow[]
		{
			// PHB races
			new TableRow(1, TableRow.NOVALUE, "Hill Dwarf"),
			new TableRow(2, TableRow.NOVALUE, "Mountain Dwarf"),
			new TableRow(3, TableRow.NOVALUE, "High Elf"),
			new TableRow(4, TableRow.NOVALUE, "Wood Elf"),
			new TableRow(5, TableRow.NOVALUE, "Dark Elf (Drow)"),
			new TableRow(6, TableRow.NOVALUE, "Lightfoot Halfling"),
			new TableRow(7, TableRow.NOVALUE, "Stout Halfling"),
			new TableRow(8, TableRow.NOVALUE, "Human"),
			new TableRow(9, TableRow.NOVALUE, "Black Dragonborn"),
			new TableRow(10, TableRow.NOVALUE, "Blue Dragonborn"),
			new TableRow(11, TableRow.NOVALUE, "Brass Dragonborn"),
			new TableRow(12, TableRow.NOVALUE, "Bronze Dragonborn"),
			new TableRow(13, TableRow.NOVALUE, "Copper Dragonborn"),
			new TableRow(14, TableRow.NOVALUE, "Gold Dragonborn"),
			new TableRow(15, TableRow.NOVALUE, "Green Dragonborn"),
			new TableRow(16, TableRow.NOVALUE, "Red Dragonborn"),
			new TableRow(17, TableRow.NOVALUE, "Silver Dragonborn"),
			new TableRow(18, TableRow.NOVALUE, "White Dragonborn"),
			new TableRow(19, TableRow.NOVALUE, "Forest Gnome"),
			new TableRow(21, TableRow.NOVALUE, "Rock Gnome"),
			new TableRow(22, TableRow.NOVALUE, "Half-Elf"),
			new TableRow(23, TableRow.NOVALUE, "Half-Orc"),
			new TableRow(24, TableRow.NOVALUE, "Tiefling"),
			// VGM races
			new TableRow(25, TableRow.NOVALUE, "Protector Aasimar"),
			new TableRow(26, TableRow.NOVALUE, "Scourge Aasimar"),
			new TableRow(27, TableRow.NOVALUE, "Fallen Aasimar"),
			new TableRow(28, TableRow.NOVALUE, "Firbolg"),
			new TableRow(29, TableRow.NOVALUE, "Goliath"),
			new TableRow(30, TableRow.NOVALUE, "Kenku"),
			new TableRow(31, TableRow.NOVALUE, "Lizardfolk"),
			new TableRow(32, TableRow.NOVALUE, "Tabaxi"),
			new TableRow(33, TableRow.NOVALUE, "Triton"),
			new TableRow(34, TableRow.NOVALUE, "Bugbear"),
			new TableRow(35, TableRow.NOVALUE, "Goblin"),
			new TableRow(36, TableRow.NOVALUE, "Hobgoblin"),
			new TableRow(37, TableRow.NOVALUE, "Kobold"),
			new TableRow(38, TableRow.NOVALUE, "Orc"),
			new TableRow(39, TableRow.NOVALUE, "Yuan-Ti Pureblood"),
			// MTF races
			new TableRow(40, TableRow.NOVALUE, "Autumn Eladrin Elf"),
			new TableRow(41, TableRow.NOVALUE, "Winter Eladrin Elf"),
			new TableRow(42, TableRow.NOVALUE, "Spring Eladrin Elf"),
			new TableRow(43, TableRow.NOVALUE, "Summer Eladrin Elf"),
			new TableRow(44, TableRow.NOVALUE, "Sea Elf"),
			new TableRow(45, TableRow.NOVALUE, "Shadar-Kai Elf"),
			new TableRow(46, TableRow.NOVALUE, "Duergar Dwarf"),
			new TableRow(47, TableRow.NOVALUE, "Githyanki Gith"),
			new TableRow(48, TableRow.NOVALUE, "Githzerai Gith"),
			new TableRow(49, TableRow.NOVALUE, "Deep Gnome (Svirfneblin)"),
		});

		public static readonly Table races_indepth_phb = new Table("Player's Handbook Subraces", "", "", "Subrace", Data.Titles.PHB, 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Hill Dwarf"),
			new TableRow(2, TableRow.NOVALUE, "Mountain Dwarf"),
			new TableRow(3, TableRow.NOVALUE, "High Elf"),
			new TableRow(4, TableRow.NOVALUE, "Wood Elf"),
			new TableRow(5, TableRow.NOVALUE, "Dark Elf (Drow)"),
			new TableRow(6, TableRow.NOVALUE, "Lightfoot Halfling"),
			new TableRow(7, TableRow.NOVALUE, "Stout Halfling"),
			new TableRow(8, TableRow.NOVALUE, "Human"),
			new TableRow(9, TableRow.NOVALUE, "Black Dragonborn"),
			new TableRow(10, TableRow.NOVALUE, "Blue Dragonborn"),
			new TableRow(11, TableRow.NOVALUE, "Brass Dragonborn"),
			new TableRow(12, TableRow.NOVALUE, "Bronze Dragonborn"),
			new TableRow(13, TableRow.NOVALUE, "Copper Dragonborn"),
			new TableRow(14, TableRow.NOVALUE, "Gold Dragonborn"),
			new TableRow(15, TableRow.NOVALUE, "Green Dragonborn"),
			new TableRow(16, TableRow.NOVALUE, "Red Dragonborn"),
			new TableRow(17, TableRow.NOVALUE, "Silver Dragonborn"),
			new TableRow(18, TableRow.NOVALUE, "White Dragonborn"),
			new TableRow(19, TableRow.NOVALUE, "Forest Gnome"),
			new TableRow(20, TableRow.NOVALUE, "Rock Gnome"),
			new TableRow(21, TableRow.NOVALUE, "Half-Elf"),
			new TableRow(22, TableRow.NOVALUE, "Half-Orc"),
			new TableRow(23, TableRow.NOVALUE, "Tiefling"),
		});

		public static readonly Table races_indepth_vgm = new Table("Volo's Guide to Monsters Subraces", "", "", "Subrace", Data.Titles.VGM, 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Protector Aasimar"),
			new TableRow(2, TableRow.NOVALUE, "Scourge Aasimar"),
			new TableRow(3, TableRow.NOVALUE, "Fallen Aasimar"),
			new TableRow(4, TableRow.NOVALUE, "Firbolg"),
			new TableRow(5, TableRow.NOVALUE, "Goliath"),
			new TableRow(6, TableRow.NOVALUE, "Kenku"),
			new TableRow(7, TableRow.NOVALUE, "Lizardfolk"),
			new TableRow(8, TableRow.NOVALUE, "Tabaxi"),
			new TableRow(9, TableRow.NOVALUE, "Triton"),
			new TableRow(10, TableRow.NOVALUE, "Bugbear"),
			new TableRow(11, TableRow.NOVALUE, "Goblin"),
			new TableRow(12, TableRow.NOVALUE, "Hobgoblin"),
			new TableRow(13, TableRow.NOVALUE, "Kobold"),
			new TableRow(14, TableRow.NOVALUE, "Orc"),
			new TableRow(15, TableRow.NOVALUE, "Yuan-Ti Pureblood"),
		});

		public static readonly Table races_indepth_mtf = new Table("Mordenkainen's Tome of Foes Subraces", "", "", "Subrace", Data.Titles.MTF, 0, new TableRow[]
		{
			new TableRow(1, TableRow.NOVALUE, "Autumn Eladrin Elf"),
			new TableRow(2, TableRow.NOVALUE, "Winter Eladrin Elf"),
			new TableRow(3, TableRow.NOVALUE, "Spring Eladrin Elf"),
			new TableRow(4, TableRow.NOVALUE, "Summer Eladrin Elf"),
			new TableRow(5, TableRow.NOVALUE, "Sea Elf"),
			new TableRow(6, TableRow.NOVALUE, "Shadar-Kai Elf"),
			new TableRow(7, TableRow.NOVALUE, "Duergar Dwarf"),
			new TableRow(8, TableRow.NOVALUE, "Githyanki Gith"),
			new TableRow(9, TableRow.NOVALUE, "Githzerai Gith"),
			new TableRow(10, TableRow.NOVALUE, "Deep Gnome (Svirfneblin)"),
		});

		#endregion Races

		public enum Rarity
		{
			COMMON,
			UNCOMMON,
			RARE,
			VERYRARE,
			LEGENDARY
		}

		public enum RarityModifier
		{
			COMMON = 10,
			UNCOMMON = 0,
			RARE = -10,
			VERYRARE = -20,
			LEGENDARY = -40
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

		public enum AgeRange
		{
			YOUNG,
			ADULT,
			ELDER
		}

		public enum Race_VanillaOnly
		{
			DWARF = 1,
			ELF,
			HALFLING,
			HUMAN,
			DRAGONBORN,
			GNOME,
			HALFELF,
			HALFORC,
			TIEFLING
		}

		public static string getRaceVanillaOnly(int race = -1)
		{
			if(race == -1 || race > 9)
			{
				race = roll(1, 9);
			}

			switch(race)
			{
				case 1:
					if(roll(1, 2) == 2)
					{
						return "Mountain Dwarf";
					}
					else
					{
						return "Hill Dwarf";
					}
				case 2:
					race = roll(1, 3);
					if(race == 1)
					{
						return "High Elf";
					}
					else if(race == 2)
					{
						return "Wood Elf";
					}
					else
					{
						return "Dark Elf (Drow)";
					}
				case 3:
					if(roll(1, 2) == 1)
					{
						return "Lightfoot Halfling";
					}
					else
					{
						return "Stout Halfling";
					}
				case 4:
					return "Human";
				case 5:
					switch(roll(1, 10))
					{
						case 1:
							return "Black Dragonborn";
						case 2:
							return "Blue Dragonborn";
						case 3:
							return "Brass Dragonborn";
						case 4:
							return "Bronze Dragonborn";
						case 5:
							return "Copper Dragonborn";
						case 6:
							return "Gold Dragonborn";
						case 7:
							return "Green Dragonborn";
						case 8:
							return "Red Dragonborn";
						case 9:
							return "Silver Dragonborn";
						default:
							return "White Dragonborn";
					}
				case 6:
					if(roll(1, 2) == 1)
					{
						return "Forest Gnome";
					}
					else
					{
						return "Rock Gnome";
					}
				case 7:
					return "Half-Elf";
				case 8:
					return "Half-Orc";
				default:
					return "Tiefling";
			}
		}

		// TODO
		public static string getAgeByRaceVanillaOnly(int ageRange = -1, int race = -1)
		{
			if(ageRange < 0 || ageRange > 2)
			{
				ageRange = roll(1, 3);
			}

			if(race == -1 || race > 9)
			{
				race = roll(1, 9);
			}
			/*
			switch(ageRange)
			{
				case AgeRange.YOUNG:
					switch (race)
					{
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						default:
							break;
					}
				case AgeRange.ADULT:
					switch (race)
					{
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						default:
					}
				case AgeRange.ELDER:
					switch (race)
					{
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						default:
					}
			}
			*/
			return "twelfity-tooth years old";
		}

		#endregion Global
	}
}