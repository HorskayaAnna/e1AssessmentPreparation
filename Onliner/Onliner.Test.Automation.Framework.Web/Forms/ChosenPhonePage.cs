using OpenQA.Selenium;
using Onliner.Test.Automation.Framework.Web.Controls;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public class ChosenPhonePage : BasePage
    {
        private Lable title = new Lable(By.XPath("//h1[@class='catalog-masthead__title']"));
        public string Title => title.Text;
    }
}
