
namespace DnD_Tracker.Forms.ChildForms
{
    partial class Mission
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
            this.PanelStats = new System.Windows.Forms.Panel();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnXP = new System.Windows.Forms.Button();
            this.XPTextBox = new System.Windows.Forms.TextBox();
            this.XPLoader = new System.Windows.Forms.Label();
            this.comboBoxXP = new System.Windows.Forms.ComboBox();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxMoney = new System.Windows.Forms.ComboBox();
            this.MoneyLoader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MissionName = new System.Windows.Forms.Label();
            this.panelSpells = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.PanelStats.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSpells.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStats
            // 
            this.PanelStats.Controls.Add(this.btnMoney);
            this.PanelStats.Controls.Add(this.btnXP);
            this.PanelStats.Controls.Add(this.XPTextBox);
            this.PanelStats.Controls.Add(this.XPLoader);
            this.PanelStats.Controls.Add(this.comboBoxXP);
            this.PanelStats.Controls.Add(this.MoneyTextBox);
            this.PanelStats.Controls.Add(this.comboBoxMoney);
            this.PanelStats.Controls.Add(this.MoneyLoader);
            this.PanelStats.Controls.Add(this.label3);
            this.PanelStats.Controls.Add(this.label1);
            this.PanelStats.Location = new System.Drawing.Point(35, 113);
            this.PanelStats.Margin = new System.Windows.Forms.Padding(1);
            this.PanelStats.Name = "PanelStats";
            this.PanelStats.Size = new System.Drawing.Size(325, 400);
            this.PanelStats.TabIndex = 3;
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(284, 270);
            this.btnMoney.Margin = new System.Windows.Forms.Padding(1);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(30, 23);
            this.btnMoney.TabIndex = 21;
            this.btnMoney.Text = "OK";
            this.btnMoney.UseVisualStyleBackColor = true;
            // 
            // btnXP
            // 
            this.btnXP.Location = new System.Drawing.Point(247, 124);
            this.btnXP.Margin = new System.Windows.Forms.Padding(1);
            this.btnXP.Name = "btnXP";
            this.btnXP.Size = new System.Drawing.Size(30, 23);
            this.btnXP.TabIndex = 20;
            this.btnXP.Text = "OK";
            this.btnXP.UseVisualStyleBackColor = true;
            // 
            // XPTextBox
            // 
            this.XPTextBox.Location = new System.Drawing.Point(186, 122);
            this.XPTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.XPTextBox.Name = "XPTextBox";
            this.XPTextBox.Size = new System.Drawing.Size(55, 20);
            this.XPTextBox.TabIndex = 19;
            this.XPTextBox.Text = "100";
            // 
            // XPLoader
            // 
            this.XPLoader.AutoSize = true;
            this.XPLoader.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPLoader.Location = new System.Drawing.Point(75, 115);
            this.XPLoader.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.XPLoader.Name = "XPLoader";
            this.XPLoader.Size = new System.Drawing.Size(70, 25);
            this.XPLoader.TabIndex = 17;
            this.XPLoader.Text = "label1";
            // 
            // comboBoxXP
            // 
            this.comboBoxXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXP.FormattingEnabled = true;
            this.comboBoxXP.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxXP.Location = new System.Drawing.Point(148, 122);
            this.comboBoxXP.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxXP.Name = "comboBoxXP";
            this.comboBoxXP.Size = new System.Drawing.Size(36, 21);
            this.comboBoxXP.TabIndex = 18;
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(229, 270);
            this.MoneyTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(50, 20);
            this.MoneyTextBox.TabIndex = 16;
            this.MoneyTextBox.Text = "100";
            // 
            // comboBoxMoney
            // 
            this.comboBoxMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoney.FormattingEnabled = true;
            this.comboBoxMoney.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxMoney.Location = new System.Drawing.Point(192, 269);
            this.comboBoxMoney.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxMoney.Name = "comboBoxMoney";
            this.comboBoxMoney.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMoney.TabIndex = 15;
            // 
            // MoneyLoader
            // 
            this.MoneyLoader.AutoSize = true;
            this.MoneyLoader.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLoader.Location = new System.Drawing.Point(119, 262);
            this.MoneyLoader.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MoneyLoader.Name = "MoneyLoader";
            this.MoneyLoader.Size = new System.Drawing.Size(70, 25);
            this.MoneyLoader.TabIndex = 14;
            this.MoneyLoader.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Money:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "XP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MissionName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 77);
            this.panel1.TabIndex = 4;
            // 
            // MissionName
            // 
            this.MissionName.AutoSize = true;
            this.MissionName.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionName.Location = new System.Drawing.Point(540, 20);
            this.MissionName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MissionName.Name = "MissionName";
            this.MissionName.Size = new System.Drawing.Size(99, 34);
            this.MissionName.TabIndex = 0;
            this.MissionName.Text = "label1";
            // 
            // panelSpells
            // 
            this.panelSpells.Controls.Add(this.button2);
            this.panelSpells.Controls.Add(this.button1);
            this.panelSpells.Controls.Add(this.listBoxPlayers);
            this.panelSpells.Controls.Add(this.label2);
            this.panelSpells.Location = new System.Drawing.Point(379, 113);
            this.panelSpells.Margin = new System.Windows.Forms.Padding(1);
            this.panelSpells.Name = "panelSpells";
            this.panelSpells.Size = new System.Drawing.Size(382, 271);
            this.panelSpells.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remove Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(15, 86);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(128, 173);
            this.listBoxPlayers.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Players";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(199, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Player";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.completedCheckBox);
            this.panel2.Location = new System.Drawing.Point(379, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 113);
            this.panel2.TabIndex = 6;
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.AutoSize = true;
            this.completedCheckBox.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedCheckBox.Location = new System.Drawing.Point(99, 38);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(161, 33);
            this.completedCheckBox.TabIndex = 0;
            this.completedCheckBox.Text = "Completed";
            this.completedCheckBox.UseVisualStyleBackColor = true;
            this.completedCheckBox.CheckedChanged += new System.EventHandler(this.completedCheckBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.desclbl);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(776, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 400);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(4, 49);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(97, 20);
            this.desclbl.TabIndex = 1;
            this.desclbl.Text = "Description";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSpells);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStats);
            this.Name = "Mission";
            this.Text = "Mission";
            this.PanelStats.ResumeLayout(false);
            this.PanelStats.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSpells.ResumeLayout(false);
            this.panelSpells.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelStats;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnXP;
        private System.Windows.Forms.TextBox XPTextBox;
        private System.Windows.Forms.Label XPLoader;
        private System.Windows.Forms.ComboBox comboBoxXP;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.ComboBox comboBoxMoney;
        private System.Windows.Forms.Label MoneyLoader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MissionName;
        private System.Windows.Forms.Panel panelSpells;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label desclbl;
    }
}