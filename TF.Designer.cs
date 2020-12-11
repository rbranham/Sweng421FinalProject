namespace Sweng421FinalProject
{
    partial class TF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionBox1 = new System.Windows.Forms.TextBox();
            this.trueButton = new System.Windows.Forms.RadioButton();
            this.falseButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "True/False";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question: ";
            // 
            // questionBox1
            // 
            this.questionBox1.Location = new System.Drawing.Point(92, 128);
            this.questionBox1.Name = "questionBox1";
            this.questionBox1.Size = new System.Drawing.Size(232, 23);
            this.questionBox1.TabIndex = 1;
            // 
            // trueButton
            // 
            this.trueButton.AutoSize = true;
            this.trueButton.Location = new System.Drawing.Point(62, 191);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(47, 19);
            this.trueButton.TabIndex = 2;
            this.trueButton.TabStop = true;
            this.trueButton.Text = "True";
            this.trueButton.UseVisualStyleBackColor = true;
            // 
            // falseButton
            // 
            this.falseButton.AutoSize = true;
            this.falseButton.Location = new System.Drawing.Point(189, 191);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(51, 19);
            this.falseButton.TabIndex = 3;
            this.falseButton.TabStop = true;
            this.falseButton.Text = "False";
            this.falseButton.UseVisualStyleBackColor = true;
            // 
            // TF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.falseButton);
            this.Controls.Add(this.trueButton);
            this.Controls.Add(this.questionBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TF";
            this.Size = new System.Drawing.Size(335, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionBox1;
        private System.Windows.Forms.RadioButton trueButton;
        private System.Windows.Forms.RadioButton falseButton;
    }
}
