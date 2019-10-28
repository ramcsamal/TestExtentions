using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExtentions.Common
{
    public static class StringUtility
    {
        public static String AlphaNonNumericString
        {
            get
            {
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

        }

        public static String AlphaNumericString
        {
            get
            {
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }

        }
        public static String NumericString
        {
            get
            {
                return "1234567890";
            }

        }

        public static String SmallCaseString
        {
            get
            {
                return "abcdefghijklmnopqrstuvwxyz";
            }

        }


        public static String UpperCaseString
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

        }

        public static string specialcharinitialplace
        {
            get
            {
                return "#@$%#%^$^&%&^" + "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }
        }

        public static string whitespaceinitialplace
        {
            get
            {
                return " " + "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }
        }

        public static string BlankField
        {
            get
            {
                return " ";
            }
        }
        public static string GetRandomizeString(StringType stringType = StringType.AlphaNonNumericString, int length=10)
        {
            var stringchar = new char[length];
            var random = new Random();
            String sType = GetStringByStringType(stringType);
            for (int i = 0; i < length; i++)
            {
                stringchar[i] = sType[random.Next(sType.Length)];
            }
            return new String(stringchar);
        }

        public static String GetStringByStringType(StringType _type)
        {
            String returnValue = "";
            switch (_type)
            {
                case StringType.AlphaNonNumericString:
                    returnValue = AlphaNonNumericString;
                    break;
                case StringType.AlphaNumericString:
                    returnValue = AlphaNumericString;
                    break;
                case StringType.NumericString:
                    returnValue = NumericString;
                    break;
                case StringType.SmallCaseString:
                    returnValue = SmallCaseString;
                    break;
                case StringType.UpperCaseString:
                    returnValue = UpperCaseString;
                    break;
                case StringType.specialcharinitialplace:
                    returnValue = specialcharinitialplace;
                    break;
                case StringType.whitespaceinitialplace:
                    returnValue = whitespaceinitialplace;
                    break;
                default:
                    returnValue = AlphaNonNumericString;
                    break;
            }
            return returnValue;
        }
    }
}
