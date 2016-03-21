namespace ComputerBuilder
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
            this.displaySpecBox = new System.Windows.Forms.ListBox();
            this.printSpecsBtn = new System.Windows.Forms.Button();
            this.rbtnGroup = new System.Windows.Forms.GroupBox();
            this.gmaeRbtn = new System.Windows.Forms.RadioButton();
            this.MultiRbtn = new System.Windows.Forms.RadioButton();
            this.businessRbtn = new System.Windows.Forms.RadioButton();
            this.laptopRbtn = new System.Windows.Forms.RadioButton();
            this.rbtnGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaySpecBox
            // 
            this.displaySpecBox.FormattingEnabled = true;
            this.displaySpecBox.ItemHeight = 16;
            this.displaySpecBox.Location = new System.Drawing.Point(267, 21);
            this.displaySpecBox.Name = "displaySpecBox";
            this.displaySpecBox.Size = new System.Drawing.Size(369, 260);
            this.displaySpecBox.TabIndex = 0;
            // 
            // printSpecsBtn
            // 
            this.printSpecsBtn.Location = new System.Drawing.Point(12, 21);
            this.printSpecsBtn.Name = "printSpecsBtn";
            this.printSpecsBtn.Size = new System.Drawing.Size(168, 34);
            this.printSpecsBtn.TabIndex = 1;
            this.printSpecsBtn.Text = "Print Spec";
            this.printSpecsBtn.UseVisualStyleBackColor = true;
            this.printSpecsBtn.Click += new System.EventHandler(this.printSpecsBtn_Click);
            // 
            // rbtnGroup
            // 
            this.rbtnGroup.Controls.Add(this.laptopRbtn);
            this.rbtnGroup.Controls.Add(this.gmaeRbtn);
            this.rbtnGroup.Controls.Add(this.MultiRbtn);
            this.rbtnGroup.Controls.Add(this.businessRbtn);
            this.rbtnGroup.Location = new System.Drawing.Point(12, 80);
            this.rbtnGroup.Name = "rbtnGroup";
            this.rbtnGroup.Size = new System.Drawing.Size(220, 202);
            this.rbtnGroup.TabIndex = 2;
            this.rbtnGroup.TabStop = false;
            this.rbtnGroup.Text = "Machine Type";
            // 
            // gmaeRbtn
            // 
            this.gmaeRbtn.AutoSize = true;
            this.gmaeRbtn.Location = new System.Drawing.Point(7, 135);
            this.gmaeRbtn.Name = "gmaeRbtn";
            this.gmaeRbtn.Size = new System.Drawing.Size(78, 21);
            this.gmaeRbtn.TabIndex = 2;
            this.gmaeRbtn.TabStop = true;
            this.gmaeRbtn.Text = "Gaming";
            this.gmaeRbtn.UseVisualStyleBackColor = true;
            // 
            // MultiRbtn
            // 
            this.MultiRbtn.AutoSize = true;
            this.MultiRbtn.Location = new System.Drawing.Point(7, 90);
            this.MultiRbtn.Name = "MultiRbtn";
            this.MultiRbtn.Size = new System.Drawing.Size(96, 21);
            this.MultiRbtn.TabIndex = 1;
            this.MultiRbtn.TabStop = true;
            this.MultiRbtn.Text = "Multimedia";
            this.MultiRbtn.UseVisualStyleBackColor = true;
            // 
            // businessRbtn
            // 
            this.businessRbtn.AutoSize = true;
            this.businessRbtn.Location = new System.Drawing.Point(7, 46);
            this.businessRbtn.Name = "businessRbtn";
            this.businessRbtn.Size = new System.Drawing.Size(86, 21);
            this.businessRbtn.TabIndex = 0;
            this.businessRbtn.TabStop = true;
            this.businessRbtn.Text = "Business";
            this.businessRbtn.UseVisualStyleBackColor = true;
            // 
            // laptopRbtn
            // 
            this.laptopRbtn.AutoSize = true;
            this.laptopRbtn.Location = new System.Drawing.Point(7, 175);
            this.laptopRbtn.Name = "laptopRbtn";
            this.laptopRbtn.Size = new System.Drawing.Size(73, 21);
            this.laptopRbtn.TabIndex = 3;
            this.laptopRbtn.TabStop = true;
            this.laptopRbtn.Text = "Laptop";
            this.laptopRbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 307);
            this.Controls.Add(this.rbtnGroup);
            this.Controls.Add(this.printSpecsBtn);
            this.Controls.Add(this.displaySpecBox);
            this.Name = "Form1";
            this.Text = "Computer Builder";
            this.rbtnGroup.ResumeLayout(false);
            this.rbtnGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox displaySpecBox;
        private System.Windows.Forms.Button printSpecsBtn;
        private System.Windows.Forms.GroupBox rbtnGroup;
        private System.Windows.Forms.RadioButton gmaeRbtn;
        private System.Windows.Forms.RadioButton MultiRbtn;
        private System.Windows.Forms.RadioButton businessRbtn;
        private System.Windows.Forms.RadioButton laptopRbtn;
    }
}

