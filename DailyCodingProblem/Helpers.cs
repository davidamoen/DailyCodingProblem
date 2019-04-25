using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodingProblem
{
    public class Helpers
    {

        public static bool Problem1(List<int> list, int k)
        {
            foreach (var outer in list)
            {
                foreach (var inner in list)
                {
                    if (inner == outer) continue;

                    if (outer + inner == k) return true;
                }
            }

            return false;
        }

        public static int[] Problem2(int[] arr)
        {
            var len = arr.Length;
            var result = new int[len];

            for (var i = 0; i < len; i++)
            {
                var product = 1;
                for(var j = 0; j < len; j++)
                {
                    if (j != i)
                    {
                        product = product * arr[j];
                    }
                }
                result[i] = product;
            }

            return result;
        }
    }
}
