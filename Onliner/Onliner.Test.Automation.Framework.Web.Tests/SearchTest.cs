using NUnit.Framework;
using Onliner.Test.Automation.Framework.Web.Forms;

namespace Onliner.Test.Automation.Framework.Web.Tests
{
    [TestFixture]
    public class SearchTest : BaseTest
    {
        [Test]
        public void Search()
        {
            Header header = new Header();
            header.SendText("iphone");
            header.ChoseElement("Смартфон Apple iPhone SE 32GB Space Gray");
            string expected = "Смартфон Apple iPhone SE 32GB Space Gray";
            string actual = header.GetTitle();
            Assert.AreEqual(actual, expected);
        }
    }
}
