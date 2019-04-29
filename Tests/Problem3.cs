using DailyCodingProblem;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class Problem3
    {
        [Fact]
        public void Problem3_Handles_Example_Correctly()
        {
            // arrange
            var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));

            // act
            var json = Helpers.Problem3_Serialize(node);
            var newNode = Helpers.Problem3_Deserialize(json);

            // Assert
            Assert.Equal("left.left", newNode.Left.Left.Val);
        }
    }
}
