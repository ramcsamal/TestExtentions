using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExtentions.Validations.Contols
{
    public class DropdownValidation
    {
        public bool AllowBlankField(IWebElement _element)
        {
            bool isValid = false;
            _element.SendKeys("");
            if (_element.Text == "")
                isValid = true;
            else
                isValid = false;

            return isValid;
        }
        public bool defaultvalueset(IWebElement _element)
        {
            bool isValid = false;
            _element.SendKeys("--Select--");
            if (_element.Text == "--Select--")
                isValid = true;
            else
                isValid = false;

            return isValid;
        }
       public bool datashouldbedisplayeddropdown(IWebElement _element)
       {
           IWebDriver driver = null;
           SelectElement Dropdownfield = new SelectElement(driver.FindElement(By.Id("")));
           IList<IWebElement> ElementCount = Dropdownfield.Options;
           int NumberOfItems = ElementCount.Count;
           bool isValid = false;
           Dictionary<String, bool> OptionsItems = new Dictionary<string, bool>();
           OptionsItems.Add("", false);
           OptionsItems.Add("", false);
           OptionsItems.Add("", false);
           for (int i = 0; i < NumberOfItems; i++)
           {
               String DropDownItems = ElementCount.ElementAt(i).Text;
               //  IWebElement popupText = driver.FindElement(By.Id("selCaste"));
               if (OptionsItems.ContainsKey(DropDownItems))
               {
                   OptionsItems[DropDownItems] = true;
               }
           }
           return isValid;
       }
       public bool SelectedValueShouldBeDisplayed(IWebElement _element)
       {
           bool isValid = false;
           _element.SendKeys("Value");
           if (_element.Text == "Value")
               isValid = true;
           else
               isValid = false;

           return isValid;
       }

    }
}
