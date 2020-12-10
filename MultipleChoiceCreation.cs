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
        public List<String> answer = new List<String>();
        public String correctAnswer = "";

        private int answerNum = 0;
        private int correctAns = 0;
        private String answer1 = "";
        private String answer2 = "";
        private String answer3 = "";
        private String answer4 = "";



        public MultipleChoiceCreation()
        {
            InitializeComponent();

            buttonDone.Hide();
            answerRB1.Hide();
            answerRB2.Hide();
            answerRB3.Hide();
            answerRB4.Hide();
            answerBox1.Hide();
            answerBox2.Hide();
            answerBox3.Hide();
            answerBox4.Hide();

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            question = textBoxQuestion.Text; //Get Question text
            for (int i = 0; i < Convert.ToInt32(numAnswers.Value); i++)
            {
                answer.Add("");
            }

            correctAnswer = ""; 

            this.Close();
        }


        private void numAnswers_ValueChanged(object sender, EventArgs e)
        {
            buttonDone.Hide();

            answerNum = Convert.ToInt32(numAnswers.Value);
            if(answerNum == 0)
            {
                answerRB1.Hide();
                answerRB2.Hide();
                answerRB3.Hide();
                answerRB4.Hide();
                answerBox1.Hide();
                answerBox2.Hide();
                answerBox3.Hide();
                answerBox4.Hide();
            }
            else if(answerNum == 1)
            {
                answerRB1.Show();
                answerRB2.Hide();
                answerRB3.Hide();
                answerRB4.Hide();
                answerBox1.Show();
                answerBox2.Hide();
                answerBox3.Hide();
                answerBox4.Hide();
            }
            else if(answerNum == 2)
            {
                answerRB1.Show();
                answerRB2.Show();
                answerRB3.Hide();
                answerRB4.Hide();
                answerBox1.Show();
                answerBox2.Show();
                answerBox3.Hide();
                answerBox4.Hide();
            }
            else if(answerNum == 3)
            {
                answerRB1.Show();
                answerRB2.Show();
                answerRB3.Show();
                answerRB4.Hide();
                answerBox1.Show();
                answerBox2.Show();
                answerBox3.Show();
                answerBox4.Hide();
            }
            else if(answerNum == 4)
            {
                answerRB1.Show();
                answerRB2.Show();
                answerRB3.Show();
                answerRB4.Show();
                answerBox1.Show();
                answerBox2.Show();
                answerBox3.Show();
                answerBox4.Show();
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (answerNum == 1 && answerRB1.Checked)
                correctAns = 1;
            else if (answerNum == 2 && answerRB2.Checked)
                correctAns = 2;
            else if (answerNum == 3 && answerRB3.Checked)
                correctAns = 3;
            else if (answerNum == 4 && answerRB4.Checked)
                correctAns = 4;
            else
                correctAns = 0;
            buttonDone.Show();
        }
    }
}
