using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.BO
{
    public class MainPage
    {
        public Header Header { get; }
        //public Header Header { get; set; }
        public PhonePage Phone { get; }

        public MainPage()
        {
            Header = new Header();
            Phone = new PhonePage();
        }

    }
}
