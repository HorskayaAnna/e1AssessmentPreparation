using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.BO
{
    public class LoginPage
    {
        public LoginForm Form { get; }

        public LoginPage()
        {
            Form = new LoginForm();
        }

        public void LoginIn(string login, string password)
        {
            Form.Update(login, password);
            Form.Submit();
        }
    }
}
