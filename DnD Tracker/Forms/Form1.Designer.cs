
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
            this.label1.Location = new System.Drawing.Point(164, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "DnD Tracker";
            // 
            // btnNewCampaign
            // 
            this.btnNewCampaign.BackColor = System.Drawing.Color.Maroon;
            this.btnNewCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCampaign.Location = new System.Drawing.Point(236, 239);
            this.btnNewCampaign.Name = "btnNewCampaign";
            this.btnNewCampaign.Size = new System.Drawing.Size(250, 48);
            this.btnNewCampaign.TabIndex = 1;
            this.btnNewCampaign.Text = "New Campaign";
            this.btnNewCampaign.UseVisualStyleBackColor = false;
            this.btnNewCampaign.Click += new System.EventHandler(this.btnNewCampaign_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD_Tracker.Properties.Resources.a4fb0f5276623_562b526084268;
            this.ClientSize = new System.Drawing.Size(733, 621);
            this.Controls.Add(this.btnNewCampaign);
            this.Controls.Add(this.label1);
            this.Name = "FirstForm";
            this.Text = "Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCampaign;
    }
}

