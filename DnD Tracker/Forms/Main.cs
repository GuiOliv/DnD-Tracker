using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Tracker.FormsUI;
using DnD_Tracker.Forms.ChildForms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using DnD_Tracker.Components;
using System.Text.Json;
using Newtonsoft.Json;

namespace DnD_Tracker.Forms
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public Campaign thisclass;
        public static Form activeForm { get; private set; }
        public Main(Campaign campaign)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            var combinepath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Campaign.CampaignName);
            if (!Directory.Exists(combinepath))
            {
                Directory.CreateDirectory(combinepath);
            }
            thisclass = campaign;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #region UIColour
        private Color SelectThemeColour()
        {
            int index = random.Next(ThemeColour.ColourList.Count);
            while (tempIndex == index)
            {
              index = random.Next(ThemeColour.ColourList.Count);
            }
            tempIndex = index;
            string colour = ThemeColour.ColourList[index];
            return ColorTranslator.FromHtml(colour);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color colour = SelectThemeColour();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = colour;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = colour;
                    panelLogo.BackColor = ThemeColour.ChangeColourBrightness(colour, -0.3);
                    ThemeColour.PrimaryColour = colour;
                    ThemeColour.SecondaryColour = ThemeColour.ChangeColourBrightness(colour, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BackColor = panelLogo.BackColor;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        #endregion
        #region Buttons
        public void buttonCharacters_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Characters(), sender);
        }

        private void buttonMission_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Missions(), sender);
        }
        public void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            thisclass.Serialize();
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
       
    }
}
