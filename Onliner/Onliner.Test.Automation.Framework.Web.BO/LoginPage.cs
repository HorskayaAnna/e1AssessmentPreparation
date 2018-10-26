using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.BO
{
    public class LoginPage
    {
        public LoginForm LogForm { get; }

        public LoginPage()
        {
            LogForm = new LoginForm();
        }

        public void LoginIn(string login, string password)
        {
            LogForm.Update(login, password).Submit();
        }
    }
}
