using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using SimpleTCP;

namespace GCR_Student
{
    public partial class TeacherChat : Form
    {
        public TeacherChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherPanel tp = new TeacherPanel();
            this.Hide();
            tp.Show();
        }
        SimpleTcpServer server;

        private string GetLocalIPAddress()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Chat.Text += "Server Starting..";
            //IPAddress ip = IPAddress.Parse("192.168.100.8");
            //server.Start(ip, 80);
            
            IPAddress ip = IPAddress.Parse(GetLocalIPAddress());
            Console.WriteLine("Local IP Address: " + ip);

            server.Start(ip, 80);
        }
        
        private void btn_send_Click(object sender, EventArgs e)
        {
            server.Broadcast(string.Format("\nTeacher: {0}", txt_Msg.Text));
            txt_Chat.Text += Environment.NewLine;
            txt_Chat.Text += string.Format("Teacher: {0}", txt_Msg.Text);
        }

        private void TeacherChat_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += server_DataReceived;
            txt_Msg.Focus();
        }

        public void server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Chat.Invoke((MethodInvoker)delegate ()
            {
                txt_Chat.Text += Environment.NewLine;
                txt_Chat.Text += e.MessageString;
                e.ReplyLine(e.MessageString);
            });
        }
    }
}
