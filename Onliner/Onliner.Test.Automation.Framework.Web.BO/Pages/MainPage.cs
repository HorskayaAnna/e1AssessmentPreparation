using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.BO.Pages
{
    public class MainPage
    {
        public Header Header
        {
            set
            {
                if (Header == null)
                {
                    Header = new Header();
                }
            }
            get
            {
                return Header;
            }
        }

        public ChosenPhonePage ChosenPhonePage
        {
            set
            {
                if (ChosenPhonePage == null)
                {
                    ChosenPhonePage = new ChosenPhonePage();
                }
            }
            get
            {
                return ChosenPhonePage;
            }
        }
    }
}
