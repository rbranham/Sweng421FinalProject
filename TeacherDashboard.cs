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
        public String questionType;
        public TeacherDashboard()
        {
            InitializeComponent();
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
            selectButton.Show();
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
            //add factory here 
            //for now we only have multiple choice
            if (questionType == "Multiple Choice")
            {
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
    }
}
