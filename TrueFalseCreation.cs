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
    public partial class TrueFalseCreation : Form
    {

        public List<QuestionIF> subQuestions;
        private questionsFactory qFactory; 

        public TrueFalseCreation()
        {
            InitializeComponent();
            subQuestions = new List<QuestionIF>(); //Init
            qFactory = new questionsFactory(); //Init
        }

        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //String typeString = listViewQuestionsTypes.SelectedItems[0].Text; //Get string of selected question type. 
            //QuestionIF nextQuestion = qFactory.createQuestion(typeString); //Run factory to create question
            //nextQuestion.createQuiz(); //run questions create function to fill out questions values
            //subQuestions.Add(nextQuestion); //Add created question to subquestions
            refreshQuestionList(); //Call refresh
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompositeCreation_Load(object sender, EventArgs e)
        {
            setTypeList();
            
        }

        /*
         * Function to refresh question list
         */
        private void refreshQuestionList()
        {
           // listViewQuestions.Clear(); 

            int i = 0; 
            foreach(QuestionIF q in subQuestions)
            {
                i++; 
            //    listViewQuestions.Items.Add(i + ". " + q.getName());
            }

        }

        /*
         * Function to refresh question type lsit
         */
        private async void setTypeList()
        {
            DBhandler dbConnection = new DBhandler();
            List<String> qTypes = await dbConnection.getQuestionTypes();

            foreach (String t in qTypes)
            {
             //   listViewQuestionsTypes.Items.Add(t); //Add types into list
            }

            //Can sort here if needed
        }
    }
}

