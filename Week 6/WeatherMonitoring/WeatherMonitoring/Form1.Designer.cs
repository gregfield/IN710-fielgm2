namespace WeatherMonitoring
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.tempLbl = new System.Windows.Forms.Label();
            this.humidityLbl = new System.Windows.Forms.Label();
            this.baroLbl = new System.Windows.Forms.Label();
            this.tempTxtBox = new System.Windows.Forms.TextBox();
            this.humidityTxtBox = new System.Windows.Forms.TextBox();
            this.baroTxtBox = new System.Windows.Forms.TextBox();
            this.temp2Lbl = new System.Windows.Forms.Label();
            this.humidity2Lbl = new System.Windows.Forms.Label();
            this.baro2Lbl = new System.Windows.Forms.Label();
            this.currListBox = new System.Windows.Forms.ListBox();
            this.averageListBox = new System.Windows.Forms.ListBox();
            this.forecastListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(37, 43);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(171, 50);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update Measurements";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Location = new System.Drawing.Point(34, 153);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(113, 17);
            this.tempLbl.TabIndex = 1;
            this.tempLbl.Text = "Temperature (C)";
            // 
            // humidityLbl
            // 
            this.humidityLbl.AutoSize = true;
            this.humidityLbl.Location = new System.Drawing.Point(34, 250);
            this.humidityLbl.Name = "humidityLbl";
            this.humidityLbl.Size = new System.Drawing.Size(96, 17);
            this.humidityLbl.TabIndex = 2;
            this.humidityLbl.Text = "Humididty (%)";
            // 
            // baroLbl
            // 
            this.baroLbl.AutoSize = true;
            this.baroLbl.Location = new System.Drawing.Point(34, 338);
            this.baroLbl.Name = "baroLbl";
            this.baroLbl.Size = new System.Drawing.Size(137, 17);
            this.baroLbl.TabIndex = 3;
            this.baroLbl.Text = "Barometric Pressure";
            this.baroLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tempTxtBox
            // 
            this.tempTxtBox.Location = new System.Drawing.Point(37, 192);
            this.tempTxtBox.Name = "tempTxtBox";
            this.tempTxtBox.Size = new System.Drawing.Size(134, 22);
            this.tempTxtBox.TabIndex = 4;
            // 
            // humidityTxtBox
            // 
            this.humidityTxtBox.Location = new System.Drawing.Point(37, 290);
            this.humidityTxtBox.Name = "humidityTxtBox";
            this.humidityTxtBox.Size = new System.Drawing.Size(134, 22);
            this.humidityTxtBox.TabIndex = 5;
            // 
            // baroTxtBox
            // 
            this.baroTxtBox.Location = new System.Drawing.Point(37, 379);
            this.baroTxtBox.Name = "baroTxtBox";
            this.baroTxtBox.Size = new System.Drawing.Size(134, 22);
            this.baroTxtBox.TabIndex = 6;
            // 
            // temp2Lbl
            // 
            this.temp2Lbl.AutoSize = true;
            this.temp2Lbl.Location = new System.Drawing.Point(362, 43);
            this.temp2Lbl.Name = "temp2Lbl";
            this.temp2Lbl.Size = new System.Drawing.Size(102, 17);
            this.temp2Lbl.TabIndex = 7;
            this.temp2Lbl.Text = "Current Values";
            // 
            // humidity2Lbl
            // 
            this.humidity2Lbl.AutoSize = true;
            this.humidity2Lbl.Location = new System.Drawing.Point(362, 214);
            this.humidity2Lbl.Name = "humidity2Lbl";
            this.humidity2Lbl.Size = new System.Drawing.Size(125, 17);
            this.humidity2Lbl.TabIndex = 8;
            this.humidity2Lbl.Text = "Average Readings";
            // 
            // baro2Lbl
            // 
            this.baro2Lbl.AutoSize = true;
            this.baro2Lbl.Location = new System.Drawing.Point(362, 384);
            this.baro2Lbl.Name = "baro2Lbl";
            this.baro2Lbl.Size = new System.Drawing.Size(63, 17);
            this.baro2Lbl.TabIndex = 9;
            this.baro2Lbl.Text = "Forecast";
            this.baro2Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currListBox
            // 
            this.currListBox.FormattingEnabled = true;
            this.currListBox.ItemHeight = 16;
            this.currListBox.Location = new System.Drawing.Point(365, 77);
            this.currListBox.Name = "currListBox";
            this.currListBox.Size = new System.Drawing.Size(491, 116);
            this.currListBox.TabIndex = 10;
            // 
            // averageListBox
            // 
            this.averageListBox.FormattingEnabled = true;
            this.averageListBox.ItemHeight = 16;
            this.averageListBox.Location = new System.Drawing.Point(365, 250);
            this.averageListBox.Name = "averageListBox";
            this.averageListBox.Size = new System.Drawing.Size(491, 116);
            this.averageListBox.TabIndex = 11;
            // 
            // forecastListBox
            // 
            this.forecastListBox.FormattingEnabled = true;
            this.forecastListBox.ItemHeight = 16;
            this.forecastListBox.Location = new System.Drawing.Point(365, 422);
            this.forecastListBox.Name = "forecastListBox";
            this.forecastListBox.Size = new System.Drawing.Size(491, 116);
            this.forecastListBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 562);
            this.Controls.Add(this.forecastListBox);
            this.Controls.Add(this.averageListBox);
            this.Controls.Add(this.currListBox);
            this.Controls.Add(this.baro2Lbl);
            this.Controls.Add(this.humidity2Lbl);
            this.Controls.Add(this.temp2Lbl);
            this.Controls.Add(this.baroTxtBox);
            this.Controls.Add(this.humidityTxtBox);
            this.Controls.Add(this.tempTxtBox);
            this.Controls.Add(this.baroLbl);
            this.Controls.Add(this.humidityLbl);
            this.Controls.Add(this.tempLbl);
            this.Controls.Add(this.updateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label humidityLbl;
        private System.Windows.Forms.Label baroLbl;
        private System.Windows.Forms.TextBox tempTxtBox;
        private System.Windows.Forms.TextBox humidityTxtBox;
        private System.Windows.Forms.TextBox baroTxtBox;
        private System.Windows.Forms.Label temp2Lbl;
        private System.Windows.Forms.Label humidity2Lbl;
        private System.Windows.Forms.Label baro2Lbl;
        private System.Windows.Forms.ListBox currListBox;
        private System.Windows.Forms.ListBox averageListBox;
        private System.Windows.Forms.ListBox forecastListBox;
    }
}

