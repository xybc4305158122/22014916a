using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

/*namespace ConsoleApps.Test
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;
            converter.InputDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 5280;

            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);

        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;
            converter.InputDistance = 5280;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METRES;
            converter.InputDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.MILES;
            converter.InputDistance = 1609.34;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;
            converter.InputDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 3.28;

            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METRES;
            converter.InputDistance = 3.28;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }

    }
}
*/