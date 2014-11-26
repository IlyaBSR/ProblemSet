using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;

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
    }
}
