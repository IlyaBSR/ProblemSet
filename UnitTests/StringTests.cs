using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void AllUniqueFalse()
        {
            // Arrange
            string s = "hello";
            
            // Act
            bool result = StringMethods.AllUniqueCharacters(s);

            // Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void AllUniqueTrue()
        {
            // Arrange
            string s = "Quickbrown";

            // Act
            bool result = StringMethods.AllUniqueCharacters(s);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void ReverseString()
        {
            // Arrange
            string s = "abcd";

            // Act
            string output = StringMethods.ReverseString(s);

            // Assert
            Assert.AreEqual(output == "dcba", true);
        }

        [TestMethod]
        public void PermutationsTrue()
        {
            // Arrange
            string a = "abcde ";
            string b = "cd abe";

            // Act
            bool result = StringMethods.ArePermutations(a, b);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PermutationsDifferentSize()
        {
            // Arrange
            string a = "abcde ";
            string b = "cd abe ";

            // Act
            bool result = StringMethods.ArePermutations(a, b);

            // Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void PermutationsFalse()
        {
            // Arrange
            string a = "abcde ";
            string b = "cdabee";

            // Act
            bool result = StringMethods.ArePermutations(a, b);

            // Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsRotationTrue()
        {
            // Arrange 
            string a = "abcd";
            string b = "bcda";

            // Act
            bool result = StringMethods.IsRotation(a, b);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsRotationFalse()
        {
            // Arrange 
            string a = "abcd";
            string b = "dcad";

            // Act
            bool result = StringMethods.IsRotation(a, b);

            // Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void AllPermutations_Basic()
        {
            // Arrange
            string input = "abcd";

            // Act
            HashSet<string> output = StringMethods.AllPermutations(input);

            // Assert
            Assert.IsTrue(output.Contains("abcd") && output.Contains("abdc") && output.Contains("acbd") 
                && output.Contains("acdb")
                && output.Contains("adbc") && output.Contains("adcb"));

            Assert.AreEqual(24, output.Count);

        }

        [TestMethod]
        public void IsPalandromic_basics()
        {
            // Arrange
            string input1 = "A man, a plan, a canal, Panama";
            string input2 = "Able was I, ere I saw Elba!";
            string input3 = "Boy am I happy!";
            string input4 = "_ab_!b@a.";
            
            // Act
            bool output1 = StringMethods.IsPalindromic(input1);
            bool output2 = StringMethods.IsPalindromic(input2);
            bool output3 = StringMethods.IsPalindromic(input3);
            bool output4 = StringMethods.IsPalindromic(input4);
            
            // Assert
            Assert.IsTrue(output1);
            Assert.IsTrue(output2);
            Assert.IsFalse(output3);
            Assert.IsTrue(output4);
        }

        [TestMethod]
        public void HasBalancedDelimiters()
        {
            // Arrange
            string input1 = "(){}";
            string input2 = "([{}])";
            string input3 = "({})";
            string input4 = "([)]";
            string input5 = "(";
            string input6 = ")}";

            // Act
            bool output1 = StringMethods.HasBalancedDelimiters(input1);
            bool output2 = StringMethods.HasBalancedDelimiters(input2);
            bool output3 = StringMethods.HasBalancedDelimiters(input3);
            bool output4 = StringMethods.HasBalancedDelimiters(input4);
            bool output5 = StringMethods.HasBalancedDelimiters(input5);
            bool output6 = StringMethods.HasBalancedDelimiters(input6);

            // Assert
            Assert.IsTrue(output1);
            Assert.IsTrue(output2);
            Assert.IsTrue(output3);
            Assert.IsFalse(output4);
            Assert.IsFalse(output5);
            Assert.IsFalse(output6);
        }

        [TestMethod]
        public void ReverseWord()
        {
            // Arrange
            string input1 = "Alice likes Bob";
            string input2 = "  Bob really really is about Alice";

            // Act
            string output1 = StringMethods.ReverseWords(input1);
            string output2 = StringMethods.ReverseWords(input2);
           
            // Assert
            Assert.AreEqual("Bob likes Alice", output1);
            Assert.AreEqual("Alice about is really really Bob  ", output2);
        }
    }
}
