using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace WindowsFormsApp2
{
    public partial class debosit : Form
    {
       
        public debosit()
        {
            InitializeComponent();
        }

        private void debosit_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X+473, this.Location.Y);
        }

        private async void DepositeBtn_Click(object sender, EventArgs e)
        {
            Signup.users[SignIn.ID].cash += int.Parse(textBox1.Text);
            textBox1.Text = "";
            //MessageBox.Show("Done");
            int x =(int)(2 * SignIn.dcnt);
            SignIn.dcnt++;
            Task t = Task.Run(() => { new SpeechSynthesizer().Speak($"please go to deposit queue .. remain {x} min "); });

            Signup.users[SignIn.ID].Deposite_q = true ;
            for (int i = 0; i < SignIn.dcnt; i++)
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
            SignIn.dcnt--;
            Signup.users[SignIn.ID].Deposite_q = false;
        }

        private void EixtPic_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }



    }
}
