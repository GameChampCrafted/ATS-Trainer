using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmericanTruckSimulatorTrainer
{
    public partial class Form1 : Form
    {
        #region Drag Window -> Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public Form1()
        {
            InitializeComponent();
            Thread ProcessThread = new Thread(new ThreadStart(CheckProcessThread));
            ProcessThread.Start();

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Globals.foundgame)
            {
                lb_procname.Text = "amtrucks.exe";
                lb_procid.Text = Globals.proc.Id.ToString();
                lb_status.Text = "Game detected.";
                if (!Globals.enabled)
                {
                    b_status.Text = "Game found, click to enable";
                }
                else
                {
                    b_status.Text = "Trainer Enabled, click to disable";
                }
            }
            else
            {
                lb_procname.Text = "Not Found";
                lb_procid.Text = "0";
                lb_status.Text = "No game detected.";
                b_status.Text = "Game not found, trainer is waiting.";
            }
        }

        public static void CheckProcessThread()
        {
            while (true)
            {
                //Check for game process
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.MainWindowTitle == "American Truck Simulator")
                    {
                        Globals.proc = p;
                        Globals.foundgame = true;
                    }
                }
                Thread.Sleep(1000);
            }
        }

        private void b_status_MouseClick(object sender, MouseEventArgs e)
        {
            Globals.enabled = !Globals.enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();
            new Trainer().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
