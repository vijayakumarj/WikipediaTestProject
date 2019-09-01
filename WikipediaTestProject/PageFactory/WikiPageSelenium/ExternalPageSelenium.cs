using OpenQA.Selenium;
using System;

namespace WikipediaTestProject.PageFactory.WikiPageSelenium
{
    public class ExternalPageSelenium
    {
        #region Elements
        IWebElement PageLoadElement
        {
            get { return Framework.Framework.webDriver.FindElement(By.Id("wrapper")); }
        }

        #endregion

        #region Operations
        public void VerifyPageLoaded()
        {
            Framework.Framework.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            if (!PageLoadElement.Displayed)
            {
                throw new Exception("Page is not loaded in 30 seconds");
            }
        }
        #endregion
    }
}
