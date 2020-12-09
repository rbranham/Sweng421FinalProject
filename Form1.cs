using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class LoginForm : Form
    {
        private String selection = "";
        private String text1 = "";
        private String text2 = "";
        private int id = 0;
        private int resultt;
        private int results;
        private bool tvalidID = false;
        private bool svalidID = false;
        List<String> teachID = new List<String> { "12345", "23456", "34567", "45678", "56789", "67890" };
        List<String> studentID = new List<String> { "9876", "8765", "7654", "6543", "5432", "4321" };
        public LoginForm()
        {
            InitializeComponent();
        }

        private void openDashboard(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.ShowDialog();
            this.Close(); //Doesn't close until after dashboard... somewhat waste of resources
            // Link to look into: https://social.msdn.microsoft.com/Forums/en-US/0333e0c3-1a86-4cf6-822e-9ec23dc766e6/how-to-switch-between-c-winform?forum=winforms
        }

        private void student_Click(object sender, EventArgs e)
        {
            selection = "student";
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            selection = "teacher";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox2.Text;
            resultt = teachID.IndexOf(text1);
            results = studentID.IndexOf(text2);
            if (resultt >= 0)
                tvalidID = true;
            if (results >= 0)
                svalidID = true;
            if ((selection == "teacher") && tvalidID)
            {
                openDashboard(new TeacherDashboard());  //Open teacher dashboard form
            }
            else if ((selection == "student") && svalidID)
            {
                openDashboard(new StudentDashboard());  //Open student dashboard form
            }
            else
            {
                if (selection == "teacher") 
                    textBox1.Text = "Invalid ID, try again!";
                if (selection == "student")
                    textBox2.Text = "Invalid ID, try again!";
            }
        }
    }
}
