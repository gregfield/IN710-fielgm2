namespace BycycleSubjectObserver
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
            this.changeRPMBtn = new System.Windows.Forms.Button();
            this.RPMTextBox = new System.Windows.Forms.TextBox();
            this.RPMLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.labelRPM = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeRPMBtn
            // 
            this.changeRPMBtn.Location = new System.Drawing.Point(298, 50);
            this.changeRPMBtn.Name = "changeRPMBtn";
            this.changeRPMBtn.Size = new System.Drawing.Size(103, 50);
            this.changeRPMBtn.TabIndex = 0;
            this.changeRPMBtn.Text = "Change RPM";
            this.changeRPMBtn.UseVisualStyleBackColor = true;
            this.changeRPMBtn.Click += new System.EventHandler(this.changeRPMBtn_Click);
            // 
            // RPMTextBox
            // 
            this.RPMTextBox.Location = new System.Drawing.Point(51, 50);
            this.RPMTextBox.Name = "RPMTextBox";
            this.RPMTextBox.Size = new System.Drawing.Size(185, 22);
            this.RPMTextBox.TabIndex = 1;
            // 
            // RPMLabel
            // 
            this.RPMLabel.AutoSize = true;
            this.RPMLabel.Location = new System.Drawing.Point(109, 157);
            this.RPMLabel.Name = "RPMLabel";
            this.RPMLabel.Size = new System.Drawing.Size(38, 17);
            this.RPMLabel.TabIndex = 2;
            this.RPMLabel.Text = "RPM";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(109, 212);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(59, 17);
            this.caloriesLabel.TabIndex = 3;
            this.caloriesLabel.Text = "Calories";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(109, 261);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(63, 17);
            this.distanceLabel.TabIndex = 4;
            this.distanceLabel.Text = "Distance";
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Location = new System.Drawing.Point(189, 157);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(0, 17);
            this.labelRPM.TabIndex = 5;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Location = new System.Drawing.Point(192, 211);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(0, 17);
            this.labelCalories.TabIndex = 6;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(195, 260);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(0, 17);
            this.labelDistance.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 441);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.RPMLabel);
            this.Controls.Add(this.RPMTextBox);
            this.Controls.Add(this.changeRPMBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeRPMBtn;
        private System.Windows.Forms.TextBox RPMTextBox;
        private System.Windows.Forms.Label RPMLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelDistance;
    }
}

