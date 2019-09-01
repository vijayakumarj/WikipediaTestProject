using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace WikipediaTestProject.Framework
{
    public class TestBase
    {
        [AssemblyInitialize]
        public void InitializeAssembly(TestContext context)
        {
            //Not Yet Implemented
        }
        [TestInitialize]
        public void TestInitialize()
        {
            ////        Initializing the browser and Navigating to the website
            Framework.webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Framework.webDriver.Url = "https://en.wikipedia.org/wiki/Selenium";
            Framework.webDriver.Navigate();
            Framework.webDriver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void TestCleanup()
        {

            Framework.webDriver.Quit();
        }

        public void ReportError(Exception exception)
        {
            throw exception;
        }
    }
}
