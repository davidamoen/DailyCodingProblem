using Newtonsoft.Json;
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
                        product *= arr[j];
                    }
                }
                result[i] = product;
            }

            return result;
        }

        public static string Problem3_Serialize(Node node)
        {
            return JsonConvert.SerializeObject(node);
        }

        public static Node Problem3_Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Node>(json);
        }

        public static int Problem4(int[] arr)
        {
            var list = arr.ToList();
            list.Sort();

            foreach (var i in list)
            {
                var next = i + 1;

                if (next < 1) continue;

                if (!list.Exists(x => x == next))
                {
                    return next;
                }
            }

            return 0;
        }

        public static int Problem9(List<int> list)
        {
            var combos = new List<List<int>>();

            var counter = 0;

            while (counter < list.Count)
            {
                var combo = new List<int>();
                for (var i = counter; i < list.Count; i += 2)
                {
                    combo.Add(list[i]);

                    if (combo.Count > 1)
                    {
                        combos.Add(combo);
                    }
                }

                counter++;
            }

            return 0;
        }

        public static double Problem14()
        {
            double pi = 0;
            var r = new Random();
            double total = 0;
            double inner = 0;
            var counter = 0;

            while (pi != 3.141592)
            {
                var x = r.NextDouble();
                var y = r.NextDouble();

                if (InCircle(x, y, .5, .5, .5))
                {
                    inner++;
                }
                total++;
                counter++;

                pi = 4 * (inner / total);
                Console.WriteLine($"Current value of Pi: {pi}, Number of points: {counter}");
            }

            return pi;
        }

        private static bool InCircle(double x, double y, double centerX, double centerY, double radius)
        {
            return Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2) < Math.Pow(radius, 2);
        }

        public static double Problem14B()
        {
            double pi = 3;
            var doAdd = true;
            double currentInt = 2;
            var counter = 0;

            while (pi != 3.141592)
            {
                double denominator = currentInt * (currentInt + 1) * (currentInt + 2);
                currentInt += 2;

                if (doAdd)
                {
                    pi += (4 / denominator);
                }
                else
                {
                    pi -= (4 / denominator);
                }

                doAdd = !doAdd;
                counter++;

                Console.WriteLine($"Pi = {pi}, Counter = {counter}");
            }

            return pi;
        }

        public static int Problem15()
        {
            var size = 1000000;
            var list = new List<int>();
            var r = new Random();

            while (list.Count < size)
            {
                list.Add(r.Next(1000000));
            }

            var idx = r.Next(0, size - 1);

            return list[idx];
            
        }
    }
}
