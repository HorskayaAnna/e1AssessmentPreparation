using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Onliner.Test.Automation.Framework.Web.Objects
{
    public class Browser
    {
        public static Browser instance;
        public static IWebDriver _driver;
        public static IWebDriver Driver => _driver;
        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(TimeoutForElement));
        public static int ImplWait;

        private Browser()
        {
            ImplWait = Convert.ToInt32(ConfigurationManager.AppSettings["ImplicitWait"]);
            _driver = CreateBrowser.GetDriver(BrowserNameToEnum());
        }

        public CreateBrowser.Browsers BrowserNameToEnum()
        {
            CreateBrowser.Browsers browserName;
            Enum.TryParse(ConfigurationManager.AppSettings["Browser"], out browserName);
            return browserName;
        }

        public static Browser Instance => instance ?? (instance = new Browser());

        public string GetPageTitle
        {
            get
            {
                return _driver.Title;
            }
        }

        public static void Navigate(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            if (_driver == null) return;

            _driver.Quit();
            _driver = null;
        }
    }

}