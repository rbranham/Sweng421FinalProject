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
        public String correctAnswer = "";
        public int test;

        public MultipleChoiceCreation()
        {
            InitializeComponent();
            buttonDone.Hide();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            question = textBoxQuestion.Text; //Get Question text
            
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            answer = new String[4] {answerBox1.Text, answerBox2.Text, answerBox3.Text, answerBox4.Text}; 
            if (answerRB1.Checked)
                correctAnswer = answer[0];
            else if (answerRB2.Checked)
                correctAnswer = answer[1];
            else if (answerRB3.Checked)
                correctAnswer = answer[2];
            else if (answerRB4.Checked)
                correctAnswer = answer[3];
            else
                correctAnswer = "";
            buttonDone.Show();
        }
    }
}
