using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCollectionOrderer("xUnitSandbox.OrderTests.OrderTestCollection", "xUnitSandbox.OrderTests")]