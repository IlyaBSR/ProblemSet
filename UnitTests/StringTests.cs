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
    }
}
