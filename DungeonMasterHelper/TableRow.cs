using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterHelper
{
	public class TableRow
	{
		public static readonly int NOVALUE = -1;
		private readonly int minRoll, maxRoll;
		private readonly string entry;

		public string Entry
		{
			get { return entry; }
		}

		public int Min
		{
			get { return minRoll; }
		}

		public int Max
		{
			// if the maxroll is -1 (or lower), return minroll, else return maxroll.
			// this is for single value items. For example, having to roll a 1 on the "Parents"
			// table in the XGE section
			get { return maxRoll < 0 ? minRoll : maxRoll; }
		}

		public TableRow() { }

		public TableRow(int min, int max, string str)
		{
			minRoll = min;
			maxRoll = max;
			entry = str;
		}

		public static implicit operator String(TableRow tr)
		{
			return tr.Entry;
		}

		public override string ToString()
		{
			string res = "";

			// if the minimum roll is 0-9, return as 00-09
			// TODO: might need to update for negative values (XGE background tables)
			if (minRoll < 10)
			{
				res += "0";
			}
			else if (minRoll == 100)
			{
				return res + "00       " + entry;
			}

			res += minRoll.ToString();

			if (maxRoll != NOVALUE)
			{
				res += "-";
				if (maxRoll < 10)
				{
					res += "0" + maxRoll.ToString();
				}
				else if (maxRoll == 100)
				{
					res += "00";
				}
				else
				{
					res += maxRoll.ToString();
				}
			}
			else
			{
				res += "     ";
			}

			res += "  " + entry;

			return res;
		}

		public bool numInRange(int num)
		{
			return (num > minRoll && num < maxRoll || num == minRoll || num == maxRoll);
		}
	}

}
