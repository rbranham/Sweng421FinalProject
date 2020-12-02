namespace Sweng421FinalProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeacherButton = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeacherButton
            // 
            this.TeacherButton.Location = new System.Drawing.Point(33, 33);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(75, 23);
            this.TeacherButton.TabIndex = 0;
            this.TeacherButton.Text = "Teacher";
            this.TeacherButton.UseVisualStyleBackColor = true;
            this.TeacherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(33, 79);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(75, 23);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 150);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.TeacherButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TeacherButton;
        private System.Windows.Forms.Button Student;
    }
}

