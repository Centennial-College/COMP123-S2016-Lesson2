using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson2;

namespace UnitTestForLesson2
{
    [TestClass]
    public class UnitTestFoRlesson2
    {
        [TestMethod]
        public void addXandYTestMethod()
        {
            // Arrange
            int x = 50;
            int y = 40;
            int expectedResult = 90;

            // Act
            int result = Program.addXandY(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void addYtoXTestMethod()
        {
            // Arrange
            int x = 50;
            int y = 40;
            int expectedResult = 90;

            // Act
            int result = Program.addYtoX(ref x, ref y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
