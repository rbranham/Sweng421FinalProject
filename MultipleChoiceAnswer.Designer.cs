namespace Sweng421FinalProject
{
    partial class MultipleChoiceAnswer
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
            this.answer1Button = new System.Windows.Forms.Button();
            this.answer2Button = new System.Windows.Forms.Button();
            this.answer4Button = new System.Windows.Forms.Button();
            this.answer3Button = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer1Button
            // 
            this.answer1Button.Location = new System.Drawing.Point(12, 105);
            this.answer1Button.Name = "answer1Button";
            this.answer1Button.Size = new System.Drawing.Size(240, 40);
            this.answer1Button.TabIndex = 0;
            this.answer1Button.Tag = "1";
            this.answer1Button.Text = "Answer1";
            this.answer1Button.UseVisualStyleBackColor = true;
            this.answer1Button.Click += new System.EventHandler(this.checkAnswer);
            // 
            // answer2Button
            // 
            this.answer2Button.Location = new System.Drawing.Point(258, 105);
            this.answer2Button.Name = "answer2Button";
            this.answer2Button.Size = new System.Drawing.Size(240, 40);
            this.answer2Button.TabIndex = 1;
            this.answer2Button.Tag = "2";
            this.answer2Button.Text = "Answer2";
            this.answer2Button.UseVisualStyleBackColor = true;
            this.answer2Button.Click += new System.EventHandler(this.checkAnswer);
            // 
            // answer4Button
            // 
            this.answer4Button.Location = new System.Drawing.Point(258, 151);
            this.answer4Button.Name = "answer4Button";
            this.answer4Button.Size = new System.Drawing.Size(240, 40);
            this.answer4Button.TabIndex = 2;
            this.answer4Button.Tag = "4";
            this.answer4Button.Text = "Answer4";
            this.answer4Button.UseVisualStyleBackColor = true;
            this.answer4Button.Click += new System.EventHandler(this.checkAnswer);
            // 
            // answer3Button
            // 
            this.answer3Button.Location = new System.Drawing.Point(12, 151);
            this.answer3Button.Name = "answer3Button";
            this.answer3Button.Size = new System.Drawing.Size(240, 40);
            this.answer3Button.TabIndex = 3;
            this.answer3Button.Tag = "3";
            this.answer3Button.Text = "Answer3";
            this.answer3Button.UseVisualStyleBackColor = true;
            this.answer3Button.Click += new System.EventHandler(this.checkAnswer);
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(12, 76);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(486, 23);
            this.questionText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question:";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(13, 246);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 6;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(362, 246);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(443, 246);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // MultipleChoiceAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 281);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.answer3Button);
            this.Controls.Add(this.answer4Button);
            this.Controls.Add(this.answer2Button);
            this.Controls.Add(this.answer1Button);
            this.Name = "MultipleChoiceAnswer";
            this.Text = "MultipleChoiceAnswer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer1Button;
        private System.Windows.Forms.Button answer2Button;
        private System.Windows.Forms.Button answer4Button;
        private System.Windows.Forms.Button answer3Button;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button submitButton;
    }
}