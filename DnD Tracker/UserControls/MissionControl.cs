using DnD_Tracker.Components;
using DnD_Tracker.Forms.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Tracker.UserControls
{
    public partial class MissionControl : UserControl
    {
        public Msn Mission { get; set; }
        public Missions PastForm { get; set; }
        public MissionControl(Msn mission, Missions pastForms)
        {
            InitializeComponent();
            Mission = mission;
            PastForm = pastForms;
            label1.Text = Mission.Name;
            if (Mission.Completed)
            {
                btnRemove.Visible = false;
                isCompleted.Visible = true;
                isCompleted.Text = "Completed";
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OpenDetails(Mission);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in Chr.ListOfPlayers.Where(w => w.ListofMisions.Contains(Mission)))
            {
                item.ListofMisions.Remove(Mission);
            }
            Msn.ListofMissions.Remove(Mission);
            Mission = null;
            PastForm.LoadMissionList();
        }

        public void OpenDetails(Msn msn)
        {
            Mission ms = new Mission(msn);
            ms.Show();
        }

        private void isCompleted_Click(object sender, EventArgs e)
        {

        }
    }
}
