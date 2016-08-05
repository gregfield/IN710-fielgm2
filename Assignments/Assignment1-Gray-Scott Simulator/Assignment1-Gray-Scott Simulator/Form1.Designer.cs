namespace Assignment1_Gray_Scott_Simulator
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.runSimBtn = new System.Windows.Forms.Button();
            this.runBatchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deltaRbtn = new System.Windows.Forms.RadioButton();
            this.convolutionRbtn = new System.Windows.Forms.RadioButton();
            this.perpendicularRbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feedATxtBox = new System.Windows.Forms.TextBox();
            this.killBTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redRbtn = new System.Windows.Forms.RadioButton();
            this.blueRbtn = new System.Windows.Forms.RadioButton();
            this.grayScaleRbtn = new System.Windows.Forms.RadioButton();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // runSimBtn
            // 
            this.runSimBtn.Location = new System.Drawing.Point(32, 709);
            this.runSimBtn.Name = "runSimBtn";
            this.runSimBtn.Size = new System.Drawing.Size(141, 49);
            this.runSimBtn.TabIndex = 0;
            this.runSimBtn.Text = "Run Simulation";
            this.runSimBtn.UseVisualStyleBackColor = true;
            this.runSimBtn.Click += new System.EventHandler(this.runSimBtn_Click);
            // 
            // runBatchBtn
            // 
            this.runBatchBtn.Location = new System.Drawing.Point(32, 775);
            this.runBatchBtn.Name = "runBatchBtn";
            this.runBatchBtn.Size = new System.Drawing.Size(141, 49);
            this.runBatchBtn.TabIndex = 1;
            this.runBatchBtn.Text = "Run Batch Simulation";
            this.runBatchBtn.UseVisualStyleBackColor = true;
            this.runBatchBtn.Click += new System.EventHandler(this.runBatchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deltaRbtn);
            this.groupBox1.Controls.Add(this.convolutionRbtn);
            this.groupBox1.Controls.Add(this.perpendicularRbtn);
            this.groupBox1.Location = new System.Drawing.Point(235, 709);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laplacian Functions";
            // 
            // deltaRbtn
            // 
            this.deltaRbtn.AutoSize = true;
            this.deltaRbtn.Location = new System.Drawing.Point(9, 88);
            this.deltaRbtn.Name = "deltaRbtn";
            this.deltaRbtn.Size = new System.Drawing.Size(108, 21);
            this.deltaRbtn.TabIndex = 2;
            this.deltaRbtn.TabStop = true;
            this.deltaRbtn.Text = "Delta Means";
            this.deltaRbtn.UseVisualStyleBackColor = true;
            // 
            // convolutionRbtn
            // 
            this.convolutionRbtn.AutoSize = true;
            this.convolutionRbtn.Location = new System.Drawing.Point(9, 54);
            this.convolutionRbtn.Name = "convolutionRbtn";
            this.convolutionRbtn.Size = new System.Drawing.Size(103, 21);
            this.convolutionRbtn.TabIndex = 1;
            this.convolutionRbtn.TabStop = true;
            this.convolutionRbtn.Text = "Convolution";
            this.convolutionRbtn.UseVisualStyleBackColor = true;
            // 
            // perpendicularRbtn
            // 
            this.perpendicularRbtn.AutoSize = true;
            this.perpendicularRbtn.Location = new System.Drawing.Point(10, 22);
            this.perpendicularRbtn.Name = "perpendicularRbtn";
            this.perpendicularRbtn.Size = new System.Drawing.Size(117, 21);
            this.perpendicularRbtn.TabIndex = 0;
            this.perpendicularRbtn.TabStop = true;
            this.perpendicularRbtn.Text = "Perpendicular";
            this.perpendicularRbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 754);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rate of Feed A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 801);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate of Kill B:";
            // 
            // feedATxtBox
            // 
            this.feedATxtBox.Location = new System.Drawing.Point(556, 751);
            this.feedATxtBox.Name = "feedATxtBox";
            this.feedATxtBox.Size = new System.Drawing.Size(160, 22);
            this.feedATxtBox.TabIndex = 5;
            // 
            // killBTxtBox
            // 
            this.killBTxtBox.Location = new System.Drawing.Point(556, 801);
            this.killBTxtBox.Name = "killBTxtBox";
            this.killBTxtBox.Size = new System.Drawing.Size(160, 22);
            this.killBTxtBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please Enter A Number Between 0 and 1";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(32, 840);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(141, 49);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save Pattern To File";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.redRbtn);
            this.groupBox2.Controls.Add(this.blueRbtn);
            this.groupBox2.Controls.Add(this.grayScaleRbtn);
            this.groupBox2.Location = new System.Drawing.Point(235, 825);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 76);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colour Scheme";
            // 
            // redRbtn
            // 
            this.redRbtn.AutoSize = true;
            this.redRbtn.Location = new System.Drawing.Point(119, 21);
            this.redRbtn.Name = "redRbtn";
            this.redRbtn.Size = new System.Drawing.Size(69, 21);
            this.redRbtn.TabIndex = 2;
            this.redRbtn.TabStop = true;
            this.redRbtn.Text = "Green";
            this.redRbtn.UseVisualStyleBackColor = true;
            // 
            // blueRbtn
            // 
            this.blueRbtn.AutoSize = true;
            this.blueRbtn.Location = new System.Drawing.Point(10, 48);
            this.blueRbtn.Name = "blueRbtn";
            this.blueRbtn.Size = new System.Drawing.Size(91, 21);
            this.blueRbtn.TabIndex = 1;
            this.blueRbtn.TabStop = true;
            this.blueRbtn.Text = "Dark Blue";
            this.blueRbtn.UseVisualStyleBackColor = true;
            // 
            // grayScaleRbtn
            // 
            this.grayScaleRbtn.AutoSize = true;
            this.grayScaleRbtn.Location = new System.Drawing.Point(9, 21);
            this.grayScaleRbtn.Name = "grayScaleRbtn";
            this.grayScaleRbtn.Size = new System.Drawing.Size(93, 21);
            this.grayScaleRbtn.TabIndex = 0;
            this.grayScaleRbtn.TabStop = true;
            this.grayScaleRbtn.Text = "Grayscale";
            this.grayScaleRbtn.UseVisualStyleBackColor = true;
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationLabel.Location = new System.Drawing.Point(461, 853);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(64, 18);
            this.iterationLabel.TabIndex = 10;
            this.iterationLabel.Text = "Iteration:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(749, 903);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.killBTxtBox);
            this.Controls.Add(this.feedATxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.runBatchBtn);
            this.Controls.Add(this.runSimBtn);
            this.MinimumSize = new System.Drawing.Size(767, 950);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button runSimBtn;
        private System.Windows.Forms.Button runBatchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton deltaRbtn;
        private System.Windows.Forms.RadioButton convolutionRbtn;
        private System.Windows.Forms.RadioButton perpendicularRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox feedATxtBox;
        private System.Windows.Forms.TextBox killBTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton grayScaleRbtn;
        private System.Windows.Forms.RadioButton redRbtn;
        private System.Windows.Forms.RadioButton blueRbtn;
        private System.Windows.Forms.Label iterationLabel;
    }
}

