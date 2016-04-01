namespace QuizNightScorer
{
    partial class Form1
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
            this.displayScoresBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adultsRbtn = new System.Windows.Forms.RadioButton();
            this.kidsRbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correctTxtBox = new System.Windows.Forms.TextBox();
            this.incorrectTxtBox = new System.Windows.Forms.TextBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayScoresBtn
            // 
            this.displayScoresBtn.Location = new System.Drawing.Point(23, 12);
            this.displayScoresBtn.Name = "displayScoresBtn";
            this.displayScoresBtn.Size = new System.Drawing.Size(99, 43);
            this.displayScoresBtn.TabIndex = 0;
            this.displayScoresBtn.Text = "Display Scores";
            this.displayScoresBtn.UseVisualStyleBackColor = true;
            this.displayScoresBtn.Click += new System.EventHandler(this.displayScoresBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kidsRbtn);
            this.groupBox1.Controls.Add(this.adultsRbtn);
            this.groupBox1.Location = new System.Drawing.Point(36, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // adultsRbtn
            // 
            this.adultsRbtn.AutoSize = true;
            this.adultsRbtn.Location = new System.Drawing.Point(7, 34);
            this.adultsRbtn.Name = "adultsRbtn";
            this.adultsRbtn.Size = new System.Drawing.Size(68, 21);
            this.adultsRbtn.TabIndex = 0;
            this.adultsRbtn.TabStop = true;
            this.adultsRbtn.Text = "Adults";
            this.adultsRbtn.UseVisualStyleBackColor = true;
            // 
            // kidsRbtn
            // 
            this.kidsRbtn.AutoSize = true;
            this.kidsRbtn.Location = new System.Drawing.Point(6, 73);
            this.kidsRbtn.Name = "kidsRbtn";
            this.kidsRbtn.Size = new System.Drawing.Size(81, 21);
            this.kidsRbtn.TabIndex = 1;
            this.kidsRbtn.TabStop = true;
            this.kidsRbtn.Text = "Children";
            this.kidsRbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incorrect:";
            // 
            // correctTxtBox
            // 
            this.correctTxtBox.Location = new System.Drawing.Point(315, 113);
            this.correctTxtBox.Name = "correctTxtBox";
            this.correctTxtBox.Size = new System.Drawing.Size(100, 22);
            this.correctTxtBox.TabIndex = 4;
            // 
            // incorrectTxtBox
            // 
            this.incorrectTxtBox.Location = new System.Drawing.Point(315, 161);
            this.incorrectTxtBox.Name = "incorrectTxtBox";
            this.incorrectTxtBox.Size = new System.Drawing.Size(100, 22);
            this.incorrectTxtBox.TabIndex = 5;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(315, 236);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(49, 17);
            this.scoreLbl.TabIndex = 6;
            this.scoreLbl.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 294);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.incorrectTxtBox);
            this.Controls.Add(this.correctTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayScoresBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayScoresBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kidsRbtn;
        private System.Windows.Forms.RadioButton adultsRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correctTxtBox;
        private System.Windows.Forms.TextBox incorrectTxtBox;
        private System.Windows.Forms.Label scoreLbl;
    }
}

