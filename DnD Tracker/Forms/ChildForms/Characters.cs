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
            int count = 0;
            foreach (var panel in panelChild.Controls.OfType<Panel>().OrderBy(w => w.Name))
            {
                if (count != Chr.ListOfPlayers.Count && Chr.ListOfPlayers != null)
                {
                    panel.Visible = true;
                    panel.Controls.OfType<Label>().First().Text = Chr.ListOfPlayers[count].NameCharacter;
                    count++;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label1.Text).First();
            OpenDetails(player);
        }
        
        public void OpenDetails(Chr plr)
        {
            Player pl = new Player(plr);
            pl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label2.Text).First();
            OpenDetails(player);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label3.Text).First();
            OpenDetails(player);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label4.Text).First();
            OpenDetails(player);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label5.Text).First();
            OpenDetails(player);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label6.Text).First();
            OpenDetails(player);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label7.Text).First();
            OpenDetails(player);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Chr player = Chr.ListOfPlayers.Where(w => w.NameCharacter == label1.Text).First();
            Chr.ListOfPlayers.Remove(player);
            player = null;
            LoadPlayerList();
        }
    }
}
