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
        public Quiz quiz;
        public String questionType;
        public String quizName;
        public MultipleChoiceQuestion mc;
        DBhandler dbConnection = new DBhandler();
        private questionsFactory qFactory;
        public TeacherDashboard()
        {
            InitializeComponent();
            qFactory = new questionsFactory();
            doneButton.Hide();
            label4.Hide();
            textBox1.Hide();
            selectButton.Hide();
            quizCreation1.Hide();

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
            selectButton.Show();
            quizCreation1.Show();
            label4.Show();
            textBox1.Show();
            quiz = new Quiz();
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
            questionType = quizCreation1.selectedType;
            QuestionIF nextQuestion = qFactory.createQuestion(questionType); //Run factory to create question
            nextQuestion.createQuiz();
            quiz.name = textBox1.Text;
            quiz.subQuestions.Add(nextQuestion);
            doneButton.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectButton.Show();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            dbConnection.AddQuiz(quiz);
        }
    }
}
