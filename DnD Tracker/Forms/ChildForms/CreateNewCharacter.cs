using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Tracker.Components;

namespace DnD_Tracker.Forms.ChildForms
{
    public partial class CreateNewCharacter : Form
    {
        string CharacterSheetFileName { get; set; }

        private Characters ParentForm;
        public CreateNewCharacter(Characters parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
            addClass.DataSource = Enum.GetValues(typeof(Classes));
            addRace.DataSource = Enum.GetValues(typeof(Races));
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
            var combinepath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "CharacterSheet");
            if (!Directory.Exists(combinepath))
            {
                Directory.CreateDirectory(combinepath);
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF files | *.pdf";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fi = new FileInfo(dialog.FileName);
                string path = Path.Combine(combinepath, fi.Name);
                File.Copy(dialog.FileName, path);
                CharacterSheetFileName = fi.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Chr NewPLayer = new Chr(addCharacterName.Text, addPlayerName.Text, (Classes)Enum.Parse(typeof(Classes), addClass.GetItemText(addClass.SelectedItem)), (Races)Enum.Parse(typeof(Races), addRace.GetItemText(addRace.SelectedItem)), listBoxSpells.Items.Cast<String>().ToList(), CharacterSheetFileName);
                Characters.CloseChildForm(this);
                ParentForm.LoadPlayerList();
            }
            catch (Exception)
            {
                MessageBox.Show("Every field must be completed");
            }
        }
    }
}
