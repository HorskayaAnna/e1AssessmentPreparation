using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onliner.Controls
{
    class WebElementExtention
    {
        public void JsClick()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browser._driver;
            executor.ExecuteScript("arguments[0].click();", this.Element);
        }
    }
}
