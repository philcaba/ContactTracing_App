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

namespace Contact_TracingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lstBoxOutput.Items.Add(txBxName.Text);
        }

        private void txBxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            lstBoxOutput.Items.Add(txBoxAddress.Text);
        }

        private void btnAddAge_Click(object sender, EventArgs e)
        {
            lstBoxOutput.Items.Add(txBxAge.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxOutput.Items.RemoveAt(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("Day 1.txt");
            outputFile.WriteLine(lstBoxOutput.Text);
            outputFile.Close();
        }
    }
}
