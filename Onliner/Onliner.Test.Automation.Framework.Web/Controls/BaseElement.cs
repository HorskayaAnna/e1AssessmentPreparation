using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Onliner.Test.Automation.Framework.Web.Controls
{
    public abstract class BaseElement
    {
        protected string Name;
        protected By Locator;
        public WebDriverWait Wait
        {
            get
            {
                return new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(Browser.ImplWait));
            }
        }

        public IWebElement Element
        {
            get
            {
                return Browser.Driver.FindElement(Locator);
            }
            private set
            {
                Element = value;
            }
        }
        public string Text => Element.Text;

        public void WaitForIsVisible()
        {
            Wait.Until(ExpectedConditions.ElementExists(Locator));
        }

        public bool IsVisible
        {
            get
            {
                try
                {
                    Wait.Until(ExpectedConditions.ElementIsVisible(Locator));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public BaseElement(By locator)
        {
            this.Locator = locator;
        }

        public BaseElement(By locator, string name)
        {
            this.Locator = locator;
            this.Name = name;
        }

        public void Click()
        {
            Element.Click();
        }
    }

}
