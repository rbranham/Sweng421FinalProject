using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class TeacherDashboard : Form
    {
        //public List<QuestionIF> quizzes;
        public Quiz quiz;
        public QuestionIF qif;
        public String questionType;
        public String quizName;
        public MultipleChoiceQuestion mc;
        DBhandler dbConnection = new DBhandler();
        public TeacherDashboard()
        {
            InitializeComponent();
            addButton.Hide();
            doneButton.Hide();
            label4.Hide();
            textBox1.Hide();
            selectButton.Hide();
            quizCreation1.Hide();
            mc1.Hide();
            tf1.Hide();
            //quizzes = new List<QuestionIF>();//init
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {

        }
        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
        }

        private void createClick(object sender, EventArgs e)
        {
            quizCreation1.Show();
            label4.Show();
            textBox1.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void assignButton_Click(object sender, EventArgs e)
        {
            openDashboard(new AssignStudent()); //open new AssignStudent dashboard
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            quiz = new Quiz();
            addButton.Show();
            questionType = quizCreation1.selectedType;

            //add factory here for below to create question type and instantiate for use 
            if (questionType == "Multiple Choice")
            {
                mc = new MultipleChoiceQuestion();
                tf1.Hide();
                mc1.Show();
            }
            else if (questionType == "Composite")
            {
                mc1.Hide();
                tf1.Show();
            }
            //depending on the return of the factory, will depend on the view to show. right now only MC
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectButton.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //get information from Multiple Choice View
            quizName = textBox1.Text;
            mc.questionText = mc1.addQuestion;
            mc.answers[0] = mc1.addAnswer1;
            mc.answers[1] = mc1.addAnswer2;
            mc.answers[2] = mc1.addAnswer3;
            mc.answers[3] = mc1.addAnswer4;
            mc.correctAnswer = mc1.addCorrectAnswer;
            quiz.name = quizName;

            //add question to Quiz list
            quiz.subQuestions.Add(mc);

            //once added, clear the question text boxes
            mc1.addQuestion = null;
            mc1.addAnswer1 = null;
            mc1.addAnswer2 = null;
            mc1.addAnswer3 = null;
            mc1.addAnswer4 = null;
            //show done button so user can stop adding questions
            doneButton.Show();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            /*
             *   When done button clicked, clear textboxes and get ready for next question
             */
            dbConnection.AddQuiz(quiz);
            addButton.Hide();
            mc1.addQuestion = null;
            mc1.addAnswer1 = null;
            mc1.addAnswer2 = null;
            mc1.addAnswer3 = null;
            mc1.addAnswer4 = null;
            mc1.Hide();
            tf1.Hide();
        }
    }
}
