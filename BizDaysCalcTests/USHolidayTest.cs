using System;
using System.Collections.Generic;
using BizDaysCalc;

namespace BizDaysCalcTests
{
    public class USHolidayTest
    {
        public static IEnumerable<object[]> Holidays
        {
            get {
                yield return new object[] { true, new DateTime(2021, 4, 14) };
                yield return new object[] { true, new DateTime(2021, 4, 15) };
                yield return new object[] { true, new DateTime(2021, 4, 16) };
                yield return new object[] { true, new DateTime(2021, 4, 17) };
                yield return new object[] { true, new DateTime(2021, 4, 18) };
                yield return new object[] { true, new DateTime(2021, 4, 19) };
                yield return new object[] { true, new DateTime(2021, 4, 20) };
                yield return new object[] { true, new DateTime(2021, 4, 21) };
                yield return new object[] { true, new DateTime(2021, 4, 22) };
                yield return new object[] { true, new DateTime(2021, 4, 23) };
            }
        }

        private Calculator calculator;

        public USHolidayTest()
        {
            calculator = new Calculator();
            calculator.AddRule(new HolidayRule());
        }
    }
}
