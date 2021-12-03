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
		#region Utilities

		private static Random rand = new Random();

		public static readonly bool INDEVELOPMENT = true;

		public static string lowerFirstLetter(string str)
		{
			return str.Substring(0, 1).ToLower() + str.Substring(1);
		}

		public static string upperFirstLetter(string str)
		{
			return str.Substring(0, 1).ToUpper() + str.Substring(1);
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

		public static string getSingleRandomFrom(Table t)
		{
			return t[roll(1, t.MaxRoll)];
		}

		public static string getMultipleRandomFrom(int numItems, Table table)
		{
			if (numItems < 1)
			{
				return "";
			}

			string res = "";

			for (int i = 0; i < numItems; i++)
			{
				res += getSingleRandomFrom(table);

				if (i + 1 != numItems)
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
					list.Add(new TableRow(start, TableRow.NOVALUE, entry));
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
					list.Add(new TableRow(start, TableRow.NOVALUE, entry + otherEntries));
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
	}
}