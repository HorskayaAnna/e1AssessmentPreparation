using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public abstract class BasePage
    {
        public By Locator { get; private set; }

        protected BasePage(By Locator)
        {
            this.Locator = Locator;
        }
    }
}
