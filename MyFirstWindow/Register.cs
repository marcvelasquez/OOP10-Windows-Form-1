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
    public partial class Register : MaterialForm
    {
        Login login;

        public Register(Login login)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.login = login;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
            this.Close();
        }

        private void registerConfirmButton_Click(object sender, EventArgs e)
        {
            string getRealName = registerTextboxFirstName.Text + " " + registerTextboxLastName.Text;
            string getEmail = registerTextBoxEmail.Text;
            string getUsername = registerTextboxUsername.Text;

            if (registerPassword.Text == registerReenterPassword.Text)
            {
                login.realName = getRealName;
                login.username = getUsername;
                login.email = getEmail;
                login.password = registerPassword.Text;

                this.Hide();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password did not match");
                return;
            }
        }
    }
}
