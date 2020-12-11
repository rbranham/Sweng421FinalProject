namespace Sweng421FinalProject
{
    partial class TeacherDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mc1 = new Sweng421FinalProject.MC();
            this.quizCreation1 = new Sweng421FinalProject.QuizCreation();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardLabel.Location = new System.Drawing.Point(7, 9);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(193, 28);
            this.DashboardLabel.TabIndex = 0;
            this.DashboardLabel.Text = "Teacher Dashboard";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 81);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(170, 77);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create a Quiz";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createClick);
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(12, 235);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(170, 77);
            this.assignButton.TabIndex = 6;
            this.assignButton.Text = "Assign Quiz to Student";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(56, 468);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "What would you like to do?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Create";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Assign";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.assignButton);
            this.panel1.Controls.Add(this.DashboardLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 503);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Controls.Add(this.mc1);
            this.panel2.Controls.Add(this.quizCreation1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(208, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 503);
            this.panel2.TabIndex = 15;
            // 
            // mc1
            // 
            this.mc1.Location = new System.Drawing.Point(183, 9);
            this.mc1.Name = "mc1";
            this.mc1.Size = new System.Drawing.Size(334, 491);
            this.mc1.TabIndex = 1;
            // 
            // quizCreation1
            // 
            this.quizCreation1.Location = new System.Drawing.Point(0, 9);
            this.quizCreation1.Name = "quizCreation1";
            this.quizCreation1.Size = new System.Drawing.Size(177, 149);
            this.quizCreation1.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(6, 164);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(171, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select Type";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherDashboard";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private QuizCreation quizCreation1;
        private MC mc1;
        private System.Windows.Forms.Button selectButton;
    }
}