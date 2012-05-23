﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quesos.Properties;
using MSRDemo1;

namespace Quesos
{
    public partial class Form1 : Form
    {
        string locMain;
        string loginMain;
        public Form1()
        {
            InitializeComponent();
            Image myImage = Resources.tabImg;

            TabControl.TabPageCollection pages = tabControl1.TabPages;
            foreach (TabPage page in pages)
            {
                page.BackgroundImage = myImage;
                page.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
        
        private void DoLogin()
        {
            try
            {
                if (uNtextBox.Text == "" || psswdtextBox.Text == "" && !listBox3.Items.Contains(comboBox1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Login Data is Incorrect.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (uNtextBox.Text == "admin" && listBox3.Items.Contains(comboBox1.SelectedItem.ToString()))
                {
                    loginMain = "admin";
                    locMain = comboBox1.SelectedItem.ToString();
                    addLocButton.Visible = true;
                    editloc.Visible = true;
                    delnoteButton.Visible = true;
                    //toolStripStatusLabel3.Text = "Location: " + comboBox1.SelectedItem.ToString();
                    //toolStripStatusLabel2.Text = "User: Administrator      ";
                    menuItem26.Visible = true;
                    menuItem21.Visible = true;
                    addnoteButton.Visible = true;
                    menuItem1.Visible = true;
                    menuItem7.Visible = true;
                    menuItem11.Visible = true;
                    menuItem12.Visible = true;
                    tabControl1.SelectedTab = dashboardTab;
                    linkLabel2.Visible = true;
                    label18.Visible = true;
                    addUNTextBox.Visible = true;
                    button4.Visible = true;
                    linkLabel3.Visible = true;
                    //MessageBox.Show("Login with admin successful!", "Admin!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Location Incorrect!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (uNtextBox.Text != "admin" && listBox3.Items.Contains(comboBox1.SelectedItem.ToString()))
                {
                    //toolStripStatusLabel3.Text = "Location: " + comboBox1.SelectedItem.ToString();
                    //toolStripStatusLabel2.Text = "User: " + uNtextBox.Text + "      ";
                    button4.Visible = false;
                    menuItem1.Visible = true;
                    menuItem7.Visible = true;
                    delnoteButton.Visible = false;
                    listBox2.Items.Add(uNtextBox.Text);
                    tabControl1.SelectedTab = dashboardTab;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please enter correct login information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (comboBox1.SelectedItem.ToString() == "harrah")
                {
                    locTB.Text = comboBox1.SelectedItem.ToString();
                    newaddrssTB.Text = " Harrah, OK";
                    newzipTB.Text = "77777";
                    newsublocTB.Text = "Sub Loc 2";
                    listBox3.SelectedItem = comboBox1.SelectedItem.ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "mwc")
                {
                    locTB.Text = comboBox1.SelectedItem.ToString();
                    newaddrssTB.Text = " MidWest City, OK";
                    newzipTB.Text = "73130";
                    newsublocTB.Text = "Sub Loc 1";
                    listBox3.SelectedItem = comboBox1.SelectedItem.ToString();
                }
                //panel1.Visible = false;
                this.Refresh();
            }
            //throw new NotImplementedException();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = backUpTab;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = locFMTab;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = subLocFMTab;
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = userFMTab;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = secFMTab;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = salesEntryTab;
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = salesFMTab;
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = emplFMTab;
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = salesEntryTab;
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = payEntryTab;
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = payoutRprtsTab;
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = catFMTab;
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = vendorsFMTab;
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = subCatFMTab;
        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = EODTab;
        }

        private void menuItem20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = EODRprtsTab;
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = invFMTab;
        }

        private void menuItem23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = invPricesTab;
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = invEntryTab;
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = invRprtsTab;
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = salesRprtsTab;
        }

        private void menuItem28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = payoutRprtsTab;
        }

        private void menuItem29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = EODRprtsTab;
        }

        private void menuItem30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = auditRprtsTab;
        }

        private void menuItem31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = laborRprtsTab;
        }

        private void menuItem32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = invRprtsTab;
        }

        private void menuItem33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = rprtsFMTab;
        }

        private void menuItem34_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = backUpTab;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = salesEntryTab;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = adminTab;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = userFMTab;
        }

        private void addnoteButton_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
            //addnoteForm noteForm = new addnoteForm();
            //noteForm.ShowDialog();
            //if(noteForm.ShowDialog = DialogResult.Cancel)
            //listBox4.Items.Add(noteForm._addnotenote.ToString());
        }
        public void ShowMyDialogBox()
        {
            addnoteForm testDialog = new addnoteForm();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                listBox4.Items.Add(testDialog._addnotenote);
            }
            testDialog.Dispose();
        }

        private void delnoteButton_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem); 
        }

        private void backUpButton_Click(object sender, EventArgs e)
        {
            DoBackUp();
        }

        private void DoBackUp()
        {
            buListBox.Items.Add(locMain + "     " + loginMain + "       " + DateTime.Now);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //upload button
                buListBox.Items.Remove(buListBox.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //delete upload button
            buListBox.Items.Remove(buListBox.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            locMain = listBox3.SelectedItem.ToString();
            locTB.Text = listBox3.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoAddUser();
        }

        private void DoAddUser()
        {
            try
            {
                if (addUserIDTextBox.Text != "" && addUNTextBox.Text != "")
                {
                    listBox2.Items.Add(addUserIDTextBox.Text + "        " + addUNTextBox.Text + "       " +
                        comboBox2.SelectedItem.ToString
                        ());
                }
                else 
                {
                    MessageBox.Show("Please enter user data.", "Error", MessageBoxButtons.OK);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}