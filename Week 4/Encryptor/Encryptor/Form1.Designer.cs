namespace Encryptor
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
            this.rdbtnROT13 = new System.Windows.Forms.RadioButton();
            this.rdbtnReverse = new System.Windows.Forms.RadioButton();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnROT13
            // 
            this.rdbtnROT13.AutoSize = true;
            this.rdbtnROT13.Location = new System.Drawing.Point(85, 84);
            this.rdbtnROT13.Name = "rdbtnROT13";
            this.rdbtnROT13.Size = new System.Drawing.Size(75, 21);
            this.rdbtnROT13.TabIndex = 0;
            this.rdbtnROT13.TabStop = true;
            this.rdbtnROT13.Text = "ROT13";
            this.rdbtnROT13.UseVisualStyleBackColor = true;
            // 
            // rdbtnReverse
            // 
            this.rdbtnReverse.AutoSize = true;
            this.rdbtnReverse.Location = new System.Drawing.Point(85, 126);
            this.rdbtnReverse.Name = "rdbtnReverse";
            this.rdbtnReverse.Size = new System.Drawing.Size(123, 21);
            this.rdbtnReverse.TabIndex = 1;
            this.rdbtnReverse.TabStop = true;
            this.rdbtnReverse.Text = "Reverse String";
            this.rdbtnReverse.UseVisualStyleBackColor = true;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(336, 84);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 34);
            this.encryptBtn.TabIndex = 2;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(85, 240);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(39, 17);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Input";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(85, 308);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(47, 17);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Ouput";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(153, 240);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(279, 22);
            this.InputTextBox.TabIndex = 5;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(153, 308);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(279, 22);
            this.OutputTextBox.TabIndex = 6;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(445, 84);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 34);
            this.decryptBtn.TabIndex = 7;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 456);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.rdbtnReverse);
            this.Controls.Add(this.rdbtnROT13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnROT13;
        private System.Windows.Forms.RadioButton rdbtnReverse;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button decryptBtn;
    }
}

