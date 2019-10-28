using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using TestExtentions.Common.Base.Message;
using OpenQA.Selenium.Support.PageObjects;

namespace TestExtentions.Common.Base.Page
{
    public abstract class PageObject : IPageObject
    {
        public  IMessageObject MessageObject { get; set; }
        public  IWebDriver Driver { get; set; }
        public  ExtentReports TestReport { get; set; }
        public  ExtentTest TestLogWriter { get; set; }

        public PageObject(IWebDriver webDriver, ExtentReports extentReports, ExtentTest extentTest)
        {
            Driver = webDriver;
            TestReport = extentReports;
            TestLogWriter = extentTest;
            PageFactory.InitElements(webDriver, this);
        }
        private PageObject()
        {
            // DONOT Allow SectionObject Class Directly.
        }
    }
}
