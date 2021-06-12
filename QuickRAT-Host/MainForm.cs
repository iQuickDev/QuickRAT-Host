using System; 
using System.Drawing; 
using System.Windows.Forms; 
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace QuickRAT_Host
{
    public partial class MainForm : Form
    {
        internal int serverPort = 100;
 
        internal ServerManagement serverManagement = new ServerManagement();
        internal ScreenView screenView = new ScreenView();
        internal SystemControl systemControl = new SystemControl();
        internal DDos ddos = new DDos();
        internal Processes processes = new Processes();
        internal Fun fun = new Fun();
        internal Terminal terminal = new Terminal();

        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        public MainForm()
        {
            InitializeComponent();
            dragpanel.MouseMove += dragpanel_MouseMove;
            dragpanel.MouseDown += dragpanel_MouseDown;
            dragpanel.MouseUp += dragpanel_MouseUp;
            title.MouseMove += title_MouseMove;
            title.MouseDown += title_MouseDown;
            title.MouseUp += title_MouseUp;
            minimizebtn.Click += minimize;
            closebtn.Click += close;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            servermanagementbtn.Click += ServerManagementPopup;
            screenviewbtn.Click += ScreenViewPopup;
            processesbtn.Click += ProcessesPopup;
            systemcontrolbtn.Click += SystemControlPopup;
            terminalbtn.Click += TerminalPopup;
            funbtn.Click += FunPopup;
            ddosbtn.Click += DDosPopup;

            ddos.Parent = screenView.Parent = processes.Parent = systemControl.Parent = terminal.Parent = fun.Parent = serverManagement.Parent = this;
            serverManagement.Location = screenView.Location = processes.Location = systemControl.Location = terminal.Location = fun.Location = ddos.Location = new Point(0, 105);
        }

        private void ServerManagementPopup(object sender, EventArgs e)
        {
            serverManagement.BringToFront();
        }

        private void ScreenViewPopup(object sender, EventArgs e)
        {
            screenView.BringToFront();
        }

        private void ProcessesPopup(object sender, EventArgs e)
        {
            processes.BringToFront();
        }

        private void SystemControlPopup(object sender, EventArgs e)
        {
            systemControl.BringToFront();
        }

        private void TerminalPopup(object sender, EventArgs e)
        {
            terminal.BringToFront();
        }

        private void FunPopup(object sender, EventArgs e)
        {
            fun.BringToFront();
        }

        private void DDosPopup(object sender, EventArgs e)
        {
            ddos.BringToFront();
        }

        private void minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region draggable panel

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void dragpanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void dragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void dragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
    }
}
