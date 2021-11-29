
namespace TCPServer
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
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeseege = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.clientIPList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(387, 294);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
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
            this.txtInfo.Size = new System.Drawing.Size(398, 217);
            this.txtInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Messege : ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMeseege
            // 
            this.txtMeseege.Location = new System.Drawing.Point(64, 265);
            this.txtMeseege.Name = "txtMeseege";
            this.txtMeseege.Size = new System.Drawing.Size(398, 23);
            this.txtMeseege.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(296, 294);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clientIPList
            // 
            this.clientIPList.FormattingEnabled = true;
            this.clientIPList.ItemHeight = 15;
            this.clientIPList.Location = new System.Drawing.Point(481, 42);
            this.clientIPList.Name = "clientIPList";
            this.clientIPList.Size = new System.Drawing.Size(234, 274);
            this.clientIPList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Client IP :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 331);
            this.Controls.Add(this.clientIPList);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtMeseege);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeseege;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox clientIPList;
        private System.Windows.Forms.Label label3;
    }
}

