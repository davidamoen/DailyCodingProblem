using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblem
{
    public class Node
    {
        public Node(string val, Node left = null, Node right = null)
        {
            Val = val;
            Left = left;
            Right = right;
        }

        public string Val { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

    }
}
