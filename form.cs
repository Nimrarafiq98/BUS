using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean isfound = false;
            foreach (NewUser u in UserDataClass.usersArrayList)
            {
                if (u.Username == txtUserName.Text && u.Password == txtPassword.Text)
                {
                    isfound = true;

                }

            }
            if (isfound)
            {
                MessageBox.Show("Valid User");

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
