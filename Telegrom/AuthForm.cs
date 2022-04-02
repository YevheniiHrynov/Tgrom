using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TL;

namespace Telegrom
{
    public partial class AuthForm : Form
    {
        private Model model;
        private TelegromForm main;

        public AuthForm()
        {
            InitializeComponent();
        }

        public AuthForm(TelegromForm f)
        {
            this.InitializeComponent();
            this.main = f;
            this.model = f.Model;
            this.FillAccList();
            if (this.model.AccountManager.ActivePhone != null)
            {
                this.lblActivePhone.Text = "+" + this.model.AccountManager.ActivePhone;
            }
            else
            {
                this.lblActivePhone.Text = "";
            }
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.main.Show();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            this.model.AccountManager.LogIn(this.lblChangedPhone.Text.Substring(1));
            this.model.AccountManager.ActivePhone = this.lblChangedPhone.Text.Substring(1);
            this.lblActivePhone.Text = "+" + this.model.AccountManager.ActivePhone;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.model.Jse.ExecuteScript("localStorage.clear();", Enumerable.Empty<object>());
            }
            catch (Exception)
            {
            }
            this.model.Browser.Navigate().Refresh();
            
            this.btnSend.Enabled = true;
            this.inputPhone.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.model.AccountManager.DelAcc(this.lblChangedPhone.Text.Substring(1));
            this.lblChangedPhone.Text = "";
            this.listAcc.Items.Clear();
            this.FillAccList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.inputCode.Text.Length != 5)
            {
                MessageBox.Show("Incorrect code!!!");
            }
            else
            {
                this.model.AccountManager.SetCode(this.inputCode.Text);
                this.tick.Start();
            }
        }

        static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return "9243364";
                case "api_hash": return "5e1d44ce28e3193b2751755ef8031341";
                case "phone_number": return "+380507750819";
                case "verification_code": Console.Write("Code: "); return Console.ReadLine();
                //case "first_name": return "John";      // if sign-up is required
                //case "last_name": return "Doe";        // if sign-up is required
                //case "password": return "secret!";     // if user has enabled 2FA
                default: return null;                  // let WTelegramClient decide the default config
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var client = new WTelegram.Client(Config);
            //    var my = client.LoginUserIfNeeded().Result;
            //    var d = my.access_hash;
            //    ;
            //}
            //catch (Exception)
            //{

            //}


            if (this.model.Browser.Url != "https://web.telegram.org/k/")
            {
                this.btnSend.Enabled = false;
                this.inputPhone.Enabled = false;
            }
            //else if (this.inputPhone.Text.Length != 12)
            //{
            //    MessageBox.Show("Incorrect number!!!");
            //}
            else
            {
                this.model.AccountManager.SetPhone(this.inputPhone.Text);
                this.inputCode.Enabled = true;
                this.btnLogin.Enabled = true;
            }
        }

        public void FillAccList()
        {
            for (int i = 0; i < this.model.Accounts.Count; i++)
            {
                this.listAcc.Items.Add("+" + this.model.Accounts[i].ToString());
            }
        }

        private void listAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listAcc.SelectedItem != null)
            {
                this.lblChangedPhone.Text = this.listAcc.SelectedItem.ToString();
                this.btnActivate.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (this.model.AccountManager.IsAll())
            {
                this.model.AccountManager.AddAcc(this.inputPhone.Text.Replace(" ", ""));
                this.listAcc.Items.Clear();
                this.FillAccList();
                this.lblActivePhone.Text = "+380" + this.model.AccountManager.ActivePhone;
                this.inputCode.Text = "";
                this.inputPhone.Text = "";
                this.inputPhone.Enabled = false;
                this.inputCode.Enabled = false;
                this.btnLogin.Enabled = false;
                this.btnSend.Enabled = false;
                this.tick.Stop();
            }
        }
    }
}

