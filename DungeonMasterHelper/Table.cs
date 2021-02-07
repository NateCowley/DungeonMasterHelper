using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMasterHelper
{
	public class Table
	{
		private string tableName;
		private TableRow[] tableRows;
		private int length = 0;
		private int maxRoll = 0;
		private string tableEntryDesc;
		private int pageNumber = 0;
		private string sourceBook;
		private string roll;
		private string rollMod;

		public string Name { get { return tableName; } }

		public TableRow[] Entries { get { return tableRows; } }

		public int Length { get { return length; } }

		/// <summary>
		/// MaxRoll is the highest you can roll on the table.
		/// </summary>
		public int MaxRoll { get { return maxRoll; } }

		/// <summary>
		/// Desc is the description at the top of the table detailing what the entries are.
		/// </summary>
		public string Desc { get { return tableEntryDesc; } }

		/// <summary>
		/// PageNumber is the page number of the table in the sourcebook it came from.
		/// </summary>
		public int PageNumber { get { return pageNumber; } }

		/// <summary>
		/// SourceBook is the name of the source book the table came from.
		/// </summary>
		public string SourceBook { get { return sourceBook; } }

		/// <summary>
		/// Roll is the text value of the dice to roll on the table (d12, d20...)
		/// </summary>
		public string Roll { get { return roll; } }

		/// <summary>
		/// RollMod is the text value of the modifier to apply to the Roll (+Cha mod, +value from other table...)
		/// </summary>
		public string RollMod { get { return rollMod; } }

		/// <summary>
		/// The [] operators have been redefined for this class. Instead of 
		/// returning an item at an index, it gets the table entry based on roll.
		/// <para>To get the TableRow at a specific index, use getRowAtIndex().</para>
		/// </summary>
		public TableRow this[int x]
		{
			get
			{
				// if the number is less than 0, return the first entry
				if (x < 0)
				{
					return tableRows[0];
				}

				// if the number is greater than the maximum roll, return the last entry
				if (x > MaxRoll)
				{
					return tableRows[length - 1];
				}

				// try to return the value that matches the number
				for (int i = 0; i < length; i++)
				{
					if (tableRows[i].numInRange(x))
					{
						return tableRows[i];
					}
				}

				// default case, return the lowest entry
				return tableRows[0];
			}
		}

		public static implicit operator String(Table t)
		{
			if (t == null)
			{
				return "";
			}

			string res = "           " + t.Desc + "\n";

			for (int i = 0; i < t.Length; i++)
			{
				res += t.getRowAtIndex(i).ToString() + "\n";
			}

			return res;
		}

		public Table(string name, string desc, string roll, string rollMod, string source, int pageNum, TableRow[] entries)
		{
			tableName = name;
			tableEntryDesc = desc;
			this.roll = roll;
			this.rollMod = rollMod;
			sourceBook = source;
			pageNumber = pageNum;
			tableRows = entries;
			length = entries.Length;
			maxRoll = entries[length - 1].Max;
		}

		public string rollOnTable(int modifier = 0)
		{
			modifier += Data.roll(1, maxRoll);

			return this[modifier];
		}

		public TableRow getRowAtIndex(int index)
		{
			if (index > tableRows.Length - 1 || index < 0)
			{
				return tableRows[0];
			}

			return tableRows[index];
		}

		public void ShowTable()
		{
			MessageBox.Show(this, Name);
		}
	}
}
