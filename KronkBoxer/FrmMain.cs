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
        static readonly List<Keys> keysToSend = new List<Keys>() { Keys.W, Keys.A, Keys.S, Keys.D };
        public List<Client> clients = new List<Client>();

        public FrmMain()
        {
            InitializeComponent();
        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnToggle_Click(object sender, EventArgs e)
        {

        }
    }
}
