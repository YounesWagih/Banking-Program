using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - 473, this.Location.Y);
        }

        private void EixtPic_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }

        private async void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (Signup.users[SignIn.ID].cash < int.Parse(textBox1.Text))
            {
                MessageBox.Show("U R Very POOOOOOOR");
            }
            else
            {
                Signup.users[SignIn.ID].cash -= int.Parse(textBox1.Text);
                textBox1.Text = "";
                int x = (int)(2 * SignIn.wcnt);
                SignIn.wcnt++;
                Task t = Task.Run(() => { new SpeechSynthesizer().Speak($"please go to withdraw queue .. remain {x} min "); });

                Signup.users[SignIn.ID].Deposite_q = true;
                for (int i = 0; i < SignIn.wcnt; i++)
                {

                    Task wait3sec = Task.Run(async delegate { await Task.Delay(120000); }); // wait 2 min
                    await wait3sec;

                }

                NotifyIcon notifyIcon1 = new NotifyIcon();
                notifyIcon1.Icon = SystemIcons.Information;
                //Task wait2sec = Task.Run(async delegate { await Task.Delay(2000); }); // wait 2 sec
                notifyIcon1.BalloonTipTitle = "Deposit Queue";
                notifyIcon1.BalloonTipText = "Remain 20 Seconds";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000);


                MessageBox.Show("Go , its your time");
                SignIn.wcnt--;
                Signup.users[SignIn.ID].Deposite_q = false;
            }
        }
    }
}
