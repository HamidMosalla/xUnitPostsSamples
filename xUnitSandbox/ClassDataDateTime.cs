using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace xUnitSandbox
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]{ new DateTime(2001, 12, 2), new DateTime(2000, 12, 2), new DateTime(1999, 12, 2), new DateTime(1988, 12, 2) },
            new object[]{ new DateTime(2001, 12, 2), new DateTime(2000, 12, 2), new DateTime(1999, 12, 2), new DateTime(1988, 12, 2) }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class ParameterizedTests
    {
        public bool IsCorrectDate(DateTime datetime)
        {
            return datetime > new DateTime(1900, 1, 1);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void IsCorrectDate_GivenCorrectDate_ReturnsTrue(DateTime a, DateTime b, DateTime c, DateTime d)
        {
            Assert.True(IsCorrectDate(a));
            Assert.True(IsCorrectDate(b));
            Assert.True(IsCorrectDate(c));
            Assert.True(IsCorrectDate(d));
        }
    }
}
