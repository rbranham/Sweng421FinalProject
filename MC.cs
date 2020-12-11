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
        }
        public String addAnswer1
        {
            get
            {
                return (String)textBox2.Text;
            }
        }
        public String addAnswer2
        {
            get
            {
                return (String)textBox3.Text;
            }
        }
        public String addAnswer3
        {
            get
            {
                return (String)textBox4.Text;
            }
        }
        public String addAnswer4
        {
            get
            {
                return (String)textBox5.Text;
            }
        }
    }
}
