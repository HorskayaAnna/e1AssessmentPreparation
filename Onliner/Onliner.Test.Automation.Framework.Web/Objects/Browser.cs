﻿using OpenQA.Selenium;
using System;

namespace Onliner.Test.Automation.Framework.Web.Objects
{
    public class Browser
    {
        public static Browser instance;
        public static IWebDriver _driver;
        public static IWebDriver Driver => _driver;
        public static int ImplWait;

        private Browser()
        {
            ImplWait = Convert.ToInt32(ConfigurationManager.AppSettings["ImplicitWait"]);
            _driver = CreateBrowser.GetDriver(BrowserNameToEnum);
        }

        public CreateBrowser.Browsers BrowserNameToEnum
        {
            get
            {
                CreateBrowser.Browsers browserName;
                Enum.TryParse(ConfigurationManager.AppSettings["Browser"], out browserName);
                return browserName;
            }
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