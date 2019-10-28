using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestExtentions.Validations.Contols
{
   public class DateValidation
    {
       public bool BlankDateField(IWebElement _element)
       {
           bool isValid = false;
           _element.SendKeys("");
           if (_element.Text == "")
               isValid = true;
           else
               isValid = false;

           return isValid;
       }

       public bool DefaultDateshouldbeCurrentDate(IWebElement _element)
       {
           bool isValid = false;
           var CurrentDate = DateTime.Now.ToString();
           if (_element.Text == "CurrentDate")
               isValid = true;
           else
               isValid = false;

           return isValid;
       }
       public bool SelectedDateShouldBeDisplayed(IWebElement _element, string Selectdate)
       {
           bool isValid = false;
         //  var Selectdate = "09-10-2018";
           _element.SendKeys("Selectdate");
           if (_element.Text != "")
               isValid = true;
           else
               isValid = false;

           return isValid;
       }
       public bool BackDateShouldBeAccepted(IWebElement _element, string Backdate)
       {
           bool isValid = false;
        //   var backdate = "09-10-2018";
           _element.SendKeys("Backdate");
           if (_element.Text != "")
               isValid = true;
           else
               isValid = false;

           return isValid;
       }
       public bool FutureDateShouldBeAccepted(IWebElement _element,string FutureDate)
       {
           bool isValid = false;
           //   var backdate = "09-10-2018";
           _element.SendKeys("FutureDate");
           if (_element.Text != "")
               isValid = true;
           else
               isValid = false;

           return isValid;
       }
    }
}
