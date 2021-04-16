using System.Drawing;

namespace Simple_RDP_Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.txbNameComputer = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgBConnecting = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrvList = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOnline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(506, 100);
            this.panelTitle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(116, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "UMC REMOTE DESKTOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Simple_RDP_Client.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 0);
            this.panel3.TabIndex = 9;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.txbNameComputer);
            this.panelContent.Controls.Add(this.lblStatus);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.btnConnect);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(506, 95);
            this.panelContent.TabIndex = 10;
            // 
            // txbNameComputer
            // 
            this.txbNameComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameComputer.Location = new System.Drawing.Point(101, 17);
            this.txbNameComputer.Name = "txbNameComputer";
            this.txbNameComputer.Size = new System.Drawing.Size(186, 26);
            this.txbNameComputer.TabIndex = 9;
            this.txbNameComputer.TextChanged += new System.EventHandler(this.txbNameComputer_TextChanged);
            this.txbNameComputer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbNameComputer_PreviewKeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(28, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên máy";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(293, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(131, 28);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSp,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel3,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSp
            // 
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(55, 19);
            this.lblSp.Text = "Support: ";
            this.lblSp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(43, 19);
            this.toolStripStatusLabel4.Text = "PE-IT";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel8.Image = global::Simple_RDP_Client.Properties.Resources._09_321;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(52, 19);
            this.toolStripStatusLabel8.Text = "3143";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(48, 19);
            this.toolStripStatusLabel3.Text = "Version:";
            // 
            // lblVersion
            // 
            this.lblVersion.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVersion.IsLink = true;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(16, 19);
            this.lblVersion.Text = "0";
            // 
            // pgBConnecting
            // 
            this.pgBConnecting.Location = new System.Drawing.Point(274, 253);
            this.pgBConnecting.Name = "pgBConnecting";
            this.pgBConnecting.Size = new System.Drawing.Size(229, 23);
            this.pgBConnecting.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgrvList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 87);
            this.panel1.TabIndex = 13;
            // 
            // dgrvList
            // 
            this.dgrvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Id,
            this.ComputerName,
            this.UpdateTime,
            this.Connection,
            this.IsOnline});
            this.dgrvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvList.Location = new System.Drawing.Point(0, 0);
            this.dgrvList.Name = "dgrvList";
            this.dgrvList.ReadOnly = true;
            this.dgrvList.RowHeadersVisible = false;
            this.dgrvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvList.Size = new System.Drawing.Size(506, 87);
            this.dgrvList.TabIndex = 0;
            this.dgrvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvList_CellClick);
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IPAddress";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 200;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ComputerName
            // 
            this.ComputerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "ComputerName";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "UpdateTime";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Visible = false;
            // 
            // Connection
            // 
            this.Connection.DataPropertyName = "Connection";
            this.Connection.HeaderText = "Connection";
            this.Connection.Name = "Connection";
            this.Connection.ReadOnly = true;
            this.Connection.Visible = false;
            // 
            // IsOnline
            // 
            this.IsOnline.DataPropertyName = "IsOnline";
            this.IsOnline.HeaderText = "IsOnline";
            this.IsOnline.Name = "IsOnline";
            this.IsOnline.ReadOnly = true;
            this.IsOnline.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 306);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgBConnecting);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "UMC REMOTE DESKTOP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ProgressBar pgBConnecting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOnline;
        private System.Windows.Forms.TextBox txbNameComputer;
    }
}