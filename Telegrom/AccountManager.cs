using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Telegrom
{
    public class AccountManager
    {
        private IWebDriver browser;
        private LocalStorage locStor;
        private List<Account> accounts;

        public AccountManager(Model model)
        {
            this.browser = model.Browser;
            this.locStor = model.LocStor;
            this.accounts = model.Accounts;
        }

        public void AddAcc(string phone)
        {
            Account item = new Account(phone);
            this.locStor.GetItems();
            this.locStor.SaveItem(item.Path);
            this.accounts.Add(item);
            using (StreamWriter writer = new StreamWriter(new FileStream("init.txt", FileMode.Append, FileAccess.Write)))
            {
                writer.WriteLine(phone);
                writer.Close();
            }
            this.ActivePhone = phone;
        }

        public void DelAcc(string phone)
        {
            for (int i = 0; i < this.accounts.Count; i++)
            {
                if (this.accounts[i].ToString() == phone)
                {
                    this.accounts.RemoveAt(i);
                }
            }
            File.Delete("Accounts/" + phone + ".txt");
            List<string> list = new List<string>(File.ReadAllLines("init.txt"));
            list.Remove(phone);
            File.WriteAllLines("init.txt", list.ToArray());
            this.ActivePhone = null;
        }

        public bool IsAll() =>
            (this.locStor.Length() > 11);

        public void LogIn(string phone)
        {
            this.locStor.LoadItems("Accounts/" + phone + ".txt");
            this.locStor.SetItems();
            this.browser.Navigate().Refresh();
            this.ActivePhone = phone;
        }

        public void SetCode(string c)
        {
            this.browser.FindElement(By.XPath("//input[@type='tel']")).SendKeys(c + Keys.Enter);
        }

        public void SetPhone(string p)
        {
            this.browser.FindElement(By.XPath("//*[contains(text(), 'Log in by phone Number')]"))?.FindElement(By.XPath("./..")).Click();
            this.browser.FindElement(By.ClassName("input-field-phone"))?.FindElement(By.TagName("div")).SendKeys(Keys.Backspace);
            this.browser.FindElement(By.ClassName("input-field-phone"))?.FindElement(By.TagName("div")).SendKeys(Keys.Backspace);
            this.browser.FindElement(By.ClassName("input-field-phone"))?.FindElement(By.TagName("div")).SendKeys(Keys.Backspace);
            this.browser.FindElement(By.ClassName("input-field-phone"))?.FindElement(By.TagName("div")).SendKeys(Keys.Backspace);
            this.browser.FindElement(By.ClassName("input-field-phone"))?.FindElement(By.TagName("div")).SendKeys(Keys.Backspace);
            this.browser.FindElement(By.ClassName("input-field-phone"))?.FindElement(By.TagName("div")).SendKeys(p);
            this.browser.FindElement(By.XPath("//*[contains(text(), 'Next')]"))?.FindElement(By.XPath("./..")).Click();
        }

        public string ActivePhone { get; set; }

        public List<Account> Accounts =>
            this.accounts;
    }
}

