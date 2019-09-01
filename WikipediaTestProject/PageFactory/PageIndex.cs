using System;
using System.Collections.Generic;
using System.Text;

namespace WikipediaTestProject.PageFactory
{
    public class PageIndex
    {
        public static WikiPageSelenium.WikiPageSelenium WikiPageSelenium { get { return new WikiPageSelenium.WikiPageSelenium(); } }
        public static WikiPageSelenium.ExternalPageSelenium ExternalPageSelenium { get { return new WikiPageSelenium.ExternalPageSelenium(); } }
        public static WikiPageOxygen.WikiPageOxygen WikiPageOxygen  { get { return new WikiPageOxygen.WikiPageOxygen(); } }
    }
}
