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
        public List<Keys> keysToSend = new List<Keys>();
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
            tbxMainPlayer.Text = Config.Default.mainPlayer;
            
            foreach (string s in Config.Default.keysToSend.Split(','))
                if (s.Length > 0)
                    keysToSend.Add((Keys)Enum.Parse(typeof(Keys), s));
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

            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Config.Default.macroTPKey))
            {
                autoTP = 11;

                foreach (Client c in clients)
                    Native.SendString(c.clientProcess, "/teleport " + tbxMainPlayer.Text);
            }


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
            Config.Default.mainPlayer = tbxMainPlayer.Text;
            string temp = "";
            foreach (Keys key in keysToSend)
                temp += key.ToString() + ",";
            Config.Default.keysToSend = temp;

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

                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        clients.Add(new Client(panels[i], tbxClientPath.Text));
                    }
                }
                catch
                {
                    MessageBox.Show("You have not set .SWF files to open with Flash Player Projector.\nPlease download it from here:\nhttp://download.macromedia.com/pub/flashplayer/updaters/14/flashplayer_14_sa.exe\nAnd then set it to open with flashplayer_14_sa by right clicking your client and clicking Open With.");
                    clients.Clear();

                    btnToggle.ImageIndex = 0;
                    btnToggle.BackColor = Color.FromArgb(60, 170, 60);

                    return;
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
        int autoTP = 0;

        private void tmrChecker_Tick(object sender, EventArgs e)
        {
            //Performance
            lblPerformance.Text = "CPU " + (int)perfCPU.NextValue() + "%  |  RAM: ";

            for (int i = 0; i < clients.Count; i++)
            {
                if (!clients[i].clientProcess.HasExited)
                {
                    lblPerformance.Text += "[" + i + "] " + clients[i].clientProcess.PagedMemorySize64 / 1024 / 1024 + "mb   :   ";
                }
            }

            lblPerformance.Location = new Point(this.Width - 50 - lblPerformance.Size.Width, lblPerformance.Location.Y);

            //Auto TP
            
            if (autoTP > 0)
                autoTP--;

            lblTPCountdown.Text = "Able to teleport in " + autoTP + "...";

            if (autoTP == 0)
            {
                if (chkAutoTeleport.Checked && running == 1)
                {
                    autoTP = 11;

                    foreach (Client c in clients)
                        Native.SendString(c.clientProcess, "/teleport " + tbxMainPlayer.Text);
                }
            }
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

        private void btnConfigKeys_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter the names of any keys, seperated by commas, to be broadcasted to all clients when pressed.\n", "KronkBoxer Key Config", Config.Default.keysToSend, -1, -1);

            if (input != "")
            {
                try
                {
                    foreach (string s in input.Split(','))
                        if (s.Length > 0)
                            Enum.Parse(typeof(Keys), s);
                }
                catch
                {
                    MessageBox.Show("Input was invalid.\nPlease make sure you're using only valid names of keys and are seperating them with commas (NO SPACES).\n\nFor a list of key names, please refer to http://msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx", "KronkBoxer Key Config");
                    return;
                }
                Config.Default.keysToSend = input;
                Config.Default.Save();

                keysToSend.Clear();

                foreach (string s in Config.Default.keysToSend.Split(','))
                    if (s.Length > 0)
                        keysToSend.Add((Keys)Enum.Parse(typeof(Keys), s));
            }
        }

        private void btnEditMacros_Click(object sender, EventArgs e)
        {
            Config.Default.macroTPKey = Microsoft.VisualBasic.Interaction.InputBox("Please enter the key you wish to bind to the Teleport Macro", "KronkBoxer Key Config", Config.Default.macroTPKey, -1, -1);
            Config.Default.Save();
        }
    }
}
