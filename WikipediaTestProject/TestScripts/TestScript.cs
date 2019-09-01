using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikipediaTestProject.Framework;

namespace WikipediaTestProject.TestScripts
{
    [TestClass]
    public class TestScript : TestBase
    {
        [TestMethod]
        public void TestCase()
        {
            ////        1.Open the page https://en.wikipedia.org/wiki/... [This test is done in the Test Base Class Initialization]
            PageFactory.PageIndex.WikiPageSelenium.WaitForPageToLoad();

            ////        2.Verify that the external links in “External links“ section work
            PageFactory.PageIndex.WikiPageSelenium.ClickAssayLink();
            PageFactory.PageIndex.ExternalPageSelenium.VerifyPageLoaded();


            ////        3.Click on the “Oxygen” link on the Periodic table at the bottom of the page



            ////        4.Verify that it is a “featured article”


            ////        5.Take a screenshot of the right hand box that contains element properties


            ////        6.Count the number of pdf links in “References“


            ////        7.In the search bar on top right enter “pluto” and verify that the 2 nd suggestio is “Plutonium”
        }
    }
}
