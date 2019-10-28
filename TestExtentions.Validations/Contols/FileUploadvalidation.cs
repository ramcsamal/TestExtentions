using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExtentions.Validations.Contols
{
    public class FileUploadvalidation
    {
       public bool AllowBlankImageField(IWebElement _element)
       {
           bool isValid = false;
           _element.SendKeys("");
           if (_element.Text == "")
               isValid = true;
           else
               isValid = false;

           return isValid;

       }
       public bool Imagesizeupto1mb(IWebElement _element,string Path)
       {
           bool isValid = false;
           _element.SendKeys(Path);
           if (_element.Text == Path)
               isValid = true;
           else
               isValid = false;

            return isValid;
        }
        public bool ImageSizeNotExceed1mb(IWebElement _element, string Path)
        {
            bool isValid = false;
            _element.SendKeys(Path);
            if (_element.Text == Path)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }
    }
}
