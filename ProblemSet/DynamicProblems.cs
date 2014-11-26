using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    public class DynamicProblems
    {
        /* CCI 9.1
         * A child is running up a staircase with n steps, and can hop either 1 step, 2 steps
         * or 3 steps at a time. Impliment a method to count how many possible ways the child
         * can run up the stairs
         */
        public static int PossibleWays(int x)
        {
            int[] map = new int[Int16.MaxValue];

            if (x <= 0) return 0;

            return PossibleWaysHelper(x, ref map);
        }

        private static int PossibleWaysHelper(int x, ref int[] map)
        {
            if (x < 0)
            {
                return 0;
            }
            else if (x == 0)
            {
                return 1;
            }
            else if (map[x] > 0)
            {
                return map[x];
            }

            map[x] = PossibleWaysHelper(x - 1, ref map) + PossibleWaysHelper(x - 2, ref map) + PossibleWaysHelper(x - 3, ref map);

            return map[x];
        }

        /* CCI 6.12 Wriate a function that takes a single-positive integer 
         * argument n (n>=2) and return all the primes between 1 and n */
        private static List<int> EnumerateAllPrimes(int n)
        {

        }
    }
}
