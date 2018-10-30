using NUnit.Framework;
using Onliner.Test.Automation.Framework.Web.Objects;


namespace Onliner.Test.Automation.Framework.Web.Tests
{
    public class BaseTest
    {

        [SetUp]
        public void InitTest()
        {
            Browser.Navigate(ConfigurationManager.AppSettings["StartUrl"]);
        }

        [TearDown]
        public void CleanTest()
        {
            Browser.Quit();
        }
    }
}
