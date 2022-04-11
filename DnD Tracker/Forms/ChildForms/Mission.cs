using DnD_Tracker.Components;
using DnD_Tracker.FormsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Tracker.Forms.ChildForms
{
    public partial class Mission : Form
    {
        Msn Msn { get; set; }
        public Mission(Msn mission)
        {
            InitializeComponent();
            this.BackColor = ThemeColour.PrimaryColour;
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                panel.BackColor = ThemeColour.SecondaryColour;
            }
            Msn = mission;
            MissionName.Text = Msn.Name;
            XPLoader.Text = Msn.XP.ToString();
            MoneyLoader.Text = Msn.Money.ToString();
            if (Msn.Completed)
            {
                completedCheckBox.Checked = true;
            }
            if (!String.IsNullOrEmpty(Msn.Description))
            {
                panel3.Visible = true;
                desclbl.Visible = true;
                desclbl.Text = Msn.Description;
            }
            LoadList();
        }
        public void LoadList()
        {
            listBoxPlayers.Items.Clear();
            foreach (var Player in Msn.ListofPLayersinMissions)
            {
                listBoxPlayers.Items.Add(Player.NameCharacter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Msn.ListofPLayersinMissions.Remove(Msn.ListofPLayersinMissions[listBoxPlayers.SelectedIndex]);
            LoadList();
        }

        private void completedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (completedCheckBox.Checked)
                Msn.Completed = true;
            else
                Msn.Completed = false;
        }
    }
}
