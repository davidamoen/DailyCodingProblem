using DailyCodingProblem;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class Problem2
    {
        [Fact]
        public void Problem2_Returns_Correct_Array_Example1()
        {
            // arrange
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var expected = new int[] { 120, 60, 40, 30, 24 };

            // act
            var result = Helpers.Problem2(arr);

            // Assert
            Assert.True(result.SequenceEqual(expected));
        }

        [Fact]
        public void Problem2_Returns_Correct_Array_Example2()
        {
            // arrange
            var arr = new int[] { 3, 2, 1 };
            var expected = new int[] { 2, 3, 6 };

            // act
            var result = Helpers.Problem2(arr);

            // Assert
            Assert.True(result.SequenceEqual(expected));
        }
    }
}
