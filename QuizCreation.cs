using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class QuizCreation : UserControl
    {
        public QuizCreation()
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
        private async void QuizCreation_Load(object sender, EventArgs e)
        {
            //here is where you bind the details of the comboBox
            DBhandler dbConnection = new DBhandler();
            List<String> qTypes = await dbConnection.getQuestionTypes();

            foreach (String t in qTypes)
            {
                comboBox1.Items.Add(t); //Add types into list
            }
        }
    }
}
