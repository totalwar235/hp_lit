using System;
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
    public partial class newspell : Form
    {
        public newspell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                //makes the file
                if (Directory.Exists("spells"))
                {
                    File.CreateText("spells\\"+textBox1.Text);
                }
                else
                {
                    Directory.CreateDirectory("spells");
                    File.CreateText("spells\\" + textBox1.Text);
                }
                this.Close();
            }
        }
    }
}
