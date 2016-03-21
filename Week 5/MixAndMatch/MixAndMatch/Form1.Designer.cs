namespace MixAndMatch
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
            this.headComboBox = new System.Windows.Forms.ComboBox();
            this.bodyComboBox = new System.Windows.Forms.ComboBox();
            this.tailComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headPicBox = new System.Windows.Forms.PictureBox();
            this.bodyPicBox = new System.Windows.Forms.PictureBox();
            this.tailPicBox = new System.Windows.Forms.PictureBox();
            this.makeMonsterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headComboBox
            // 
            this.headComboBox.FormattingEnabled = true;
            this.headComboBox.Location = new System.Drawing.Point(346, 27);
            this.headComboBox.Name = "headComboBox";
            this.headComboBox.Size = new System.Drawing.Size(121, 24);
            this.headComboBox.TabIndex = 0;
            // 
            // bodyComboBox
            // 
            this.bodyComboBox.FormattingEnabled = true;
            this.bodyComboBox.Location = new System.Drawing.Point(346, 92);
            this.bodyComboBox.Name = "bodyComboBox";
            this.bodyComboBox.Size = new System.Drawing.Size(121, 24);
            this.bodyComboBox.TabIndex = 1;
            // 
            // tailComboBox
            // 
            this.tailComboBox.FormattingEnabled = true;
            this.tailComboBox.Location = new System.Drawing.Point(346, 153);
            this.tailComboBox.Name = "tailComboBox";
            this.tailComboBox.Size = new System.Drawing.Size(121, 24);
            this.tailComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Head";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tail";
            // 
            // headPicBox
            // 
            this.headPicBox.Location = new System.Drawing.Point(35, 27);
            this.headPicBox.Name = "headPicBox";
            this.headPicBox.Size = new System.Drawing.Size(210, 143);
            this.headPicBox.TabIndex = 6;
            this.headPicBox.TabStop = false;
            // 
            // bodyPicBox
            // 
            this.bodyPicBox.Location = new System.Drawing.Point(35, 167);
            this.bodyPicBox.Name = "bodyPicBox";
            this.bodyPicBox.Size = new System.Drawing.Size(210, 143);
            this.bodyPicBox.TabIndex = 7;
            this.bodyPicBox.TabStop = false;
            // 
            // tailPicBox
            // 
            this.tailPicBox.Location = new System.Drawing.Point(35, 307);
            this.tailPicBox.Name = "tailPicBox";
            this.tailPicBox.Size = new System.Drawing.Size(210, 143);
            this.tailPicBox.TabIndex = 8;
            this.tailPicBox.TabStop = false;
            // 
            // makeMonsterBtn
            // 
            this.makeMonsterBtn.Location = new System.Drawing.Point(346, 216);
            this.makeMonsterBtn.Name = "makeMonsterBtn";
            this.makeMonsterBtn.Size = new System.Drawing.Size(121, 34);
            this.makeMonsterBtn.TabIndex = 9;
            this.makeMonsterBtn.Text = "Make Monster";
            this.makeMonsterBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 508);
            this.Controls.Add(this.makeMonsterBtn);
            this.Controls.Add(this.tailPicBox);
            this.Controls.Add(this.bodyPicBox);
            this.Controls.Add(this.headPicBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tailComboBox);
            this.Controls.Add(this.bodyComboBox);
            this.Controls.Add(this.headComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.headPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox headComboBox;
        private System.Windows.Forms.ComboBox bodyComboBox;
        private System.Windows.Forms.ComboBox tailComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox headPicBox;
        private System.Windows.Forms.PictureBox bodyPicBox;
        private System.Windows.Forms.PictureBox tailPicBox;
        private System.Windows.Forms.Button makeMonsterBtn;
    }
}

