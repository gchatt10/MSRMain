using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSRDemo1
{
    public partial class addnoteForm : Form
    {
        public addnoteForm()
        {
            InitializeComponent();
            textBox1.Text = "";
        }
        public string _addnotenote
        {
            get { return textBox1.Text.ToString() + "   " + DateTime.Now; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("Please enter a note first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
