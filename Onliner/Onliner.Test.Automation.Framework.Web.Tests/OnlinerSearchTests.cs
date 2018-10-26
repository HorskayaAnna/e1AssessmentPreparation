using NUnit.Framework;
using Onliner.Test.Automation.Framework.Web.BO;

namespace Onliner.Test.Automation.Framework.Web.Tests
{
    [TestFixture]
    public class OnlinerSearchTests : BaseTest
    {
        [SetUp]
        public void LoginIn()
        {
            OnlinerBO.Page<LoginPage>().LoginIn("horskaya.anna@gmail.com", "123qweasdzxc");
        }

        [Test]
        public void SearchTest()
        {
            string stringToSearch = "Iphone";
            string expectedTitle = "Смартфон Apple iPhone SE 32GB Space Gray";
            OnlinerBO.Page<MainPage>().Header.SendText(stringToSearch).ChoseElement(expectedTitle);
            Assert.AreEqual(OnlinerBO.Page<MainPage>().ChosenPhone.Title, expectedTitle);
        }
    }
}
