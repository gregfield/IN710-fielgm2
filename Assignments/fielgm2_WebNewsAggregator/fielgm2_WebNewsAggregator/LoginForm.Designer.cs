namespace fielgm2_WebNewsAggregator
{
    partial class LoginForm
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
            this.loginLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.usrnameTxtBox = new System.Windows.Forms.TextBox();
            this.passwdTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.createUsrBtn = new System.Windows.Forms.Button();
            this.confirmPsswdTxtBox = new System.Windows.Forms.TextBox();
            this.confimPsswdLbl = new System.Windows.Forms.Label();
            this.newPasswdTxtBox = new System.Windows.Forms.TextBox();
            this.nuewUsrTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(43, 51);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(106, 20);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Please Login";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(43, 127);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(91, 20);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Username:";
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLbl.Location = new System.Drawing.Point(43, 162);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(88, 20);
            this.passwdLbl.TabIndex = 2;
            this.passwdLbl.Text = "Password:";
            // 
            // usrnameTxtBox
            // 
            this.usrnameTxtBox.Location = new System.Drawing.Point(140, 125);
            this.usrnameTxtBox.Name = "usrnameTxtBox";
            this.usrnameTxtBox.Size = new System.Drawing.Size(209, 22);
            this.usrnameTxtBox.TabIndex = 3;
            // 
            // passwdTxtBox
            // 
            this.passwdTxtBox.Location = new System.Drawing.Point(140, 162);
            this.passwdTxtBox.Name = "passwdTxtBox";
            this.passwdTxtBox.PasswordChar = '*';
            this.passwdTxtBox.Size = new System.Drawing.Size(209, 22);
            this.passwdTxtBox.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(131, 230);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(158, 40);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createUsrBtn
            // 
            this.createUsrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUsrBtn.Location = new System.Drawing.Point(771, 230);
            this.createUsrBtn.Name = "createUsrBtn";
            this.createUsrBtn.Size = new System.Drawing.Size(155, 40);
            this.createUsrBtn.TabIndex = 18;
            this.createUsrBtn.Text = "Create User";
            this.createUsrBtn.UseVisualStyleBackColor = true;
            this.createUsrBtn.Click += new System.EventHandler(this.createUsrBtn_Click);
            // 
            // confirmPsswdTxtBox
            // 
            this.confirmPsswdTxtBox.Location = new System.Drawing.Point(717, 187);
            this.confirmPsswdTxtBox.Name = "confirmPsswdTxtBox";
            this.confirmPsswdTxtBox.PasswordChar = '*';
            this.confirmPsswdTxtBox.Size = new System.Drawing.Size(209, 22);
            this.confirmPsswdTxtBox.TabIndex = 17;
            // 
            // confimPsswdLbl
            // 
            this.confimPsswdLbl.AutoSize = true;
            this.confimPsswdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confimPsswdLbl.Location = new System.Drawing.Point(559, 189);
            this.confimPsswdLbl.Name = "confimPsswdLbl";
            this.confimPsswdLbl.Size = new System.Drawing.Size(152, 20);
            this.confimPsswdLbl.TabIndex = 16;
            this.confimPsswdLbl.Text = "Confirm Password:";
            // 
            // newPasswdTxtBox
            // 
            this.newPasswdTxtBox.Location = new System.Drawing.Point(717, 153);
            this.newPasswdTxtBox.Name = "newPasswdTxtBox";
            this.newPasswdTxtBox.PasswordChar = '*';
            this.newPasswdTxtBox.Size = new System.Drawing.Size(209, 22);
            this.newPasswdTxtBox.TabIndex = 15;
            // 
            // nuewUsrTxtbox
            // 
            this.nuewUsrTxtbox.Location = new System.Drawing.Point(717, 116);
            this.nuewUsrTxtbox.Name = "nuewUsrTxtbox";
            this.nuewUsrTxtbox.Size = new System.Drawing.Size(209, 22);
            this.nuewUsrTxtbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Don\'t Have a profile. Create a new one below";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createUsrBtn);
            this.Controls.Add(this.confirmPsswdTxtBox);
            this.Controls.Add(this.confimPsswdLbl);
            this.Controls.Add(this.newPasswdTxtBox);
            this.Controls.Add(this.nuewUsrTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwdTxtBox);
            this.Controls.Add(this.usrnameTxtBox);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.loginLbl);
            this.Name = "LoginForm";
            this.Text = "News Aggregator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwdLbl;
        private System.Windows.Forms.TextBox usrnameTxtBox;
        private System.Windows.Forms.TextBox passwdTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createUsrBtn;
        private System.Windows.Forms.TextBox confirmPsswdTxtBox;
        private System.Windows.Forms.Label confimPsswdLbl;
        private System.Windows.Forms.TextBox newPasswdTxtBox;
        private System.Windows.Forms.TextBox nuewUsrTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

