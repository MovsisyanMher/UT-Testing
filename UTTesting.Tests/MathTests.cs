using UTTesting;
using Xunit;

namespace UTTesting.Tests
{
    /// <summary>
    /// A collection of tests for the Math library
    /// </summary>
    public class MathTests
    {
        [Theory]
        [InlineData(1, 1)]              // Normal Data
        [InlineData(2, 2)]              // Normal Data
        [InlineData(3, 6)]              // Normal Data
        [InlineData(4, 24)]             // Normal Data
        [InlineData(5, 120)]            // Normal Data
        [InlineData(6, 720)]            // Normal Data
        [InlineData(7, 5_040)]          // Normal Data
        [InlineData(8, 40_320)]         // Normal Data
        [InlineData(9, 362_880)]        // Normal Data
        [InlineData(10, 3_628_800)]     // Normal Data
        [InlineData(11, 39_916_800)]    // Normal Data
        [InlineData(12, 479_001_600)]   // Normal Data
        [InlineData(0, 1)]              // Special Data
        [InlineData(-4, -1)]            // Out of Bounds Data
        [InlineData(13, -1)]            // Out of Bounds Data
        [InlineData(int.MaxValue, -1)]  // Out of Bounds Data
        [InlineData(int.MinValue, -1)]  // Out of Bounds Data
        public void Factorial_ShouldCalculateInts(int input, int expected)
        {
            Assert.Equal(expected, Math.Factorial(input));
        }

        
        [Theory]
        [InlineData(1, 1)]             // Normal Data
        [InlineData(2, 3)]             // Normal Data
        [InlineData(3, 6)]             // Normal Data
        [InlineData(4, 10)]            // Normal Data
        [InlineData(0, 0)]             // Normal Data
        [InlineData(-4, -1)]
        // So on...
        public void Sigma_ShouldCalculateInts(int input, int expected)
        {
            Assert.Equal(expected, Math.Sigma(input));
        }
    }
}
