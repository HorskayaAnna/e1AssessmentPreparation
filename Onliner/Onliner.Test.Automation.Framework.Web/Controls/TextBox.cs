using OpenQA.Selenium;

namespace Onliner.Test.Automation.Framework.Web.Controls
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SendKeys(string Data)
        {
            Element.SendKeys(Data);
        }
    }
}
