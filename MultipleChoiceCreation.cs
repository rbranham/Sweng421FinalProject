using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class MultipleChoiceCreation : Form
    {
        //Variables to save 
        public String question = "";
        public String[] answer;
        public String correct = "";

        public MultipleChoiceCreation()
        {
            InitializeComponent();
            buttonDone.Hide();
        }

        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            answer = new String[4] {answerBox1.Text, answerBox2.Text, answerBox3.Text, answerBox4.Text}; 
            if (answerRB1.Checked)
                correct = answer[0];
            else if (answerRB2.Checked)
                correct = answer[1];
            else if (answerRB3.Checked)
                correct = answer[2];
            else if (answerRB4.Checked)
                correct = answer[3];
            else
                correct = "";
            question = textBoxQuestion.Text; //Get Question text
 
            buttonDone.Show();
        }
    }
}
