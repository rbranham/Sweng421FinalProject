using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class StudentDashboard : Form
    {
        List<QuestionIF> questions = new List<QuestionIF>();
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            
            

        }

    }
}
