using System.Linq;
using Xunit;

namespace xUnitSandbox
{
    public class MyArrayTests
    {
        [Fact]
        public void Reverse_GivenAnArray_ReturnsReversedArray()
        {
            var array = new[] {2, 4, 56, 6};

            var sut = new MyArray(array);

            var reversedArray = sut.Reverse().ToArray();

            Assert.Equal(array.Reverse(), reversedArray);
        }
    }
}