using CommonFunc;
using Simple_RDP_Client.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_RDP_Client
{
    public partial class Main : Form
    {
        private string IpAddress;
        private string NameComputer;
        private List<REMOTE_INFO> list;
        private List<REMOTE_INFO> listAll;
        public Main()
        {
            InitializeComponent();
            lblVersion.Text = CommonFunc.Utils.GetRunningVersion();
            using (var db = new SOFTWAREEntities())
            {
                listAll = db.REMOTE_INFO.Where(m => m.IsOnline == true).ToList();
                list = listAll;
                dgrvList.DataSource = list;
                dgrvList.Refresh();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txbNameComputer.Text))
                {
                    lblStatus.Text = "Nhập tên máy tính";
                    lblStatus.ForeColor = Color.Maroon;
                    txbNameComputer.Focus();
                    txbNameComputer.SelectAll();
                    return;
                }
                if (Utils.ValidateIPv4(txbNameComputer.Text))
                {
                    IpAddress = txbNameComputer.Text.Trim();
                }
                else
                {
                    IpAddress = Utils.GetIPAddressFrom(txbNameComputer.Text.Trim());
                    NameComputer = txbNameComputer.Text.Trim();

                    if (string.IsNullOrEmpty(IpAddress))
                    {
                        lblStatus.Text = "Không tìm thấy tên máy tính!";
                        lblStatus.ForeColor = Color.Maroon;
                        txbNameComputer.Focus();
                        txbNameComputer.SelectAll();
                        return;
                    }
                }
                if (timer != null && timer.Enabled)
                {
                    timer.Stop();
                }
                InitializeTimer();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to the Server");
            }
        }

        Timer timer;
        int i = 0;
        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(Timer_Tick);
            pgBConnecting.Maximum = 100;
            pgBConnecting.Step = 1;
            pgBConnecting.Value = 0;
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            i = i + 20;
            if (i > 100)
            {
                i = 0;
            }
            pgBConnecting.Value = i;
            using (var db = new SOFTWAREEntities())
            {
                var ip = db.REMOTE_INFO.Where(m => (m.IPAddress == IpAddress || m.ComputerName.ToLower() == NameComputer.ToLower()) && m.IsOnline == true).FirstOrDefault();
                var list = db.REMOTE_INFO.ToList();
                if (ip != null && !string.IsNullOrEmpty(ip.Connection))
                {
                    Form1 form = new Form1(ip);
                    form.closed += () =>
                    {
                        Show();
                    };
                    form.Show();

                    timer.Stop();
                    i = 1;
                    Hide();
                }
            };

        }

        private void Main_Load(object sender, EventArgs e)
        {
            panelTitle.Paint += new PaintEventHandler(panelTitle_Paint);
            panelTitle.Refresh();
            panelContent.BackColor = Color.FromArgb(10, Color.Maroon);
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(panelTitle.Size.Width, panelTitle.Height);
            LinearGradientBrush lgb =
               new LinearGradientBrush(new Rectangle()
               {
                   Location = startPoint,
                   Size = panelTitle.Size
               }, Color.FromArgb(50, Color.Maroon), Color.White, LinearGradientMode.Vertical);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, panelTitle.Size.Width, panelTitle.Size.Height);
        }

        private void dgrvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var s = list.ElementAt(e.RowIndex);
                    txbNameComputer.Text = s.ComputerName;
                   
                    btnConnect.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void txbNameComputer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                list = listAll.Where(m => m.ComputerName.ToLower().Contains(txbNameComputer.Text.ToLower()) || m.IPAddress.Contains(txbNameComputer.Text)).ToList();
                dgrvList.DataSource = list;
                dgrvList.Refresh();
            }
        }

        private void txbNameComputer_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }
    }
}
