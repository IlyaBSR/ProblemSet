using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;

namespace UnitTests
{
    [TestClass]
    public class InterviewQuestionUnitTests
    {
        [TestMethod]
        public void GetRationalDecimalTests()
        {
            // Assert
            Assert.AreEqual("-0.5(0)", InterviewProblem.GetRationalDecimal(1, -2));
            Assert.AreEqual("-0.(3)", InterviewProblem.GetRationalDecimal(-1, 3));
            Assert.AreEqual("0.(3)", InterviewProblem.GetRationalDecimal(-1, -3));
            Assert.AreEqual("3.(3)", InterviewProblem.GetRationalDecimal(10, 3));
            Assert.AreEqual("2.(0)", InterviewProblem.GetRationalDecimal(10, 5));
            Assert.AreEqual("33.(3)", InterviewProblem.GetRationalDecimal(100, 3));
            Assert.AreEqual("0.00(3)", InterviewProblem.GetRationalDecimal(1, 300));
            Assert.AreEqual("0.(0)", InterviewProblem.GetRationalDecimal(0, 300));
        }
    }
}
