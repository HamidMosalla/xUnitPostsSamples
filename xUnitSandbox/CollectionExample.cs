using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitSandbox
{
    [CollectionDefinition("Heavy Tests Collection")]
    public class HeavyTestCollection : ICollectionFixture<SuperHeavyWeightFixture>
    {

    }

    [Collection("Heavy Tests Collection")]
    public class HeavyTest1
    {
        private readonly SuperHeavyWeightFixture _fixture;

        public HeavyTest1(SuperHeavyWeightFixture fixture)
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

    [Collection("Heavy Tests Collection")]
    public class HeavyTest2
    {
        private readonly SuperHeavyWeightFixture _fixture;

        public HeavyTest2(SuperHeavyWeightFixture fixture)
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
