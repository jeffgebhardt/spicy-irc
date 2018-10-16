namespace SpicyIrc.SpicyClient
{
    partial class Client
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.sendTxtBox = new System.Windows.Forms.TextBox();
            this.displayMessagesTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(36, 389);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(121, 46);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // sendTxtBox
            // 
            this.sendTxtBox.Location = new System.Drawing.Point(175, 415);
            this.sendTxtBox.Name = "sendTxtBox";
            this.sendTxtBox.Size = new System.Drawing.Size(600, 20);
            this.sendTxtBox.TabIndex = 1;
            // 
            // displayMessagesTxtBox
            // 
            this.displayMessagesTxtBox.Location = new System.Drawing.Point(36, 21);
            this.displayMessagesTxtBox.Multiline = true;
            this.displayMessagesTxtBox.Name = "displayMessagesTxtBox";
            this.displayMessagesTxtBox.Size = new System.Drawing.Size(739, 349);
            this.displayMessagesTxtBox.TabIndex = 2;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayMessagesTxtBox);
            this.Controls.Add(this.sendTxtBox);
            this.Controls.Add(this.sendBtn);
            this.Name = "Client";
            this.Text = "Spicy IRC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox sendTxtBox;
        private System.Windows.Forms.TextBox displayMessagesTxtBox;
    }
}

