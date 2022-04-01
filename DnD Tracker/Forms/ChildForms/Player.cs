using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public void LoadListofSpells(List<string> list)
        {
            foreach (var spell in list)
            {
                listBoxSpells.Items.Add(spell);
            }
        }

        private void btnXP_Click(object sender, EventArgs e)
        {
            Character.XPManager(comboBoxXP.Text, int.Parse(XPTextBox.Text));
            XPLoader.Text = Character.xp.ToString();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            Character.MoneyManager(comboBoxMoney.Text, int.Parse(MoneyTextBox.Text));
            MoneyLoader.Text = Character.money.ToString();
        }
    }
}
