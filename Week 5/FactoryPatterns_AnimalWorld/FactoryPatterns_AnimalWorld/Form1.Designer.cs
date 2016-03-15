namespace FactoryPatterns_AnimalWorld
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
            this.AnimalInfo = new System.Windows.Forms.RichTextBox();
            this.AUSBtn = new System.Windows.Forms.Button();
            this.NorthABtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalInfo
            // 
            this.AnimalInfo.Location = new System.Drawing.Point(294, 25);
            this.AnimalInfo.Name = "AnimalInfo";
            this.AnimalInfo.Size = new System.Drawing.Size(511, 421);
            this.AnimalInfo.TabIndex = 0;
            this.AnimalInfo.Text = "";
            // 
            // AUSBtn
            // 
            this.AUSBtn.Location = new System.Drawing.Point(319, 474);
            this.AUSBtn.Name = "AUSBtn";
            this.AUSBtn.Size = new System.Drawing.Size(172, 49);
            this.AUSBtn.TabIndex = 1;
            this.AUSBtn.Text = "Australia";
            this.AUSBtn.UseVisualStyleBackColor = true;
            this.AUSBtn.Click += new System.EventHandler(this.AUSBtn_Click);
            // 
            // NorthABtn
            // 
            this.NorthABtn.Location = new System.Drawing.Point(599, 474);
            this.NorthABtn.Name = "NorthABtn";
            this.NorthABtn.Size = new System.Drawing.Size(172, 49);
            this.NorthABtn.TabIndex = 2;
            this.NorthABtn.Text = "North America";
            this.NorthABtn.UseVisualStyleBackColor = true;
            this.NorthABtn.Click += new System.EventHandler(this.NorthABtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 548);
            this.Controls.Add(this.NorthABtn);
            this.Controls.Add(this.AUSBtn);
            this.Controls.Add(this.AnimalInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AnimalInfo;
        private System.Windows.Forms.Button AUSBtn;
        private System.Windows.Forms.Button NorthABtn;
    }
}

