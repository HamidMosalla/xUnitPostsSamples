using System;
using Xunit;
using Xunit.Sdk;

namespace STAExamples
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    [XunitTestCaseDiscoverer("STAExamples.WpfTheoryDiscoverer", "STAExamples")]
    public class WpfTheoryAttribute : TheoryAttribute { }
}
