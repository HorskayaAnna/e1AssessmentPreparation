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

        public LoginForm Update(string loginData, string passwordData)
        {
            login.SendKeys(loginData);
            password.SendKeys(passwordData);
            return this;
        }

        public void Submit()
        {
            submit.Click();
        }

        public bool IsSubmitClickable
        {
            get
            {
                return submit.IsClickable();
            }
        }

        public bool IsLoginTextBoxVisible
        {
            get
            {
                return login.IsVisible();
            }
        }

        public bool IsPassTextBoxVisible
        {
            get
            {
                return password.IsVisible();
            }
        }

    }
}
