namespace CustomHandlers
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
            this.testHandlersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testHandlersBtn
            // 
            this.testHandlersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testHandlersBtn.Location = new System.Drawing.Point(35, 74);
            this.testHandlersBtn.Name = "testHandlersBtn";
            this.testHandlersBtn.Size = new System.Drawing.Size(205, 91);
            this.testHandlersBtn.TabIndex = 0;
            this.testHandlersBtn.Text = "Test Handlers";
            this.testHandlersBtn.UseVisualStyleBackColor = true;
            this.testHandlersBtn.Click += new System.EventHandler(this.testHandlersBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.testHandlersBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testHandlersBtn;
    }
}

