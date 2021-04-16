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
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 798);
            this.Controls.Add(this.axRDPViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UMC REMOTE DESKTOP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer;
    }
}

