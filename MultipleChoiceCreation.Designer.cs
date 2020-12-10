namespace Sweng421FinalProject
{
    partial class MultipleChoiceCreation
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.answerRB1 = new System.Windows.Forms.RadioButton();
            this.answerRB2 = new System.Windows.Forms.RadioButton();
            this.answerRB3 = new System.Windows.Forms.RadioButton();
            this.answerRB4 = new System.Windows.Forms.RadioButton();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.answerBox2 = new System.Windows.Forms.TextBox();
            this.answerBox3 = new System.Windows.Forms.TextBox();
            this.answerBox4 = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(33, 21);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(61, 15);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question: ";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(149, 21);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(268, 23);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(701, 403);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Save";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // answerRB1
            // 
            this.answerRB1.AutoSize = true;
            this.answerRB1.Location = new System.Drawing.Point(32, 74);
            this.answerRB1.Name = "answerRB1";
            this.answerRB1.Size = new System.Drawing.Size(76, 19);
            this.answerRB1.TabIndex = 3;
            this.answerRB1.TabStop = true;
            this.answerRB1.Text = "Answer 1:";
            this.answerRB1.UseVisualStyleBackColor = true;
            // 
            // answerRB2
            // 
            this.answerRB2.AutoSize = true;
            this.answerRB2.Location = new System.Drawing.Point(32, 124);
            this.answerRB2.Name = "answerRB2";
            this.answerRB2.Size = new System.Drawing.Size(76, 19);
            this.answerRB2.TabIndex = 4;
            this.answerRB2.TabStop = true;
            this.answerRB2.Text = "Answer 2:";
            this.answerRB2.UseVisualStyleBackColor = true;
            // 
            // answerRB3
            // 
            this.answerRB3.AutoSize = true;
            this.answerRB3.Location = new System.Drawing.Point(32, 175);
            this.answerRB3.Name = "answerRB3";
            this.answerRB3.Size = new System.Drawing.Size(76, 19);
            this.answerRB3.TabIndex = 5;
            this.answerRB3.TabStop = true;
            this.answerRB3.Text = "Answer 3:";
            this.answerRB3.UseVisualStyleBackColor = true;
            // 
            // answerRB4
            // 
            this.answerRB4.AutoSize = true;
            this.answerRB4.Location = new System.Drawing.Point(32, 231);
            this.answerRB4.Name = "answerRB4";
            this.answerRB4.Size = new System.Drawing.Size(76, 19);
            this.answerRB4.TabIndex = 6;
            this.answerRB4.TabStop = true;
            this.answerRB4.Text = "Answer 4:";
            this.answerRB4.UseVisualStyleBackColor = true;
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(120, 73);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(647, 23);
            this.answerBox1.TabIndex = 1;
            // 
            // answerBox2
            // 
            this.answerBox2.Location = new System.Drawing.Point(120, 123);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(647, 23);
            this.answerBox2.TabIndex = 1;
            // 
            // answerBox3
            // 
            this.answerBox3.Location = new System.Drawing.Point(120, 174);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(647, 23);
            this.answerBox3.TabIndex = 1;
            // 
            // answerBox4
            // 
            this.answerBox4.Location = new System.Drawing.Point(120, 230);
            this.answerBox4.Name = "answerBox4";
            this.answerBox4.Size = new System.Drawing.Size(647, 23);
            this.answerBox4.TabIndex = 1;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(620, 403);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // MultipleChoiceCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.answerBox4);
            this.Controls.Add(this.answerBox3);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.answerRB4);
            this.Controls.Add(this.answerRB3);
            this.Controls.Add(this.answerRB2);
            this.Controls.Add(this.answerRB1);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Name = "MultipleChoiceCreation";
            this.Text = "MultipleChoiceCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonDone;

        private System.Windows.Forms.RadioButton answerRB1;
        private System.Windows.Forms.RadioButton answerRB2;
        private System.Windows.Forms.RadioButton answerRB3;
        private System.Windows.Forms.RadioButton answerRB4;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.TextBox answerBox2;
        private System.Windows.Forms.TextBox answerBox3;
        private System.Windows.Forms.TextBox answerBox4;
        private System.Windows.Forms.Button applyButton;
    }
}