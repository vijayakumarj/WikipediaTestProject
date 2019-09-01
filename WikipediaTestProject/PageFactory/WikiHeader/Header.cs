using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WikipediaTestProject.PageFactory.WikiHeader
{
    public class Header
    {
        #region Elements
        IWebElement PageLoadElement
        {
            get { return Framework.Framework.webDriver.FindElement(By.XPath("//h1[@id='firstHeading' and contains(.,'Oxygen')]")); }
        }
        IWebElement TextSeacrhBox
        {
            get { return Framework.Framework.webDriver.FindElement(By.Id("searchInput")); }
        }
        IWebElement LinkSuggestionPlutonium
        {
            get { return Framework.Framework.webDriver.FindElement(By.XPath("//div[@class='suggestions']//a[@title='Plutonium']")); }
        }
        #endregion

        #region Operations
        public void VerifyPageLoaded()
        {
            Framework.Framework.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            if (!PageLoadElement.Displayed)
            {
                throw new Exception("Page is not loaded in 60 seconds");
            }
        }

        public void EnterTextInSearchBox(string valueToEnter)
        {
            TextSeacrhBox.SendKeys(valueToEnter);
        }
        #endregion
    }
}
