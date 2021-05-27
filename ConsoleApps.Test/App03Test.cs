using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApps.Test
{
    [TestClass]
    public class App03Test
    {
        private StudentMarks studentMarks = new StudentMarks();

        [TestMethod]
        public void ConvertMarkToGrade0F()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(0);

            // Act

            // Assert

            Assert.AreEqual(Grades.F, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade39F()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(39);

            // Act

            // Assert

            Assert.AreEqual(Grades.F, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade40D()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(40);

            // Act

            // Assert

            Assert.AreEqual(Grades.D, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade49D()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(49);

            // Act

            // Assert

            Assert.AreEqual(Grades.D, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade50C()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(50);

            // Act

            // Assert

            Assert.AreEqual(Grades.C, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade59C()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(59);

            // Act

            // Assert

            Assert.AreEqual(Grades.C, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade60B()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(60);

            // Act

            // Assert

            Assert.AreEqual(Grades.B, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade69B()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(69);

            // Act

            // Assert

            Assert.AreEqual(Grades.B, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade70A()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(70);

            // Act

            // Assert

            Assert.AreEqual(Grades.A, actualGrade);
        }

        [TestMethod]
        public void ConvertMarkToGrade100A()
        {
            // Arrange
            Grades actualGrade = studentMarks.CalculateGrade(100);

            // Act

            // Assert

            Assert.AreEqual(Grades.A, actualGrade);
        }
    }
}
