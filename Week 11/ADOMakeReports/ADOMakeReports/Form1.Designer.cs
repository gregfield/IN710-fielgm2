namespace ADOMakeReports
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
            this.papersTutorsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assignments2WeeksBtn = new System.Windows.Forms.Button();
            this.avgMarkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // papersTutorsBtn
            // 
            this.papersTutorsBtn.Location = new System.Drawing.Point(26, 414);
            this.papersTutorsBtn.Name = "papersTutorsBtn";
            this.papersTutorsBtn.Size = new System.Drawing.Size(140, 45);
            this.papersTutorsBtn.TabIndex = 0;
            this.papersTutorsBtn.Text = "Papers and Tutors";
            this.papersTutorsBtn.UseVisualStyleBackColor = true;
            this.papersTutorsBtn.Click += new System.EventHandler(this.papersTutorsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // assignments2WeeksBtn
            // 
            this.assignments2WeeksBtn.Location = new System.Drawing.Point(285, 414);
            this.assignments2WeeksBtn.Name = "assignments2WeeksBtn";
            this.assignments2WeeksBtn.Size = new System.Drawing.Size(140, 45);
            this.assignments2WeeksBtn.TabIndex = 4;
            this.assignments2WeeksBtn.Text = "Assignments Due Next 2 Weeks";
            this.assignments2WeeksBtn.UseVisualStyleBackColor = true;
            this.assignments2WeeksBtn.Click += new System.EventHandler(this.assignments2WeeksBtn_Click);
            // 
            // avgMarkBtn
            // 
            this.avgMarkBtn.Location = new System.Drawing.Point(533, 414);
            this.avgMarkBtn.Name = "avgMarkBtn";
            this.avgMarkBtn.Size = new System.Drawing.Size(140, 45);
            this.avgMarkBtn.TabIndex = 5;
            this.avgMarkBtn.Text = "Average Mark";
            this.avgMarkBtn.UseVisualStyleBackColor = true;
            this.avgMarkBtn.Click += new System.EventHandler(this.avgMarkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 470);
            this.Controls.Add(this.avgMarkBtn);
            this.Controls.Add(this.assignments2WeeksBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.papersTutorsBtn);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button papersTutorsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button assignments2WeeksBtn;
        private System.Windows.Forms.Button avgMarkBtn;
    }
}

