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
        public static List<int> EnumerateAllPrimes(int n)
        {
            if (n < 2)
            { 
                return null; 
            }

            HashSet<int> knownPrimes = new HashSet<int>();
            knownPrimes.Add(2);

            for (int i = 3; i <= n; i += 2)
            {
                bool isPrime = true;
                foreach (int prime in knownPrimes)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    knownPrimes.Add(i);
                }
            }

                return knownPrimes.ToList();
        }

        public static List<int> EnumerateAllPrimesDeux(int n)
        {
            if (n < 2) return null;

            int[] allPrimes = new int[n + 1];

            allPrimes[0] = -1;
            allPrimes[1] = -1;
            allPrimes[2] = 1;

            return new List<int>();
        }
    }
}
