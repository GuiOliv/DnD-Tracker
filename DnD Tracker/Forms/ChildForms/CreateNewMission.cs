using DnD_Tracker.Components;
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
    public partial class CreateNewMission : Form
    {
        public List<Chr> ListofPlayersMission { get; set; } = new List<Chr>();
        public Missions PastForm;
        public CreateNewMission(Missions pastForm)
        {
            InitializeComponent();
            PastForm = pastForm;
            LoadPLayerList();
        }

        public void LoadPLayerList()
        {
            listPlayers.Items.Clear();
            foreach (var Player in Chr.ListOfPlayers)
            {
                if (!ListofPlayersMission.Contains(Player))
                {
                     listPlayers.Items.Add(Player.NameCharacter);
                }
            }
        }
        public void LoadPlayerMissionList()
        {
            listInMission.Items.Clear();
            foreach (var Player in ListofPlayersMission)
            {
                listInMission.Items.Add(Player.NameCharacter);
            }
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                ListofPlayersMission.Add(Chr.ListOfPlayers.FirstOrDefault(w => w.NameCharacter == listPlayers.Text));
                listPlayers.Items.Remove(listPlayers.SelectedItem);
                LoadPlayerMissionList();
                LoadPLayerList();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Player by clicking on the ListBox to the left");
            }
        }

        private void RemovePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                ListofPlayersMission.Remove(ListofPlayersMission[listInMission.SelectedIndex]);
                listInMission.Items.Remove(listInMission.SelectedItem);
                LoadPlayerMissionList();
                LoadPLayerList();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Player by clicking on the ListBox to the right");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Msn msn = new Msn(txtName.Text, ListofPlayersMission, (int)Xp.Value, (int)Money.Value, textBox1.Text);
                Characters.CloseChildForm(this);
                PastForm.LoadMissionList();
            }
            catch (Exception)
            {
                MessageBox.Show("Every field must be completed");
            }
        }
    }
}
