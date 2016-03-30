namespace Social_Networker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateStatusTxtBox = new System.Windows.Forms.TextBox();
            this.mainPageListBox = new System.Windows.Forms.ListBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.firend1ListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.friend2ListBox = new System.Windows.Forms.ListBox();
            this.friend3ListBox = new System.Windows.Forms.ListBox();
            this.friend4ListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateStatusTxtBox);
            this.tabPage1.Controls.Add(this.mainPageListBox);
            this.tabPage1.Controls.Add(this.updateBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateStatusTxtBox
            // 
            this.updateStatusTxtBox.Location = new System.Drawing.Point(167, 366);
            this.updateStatusTxtBox.Name = "updateStatusTxtBox";
            this.updateStatusTxtBox.Size = new System.Drawing.Size(426, 22);
            this.updateStatusTxtBox.TabIndex = 2;
            // 
            // mainPageListBox
            // 
            this.mainPageListBox.FormattingEnabled = true;
            this.mainPageListBox.ItemHeight = 16;
            this.mainPageListBox.Location = new System.Drawing.Point(15, 7);
            this.mainPageListBox.Name = "mainPageListBox";
            this.mainPageListBox.Size = new System.Drawing.Size(578, 340);
            this.mainPageListBox.TabIndex = 1;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(15, 361);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(129, 32);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update Status";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.firend1ListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friend 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // firend1ListBox
            // 
            this.firend1ListBox.FormattingEnabled = true;
            this.firend1ListBox.ItemHeight = 16;
            this.firend1ListBox.Location = new System.Drawing.Point(19, 35);
            this.firend1ListBox.Name = "firend1ListBox";
            this.firend1ListBox.Size = new System.Drawing.Size(578, 340);
            this.firend1ListBox.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.friend2ListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(616, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Friend 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.friend3ListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(616, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Friend 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.friend4ListBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(616, 410);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Friend 4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // friend2ListBox
            // 
            this.friend2ListBox.FormattingEnabled = true;
            this.friend2ListBox.ItemHeight = 16;
            this.friend2ListBox.Location = new System.Drawing.Point(19, 35);
            this.friend2ListBox.Name = "friend2ListBox";
            this.friend2ListBox.Size = new System.Drawing.Size(578, 340);
            this.friend2ListBox.TabIndex = 3;
            // 
            // friend3ListBox
            // 
            this.friend3ListBox.FormattingEnabled = true;
            this.friend3ListBox.ItemHeight = 16;
            this.friend3ListBox.Location = new System.Drawing.Point(19, 35);
            this.friend3ListBox.Name = "friend3ListBox";
            this.friend3ListBox.Size = new System.Drawing.Size(578, 340);
            this.friend3ListBox.TabIndex = 3;
            // 
            // friend4ListBox
            // 
            this.friend4ListBox.FormattingEnabled = true;
            this.friend4ListBox.ItemHeight = 16;
            this.friend4ListBox.Location = new System.Drawing.Point(19, 35);
            this.friend4ListBox.Name = "friend4ListBox";
            this.friend4ListBox.Size = new System.Drawing.Size(578, 340);
            this.friend4ListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox updateStatusTxtBox;
        private System.Windows.Forms.ListBox mainPageListBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox firend1ListBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox friend2ListBox;
        private System.Windows.Forms.ListBox friend3ListBox;
        private System.Windows.Forms.ListBox friend4ListBox;
    }
}

