using Xunit;
using System;
using Xunit.Abstractions;

namespace BizDaysCalcTests
{
    [Collection("US region collection")]
    public class USRegionTest : IClassFixture<USRegionFixture>
    {
        private readonly USRegionFixture fixture;
        private readonly ITestOutputHelper output;

        public USRegionTest(USRegionFixture fixture, ITestOutputHelper output)
        {
            this.fixture = fixture;
            this.output = output;
        }

        [Theory]
        [InlineData("2021-01-01")]
        [InlineData("2021-12-25")]
        public void TestHolidays(string date)
        {
            output.WriteLine($@"TestHolidays(""{date}""),");
            Assert.False(fixture.Calc.IsBusinessDay(DateTime.Parse(date)));
        }

        [Theory]
        [InlineData("2021-02-29")]
        [InlineData("2021-01-04")]
        public void TestNonHolidays(string date)
        {
            output.WriteLine($@"TestNonHolidays(""{date}"")");
            Assert.False(fixture.Calc.IsBusinessDay(DateTime.Parse(date)));
        }
    }
}
