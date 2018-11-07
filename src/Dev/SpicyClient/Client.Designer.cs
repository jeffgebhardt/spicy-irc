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
            this.connectBtn = new System.Windows.Forms.Button();
            this.ircServerNameTxtBox = new System.Windows.Forms.TextBox();
            this.ircServerNameLbl = new System.Windows.Forms.Label();
            this.ircServerPortNumberTxtBox = new System.Windows.Forms.TextBox();
            this.ircServerPortNumberLbl = new System.Windows.Forms.Label();
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
            this.displayMessagesTxtBox.Location = new System.Drawing.Point(36, 68);
            this.displayMessagesTxtBox.Multiline = true;
            this.displayMessagesTxtBox.Name = "displayMessagesTxtBox";
            this.displayMessagesTxtBox.Size = new System.Drawing.Size(739, 302);
            this.displayMessagesTxtBox.TabIndex = 2;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(36, 13);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(121, 39);
            this.connectBtn.TabIndex = 3;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ircServerNameTxtBox
            // 
            this.ircServerNameTxtBox.Location = new System.Drawing.Point(191, 32);
            this.ircServerNameTxtBox.Name = "ircServerNameTxtBox";
            this.ircServerNameTxtBox.Size = new System.Drawing.Size(191, 20);
            this.ircServerNameTxtBox.TabIndex = 4;
            // 
            // ircServerNameLbl
            // 
            this.ircServerNameLbl.AutoSize = true;
            this.ircServerNameLbl.Location = new System.Drawing.Point(191, 13);
            this.ircServerNameLbl.Name = "ircServerNameLbl";
            this.ircServerNameLbl.Size = new System.Drawing.Size(90, 13);
            this.ircServerNameLbl.TabIndex = 5;
            this.ircServerNameLbl.Text = "IRC Server Name";
            // 
            // ircServerPortNumberTxtBox
            // 
            this.ircServerPortNumberTxtBox.Location = new System.Drawing.Point(442, 31);
            this.ircServerPortNumberTxtBox.Name = "ircServerPortNumberTxtBox";
            this.ircServerPortNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ircServerPortNumberTxtBox.TabIndex = 6;
            // 
            // ircServerPortNumberLbl
            // 
            this.ircServerPortNumberLbl.AutoSize = true;
            this.ircServerPortNumberLbl.Location = new System.Drawing.Point(442, 12);
            this.ircServerPortNumberLbl.Name = "ircServerPortNumberLbl";
            this.ircServerPortNumberLbl.Size = new System.Drawing.Size(121, 13);
            this.ircServerPortNumberLbl.TabIndex = 7;
            this.ircServerPortNumberLbl.Text = "IRC Server Port Number";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ircServerPortNumberLbl);
            this.Controls.Add(this.ircServerPortNumberTxtBox);
            this.Controls.Add(this.ircServerNameLbl);
            this.Controls.Add(this.ircServerNameTxtBox);
            this.Controls.Add(this.connectBtn);
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
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox ircServerNameTxtBox;
        private System.Windows.Forms.Label ircServerNameLbl;
        private System.Windows.Forms.TextBox ircServerPortNumberTxtBox;
        private System.Windows.Forms.Label ircServerPortNumberLbl;
    }
}

