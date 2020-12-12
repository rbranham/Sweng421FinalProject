using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class AssignQuiz : UserControl
    {
        public AssignQuiz()
        {
            InitializeComponent();
        }
        public String selectedType
        {
            get
            {
                return (String)comboBox1.SelectedItem;
            }
        }
        private async void AssignQuiz_Load(object sender, EventArgs e)
        {
            DBhandler dbConnection = new DBhandler();
            List<String> quizzes = await dbConnection.getAllQuizzes();

            foreach (String t in quizzes)
            {
                comboBox1.Items.Add(t); //Add types into list
            }
        }
    }
}
