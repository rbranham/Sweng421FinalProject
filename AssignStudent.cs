using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class AssignStudent : Form
    {
        String studentID = "";
        public AssignStudent(String quizName)
        {
            InitializeComponent();
            submitButton.Hide();
            textBox2.Text = quizName;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.studentID = textBox1.Text;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            submitButton.Show();
        }
    }
}
