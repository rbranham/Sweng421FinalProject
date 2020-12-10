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


        public MultipleChoiceCreation()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            question = textBoxQuestion.Text; //Get Question text
        }
    }
}
