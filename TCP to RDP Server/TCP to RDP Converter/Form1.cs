using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDPCOMAPILib;
using AxMSTSCLib;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TCP_to_RDP_Converter
{
    public partial class Form1 : Form
    {
        public static RDPSession currentSession = null;
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        private TcpListener listener;


        public static void createSession()
        {
            currentSession = new RDPSession();
        }

        public static void Connect(RDPSession session)
        {
            try
            {
                session.OnAttendeeConnected += Incoming;
                session.Open();
            }
            catch (Exception)
            {

            }
           
        }

        public static void Disconnect(RDPSession session)
        {
            try
            {
                session.Close();
            }
            catch (Exception)
            {

            }
           
        }

        public static string getConnectionString(RDPSession session, String authString,
            string group, string password, int clientLimit)
        {
            IRDPSRAPIInvitation invitation =
                session.Invitations.CreateInvitation
                (authString, group, password, clientLimit);
            return invitation.ConnectionString;
        }

        private static void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }
        string IpAddress = "";
        int Port = 0;
        Timer timer;
        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            if (CommonFunc.Utils.PingHost("172.28.10.8"))
            {
                timer.Stop();
                try
                {
                    Common.RegisterInStartup(true, Application.ExecutablePath);
                    IpAddress = CommonFunc.Utils.GetLocalIPAddress();
                    string hostname = Environment.MachineName;
                    createSession();
                    Connect(currentSession);
                    var textConnectionString = getConnectionString(currentSession,
                        "Test", "Group", "", 5);
                    using (var db = new SOFTWAREEntities())
                    {
                        var ip = db.REMOTE_INFO.Where(m => m.ComputerName == hostname).FirstOrDefault();

                        if (ip != null)
                        {
                            ip.UpdateTime = DateTime.Now;
                            ip.Connection = textConnectionString;
                            ip.ComputerName = hostname;
                            ip.IsOnline = true;
                            db.SaveChanges();
                        }
                        else
                        {
                            ip = new REMOTE_INFO()
                            {
                                IPAddress = IpAddress,
                                Connection = textConnectionString,
                                UpdateTime = DateTime.Now,
                                ComputerName = hostname,
                                IsOnline = true
                            };
                            db.REMOTE_INFO.Add(ip);
                            db.SaveChanges();
                            
                        }
                        Port = ip.Id;
                        StartConnection();
                    }
                }
                catch (Exception)
                {
                    
                }

            }
        }
        private void CloseConnection()
        {
            listener.Stop();
            client.Close();
            STR.Close();
            STW.Close();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerSupportsCancellation = true;

        }
        private void StartConnection()
        {
            listener = new TcpListener(IPAddress.Any, Port);
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    if(recieve == null)
                    {
                        e.Result = "RESTART";
                        return;
                    }
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
                    WindowState = FormWindowState.Normal;
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
            if (MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
        }
        
        public Form1()
        {
            InitializeComponent();
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);
            WindowState = FormWindowState.Minimized;
            InitializeTimer();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect(currentSession);
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = e.Result as string;
            if (result == "RESTART")
            {
                CloseConnection();
                WindowState = FormWindowState.Minimized;
                StartConnection();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var db = new SOFTWAREEntities())
            {
                var ip = db.REMOTE_INFO.Where(m => m.IPAddress == IpAddress).FirstOrDefault();
                if (ip != null)
                {
                    ip.IsOnline = false;
                    db.SaveChanges();
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
