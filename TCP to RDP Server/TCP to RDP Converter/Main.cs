using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_to_RDP_Converter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                InitializeTimer();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to the Server");
            }
        }

        Timer timer;
        int i = 1;
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
            lblTick.Text = i.ToString();
            i++;
            using (var db = new SOFTWAREEntities())
            {
                var ip = db.REMOTE_INFO.Where(m => m.IPAddress == txtIpAddress.Text.Trim()).OrderByDescending(m => m.UpdateTime).FirstOrDefault();
                if (ip != null && !string.IsNullOrEmpty(ip.Connection))
                {
                    var form = new Form1(ip.Connection);
                    form.Show();
                    timer.Stop();
                    i = 1;
                }

            };

        }

    }
}
