
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listOfPlayers = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ Create new Character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listOfPlayers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2133, 1273);
            this.panel1.TabIndex = 1;
            // 
            // listOfPlayers
            // 
            this.listOfPlayers.FormattingEnabled = true;
            this.listOfPlayers.ItemHeight = 31;
            this.listOfPlayers.Location = new System.Drawing.Point(32, 62);
            this.listOfPlayers.Name = "listOfPlayers";
            this.listOfPlayers.Size = new System.Drawing.Size(2065, 1182);
            this.listOfPlayers.TabIndex = 0;
            // 
            // Characters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Characters";
            this.Text = "Characters";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listOfPlayers;
    }
}