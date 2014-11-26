using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSet
{
    public class InterviewProblem
    {
        /* Given an integer numerator and integer denominator, print rational number 
         * in its decimal form with repetitions marked by brackets. For example:
             1, 3 => 0.33333 => 0.(3)
            10, 3 => 3.(3)
             1, 11 => 0.0909 => 0.(09)
             1, 30 => 0.0(3)
             1, 300 => 0.00(3)
             1, 2 => 0.5(0) */
        public static string GetRationalDecimal(int num, int den)
        {
            // using StringBuilder due to constant need to update the output string
            StringBuilder output = new StringBuilder();
            output.Append(num * den >= 0 ? "" : "-");

            // Storing the remainders encountered and their locations in the output string
            Dictionary<int, int> mapToLocation = new Dictionary<int, int>();

            int multiplier = num / den;

            // Setting values to absolute so sign would not interfere with calculations
            int remainder = Math.Abs(num % den);
            den = Math.Abs(den);

            // Append the content before the decimal point
            output.Append(multiplier);
            output.Append(".");

            while (true)
            {
                // If we encounter a remainder already found in the dictionary 
                // append a ')' to the end and insert a '(' in the location in the dictionary
                if (mapToLocation.ContainsKey(remainder))
                {
                    output.Append(")");
                    output.Insert(mapToLocation[remainder], "(");
                    return output.ToString();
                }

                // Add unencountered remainder to the dictionary
                mapToLocation.Add(remainder, output.Length);

                if (remainder < den)
                {
                    remainder *= 10;
                }
                
                output.Append(remainder / den);
                remainder %= den;
            }
        }
    }
}
