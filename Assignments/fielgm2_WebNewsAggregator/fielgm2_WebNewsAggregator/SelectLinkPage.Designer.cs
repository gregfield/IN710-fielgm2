namespace fielgm2_WebNewsAggregator
{
    partial class SelectLinkPage
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
            this.getNewsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.likeTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dislikeTxtBox = new System.Windows.Forms.TextBox();
            this.addLikeBtn = new System.Windows.Forms.Button();
            this.addDislikeBtn = new System.Windows.Forms.Button();
            this.newsRbtn = new System.Windows.Forms.RadioButton();
            this.weSitesRbtn = new System.Windows.Forms.RadioButton();
            this.NameOfArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getNewsBtn
            // 
            this.getNewsBtn.Location = new System.Drawing.Point(990, 144);
            this.getNewsBtn.Name = "getNewsBtn";
            this.getNewsBtn.Size = new System.Drawing.Size(234, 49);
            this.getNewsBtn.TabIndex = 0;
            this.getNewsBtn.Text = "Get Random Links";
            this.getNewsBtn.UseVisualStyleBackColor = true;
            this.getNewsBtn.Click += new System.EventHandler(this.getNewsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfArticle,
            this.Description,
            this.Link});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 894);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(999, 905);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(234, 49);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Click On Article you wish to view";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1402, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add a new Like or Dislike";
            // 
            // likeTxtBox
            // 
            this.likeTxtBox.Location = new System.Drawing.Point(1459, 80);
            this.likeTxtBox.Name = "likeTxtBox";
            this.likeTxtBox.Size = new System.Drawing.Size(227, 22);
            this.likeTxtBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1404, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Like:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1404, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dislike:";
            // 
            // dislikeTxtBox
            // 
            this.dislikeTxtBox.Location = new System.Drawing.Point(1479, 159);
            this.dislikeTxtBox.Name = "dislikeTxtBox";
            this.dislikeTxtBox.Size = new System.Drawing.Size(207, 22);
            this.dislikeTxtBox.TabIndex = 9;
            // 
            // addLikeBtn
            // 
            this.addLikeBtn.Location = new System.Drawing.Point(1733, 71);
            this.addLikeBtn.Name = "addLikeBtn";
            this.addLikeBtn.Size = new System.Drawing.Size(120, 41);
            this.addLikeBtn.TabIndex = 10;
            this.addLikeBtn.Text = "Add Like";
            this.addLikeBtn.UseVisualStyleBackColor = true;
            this.addLikeBtn.Click += new System.EventHandler(this.addLikeBtn_Click);
            // 
            // addDislikeBtn
            // 
            this.addDislikeBtn.Location = new System.Drawing.Point(1733, 152);
            this.addDislikeBtn.Name = "addDislikeBtn";
            this.addDislikeBtn.Size = new System.Drawing.Size(120, 41);
            this.addDislikeBtn.TabIndex = 11;
            this.addDislikeBtn.Text = "Add Dislike";
            this.addDislikeBtn.UseVisualStyleBackColor = true;
            this.addDislikeBtn.Click += new System.EventHandler(this.addDislikeBtn_Click);
            // 
            // newsRbtn
            // 
            this.newsRbtn.AutoSize = true;
            this.newsRbtn.Location = new System.Drawing.Point(999, 60);
            this.newsRbtn.Name = "newsRbtn";
            this.newsRbtn.Size = new System.Drawing.Size(113, 21);
            this.newsRbtn.TabIndex = 12;
            this.newsRbtn.TabStop = true;
            this.newsRbtn.Text = "News Articles";
            this.newsRbtn.UseVisualStyleBackColor = true;
            // 
            // weSitesRbtn
            // 
            this.weSitesRbtn.AutoSize = true;
            this.weSitesRbtn.Location = new System.Drawing.Point(999, 105);
            this.weSitesRbtn.Name = "weSitesRbtn";
            this.weSitesRbtn.Size = new System.Drawing.Size(93, 21);
            this.weSitesRbtn.TabIndex = 13;
            this.weSitesRbtn.TabStop = true;
            this.weSitesRbtn.Text = "Web Sites";
            this.weSitesRbtn.UseVisualStyleBackColor = true;
            // 
            // NameOfArticle
            // 
            this.NameOfArticle.HeaderText = "Name";
            this.NameOfArticle.Name = "NameOfArticle";
            this.NameOfArticle.Width = 250;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 500;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 200;
            // 
            // SelectLinkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.weSitesRbtn);
            this.Controls.Add(this.newsRbtn);
            this.Controls.Add(this.addDislikeBtn);
            this.Controls.Add(this.addLikeBtn);
            this.Controls.Add(this.dislikeTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.likeTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getNewsBtn);
            this.Name = "SelectLinkPage";
            this.Text = "CreateNewUserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateNewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getNewsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox likeTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dislikeTxtBox;
        private System.Windows.Forms.Button addLikeBtn;
        private System.Windows.Forms.Button addDislikeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.RadioButton newsRbtn;
        private System.Windows.Forms.RadioButton weSitesRbtn;

    }
}