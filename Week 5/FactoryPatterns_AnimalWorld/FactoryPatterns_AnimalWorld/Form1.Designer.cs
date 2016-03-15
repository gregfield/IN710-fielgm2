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
            this.AUSBtn = new System.Windows.Forms.Button();
            this.NorthABtn = new System.Windows.Forms.Button();
            this.displayAnimalInfo = new System.Windows.Forms.ListBox();
            this.AsiaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AUSBtn
            // 
            this.AUSBtn.Location = new System.Drawing.Point(213, 474);
            this.AUSBtn.Name = "AUSBtn";
            this.AUSBtn.Size = new System.Drawing.Size(172, 49);
            this.AUSBtn.TabIndex = 1;
            this.AUSBtn.Text = "Australia";
            this.AUSBtn.UseVisualStyleBackColor = true;
            this.AUSBtn.Click += new System.EventHandler(this.AUSBtn_Click);
            // 
            // NorthABtn
            // 
            this.NorthABtn.Location = new System.Drawing.Point(569, 474);
            this.NorthABtn.Name = "NorthABtn";
            this.NorthABtn.Size = new System.Drawing.Size(172, 49);
            this.NorthABtn.TabIndex = 2;
            this.NorthABtn.Text = "North America";
            this.NorthABtn.UseVisualStyleBackColor = true;
            this.NorthABtn.Click += new System.EventHandler(this.NorthABtn_Click);
            // 
            // displayAnimalInfo
            // 
            this.displayAnimalInfo.FormattingEnabled = true;
            this.displayAnimalInfo.ItemHeight = 16;
            this.displayAnimalInfo.Location = new System.Drawing.Point(213, 22);
            this.displayAnimalInfo.Name = "displayAnimalInfo";
            this.displayAnimalInfo.Size = new System.Drawing.Size(528, 420);
            this.displayAnimalInfo.TabIndex = 3;
            // 
            // AsiaBtn
            // 
            this.AsiaBtn.Location = new System.Drawing.Point(391, 474);
            this.AsiaBtn.Name = "AsiaBtn";
            this.AsiaBtn.Size = new System.Drawing.Size(172, 49);
            this.AsiaBtn.TabIndex = 4;
            this.AsiaBtn.Text = "Asia";
            this.AsiaBtn.UseVisualStyleBackColor = true;
            this.AsiaBtn.Click += new System.EventHandler(this.AsiaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 553);
            this.Controls.Add(this.AsiaBtn);
            this.Controls.Add(this.displayAnimalInfo);
            this.Controls.Add(this.NorthABtn);
            this.Controls.Add(this.AUSBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AUSBtn;
        private System.Windows.Forms.Button NorthABtn;
        private System.Windows.Forms.ListBox displayAnimalInfo;
        private System.Windows.Forms.Button AsiaBtn;
    }
}

