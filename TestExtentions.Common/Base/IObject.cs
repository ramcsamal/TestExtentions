using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace TestExtentions.Common.Base
{
    public interface IObject
    {
        IWebDriver Driver { get; set; }
        ExtentReports TestReport { get; set; }
        ExtentTest TestLogWriter { get; set; }
    }
}
