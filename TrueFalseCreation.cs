using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sweng421FinalProject;


namespace Sweng421FinalProject
{
    public partial class TrueFalseCreation : Form
    {
        public Boolean trueFalse;
        public String questionText;
        public TrueFalseCreation()
        {
            InitializeComponent();
            doneButton.Hide();
        }

        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            questionText = textBox1.Text;
            if (trueRB.Checked)
                trueFalse = true;
            else if (falseRB.Checked)
                trueFalse = false;
            else
                trueFalse = false;
            this.Close();
        }

        private void CompositeCreation_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            doneButton.Show();
        }
    }
}

