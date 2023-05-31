using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            UserName.Text = Signup.users[SignIn.ID].name;
            UserPassword.Text = Signup.users[SignIn.ID].password;
            UserCash.Text = Signup.users[SignIn.ID].cash.ToString();
        }

        private void ChngPass_Click(object sender, EventArgs e)
        {
            ChangePasswordcs chn = new ChangePasswordcs();
            chn.Show();
            this.Hide();
        }

        private void UserCash_Click(object sender, EventArgs e)
        {
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void EixtPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnPic_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }
    }
}
