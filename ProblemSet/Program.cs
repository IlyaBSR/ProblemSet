using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSet.DataStructures;

namespace ProblemSet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> output = DynamicProblems.EnumerateAllPrimes(1000);
            foreach(int i in output)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
