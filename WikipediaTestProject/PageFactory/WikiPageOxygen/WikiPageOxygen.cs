using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WikipediaTestProject.PageFactory.WikiPageOxygen
{
    public class WikiPageOxygen
    {
        #region Elements
        IWebElement PageLoadElement
        {
            get { return Framework.Framework.webDriver.FindElement(By.XPath("//h1[@id='firstHeading' and contains(.,'Oxygen')]")); }
        }
        IWebElement LinkFeaturedArticle
        {
            get { return Framework.Framework.webDriver.FindElement(By.XPath("//a[@href='/wiki/Wikipedia:Featured_articles']")); }
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

        public void VerifyFeaturedArticleDisplayed()
        {
            Framework.Framework.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            if (!PageLoadElement.Displayed)
            {
                throw new Exception("Element not loaded in 60 seconds");
            }
        }

        public int CountPDFReferences()
        {
            IReadOnlyList<IWebElement> elements = Framework.Framework.webDriver.FindElements(By.XPath("//div[@class='reflist columns references-column-width'][2]//ol[@class='references']//li/span[contains(.,'PDF')]"));
            if(elements.Count != 0)
            {
                return elements.Count;
            }
            return 0;
        }
        #endregion
    }
}
