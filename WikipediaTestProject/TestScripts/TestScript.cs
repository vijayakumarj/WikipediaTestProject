using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WikipediaTestProject.Framework;

namespace WikipediaTestProject.TestScripts
{
    [TestClass]
    public class TestScript : TestBase
    {
        [TestMethod]
        public void TestCase()
        {
            ScreenshotHandler screenshotHandler = new ScreenshotHandler();
            try
            {
                ////        1.Open the page https://en.wikipedia.org/wiki/... [This test is done in the Test Base Class Initialization]
                PageFactory.PageIndex.WikiPageSelenium.WaitForPageToLoad();

                ////        2.Verify that the external links in “External links“ section work
                PageFactory.PageIndex.WikiPageSelenium.ClickAssayLink();
                PageFactory.PageIndex.ExternalPageSelenium.VerifyPageLoaded();
                PageFactory.PageIndex.ExternalPageSelenium.GoBackToPreviousPage();
                PageFactory.PageIndex.WikiPageSelenium.WaitForPageToLoad();

                ////        3.Click on the “Oxygen” link on the Periodic table at the bottom of the page
                PageFactory.PageIndex.WikiPageSelenium.ClickOxygenLink();

                ////        4.Verify that it is a “featured article”
                PageFactory.PageIndex.WikiPageOxygen.VerifyPageLoaded();
                PageFactory.PageIndex.WikiPageOxygen.VerifyFeaturedArticleDisplayed();

                ////        5.Take a screenshot of the right hand box that contains element properties

                ////        6.Count the number of pdf links in “References“
                var numberOfLinks = PageFactory.PageIndex.WikiPageOxygen.CountPDFReferences();

                ////        7.In the search bar on top right enter “pluto” and verify that the 2 nd suggestio is “Plutonium”
                PageFactory.PageIndex.WikiHeader.EnterTextInSearchBox("pluto");
                PageFactory.PageIndex.WikiHeader.VerifySecondSuggestion("Plutonium");
            }
            catch (Exception exception)
            {
                ReportError(exception);
            }
        }
    }
}
