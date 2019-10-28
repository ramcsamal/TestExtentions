using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestExtentions.Common.Base.Message
{
    public abstract class MessageObject : IMessageObject
    {
      
       
        public  IWebDriver Driver { get; set; }
        public  ExtentReports TestReport { get; set; }
        public  ExtentTest TestLogWriter { get; set; }

        public abstract string AlertMessage { get; }
        public abstract void ClickOkButton();
        public abstract bool IsMessageVisible();



        public MessageObject(IWebDriver webDriver, ExtentReports extentReports, ExtentTest extentTest)
        {
            Driver = webDriver;
            TestReport = extentReports;
            TestLogWriter = extentTest;
            PageFactory.InitElements(webDriver, this);

        }
        private MessageObject()
        {
            // DONOT Allow SectionObject Class Directly.
        }
    }
}
