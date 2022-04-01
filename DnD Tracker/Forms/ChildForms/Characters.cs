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
            listOfPlayers.DataSource = Chr.ListOfPlayers;
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = this.BackColor;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateNewCharacter(), sender);
        }
        #endregion
    }
}
