using OpenQA.Selenium;

namespace Onliner.Test.Automation.Framework.Web.Controls
{
    public class Button : BaseElement
    {
        public Button(By locator) : base(locator)
        {
        }

        public Button(By locator, string name) : base(locator, name)
        {
        }
    }
}
