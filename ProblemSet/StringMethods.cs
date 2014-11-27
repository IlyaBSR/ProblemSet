using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    public class StringMethods
    {
        // 1.1 Impliment an algorithm to determine if a string has all 
        // unique characters.  What if you cannot use additional data structures
        public static bool AllUniqueCharacters(string input)
        {
            if (input.Length > 255) return false;

            bool[] chars = new bool[256];
            foreach (char c in input)
            {
                if (chars[c])
                {
                    return false;
                }
                else
                {
                    chars[c] = true;
                }
            }

            return true;
        }

        // 1.2 Reverse a string
        public static string ReverseString(string input)
        {
            StringBuilder sb = new StringBuilder(input);
            
            for (int i = 0; i < sb.Length / 2; i++)
            {
                char c = sb[i];
                sb[i] = sb[sb.Length - i - 1];
                sb[sb.Length - i - 1] = c;
            }

            return sb.ToString();
        }

        // 1.3 Are strings permutations of each other
        public static bool ArePermutations(string a, string b)
        {
            if (a.Length != b.Length) return false;

            int[] A = new int[256];
            int[] B = new int[256];

            for (int i = 0; i < a.Length; i++)
            {
                A[a[i]]++;
                B[b[i]]++;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i]) return false;
            }

            return true;
        }

        // 1.8 Assume you have a method isSubstring which checks if 
        // one word is a substring of another.  Given two strings, 
        // s1 adn s2, write code to check if s2 is a rotation of s1 
        // using only one call to isSubstring.
        public static bool IsRotation(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;
            if (s1.Length != s2.Length) return false;

            StringBuilder sb = new StringBuilder(s2);
            sb.Append(s2);

            return sb.ToString().Contains(s1);
        }


        public static HashSet<string> AllPermutations(string inputString)
        {
            HashSet<string> output = new HashSet<string>();

            if (String.IsNullOrEmpty(inputString))
            {
                return null;
            }
            else if (inputString.Length == 1)
            {
                output.Add(inputString);
            }
            else if (inputString.Length == 2)
            {
                output.Add(inputString);
                output.Add("" + inputString[1] + inputString[0]);
            }
            else
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(inputString.Substring(i + 1));
                    sb.Append(inputString.Substring(0, i));
                    HashSet<string> permutations = AllPermutations(sb.ToString());

                    foreach (string permutation in permutations)
                    {
                        if (!output.Contains(inputString[i] + permutation))
                        {
                            output.Add(inputString[i] + permutation);
                        }
                    }
                }
            }

            return output;
        }
    }
}
