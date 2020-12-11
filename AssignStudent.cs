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
        public AssignStudent()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            studentID = textBox1.Text;
            this.Close();
        }
    }
}
