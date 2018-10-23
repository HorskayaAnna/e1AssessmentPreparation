using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public abstract class BaseForm
    {
        protected Browser _browser;
        public By Locator { get; private set; }

        protected BaseForm(By Locator, Browser browser)
        {
            this.Locator = Locator;
            this._browser = browser;
        }
    }
}
