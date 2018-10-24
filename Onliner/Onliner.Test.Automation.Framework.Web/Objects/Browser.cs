using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Onliner.Test.Automation.Framework.Web.Objects
{
    public class Browser
    {
        public static Browser instance;
        public static IWebDriver _driver;
        public static IWebDriver Driver => _driver;

        private Browser()
        {
            _driver = CreateBrowser.GetDriver(CreateBrowser.Browsers.Chrome);
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

        public IWebElement FindElement(By locator)
        {

            return _driver.FindElement(locator);

        }

        public IEnumerable<IWebElement> FindElements(By locator)
        {

            return _driver.FindElements(locator);

        }
    }

}