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

namespace TCP_to_RDP_Converter
{
    public partial class Form1 : Form
    {
        public static RDPSession currentSession = null;
        public static void createSession()
        {
            currentSession = new RDPSession();
        }

        public static void Connect(RDPSession session)
        {
            session.OnAttendeeConnected += Incoming;
            session.Open();
        }

        public static void Disconnect(RDPSession session)
        {
            session.Close();
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
                    }
                }
                catch (Exception)
                {
                    
                }

            }
        }

        /// <summary>
        /// Handle the form items
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect(currentSession);
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
    }
}
