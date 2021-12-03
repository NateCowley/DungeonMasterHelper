using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMasterHelper
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			new NPC_Form().Show();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			//Data.showTable(Data.World.cataclysmic_distasters);
			//MessageBox.Show(Data.getMultipleRandomFrom(4, Data.Treasure.magic_item_table_a));
			Data.DMG.Treasure.magic_item_table_d.ShowTable();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			/*
			// *****
			// MISSING VILLAIN SCHEMES TABLE
			// *****
			string[] namesOfTables = new string[Data.allTables.Length];
			string[] valuesOfTables = new string[Data.allTables.Length];
			string[] valuesOfDoubleTables = new string[Data.allDoubleTables.Length];

			for (int i = 0; i < Data.allTables.Length; i++)
			{
				valuesOfTables[i] = Data.getTableAsString(Data.allTables[i]);
			}

			for(int i = 0; i < Data.allDoubleTables.Length; i++)
			{
				valuesOfDoubleTables[i] = Data.getTableAsString(Data.allDoubleTables[i]);
			}

			System.IO.File.WriteAllLines(@"C:\Users\lupus\Downloads\tables.txt", valuesOfTables);
			System.IO.File.WriteAllLines(@"C:\Users\lupus\Downloads\doubletables.txt", valuesOfDoubleTables);
			*/
		}

		private void button4_Click(object sender, EventArgs e)
		{

			MessageBox.Show(RandomGenerators.craftStore());
			/*
			string[] valuesOfTables = System.IO.File.ReadAllLines(@"C:\Users\lupus\Downloads\tables.txt");
			string[] valuesOfDoubleTables = System.IO.File.ReadAllLines(@"C:\Users\lupus\Downloads\doubletables.txt");

			List<string> tab = new List<string>();
			List<string> tab2 = new List<string>();

			for(int i = 0; i < valuesOfTables.Length; i++)
			{
				int offset = i;

				while(valuesOfTables[offset] != "")
				{
					offset++;
				}

				tab.Add("public static readonly Table t = new Table(\"n\", new TableRow[]{");

				for(int j = i; j < offset; j++)
				{
					tab.Add(valuesOfTables[j]);
				}

				tab.Add("});");

				i = offset;
			}

			for (int i = 0; i < valuesOfDoubleTables.Length; i++)
			{
				int offset = i;

				while (offset < valuesOfDoubleTables.Length && valuesOfDoubleTables[offset] != "")
				{
					offset++;
				}

				tab2.Add("public static readonly Table t = new Table(\"n\", new TableRow[]{");

				for (int j = i; j < offset; j++)
				{
					tab2.Add(valuesOfDoubleTables[j]);
				}

				tab2.Add("});");

				i = offset;
			}

			System.IO.File.WriteAllLines(@"C:\Users\lupus\Downloads\tables2.txt", tab.ToArray());
			System.IO.File.WriteAllLines(@"C:\Users\lupus\Downloads\doubletables2.txt", tab2.ToArray());
			*/
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Data.DMG.Treasure.magic_item_table_b.ShowTable();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Data.DMG.Treasure.magic_item_table_b.rollOnTable());
		}
	}
}
