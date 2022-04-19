
namespace DnD_Tracker
{
    partial class FirstForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewCampaign = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.CampaignList = new System.Windows.Forms.ListBox();
            this.txtCampaignName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(317, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1079, 258);
            this.label1.TabIndex = 0;
            this.label1.Text = "DnD Tracker";
            // 
            // btnNewCampaign
            // 
            this.btnNewCampaign.BackColor = System.Drawing.Color.Maroon;
            this.btnNewCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCampaign.Location = new System.Drawing.Point(470, 326);
            this.btnNewCampaign.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNewCampaign.Name = "btnNewCampaign";
            this.btnNewCampaign.Size = new System.Drawing.Size(667, 114);
            this.btnNewCampaign.TabIndex = 1;
            this.btnNewCampaign.Text = "New Campaign";
            this.btnNewCampaign.UseVisualStyleBackColor = false;
            this.btnNewCampaign.Click += new System.EventHandler(this.btnNewCampaign_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Maroon;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(470, 634);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(667, 114);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Campaign";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // CampaignList
            // 
            this.CampaignList.FormattingEnabled = true;
            this.CampaignList.ItemHeight = 31;
            this.CampaignList.Location = new System.Drawing.Point(470, 796);
            this.CampaignList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CampaignList.Name = "CampaignList";
            this.CampaignList.Size = new System.Drawing.Size(660, 376);
            this.CampaignList.TabIndex = 3;
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Location = new System.Drawing.Point(1156, 390);
            this.txtCampaignName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(417, 38);
            this.txtCampaignName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1167, 932);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 114);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Campaign";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::DnD_Tracker.Properties.Resources.a4fb0f5276623_562b526084268;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1707, 1398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCampaignName);
            this.Controls.Add(this.CampaignList);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNewCampaign);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FirstForm";
            this.Text = "Hub";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCampaign;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox CampaignList;
        private System.Windows.Forms.TextBox txtCampaignName;
        private System.Windows.Forms.Button button1;
    }
}

