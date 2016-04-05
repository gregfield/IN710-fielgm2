namespace FireAlarm
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
            this.fireAlarmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minorFireRbtn = new System.Windows.Forms.RadioButton();
            this.seriousFireBtn = new System.Windows.Forms.RadioButton();
            this.infernoFireBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fireAlarmBtn
            // 
            this.fireAlarmBtn.Location = new System.Drawing.Point(35, 12);
            this.fireAlarmBtn.Name = "fireAlarmBtn";
            this.fireAlarmBtn.Size = new System.Drawing.Size(121, 37);
            this.fireAlarmBtn.TabIndex = 0;
            this.fireAlarmBtn.Text = "Fire Alarm";
            this.fireAlarmBtn.UseVisualStyleBackColor = true;
            this.fireAlarmBtn.Click += new System.EventHandler(this.fireAlarmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infernoFireBtn);
            this.groupBox1.Controls.Add(this.seriousFireBtn);
            this.groupBox1.Controls.Add(this.minorFireRbtn);
            this.groupBox1.Location = new System.Drawing.Point(35, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire Category";
            // 
            // minorFireRbtn
            // 
            this.minorFireRbtn.AutoSize = true;
            this.minorFireRbtn.Location = new System.Drawing.Point(7, 44);
            this.minorFireRbtn.Name = "minorFireRbtn";
            this.minorFireRbtn.Size = new System.Drawing.Size(68, 21);
            this.minorFireRbtn.TabIndex = 0;
            this.minorFireRbtn.TabStop = true;
            this.minorFireRbtn.Text = "Minor ";
            this.minorFireRbtn.UseVisualStyleBackColor = true;
            // 
            // seriousFireBtn
            // 
            this.seriousFireBtn.AutoSize = true;
            this.seriousFireBtn.Location = new System.Drawing.Point(7, 91);
            this.seriousFireBtn.Name = "seriousFireBtn";
            this.seriousFireBtn.Size = new System.Drawing.Size(77, 21);
            this.seriousFireBtn.TabIndex = 1;
            this.seriousFireBtn.TabStop = true;
            this.seriousFireBtn.Text = "Serious";
            this.seriousFireBtn.UseVisualStyleBackColor = true;
            // 
            // infernoFireBtn
            // 
            this.infernoFireBtn.AutoSize = true;
            this.infernoFireBtn.Location = new System.Drawing.Point(7, 136);
            this.infernoFireBtn.Name = "infernoFireBtn";
            this.infernoFireBtn.Size = new System.Drawing.Size(73, 21);
            this.infernoFireBtn.TabIndex = 2;
            this.infernoFireBtn.TabStop = true;
            this.infernoFireBtn.Text = "Inferno";
            this.infernoFireBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fireAlarmBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fireAlarmBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton infernoFireBtn;
        private System.Windows.Forms.RadioButton seriousFireBtn;
        private System.Windows.Forms.RadioButton minorFireRbtn;
    }
}

