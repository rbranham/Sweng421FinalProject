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
    public partial class CompositeCreation : Form
    {

         public List<QuestionIF> subQuestions;

        public CompositeCreation()
        {
            InitializeComponent();
            subQuestions = new List<QuestionIF>(); //Init
        }

        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
            //this.Close();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get list item of question type. 
            //Run factory to create question
            //run questions create function to fill out question

            openDashboard(new MultipleChoiceCreation());
            //Add created questtion to subquesiotns
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            //Add created questtion to subquesiotns
        }

    }

