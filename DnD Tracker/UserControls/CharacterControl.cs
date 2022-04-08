using DnD_Tracker.Components;
using DnD_Tracker.Forms.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Tracker.UserControls
{
    public partial class CharacterControl : UserControl
    {
        Chr Player1 { get; set; }
        Characters Characters { get; set; }
        public CharacterControl(Chr chr, Characters characters)
        {
            InitializeComponent();
            Player1 = chr;
            label1.Text = Player1.NameCharacter;
            Characters = characters;
        }

        public CharacterControl()
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OpenDetails(Player1);
        }

        public void OpenDetails(Chr plr)
        {
            Player pl = new Player(plr);
            pl.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Chr.ListOfPlayers.Remove(Player1);
            Player1 = null;
            Characters.LoadPlayerList();
        }
    }
}
