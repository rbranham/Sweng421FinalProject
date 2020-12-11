namespace Sweng421FinalProject
{
    partial class CompositeCreation
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
            this.labelQuestions = new System.Windows.Forms.Label();
            this.labelQuestionTypes = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewQuestions = new System.Windows.Forms.ListView();
            this.listViewQuestionsTypes = new System.Windows.Forms.ListView();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Location = new System.Drawing.Point(106, 53);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(60, 15);
            this.labelQuestions.TabIndex = 0;
            this.labelQuestions.Text = "Questions";
            // 
            // labelQuestionTypes
            // 
            this.labelQuestionTypes.AutoSize = true;
            this.labelQuestionTypes.Location = new System.Drawing.Point(542, 53);
            this.labelQuestionTypes.Name = "labelQuestionTypes";
            this.labelQuestionTypes.Size = new System.Drawing.Size(87, 15);
            this.labelQuestionTypes.TabIndex = 0;
            this.labelQuestionTypes.Text = "Question Types";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(579, 363);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewQuestions
            // 
            this.listViewQuestions.HideSelection = false;
            this.listViewQuestions.Location = new System.Drawing.Point(88, 106);
            this.listViewQuestions.Name = "listViewQuestions";
            this.listViewQuestions.Size = new System.Drawing.Size(262, 174);
            this.listViewQuestions.TabIndex = 2;
            this.listViewQuestions.UseCompatibleStateImageBehavior = false;
            this.listViewQuestions.View = System.Windows.Forms.View.List;
            // 
            // listViewQuestionsTypes
            // 
            this.listViewQuestionsTypes.HideSelection = false;
            this.listViewQuestionsTypes.Location = new System.Drawing.Point(469, 106);
            this.listViewQuestionsTypes.Name = "listViewQuestionsTypes";
            this.listViewQuestionsTypes.Size = new System.Drawing.Size(185, 174);
            this.listViewQuestionsTypes.TabIndex = 3;
            this.listViewQuestionsTypes.UseCompatibleStateImageBehavior = false;
            this.listViewQuestionsTypes.View = System.Windows.Forms.View.List;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(708, 415);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CompositeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.listViewQuestionsTypes);
            this.Controls.Add(this.listViewQuestions);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelQuestionTypes);
            this.Controls.Add(this.labelQuestions);
            this.Name = "CompositeCreation";
            this.Text = "Composite";
            this.Load += new System.EventHandler(this.CompositeCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestions;
        private System.Windows.Forms.Label labelQuestionTypes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewQuestions;
        private System.Windows.Forms.ListView listViewQuestionsTypes;

        private System.Windows.Forms.Button doneButton;

    }
}