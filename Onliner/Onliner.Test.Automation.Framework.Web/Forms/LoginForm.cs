using Onliner.Test.Automation.Framework.Web.Controls;
using OpenQA.Selenium;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    class LoginForm
    {
        public TextBox login = new TextBox(By.CssSelector("input[data - field = login]"));
        public TextBox password = new TextBox(By.CssSelector("input[type=password]"));
        public Button submit = new Button(By.XPath("//button[@type='submit']"));

        public void inputData(string loginData, string passwordData)
        {
            login.SendKeys(loginData);
            password.SendKeys(passwordData);
        }

        public void clickSubmit()
        {
            submit.Click();
        }

        public bool isSubmitClickable() => submit.IsClickable();
        public bool isLoginTextBoxVisible() => login.IsVisible();
        public bool isPassTextBoxVisible() => password.IsVisible();
    }
}
