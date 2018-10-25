using OpenQA.Selenium;
using System;

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

        public bool IsClickable()
        {
            try
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(Locator));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
