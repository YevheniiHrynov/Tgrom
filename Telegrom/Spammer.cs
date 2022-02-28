using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Telegrom
{
    public class Spammer
    {
        private IWebDriver browser;
        private List<string> logins;
        private List<Account> accounts;
        private AccountManager accountManager;
        private int delay;
        private int iter;
        private string txt;

        public Spammer(Model model)
        {
            this.browser = model.Browser;
            this.accounts = model.Accounts;
            this.accountManager = model.AccountManager;
            this.logins = new List<string>();
        }

        public IWebElement FindElement(By selector)
        {
            IWebElement element = null;
            try
            {
                element = this.browser.FindElement(selector);
            }
            catch (Exception)
            {
                return null;
            }
            return element;
        }

        public void GetArgsForThread(string txt, int delay, int iter)
        {
            this.txt = txt;
            this.delay = delay;
            this.iter = iter;
        }

        public void LoadLogins()
        {
            string path = string.Empty;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Текстовые файлы|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                }
            }
            if (path != "")
            {
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    string str2;
                    while ((str2 = reader.ReadLine()) != null)
                    {
                        this.logins.Add(str2);
                    }
                }
            }
        }

        public void SendMes(string txt)
        {
            this.browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.0);
            try
            {
                this.FindElement(By.ClassName("im_start_btn")).Click();
            }
            catch (Exception)
            {
            }
            try
            {
                this.FindElement(By.ClassName("composer_rich_textarea")).SendKeys(txt + OpenQA.Selenium.Keys.Enter);
            }
            catch (Exception)
            {
            }
            this.browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60.0);
        }

        public void Spamming()
        {
            int index;
            int num2 = 0;
            if (this.accountManager.ActivePhone != null)
            {
                index = this.accountManager.Accounts.IndexOf(new Account(this.accountManager.ActivePhone));
            }
            else
            {
                index = 0;
                this.accountManager.LogIn(this.accountManager.Accounts[index].ToString());
            }
            while (true)
            {
                foreach (string str in this.logins)
                {
                    if (num2 == this.iter)
                    {
                        index++;
                        if (index > (this.accountManager.Accounts.Count - 1))
                        {
                            index = 0;
                        }
                        this.accountManager.LogIn(this.accountManager.Accounts[index].ToString());
                        num2 = 0;
                    }
                    string url = "https://web.telegram.org/#/im?p=" + str;
                    this.browser.Navigate().GoToUrl(url);
                    if (this.browser.Url == url)
                    {
                        this.SendMes(this.txt);
                        num2++;
                        Thread.Sleep((int)(this.delay * 0x3e8));
                    }
                    else
                    {
                        this.accountManager.Accounts.RemoveAt(index);
                        if (index <= (this.accountManager.Accounts.Count - 1))
                        {
                            this.accountManager.LogIn(this.accountManager.Accounts[index].ToString());
                        }
                    }
                }
            }
        }

        public List<string> Logins =>
            this.logins;
    }
}

