using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Drawing;


namespace Onliner.Test.Automation.Framework.Web.Controls
{
    public abstract class BaseElement
    {
        protected string Name;
        protected By Locator;

        public IWebElement Element
        {
            get
            {
                return Browser.Instance.FindElement(Locator);
            }
            private set
            {
                Element = value;
            }
        }
        public string TagName => Element.TagName;
        public string Text => Element.Text;
        public bool Selected => Element.Selected;
        public bool Enabled => Element.Enabled;
        public Point Location => Element.Location;
        public Size Size => Element.Size;
        public bool Displayed => Element.Displayed;

        public void Clear()
        {
            Element.Clear();
        }

        public void SendKeys(string text)
        {
            Element.SendKeys(text);
        }

        public void Submit()
        {
            Element.Submit();
        }

        public string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            return Element.GetProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            return Element.GetCssValue(propertyName);
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

        public IWebElement FindElement(By locator)
        {
            return Element.FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return Element.FindElements(locator);
        }

        public void Click()
        {
            Element.Click();
        }

        public void JsClick()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browser._driver;
            executor.ExecuteScript("arguments[0].click();", this.Element);
        }

    }

}
