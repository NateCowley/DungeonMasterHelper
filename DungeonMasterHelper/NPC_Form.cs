﻿using System;
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
            talentTB.Text = Data.getRandomFrom(Data.NPC.npc_talents);
            idealTB.Text = Data.getRandomFrom(Data.NPC.ideals[Data.roll(1, Data.NPC.ideals.Length) - 1]);
            bondTB.Text = Data.getRandomFrom(Data.NPC.npc_bonds);
            flawSecretRTB.Text = Data.getRandomFrom(Data.NPC.npc_flaws_and_secrets);

        }
    }
}