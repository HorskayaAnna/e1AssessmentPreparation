using NUnit.Framework;
using Onliner.Test.Automation.Framework.Web.BO.Pages;
using Onliner.Test.Automation.Framework.Web.BO;

namespace Onliner.Test.Automation.Framework.Web.Tests
{
    [TestFixture]
    public class OnlinerSearchTests : BaseTest
    {
        [OneTimeSetUp]
        public void LoginIn()
        {
            OnlinerBO.Page<LoginPage>().LoginIn(ConfigurationManager.AppSettings["Email"], ConfigurationManager.AppSettings["Password"]);
        }

        [Test]
        public void SearchTest()
        {
            string stringToSearch = "Iphone";
            string expectedTitle = "Смартфон Apple iPhone SE 32GB Space Gray";
            OnlinerBO.Page<MainPage>().Header.SendText(stringToSearch).ChoseElement(expectedTitle);
            Assert.AreEqual(OnlinerBO.Page<MainPage>().ChosenPhonePage.Title, expectedTitle);
        }
    }
}
