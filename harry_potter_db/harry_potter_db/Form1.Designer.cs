namespace harry_potter_db
{
    partial class Main
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
            this.Load_spell = new System.Windows.Forms.Button();
            this.Spell_List = new System.Windows.Forms.ComboBox();
            this.Add_Spell = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.Edit_Spell = new System.Windows.Forms.Button();
            this.Save_Spell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_spell
            // 
            this.Load_spell.Location = new System.Drawing.Point(175, 12);
            this.Load_spell.Name = "Load_spell";
            this.Load_spell.Size = new System.Drawing.Size(125, 23);
            this.Load_spell.TabIndex = 1;
            this.Load_spell.Text = "Load Selected Spell";
            this.Load_spell.UseVisualStyleBackColor = true;
            this.Load_spell.Click += new System.EventHandler(this.Load_spell_Click);
            // 
            // Spell_List
            // 
            this.Spell_List.FormattingEnabled = true;
            this.Spell_List.Location = new System.Drawing.Point(12, 12);
            this.Spell_List.Name = "Spell_List";
            this.Spell_List.Size = new System.Drawing.Size(157, 21);
            this.Spell_List.TabIndex = 3;
            this.Spell_List.SelectedIndexChanged += new System.EventHandler(this.Spell_List_SelectedIndexChanged);
            this.Spell_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Spell_List_MouseClick);
            // 
            // Add_Spell
            // 
            this.Add_Spell.Location = new System.Drawing.Point(307, 12);
            this.Add_Spell.Name = "Add_Spell";
            this.Add_Spell.Size = new System.Drawing.Size(75, 23);
            this.Add_Spell.TabIndex = 4;
            this.Add_Spell.Text = "Add Spell";
            this.Add_Spell.UseVisualStyleBackColor = true;
            this.Add_Spell.Click += new System.EventHandler(this.Add_Spell_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(13, 40);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(526, 353);
            this.text.TabIndex = 5;
            this.text.Text = "";
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // Edit_Spell
            // 
            this.Edit_Spell.Location = new System.Drawing.Point(388, 12);
            this.Edit_Spell.Name = "Edit_Spell";
            this.Edit_Spell.Size = new System.Drawing.Size(75, 23);
            this.Edit_Spell.TabIndex = 6;
            this.Edit_Spell.Text = "Edit Spell";
            this.Edit_Spell.UseVisualStyleBackColor = true;
            this.Edit_Spell.Click += new System.EventHandler(this.Edit_Spell_Click);
            // 
            // Save_Spell
            // 
            this.Save_Spell.Location = new System.Drawing.Point(470, 11);
            this.Save_Spell.Name = "Save_Spell";
            this.Save_Spell.Size = new System.Drawing.Size(75, 23);
            this.Save_Spell.TabIndex = 7;
            this.Save_Spell.Text = "Save Spell";
            this.Save_Spell.UseVisualStyleBackColor = true;
            this.Save_Spell.Click += new System.EventHandler(this.Save_Spell_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 405);
            this.Controls.Add(this.Save_Spell);
            this.Controls.Add(this.Edit_Spell);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Add_Spell);
            this.Controls.Add(this.Spell_List);
            this.Controls.Add(this.Load_spell);
            this.Name = "Main";
            this.Text = "Harry\'s Spell Book";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_spell;
        private System.Windows.Forms.ComboBox Spell_List;
        private System.Windows.Forms.Button Add_Spell;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Button Edit_Spell;
        private System.Windows.Forms.Button Save_Spell;
    }
}

