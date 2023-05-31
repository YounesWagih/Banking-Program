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

    public partial class Signup : Form
    {
        public static Dictionary<string, int> UserId = new Dictionary<string, int>();
        public static user[] users = new user[1000];
        public static int CurrId=1;
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100, 0, 0, 0);

            for (int i = 0; i < 1000; i++)
            {
                users[i] = new user();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            users[CurrId].name = Nametxt.Text;
            UserId[users[CurrId].name] = CurrId;
            users[CurrId].cash =int.Parse(Cashtxt.Text);
            users[CurrId++].password = Passwordtxt.Text;
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EixtPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnPic_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
    public class user
    {
        public int cash;
        public string name, password;
        public bool Deposite_q;
        public bool Withdraw_q;
        public bool CustmerService_q;
        public user()
        {
            password = name = "";
            cash = 0;
            Deposite_q = false;
            Withdraw_q = false;
            CustmerService_q = false;
        }

    }
}

