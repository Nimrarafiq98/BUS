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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void cmdRegistration_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool isvalid;
            bool isvalidPassed;
            server.isvalid(txtUsername.Text, txtPassword.Text,comboBox1.Text, out isvalid, out isvalidPassed);
            if (isvalid)
            { MessageBox.Show(" valid");

                    Addnum add = new Addnum();
                    this.Hide();
                    add.Show();
                
                if (comboBox1.Text== "user")
                {
                    Search search = new Search();
                    this.Hide();
                    search.Show();
                    MessageBox.Show("valid");
                }
                
            }
            else
            {
                MessageBox.Show("invalid user!");
            }

            
            
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registration = new Form1();
            this.Hide();
            registration.Show();
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset reset = new Reset();
            this.Hide();
            reset.Show();
        }

        private void lnkAddnum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void nimraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            this.Hide();
            reg.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void signUpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            this.Hide();
            reg.Show();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            this.Hide();
            info.Show();
        }
    }
}
