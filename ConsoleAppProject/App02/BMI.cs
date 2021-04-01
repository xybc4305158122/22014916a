using System;
namespace ConsoleAppProject.App02
{
    /// This app is a bmi calculator which calculates your 
    /// Body Mass Index by looking at your height and weight.
    /// <AbdulSalam>
    /// Abdul Salam version 0.1
    public class BMI
    {
        double weightImperial;
        double heightImperial;
        double weightMetric;
        double heightMetric;
        string unitChoice;
        double heightInFeet;
        double heightInInches;
        double heightInMetres;
        double weightInStones;
        double weightInPounds;
        double weightInKg;
        double imperialBMI;
        double metricBMI;


        public void Run()
        {
            OutputHeading();
            TypeOfUnit();
            CalculateBMI();
        }

        private void OutputHeading()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("        Body Mass Index Calculator" + "\n             by Abdul Salam\n");
            Console.WriteLine("-------------------------------------------------");
        }


        private void TypeOfUnit()
        {
            Console.WriteLine(" 1. Metric Units ");
            Console.WriteLine(" 2. Imperial Units ");
            Console.Write(" Please enter your choice >");
            unitChoice = Console.ReadLine();

            if (unitChoice == "1")
            {
                Console.WriteLine("Enter your height in the nearest height in metres ");
                Console.Write("Enter your height in metres> ");
                string heightm = Console.ReadLine();
                heightInMetres = Convert.ToDouble(heightm);
                Console.Write("Enter your weight in kg> ");
                string kg = Console.ReadLine();
                weightInKg = Convert.ToDouble(kg);
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (unitChoice == "2")
            {
                Console.WriteLine("Enter your height in the nearest feet and inches \n \n ");
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

            }

            else
            {
                Console.WriteLine("\n Please select either 1 or 2 ");
            }


            Console.WriteLine("\n \n 1. Metric Units ");
            Console.WriteLine(" 2. Imperial Units ");
            Console.Write(" Please enter your choice >");
            unitChoice = Console.ReadLine();
            
            heightMetric = heightInMetres;
            weightMetric = weightInKg;

            heightImperial = heightInFeet + heightInInches;
            weightImperial = weightInStones + weightInPounds;

            metricBMI = weightInKg / Math.Pow(heightInMetres, 2);

            imperialBMI = (weightInStones + weightInPounds) / Math.Pow((heightInFeet + heightInInches), 2);
        }

        private void CalculateBMI()
        {
            heightMetric = heightInMetres;
            weightMetric = weightInKg;

            heightImperial = heightInFeet + heightInInches;
            weightImperial = weightInStones + weightInPounds;

            metricBMI = weightInKg / Math.Pow(heightInMetres, 2);

            imperialBMI = (weightInStones + weightInPounds) / Math.Pow((heightInFeet + heightInInches), 2);

            if (imperialBMI < 18.5 || metricBMI < 18.5)
            {
                Console.WriteLine("You are undeweight");
            }

            else if (imperialBMI == 18.5 && imperialBMI <= 24.9 || metricBMI == 18.5 && metricBMI <= 24.9)
            {
                Console.WriteLine("You are Normal");
            }

            else if (imperialBMI == 25.0 && imperialBMI <= 29.9 || metricBMI == 25.0 && metricBMI <= 29.9)
            {
                Console.WriteLine("You are overweight");
            }

            else if (imperialBMI == 30.0 && imperialBMI <= 34.9 || metricBMI == 30.0 && metricBMI <= 34.9)
            {
                Console.WriteLine("You are obese Class 1");
            }

            else if (imperialBMI == 35.0 && imperialBMI <= 39.9 || metricBMI == 35.0 && metricBMI <= 39.9)
            {
                Console.WriteLine("You are Obese Class 2");
            }

            else if (imperialBMI >= 40.0 || metricBMI >= 40.0)
            {
                Console.WriteLine(imperialBMI);
                Console.WriteLine("You are Obese Class 3");
            }

            Console.WriteLine(" If you are Black, Asian or other minority \n " + "ethnic groups, you have a higher risk  ");
            Console.WriteLine("Adults 23.0 or more at increased risk \n Adults 27.5 or more at high risk");
        }
    }
}
