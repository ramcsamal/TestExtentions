using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using TestExtentions.Common.Base;
using TestExtentions.Common.Base.Message;
using OpenQA.Selenium.Support.PageObjects;
namespace TestExtentions.Common.Base.Section
{
    public abstract class SectionObject : ISectionObject
    {
        public  IMessageObject MessageObject { get; set; }
        public  IWebDriver Driver { get; set; }
        public  ExtentReports TestReport { get; set; }
        public  ExtentTest TestLogWriter { get; set; }
        public SectionObject(IWebDriver webDriver, ExtentReports extentReports, ExtentTest extentTest)
        {
            Driver = webDriver;
            TestReport = extentReports;
            TestLogWriter = extentTest;
            PageFactory.InitElements(webDriver, this);
        }
        private SectionObject()
        {
            // DONOT Allow SectionObject Class Directly.
        }
    }
}
