using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MyFirstWindow
{
    public partial class Login : MaterialForm
    {
        public string realName = "John Doe";
        public string email = "admin@email.com";
        public string username = "admin";
        public string password = "admin";
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm(this);
            mainform.Show();
        }
    }
}
