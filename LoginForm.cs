using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //private int id = 0;
        //private int resultt;
        //private int results;
        //private bool tvalidID = false;
        //private bool svalidID = false;
        List<Teacher> teachList;
        List<Student> studentList;
        DBhandler db; 
        public LoginForm()
        {
            InitializeComponent();

            db = new DBhandler(); //Get database connection

            //Call two async tasks to get in data
            //getAccountLists(databaseConnection);
            //getStudentLists(databaseConnection); 
            getAccountLists();
            getStudentLists(); 
        }

        private async void getAccountLists()
        {
            /*
            var teacherTask = db.getTeacherAccounts(); //start task
            teachList = await teacherTask; //Awaits return of task
            */
            teachList = await db.getTeacherAccounts();
            Debug.WriteLine("Got teachers list");
        }

        private async void getStudentLists()
        {
            /*
            var studentTask = db.getStudentAccounts(); //starts task
            studentList = await studentTask; //Awaits return of task
            */
            studentList = await db.getStudentAccounts();
            Debug.WriteLine("Got student list");
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
            String textTeacherBox = textBox1.Text;
            String textStudentBox = textBox2.Text;

            if (selection == "teacher")
            {

                Debug.WriteLine("Selection was teacher");
                Teacher t; 
                try {
                    t = teachList.First(Teacher => Teacher.getUserName() == textTeacherBox);
                    Debug.WriteLine("first teacher is: " + t.getName());
                } catch
                {
                    t = null; 
                    Debug.WriteLine("teacher was empty ");
                }


                if (t != null)
                {
                    Debug.WriteLine("Attempting to open teacher dashboard");
                    openDashboard(new TeacherDashboard());  //Open teacher dashboard form
                } else
                {
                    textBox1.Text = "Invalid ID, try again!";
                }
                
            }
            else if (selection == "student")
            {
                Student s;

                try
                {
                    s = studentList.First(Student => Student.getUserName() == textStudentBox);
                    Debug.WriteLine("first teacher is: " + s.getName());
                }
                catch { s = null; } //If can't find  set as null

                if (s != null)
                {
                    openDashboard(new StudentDashboard());  //Open student dashboard form
                }
                else
                {
                    textBox2.Text = "Invalid ID, try again!";
                }

                
            }
            else
            {
               
               textBox1.Text = "Please Select a account type";
               
            }

            //old
            /*
            resultt = teachList.IndexOf(text1);
            results = studentList.IndexOf(text2);

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
            */
        }
    }
}
