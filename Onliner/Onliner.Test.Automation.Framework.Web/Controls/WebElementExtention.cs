using Onliner.Test.Automation.Framework.Web.Objects;
using OpenQA.Selenium;

namespace Onliner.Test.Automation.Framework.Web.Controls
{
    static class WebElementExtention
    {
        public static void JsClick(this IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browser._driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }
    }
}
