namespace ADOMakeDatabase
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
            this.mkDbBtn = new System.Windows.Forms.Button();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.passwdTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mkDbBtn
            // 
            this.mkDbBtn.Location = new System.Drawing.Point(266, 225);
            this.mkDbBtn.Name = "mkDbBtn";
            this.mkDbBtn.Size = new System.Drawing.Size(159, 31);
            this.mkDbBtn.TabIndex = 0;
            this.mkDbBtn.Text = "Make Database";
            this.mkDbBtn.UseVisualStyleBackColor = true;
            this.mkDbBtn.Click += new System.EventHandler(this.mkDbBtn_Click);
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Location = new System.Drawing.Point(80, 136);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(69, 17);
            this.passwdLbl.TabIndex = 1;
            this.passwdLbl.Text = "Password";
            // 
            // passwdTxtBox
            // 
            this.passwdTxtBox.Location = new System.Drawing.Point(176, 136);
            this.passwdTxtBox.Name = "passwdTxtBox";
            this.passwdTxtBox.PasswordChar = '*';
            this.passwdTxtBox.Size = new System.Drawing.Size(100, 22);
            this.passwdTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 308);
            this.Controls.Add(this.passwdTxtBox);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.mkDbBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mkDbBtn;
        private System.Windows.Forms.Label passwdLbl;
        private System.Windows.Forms.TextBox passwdTxtBox;
    }
}

