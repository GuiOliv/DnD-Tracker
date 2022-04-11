using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Tracker.Components;
using DnD_Tracker.FormsUI;

namespace DnD_Tracker.Forms.ChildForms
{
    public partial class Player : Form
    {
        public Chr Character { get; set; }
        public Player(Chr Player1)
        {
            InitializeComponent();
            this.BackColor = ThemeColour.PrimaryColour;
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                panel.BackColor = ThemeColour.SecondaryColour;
            }
            CharacterName.Text = Player1.NameCharacter;
            PlayerName.Text = Player1.NamePlayer;
            Class.Text = "Class: " + Player1.Class;
            Race.Text = "Race: " + Player1.Race;
            XPLoader.Text = Player1.xp.ToString();
            MoneyLoader.Text = Player1.money.ToString();
            LoadListofSpells(Player1.ListofSpells);
            Character = Player1;
            comboBoxMoney.SelectedIndex = -1;
            comboBoxXP.SelectedIndex = -1;
        }

        public void LoadListofSpells(List<string> list)
        {
            listBoxSpells.Items.Clear();
            foreach (var spell in list)
            {
                listBoxSpells.Items.Add(spell);
            }
        }

        private void btnXP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(XPTextBox.Text))
            {
                Character.XPManager(comboBoxXP.Text ?? "+", int.Parse(XPTextBox.Text));
                XPLoader.Text = Character.xp.ToString();
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MoneyTextBox.Text))
            {
                Character.MoneyManager(comboBoxMoney.Text, int.Parse(MoneyTextBox.Text));
                MoneyLoader.Text = Character.money.ToString();
            }
        }


        private void btnAddSpell_Click(object sender, EventArgs e)
        {
            try
            {
            Character.ListofSpells.Add(addSpell.Text);
            LoadListofSpells(Character.ListofSpells);

            }
            catch (Exception)
            {
                MessageBox.Show("Select an Index");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            Character.ListofSpells.RemoveAt(listBoxSpells.SelectedIndex);
            LoadListofSpells(Character.ListofSpells);

            }
            catch (Exception)
            {
                MessageBox.Show("Select an Index");
            }
        }

        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            var combinepath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Campaign.CampaignName));
            Process.Start(Path.Combine(combinepath, Character.CharacterSheetFileName));
        }
    }
}
