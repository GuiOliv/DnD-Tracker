
namespace DnD_Tracker.Forms.ChildForms
{
    partial class Player
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
            this.CharacterName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Race = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
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
            this.panelSpells = new System.Windows.Forms.Panel();
            this.btnAddSpell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSpells = new System.Windows.Forms.ListBox();
            this.addSpell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPDF = new System.Windows.Forms.Panel();
            this.btnOpenPDF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelStats.SuspendLayout();
            this.panelSpells.SuspendLayout();
            this.panelPDF.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterName.Location = new System.Drawing.Point(340, 6);
            this.CharacterName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(99, 34);
            this.CharacterName.TabIndex = 0;
            this.CharacterName.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Race);
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Controls.Add(this.CharacterName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 77);
            this.panel1.TabIndex = 1;
            // 
            // Race
            // 
            this.Race.AutoSize = true;
            this.Race.Font = new System.Drawing.Font("Mongolian Baiti", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.Location = new System.Drawing.Point(579, 44);
            this.Race.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(55, 20);
            this.Race.TabIndex = 3;
            this.Race.Text = "label1";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Mongolian Baiti", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(579, 17);
            this.Class.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(55, 20);
            this.Class.TabIndex = 2;
            this.Class.Text = "label1";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Mongolian Baiti", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(360, 44);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(55, 20);
            this.PlayerName.TabIndex = 1;
            this.PlayerName.Text = "label1";
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
            this.PanelStats.Location = new System.Drawing.Point(22, 88);
            this.PanelStats.Margin = new System.Windows.Forms.Padding(1);
            this.PanelStats.Name = "PanelStats";
            this.PanelStats.Size = new System.Drawing.Size(325, 400);
            this.PanelStats.TabIndex = 2;
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
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
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
            this.btnXP.Click += new System.EventHandler(this.btnXP_Click);
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
            // panelSpells
            // 
            this.panelSpells.Controls.Add(this.btnAddSpell);
            this.panelSpells.Controls.Add(this.button1);
            this.panelSpells.Controls.Add(this.listBoxSpells);
            this.panelSpells.Controls.Add(this.addSpell);
            this.panelSpells.Controls.Add(this.label4);
            this.panelSpells.Controls.Add(this.label2);
            this.panelSpells.Location = new System.Drawing.Point(357, 88);
            this.panelSpells.Margin = new System.Windows.Forms.Padding(1);
            this.panelSpells.Name = "panelSpells";
            this.panelSpells.Size = new System.Drawing.Size(382, 271);
            this.panelSpells.TabIndex = 3;
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpell.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpell.Location = new System.Drawing.Point(298, 44);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Size = new System.Drawing.Size(80, 25);
            this.btnAddSpell.TabIndex = 16;
            this.btnAddSpell.Text = "Add";
            this.btnAddSpell.UseVisualStyleBackColor = true;
            this.btnAddSpell.Click += new System.EventHandler(this.btnAddSpell_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(158, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remove Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSpells
            // 
            this.listBoxSpells.FormattingEnabled = true;
            this.listBoxSpells.Location = new System.Drawing.Point(10, 86);
            this.listBoxSpells.Name = "listBoxSpells";
            this.listBoxSpells.Size = new System.Drawing.Size(128, 173);
            this.listBoxSpells.TabIndex = 14;
            // 
            // addSpell
            // 
            this.addSpell.Location = new System.Drawing.Point(122, 49);
            this.addSpell.Name = "addSpell";
            this.addSpell.Size = new System.Drawing.Size(158, 20);
            this.addSpell.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add Spell:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spells";
            // 
            // panelPDF
            // 
            this.panelPDF.Controls.Add(this.btnOpenPDF);
            this.panelPDF.Controls.Add(this.label5);
            this.panelPDF.Location = new System.Drawing.Point(357, 382);
            this.panelPDF.Margin = new System.Windows.Forms.Padding(1);
            this.panelPDF.Name = "panelPDF";
            this.panelPDF.Size = new System.Drawing.Size(386, 106);
            this.panelPDF.TabIndex = 4;
            // 
            // btnOpenPDF
            // 
            this.btnOpenPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPDF.Location = new System.Drawing.Point(129, 56);
            this.btnOpenPDF.Name = "btnOpenPDF";
            this.btnOpenPDF.Size = new System.Drawing.Size(125, 30);
            this.btnOpenPDF.TabIndex = 16;
            this.btnOpenPDF.Text = "Open";
            this.btnOpenPDF.UseVisualStyleBackColor = true;
            this.btnOpenPDF.Click += new System.EventHandler(this.btnOpenPDF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "Character Sheet";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "↺";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(787, 517);
            this.Controls.Add(this.panelPDF);
            this.Controls.Add(this.panelSpells);
            this.Controls.Add(this.PanelStats);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Player";
            this.Text = "Player";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelStats.ResumeLayout(false);
            this.PanelStats.PerformLayout();
            this.panelSpells.ResumeLayout(false);
            this.panelSpells.PerformLayout();
            this.panelPDF.ResumeLayout(false);
            this.panelPDF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Panel PanelStats;
        private System.Windows.Forms.Label Race;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Panel panelSpells;
        private System.Windows.Forms.Panel panelPDF;
        private System.Windows.Forms.TextBox XPTextBox;
        private System.Windows.Forms.Label XPLoader;
        private System.Windows.Forms.ComboBox comboBoxXP;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.ComboBox comboBoxMoney;
        private System.Windows.Forms.Label MoneyLoader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSpell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxSpells;
        private System.Windows.Forms.TextBox addSpell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnXP;
        private System.Windows.Forms.Button btnOpenPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}