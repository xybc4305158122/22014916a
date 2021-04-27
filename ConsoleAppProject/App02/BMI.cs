using System;
namespace ConsoleAppProject.App02
{
    /// This app is a bmi calculator which calculates your 
    /// Body Mass Index by looking at your height and weight.
    /// <AbdulSalam>
    /// Abdul Salam version 0.1
    public class BMI
    {
        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;
        double weightImperial { get; set; }
        double heightImperial { get; set; }
        string unitChoice { get; set; }
        double heightInFeet { get; set; }
        double heightInInches { get; set; }
        double heightInMetres { get; set; }
        double weightInStones { get; set; }
        double weightInPounds { get; set; }
        double weightInKg { get; set; }
        double imperialBMI { get; set; }
        double metricBMI { get; set; }

        public UnitSystems UnitSystems 
        {
            get => default;
        }

        public void Run()
        {
            OutputHeading();
            DisplayTypeOfUnit();
            PrintEthnicMessage();
        }

        private void OutputHeading()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("        Body Mass Index Calculator" + "\n             by Abdul Salam\n");
            Console.WriteLine("-------------------------------------------------");
        }

        private void DisplayTypeOfUnit()
        {
            Console.WriteLine("1. Metric Units\n2. Imperial Units\n Please enter your choice >");
            unitChoice = Console.ReadLine();

            if (unitChoice == "1")
            {
                Console.WriteLine("Enter your height in the nearest height in metres ");
                Console.Write("Enter your height in metres> ");
                string height = Console.ReadLine();
                heightInMetres = Convert.ToDouble(height);
                Console.Write("Enter your weight in kg> ");
                string kg = Console.ReadLine();
                weightInKg = Convert.ToDouble(kg);
                CalculateMetricFormula();
                DisplayBMI(metricBMI);
            }

            else if (unitChoice == "2")
            {
                Console.WriteLine("Enter your height in the nearest feet and inches \n ");
                Console.Write("Enter your height in feet> ");
                string height = Console.ReadLine();
                heightInFeet = Convert.ToDouble(height);

                Console.Write("Enter your height in inches> ");
                string inches = Console.ReadLine();
                heightInInches = Convert.ToDouble(inches);

                Console.WriteLine("\n Enter your weight to the nearest stones and pounds ");
                Console.Write("Enter your weight in stones> ");
                string stones = Console.ReadLine();
                weightInStones = Convert.ToDouble(stones);

                Console.Write("Enter your weight in pounds> ");
                string pounds = Console.ReadLine();
                weightInPounds = Convert.ToDouble(pounds);

                CalculateImperialFormula();
                DisplayBMI(imperialBMI);
            }
            else
            {
                Console.WriteLine("Please select either 1 or 2 ");
            }
        }
       
        public void CalculateImperialFormula()
        {
            double Pounds = weightInStones * PoundsInStones;
            weightImperial = weightInPounds + Pounds;

            double inches = heightInFeet * InchesInFeet;
            heightImperial = heightInInches + inches;

            imperialBMI = (weightImperial * 703) / (heightImperial * heightImperial);
        }
       
        public void CalculateMetricFormula()
        {
            metricBMI = (weightInKg) / (heightInMetres * heightInMetres);
        }

        private void DisplayBMI(double BMI)
        {
            if (BMI < 18.5)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are undeweight");
            }

            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Normal" );
            }

            else if (BMI >= 25.0 && BMI <= 29.9)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Overweight");
            }

            else if (BMI >= 30.0 && BMI <= 34.9)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Obese Class 1");
            }

            else if (BMI >= 35.0 && BMI <= 39.9)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Obese Class 2");
            }

            else if (BMI >= 40.0)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Obese Class 3");
            }
        }
        private void PrintEthnicMessage()
        {
            Console.WriteLine("\nIf you are Black, Asian or minority ethnic groups, you have a risk");
            Console.WriteLine("Adults 23.0 or more are at increased risk \nAdults 27.5 or more at high risk");
        }
    }
}
    

