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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Load_spell = new System.Windows.Forms.Button();
            this.Spell_List = new System.Windows.Forms.ComboBox();
            this.Add_Spell = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.Edit_Spell = new System.Windows.Forms.Button();
            this.Save_Spell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_spell
            // 
            this.Load_spell.Location = new System.Drawing.Point(12, 39);
            this.Load_spell.Name = "Load_spell";
            this.Load_spell.Size = new System.Drawing.Size(125, 23);
            this.Load_spell.TabIndex = 1;
            this.Load_spell.Text = "Load Selected Spell";
            this.Load_spell.UseVisualStyleBackColor = true;
            this.Load_spell.Click += new System.EventHandler(this.Load_spell_Click);
            // 
            // Spell_List
            // 
            this.Spell_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.Add_Spell.Location = new System.Drawing.Point(12, 68);
            this.Add_Spell.Name = "Add_Spell";
            this.Add_Spell.Size = new System.Drawing.Size(75, 23);
            this.Add_Spell.TabIndex = 4;
            this.Add_Spell.Text = "Add Spell";
            this.Add_Spell.UseVisualStyleBackColor = true;
            this.Add_Spell.Click += new System.EventHandler(this.Add_Spell_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Orange;
            this.text.ForeColor = System.Drawing.Color.Maroon;
            this.text.Location = new System.Drawing.Point(97, 70);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(286, 285);
            this.text.TabIndex = 5;
            this.text.Text = "";
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // Edit_Spell
            // 
            this.Edit_Spell.Location = new System.Drawing.Point(12, 97);
            this.Edit_Spell.Name = "Edit_Spell";
            this.Edit_Spell.Size = new System.Drawing.Size(75, 23);
            this.Edit_Spell.TabIndex = 6;
            this.Edit_Spell.Text = "Edit Spell";
            this.Edit_Spell.UseVisualStyleBackColor = true;
            this.Edit_Spell.Click += new System.EventHandler(this.Edit_Spell_Click);
            // 
            // Save_Spell
            // 
            this.Save_Spell.Location = new System.Drawing.Point(12, 126);
            this.Save_Spell.Name = "Save_Spell";
            this.Save_Spell.Size = new System.Drawing.Size(75, 23);
            this.Save_Spell.TabIndex = 7;
            this.Save_Spell.Text = "Save Spell";
            this.Save_Spell.UseVisualStyleBackColor = true;
            this.Save_Spell.Click += new System.EventHandler(this.Save_Spell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Harry\'s Spell Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 67);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(391, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_Spell);
            this.Controls.Add(this.Edit_Spell);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Add_Spell);
            this.Controls.Add(this.Spell_List);
            this.Controls.Add(this.Load_spell);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Harry\'s Spell Book";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_spell;
        private System.Windows.Forms.ComboBox Spell_List;
        private System.Windows.Forms.Button Add_Spell;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Button Edit_Spell;
        private System.Windows.Forms.Button Save_Spell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

