using DnD_Tracker.Components;
using DnD_Tracker.FormsUI;
using DnD_Tracker.UserControls;
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
    public partial class Missions : Form
    {
        public Missions()
        {
            InitializeComponent();
            LoadMissionList();
        }

        #region ChildForm
        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = this.BackColor;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public static void CloseChildForm(Form childForm)
        {
            childForm.Close();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateNewMission(this), sender);
        }

        public void LoadMissionList()
        {
            ListMissions.Controls.Clear();
            foreach (var mission in Msn.ListofMissions)
            {
                ListMissions.Controls.Add(new MissionControl(mission, this));
            }
        }
    }
}
