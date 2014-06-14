using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KronkBoxer
{
    public class Client
    {
        public Process clientProcess;
        public Control parent;

        public Client(Control parent, string path)
        {
            this.parent = parent;
            this.clientProcess = Native.LoadProcessInControl(path, parent);

            parent.Resize += parent_Resize;
        }

        void parent_Resize(object sender, EventArgs e)
        {
            Native.ReMaximize(clientProcess);
        }
    }
}
