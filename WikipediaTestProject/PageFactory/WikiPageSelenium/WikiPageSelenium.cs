using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WikipediaTestProject.Framework;

namespace WikipediaTestProject.PageFactory.WikiPageSelenium
{
    public class WikiPageSelenium
    {
        #region Elements
        IWebElement PageLoadElement
        {
            get { return Framework.Framework.webDriver.FindElement(By.Id("firstHeading")); }
        }
        IWebElement LinkOxygen
        {
            get { return Framework.Framework.webDriver.FindElement(By.XPath("//table[@aria-describedby='periodic-table-legend']//a[@href='/wiki/Oxygen']")); }
        }
        IWebElement LinkAssay
        {
            get { return Framework.Framework.webDriver.FindElement(By.XPath("//a[@href='http://www.sas-centre.org/assays/trace_metals/selenium.html']")); }
        }

        #endregion

        #region Operations
        public void ClickAssayLink()
        {
            LinkAssay.Click();
        }

        public void WaitForPageToLoad()
        {
            Framework.Framework.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            if (!PageLoadElement.Displayed)
            {
                throw new Exception("Page is not loaded in 30 seconds");
            }
        }

        public void ClickOxygenLink()
        {
            LinkOxygen.Click();
        }
        #endregion
    }
}
