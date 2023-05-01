namespace KhumbulaMultipleChoiceBuilder
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadQuestions = new System.Windows.Forms.Button();
            this.lblQuestionsPath = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbxQuestions = new System.Windows.Forms.ListBox();
            this.gbxAnswerA = new System.Windows.Forms.GroupBox();
            this.btnSetAnswerA = new System.Windows.Forms.Button();
            this.tbxQuestionA = new System.Windows.Forms.TextBox();
            this.gbxAnswerB = new System.Windows.Forms.GroupBox();
            this.btnSetAnswerB = new System.Windows.Forms.Button();
            this.tbxQuestionB = new System.Windows.Forms.TextBox();
            this.gbxAnswerC = new System.Windows.Forms.GroupBox();
            this.btnSetAnswerC = new System.Windows.Forms.Button();
            this.tbxQuestionC = new System.Windows.Forms.TextBox();
            this.gbxAnswerD = new System.Windows.Forms.GroupBox();
            this.btnSetAnswerD = new System.Windows.Forms.Button();
            this.tbxQuestionD = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxAnswerA.SuspendLayout();
            this.gbxAnswerB.SuspendLayout();
            this.gbxAnswerC.SuspendLayout();
            this.gbxAnswerD.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadQuestions);
            this.groupBox1.Controls.Add(this.lblQuestionsPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // btnLoadQuestions
            // 
            this.btnLoadQuestions.Location = new System.Drawing.Point(168, 15);
            this.btnLoadQuestions.Name = "btnLoadQuestions";
            this.btnLoadQuestions.Size = new System.Drawing.Size(80, 23);
            this.btnLoadQuestions.TabIndex = 1;
            this.btnLoadQuestions.Text = "Load (.txt)";
            this.btnLoadQuestions.UseVisualStyleBackColor = true;
            this.btnLoadQuestions.Click += new System.EventHandler(this.btnLoadQuestions_Click);
            // 
            // lblQuestionsPath
            // 
            this.lblQuestionsPath.AutoEllipsis = true;
            this.lblQuestionsPath.Location = new System.Drawing.Point(6, 15);
            this.lblQuestionsPath.Name = "lblQuestionsPath";
            this.lblQuestionsPath.Size = new System.Drawing.Size(156, 23);
            this.lblQuestionsPath.TabIndex = 0;
            this.lblQuestionsPath.Text = "...";
            this.lblQuestionsPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveQuestion);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Location = new System.Drawing.Point(272, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(6, 15);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(88, 23);
            this.btnSaveQuestion.TabIndex = 2;
            this.btnSaveQuestion.Text = "Save (.txt)";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(100, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export (.json)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbxQuestions);
            this.groupBox4.Location = new System.Drawing.Point(12, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 530);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // lbxQuestions
            // 
            this.lbxQuestions.FormattingEnabled = true;
            this.lbxQuestions.ItemHeight = 15;
            this.lbxQuestions.Location = new System.Drawing.Point(6, 22);
            this.lbxQuestions.Name = "lbxQuestions";
            this.lbxQuestions.Size = new System.Drawing.Size(242, 499);
            this.lbxQuestions.TabIndex = 2;
            this.lbxQuestions.SelectedIndexChanged += new System.EventHandler(this.lbxQuestions_SelectedIndexChanged);
            // 
            // gbxAnswerA
            // 
            this.gbxAnswerA.Controls.Add(this.btnSetAnswerA);
            this.gbxAnswerA.Controls.Add(this.tbxQuestionA);
            this.gbxAnswerA.Location = new System.Drawing.Point(272, 178);
            this.gbxAnswerA.Name = "gbxAnswerA";
            this.gbxAnswerA.Size = new System.Drawing.Size(510, 100);
            this.gbxAnswerA.TabIndex = 5;
            this.gbxAnswerA.TabStop = false;
            this.gbxAnswerA.Text = "A";
            // 
            // btnSetAnswerA
            // 
            this.btnSetAnswerA.Location = new System.Drawing.Point(6, 21);
            this.btnSetAnswerA.Name = "btnSetAnswerA";
            this.btnSetAnswerA.Size = new System.Drawing.Size(15, 73);
            this.btnSetAnswerA.TabIndex = 1;
            this.btnSetAnswerA.UseVisualStyleBackColor = true;
            this.btnSetAnswerA.Click += new System.EventHandler(this.btnSetAnswerA_Click);
            // 
            // tbxQuestionA
            // 
            this.tbxQuestionA.Location = new System.Drawing.Point(27, 22);
            this.tbxQuestionA.Multiline = true;
            this.tbxQuestionA.Name = "tbxQuestionA";
            this.tbxQuestionA.Size = new System.Drawing.Size(477, 72);
            this.tbxQuestionA.TabIndex = 0;
            this.tbxQuestionA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxQuestion_KeyUp);
            // 
            // gbxAnswerB
            // 
            this.gbxAnswerB.Controls.Add(this.btnSetAnswerB);
            this.gbxAnswerB.Controls.Add(this.tbxQuestionB);
            this.gbxAnswerB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxAnswerB.Location = new System.Drawing.Point(272, 284);
            this.gbxAnswerB.Name = "gbxAnswerB";
            this.gbxAnswerB.Size = new System.Drawing.Size(510, 100);
            this.gbxAnswerB.TabIndex = 6;
            this.gbxAnswerB.TabStop = false;
            this.gbxAnswerB.Text = "B";
            // 
            // btnSetAnswerB
            // 
            this.btnSetAnswerB.Location = new System.Drawing.Point(6, 21);
            this.btnSetAnswerB.Name = "btnSetAnswerB";
            this.btnSetAnswerB.Size = new System.Drawing.Size(15, 73);
            this.btnSetAnswerB.TabIndex = 2;
            this.btnSetAnswerB.UseVisualStyleBackColor = true;
            this.btnSetAnswerB.Click += new System.EventHandler(this.btnSetAnswerB_Click);
            // 
            // tbxQuestionB
            // 
            this.tbxQuestionB.Location = new System.Drawing.Point(27, 22);
            this.tbxQuestionB.Multiline = true;
            this.tbxQuestionB.Name = "tbxQuestionB";
            this.tbxQuestionB.Size = new System.Drawing.Size(477, 72);
            this.tbxQuestionB.TabIndex = 0;
            this.tbxQuestionB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxQuestion_KeyUp);
            // 
            // gbxAnswerC
            // 
            this.gbxAnswerC.Controls.Add(this.btnSetAnswerC);
            this.gbxAnswerC.Controls.Add(this.tbxQuestionC);
            this.gbxAnswerC.Location = new System.Drawing.Point(272, 390);
            this.gbxAnswerC.Name = "gbxAnswerC";
            this.gbxAnswerC.Size = new System.Drawing.Size(510, 100);
            this.gbxAnswerC.TabIndex = 6;
            this.gbxAnswerC.TabStop = false;
            this.gbxAnswerC.Text = "C";
            // 
            // btnSetAnswerC
            // 
            this.btnSetAnswerC.Location = new System.Drawing.Point(6, 22);
            this.btnSetAnswerC.Name = "btnSetAnswerC";
            this.btnSetAnswerC.Size = new System.Drawing.Size(15, 73);
            this.btnSetAnswerC.TabIndex = 2;
            this.btnSetAnswerC.UseVisualStyleBackColor = true;
            this.btnSetAnswerC.Click += new System.EventHandler(this.btnSetAnswerC_Click);
            // 
            // tbxQuestionC
            // 
            this.tbxQuestionC.Location = new System.Drawing.Point(27, 22);
            this.tbxQuestionC.Multiline = true;
            this.tbxQuestionC.Name = "tbxQuestionC";
            this.tbxQuestionC.Size = new System.Drawing.Size(477, 72);
            this.tbxQuestionC.TabIndex = 0;
            this.tbxQuestionC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxQuestion_KeyUp);
            // 
            // gbxAnswerD
            // 
            this.gbxAnswerD.Controls.Add(this.btnSetAnswerD);
            this.gbxAnswerD.Controls.Add(this.tbxQuestionD);
            this.gbxAnswerD.Location = new System.Drawing.Point(272, 496);
            this.gbxAnswerD.Name = "gbxAnswerD";
            this.gbxAnswerD.Size = new System.Drawing.Size(510, 100);
            this.gbxAnswerD.TabIndex = 7;
            this.gbxAnswerD.TabStop = false;
            this.gbxAnswerD.Text = "D";
            // 
            // btnSetAnswerD
            // 
            this.btnSetAnswerD.Location = new System.Drawing.Point(6, 22);
            this.btnSetAnswerD.Name = "btnSetAnswerD";
            this.btnSetAnswerD.Size = new System.Drawing.Size(15, 73);
            this.btnSetAnswerD.TabIndex = 2;
            this.btnSetAnswerD.UseVisualStyleBackColor = true;
            this.btnSetAnswerD.Click += new System.EventHandler(this.btnSetAnswerD_Click);
            // 
            // tbxQuestionD
            // 
            this.tbxQuestionD.Location = new System.Drawing.Point(27, 22);
            this.tbxQuestionD.Multiline = true;
            this.tbxQuestionD.Name = "tbxQuestionD";
            this.tbxQuestionD.Size = new System.Drawing.Size(477, 72);
            this.tbxQuestionD.TabIndex = 0;
            this.tbxQuestionD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxQuestion_KeyUp);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbxQuestion);
            this.groupBox8.Location = new System.Drawing.Point(272, 72);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(510, 100);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Question";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(6, 22);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(498, 72);
            this.tbxQuestion.TabIndex = 0;
            this.tbxQuestion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxQuestion_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 604);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.gbxAnswerD);
            this.Controls.Add(this.gbxAnswerC);
            this.Controls.Add(this.gbxAnswerB);
            this.Controls.Add(this.gbxAnswerA);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Khumbula Multiple Choice Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbxAnswerA.ResumeLayout(false);
            this.gbxAnswerA.PerformLayout();
            this.gbxAnswerB.ResumeLayout(false);
            this.gbxAnswerB.PerformLayout();
            this.gbxAnswerC.ResumeLayout(false);
            this.gbxAnswerC.PerformLayout();
            this.gbxAnswerD.ResumeLayout(false);
            this.gbxAnswerD.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLoadQuestions;
        private Label lblQuestionsPath;
        private GroupBox groupBox3;
        private Button btnSaveQuestion;
        private Button btnExport;
        private GroupBox groupBox4;
        private ListBox lbxQuestions;
        private GroupBox gbxAnswerA;
        private TextBox tbxQuestionA;
        private GroupBox gbxAnswerB;
        private TextBox tbxQuestionB;
        private GroupBox gbxAnswerC;
        private TextBox tbxQuestionC;
        private GroupBox gbxAnswerD;
        private TextBox tbxQuestionD;
        private GroupBox groupBox8;
        private TextBox tbxQuestion;
        private Button btnSetAnswerA;
        private Button btnSetAnswerB;
        private Button btnSetAnswerC;
        private Button btnSetAnswerD;
    }
}