using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using AxRDPCOMAPILib;

namespace Simple_RDP_Client
{
    public partial class Form1 : Form
    {
        public Action closed;
        private TcpClient client;
        private REMOTE_INFO ip;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;
        public Form1(REMOTE_INFO ip)
        {
            InitializeComponent();
            this.ip = ip;
            lblNameComputer.Text = ip.ComputerName;
            Connect(ip.Connection, this.axRDPViewer, "", "");
            
        }

        public void Connect(string invitation, AxRDPViewer display, string userName, string password)
        {
            try
            {
                display.Connect(invitation, userName, password);
                client = new TcpClient();
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ip.IPAddress.Trim()), ip.Id);

                try
                {
                    client.Connect(IpEnd);

                    if (client.Connected)
                    {
                        ChatScreentextBox.AppendText("Connected to server" + Environment.NewLine);
                        STW = new StreamWriter(client.GetStream());
                        STR = new StreamReader(client.GetStream());
                        STW.AutoFlush = true;
                        backgroundWorker1.RunWorkerAsync();
                        backgroundWorker2.WorkerSupportsCancellation = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    closed();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                closed();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    if (recieve == null) return;
                    this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentextBox.AppendText("You:" + recieve + Environment.NewLine);
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreentextBox.AppendText("Me:" + TextToSend + Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            if (MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.ResetText();
            MessagetextBox.Focus();
        }
        public static void disconnect(AxRDPViewer display)
        {
            try
            {
                display.Disconnect();
            }
            catch (Exception e)
            {

            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                client.Close();
                STW.Close();
                STR.Close();
                closed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void toolStripStatusLabelFullScreen_Click(object sender, EventArgs e)
        {
            if (TopMost)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                btnFullScreen.Image = Properties.Resources.icons8_full_screen_16;

            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                btnFullScreen.Image = Properties.Resources.icons8_exit_16;
            }

        }

        private void sbChat_Click(object sender, EventArgs e)
        {
            if (panelChat.Visible)
            {
                panelChat.Hide();
            }
            else
            {
                panelChat.Show();
                MessagetextBox.Focus();
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                panelTool.Show();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelTool.Visible = false;
            btnOpenToolBar.Visible = true;
        }

        private void btnOpenToolBar_Click(object sender, EventArgs e)
        {
            panelTool.Visible = true;
            btnOpenToolBar.Visible = false;
        }

        private void MessagetextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendMessage();
               
            }
        }
    }
}
