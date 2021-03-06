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
using DnD_Tracker.Components;
using DnD_Tracker.UserControls;

namespace DnD_Tracker.Forms.ChildForms
{
    public partial class Characters : Form
    {
        public Characters()
        {
            InitializeComponent();
            LoadPlayerList();
        }
        #region ChildForm
        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = this.BackColor;
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public static void CloseChildForm(Form childForm)
        {
            childForm.Close();
        }

        #endregion

        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateNewCharacter(this), sender);
        }
        #endregion

        public void LoadPlayerList()
        {
            ListofPlayers.Controls.Clear();
            foreach (var player in Chr.ListOfPlayers)
            {
                ListofPlayers.Controls.Add(new CharacterControl(player, this));
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
