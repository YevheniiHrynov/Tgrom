namespace Telegrom
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;

    public class Model
    {
        private IWebDriver browser;
        private LocalStorage locStor;
        private List<Account> accounts;
        private string pathToInitFile = "init.txt";
        private AccountManager accountManager;
        private Spammer spammer;

        public Model()
        {
            this.OpenBrowser();
            this.accounts = new List<Account>();
            this.locStor = new LocalStorage(this);
            this.accountManager = new AccountManager(this);
            this.spammer = new Spammer(this);
            this.Initialize();
        }

        public void Initialize()
        {
            if (File.Exists(this.pathToInitFile))
            {
                foreach (string str in File.ReadAllLines(this.pathToInitFile))
                {
                    this.accounts.Add(new Account(str));
                }
            }
            DirectoryInfo info = new DirectoryInfo("Accounts");
            if (!info.Exists)
            {
                info.Create();
            }
        }

        public void OpenBrowser()
        {
            this.browser = new ChromeDriver();
            this.browser.Manage().Window.Size = new Size(300, 900);
            this.browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60.0);
            this.browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180.0);
            this.browser.Navigate().GoToUrl("https://web.telegram.org/k/");
        }

        public AccountManager AccountManager =>
            this.accountManager;

        public IWebDriver Browser =>
            this.browser;

        public List<Account> Accounts =>
            this.accounts;

        public LocalStorage LocStor =>
            this.locStor;

        public IJavaScriptExecutor Jse =>
            (this.browser as IJavaScriptExecutor);

        public Spammer Spammer
        {
            get { return this.spammer; }

            set { this.spammer = value; }
        }
    }
}

