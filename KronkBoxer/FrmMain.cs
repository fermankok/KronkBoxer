using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace KronkBoxer
{
    public partial class FrmMain : Form
    {
        public List<Keys> keysToSend = new List<Keys>() { Keys.W, Keys.A, Keys.S, Keys.D, Keys.Enter, Keys.Q, Keys.E, Keys.R };
        public List<Panel> panels = new List<Panel>();
        public List<Client> clients = new List<Client>();
        public int running = 0; //0 = stopped, 1 = running, 2 = paused

        public FrmMain()
        {
            InitializeComponent();

            //Panels available for clients to be parented to
            panels.Add(splitTop.Panel1);
            panels.Add(splitTop.Panel2);
            panels.Add(splitBottom.Panel1);
            panels.Add(splitBottom.Panel2);
            numClients.Maximum = panels.Count;
            //Load config
            numClients.Value = Config.Default.numClients;
            tbxClientPath.Text = Config.Default.clientPath;
        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;

            if (running == 1 && keysToSend.Contains(e.KeyCode))
            {
                foreach (Client c in clients)
                    Native.SendDown(c.clientProcess, e.KeyCode);
            }
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;

            if (running == 1 && keysToSend.Contains(e.KeyCode))
            {
                foreach (Client c in clients)
                    Native.SendUp(c.clientProcess, e.KeyCode);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Client c in clients)
            {
                if (!c.clientProcess.HasExited)
                    c.clientProcess.Kill();
            }

            Config.Default.numClients = (int)numClients.Value;
            Config.Default.clientPath = tbxClientPath.Text;
            Config.Default.Save();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (running == 0) //start
            {
                if (!File.Exists(tbxClientPath.Text))
                {
                    MessageBox.Show("Invalid file path chosen for the client to be used.", "KronkBoxer");
                    return;
                }

                btnToggle.ImageIndex = 1;
                btnToggle.BackColor = Color.FromArgb(220, 0, 0);

                int count = (int)numClients.Value;

                for (int i = 0; i < count; i++)
                {
                    clients.Add(new Client(panels[i], tbxClientPath.Text));
                }

                running = 1;
                lblStatus.Text = "Running [" + clients.Count + "]";
            }
            else //stop
            {
                btnToggle.ImageIndex = 0;
                btnToggle.BackColor = Color.FromArgb(60, 170, 60);

                foreach (Client c in clients)
                {
                    if (!c.clientProcess.HasExited)
                        c.clientProcess.Kill();
                }
                clients.Clear();

                running = 0;
                lblStatus.Text = "Stopped";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (running == 1) //running
            {
                btnPause.BackColor = Color.FromArgb(190, 108, 30);
                running = 2;
                lblStatus.Text = "Paused [" + clients.Count + "]";
            }
            else if (running == 2) //paused
            {
                btnPause.BackColor = Color.FromArgb(220, 128, 30);
                running = 1;
                lblStatus.Text = "Running [" + clients.Count + "]";
            }
        }

        private PerformanceCounter perfCPU =
            new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private void tmrChecker_Tick(object sender, EventArgs e)
        {
            lblPerformance.Text = "CPU " + (int)perfCPU.NextValue() + "%  |  RAM: ";

            for (int i = 0; i < clients.Count; i++)
            {
                if (!clients[i].clientProcess.HasExited)
                {
                    lblPerformance.Text += "[" + i + "] " + clients[i].clientProcess.PeakWorkingSet64 / 1024 / 1024 + "mb   :   ";
                }
            }

            lblPerformance.Location = new Point(this.Width - 50 - lblPerformance.Size.Width, lblPerformance.Location.Y);
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void btnClientBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();

            if (FD.ShowDialog() == DialogResult.OK)
                tbxClientPath.Text = FD.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Client c in clients)
                Native.SendString(c.clientProcess, "poop");
        }
    }
}
