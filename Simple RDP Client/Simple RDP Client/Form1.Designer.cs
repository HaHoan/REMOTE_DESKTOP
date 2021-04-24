namespace Simple_RDP_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axRDPViewer = new AxRDPCOMAPILib.AxRDPViewer();
            this.panelChat = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnChat = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblNameComputer = new System.Windows.Forms.Label();
            this.btnOpenToolBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).BeginInit();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            this.panelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // axRDPViewer
            // 
            this.axRDPViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axRDPViewer.Enabled = true;
            this.axRDPViewer.Location = new System.Drawing.Point(0, 0);
            this.axRDPViewer.Name = "axRDPViewer";
            this.axRDPViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRDPViewer.OcxState")));
            this.axRDPViewer.Size = new System.Drawing.Size(1235, 798);
            this.axRDPViewer.TabIndex = 5;
            // 
            // panelChat
            // 
            this.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChat.Controls.Add(this.btnSend);
            this.panelChat.Controls.Add(this.MessagetextBox);
            this.panelChat.Controls.Add(this.ChatScreentextBox);
            this.panelChat.Location = new System.Drawing.Point(24, 36);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(289, 297);
            this.panelChat.TabIndex = 7;
            this.panelChat.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Image = global::Simple_RDP_Client.Properties.Resources.icons8_email_send_30;
            this.btnSend.Location = new System.Drawing.Point(234, 235);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(37, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(26, 234);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(200, 51);
            this.MessagetextBox.TabIndex = 1;
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.Location = new System.Drawing.Point(24, 18);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.ReadOnly = true;
            this.ChatScreentextBox.Size = new System.Drawing.Size(247, 195);
            this.ChatScreentextBox.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // panelTool
            // 
            this.panelTool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTool.Controls.Add(this.btnChat);
            this.panelTool.Controls.Add(this.btnFullScreen);
            this.panelTool.Controls.Add(this.btnMinimize);
            this.panelTool.Controls.Add(this.btnClose);
            this.panelTool.Controls.Add(this.lblNameComputer);
            this.panelTool.Location = new System.Drawing.Point(23, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(207, 23);
            this.panelTool.TabIndex = 8;
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChat.Image = global::Simple_RDP_Client.Properties.Resources.icons8_chat_16;
            this.btnChat.Location = new System.Drawing.Point(105, 0);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(27, 19);
            this.btnChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnChat.TabIndex = 4;
            this.btnChat.TabStop = false;
            this.btnChat.Click += new System.EventHandler(this.sbChat_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFullScreen.Image = global::Simple_RDP_Client.Properties.Resources.icons8_full_screen_16;
            this.btnFullScreen.Location = new System.Drawing.Point(132, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(27, 19);
            this.btnFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFullScreen.TabIndex = 3;
            this.btnFullScreen.TabStop = false;
            this.btnFullScreen.Click += new System.EventHandler(this.toolStripStatusLabelFullScreen_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Image = global::Simple_RDP_Client.Properties.Resources.icons8_minimize_window_16;
            this.btnMinimize.Location = new System.Drawing.Point(159, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 19);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Simple_RDP_Client.Properties.Resources.icons8_close_window_16;
            this.btnClose.Location = new System.Drawing.Point(187, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNameComputer
            // 
            this.lblNameComputer.AutoSize = true;
            this.lblNameComputer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNameComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameComputer.Location = new System.Drawing.Point(0, 0);
            this.lblNameComputer.Name = "lblNameComputer";
            this.lblNameComputer.Size = new System.Drawing.Size(54, 15);
            this.lblNameComputer.TabIndex = 0;
            this.lblNameComputer.Text = "Tên máy";
            this.lblNameComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenToolBar
            // 
            this.btnOpenToolBar.Image = global::Simple_RDP_Client.Properties.Resources.icons8_minimize_window_16;
            this.btnOpenToolBar.Location = new System.Drawing.Point(9, 3);
            this.btnOpenToolBar.Name = "btnOpenToolBar";
            this.btnOpenToolBar.Size = new System.Drawing.Size(15, 18);
            this.btnOpenToolBar.TabIndex = 5;
            this.btnOpenToolBar.TabStop = false;
            this.btnOpenToolBar.Visible = false;
            this.btnOpenToolBar.Click += new System.EventHandler(this.btnOpenToolBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 798);
            this.Controls.Add(this.btnOpenToolBar);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.axRDPViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "UMC REMOTE DESTOP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).EndInit();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenToolBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.PictureBox btnSend;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Label lblNameComputer;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnFullScreen;
        private System.Windows.Forms.PictureBox btnChat;
        private System.Windows.Forms.PictureBox btnOpenToolBar;
    }
}

