using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class DynamicProblemTests
    {
        [TestMethod]
        public void PossibleStepsDP_Basic()
        {
            // Assert
            Assert.AreEqual(1, DynamicProblems.PossibleWays(1));
            Assert.AreEqual(2, DynamicProblems.PossibleWays(2));
            Assert.AreEqual(4, DynamicProblems.PossibleWays(3));
            Assert.AreEqual(7, DynamicProblems.PossibleWays(4));
            Assert.AreEqual(0, DynamicProblems.PossibleWays(0));
        }

        [TestMethod]
        public void EnumeratePrimesDP_Basic()
        {
            // Act
            List<int> output = DynamicProblems.EnumerateAllPrimes(25);
            
            //Assert
            Assert.IsTrue(output.Contains(2) && output.Contains(3) && output.Contains(5)
                && output.Contains(7) && output.Contains(11) && output.Contains(13)
                && output.Contains(17) && output.Contains(19) && output.Contains(23));
            Assert.AreEqual(9, output.Count);
        }

        [TestMethod]
        public void EnumeratePrimesDeuxDP_Basic()
        {
            // Act
            List<int> output = DynamicProblems.EnumerateAllPrimesDeux(25);

            //Assert
            Assert.IsTrue(output.Contains(2) && output.Contains(3) && output.Contains(5)
                && output.Contains(7) && output.Contains(11) && output.Contains(13)
                && output.Contains(17) && output.Contains(19) && output.Contains(23));
            Assert.AreEqual(9, output.Count);
        }
    }
}
