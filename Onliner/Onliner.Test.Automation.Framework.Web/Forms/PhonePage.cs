using OpenQA.Selenium;
using Onliner.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onliner.Test.Automation.Framework.Web.Controls;

namespace Onliner.Test.Automation.Framework.Web.Forms
{
    public class PhonePage
    {
        private Lable title = new Lable(By.XPath("//h1[@class='catalog-masthead__title']"));
        public string Title => title.Text;
    }
}
