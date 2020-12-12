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
        public String[] answers = new string[4];
        public String correctAnswer;
        public String questionText;
        

        public MultipleChoiceCreation()
        {
            InitializeComponent();
        }

        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {             
            answers[0] = answerBox1.Text;
            answers[1] = answerBox2.Text;
            answers[2] = answerBox3.Text;
            answers[3] = answerBox4.Text;
            
            if (answerRB1.Checked)
                correctAnswer = answers[0];
            else if (answerRB2.Checked)
                correctAnswer = answers[1];
            else if (answerRB3.Checked)
                correctAnswer = answers[2];
            else if (answerRB4.Checked)
                correctAnswer = answers[3];
            else
                correctAnswer = "";
            questionText = textBoxQuestion.Text; //Get Question text

            this.Close();
        }
    }
}
