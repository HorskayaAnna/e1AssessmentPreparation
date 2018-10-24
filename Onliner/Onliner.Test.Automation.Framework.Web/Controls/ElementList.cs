using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Onliner.Test.Automation.Framework.Web.Controls
{
    public class ElementsList
    {
        private By locator;

        public List<IWebElement> Elements
        {
            get
            {
                return  Browser._driver.FindElements(locator).ToList() ;
            }
        }

        public ElementsList(By locator)
        {
            this.locator = locator;
        }

        public ElementsList(By locator, BaseElement parent, Browser browser)
        {
            this.locator = locator;
        }

        public void ClickElement(string elementName)
        {
            IWebElement element = Elements.FirstOrDefault(t => (t.Text) == (elementName));          
            element.Click();
        }
    }
}
