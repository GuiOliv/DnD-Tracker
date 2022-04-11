using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Tracker.Components;
using DnD_Tracker.Forms;

namespace DnD_Tracker
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            if (Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory, "*", SearchOption.AllDirectories).Length ==0)
            {
                CampaignList.Visible = false;
            }
            else
            {
                foreach (var folder in Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory, "*", SearchOption.AllDirectories))
                {
                    CampaignList.Items.Add(Path.GetFileName(folder));
                }
            }
        }

        #region Buttons
        private void btnNewCampaign_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCampaignName.Text))
            {
                OpenMainForm();
            }
            else
                MessageBox.Show("Give the campaign a name");
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Campaign newCampaign = new Campaign(CampaignList.SelectedItem.ToString());
                Main MainForm = new Main(newCampaign);
                MainForm.Show();
                this.Hide();
                newCampaign.Deserialize(CampaignList.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Pick a campaign by clicking it on the list");
            }
        }
        #endregion

        private void OpenMainForm()
        {
            Main MainForm = new Main(new Campaign(txtCampaignName.Text));
            MainForm.Show();
            this.Hide();
        }
    }
}
