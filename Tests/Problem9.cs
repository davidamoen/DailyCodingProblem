using DailyCodingProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class Problem9
    {
        [Fact]
        public void Problem9_Handles_First_Example_Correctly()
        {
            // arrange
            var arr = new List<int>() { 2, 4, 6, 2, 5 };

            // act
            var result = Helpers.Problem9(arr);

            // assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Problem9_Handles_Second_Example_Correctly()
        {
            // arrange
            var arr = new int[] { 5, 1, 1, 5 };

            // act
            var result = Helpers.Problem4(arr);

            // assert
            Assert.Equal(10, result);
        }
    }
}
