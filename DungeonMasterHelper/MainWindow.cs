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
            NPC_Form npcf = new NPC_Form();
            npcf.Show();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			string str = "";
			//TableRow[] rows = Data.getTable(Data.Treasure.magic_item_table_c);
			TableRow[] rows = Data.getTable(Data.Treasure.horn_of_valhalla);
			for (int i = 0; i < rows.Length; i++)
			{
				str += rows[i] + "\n";
			}

			MessageBox.Show(str);
		}
	}
}
