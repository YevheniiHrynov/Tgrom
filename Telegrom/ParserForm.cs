using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegrom
{
    public partial class ParserForm : Form
    {
        private Model model;
        private TelegromForm main;
        private readonly string existTelegramPhonesFile = "existTelegramPhones.txt";
        private readonly string withoutTelegramPhonesFile = "withoutTelegramPhones.txt";
        private List<string> loadPhones;

        public ParserForm()
        {
            InitializeComponent();
        }

        public ParserForm(TelegromForm f)
        {
            this.InitializeComponent();
            btnStart.Enabled = false;
            this.main = f;
            this.model = f.Model;

            if (File.Exists(existTelegramPhonesFile))
            { 
                var existPhones = File.ReadAllLines(existTelegramPhonesFile);
                for (int i = 0; i < existPhones.Count(); i++)
                    this.existTelegramPhonesList.Items.Add($"{i + 1}. {existPhones[i]}");
            }
            else
            {
                File.Create(existTelegramPhonesFile);
            }

            if (File.Exists(withoutTelegramPhonesFile))
            {
                var withoutTelegram = File.ReadAllLines(withoutTelegramPhonesFile);
                for (int i = 0; i < withoutTelegram.Count(); i++)
                    this.withoutTelegramList.Items.Add($"{i+1}. {withoutTelegram[i]}");
            }
            else
            {
                File.Create(withoutTelegramPhonesFile);
            }
        }


        private void btnLoadDatabase_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Текстовые файлы|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.FileName;
            }
            if (path != string.Empty)
            {
                var existFiles = File.ReadAllLines(existTelegramPhonesFile);
                var withoutTelFiles = File.ReadAllLines(withoutTelegramPhonesFile);

                loadPhones = File.ReadAllLines(path).Select(i => i.Split('\t')[0]).ToList();
                loadPhones = loadPhones.Except(existFiles).Except(withoutTelFiles).Distinct().ToList();

                lblLost.Text = $"Lost: {loadPhones.Count}";
                btnStart.Enabled = true;
            }
        }

        private void ParserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.main.Show();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            new Task(async () =>
            {
                this.Invoke(new Action(() => { btnStart.Enabled = false; }));
                this.Invoke(new Action(() => { btnLoadDatabase.Enabled = false; }));

                AttemptGoToTheContacts();
                for (int i = 0; i < loadPhones.Count; i++)
                {
                    await AddContact(loadPhones[i]);
                    loadPhones.RemoveAt(i);
                    i--;
                    this.Invoke(new Action(() => { lblLost.Text = $"Lost: {loadPhones.Count}"; }));
                }
                this.Invoke(new Action(() => { btnStart.Enabled = true; }));
                this.Invoke(new Action(() => { btnLoadDatabase.Enabled = true; }));
            }).Start();
        }

        private void AttemptGoToTheContacts()
        {
            try
            {
                this.model.Browser.FindElement(By.ClassName("sidebar-header__btn-container")).Click();
                this.model.Browser.FindElement(By.XPath("//*[contains(text(), 'Contacts')]"))?.FindElement(By.XPath("./..")).Click();
            }
            catch (Exception e)
            {
            } 
        }

        private async Task AddContact(string phone)
        {
            await AttemptToEnterName(phone);
            await AttemtToEnterPhone(phone);
            await AttemptToCloseAddContact(phone);
        }

        private async Task AttemtToEnterPhone(string phone)
        {
            try
            {
                this.model.Browser.FindElement(By.XPath("//*[contains(text(), 'Phone Number')]")).FindElement(By.XPath("./..")).FindElement(By.XPath("./..")).Click();
                Actions setPhone = new Actions(this.model.Browser);
                setPhone.SendKeys(OpenQA.Selenium.Keys.Backspace + OpenQA.Selenium.Keys.Backspace + OpenQA.Selenium.Keys.Backspace + OpenQA.Selenium.Keys.Backspace + OpenQA.Selenium.Keys.Backspace + phone).Perform();
                await Task.Delay(750);
                this.model.Browser.FindElement(By.XPath("//*[text()='Add']"))?.FindElement(By.XPath("./..")).Click();
            }
            catch (Exception e)
            {
            }
        }

        private async Task AttemptToEnterName(string name)
        {
            try
            {
                this.model.Browser.FindElement(By.ClassName("tgico-add")).FindElement(By.TagName("div")).Click();
                this.model.Browser.FindElement(By.XPath("//*[contains(text(), 'First name (required)')]")).FindElement(By.XPath("./..")).FindElement(By.XPath("./..")).Click();
                Actions setName = new Actions(this.model.Browser);
                setName.SendKeys(name).Perform();
            }
            catch (Exception e)
            {
            }
        }

        private IWebElement GetElementSafety(Func<IWebElement> func)
        {

            try
            {
                return func();
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task AttemptToCloseAddContact(string phone)
        {
            try
            {
                await Task.Delay(1000);
                this.model.Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                var closeButton = GetElementSafety(() => { return this.model.Browser.FindElement(By.ClassName("popup-close")); });
                if (closeButton != null)
                {
                    await Task.Delay(2750);
                    closeButton = this.model.Browser.FindElement(By.ClassName("popup-close"));
                    closeButton.Click();
                    this.Invoke(new Action(() => { logsList.Items.Add($"Not: {phone}"); }));
                    File.AppendAllLines(withoutTelegramPhonesFile, new List<string>() { phone });
                    this.Invoke(new Action(() => { withoutTelegramList.Items.Add($"{withoutTelegramList.Items.Count + 1}. {phone}"); }));
                }
                else
                {
                    AddToExist(phone);
                }
            }
            catch (Exception e)
            {
                AddToExist(phone);
            }
            finally
            {
                this.model.Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            }
        }

        private void AddToExist(string phone)
        {
            if (!existTelegramPhonesList.Items.Contains(phone))
            {
                File.AppendAllLines(existTelegramPhonesFile, new List<string>() { phone });
                this.Invoke(new Action(() => { existTelegramPhonesList.Items.Add($"{existTelegramPhonesList.Items.Count + 1}. {phone}"); }));
                this.Invoke(new Action(() => { logsList.Items.Add($"Add: {phone}"); }));
            }
        }
    }
}
