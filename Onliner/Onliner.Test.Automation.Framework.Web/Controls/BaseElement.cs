﻿using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;


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

        public void Submit()
        {
            Element.Submit();
        }

        public void WaitForIsVisible()
        {
            Wait.Until(ExpectedConditions.ElementExists(Locator));
        }

        public bool IsVisible()
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

        public void JsClick()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browser._driver;
            executor.ExecuteScript("arguments[0].click();", this.Element);
        }

    }

}
