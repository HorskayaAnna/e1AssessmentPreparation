using Onliner.Test.Automation.Framework.Web.Controls;
using OpenQA.Selenium;


namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public class Header
    {
        private TextBox searchLine = new TextBox(By.XPath("//input[@class='fast-search__input']"));
        private ElementsList list = new ElementsList(By.XPath("//div[@class='product__offers__wrapper']"));
        private Lable title = new Lable(By.XPath("//h1[@class='catalog-masthead__title']"));

        public void SendText(string paramName)
        {
            searchLine.SendKeys(paramName);
        }

        public void ChoseElement(string paramName)
        {
            list.ClickElement(paramName);
        }

        public string Title => title.Text;
    }
}
