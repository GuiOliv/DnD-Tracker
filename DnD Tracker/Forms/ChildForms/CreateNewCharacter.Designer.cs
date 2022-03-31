
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddSpell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSpells = new System.Windows.Forms.ListBox();
            this.addSpell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addRace = new System.Windows.Forms.TextBox();
            this.addClass = new System.Windows.Forms.TextBox();
            this.addPlayerName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCharacterSheet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Character Name:";
            // 
            // addCharacterName
            // 
            this.addCharacterName.Location = new System.Drawing.Point(156, 12);
            this.addCharacterName.Name = "addCharacterName";
            this.addCharacterName.Size = new System.Drawing.Size(195, 20);
            this.addCharacterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addRace);
            this.panel1.Controls.Add(this.addClass);
            this.panel1.Controls.Add(this.addPlayerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.addCharacterName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 298);
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spells";
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpell.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpell.Location = new System.Drawing.Point(293, 42);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpell.TabIndex = 11;
            this.btnAddSpell.Text = "Add";
            this.btnAddSpell.UseVisualStyleBackColor = true;
            this.btnAddSpell.Click += new System.EventHandler(this.btnAddSpell_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(156, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSpells
            // 
            this.listBoxSpells.FormattingEnabled = true;
            this.listBoxSpells.Location = new System.Drawing.Point(17, 88);
            this.listBoxSpells.Name = "listBoxSpells";
            this.listBoxSpells.Size = new System.Drawing.Size(120, 186);
            this.listBoxSpells.TabIndex = 9;
            // 
            // addSpell
            // 
            this.addSpell.Location = new System.Drawing.Point(125, 45);
            this.addSpell.Name = "addSpell";
            this.addSpell.Size = new System.Drawing.Size(148, 20);
            this.addSpell.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add Spell:";
            // 
            // addRace
            // 
            this.addRace.Location = new System.Drawing.Point(156, 113);
            this.addRace.Name = "addRace";
            this.addRace.Size = new System.Drawing.Size(195, 20);
            this.addRace.TabIndex = 7;
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(156, 80);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(195, 20);
            this.addClass.TabIndex = 6;
            // 
            // addPlayerName
            // 
            this.addPlayerName.Location = new System.Drawing.Point(156, 45);
            this.addPlayerName.Name = "addPlayerName";
            this.addPlayerName.Size = new System.Drawing.Size(195, 20);
            this.addPlayerName.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCharacterSheet);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(391, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 217);
            this.panel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Character Sheet:";
            // 
            // btnCharacterSheet
            // 
            this.btnCharacterSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacterSheet.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharacterSheet.Location = new System.Drawing.Point(240, 87);
            this.btnCharacterSheet.Name = "btnCharacterSheet";
            this.btnCharacterSheet.Size = new System.Drawing.Size(75, 32);
            this.btnCharacterSheet.TabIndex = 12;
            this.btnCharacterSheet.Text = "Upload";
            this.btnCharacterSheet.UseVisualStyleBackColor = true;
            this.btnCharacterSheet.Click += new System.EventHandler(this.btnCharacterSheet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CreateNewCharacter";
            this.Text = "CreateNewCharacter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox addRace;
        private System.Windows.Forms.TextBox addClass;
        private System.Windows.Forms.TextBox addPlayerName;
        private System.Windows.Forms.Button btnAddSpell;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCharacterSheet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}