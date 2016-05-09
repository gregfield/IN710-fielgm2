namespace ORMandLinq
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
            this.avgStrikeIntensityBtn = new System.Windows.Forms.Button();
            this.larget3FiresBtn = new System.Windows.Forms.Button();
            this.fireCausedbyStrikeBtn = new System.Windows.Forms.Button();
            this.picLongLatFileBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // avgStrikeIntensityBtn
            // 
            this.avgStrikeIntensityBtn.Location = new System.Drawing.Point(12, 38);
            this.avgStrikeIntensityBtn.Name = "avgStrikeIntensityBtn";
            this.avgStrikeIntensityBtn.Size = new System.Drawing.Size(175, 40);
            this.avgStrikeIntensityBtn.TabIndex = 0;
            this.avgStrikeIntensityBtn.Text = "Average Strike Intensity";
            this.avgStrikeIntensityBtn.UseVisualStyleBackColor = true;
            this.avgStrikeIntensityBtn.Click += new System.EventHandler(this.avgStrikeIntensityBtn_Click);
            // 
            // larget3FiresBtn
            // 
            this.larget3FiresBtn.Location = new System.Drawing.Point(193, 38);
            this.larget3FiresBtn.Name = "larget3FiresBtn";
            this.larget3FiresBtn.Size = new System.Drawing.Size(150, 40);
            this.larget3FiresBtn.TabIndex = 1;
            this.larget3FiresBtn.Text = "Largest 3 Fires";
            this.larget3FiresBtn.UseVisualStyleBackColor = true;
            this.larget3FiresBtn.Click += new System.EventHandler(this.larget3FiresBtn_Click);
            // 
            // fireCausedbyStrikeBtn
            // 
            this.fireCausedbyStrikeBtn.Location = new System.Drawing.Point(530, 38);
            this.fireCausedbyStrikeBtn.Name = "fireCausedbyStrikeBtn";
            this.fireCausedbyStrikeBtn.Size = new System.Drawing.Size(175, 40);
            this.fireCausedbyStrikeBtn.TabIndex = 2;
            this.fireCausedbyStrikeBtn.Text = "Fires Caued by Strikes";
            this.fireCausedbyStrikeBtn.UseVisualStyleBackColor = true;
            this.fireCausedbyStrikeBtn.Click += new System.EventHandler(this.fireCausedbyStrikeBtn_Click);
            // 
            // picLongLatFileBtn
            // 
            this.picLongLatFileBtn.Location = new System.Drawing.Point(349, 38);
            this.picLongLatFileBtn.Name = "picLongLatFileBtn";
            this.picLongLatFileBtn.Size = new System.Drawing.Size(175, 40);
            this.picLongLatFileBtn.TabIndex = 3;
            this.picLongLatFileBtn.Text = "Picture Info";
            this.picLongLatFileBtn.UseVisualStyleBackColor = true;
            this.picLongLatFileBtn.Click += new System.EventHandler(this.picLongLatFileBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(688, 372);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 483);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.picLongLatFileBtn);
            this.Controls.Add(this.fireCausedbyStrikeBtn);
            this.Controls.Add(this.larget3FiresBtn);
            this.Controls.Add(this.avgStrikeIntensityBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button avgStrikeIntensityBtn;
        private System.Windows.Forms.Button larget3FiresBtn;
        private System.Windows.Forms.Button fireCausedbyStrikeBtn;
        private System.Windows.Forms.Button picLongLatFileBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

