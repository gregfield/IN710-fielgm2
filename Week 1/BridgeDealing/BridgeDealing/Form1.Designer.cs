namespace BridgeDealing
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
            this.Player1 = new System.Windows.Forms.ListBox();
            this.Player2 = new System.Windows.Forms.ListBox();
            this.Player3 = new System.Windows.Forms.ListBox();
            this.Player4 = new System.Windows.Forms.ListBox();
            this.DealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.FormattingEnabled = true;
            this.Player1.ItemHeight = 16;
            this.Player1.Location = new System.Drawing.Point(238, 12);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(170, 116);
            this.Player1.TabIndex = 0;
            // 
            // Player2
            // 
            this.Player2.FormattingEnabled = true;
            this.Player2.ItemHeight = 16;
            this.Player2.Location = new System.Drawing.Point(429, 129);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(170, 116);
            this.Player2.TabIndex = 1;
            // 
            // Player3
            // 
            this.Player3.FormattingEnabled = true;
            this.Player3.ItemHeight = 16;
            this.Player3.Location = new System.Drawing.Point(238, 251);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(170, 116);
            this.Player3.TabIndex = 2;
            // 
            // Player4
            // 
            this.Player4.FormattingEnabled = true;
            this.Player4.ItemHeight = 16;
            this.Player4.Location = new System.Drawing.Point(43, 129);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(170, 116);
            this.Player4.TabIndex = 3;
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(487, 353);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(136, 30);
            this.DealButton.TabIndex = 4;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 395);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Name = "Form1";
            this.Text = "Bridge Dealer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Player1;
        private System.Windows.Forms.ListBox Player2;
        private System.Windows.Forms.ListBox Player3;
        private System.Windows.Forms.ListBox Player4;
        private System.Windows.Forms.Button DealButton;
    }
}

