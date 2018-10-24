using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public abstract class BaseForm
    {
        public By Locator { get; private set; }

        protected BaseForm(By Locator, Browser browser)
        {
            this.Locator = Locator;
        }
    }
}
