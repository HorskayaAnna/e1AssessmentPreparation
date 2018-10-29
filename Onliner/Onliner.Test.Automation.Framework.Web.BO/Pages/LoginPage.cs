using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.BO.Pages
{
    public class LoginPage
    {
        public LoginForm LogForm { get; }

        private LoginForm LoginForm()
        {
            get
            {
            if (LoginForm == null)
            {
                loginForm = new LoginForm();
            }
                return loginForm;
            }
        }

        public void LoginIn(string login, string password)
        {
            LogForm.Update(login, password).Submit();
        }
    }
}
