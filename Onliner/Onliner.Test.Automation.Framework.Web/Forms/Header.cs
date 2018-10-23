using Onliner.Test.Automation.Framework.Web.Controls;
using OpenQA.Selenium;


namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public class Header
    {
        private TextBox searchLine = new TextBox(By.XPath("//input[@class='fast-search__input']"));

        public void SendText()
        {
            searchLine.SendKeys("iphone");
        }
    }
}
