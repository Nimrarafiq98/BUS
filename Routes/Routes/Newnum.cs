﻿using System;
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
    public partial class Newnum : Form
    {
        private Server.Route blogToShow;
        public Newnum()
        {
            InitializeComponent();
        }
        public Newnum(Server.Route post)
        {
            InitializeComponent();
            blogToShow = post;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmdAddnum_Click(object sender, EventArgs e)
        {
            {
                Server.Service1 server = new Server.Service1();
                bool update;
                bool updatePassed;
                server.update(txtOldbus.Text, txtOldroute.Text, txtBusNumber.Text, txtRouteNumber.Text, out update, out updatePassed);
                if (update)
                {
                    MessageBox.Show("route updated");
                }
                else
                {
                    MessageBox.Show("route not founded .Please enter valid bus number and route number");
                }
            }
        }
    }
}

