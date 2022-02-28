using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Telegrom
{
    public class LocalStorage
    {
        private Dictionary<string, object> items;
        private IWebDriver browser;
        private IJavaScriptExecutor scriptExecutor;
        private string allData;

        public LocalStorage(Model model)
        {
            this.browser = model.Browser;
            this.SetJSExecutor(this.browser);
            this.items = new Dictionary<string, object>();
        }

        public void Clear()
        {
            this.items.Clear();
            this.allData = string.Empty;
        }

        public void GetItems()
        {
            var localStorage = (Dictionary<string, object>)this.scriptExecutor.ExecuteScript("return localStorage;");
            localStorage.Remove("clear");
            localStorage.Remove("length");
            localStorage.Remove("removeItem");
            localStorage.Remove("getItem");
            localStorage.Remove("key");
            localStorage.Remove("setItem");

            this.allData = JsonConvert.SerializeObject(localStorage);
        }

        public int Length()
        {
            var num = Convert.ToInt32(this.scriptExecutor.ExecuteScript("return localStorage.length;", Enumerable.Empty<object>()).ToString());
            return num;
        }

        public void LoadItems(string path)
        {
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string str = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<Dictionary<string, object>>(str);
            }
        }

        public void SaveItem(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
                writer.Write(this.allData);

            this.items = new Dictionary<string, object>();
            this.Clear();
        }

        public void SetItems()
        {
            foreach (KeyValuePair<string, object> pair in this.items)
            {
                object[] args = new object[] { pair.Key, pair.Value };
                this.scriptExecutor.ExecuteScript("localStorage.setItem(arguments[0], arguments[1]);", args);
            }
            this.Clear();
        }

        private void SetJSExecutor(IWebDriver browser)
        {
            this.browser = browser;
            this.scriptExecutor = browser as IJavaScriptExecutor;
        }

        public string AllData
        {
            get { return this.allData; }

            set
            {
                this.allData = value;
            }
        }
    }
}

