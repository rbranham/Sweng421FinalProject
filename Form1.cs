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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open teacher dashboard form
            openDashboard(new TeacherDashboard());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Open teacher dashboard form
            openDashboard(new StudentDashboard());
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


    }
}
