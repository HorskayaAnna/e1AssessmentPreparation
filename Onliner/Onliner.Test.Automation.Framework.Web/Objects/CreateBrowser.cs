using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace Onliner.Test.Automation.Framework.Web.Objects
{
    public class CreateBrowser
    {
        public enum Browsers
        {
            Chrome,
            Firefox,
            MicrosoftEdge
        }

        public static IWebDriver GetDriver(Browsers type)
        {
            IWebDriver driver = null;
            switch (type)
            {
                case Browsers.Chrome:
                    {
                        driver = new ChromeDriver();
                        break;
                    }

                case Browsers.Firefox:
                    {
                        driver = new FirefoxDriver();
                        break;
                    }
                case Browsers.MicrosoftEdge:
                    {
                        driver = new EdgeDriver();
                        break;
                    }
            }
            return driver;
        }

    }
}