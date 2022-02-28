using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Telegrom
{
    public partial class SpammerForm : Form
    {
        private Model model;
        private TelegromForm main;
        private Thread spammingThread;
       
        public SpammerForm(TelegromForm f)
        {
            this.InitializeComponent();
            this.main = f;
            this.model = f.Model;
            for (int i = 0; i < this.model.Accounts.Count; i++)
            {
                this.comBoxActAcc.Items.Add("+380" + this.model.Accounts[i].ToString());
            }
            if (this.model.AccountManager.ActivePhone != null)
            {
                this.comBoxActAcc.SelectedItem = "+380" + this.model.AccountManager.ActivePhone;
            }
            else
            {
                this.comBoxActAcc.SelectedItem = "";
            }
        }

        private void btnLoadLogins_Click(object sender, EventArgs e)
        {
            this.model.Spammer.LoadLogins();
            foreach (string str in this.model.Spammer.Logins)
            {
                this.listLogins.Items.Add(str);
            }
        }

        private void btnStartSpam_Click(object sender, EventArgs e)
        {
            if ((this.messageBox.Text == "") || (this.messageBox.Text == "Your message"))
            {
                MessageBox.Show("You have not entered a message!!!");
            }
            else
            {
                this.model.Spammer.GetArgsForThread(this.messageBox.Text, decimal.ToInt32(this.numOfDelay.Value), decimal.ToInt32(this.numOfMesToChange.Value));
                this.spammingThread = new Thread(new ThreadStart(this.model.Spammer.Spamming));
                this.spammingThread.Start();
                this.timer.Start();
                foreach (Control control in base.Controls.Cast<Control>())
                {
                    control.Enabled = (control.Name == this.btnStopSpam.Name) ? !control.Enabled : !control.Enabled;
                }
            }
        }

        private void btnStopSpam_Click(object sender, EventArgs e)
        {
            this.spammingThread.Abort();
            this.spammingThread.Join();
            this.timer.Stop();
            foreach (Control control in base.Controls.Cast<Control>())
            {
                control.Enabled = (control.Name == this.btnStopSpam.Name) ? !control.Enabled : !control.Enabled;
            }
        }

        private void comBoxActAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.model.AccountManager.LogIn(this.comBoxActAcc.SelectedItem.ToString().Substring(4));
        }

        private void messageBox_Enter(object sender, EventArgs e)
        {
            if (this.messageBox.Text == "Your message")
            {
                this.messageBox.Text = null;
                this.messageBox.ForeColor = Color.Black;
            }
        }

        private void messageBox_Leave(object sender, EventArgs e)
        {
            if (this.messageBox.Text == "")
            {
                this.messageBox.Text = "Your message";
                this.messageBox.ForeColor = Color.Gray;
            }
        }

        private void SpammerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.spammingThread != null)
            {
                this.spammingThread.Abort();
                this.spammingThread.Join();
            }
            this.main.Show();
        }

        private void SpammerForm_Load(object sender, EventArgs e)
        {
            this.messageBox.Text = "Your message";
            this.messageBox.ForeColor = Color.Gray;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.model.AccountManager.ActivePhone != null)
            {
                this.comBoxActAcc.SelectedItem = "+380" + this.model.AccountManager.ActivePhone;
            }
            else
            {
                this.comBoxActAcc.SelectedItem = "";
            }
        }
    }
}
