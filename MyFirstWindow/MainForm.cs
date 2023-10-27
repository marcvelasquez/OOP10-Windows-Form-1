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
    public partial class MainForm : MaterialForm
    {
        Login login;
        public MainForm(Login login)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.login = login;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelMainWelcome.Text = "Welcome to Aincrad, " + login.realName;
            mainContent.Text = "Name: " + login.realName + "\nEmail: " + login.email + "\nUsername: " + login.username;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
            this.Close();
        }
    }
}
