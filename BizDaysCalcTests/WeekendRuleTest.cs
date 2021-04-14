using System;
using Xunit;
using BizDaysCalc;
using System.Collections.Generic;

namespace BizDaysCalcTests
{
    public class WeekendRuleTest
    {
        public static IEnumerable<object[]> Days {
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

        [Fact]
        public void TestCheckIsBusinessDay()
        {
            var rule = new WeekendRule();
            Assert.True(rule.CheckIsBusinessDay(new DateTime(2021, 4, 13)));
            Assert.False(rule.CheckIsBusinessDay(new DateTime(2021, 4, 17)));
        }

        [TheoryAttribute]
        [MemberData(nameof(Days))]
        public void TestMultiCheckIsBusinessDay(bool expected, DateTime date)
        {
            var rule = new WeekendRule();
            Assert.Equal(expected, rule.CheckIsBusinessDay(date));
        }
    }
}
