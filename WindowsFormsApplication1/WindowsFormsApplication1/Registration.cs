                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void cmdRegistration_Click(object sender, EventArgs e)
        {
            
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registration = new Form1();
            this.Hide();
            registration.Show();
        }

        }
    }

