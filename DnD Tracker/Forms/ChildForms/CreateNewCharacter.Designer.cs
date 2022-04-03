
namespace DnD_Tracker.Forms.ChildForms
{
    partial class CreateNewCharacter
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
            this.lblName = new System.Windows.Forms.Label();
            this.addCharacterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRace = new System.Windows.Forms.ComboBox();
            this.addClass = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddSpell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSpells = new System.Windows.Forms.ListBox();
            this.addSpell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addPlayerName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCharacterSheet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 21);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(343, 50);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Character Name:";
            // 
            // addCharacterName
            // 
            this.addCharacterName.Location = new System.Drawing.Point(416, 29);
            this.addCharacterName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addCharacterName.Name = "addCharacterName";
            this.addCharacterName.Size = new System.Drawing.Size(513, 38);
            this.addCharacterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addRace);
            this.panel1.Controls.Add(this.addClass);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addPlayerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.addCharacterName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 1073);
            this.panel1.TabIndex = 5;
            // 
            // addRace
            // 
            this.addRace.FormattingEnabled = true;
            this.addRace.Location = new System.Drawing.Point(416, 273);
            this.addRace.Name = "addRace";
            this.addRace.Size = new System.Drawing.Size(513, 39);
            this.addRace.TabIndex = 10;
            // 
            // addClass
            // 
            this.addClass.FormattingEnabled = true;
            this.addClass.Location = new System.Drawing.Point(416, 193);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(513, 39);
            this.addClass.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 711);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSpell);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBoxSpells);
            this.groupBox1.Controls.Add(this.addSpell);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1043, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spells";
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpell.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpell.Location = new System.Drawing.Point(781, 100);
            this.btnAddSpell.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Size = new System.Drawing.Size(200, 55);
            this.btnAddSpell.TabIndex = 11;
            this.btnAddSpell.Text = "Add";
            this.btnAddSpell.UseVisualStyleBackColor = true;
            this.btnAddSpell.Click += new System.EventHandler(this.btnAddSpell_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(416, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSpells
            // 
            this.listBoxSpells.FormattingEnabled = true;
            this.listBoxSpells.ItemHeight = 31;
            this.listBoxSpells.Location = new System.Drawing.Point(45, 210);
            this.listBoxSpells.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxSpells.Name = "listBoxSpells";
            this.listBoxSpells.Size = new System.Drawing.Size(313, 438);
            this.listBoxSpells.TabIndex = 9;
            // 
            // addSpell
            // 
            this.addSpell.Location = new System.Drawing.Point(333, 107);
            this.addSpell.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addSpell.Name = "addSpell";
            this.addSpell.Size = new System.Drawing.Size(388, 38);
            this.addSpell.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add Spell:";
            // 
            // addPlayerName
            // 
            this.addPlayerName.Location = new System.Drawing.Point(416, 107);
            this.addPlayerName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addPlayerName.Name = "addPlayerName";
            this.addPlayerName.Size = new System.Drawing.Size(513, 38);
            this.addPlayerName.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCharacterSheet);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1043, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 517);
            this.panel3.TabIndex = 6;
            // 
            // btnCharacterSheet
            // 
            this.btnCharacterSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacterSheet.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharacterSheet.Location = new System.Drawing.Point(640, 207);
            this.btnCharacterSheet.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCharacterSheet.Name = "btnCharacterSheet";
            this.btnCharacterSheet.Size = new System.Drawing.Size(200, 76);
            this.btnCharacterSheet.TabIndex = 12;
            this.btnCharacterSheet.Text = "Upload";
            this.btnCharacterSheet.UseVisualStyleBackColor = true;
            this.btnCharacterSheet.Click += new System.EventHandler(this.btnCharacterSheet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Character Sheet:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1043, 517);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1090, 556);
            this.panel4.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(352, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 72);
            this.button2.TabIndex = 12;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CreateNewCharacter";
            this.Text = "CreateNewCharacter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox addCharacterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxSpells;
        private System.Windows.Forms.TextBox addSpell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPlayerName;
        private System.Windows.Forms.Button btnAddSpell;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCharacterSheet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox addRace;
        private System.Windows.Forms.ComboBox addClass;
    }
}