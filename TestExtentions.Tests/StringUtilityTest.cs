using NUnit.Framework;
using TestExtentions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestExtentions.Common.Tests
{
    [TestFixture()]
    public class StringUtilityTest
    {
        [Test()]
        public void GetRandomizeString_Default_Test()
        {
            var anyString = StringUtility.GetRandomizeString();

            if (anyString.Length == 10)
                Assert.Pass("GetRandomizeString: Default Length = 10");
            else
                Assert.Fail("GetRandomizeString: Default Length <> 10");
        }


        [Test()]
        public void GetRandomizeString_Length_Test()
        {
            var length = 50;
            var anyString = StringUtility.GetRandomizeString(length: length);

            if (anyString.Length == length)
                Assert.Pass("GetRandomizeString: New Length = {0}", length);
            else
                Assert.Fail("GetRandomizeString: New Length <> {0}", length);
        }

        [Test()]
        public void GetRandomizeString_NumericType_Test()
        {
            var length = 10;   
            var numericString = StringUtility.GetRandomizeString(StringType.NumericString);

            if (numericString.Length == length && 
                numericString.All(x => StringUtility.NumericString.Contains(x)))
            {

                Assert.Pass("GetRandomizeString: Default Length = {0}", length);
            }
            else
            {
                Assert.Fail("GetRandomizeString: Default Length <> {0}", length);
            }
        }

        [Test()]
        public void GetRandomizeString_AlphaNumericType_Length_Test()
        {
            var length = 35;

            var alphaNumericString = StringUtility.GetRandomizeString(StringType.AlphaNumericString, length);

            if (alphaNumericString.Length == length &&
                alphaNumericString.All(x => StringUtility.AlphaNumericString.Contains(x)))
            {

                Assert.Pass("GetRandomizeString: Default Length = {0}", length);
            }
            else
            {
                Assert.Fail("GetRandomizeString: Default Length <> {0}", length);
            }
        }
        [Test()]
        public void GetStringByStringTypeTest()
        {
            Assert.Fail();
        }
    }
}