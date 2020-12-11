namespace Sweng421FinalProject
{
    partial class StudentDashboard
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
            this.doneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listQuestionsToAnswer = new System.Windows.Forms.ListView();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardLabel.Location = new System.Drawing.Point(266, 9);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(194, 28);
            this.DashboardLabel.TabIndex = 0;
            this.DashboardLabel.Text = "Student Dashboard";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(184, 391);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Logout";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Questions to Answer:";
            // 
            // listQuestionsToAnswer
            // 
            this.listQuestionsToAnswer.HideSelection = false;
            this.listQuestionsToAnswer.Location = new System.Drawing.Point(32, 77);
            this.listQuestionsToAnswer.Name = "listQuestionsToAnswer";
            this.listQuestionsToAnswer.Size = new System.Drawing.Size(145, 337);
            this.listQuestionsToAnswer.TabIndex = 3;
            this.listQuestionsToAnswer.UseCompatibleStateImageBehavior = false;
            this.listQuestionsToAnswer.View = System.Windows.Forms.View.List;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(184, 77);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 428);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.listQuestionsToAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.DashboardLabel);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listQuestionsToAnswer;
        private System.Windows.Forms.Button startButton;
    }
}