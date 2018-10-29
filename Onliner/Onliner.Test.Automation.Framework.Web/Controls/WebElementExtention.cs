using OpenQA.Selenium;

namespace Onliner.Controls
{
    static class WebElementExtention
    {
        public static void JsClick(this IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browser._driver;
            executor.ExecuteScript("arguments[0].click();", Element);
        }
    }
}
