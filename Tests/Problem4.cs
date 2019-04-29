using DailyCodingProblem;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class Problem4
    {
        [Fact]
        public void Problem4_Handles_First_Example_Correctly()
        {
            // arrange
            var arr = new int[] { 3, 4, -1, 1 };

            // act
            var result = Helpers.Problem4(arr);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Problem4_Handles_Second_Example_Correctly()
        {
            // arrange
            var arr = new int[] { 1, 2, 0 };

            // act
            var result = Helpers.Problem4(arr);

            // assert
            Assert.Equal(3, result);
        }
    }
}
