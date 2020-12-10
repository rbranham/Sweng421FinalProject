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
        public String question;

        private int answerNum = 0;




        public MultipleChoiceCreation()
        {
            InitializeComponent();

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
        }


        private void numAnswers_ValueChanged(object sender, EventArgs e)
        {
            answerNum = Convert.ToInt32(numAnswers.Value);
            if(answerNum == 0)
            {

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

    }
}
