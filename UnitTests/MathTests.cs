using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;

namespace UnitTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void ReverseInt_Basic()
        {
            // Arrange
            uint input = 1234;
            uint expected = 4321;

            // Act
            uint output = MathMethods.ReverseInt(input);
            
            // Assert
            Assert.AreEqual(expected, output);
        }
    }
}
