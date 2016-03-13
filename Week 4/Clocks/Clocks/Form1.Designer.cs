namespace Clocks
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
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.rbtnDigital = new System.Windows.Forms.RadioButton();
            this.rbtnAnalog = new System.Windows.Forms.RadioButton();
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.digitalClockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(38, 47);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(221, 48);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Clock";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(38, 113);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(221, 48);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop Clock";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // rbtnDigital
            // 
            this.rbtnDigital.AutoSize = true;
            this.rbtnDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDigital.Location = new System.Drawing.Point(15, 14);
            this.rbtnDigital.Name = "rbtnDigital";
            this.rbtnDigital.Size = new System.Drawing.Size(141, 29);
            this.rbtnDigital.TabIndex = 2;
            this.rbtnDigital.TabStop = true;
            this.rbtnDigital.Text = "Digital Clock";
            // 
            // rbtnAnalog
            // 
            this.rbtnAnalog.AutoSize = true;
            this.rbtnAnalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnalog.Location = new System.Drawing.Point(15, 58);
            this.rbtnAnalog.Name = "rbtnAnalog";
            this.rbtnAnalog.Size = new System.Drawing.Size(150, 29);
            this.rbtnAnalog.TabIndex = 3;
            this.rbtnAnalog.TabStop = true;
            this.rbtnAnalog.Text = "Analog Clock";
            this.rbtnAnalog.UseVisualStyleBackColor = true;
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(109, 199);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(263, 263);
            this.analogClock1.TabIndex = 4;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // digitalClockLabel
            // 
            this.digitalClockLabel.AutoSize = true;
            this.digitalClockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digitalClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClockLabel.Location = new System.Drawing.Point(181, 321);
            this.digitalClockLabel.Name = "digitalClockLabel";
            this.digitalClockLabel.Size = new System.Drawing.Size(2, 27);
            this.digitalClockLabel.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnAnalog);
            this.panel1.Controls.Add(this.rbtnDigital);
            this.panel1.Location = new System.Drawing.Point(278, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 114);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.digitalClockLabel);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Clocks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.RadioButton rbtnDigital;
        private System.Windows.Forms.RadioButton rbtnAnalog;
        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.Label digitalClockLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;

    }
}

