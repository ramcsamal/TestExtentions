using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestExtentions.Common;

namespace TestExtentions.Validations.Contols
{
    public class TextBoxValidation
    {

        public bool AllowBlankText(IWebElement _element)
        {
            bool isValid = false;
            _element.SendKeys("");
            if (_element.Text == "")
                isValid = true;
            else
                isValid = false;

            return isValid;

        }
        public bool AllowOnlyNummericText(IWebElement _element)
        {
            bool isValid = false;

            String numericString = StringUtility.GetRandomizeString(StringType.NumericString, 100);
            _element.SendKeys(numericString);
            if (_element.Text == numericString)
            {
                String nonNumericString = StringUtility.GetRandomizeString(StringType.AlphaNonNumericString, 100);
                _element.SendKeys(nonNumericString);
                if (_element.Text == nonNumericString)
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }
            else
            {
                isValid = false;
            }

            return isValid;

        }

        public bool AllowonlyAlphaNonNumerictext(IWebElement _element)
        {
            bool isvalid = false;
            String AlphaNonNumericString = StringUtility.GetRandomizeString(StringType.AlphaNonNumericString, 100);
            _element.SendKeys(AlphaNonNumericString);
            if (_element.Text == AlphaNonNumericString)
            {
                String NumericString = StringUtility.GetRandomizeString(StringType.NumericString, 100);
                _element.SendKeys(NumericString);
                if (_element.Text == NumericString)
                {
                    isvalid = false;
                }
                else
                {
                    isvalid = true;
                }
            }
            else
            {
                isvalid = false;
            }

            return isvalid;
        }

        public bool AllowAlphanumerictext(IWebElement _element)
        {
            bool isValid = false;
            string alphanumericstring = StringUtility.GetRandomizeString(StringType.AlphaNumericString, 100);
            _element.SendKeys(alphanumericstring);
            if (_element.Text == alphanumericstring)
                isValid = true;
            else
                isValid = false;

            return isValid;
        }

        public bool Specialcharnotallowinitialplace(IWebElement _element)
        {
            bool isValid = false;
            string specialchar = StringUtility.GetRandomizeString(StringType.specialcharinitialplace, 100);
            _element.SendKeys(specialchar);
            if (_element.Text == specialchar)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }

        public bool Whitespacenotallowinitialplace(IWebElement _element)
        {
            bool isValid = false;
            string whitespace = StringUtility.GetRandomizeString(StringType.whitespaceinitialplace, 100);
            _element.SendKeys(whitespace);
            if (_element.Text == whitespace)
                isValid = false;
            else
                isValid = true;

            return isValid;

        }

        public bool Allowonly100AlphaNonNumericChar(IWebElement _element)
        {
            bool isValid = false;
            string allow100alphanonnumericchar = StringUtility.GetRandomizeString(StringType.AlphaNonNumericString, 120);
            _element.SendKeys(allow100alphanonnumericchar);
            if (_element.Text == allow100alphanonnumericchar)
                isValid = false;
            else
                isValid = true;
            return isValid;
        }
        public bool Allowonly100AlphaNumericChar(IWebElement _element)
        {
            bool isValid = false;
            string allow100alphanonnumericchar = StringUtility.GetRandomizeString(StringType.AlphaNonNumericString, 100);
            _element.SendKeys(allow100alphanonnumericchar);
            if (_element.Text == allow100alphanonnumericchar)
                isValid = true;
            else
                isValid = false;

            return isValid;
        }

        public bool ValidMobileNumber(IWebElement _element)
        {
            bool isValid = false;
            string mobilenumber = StringUtility.GetRandomizeString(StringType.NumericString, 10);
            _element.SendKeys(mobilenumber);
            if (_element.Text == mobilenumber)
                isValid = true;
            else
                isValid = false;

            return isValid;
        }

        public bool ValidMobileNumberCheck(IWebElement _element)
        {
            bool isValid = false;
            string mobilenumbercheck = StringUtility.GetRandomizeString(StringType.NumericString, 8);
            _element.SendKeys(mobilenumbercheck);
            if (_element.Text == mobilenumbercheck)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }

        public bool ShouldNotMoreThan10DigitMobileNumber(IWebElement _element)
        {
            bool isValid = false;
            string mobilenumber = StringUtility.GetRandomizeString(StringType.NumericString, 12);
            _element.SendKeys(mobilenumber);
            if (_element.Text == mobilenumber)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }

        public bool ValidAadharNumber(IWebElement _element)
        {
            bool isValid = false;
            string mobilenumber = StringUtility.GetRandomizeString(StringType.NumericString, 12);
            _element.SendKeys(mobilenumber);
            if (_element.Text == mobilenumber)
                isValid = true;
            else
                isValid = false;

            return isValid;
        }
        public bool NotAcceptLessThan12DigitAadharNumber(IWebElement _element)
        {
            bool isValid = false;
            string mobilenumbercheck = StringUtility.GetRandomizeString(StringType.NumericString, 11);
            _element.SendKeys(mobilenumbercheck);
            if (_element.Text == mobilenumbercheck)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }
        public bool ShouldNotMoreThan12DigitAadharNumber(IWebElement _element)
        {
            bool isValid = false;
            string mobilenumber = StringUtility.GetRandomizeString(StringType.NumericString, 13);
            _element.SendKeys(mobilenumber);
            if (_element.Text == mobilenumber)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }


        public bool ValidEmailAddress(IWebElement _element,string email)
        {
            bool isVlaid = false;
            isVlaid = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            _element.SendKeys(email);
            if (_element.Text == email)
                isVlaid = false;
            else
                isVlaid = true;
            return isVlaid;
        }

    }
}
