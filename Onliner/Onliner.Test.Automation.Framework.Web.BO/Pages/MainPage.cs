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
        public Header header;
        public ChosenPhonePage chosenPhone;
        private Header Header()
        {
            get
            {
                if (Header == null)
                {
                   header  = new Header();
                }
                return header;
            }
        }
        private ChosenPhonePage ChosenPhonePage()
        {
            get
            {
                if (ChosenPhonePage == null)
                {
                    chosenPhone = new ChosenPhonePage();
                }
                return chosenPhone;
            }
        }
    }
}
