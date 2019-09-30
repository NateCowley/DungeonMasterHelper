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
			MessageBox.Show(Data.getTableAsString(Data.Treasure.carpet_of_flying));
		}

		private void button3_Click(object sender, EventArgs e)
		{
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
		}
	}
}
