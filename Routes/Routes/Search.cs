using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routes
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool searchpick;
            bool searchpickpassed;
            server.searchpick(txtPickup.Text, out searchpick, out searchpickpassed);
         
        }
    }
}
