using System;
using Xunit;

namespace xUnitSandbox
{
    public class SuperHeavyWeightFixture : IDisposable
    {
        public SuperHeavyWeight Sut { get; private set; }

        public SuperHeavyWeightFixture()
        {
            Sut = new SuperHeavyWeight();
        }

        public void Dispose()
        {
            Sut.Dispose();
        }
    }

    public class SuperHeavyWeightTests : IClassFixture<SuperHeavyWeightFixture>
    {
        private readonly SuperHeavyWeightFixture _fixture;

        public SuperHeavyWeightTests(SuperHeavyWeightFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CalculationOne_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _fixture.Sut.CalculationOne(2);

            Assert.Equal(Math.PI * 2, result);
        }

        [Fact]
        public void CalculationTwo_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _fixture.Sut.CalculationOne(5);

            Assert.Equal(Math.PI * 5, result);
        }

        [Fact]
        public void CalculationThree_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _fixture.Sut.CalculationOne(7);

            Assert.Equal(Math.PI * 7, result);
        }
    }
}
