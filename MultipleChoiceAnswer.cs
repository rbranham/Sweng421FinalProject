using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class MultipleChoiceAnswer : Form
    {
        List<QuestionIF> questions = new List<QuestionIF>();
        int questionNum = 0;
        String[] answers;
        int correctAns;
        public MultipleChoiceAnswer()
        {
            InitializeComponent();
            //answers = new string[4] --get answers from current question
            //correctAns = get index # of correct answer from array
            //start from the beginning of the question list with index of 0
            submitButton.Hide();
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            //check to see if answer selected is the correct answer
            //if correct, add to results
            //move to next question, regardless if it is correct or not.
        }
    }
}
