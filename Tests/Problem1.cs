using DailyCodingProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class Problem1
    {
        [Fact]
        public void Problem1_Performs_Example_Correctly()
        {
            // arrange
            var list = new List<int> { 10, 15, 3, 7 };
            var k = 17;

            // act
            var result = Helpers.Problem1(list, k);

            // Assert
            Assert.True(result);
        }


        [Fact]
        public void Problem1_Returns_False_Appropriately()
        {
            // arrange
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var k = 10;

            // act
            var result = Helpers.Problem1(list, k);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Problem1_Returns_True_Appropriately()
        {
            // arrange
            var list = new List<int> { 10, 30, 55, 67, 1000 };
            var k = 55 + 67;

            // act
            var result = Helpers.Problem1(list, k);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Problem1_Returns_False_When_K_is_Double_of_One_of_the_items()
        {
            // arrange
            var list = new List<int> { 10, 30, 55, 67, 1000 };
            var k = 30 * 2;

            // act
            var result = Helpers.Problem1(list, k);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Problem1_Returns_True_When_K_is_Double_of_One_of_the_items_but_double_is_in_list()
        {
            // arrange
            var list = new List<int> { 10, 30, 45, 50, 1000 };
            var k = 30 * 2;

            // act
            var result = Helpers.Problem1(list, k);

            // Assert
            Assert.True(result);
        }
    }
}
