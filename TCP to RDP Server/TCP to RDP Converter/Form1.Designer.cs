namespace TCP_to_RDP_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChat = new System.Windows.Forms.Panel();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panelChat
            // 
            this.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChat.Controls.Add(this.button1);
            this.panelChat.Controls.Add(this.btnMinimize);
            this.panelChat.Controls.Add(this.ChatScreentextBox);
            this.panelChat.Controls.Add(this.MessagetextBox);
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChat.Location = new System.Drawing.Point(0, 0);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(289, 273);
            this.panelChat.TabIndex = 9;
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.Location = new System.Drawing.Point(11, 37);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.ReadOnly = true;
            this.ChatScreentextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatScreentextBox.Size = new System.Drawing.Size(267, 180);
            this.ChatScreentextBox.TabIndex = 0;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(15, 234);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(205, 23);
            this.MessagetextBox.TabIndex = 1;
            this.MessagetextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MessagetextBox_PreviewKeyDown);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TCP_to_RDP_Converter.Properties.Resources.icons8_send_email_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(230, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gửi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::TCP_to_RDP_Converter.Properties.Resources.icons8_minimize_window_16;
            this.btnMinimize.Location = new System.Drawing.Point(255, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 15);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 273);
            this.Controls.Add(this.panelChat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UMC REMOTE DESKTOP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
    }
}

