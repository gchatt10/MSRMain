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
    public partial class editLocForm : Form
    {
        public editLocForm()
        {
            InitializeComponent();
        }

        private void editLocForm_Load(object sender, EventArgs e)
        {
       
        }
        public string _locLabel
        {
            set { label4.Text = value; }
        }
        public string _locTB
        {
            set { newlocTB2.Text = value; }
        }
        public string _addrssTB
        {
            set { newaddrssTB2.Text = value; }
        }
        public string _zipTB
        {
            set { newzipTB2.Text = value; }
        }

        public string _locMod
        {
            get { return newlocTB2.Text.ToString(); }
        }
        public string _addrssMod
        {
            get { return newaddrssTB2.Text.ToString(); }
        }
        public string _zipMod
        {
            get { return newzipTB2.Text.ToString(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
