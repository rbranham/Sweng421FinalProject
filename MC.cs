using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    public partial class MC : UserControl
    {
        public String[] answer;
        public String correctAns;
        public MC()
        {
            InitializeComponent();
        }
        public String addQuestion
        {
            get
            {
                return (String)textBox1.Text;
            }
            set
            {
                textBox1.Text = null;
            }
        }
        public String addAnswer1
        {
            get
            {
                return (String)textBox2.Text;
            }
            set
            {
                textBox2.Text = null;
            }
        }
        public String addAnswer2
        {
            get
            {
                return (String)textBox3.Text;
            }
            set
            {
                textBox3.Text = null;
            }
        }
        public String addAnswer3
        {
            get
            {
                return (String)textBox4.Text;
            }
            set
            {
                textBox4.Text = null;
            }
        }
        public String addAnswer4
        {
            get
            {
                return (String)textBox5.Text;
            }
            set
            {
                textBox5.Text = null;
            }
        }
        public String addCorrectAnswer
        {
            get
            {
                if (radioButton1.Checked)
                    return (String)textBox2.Text;
                else if (radioButton2.Checked)
                    return (String)textBox3.Text;
                else if (radioButton3.Checked)
                    return (String)textBox4.Text;
                else if (radioButton4.Checked)
                    return (String)textBox5.Text;
                else
                    return "";
            }
        }
    }
}
