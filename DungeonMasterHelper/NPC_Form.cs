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
    public partial class NPC_Form : Form
    {
        public NPC_Form()
        {
            InitializeComponent();

            // TODO: make name table, make race table, make race age range generator

            appearanceRTB.Text = Data.getRandomFrom(Data.NPC.npc_appearance);
            mannerismTB.Text = Data.getRandomFrom(Data.NPC.npc_mannerisms);
            interactionsTB.Text = Data.getRandomFrom(Data.NPC.npc_interaction_traits);
            abilitiesHighTB.Text = Data.getRandomFrom(Data.NPC.npc_high_abilities);
            abilitiesLowTB.Text = Data.getRandomFrom(Data.NPC.npc_low_abilities);

			// save the name of the high and low abilities, and make sure we don't have 
			// duplicates
			string hstr = abilitiesHighTB.Text.Substring(0, abilitiesHighTB.Text.IndexOf('-'));
			string lstr = abilitiesLowTB.Text.Substring(0, abilitiesLowTB.Text.IndexOf('-'));

			while(hstr == lstr)
			{
				abilitiesLowTB.Text = Data.getRandomFrom(Data.NPC.npc_low_abilities);

				lstr = abilitiesLowTB.Text.Substring(0, abilitiesLowTB.Text.IndexOf('-'));
			}

            talentTB.Text = Data.getRandomFrom(Data.NPC.npc_talents);
            idealTB.Text = Data.getRandomFrom(Data.NPC.ideals[Data.roll(1, Data.NPC.ideals.Length) - 1]);
            bondTB.Text = Data.getRandomFrom(Data.NPC.npc_bonds);
            flawSecretRTB.Text = Data.getRandomFrom(Data.NPC.npc_flaws_and_secrets);

        }

		private void nameTB_TextChanged(object sender, EventArgs e)
		{
			if(nameTB.Text.Length > 0)
			{
				this.Text = "NPC Form - " + nameTB.Text;
			}
			else
			{
				this.Text = "NPC Form";
			}
		}

		private void NPC_Form_DoubleClick(object sender, EventArgs e)
		{
			if(Data.DEVELOPMENT)
			{
				MessageBox.Show(this.Width.ToString() + " " + this.Height.ToString());
			}
		}
	}
}
