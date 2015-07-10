using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Livestreamer;

namespace Livestreamer_App_Tests
{
    [TestClass]
    public class LivestreamerTests
    {
        [TestMethod]
        public void GetClipboardTest()
        {
            Core livestreamer = new Core();
            Clipboard.SetText("hallo");
            Assert.AreEqual("hallo", livestreamer.GetClipboard());
            Clipboard.SetText("du hundesohne");
            Assert.AreEqual("du hundesohne", livestreamer.GetClipboard());
        }
    }
}
