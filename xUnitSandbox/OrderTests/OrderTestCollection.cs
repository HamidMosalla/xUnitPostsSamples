using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace xUnitSandbox.OrderTests
{
    public class OrderTestCollection : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            var orderedCollection =  testCollections.OrderByDescending(a => a.DisplayName);

            return orderedCollection;
        }
    }
}
