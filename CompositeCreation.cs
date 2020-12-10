using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sweng421FinalProject;
using static Sweng421FinalProject.Program;

namespace Sweng421FinalProject
{
    public partial class CompositeCreation : Form
    {

         public List<QuestionIF> subQuestions;

        public CompositeCreation()
        {
            InitializeComponent();
            subQuestions = new List<QuestionIF>(); //Init
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get list item of question type. 
            //Run factory to create question
            //run questions create function to fill out question
            //Add created questtion to subquesiotns
        }
    }
}
