using Xunit.Abstractions;
using Xunit.Sdk;

namespace SqlDataExample
{
    public class DataAdapterDataAttributeDiscoverer : DataDiscoverer
    {
        public override bool SupportsDiscoveryEnumeration(IAttributeInfo dataAttribute, IMethodInfo testMethod)
            => dataAttribute.GetNamedArgument<bool>("EnableDiscoveryEnumeration");
    }
}
