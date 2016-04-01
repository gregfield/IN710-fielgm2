namespace ProgressIndicatorApplication
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
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spinBoxRbtn = new System.Windows.Forms.RadioButton();
            this.progBarRbtn = new System.Windows.Forms.RadioButton();
            this.trackBarRbtn = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(36, 24);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(139, 33);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarRbtn);
            this.groupBox1.Controls.Add(this.progBarRbtn);
            this.groupBox1.Controls.Add(this.spinBoxRbtn);
            this.groupBox1.Location = new System.Drawing.Point(36, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feedback";
            // 
            // spinBoxRbtn
            // 
            this.spinBoxRbtn.AutoSize = true;
            this.spinBoxRbtn.Location = new System.Drawing.Point(7, 22);
            this.spinBoxRbtn.Name = "spinBoxRbtn";
            this.spinBoxRbtn.Size = new System.Drawing.Size(84, 21);
            this.spinBoxRbtn.TabIndex = 0;
            this.spinBoxRbtn.TabStop = true;
            this.spinBoxRbtn.Text = "Spin Box";
            this.spinBoxRbtn.UseVisualStyleBackColor = true;
            // 
            // progBarRbtn
            // 
            this.progBarRbtn.AutoSize = true;
            this.progBarRbtn.Location = new System.Drawing.Point(7, 62);
            this.progBarRbtn.Name = "progBarRbtn";
            this.progBarRbtn.Size = new System.Drawing.Size(112, 21);
            this.progBarRbtn.TabIndex = 1;
            this.progBarRbtn.TabStop = true;
            this.progBarRbtn.Text = "Progress Bar";
            this.progBarRbtn.UseVisualStyleBackColor = true;
            // 
            // trackBarRbtn
            // 
            this.trackBarRbtn.AutoSize = true;
            this.trackBarRbtn.Location = new System.Drawing.Point(7, 100);
            this.trackBarRbtn.Name = "trackBarRbtn";
            this.trackBarRbtn.Size = new System.Drawing.Size(91, 21);
            this.trackBarRbtn.TabIndex = 2;
            this.trackBarRbtn.TabStop = true;
            this.trackBarRbtn.Text = "Track Bar";
            this.trackBarRbtn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(269, 117);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(269, 167);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(381, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(269, 217);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(381, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 331);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton trackBarRbtn;
        private System.Windows.Forms.RadioButton progBarRbtn;
        private System.Windows.Forms.RadioButton spinBoxRbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

