
namespace TCPClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeseege = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(387, 247);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(64, 13);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(398, 23);
            this.txtIp.TabIndex = 2;
            this.txtIp.Text = "127.0.0.1:9000";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(64, 42);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(398, 170);
            this.txtInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Messege : ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMeseege
            // 
            this.txtMeseege.Location = new System.Drawing.Point(64, 218);
            this.txtMeseege.Name = "txtMeseege";
            this.txtMeseege.Size = new System.Drawing.Size(398, 23);
            this.txtMeseege.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(296, 247);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 276);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtMeseege);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeseege;
        private System.Windows.Forms.Button sendButton;
    }
}

