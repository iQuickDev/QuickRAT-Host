using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace QuickRAT_Host
{
    public partial class Terminal : UserControl
    {
        private bool isCmdStarted = false;
        public Terminal()
        {
            InitializeComponent();
            terminalsendbtn.Click += SendCmd;
        }
        private void StartCmd()
        {
            String command = "startcmd";
            //loopSend(command);
            isCmdStarted = true;
        }

        private void SendCmd(object sender, EventArgs e)
        {
            String cmd = "procstart|" + terminalcommandfield.Text;
            //loopSend(cmd);
        }
    }
}
