namespace IsEvenUsingLambdaExpressions
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.selectLessThan10 = new System.Windows.Forms.Button();
            this.selectEvens = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.generateRandoms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(317, 135);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(166, 404);
            this.listBox2.TabIndex = 9;
            // 
            // selectLessThan10
            // 
            this.selectLessThan10.Location = new System.Drawing.Point(317, 70);
            this.selectLessThan10.Name = "selectLessThan10";
            this.selectLessThan10.Size = new System.Drawing.Size(166, 43);
            this.selectLessThan10.TabIndex = 8;
            this.selectLessThan10.Text = "Select < 10";
            this.selectLessThan10.UseVisualStyleBackColor = true;
            this.selectLessThan10.Click += new System.EventHandler(this.selectLessThan10_Click);
            // 
            // selectEvens
            // 
            this.selectEvens.Location = new System.Drawing.Point(317, 21);
            this.selectEvens.Name = "selectEvens";
            this.selectEvens.Size = new System.Drawing.Size(166, 43);
            this.selectEvens.TabIndex = 7;
            this.selectEvens.Text = "Select Evens";
            this.selectEvens.UseVisualStyleBackColor = true;
            this.selectEvens.Click += new System.EventHandler(this.selectEvens_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(52, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 404);
            this.listBox1.TabIndex = 6;
            // 
            // generateRandoms
            // 
            this.generateRandoms.Location = new System.Drawing.Point(52, 21);
            this.generateRandoms.Name = "generateRandoms";
            this.generateRandoms.Size = new System.Drawing.Size(166, 43);
            this.generateRandoms.TabIndex = 5;
            this.generateRandoms.Text = "Generate Randoms";
            this.generateRandoms.UseVisualStyleBackColor = true;
            this.generateRandoms.Click += new System.EventHandler(this.generateRandoms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 561);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.selectLessThan10);
            this.Controls.Add(this.selectEvens);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.generateRandoms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button selectLessThan10;
        private System.Windows.Forms.Button selectEvens;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button generateRandoms;
    }
}

