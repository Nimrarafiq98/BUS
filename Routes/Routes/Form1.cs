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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            foreach (MyUser m in dataclass.dc)
            {
                {
                    if (m.Username == txtUsername.Text)
                    {
                        MessageBox.Show("please enter a unique Username");
                    }
                }
            }
             if (txtPassword.Text!="" &&  txtUsername.Text!="")
            {
                MyUser u = new MyUser();
                u.Username = txtUsername.Text;
                u.Passward = txtPassword.Text;
                dataclass.dc.Add(u);
                MessageBox.Show("You are registered");
                 
            }
            
            
            else
            {
                MessageBox.Show("Please Enter name and passward");
            }
         }
           

        private void lnklbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form1 registration = new Form1();
            this.Hide();
            registration.Show();
        }
    }
}
