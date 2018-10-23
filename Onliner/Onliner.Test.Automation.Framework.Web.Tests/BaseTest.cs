using NUnit.Framework;
using Onliner.Test.Automation.Framework.Web.Objects;


namespace Onliner.Test.Automation.Framework.Web.Tests
{
    public class BaseTest
    {
        protected static Browser browser;

        [SetUp]
        public void InitTest()
        {
            browser = Browser.instance;
            Browser.Navigate("www.onliner.by");
        }

        [TearDown]
        public void CleanTest()
        {
            Browser.Quit();
        }
    }
}
