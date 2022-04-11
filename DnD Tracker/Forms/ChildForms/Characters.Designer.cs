
namespace DnD_Tracker.Forms.ChildForms
{
    partial class Characters
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.ListofPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.characterControl1 = new DnD_Tracker.UserControls.CharacterControl();
            this.panelChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ Create new Character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChild
            // 
            this.panelChild.Controls.Add(this.ListofPlayers);
            this.panelChild.Location = new System.Drawing.Point(0, 79);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(800, 534);
            this.panelChild.TabIndex = 1;
            // 
            // ListofPlayers
            // 
            this.ListofPlayers.Location = new System.Drawing.Point(1, 1);
            this.ListofPlayers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListofPlayers.Name = "ListofPlayers";
            this.ListofPlayers.Size = new System.Drawing.Size(798, 528);
            this.ListofPlayers.TabIndex = 3;
            // 
            // characterControl1
            // 
            this.characterControl1.Location = new System.Drawing.Point(236, 12);
            this.characterControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.characterControl1.Name = "characterControl1";
            this.characterControl1.Size = new System.Drawing.Size(543, 63);
            this.characterControl1.TabIndex = 2;
            // 
            // Characters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.characterControl1);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.button1);
            this.Name = "Characters";
            this.Text = "Characters";
            this.panelChild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelChild;
        private UserControls.CharacterControl characterControl1;
        private System.Windows.Forms.FlowLayoutPanel ListofPlayers;
    }
}