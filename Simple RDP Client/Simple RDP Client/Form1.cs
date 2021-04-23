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
                        ChatScreentextBox.AppendText("Connected to server" + "\n");
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
                    this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentextBox.AppendText("You:" + recieve + "\n");
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
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
                    ChatScreentextBox.AppendText("Me:" + TextToSend + "\n");
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
            if (MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
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
                sbFullScreen.Image = Properties.Resources.full_screen;

            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                sbFullScreen.Image = Properties.Resources.icons8_exit_24;
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
            }

        }

    }
}
