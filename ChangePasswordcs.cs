using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApp2
{
    public partial class ChangePasswordcs : Form
    {
        public ChangePasswordcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)          
        {
            if(ChngePassword.Text==Signup.users[SignIn.ID].password)
            {
                Signup.users[SignIn.ID].password = NewPassword.Text;
            }
            else
            {
                MessageBox.Show("Unsucceful Operation.");
            }
            AccountSettings A = new AccountSettings();
            this.Hide();
            A.Show();
        }

        private void ChangePasswordcs_Load(object sender, EventArgs e)
        {

        }

        private void EixtPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnPic_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[2].Show();
        }
    }
}
