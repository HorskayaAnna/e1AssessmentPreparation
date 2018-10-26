using Onliner.Test.Automation.Framework.Web.Controls;
using OpenQA.Selenium;


namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public class Header
    {
        private TextBox searchLine = new TextBox(By.XPath("//input[@class='fast-search__input']"));
        private ElementsList list = new ElementsList(By.XPath("//div[@class='product__offers__wrapper']"));

        public Header SendText(string paramName)
        {
            searchLine.IsVisible();
            searchLine.SendKeys(paramName);
            return this;
        }

        public void ChoseElement(string paramName)
        {
            list.ClickElement(paramName);           
        }
    }
}
