using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ObservationExample.XunitExtensions
{
    public class ObservationTestCaseOrderer : ITestCaseOrderer
    {
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase
        {
            return testCases;
        }
    }
}
