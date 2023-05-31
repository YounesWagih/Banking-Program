using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class service_form : Form
    {
        public int depositCounter = 0;
        public service_form()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            debosit d = new debosit();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Withdraw w = new Withdraw();
            w.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountSettings AccSet = new AccountSettings();
            AccSet.Show();
            this.Hide();
        }

        private void service_form_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private async void CustomerService_Click(object sender, EventArgs e)
        {
            SignIn.CustomerServ_Q.Enqueue(SignIn.Name);
            int x = (int)(2 * SignIn.ccnt);
            SignIn.ccnt++;
            //Task t = Task.Run(() => { new SpeechSynthesizer().Speak($"please Mr {SignIn.CustomerServ_Q.Dequeue()}  go to Customer service queue .. remain {x} min "); });

            Signup.users[SignIn.ID].Deposite_q = true;
            NotifyIcon notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Information;
            //Task wait2sec = Task.Run(async delegate { await Task.Delay(2000); }); // wait 2 sec
            notifyIcon1.BalloonTipTitle = "Customer service Queue";
            notifyIcon1.BalloonTipText = "Remain 20 Seconds";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000);
            for (int i = 0; i < SignIn.ccnt; i++)
            {
                //Task wait3sec = Task.Run(async delegate { await Task.Delay(120000); }); // wait 2 min

                Task wait3sec = Task.Run(async delegate { await Task.Delay(5000); }); // wait 10 sec
                await wait3sec;

            }
            Task ea = Task.Run(() => { new SpeechSynthesizer().Speak($"its your time mr {SignIn.CustomerServ_Q.Peek()}  go to Customer service queue "); });
            ea.Wait();
            MessageBox.Show($"Go {SignIn.CustomerServ_Q.Dequeue()} , its your time");

            SignIn.ccnt--;
            Signup.users[SignIn.ID].Deposite_q = false;
        }

        private void EixtPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnPic_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }
    }
}
