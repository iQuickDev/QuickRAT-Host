using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRAT_Host
{
    public class Connection
    {
        public static string IP;
        public static int port = 100;
        public static TcpClient client;
        public static TcpListener server;
        public static bool isOnline = false;

        private static string GetIP()
        {
            string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            MessageBox.Show(externalIpString);
            return externalIpString;
        }

        private void StartListening(object sender, EventArgs e)
        {
            new Thread((StartListening) =>
            {
                server = new TcpListener(IPAddress.Any, port);
                while (!client.Connected)
                {
                    server.Start();
                    client = server.AcceptTcpClient();
                }
            }).Start();
        }

        private void StopListening(object sender, EventArgs e)
        {
            server.Stop();
            client = null;
        }
    }
}
