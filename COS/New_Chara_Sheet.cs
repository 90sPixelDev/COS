using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS
{
    public partial class Edit_Chara_Sheet : Form
    {
        public CharacterSheet charaSheet = new CharacterSheet();
        public bool warningDeleteChara;

        public Edit_Chara_Sheet()
        {
            InitializeComponent();
            NewCharacter();
            character_listbx.SelectedIndex = 0;
            warningDeleteChara = true;
        }

        public void NewCharacter()
        {
            charaSheet.GetCharacterIndex.Add(new Character("(New Blank Character) " + (charaSheet.GetCharacterIndex.Count + 1)));
        }
        public void DeleteCharacter()
        {
            charaSheet.GetCharacterIndex.RemoveAt(character_listbx.SelectedIndex);
            character_listbx.Items.RemoveAt(character_listbx.SelectedIndex);
        }

        public void UpdateCharacterSheet()
        {
            //Making it shorter code by nicknaming the selected index of the character
            var selectedCharA = charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex);

            //Set the textboxes and radiobutton to the values within the currently selected CharacterIndex!
            //Debug.WriteLine("Character Index: {0} Name: {1}", charaSheet.GetCharacterIndex.IndexOf(selectedCharA), selectedCharA.charaName);
            //Debug.WriteLine(charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).pronoun);

            //Updating Name
            charaname_txtbx.Text = selectedCharA.charaName;
            //Updating Age
            age_txtbx.Text = selectedCharA.charaAge;
            //Updating DOB
            dob_txtbx.Text = selectedCharA.dob;
            //Updating Weight
            weight_txtbx.Text = selectedCharA.weight;
            //Updating Height
            height_txtbx.Text = selectedCharA.height;
            //Updating Pronoun
            if (selectedCharA.pronoun == Character.Pronoun.nonbinary)
                nonbinary_rdbtn.Checked = true;
            if (selectedCharA.pronoun == Character.Pronoun.female)
                female_rdbtn.Checked = true;
            if (selectedCharA.pronoun == Character.Pronoun.male)
                male_rdbtn.Checked = true;
            species_race_txtbx.Text = selectedCharA.species;
            //Updating Nationality
            nationality_txtbx.Text = selectedCharA.nationality;
            //Updating Personality
            personality_txtbx.Text = selectedCharA.personality;
            //Updating Likes
            likes_listbx.Items.Clear(); //Removing previous likes from other selected character
            foreach (var item in selectedCharA.likes)
            {
                likes_listbx.Items.Add(item);
            }

            dislikes_listbx.Items.Clear(); //Removing previous dislikes from other selected character
            foreach (var item in selectedCharA.dislikes)
            {
                dislikes_listbx.Items.Add(item);
            }
        }

        private void UpdateCharacterList()
        {
            character_listbx.Items.Clear();
            for (int i = 0; i < charaSheet.CharacterIndex.Count(); i++)
            {
                character_listbx.Items.Add(charaSheet.CharacterIndex[i].charaName);
            }
        }

        private void New_Character_btn_Click(object sender, EventArgs e)
        {
            //Add the character
            character_listbx.Items.Add("(New Blank Character) " + (charaSheet.GetCharacterIndex.Count + 1));
            //Selects the newest character automatically in the Character ListBox
            character_listbx.SelectedIndex = character_listbx.Items.Count - 1;
            NewCharacter();
        }
        private void Delete_Character_btn_Click(object sender, EventArgs e)
        {
            if (character_listbx.Items.Count == 1)
                MessageBox.Show("This is your last character left!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (character_listbx.SelectedIndex == -1)
                MessageBox.Show("You haven't selected any character to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Are you sure you'd like to delete " + character_listbx.SelectedItem + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                DeleteCharacter();
            }
        }

        private void character_listbx_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateCharacterSheet();
        }

        private void Options_btn_Click(object sender, EventArgs e)
        {
            //Temporary code for testing purposes below
            for (int i = 0; i < charaSheet.CharacterIndex.Count(); i++)
            {
                Debug.WriteLine(charaSheet.CharacterIndex[i].charaName);

            }

            test_txtbx.Text = charaSheet.Test;
        }
        private void test_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.Test = test_txtbx.Text;
        }

        private void delete_charainfo_btn_Click(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).charaName = null;
            character_listbx.Items[character_listbx.SelectedIndex] = ("(New Blank Character) " + (charaSheet.GetCharacterIndex.Count + 1));
            charaname_txtbx.Text = null;
        }

        private void load_character_sheet_btn_Click(object sender, EventArgs e)
        {
            LoadCharacterSheet();
        }

        private void save_character_sheet_btn_Click(object sender, EventArgs e)
        {
            SaveCharacterSheet();
        }

        /// <summary>
        /// SETTING DATA BY INPUT FROM WINDOWS FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Set Character Data
        //NAME SET
        private void charaname_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).charaName = charaname_txtbx.Text;
            character_listbx.Items[character_listbx.SelectedIndex] = charaname_txtbx.Text;
        }
        //AGE SET
        private void age_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).charaAge = age_txtbx.Text;
        }
        //DOB SET
        private void dob_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).dob = dob_txtbx.Text;
        }
        //WEIGHT SET
        private void weight_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).weight = weight_txtbx.Text;
        }
        //HEIGHT SET
        private void height_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).height = height_txtbx.Text;
        }
        //PRONOUN SET
        private void nonbinary_rdbtn_Click(object sender, EventArgs e)
        {
            if (nonbinary_rdbtn.Checked)
                charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).pronoun = Character.Pronoun.nonbinary;
        }
        private void female_rdbtn_Click(object sender, EventArgs e)
        {
            if (female_rdbtn.Checked)
                charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).pronoun = Character.Pronoun.female;
        }
        private void male_rdbtn_Click(object sender, EventArgs e)
        {
            if (male_rdbtn.Checked)
                charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).pronoun = Character.Pronoun.male;
        }
        //SPECIES/RACE SET
        private void species_race_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).species = species_race_txtbx.Text;
        }
        //NATIONALITY SET
        private void nationality_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).nationality = nationality_txtbx.Text;
        }
        //PERSONALITY SET
        private void personality_txtbx_Leave(object sender, EventArgs e)
        {
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).personality = personality_txtbx.Text;
        }
        //LIKE ADD
        private void add_like_btn_Click(object sender, EventArgs e)
        {
            likes_listbx.Items.Add(likes_txtbx.Text);
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).likes.Add(likes_txtbx.Text);
            likes_txtbx.Clear();
        }
        //DISLIKE ADD
        private void add_dislike_btn_Click(object sender, EventArgs e)
        {
            dislikes_listbx.Items.Add(dislikes_txtbx.Text);
            charaSheet.GetCharacterIndex.ElementAt(character_listbx.SelectedIndex).dislikes.Add(dislikes_txtbx.Text);
            dislikes_txtbx.Clear();
        }
        //LIKE DELETE
        private void delete_like_btn_Click(object sender, EventArgs e)
        {
            if (likes_listbx.SelectedIndex != -1)
                likes_listbx.Items.RemoveAt(likes_listbx.SelectedIndex);
            else
                MessageBox.Show("No like selected to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //DISLIKE DELETE
        private void delete_dislike_btn_Click(object sender, EventArgs e)
        {
            if (dislikes_listbx.SelectedIndex != -1)
                dislikes_listbx.Items.RemoveAt(dislikes_listbx.SelectedIndex);
            else
                MessageBox.Show("No dislike selected to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion


        /// <summary>
        /// STRIPMENU BUTTON EVENTS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region ToolStripMenu Buttons
        private void saveCharacterSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCharacterSheet();
        }
        private void loadCharacterSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCharacterSheet();
        }

        private void resetCharacterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you'd like to reset the character sheet to a brand new one?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                charaSheet.ResetCharacterIndex();
                character_listbx.Items.Clear();

                character_listbx.Items.Add("(New Blank Character) " + (charaSheet.GetCharacterIndex.Count + 1));
                NewCharacter();

                character_listbx.SelectedIndex = 0;
            }
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Save changes before closing?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                SaveCharacterSheet();
            }
            else
                Application.Exit();
        }
        #endregion


        private void SaveCharacterSheet()
        {
            SaveFileDialog SaveFileDialogMain = new SaveFileDialog();
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Default file extension
            SaveFileDialogMain.DefaultExt = "txt";
            // Available file extensions
            SaveFileDialogMain.Filter = "Text Files (*.txt)|*txt|All Files (*.*)|*.*";
            // Adds a extension if the user does not
            SaveFileDialogMain.AddExtension = false;
            // Restores the selected directory, next time
            SaveFileDialogMain.RestoreDirectory = true;
            // Dialog title
            SaveFileDialogMain.Title = "Where do you want to save the Character Sheet?";
            // Startup directory
            SaveFileDialogMain.InitialDirectory = path;

            if (SaveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                string savepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                SerializeData sdata = new SerializeData(savepath);
                sdata.SerializeCharacterSheet(charaSheet, SaveFileDialogMain.FileName);
                Debug.WriteLine(SaveFileDialogMain.FileName);
            }
            SaveFileDialogMain.Dispose();
        }

        public void LoadCharacterSheet()
        {
            OpenFileDialog openFileDialogMain = new OpenFileDialog();
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            charaSheet = new CharacterSheet();

            // Sets selection of multiple files 
            openFileDialogMain.Multiselect = false;
            // Available file extensions
            openFileDialogMain.Filter = "Text Files (*.txt)|*.txt";
            // Startup directory
            openFileDialogMain.InitialDirectory = path;
            // Restores the selected directory, next time
            openFileDialogMain.RestoreDirectory = true;

            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                //SerializeData sdata = new SerializeData();
                CharacterSheet loadedCharaSheet = (CharacterSheet)SerializeData.BinaryCharacterSheet(openFileDialogMain.FileName);

                charaSheet = loadedCharaSheet;
                UpdateCharacterList();
                //UpdateCharacterSheet();

                Debug.WriteLine(charaSheet.CharacterIndex.Count());
                Debug.WriteLine("Loaded Character Sheet File.");
            }
        }

        private void New_Chara_Sheet_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dlgResult = MessageBox.Show("Save changes before closing?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                SaveCharacterSheet();
            }
            else
            Application.Exit();
        }

    }
}
