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
            header.SendText();
        }
    }
}
