using Onliner.Test.Automation.Framework.Web.Controls;
using OpenQA.Selenium;
using System.Text;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public class LoginForm
    {
        public TextBox login = new TextBox(By.CssSelector("input[data - field = login]"));
        public TextBox password = new TextBox(By.CssSelector("input[type=password]"));
        public Button submit = new Button(By.XPath("//button[@type='submit']"));

        public void Update(string loginData, string passwordData)
        {
            login.SendKeys(loginData);
            password.SendKeys(passwordData);
            //return this;
        }

        public void Submit()
        {
            submit.Click();
        }

        public bool IsSubmitClickable() => submit.IsClickable();
        public bool IsLoginTextBoxVisible() => login.IsVisible();
        public bool IsPassTextBoxVisible() => password.IsVisible();
    }
}
