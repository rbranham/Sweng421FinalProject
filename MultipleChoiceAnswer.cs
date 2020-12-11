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
        public MultipleChoiceAnswer()
        {
            InitializeComponent();
            
            submitButton.Hide();
        }

        private void checkAnswer(object sender, EventArgs e)
        {

        }
    }
}
