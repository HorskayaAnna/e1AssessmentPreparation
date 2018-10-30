using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.BO.Pages
{
    public class LoginPage
    {
        public LoginForm LoginForm
        {
            set
            {
                if (LoginForm == null)
                {
                    LoginForm = new LoginForm();
                }
            }
            get
            {
                return LoginForm;
            }
        }

        public void LoginIn(string login, string password)
        {
            LoginForm.Update(login, password).Submit();
        }
    }
}
