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
        public List<QuestionIF> quizzes; 
        public QuestionIF qif;
        public String studentID;
        public TeacherDashboard()
        {
            InitializeComponent();
            quizzes = new List<QuestionIF>();//init
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
            qif = new Quiz();
            qif.createQuiz();
            //setQuizList();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void assignButton_Click(object sender, EventArgs e)
        {
            //String quiz = listView1.SelectedItems[0].Text;
            openDashboard(new AssignStudent()); //temporary until i can figure out better implementation
        }

        private async void setQuizList()
        {
            DBhandler dbConnection = new DBhandler();
            List<String> qTests = await dbConnection.getQuiz();

            foreach (String t in qTests)
            {
                listView1.Items.Add(t); //Add quizzes into list
            }

            //Can sort here if needed
        }
    }
}
