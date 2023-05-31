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
    public partial class SignIn : Form
    {
        Signup obj = new Signup();
        public static int ID , dcnt=1 , wcnt=1 , ccnt=1  ;
        public static string Name;
        public static Queue<string> deposit_Q = new Queue<string>();
        public static Queue<string> Withdraw_Q = new Queue<string>();
        public static Queue<string> CustomerServ_Q = new Queue<string>();
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = false;
            foreach (var item in Signup.UserId)
            {
                if (item.Key == Nametxt.Text)
                {
                    f = true;break;
                }
            }
            if (f&&Passwordtxt.Text == Signup.users[Signup.UserId[Nametxt.Text]].password)
            {
                ID = Signup.UserId[Nametxt.Text];
                service_form serviceForm = new service_form();
                Name = Nametxt.Text;
                this.Hide();
                serviceForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password Please Try Again.");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj.Show();
        }


        private void EixtPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
