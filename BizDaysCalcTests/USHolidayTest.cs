using System;
using System.Collections.Generic;
using BizDaysCalc;
using Xunit;

namespace BizDaysCalcTests
{
    public class USHolidayTest
    {
        private Calculator _calculator;
        public USHolidayTest()
        {
            _calculator = new Calculator();
            _calculator.AddRule(new HolidayRule());
            Console.WriteLine("In USHolidayTest constructor");
        }

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

        [Xunit.Theory]
        [InlineData("2021-04-20")]
        [InlineData("2021-04-21")]
        public void TestNonHolidays(string date)
        {
            Assert.True(_calculator.IsBusinessDay(DateTime.Parse(date)));
            Console.WriteLine($"In TestNonHolidays {date}");
        }

        [Theory]
        [MemberData(nameof(Holidays))]
        public void TestHolidays(DateTime date)
        {
            Assert.False(_calculator.IsBusinessDay(date));
            Console.WriteLine($"In TestHolidays {date:yyyy-MM-dd}");
        }
    }
}
