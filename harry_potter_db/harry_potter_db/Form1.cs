﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace harry_potter_db
{
    public partial class Main : Form
    {
        bool editing = false;
        int opened;
        public Main()
        {
            InitializeComponent();
            //creates list of spells to access
            if(Directory.Exists("spells"))
            {
                string[] lineOfContents = Directory.GetFiles("spells");
                foreach (var line in lineOfContents)
                {
                    string result = Path.GetFileNameWithoutExtension(line);
                    string[] tokens = result.Split(',');
                    Spell_List.Items.Add(tokens[0]); 
                }
            }
            else
            {
                Directory.CreateDirectory("spells");
            }
        }

        private void Edit_Spell_Click(object sender, EventArgs e)
        {
            if(!editing)
            {
                text.ReadOnly = false;
                Spell_List.Enabled = false;
                editing = true;
            }
            else
            {
                text.ReadOnly = true;
                Spell_List.Enabled = true;
                editing = false;
            }
            
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Spell_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                text.ReadOnly = true;
                File.WriteAllText("spells\\" + Spell_List.SelectedItem.ToString(), text.Text);
                text.ReadOnly = true;
                Spell_List.Enabled = true;
                editing = false;
            }

        }

        private void Add_Spell_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            newspell settingsForm = new newspell();

            // Show the settings form
            settingsForm.Show();
        }

        private void Load_spell_Click(object sender, EventArgs e)
        {
            if(Spell_List.SelectedIndex != -1 && Spell_List.SelectedIndex != opened)
            {
                text.ResetText();
                label1.Text = Spell_List.SelectedItem.ToString();

                text.AppendText(File.ReadAllText("spells\\" + Spell_List.SelectedItem.ToString()));
                opened = Spell_List.SelectedIndex;
            }
        
        }

        private void Spell_List_MouseClick(object sender, MouseEventArgs e)
        {
            //refeshes the list of spells on click
            Spell_List.Items.Clear();
            string[] lineOfContents = Directory.GetFiles("spells"); //gets all spells from directory
            foreach (var line in lineOfContents)
            {
                string result = Path.GetFileNameWithoutExtension(line);//removes the .file
                string[] tokens = result.Split(',');
                Spell_List.Items.Add(tokens[0]);
            }
        }

        private void Spell_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
