using System;
using System.Windows.Forms;
using AxRDPCOMAPILib;

namespace Simple_RDP_Client
{
    public partial class Form1 : Form
    {
        public Action closed;
        public Form1(string connection)
        {
            InitializeComponent();
            Connect(connection, this.axRDPViewer, "", "");
        }

        public static void Connect(string invitation, AxRDPViewer display, string userName, string password)
        {
            try
            {
                display.Connect(invitation, userName, password);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static void disconnect(AxRDPViewer display)
        {
            try
            {
                display.Disconnect();
            }catch(Exception e)
            {
              
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                closed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
