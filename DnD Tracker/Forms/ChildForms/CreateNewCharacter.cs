using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Tracker.Forms.ChildForms
{
    public partial class CreateNewCharacter : Form
    {
        public CreateNewCharacter()
        {
            InitializeComponent();
        }

        private void btnAddSpell_Click(object sender, EventArgs e)
        {
            if (addSpell.Text.Length != 0)
            {
                listBoxSpells.Items.Add(addSpell.Text);
                addSpell.Clear();
            }
            else
                MessageBox.Show("Write a spell in the text box!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxSpells.SelectedItem != null)
            {
                listBoxSpells.Items.Remove(listBoxSpells.SelectedItem);
            }
            else
                MessageBox.Show("Choose a spell to remove!");
        }

        private void btnCharacterSheet_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("CaracterSheet"))
            {
                Directory.CreateDirectory("CaracterSheet");
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF files | *.pdf";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                   
                }
            }
        }
    }
}
