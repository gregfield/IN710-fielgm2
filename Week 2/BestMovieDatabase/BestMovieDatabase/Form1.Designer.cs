namespace BestMovieDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.movieAddBtn = new System.Windows.Forms.Button();
            this.movieDeleteBtn = new System.Windows.Forms.Button();
            this.movieSearchBtn = new System.Windows.Forms.Button();
            this.printAllBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.displayAllBox = new System.Windows.Forms.ListBox();
            this.yearAdd = new System.Windows.Forms.TextBox();
            this.titleAdd = new System.Windows.Forms.TextBox();
            this.directorAdd = new System.Windows.Forms.TextBox();
            this.yearDelete = new System.Windows.Forms.TextBox();
            this.yearSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Director:";
            // 
            // movieAddBtn
            // 
            this.movieAddBtn.Location = new System.Drawing.Point(34, 72);
            this.movieAddBtn.Name = "movieAddBtn";
            this.movieAddBtn.Size = new System.Drawing.Size(102, 42);
            this.movieAddBtn.TabIndex = 3;
            this.movieAddBtn.Text = "Add Movie";
            this.movieAddBtn.UseVisualStyleBackColor = true;
            this.movieAddBtn.Click += new System.EventHandler(this.movieAddBtn_Click);
            // 
            // movieDeleteBtn
            // 
            this.movieDeleteBtn.Location = new System.Drawing.Point(34, 223);
            this.movieDeleteBtn.Name = "movieDeleteBtn";
            this.movieDeleteBtn.Size = new System.Drawing.Size(102, 42);
            this.movieDeleteBtn.TabIndex = 4;
            this.movieDeleteBtn.Text = "Delete Movie";
            this.movieDeleteBtn.UseVisualStyleBackColor = true;
            this.movieDeleteBtn.Click += new System.EventHandler(this.movieDeleteBtn_Click);
            // 
            // movieSearchBtn
            // 
            this.movieSearchBtn.Location = new System.Drawing.Point(34, 297);
            this.movieSearchBtn.Name = "movieSearchBtn";
            this.movieSearchBtn.Size = new System.Drawing.Size(102, 42);
            this.movieSearchBtn.TabIndex = 5;
            this.movieSearchBtn.Text = "Search";
            this.movieSearchBtn.UseVisualStyleBackColor = true;
            this.movieSearchBtn.Click += new System.EventHandler(this.movieSearchBtn_Click);
            // 
            // printAllBtn
            // 
            this.printAllBtn.Location = new System.Drawing.Point(34, 361);
            this.printAllBtn.Name = "printAllBtn";
            this.printAllBtn.Size = new System.Drawing.Size(102, 42);
            this.printAllBtn.TabIndex = 6;
            this.printAllBtn.Text = "Print All";
            this.printAllBtn.UseVisualStyleBackColor = true;
            this.printAllBtn.Click += new System.EventHandler(this.printAllBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year:";
            // 
            // displayAllBox
            // 
            this.displayAllBox.FormattingEnabled = true;
            this.displayAllBox.ItemHeight = 16;
            this.displayAllBox.Location = new System.Drawing.Point(225, 361);
            this.displayAllBox.Name = "displayAllBox";
            this.displayAllBox.Size = new System.Drawing.Size(539, 148);
            this.displayAllBox.TabIndex = 9;
            // 
            // yearAdd
            // 
            this.yearAdd.Location = new System.Drawing.Point(309, 72);
            this.yearAdd.Name = "yearAdd";
            this.yearAdd.Size = new System.Drawing.Size(455, 22);
            this.yearAdd.TabIndex = 10;
            // 
            // titleAdd
            // 
            this.titleAdd.Location = new System.Drawing.Point(309, 110);
            this.titleAdd.Name = "titleAdd";
            this.titleAdd.Size = new System.Drawing.Size(455, 22);
            this.titleAdd.TabIndex = 11;
            // 
            // directorAdd
            // 
            this.directorAdd.Location = new System.Drawing.Point(309, 146);
            this.directorAdd.Name = "directorAdd";
            this.directorAdd.Size = new System.Drawing.Size(455, 22);
            this.directorAdd.TabIndex = 12;
            // 
            // yearDelete
            // 
            this.yearDelete.Location = new System.Drawing.Point(309, 236);
            this.yearDelete.Name = "yearDelete";
            this.yearDelete.Size = new System.Drawing.Size(455, 22);
            this.yearDelete.TabIndex = 13;
            // 
            // yearSearch
            // 
            this.yearSearch.Location = new System.Drawing.Point(309, 305);
            this.yearSearch.Name = "yearSearch";
            this.yearSearch.Size = new System.Drawing.Size(455, 22);
            this.yearSearch.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 534);
            this.Controls.Add(this.yearSearch);
            this.Controls.Add(this.yearDelete);
            this.Controls.Add(this.directorAdd);
            this.Controls.Add(this.titleAdd);
            this.Controls.Add(this.yearAdd);
            this.Controls.Add(this.displayAllBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.printAllBtn);
            this.Controls.Add(this.movieSearchBtn);
            this.Controls.Add(this.movieDeleteBtn);
            this.Controls.Add(this.movieAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button movieAddBtn;
        private System.Windows.Forms.Button movieDeleteBtn;
        private System.Windows.Forms.Button movieSearchBtn;
        private System.Windows.Forms.Button printAllBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox displayAllBox;
        private System.Windows.Forms.TextBox yearAdd;
        private System.Windows.Forms.TextBox titleAdd;
        private System.Windows.Forms.TextBox directorAdd;
        private System.Windows.Forms.TextBox yearDelete;
        private System.Windows.Forms.TextBox yearSearch;
    }
}

